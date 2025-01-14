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
Public Class FRM_ADDBOKKS
    Public ID As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim OFD As New OpenFileDialog()
        If OFD.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OFD.FileName)
        End If

    End Sub
    Private Sub FRM_ADDBOOKS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim BLBOOKS As New BL.CLS_BOOKS()
            Dim dt As New DataTable()
            dt = BLBOOKS.LOADCAT()

            Dim obj(dt.Rows.Count - 1) As Object
            Dim i As Integer

            For i = 0 To dt.Rows.Count - 1
                obj(i) = dt.Rows(i)("CAT_NAME")
            Next

            ComboBox1.Items.AddRange(obj)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim FCAT As New FRM_ADDCAT()
        FCAT.btnadd.ButtonText = "اضافة"
        FCAT.ID = 0
        FCAT.Show()
    End Sub
End Class