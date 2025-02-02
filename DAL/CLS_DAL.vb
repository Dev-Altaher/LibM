﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Namespace LibM.DAL
    Class CLS_DAL
        ' تعريف اتصال SQL
        Private con As SqlConnection

        ' تعريف الاتصال بسيرفر قاعدة البيانات مع مسار قاعدة البيانات
        Public Sub New()
            ' مسار قاعدة البيانات المحلية (LocalDB)
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\LibM\DBLIBM.mdf;Integrated Security=True")
        End Sub

        ' وظيفة لفتح اتصال بقاعدة البيانات
        Public Sub open()
            ' التحقق مما إذا كان الاتصال مغلقًا، ثم فتحه
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        End Sub

        ' وظيفة لإغلاق الاتصال بقاعدة البيانات
        Public Sub close()
            ' التحقق مما إذا كان الاتصال مفتوحًا، ثم إغلاقه
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Sub

        ' وظيفة لقراءة البيانات باستخدام إجراء مخزن
        ' store: اسم الإجراء المخزن
        ' pr: قائمة بالمعاملات (Parameters) التي سيتم تمريرها للإجراء
        Public Function read(store As String, pr As SqlParameter()) As DataTable
            ' إنشاء أمر SQL Command
            Dim cmd As New SqlCommand()
            cmd.Connection = con ' تعيين الاتصال
            cmd.CommandType = CommandType.StoredProcedure ' نوع الأمر هو إجراء مخزن
            cmd.CommandText = store ' اسم الإجراء المخزن

            ' إضافة المعاملات إذا وُجدت
            If pr IsNot Nothing Then
                cmd.Parameters.AddRange(pr)
            End If

            ' إنشاء Adapter لملء البيانات في DataTable
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt) ' تعبئة البيانات في DataTable
            Return dt
        End Function


        ' وظيفة لتنفيذ إجراءات مثل الإضافة، التعديل، أو الحذف باستخدام إجراء مخزن
        ' store: اسم الإجراء المخزن
        ' pr: قائمة بالمعاملات (Parameters) التي سيتم تمريرها للإجراء
        Public Sub Execute(store As String, pr() As SqlParameter)
            Using cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = store

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                ' التحقق من المعاملات
                If pr IsNot Nothing AndAlso pr.Length > 0 Then
                    For Each param As SqlParameter In pr
                        If param IsNot Nothing Then
                            If param.Value Is Nothing Then
                                param.Value = DBNull.Value
                            ElseIf TypeOf param.Value Is MemoryStream() Then
                                Dim memoryStreams As MemoryStream() = CType(param.Value, MemoryStream())
                                Dim byteArrays As New List(Of Byte())()
                                For Each ms As MemoryStream In memoryStreams
                                    byteArrays.Add(ms.ToArray())
                                Next
                                param.Value = byteArrays.SelectMany(Function(b) b).ToArray()
                            End If
                            cmd.Parameters.Add(param)
                        End If
                    Next
                Else
                    'Throw New ArgumentException("المعاملات pr فارغة أو غير مهيأة بشكل صحيح.")
                End If

                'تنفيذ الأمر
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As SqlException
                    'Throw New Exception("حدث خطأ أثناء تنفيذ الإجراء المخزن: " & ex.Message, ex)
                End Try
            End Using
        End Sub
    End Class
End Namespace
