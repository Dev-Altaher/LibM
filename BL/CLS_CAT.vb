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
        Public Property ID As SqlDbType

        Public Function Load() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADCAT", pr)
            Return dt
        End Function

        Public Sub Insert(CAT_NAME As String)
            Dim pr As SqlParameter() = New SqlParameter(0) {}
            pr(0) = New SqlParameter("CAT_NAME", CAT_NAME)

            DAL.open()
            DAL.Excute("P_ADDCAT", pr)
            DAL.close()
        End Sub
        Public Sub update(CAT_NAME As String)
            Dim pr As SqlParameter() = New SqlParameter(2) {}
            pr(0) = New SqlParameter("CAT_NAME", CAT_NAME)
            pr(1) = New SqlParameter("ID", ID)

            DAL.open()
            DAL.Excute("P_EDITCAT", pr)
            DAL.close()
        End Sub
    End Class
End Namespace