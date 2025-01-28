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
Imports System.Data.SqlClient

Public Class FRM_BRO
    Public ID As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub FRM_BRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txt_title.Text = "" Then
            Dim FError As New FRM_ERRORINSERT()
            FError.ShowDialog()
        Else
            Dim title As Integer
            If Integer.TryParse(txt_title.Text, title) Then
                If ID = 0 Then
                    ' Check if there are rows in DataGridView1 and DataGridView2
                    If AreRowsValid() Then
                        ' Add new data
                        Dim BLSEEL As New BL.CLS_BOR()
                        BLSEEL.Insert(Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value), Convert.ToString(DataGridView2.CurrentRow.Cells(0).Value), txt_date.Value.ToString("yyyy-MM-dd"), txt_date2.Value.ToString("yyyy-MM-dd"), txt_title.Text)
                        Dim Fadd As New FRM_DADD()
                        Fadd.Show()
                        Me.Close()
                    End If
                Else
                    If AreRowsValid() Then
                        Dim BLSEEL As New BL.CLS_BOR()
                        BLSEEL.upadte(Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value), Convert.ToString(DataGridView2.CurrentRow.Cells(0).Value), txt_date.Value.ToString("yyyy-MM-dd"), txt_date2.Value.ToString("yyyy-MM-dd"), txt_title.Text, ID)
                        Dim Fadd As New FRM_DEDIT()
                        Fadd.Show()
                        Me.Close()
                    End If
                End If
            Else
                MessageBox.Show("يرجى إدخال قيمة رقمية صحيحة في حقل العنوان.")
            End If
        End If

    End Sub

    Private Function AreRowsValid() As Boolean
        If DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView2.CurrentRow IsNot Nothing Then
            If DataGridView1.CurrentRow.Cells.Count >= 1 AndAlso DataGridView2.CurrentRow.Cells.Count >= 1 Then
                Return True
            Else
                MessageBox.Show("يرجى التأكد من وجود بيانات كافية في الصفوف المحددة.")
            End If
        Else
            MessageBox.Show("يرجى التأكد من وجود بيانات في الجداول.")
        End If
        Return False
    End Function
End Class