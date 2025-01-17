<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ADDSTUDNET
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ADDSTUDNET))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_phone = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_email = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_loaction = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_dept = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_school = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cover = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnadd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_loaction)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Lb_Title)
        Me.GroupBox1.Location = New System.Drawing.Point(500, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 589)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "المعلومات الاساسية"
        '
        'txt_phone
        '
        Me.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_phone.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_phone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_phone.HintForeColor = System.Drawing.Color.Empty
        Me.txt_phone.HintText = ""
        Me.txt_phone.isPassword = False
        Me.txt_phone.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_phone.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_phone.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_phone.LineThickness = 4
        Me.txt_phone.Location = New System.Drawing.Point(43, 381)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(368, 46)
        Me.txt_phone.TabIndex = 14
        Me.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_email
        '
        Me.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_email.HintForeColor = System.Drawing.Color.Empty
        Me.txt_email.HintText = ""
        Me.txt_email.isPassword = False
        Me.txt_email.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_email.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_email.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_email.LineThickness = 4
        Me.txt_email.Location = New System.Drawing.Point(43, 494)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(368, 46)
        Me.txt_email.TabIndex = 12
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 456)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 42)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "الايميل"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 42)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "رقم الهاتف"
        '
        'txt_loaction
        '
        Me.txt_loaction.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_loaction.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_loaction.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_loaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_loaction.HintForeColor = System.Drawing.Color.Empty
        Me.txt_loaction.HintText = ""
        Me.txt_loaction.isPassword = False
        Me.txt_loaction.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_loaction.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_loaction.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_loaction.LineThickness = 4
        Me.txt_loaction.Location = New System.Drawing.Point(43, 245)
        Me.txt_loaction.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_loaction.Name = "txt_loaction"
        Me.txt_loaction.Size = New System.Drawing.Size(368, 46)
        Me.txt_loaction.TabIndex = 8
        Me.txt_loaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "السكن"
        '
        'txt_name
        '
        Me.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_name.HintForeColor = System.Drawing.Color.Empty
        Me.txt_name.HintText = ""
        Me.txt_name.isPassword = False
        Me.txt_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_name.LineThickness = 4
        Me.txt_name.Location = New System.Drawing.Point(43, 109)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(368, 46)
        Me.txt_name.TabIndex = 7
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_Title
        '
        Me.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lb_Title.AutoSize = True
        Me.Lb_Title.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.Location = New System.Drawing.Point(275, 61)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(149, 42)
        Me.Lb_Title.TabIndex = 7
        Me.Lb_Title.Text = "اسم الطالب"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_dept)
        Me.GroupBox2.Controls.Add(Me.txt_school)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.cover)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 596)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "المعلومات الثانوية"
        '
        'txt_dept
        '
        Me.txt_dept.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_dept.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_dept.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_dept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_dept.HintForeColor = System.Drawing.Color.Empty
        Me.txt_dept.HintText = ""
        Me.txt_dept.isPassword = False
        Me.txt_dept.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_dept.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_dept.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_dept.LineThickness = 4
        Me.txt_dept.Location = New System.Drawing.Point(44, 273)
        Me.txt_dept.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(368, 46)
        Me.txt_dept.TabIndex = 16
        Me.txt_dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_school
        '
        Me.txt_school.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_school.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_school.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_school.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_school.HintForeColor = System.Drawing.Color.Empty
        Me.txt_school.HintText = ""
        Me.txt_school.isPassword = False
        Me.txt_school.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_school.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_school.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_school.LineThickness = 4
        Me.txt_school.Location = New System.Drawing.Point(44, 123)
        Me.txt_school.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_school.Name = "txt_school"
        Me.txt_school.Size = New System.Drawing.Size(368, 46)
        Me.txt_school.TabIndex = 14
        Me.txt_school.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(117, 560)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(136, 29)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "تحميل غلاف"
        '
        'cover
        '
        Me.cover.Image = CType(resources.GetObject("cover.Image"), System.Drawing.Image)
        Me.cover.Location = New System.Drawing.Point(84, 370)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(220, 187)
        Me.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover.TabIndex = 14
        Me.cover.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 42)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "صورة الطالب"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(267, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 42)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "قسم الدراسي"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(225, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 42)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "مدرسة او جامعة"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(12, 1)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(48, 37)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 16
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnadd
        '
        Me.btnadd.ActiveBorderThickness = 1
        Me.btnadd.ActiveCornerRadius = 20
        Me.btnadd.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnadd.ActiveForecolor = System.Drawing.Color.White
        Me.btnadd.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnadd.BackColor = System.Drawing.Color.White
        Me.btnadd.BackgroundImage = CType(resources.GetObject("btnadd.BackgroundImage"), System.Drawing.Image)
        Me.btnadd.ButtonText = "اضافة"
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnadd.IdleBorderThickness = 1
        Me.btnadd.IdleCornerRadius = 20
        Me.btnadd.IdleFillColor = System.Drawing.Color.White
        Me.btnadd.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnadd.Location = New System.Drawing.Point(174, 620)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(9)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(603, 77)
        Me.btnadd.TabIndex = 5
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRM_ADDSTUDNET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 710)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnadd)
        Me.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FRM_ADDSTUDNET"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ADDBOKKS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lb_Title As Label
    Public WithEvents txt_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents txt_email As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents txt_loaction As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Public WithEvents cover As PictureBox
    Public WithEvents txt_dept As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents txt_school As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents btnadd As Bunifu.Framework.UI.BunifuThinButton2
    Public WithEvents txt_phone As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
