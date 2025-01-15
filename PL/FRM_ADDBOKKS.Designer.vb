<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ADDBOKKS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ADDBOKKS))
        Me.btnadd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_price = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_auther = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_title = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cover = New System.Windows.Forms.PictureBox()
        Me.txt_rate = New Bunifu.Framework.UI.BunifuRating()
        Me.txt_date = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnadd.Location = New System.Drawing.Point(149, 620)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(9)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(603, 77)
        Me.btnadd.TabIndex = 5
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_auther)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_title)
        Me.GroupBox1.Controls.Add(Me.Lb_Title)
        Me.GroupBox1.Location = New System.Drawing.Point(500, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 589)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "المعلومات الاساسية"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(383, 405)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(68, 29)
        Me.LinkLabel2.TabIndex = 15
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "اضافة"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 402)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(368, 36)
        Me.ComboBox1.TabIndex = 14
        '
        'txt_price
        '
        Me.txt_price.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_price.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_price.HintForeColor = System.Drawing.Color.Empty
        Me.txt_price.HintText = ""
        Me.txt_price.isPassword = False
        Me.txt_price.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_price.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_price.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_price.LineThickness = 4
        Me.txt_price.Location = New System.Drawing.Point(43, 494)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(368, 46)
        Me.txt_price.TabIndex = 12
        Me.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(275, 446)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 42)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "سعر الكتاب"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 42)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "صنف الكتاب"
        '
        'txt_auther
        '
        Me.txt_auther.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_auther.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_auther.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_auther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_auther.HintForeColor = System.Drawing.Color.Empty
        Me.txt_auther.HintText = ""
        Me.txt_auther.isPassword = False
        Me.txt_auther.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_auther.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_auther.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_auther.LineThickness = 4
        Me.txt_auther.Location = New System.Drawing.Point(43, 245)
        Me.txt_auther.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_auther.Name = "txt_auther"
        Me.txt_auther.Size = New System.Drawing.Size(368, 46)
        Me.txt_auther.TabIndex = 8
        Me.txt_auther.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "اسم المؤلف"
        '
        'txt_title
        '
        Me.txt_title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_title.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_title.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_title.HintForeColor = System.Drawing.Color.Empty
        Me.txt_title.HintText = ""
        Me.txt_title.isPassword = False
        Me.txt_title.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_title.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_title.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_title.LineThickness = 4
        Me.txt_title.Location = New System.Drawing.Point(43, 109)
        Me.txt_title.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(368, 46)
        Me.txt_title.TabIndex = 7
        Me.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_Title
        '
        Me.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lb_Title.AutoSize = True
        Me.Lb_Title.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.Location = New System.Drawing.Point(275, 61)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(143, 42)
        Me.Lb_Title.TabIndex = 7
        Me.Lb_Title.Text = "اسم الكتاب"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.cover)
        Me.GroupBox2.Controls.Add(Me.txt_rate)
        Me.GroupBox2.Controls.Add(Me.txt_date)
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
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(281, 535)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(136, 29)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "تحميل غلاف"
        '
        'cover
        '
        Me.cover.Image = CType(resources.GetObject("cover.Image"), System.Drawing.Image)
        Me.cover.Location = New System.Drawing.Point(271, 372)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(152, 149)
        Me.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover.TabIndex = 14
        Me.cover.TabStop = False
        '
        'txt_rate
        '
        Me.txt_rate.BackColor = System.Drawing.Color.Transparent
        Me.txt_rate.Font = New System.Drawing.Font("AGA Arabesque Desktop", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txt_rate.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_rate.Location = New System.Drawing.Point(63, 239)
        Me.txt_rate.Margin = New System.Windows.Forms.Padding(7)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(371, 61)
        Me.txt_rate.TabIndex = 13
        Me.txt_rate.Value = 0
        '
        'txt_date
        '
        Me.txt_date.BackColor = System.Drawing.Color.SeaGreen
        Me.txt_date.BorderRadius = 0
        Me.txt_date.ForeColor = System.Drawing.Color.White
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.txt_date.FormatCustom = Nothing
        Me.txt_date.Location = New System.Drawing.Point(32, 123)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(7)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(406, 49)
        Me.txt_date.TabIndex = 12
        Me.txt_date.Value = New Date(2025, 1, 13, 23, 48, 1, 489)
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(271, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 42)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "غلاف الكتاب"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(290, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 42)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "تقييم الكتاب"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(290, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 42)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "تاريخ النشر"
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
        'FRM_ADDBOKKS
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
        Me.Name = "FRM_ADDBOKKS"
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

    Public WithEvents btnadd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lb_Title As Label
    Public WithEvents txt_title As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ComboBox1 As ComboBox
    Public WithEvents txt_price As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents txt_auther As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents LinkLabel2 As LinkLabel
    Public WithEvents txt_rate As Bunifu.Framework.UI.BunifuRating
    Public WithEvents txt_date As Bunifu.Framework.UI.BunifuDatepicker
    Public WithEvents cover As PictureBox
End Class
