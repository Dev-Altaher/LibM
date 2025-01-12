Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient

Namespace LibM.BL
    Public Class CLS_CAT

        Private DAL As New LibM.DAL.CLS_DAL()

        ' تحميل البيانات
        Public Function Load() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADCAT", pr)
            Return dt
        End Function

        ' إضافة سجل جديد
        Public Sub Insert(ByVal CAT_NAME As String)
            Dim pr As SqlParameter() = New SqlParameter(0) {}
            pr(0) = New SqlParameter("@CAT_NAME", CAT_NAME) ' تأكد من استخدام @ إذا كانت مطلوبة في الإجراء المخزن

            DAL.open()
            DAL.Execute("P_ADDCAT", pr)
            DAL.close()
        End Sub

        'تحديث سجل موجود
        Public Sub Update(ByVal CAT_NAME As String, ByVal ID As Integer)
            Dim pr As SqlParameter() = New SqlParameter(1) {}
            pr(0) = New SqlParameter("@CAT_NAME", CAT_NAME) ' تأكد من استخدام @ إذا كانت مطلوبة في الإجراء المخزن
            pr(1) = New SqlParameter("@ID", ID)

            DAL.open()
            DAL.Execute("P_EDITCAT", pr)
            DAL.close()
        End Sub

        'Friend Sub Update(ByVal CAT_NAME As String)
        '    Dim pr As SqlParameter() = New SqlParameter(1) {}
        '    pr(0) = New SqlParameter("@CAT_NAME", CAT_NAME)
        '    pr(1) = New SqlParameter("@ID", ID)

        '    DAL.open()
        '    DAL.Execute("P_EDITCAT", pr)
        '    DAL.close()
        'End Sub
    End Class
End Namespace