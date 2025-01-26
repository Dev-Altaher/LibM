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
        'تحميل 
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
        Public Sub upadte(SNAME As String, BTITLE As String, PRICE As Integer, BDATE As String, ID As Integer)
            Dim pr(5) As SqlParameter
            pr(0) = New SqlParameter("@SNAME", SNAME)
            pr(1) = New SqlParameter("@BTITLE", BTITLE)
            pr(2) = New SqlParameter("@PRICE", PRICE)
            pr(3) = New SqlParameter("@BDATE", BDATE)
            pr(4) = New SqlParameter("@ID", ID)
            DAL.open()
            DAL.Execute("PR_UPDATERTSELL", pr)
            DAL.close()
        End Sub
        'حذف عملية بيع
        Public Sub Delete(ID As Integer)
            Dim pr As SqlParameter() = New SqlParameter(1) {}
            pr(0) = New SqlParameter("@ID", ID)
            DAL.open()
            DAL.Execute("PR_SELLDELETE", pr)
            DAL.close()
        End Sub
        'بحث عن عملية بيع
        Public Function serach(SEARCH As String) As DataTable
            ' إنشاء معلمة @SEARCH
            Dim pr As SqlParameter() = {
                New SqlParameter("@SEARCH", SqlDbType.NVarChar) With {
                    .Value = SEARCH
                }
            }

            ' قراءة البيانات باستخدام الإجراء المخزن
            Dim dt As New DataTable()
            dt = DAL.read("P_BOOKSSEARCH", pr)
            Return dt
        End Function
    End Class
End Namespace