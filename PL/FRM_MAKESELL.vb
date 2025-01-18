Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO
Imports LibM.LibM.BL
Imports Bunifu.Framework.UI
Imports LibM.LibM
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FRM_MAKESELL
    Public ID As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub FRM_MAKESELL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BLSELL As New BL.CLS_SELL()
        'Load Books
        Dim dt1 As New DataTable()
        dt1 = BLSELL.loadBOOKS()
        DataGridView2.DataSource = dt1

        Dim dt2 As New DataTable()
        dt2 = BLSELL.loadST()
        DataGridView1.DataSource = dt2


    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txt_title.Text = "" Then
            Dim FError As New FRM_ERRORINSERT()
            FError.ShowDialog()
        Else
            Dim title As Integer
            If Integer.TryParse(txt_title.Text, title) Then
                If ID = 0 Then
                    ' تحقق من وجود صفوف في DataGridView1 و DataGridView2
                    If DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView2.CurrentRow IsNot Nothing Then
                        ' إضافة بيانات جديدة  
                        Dim BLSEEL As New BL.CLS_SELL()
                        BLSEEL.Insert(DataGridView2.CurrentRow.Cells(0).Value, DataGridView1.CurrentRow.Cells(0).Value, title, DateTime.Now.ToString("yyyy-MM-dd"))
                        Dim Fadd As New FRM_DADD()
                        Fadd.Show()
                        ' إعادة تحميل البيانات بعد الإضافة
                        ReloadData()
                        Me.Close()
                    Else
                        MessageBox.Show("يرجى التأكد من وجود بيانات في الجداول.")
                    End If
                Else
                    ' تحديث بيانات موجودة (الكود معلق)
                End If
            Else
                MessageBox.Show("يرجى إدخال قيمة رقمية صحيحة في حقل العنوان.")
            End If
        End If
    End Sub

    Private Sub ReloadData()
        Dim BLSELL As New BL.CLS_SELL()
        'Load Books
        Dim dt1 As New DataTable()
        dt1 = BLSELL.loadBOOKS()
        DataGridView2.DataSource = dt1

        Dim dt2 As New DataTable()
        dt2 = BLSELL.loadST()
        DataGridView1.DataSource = dt2
    End Sub
End Class