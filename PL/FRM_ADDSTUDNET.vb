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
Public Class FRM_ADDSTUDNET
    Public ID As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim OFD As New OpenFileDialog()
        If OFD.ShowDialog() = DialogResult.OK Then
            cover.Image = Image.FromFile(OFD.FileName)
        End If
    End Sub

    Private Sub FRM_ADDSTUDNET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim FCAT As New FRM_ADDCAT()
        FCAT.btnadd.ButtonText = "اضافة"
        FCAT.ID = 0
        FCAT.Show()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txt_name.Text = "" Or txt_loaction.Text = "" Or txt_email.Text = "" Then
            Dim FError As New FRM_ERRORINSERT()
            FError.ShowDialog()
        Else
            Dim ma As New MemoryStream()
            cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg)

            If ID = 0 Then
                ' إضافة بيانات جديدة  
                Dim BLCAT As New BL.CLS_ST()
                BLCAT.Insert(txt_name.Text, txt_loaction.Text, txt_phone.Text, txt_email.Text, txt_school.Text, txt_dept.Text, ma)
                Dim Fadd As New FRM_DADD()
                Fadd.Show()
                Me.Close()
            Else
                Dim maUpdate As New MemoryStream()
                cover.Image.Save(maUpdate, System.Drawing.Imaging.ImageFormat.Jpeg)
                ' تحديث بيانات موجودة  
                Dim BLCAT As BL.CLS_ST = New BL.CLS_ST()
                BLCAT.Update(txt_name.Text, txt_loaction.Text, txt_phone.Text, txt_email.Text, txt_school.Text, txt_dept.Text, ma, ID)
                Dim fEDIT As FRM_DEDIT = New FRM_DEDIT()
                fEDIT.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class