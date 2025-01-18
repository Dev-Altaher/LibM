Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Namespace LibM.BL
    Public Class CLS_SELL
        Private DAL As New LibM.DAL.CLS_DAL()
        'تحميل البيانات  
        Public Function Load() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADSELL", pr)
            Return dt
        End Function
        'تحميل كتاب  
        Public Function loadBOOKS() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADBOOKFORSELL", pr)
            Return dt
        End Function
        'تحميل طالب  
        Public Function loadST() As DataTable
            Dim pr As SqlParameter() = Nothing
            Dim dt As New DataTable()
            dt = DAL.read("PR_LOADSTFORSELL", pr)
            Return dt
        End Function
        'تحديث سجل جديد  
        Public Sub Insert(SNAME As String, BTITLE As String, PRICE As Integer, BDATE As String)
            Dim pr(4) As SqlParameter
            pr(0) = New SqlParameter("@SNAME", SNAME)
            pr(1) = New SqlParameter("@BTITLE", BTITLE)
            pr(2) = New SqlParameter("@PRICE", PRICE)
            pr(3) = New SqlParameter("@BDATE", BDATE)
            DAL.open()
            DAL.Execute("PR_INSERTSELL", pr)
            DAL.close()
        End Sub
    End Class
End Namespace