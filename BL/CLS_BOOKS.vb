Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient

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
    End Class
End Namespace