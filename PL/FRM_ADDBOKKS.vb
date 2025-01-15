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
            cover.Image = Image.FromFile(OFD.FileName)
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

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txt_title.Text = "" Or txt_auther.Text = "" Or txt_price.Text = "" Then
            Dim FError As New FRM_ERRORINSERT()
            FError.ShowDialog()
        Else
            Dim bDate As Object
            If txt_date.Text = "" Then
                bDate = Nothing ' or a default date value like DateTime.Now
            Else
                bDate = txt_date.Value
            End If

            Dim ma As New MemoryStream()
            cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg)

            If ID = 0 Then
                ' إضافة بيانات جديدة
                Dim BLCAT As New BL.CLS_BOOKS()
                BLCAT.Insert(txt_title.Text, txt_auther.Text, ComboBox1.Text, txt_price.Text, If(bDate Is Nothing, "", bDate.ToString()), txt_rate.Value, ma)


                Dim Fadd As New FRM_DADD()
                Fadd.Show()
                Me.Close()
            Else
                Dim maUpdate As New MemoryStream()
                cover.Image.Save(maUpdate, System.Drawing.Imaging.ImageFormat.Jpeg)
                ' تحديث بيانات موجودة
                Dim BLCAT As New BL.CLS_BOOKS()
                BLCAT.Update(txt_title.Text, txt_auther.Text, ComboBox1.Text, txt_price.Text, If(bDate Is Nothing, "", bDate.ToString()), txt_rate.Value, maUpdate, ID)
                Dim FEdit As New FRM_DEDIT()
                FEdit.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class