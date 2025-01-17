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
    Dim BLBOOKS As New CLS_BOOKS()
    Dim BLST As New CLS_ST()
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
        BunifuThinButton24.Visible = False
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
        P_HOME.Visible = True
        P_MAIN.Visible = False
        Lb_Title.Text = "الرئيسية"
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
        'اضافة كتاب
        If State = "BOOKS" Then
            Dim FBOOKS As New FRM_ADDBOKKS()
            FBOOKS.btnadd.ButtonText = "اضافة"
            FBOOKS.ID = 0
            BunifuTransition1.ShowSync(FBOOKS)
            FBOOKS.Show()
        End If
        'اضافة طالب
        If State = "ST" Then
            Dim FBOOKS As New FRM_ADDSTUDNET()
            FBOOKS.btnadd.ButtonText = "اضافة"
            FBOOKS.ID = 0
            BunifuTransition1.ShowSync(FBOOKS)
            FBOOKS.Show()
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
        ElseIf State = "BOOKS" Then
            ' معالجة الاستثناءات
            Try
                ' تحميل البيانات
                Dim dt As New DataTable()
                dt = BLBOOKS.Load()
                DataGridView1.DataSource = dt

                ' تغيير عناوين الأعمدة
                DataGridView1.Columns(0).HeaderText = "التسلسل"
                DataGridView1.Columns(1).HeaderText = "اسم الكتاب"
                DataGridView1.Columns(2).HeaderText = "اسم المؤلف"
                DataGridView1.Columns(3).HeaderText = "التصنيف"
                DataGridView1.Columns(4).HeaderText = "السعر"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf State = "ST" Then
            P_HOME.Visible = False
            P_MAIN.Visible = True
            BunifuThinButton24.Visible = True
            State = "ST"
            Lb_Title.Text = "الطلاب"

            ' معالجة الاستثناءات
            Try
                ' تحميل البيانات
                Dim dt As New DataTable()
                dt = BLST.Load()
                DataGridView1.DataSource = dt

                ' تغيير عناوين الأعمدة
                DataGridView1.Columns(0).HeaderText = "التسلسل"
                DataGridView1.Columns(1).HeaderText = "اسم الطالب"
                DataGridView1.Columns(2).HeaderText = "السكن"
                DataGridView1.Columns(3).HeaderText = "رقم الهاتف"
                DataGridView1.Columns(4).HeaderText = "ايميل"
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
        'تعديل كتاب
        If State = "CAT" Then
            Dim FCAT As New FRM_ADDCAT()
            FCAT.btnadd.ButtonText = "تعديل"
            FCAT.txt_catname.Text = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
            FCAT.ID = Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value)
            BunifuTransition1.ShowSync(FCAT)
            FCAT.Show()
            'تعديل كتاب
        ElseIf State = "BOOKS" Then
            Dim FBOOKS As New FRM_ADDBOKKS()

            FBOOKS.btnadd.ButtonText = "تعديل"
            FBOOKS.ID = Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value)
            Try
                Dim dt As New DataTable()
                dt = BLBOOKS.LOADEDIT(Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value))
                Dim obj1 As Object = dt.Rows(0)("TITLE")
                Dim obj2 As Object = dt.Rows(0)("AUTHER")
                Dim obj3 As Object = dt.Rows(0)("CAT")
                Dim obj4 As Object = dt.Rows(0)("PRICE")
                Dim obj5 As Object = dt.Rows(0)("BDATE")
                Dim obj6 As Object = dt.Rows(0)("RATE")
                Dim obj7 As Object = dt.Rows(0)("COVER")
                FBOOKS.txt_title.Text = obj1.ToString()
                FBOOKS.txt_auther.Text = obj2.ToString()
                FBOOKS.txt_rate.Value = CType(obj6, Integer)
                Dim ob As Byte() = CType(obj7, Byte())
                FBOOKS.txt_date.Value = CType(obj5, DateTime)
                'تحويل البيانات الثنائية إلى صورة
                Dim ma As New MemoryStream(ob)
                FBOOKS.cover.Image = Image.FromStream(ma)
                BunifuTransition1.ShowSync(FBOOKS)
                FBOOKS.ComboBox1.Text = obj3.ToString()
                FBOOKS.txt_price.Text = obj4.ToString()
            Catch ex As Exception
                ' يمكن وضع التعليمات البرمجية لمعالجة الأخطاء هنا
            End Try
            FBOOKS.Show()
            'Edit Student
        ElseIf State = "ST" Then
            Try
                Dim FST As New FRM_ADDSTUDNET()
                FST.btnadd.ButtonText = "تعديل"
                FST.ID = Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value)
                Dim dt As New DataTable()
                dt = BLST.LOADEDIT(Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value))
                Dim obj1 As Object = dt.Rows(0)("NAME")
                Dim obj2 As Object = dt.Rows(0)("TLOACTION")
                Dim obj3 As Object = dt.Rows(0)("PHONE")
                Dim obj4 As Object = dt.Rows(0)("EMAIL")
                Dim obj5 As Object = dt.Rows(0)("SCHOOL")
                Dim obj6 As Object = dt.Rows(0)("DEP")
                Dim obj7 As Object = dt.Rows(0)("COVER")

                FST.txt_name.Text = obj1.ToString()
                FST.txt_loaction.Text = obj2.ToString()
                FST.txt_phone.Text = obj3.ToString()
                FST.txt_email.Text = obj4.ToString()
                FST.txt_school.Text = obj5.ToString()
                FST.txt_dept.Text = obj6.ToString()

                'Load Image
                Dim ob As Byte() = CType(obj7, Byte())
                Dim ma As New MemoryStream(ob)
                FST.cover.Image = Image.FromStream(ma)
                BunifuTransition1.ShowSync(FST)
            Catch ex As Exception
                ' يمكن إضافة سجل الأخطاء هنا إذا لزم الأمر
            End Try
        End If
    End Sub


    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        ' حذف فئة
        If State = "CAT" Then
            BLCAT.Delete(Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value))
            Dim Fdelete As New FRM_DDELETE()
            Fdelete.Show()
            'MessageBox.Show("تم الحذف بنجاح")

        ElseIf State = "BOOKS" Then
            'حذف كتاب
            BLBOOKS.Delete(Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value))
            Dim Fdelete As New FRM_DDELETE()
            Fdelete.Show()
            'MessageBox.Show("تم الحذف بنجاح")
        End If
    End Sub
    Private Sub bunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged
        ' البحث
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

        ' البحث عن الكتب
        If State = "BOOKS" Then
            Dim inputText As String = BunifuMaterialTextbox1.Text.Trim()

            ' التأكد من أن النص غير فارغ
            If Not String.IsNullOrEmpty(inputText) Then
                Dim dt As New DataTable()
                dt = BLBOOKS.serach(inputText) ' إرسال النص إلى الدالة
                DataGridView1.DataSource = dt
            End If
        End If

        ' البحث عن الطلاب
        If State = "ST" Then
            Dim inputText As String = BunifuMaterialTextbox1.Text.Trim()

            ' التأكد من أن النص غير فارغ
            If Not String.IsNullOrEmpty(inputText) Then
                Dim dt As New DataTable()
                dt = BLST.serach(inputText) ' إرسال النص إلى الدالة
                DataGridView1.DataSource = dt
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        P_HOME.Visible = False
        P_MAIN.Visible = True
        BunifuThinButton24.Visible = True
        State = "BOOKS"
        Lb_Title.Text = "الكتب"

        ' معالجة الاستثناءات
        Try
            ' تحميل البيانات
            Dim dt As New DataTable()
            dt = BLBOOKS.Load()
            DataGridView1.DataSource = dt

            ' تغيير عناوين الأعمدة
            DataGridView1.Columns(0).HeaderText = "التسلسل"
            DataGridView1.Columns(1).HeaderText = "اسم الكتاب"
            DataGridView1.Columns(2).HeaderText = "اسم المؤلف"
            DataGridView1.Columns(3).HeaderText = "التصنيف"
            DataGridView1.Columns(4).HeaderText = "السعر"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        ' تصدير البيانات
        If State = "CAT" Then
            Dim dt As New DataTable()
            dt = BLCAT.Load()
            Dim save As New SaveFileDialog()
            save.Filter = "CSV|*.csv"
            save.FileName = "Categories.csv"
            If save.ShowDialog() = DialogResult.OK Then
                Dim sw As New StreamWriter(save.FileName)
                For i As Integer = 0 To dt.Columns.Count - 1
                    sw.Write(dt.Columns(i).ToString().ToUpper() & If(i + 1 < dt.Columns.Count, ",", Environment.NewLine))
                Next
                For Each row As DataRow In dt.Rows
                    For i As Integer = 0 To dt.Columns.Count - 1
                        sw.Write(row(i).ToString() & If(i + 1 < dt.Columns.Count, ",", Environment.NewLine))
                    Next
                Next
                sw.Close()
                MessageBox.Show("تم حفظ البيانات بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'تفاصيل الكتب
        If State = "BOOKS" Then
            Try

                Dim dt As New DataTable()
                dt = BLBOOKS.LOADEDIT(Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value))
                Dim obj1 As Object = dt.Rows(0)("TITLE")
                Dim obj2 As Object = dt.Rows(0)("AUTHER")
                Dim obj3 As Object = dt.Rows(0)("CAT")
                Dim obj4 As Object = dt.Rows(0)("PRICE")
                Dim obj5 As Object = dt.Rows(0)("BDATE")
                Dim obj6 As Object = dt.Rows(0)("RATE")
                Dim obj7 As Object = dt.Rows(0)("COVER")
                Dim DETBOOKS As New FRM_DETBOOKS()
                DETBOOKS.txt_title.Text = obj1.ToString()
                DETBOOKS.txt_auther.Text = obj2.ToString()
                DETBOOKS.txt_rate.Value = CType(obj6, Integer)
                Dim ob As Byte() = CType(obj7, Byte())
                DETBOOKS.txt_date.Value = CType(obj5, DateTime)
                'تحويل البيانات الثنائية إلى صورة
                Dim ma As New MemoryStream(ob)
                DETBOOKS.cover.Image = Image.FromStream(ma)
                BunifuTransition1.ShowSync(DETBOOKS)
                DETBOOKS.txt_cat.Text = obj3.ToString()
                DETBOOKS.txt_price.Text = obj4.ToString()
            Catch ex As Exception
                ' يمكن وضع التعليمات البرمجية لمعالجة الأخطاء هنا
            End Try
        ElseIf State = "ST" Then
            Try
                'تفاصيل الطلاب
                Dim FST As New FRM_ADDSTUDNET()
                Dim dt As New DataTable()
                dt = BLST.LOADEDIT(Convert.ToInt16(DataGridView1.CurrentRow.Cells(0).Value))
                Dim obj1 As Object = dt.Rows(0)("NAME")
                Dim obj2 As Object = dt.Rows(0)("TLOACTION")
                Dim obj3 As Object = dt.Rows(0)("PHONE")
                Dim obj4 As Object = dt.Rows(0)("EMAIL")
                Dim obj5 As Object = dt.Rows(0)("SCHOOL")
                Dim obj6 As Object = dt.Rows(0)("DEP")
                Dim obj7 As Object = dt.Rows(0)("COVER")

                FST.txt_name.Text = obj1.ToString()
                FST.txt_loaction.Text = obj2.ToString()
                FST.txt_phone.Text = obj3.ToString()
                FST.txt_email.Text = obj4.ToString()
                FST.txt_school.Text = obj5.ToString()
                FST.txt_dept.Text = obj6.ToString()

                'Load Image
                Dim ob As Byte() = CType(obj7, Byte())
                Dim ma As New MemoryStream(ob)
                FST.cover.Image = Image.FromStream(ma)
                BunifuTransition1.ShowSync(FST)
            Catch ex As Exception
                ' يمكن إضافة سجل الأخطاء هنا إذا لزم الأمر
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        P_HOME.Visible = False
        P_MAIN.Visible = True
        BunifuThinButton24.Visible = True
        State = "ST"
        Lb_Title.Text = "الطلاب"

        ' معالجة الاستثناءات
        Try
            ' تحميل البيانات
            Dim dt As New DataTable()
            dt = BLST.Load()
            DataGridView1.DataSource = dt

            ' تغيير عناوين الأعمدة
            DataGridView1.Columns(0).HeaderText = "التسلسل"
            DataGridView1.Columns(1).HeaderText = "اسم الطالب"
            DataGridView1.Columns(2).HeaderText = "السكن"
            DataGridView1.Columns(3).HeaderText = "رقم الهاتف"
            DataGridView1.Columns(4).HeaderText = "ايميل"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class