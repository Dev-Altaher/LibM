Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Namespace LibM.BL

    Public Class CLS_BOR
        Private DAL As New LibM.DAL.CLS_DAL()
        'تحميل البيانات  
        Public Function Load() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADBOR", pr)
            Return dt
        End Function
        Public Function loadBOOKS() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADBOOKFORSELL", pr)
            Return dt
        End Function
        'تحميل 
        Public Function loadST() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADSTFORSELL", pr)
            Return dt
        End Function
        'تحديث سجل جديد  
        Public Sub Insert(BNAME As String, BTITLE As String, BDATE1 As String, BDATE2 As String, PRICE As String)
            Dim pr(5) As SqlParameter
            pr(0) = New SqlParameter("@BNAME", BNAME)
            pr(1) = New SqlParameter("@BTITLE", BTITLE)
            pr(2) = New SqlParameter("@BDATE1", BDATE1)
            pr(3) = New SqlParameter("@BDATE2", BDATE2)
            pr(4) = New SqlParameter("@PRICE", PRICE)
            DAL.open()
            DAL.Execute("PR_INSERTBOR", pr)
            DAL.close()
        End Sub
    End Class
End Namespace
