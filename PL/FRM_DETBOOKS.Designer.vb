<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DETBOOKS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DETBOOKS))
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cover = New System.Windows.Forms.PictureBox()
        Me.txt_rate = New Bunifu.Framework.UI.BunifuRating()
        Me.txt_date = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.Label()
        Me.txt_cat = New System.Windows.Forms.Label()
        Me.txt_auther = New System.Windows.Forms.Label()
        Me.txt_title = New System.Windows.Forms.Label()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(12, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(48, 37)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 19
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.cover)
        Me.GroupBox2.Controls.Add(Me.txt_rate)
        Me.GroupBox2.Controls.Add(Me.txt_date)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Sylfaen", 16.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 614)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "المعلومات الثانوية"
        '
        'cover
        '
        Me.cover.Image = CType(resources.GetObject("cover.Image"), System.Drawing.Image)
        Me.cover.Location = New System.Drawing.Point(96, 359)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(332, 230)
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
        Me.txt_rate.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(537, 61)
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
        Me.txt_date.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(572, 49)
        Me.txt_date.TabIndex = 12
        Me.txt_date.Value = New Date(2025, 1, 13, 23, 48, 1, 489)
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(416, 323)
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
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(449, 197)
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
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(449, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 42)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "تاريخ النشر"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_cat)
        Me.GroupBox1.Controls.Add(Me.txt_auther)
        Me.GroupBox1.Controls.Add(Me.txt_title)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lb_Title)
        Me.GroupBox1.Font = New System.Drawing.Font("Stencil", 16.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(727, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 614)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "المعلومات الاساسية"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
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
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(275, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 42)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "صنف الكتاب"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(275, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "اسم المؤلف"
        '
        'Lb_Title
        '
        Me.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lb_Title.AutoSize = True
        Me.Lb_Title.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.ForeColor = System.Drawing.Color.White
        Me.Lb_Title.Location = New System.Drawing.Point(275, 61)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(143, 42)
        Me.Lb_Title.TabIndex = 7
        Me.Lb_Title.Text = "اسم الكتاب"
        '
        'txt_price
        '
        Me.txt_price.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_price.AutoSize = True
        Me.txt_price.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.ForeColor = System.Drawing.Color.White
        Me.txt_price.Location = New System.Drawing.Point(39, 446)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(0, 42)
        Me.txt_price.TabIndex = 17
        '
        'txt_cat
        '
        Me.txt_cat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_cat.AutoSize = True
        Me.txt_cat.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cat.ForeColor = System.Drawing.Color.White
        Me.txt_cat.Location = New System.Drawing.Point(39, 323)
        Me.txt_cat.Name = "txt_cat"
        Me.txt_cat.Size = New System.Drawing.Size(0, 42)
        Me.txt_cat.TabIndex = 16
        '
        'txt_auther
        '
        Me.txt_auther.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_auther.AutoSize = True
        Me.txt_auther.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_auther.ForeColor = System.Drawing.Color.White
        Me.txt_auther.Location = New System.Drawing.Point(39, 197)
        Me.txt_auther.Name = "txt_auther"
        Me.txt_auther.Size = New System.Drawing.Size(0, 42)
        Me.txt_auther.TabIndex = 15
        '
        'txt_title
        '
        Me.txt_title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_title.AutoSize = True
        Me.txt_title.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title.ForeColor = System.Drawing.Color.White
        Me.txt_title.Location = New System.Drawing.Point(39, 61)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(0, 42)
        Me.txt_title.TabIndex = 14
        '
        'FRM_DETBOOKS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1190, 733)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_DETBOOKS"
        Me.Opacity = 0.85R
        Me.Text = "FRM_DETBOOKS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents cover As PictureBox
    Public WithEvents txt_rate As Bunifu.Framework.UI.BunifuRating
    Public WithEvents txt_date As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lb_Title As Label
    Public WithEvents txt_price As Label
    Public WithEvents txt_cat As Label
    Public WithEvents txt_auther As Label
    Public WithEvents txt_title As Label
End Class
