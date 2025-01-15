Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Namespace LibM.BL
    Public Class CLS_BOOKS
        Private DAL As New LibM.DAL.CLS_DAL()
        'تحميل البيانات
        Public Function Load() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADBOOKS", pr)
            Return dt
        End Function
        'بحث عن كتاب موجود
        Public Function LOADCAT() As DataTable
            ' إنشاء معلمة @SEARCH
            Dim pr As SqlParameter() = Nothing
            ' قراءة البيانات باستخدام الإجراء المخزن
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADCATTOCOMBOBOX", pr)
            Return dt
        End Function
        ' إضافة سجل جديد
        Public Sub Insert(TITLE As String, AUTHER As String, CAT As String, PRICE As String, BDATE As String, RATE As Integer, COVER As MemoryStream)
            Dim pr(7) As SqlParameter
            pr(0) = New SqlParameter("TITLE", TITLE)
            pr(1) = New SqlParameter("AUTHER", AUTHER)
            pr(2) = New SqlParameter("CAT", CAT)
            pr(3) = New SqlParameter("PRICE", PRICE)
            pr(4) = New SqlParameter("BDATE", BDATE)
            pr(5) = New SqlParameter("RATE", RATE)
            pr(6) = New SqlParameter("COVER", COVER.ToArray())
            DAL.open()
            DAL.Execute("PR_INSERTBOOKS", pr)
            DAL.close()
        End Sub
        ' تعديل سجل موجود
        Public Function LOADEDIT(ByVal ID As Integer) As DataTable
            Dim pr As SqlParameter() = New SqlParameter(0) {}
            pr(0) = New SqlParameter("ID", ID)

            Dim dt As New DataTable()
            dt = DAL.read("PR_SELECTEDIT", pr)
            Return dt
        End Function
        'تحديث سجل موجود
        Public Sub Update(TITLE As String, AUTHER As String, CAT As String, PRICE As String, BDATE As String, RATE As Integer, COVER As MemoryStream, ID As Integer)
            Dim pr(7) As SqlParameter
            pr(0) = New SqlParameter("TITLE", TITLE)
            pr(1) = New SqlParameter("AUTHER", AUTHER)
            pr(2) = New SqlParameter("CAT", CAT)
            pr(3) = New SqlParameter("PRICE", PRICE)
            pr(4) = New SqlParameter("BDATE", BDATE)
            pr(5) = New SqlParameter("RATE", RATE)
            pr(6) = New SqlParameter("COVER", COVER.ToArray())
            pr(7) = New SqlParameter("ID", ID)
            DAL.open()
            DAL.Execute("PR_EDITBOKKS", pr)
            DAL.close()
        End Sub
    End Class
End Namespace