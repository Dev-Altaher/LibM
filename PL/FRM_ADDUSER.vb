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
Imports System.Runtime.ConstrainedExecution
Imports System.Data.SqlClient
Public Class FRM_ADDUSER
    Public ID As Integer
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If ID = 0 Then
            If txt_name.Text = "" Or txt_user.Text = "" Or txt_password.Text = "" Then
                Dim FError As New FRM_ERRORINSERT()
                FError.ShowDialog()
                Return
            End If
            Dim cona As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\LibM\DBLIBM.mdf;Integrated Security=True")
            Try
                If cona.State = ConnectionState.Closed Then cona.Open()
                Dim query As String = "insert into TBUSER (CNAME, CUSER, CPASSWORD, CPREM) values (@CNAME, @CUSER, @CPASSWORD, @CPREM)"
                Dim cmd As New SqlCommand(query, cona)
                cmd.Parameters.AddWithValue("@CNAME", txt_name.Text)
                cmd.Parameters.AddWithValue("@CUSER", txt_user.Text)
                cmd.Parameters.AddWithValue("@CPASSWORD", txt_password.Text)
                cmd.Parameters.AddWithValue("@CPREM", txt_prem.Text)
                cmd.ExecuteNonQuery()
                Dim Fadd As New FRM_DADD()
                Fadd.Show()
                Me.Close()
                Loaduserdata()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If cona.State = ConnectionState.Open Then cona.Close()
            End Try
        Else

            'تحديث بيانات موجودة  
            Dim BLUSER As BL.CLS_USERS = New BL.CLS_USERS()
            BLUSER.upadte(txt_name.Text, txt_user.Text, txt_password.Text, txt_prem.Text, ID)
            Dim fEDIT As FRM_DEDIT = New FRM_DEDIT()
            fEDIT.Show()
            Me.Close()
        End If


        'If ID = 0 Then
        '    ' إضافة بيانات جديدة  
        '    Dim BLUSER As New BL.CLS_USERS()
        '    BLUSER.Insert(txt_name.Text, txt_user.Text, txt_password.Text, txt_prem.Text)
        '    Dim Fadd As New FRM_DADD()
        '    Fadd.Show()
        '    Loaduserdata()
        '    Me.Close()
        'Else


    End Sub
    Public Sub Loaduserdata()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\LibM\DBLIBM.mdf;Integrated Security=True")
        Dim query As String = "select Id, CNAME, CUSER, CPASSWORD, CPREM from TBUSER"
        Using cmd As New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)
            FRM_MIAN.DataGridView1.DataSource = dt
        End Using

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_user_OnValueChanged(sender As Object, e As EventArgs) Handles txt_user.OnValueChanged

    End Sub
End Class