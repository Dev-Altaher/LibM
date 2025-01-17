Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Namespace LibM.BL

    Public Class CLS_ST
        Private DAL As New LibM.DAL.CLS_DAL()
        'تحميل البيانات
        Public Function Load() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADST", pr)
            Return dt
        End Function
        ' إضافة سجل جديد
        Public Sub Insert(NAME As String, TLOACTION As String, PHONE As String, EMAIL As String, SCHOOL As String, DEP As String, COVER As MemoryStream)
            Dim pr(7) As SqlParameter
            pr(0) = New SqlParameter("@NAME", NAME)
            pr(1) = New SqlParameter("@TLOACTION", TLOACTION)
            pr(2) = New SqlParameter("@PHONE", PHONE)
            pr(3) = New SqlParameter("@EMAIL", EMAIL)
            pr(4) = New SqlParameter("@SCHOOL", SCHOOL)
            pr(5) = New SqlParameter("@DEP", DEP)
            pr(6) = New SqlParameter("@COVER", COVER.ToArray())
            DAL.open()
            DAL.Execute("PR_INSERTST", pr)
            DAL.close()
        End Sub
        ' تعديل سجل موجود
        Public Function LOADEDIT(ByVal ID As Integer) As DataTable
            Dim pr As SqlParameter() = New SqlParameter(0) {}
            pr(0) = New SqlParameter("@ID", ID)

            Dim dt As New DataTable()
            dt = DAL.read("PR_SELECTEDITST", pr)
            Return dt
        End Function
        'تحديث سجل موجود
        Public Sub Update(NAME As String, TLOACTION As String, PHONE As String, EMAIL As String, SCHOOL As String, DEP As String, COVER As MemoryStream, ID As Integer)
            Dim pr As SqlParameter() = New SqlParameter(8) {}
            pr(0) = New SqlParameter("NAME", NAME)
            pr(1) = New SqlParameter("TLOACTION", TLOACTION)
            pr(2) = New SqlParameter("PHONE", PHONE)
            pr(3) = New SqlParameter("EMAIL", EMAIL)
            pr(4) = New SqlParameter("SCHOOL", SCHOOL)
            pr(5) = New SqlParameter("DEP", DEP)
            pr(6) = New SqlParameter("COVER", COVER.ToArray())
            pr(7) = New SqlParameter("ID", ID)
            DAL.open()
            DAL.Execute("PR_EDITST", pr)
            DAL.close()
        End Sub
        'بحث عن طالب موجود
        Public Function serach(SEARCH As String) As DataTable
            ' إنشاء معلمة @SEARCH
            Dim pr As SqlParameter() = {
                New SqlParameter("SERACH", SqlDbType.NVarChar) With {
                    .Value = SEARCH
                }
            }

            ' قراءة البيانات باستخدام الإجراء المخزن
            Dim dt As New DataTable()
            dt = DAL.read("PR_SERACHST", pr)
            Return dt
        End Function
    End Class
End Namespace
