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
            Dim pr(4) As SqlParameter
            pr(0) = New SqlParameter("@CNAME", CNAME)
            pr(1) = New SqlParameter("@CUSER", CUSER)
            pr(2) = New SqlParameter("@CPASSWORD", CPASSWORD)
            pr(3) = New SqlParameter("@CPREM", CPREM)
            DAL.open()
            DAL.Execute("PR_INSERTUSER", pr)
            DAL.close()
        End Sub
        'تحديث  سجل جديد
        Public Sub upadte(CNAME As String, CUSER As String, CPASSWORD As String, CPREM As String, ID As Integer)
            Dim pr(5) As SqlParameter
            pr(0) = New SqlParameter("@CNAME", CNAME)
            pr(1) = New SqlParameter("@CUSER", CUSER)
            pr(2) = New SqlParameter("@CPASSWORD", CPASSWORD)
            pr(3) = New SqlParameter("@CPREM", CPREM)
            pr(4) = New SqlParameter("@ID", ID)
            DAL.open()
            DAL.Execute("PR_EDITUSER", pr)
            DAL.close()
        End Sub
        'حذف عملية بيع
        Public Sub Delete(ID As Integer)
            Dim pr As SqlParameter() = New SqlParameter(1) {}
            pr(0) = New SqlParameter("@ID", ID)
            DAL.open()
            DAL.Execute("PR_DELETEUSER", pr)
            DAL.close()
        End Sub
        'تسجيل خروج
        Public Sub Logout()
            Dim pr As SqlParameter() = Nothing
            DAL.open()
            DAL.Execute("PR_LOGOUT", pr)
            DAL.close()
        End Sub
        'تحميل تسجيل الدخول
        Public Function Login(CUSER As String, CPASSWORD As String) As DataTable
            Dim pr(2) As SqlParameter
            pr(0) = New SqlParameter("@CUSER", CUSER)
            pr(1) = New SqlParameter("@CPASSWORD", CPASSWORD)

            Dim dt As New DataTable()
            dt = DAL.read("PR_LOGIN", pr)
            Return dt
        End Function
        'تحديث تسجيل الدخول
        Public Sub upadteLOGIN(CUSER As String, CPASSWORD As String)
            Dim pr(2) As SqlParameter
            pr(0) = New SqlParameter("@CUSER", CUSER)
            pr(1) = New SqlParameter("@CPASSWORD", CPASSWORD)
            DAL.open()
            DAL.Execute("PR_updatelogin", pr)
            DAL.close()
        End Sub
        'تحقق من عملية البدء
        Public Function STARTLOADDTA() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_START", pr)
            Return dt
        End Function
    End Class
End Namespace
