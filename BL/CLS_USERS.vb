Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Namespace LibM.BL


    Public Class CLS_USERS
        Private DAL As New LibM.DAL.CLS_DAL()
        'تحميل البيانات  
        Public Function Load() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADUSER", pr)
            Return dt
        End Function
        Public Sub Insert(CNAME As String, CUSER As String, CPASSWORD As String, CPREM As String)
            Dim pr(5) As SqlParameter
            pr(0) = New SqlParameter("@CNAME", CNAME)
            pr(1) = New SqlParameter("@CUSER", CUSER)
            pr(2) = New SqlParameter("@@CPASSWORD", CPASSWORD)
            pr(3) = New SqlParameter("@CPREM", CPREM)
            DAL.open()
            DAL.Execute("PR_INSERTUSER", pr)
            DAL.close()
        End Sub
        'تحديث  سجل جديد
        Public Sub upadte(CNAME As String, CUSER As String, CPASSWORD As String, CPREM As String, ID As String)
            Dim pr(5) As SqlParameter
            pr(0) = New SqlParameter("@CNAME", CNAME)
            pr(1) = New SqlParameter("@CUSER", CUSER)
            pr(2) = New SqlParameter("@@CPASSWORD", CPASSWORD)
            pr(3) = New SqlParameter("@CPREM", CPREM)
            pr(4) = New SqlParameter("@ID", ID)
            DAL.open()
            DAL.Execute("PR_EDITUSER", pr)
            DAL.close()
        End Sub
    End Class
End Namespace
