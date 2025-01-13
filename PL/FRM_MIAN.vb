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
Public Class FRM_MIAN

    Private PlaceholderTexts As New Dictionary(Of BunifuMaterialTextbox, String)

    Dim State As String
    Dim ID As Integer
    Dim BLCAT As New CLS_CAT()
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        If P_MB.Size.Width = 175 Then
            P_MB.Width = 50
            Button1.RightToLeft = RightToLeft.Yes
            Button2.RightToLeft = RightToLeft.Yes
            Button3.RightToLeft = RightToLeft.Yes
            Button4.RightToLeft = RightToLeft.Yes
            Button5.RightToLeft = RightToLeft.Yes
            Button6.RightToLeft = RightToLeft.Yes
            Button7.RightToLeft = RightToLeft.Yes
        Else
            P_MB.Width = 175
            Button1.RightToLeft = RightToLeft.No
            Button2.RightToLeft = RightToLeft.No
            Button3.RightToLeft = RightToLeft.No
            Button4.RightToLeft = RightToLeft.No
            Button5.RightToLeft = RightToLeft.No
            Button6.RightToLeft = RightToLeft.No
            Button7.RightToLeft = RightToLeft.No
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        P_HOME.Visible = False
        P_MAIN.Visible = True
        State = "CAT"
        Lb_Title.Text = "الاصناف"

        ' معالجة الاستثناءات
        Try
            ' تحميل البيانات
            Dim dt As New DataTable()
            dt = BLCAT.Load()
            DataGridView1.DataSource = dt

            ' تغيير عناوين الأعمدة
            DataGridView1.Columns(0).HeaderText = "التسلسل"
            DataGridView1.Columns(1).HeaderText = "اسم الصنف"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FRM_MIAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddPlaceholder(BunifuMaterialTextbox1, "تأكيد كلمة المرور")

        ' تعيين النصوص المؤقتة لجميع مربعات النص
        For Each txtBox As BunifuMaterialTextbox In PlaceholderTexts.Keys
            SetPlaceholder(txtBox)
        Next
        P_HOME.Visible = True
        P_MAIN.Visible = False
        Lb_Title.Text = "الرئيسية"
    End Sub
    Private Sub AddPlaceholder(txtBox As BunifuMaterialTextbox, placeholder As String)
        If Not PlaceholderTexts.ContainsKey(txtBox) Then
            PlaceholderTexts.Add(txtBox, placeholder)
        Else
            PlaceholderTexts(txtBox) = placeholder
        End If
    End Sub

    ' تعيين النص المؤقت لمربع النص
    Private Sub SetPlaceholder(txtBox As BunifuMaterialTextbox)
        If PlaceholderTexts.ContainsKey(txtBox) Then
            txtBox.Text = PlaceholderTexts(txtBox)
            txtBox.ForeColor = Drawing.Color.Gray ' النص المؤقت يكون رمادي اللون
        End If
    End Sub

    ' التعامل مع التركيز على BunifuTextBox (إزالة النص المؤقت)
    Private Sub BunifuMaterialTextbox_GotFocus(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.GotFocus
        Dim txtBox As BunifuMaterialTextbox = DirectCast(sender, BunifuMaterialTextbox)
        If PlaceholderTexts.ContainsKey(txtBox) AndAlso txtBox.Text = PlaceholderTexts(txtBox) Then
            txtBox.Text = ""
            txtBox.ForeColor = Drawing.Color.Black ' إعادة النص إلى اللون الطبيعي
        End If
    End Sub

    ' التعامل مع فقدان التركيز على BunifuTextBox (إعادة النص المؤقت)
    Private Sub BunifuMaterialTextbox_LostFocus(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.LostFocus
        Dim txtBox As BunifuMaterialTextbox = DirectCast(sender, BunifuMaterialTextbox)
        If PlaceholderTexts.ContainsKey(txtBox) AndAlso String.IsNullOrWhiteSpace(txtBox.Text) Then
            SetPlaceholder(txtBox)
        End If
    End Sub

    ' تطبيق النص المؤقت لمربع النص
    Public Sub ApplyPlaceholder(txtBox As BunifuMaterialTextbox, placeholder As String)
        AddPlaceholder(txtBox, placeholder)
        SetPlaceholder(txtBox)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        ' إضافة فئة
        If State = "CAT" Then
            Dim FCAT As New FRM_ADDCAT()
            FCAT.btnadd.ButtonText = "اضافة"
            FCAT.ID = 0
            BunifuTransition1.ShowSync(FCAT)
            FCAT.Show()
        End If
    End Sub

    Private Sub FRM_MIAN_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If State = "CAT" Then
            ' معالجة الاستثناءات
            Try
                ' تحميل البيانات
                Dim dt As New DataTable()
                dt = BLCAT.Load()
                DataGridView1.DataSource = dt

                ' تغيير عناوين الأعمدة
                DataGridView1.Columns(0).HeaderText = "التسلسل"
                DataGridView1.Columns(1).HeaderText = "اسم الصنف"

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        ' تعديل فئة
        If State = "CAT" Then
            Dim FCAT As New FRM_ADDCAT()
            FCAT.btnadd.ButtonText = "تعديل"
            FCAT.txt_catname.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
            FCAT.ID = Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value)
            BunifuTransition1.ShowSync(FCAT)
            FCAT.Show()
        End If
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        ' حذف فئة
        If State = "CAT" Then
            BLCAT.Delete(Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value))
            Dim Fdelete As New FRM_DDELETE()
            Fdelete.Show()
            'MessageBox.Show("تم الحذف بنجاح")

        End If
    End Sub
    Private Sub bunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged
        If State = "CAT" Then
            Dim inputText As String = BunifuMaterialTextbox1.Text.Trim()

            ' التأكد من أن النص غير فارغ
            If Not String.IsNullOrEmpty(inputText) Then
                Dim dt As New DataTable()
                dt = BLCAT.serach(inputText) ' إرسال النص إلى الدالة
                DataGridView1.DataSource = dt
            Else
                'MessageBox.Show("يرجى إدخال اسم للبحث.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

End Class