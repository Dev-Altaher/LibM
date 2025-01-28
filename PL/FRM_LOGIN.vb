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
Imports System.Data.SqlClient
Public Class FRM_LOGIN
    Private ex As Object

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim username As String = txt_user.Text.Trim
        Dim password As String = txt_password.Text.Trim
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\LibM\DBLIBM.mdf;Integrated Security=True")
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query As String = "SELECT count(*) FROM TBUSER WHERE CUSER = @CUSER AND CPASSWORD = @CPASSWORD"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@CUSER", username)
            cmd.Parameters.AddWithValue("@CPASSWORD", password)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim frm As New FRM_MIAN
                frm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class