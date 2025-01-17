<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DETST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DETST))
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cover = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_email = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.Label()
        Me.txt_location = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.txt_school = New System.Windows.Forms.Label()
        Me.txt_dept = New System.Windows.Forms.Label()
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
        Me.GroupBox2.Controls.Add(Me.txt_dept)
        Me.GroupBox2.Controls.Add(Me.txt_school)
        Me.GroupBox2.Controls.Add(Me.cover)
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
        Me.cover.Location = New System.Drawing.Point(74, 359)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(332, 230)
        Me.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover.TabIndex = 14
        Me.cover.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(412, 323)
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
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(513, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 42)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "القسم"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(382, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 42)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "مدرسة او جامعة"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.txt_location)
        Me.GroupBox1.Controls.Add(Me.txt_name)
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
        'txt_email
        '
        Me.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_email.AutoSize = True
        Me.txt_email.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.White
        Me.txt_email.Location = New System.Drawing.Point(39, 446)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(0, 42)
        Me.txt_email.TabIndex = 17
        '
        'txt_phone
        '
        Me.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_phone.AutoSize = True
        Me.txt_phone.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.ForeColor = System.Drawing.Color.White
        Me.txt_phone.Location = New System.Drawing.Point(39, 323)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(0, 42)
        Me.txt_phone.TabIndex = 16
        '
        'txt_location
        '
        Me.txt_location.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_location.AutoSize = True
        Me.txt_location.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_location.ForeColor = System.Drawing.Color.White
        Me.txt_location.Location = New System.Drawing.Point(39, 197)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(0, 42)
        Me.txt_location.TabIndex = 15
        '
        'txt_name
        '
        Me.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_name.AutoSize = True
        Me.txt_name.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.White
        Me.txt_name.Location = New System.Drawing.Point(39, 61)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(0, 42)
        Me.txt_name.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(333, 446)
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
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(336, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 42)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "الهاتف"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(340, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "السكن"
        '
        'Lb_Title
        '
        Me.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lb_Title.AutoSize = True
        Me.Lb_Title.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.ForeColor = System.Drawing.Color.White
        Me.Lb_Title.Location = New System.Drawing.Point(280, 61)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(149, 42)
        Me.Lb_Title.TabIndex = 7
        Me.Lb_Title.Text = "اسم الطالب"
        '
        'txt_school
        '
        Me.txt_school.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_school.AutoSize = True
        Me.txt_school.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_school.ForeColor = System.Drawing.Color.White
        Me.txt_school.Location = New System.Drawing.Point(48, 50)
        Me.txt_school.Name = "txt_school"
        Me.txt_school.Size = New System.Drawing.Size(0, 42)
        Me.txt_school.TabIndex = 15
        '
        'txt_dept
        '
        Me.txt_dept.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_dept.AutoSize = True
        Me.txt_dept.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dept.ForeColor = System.Drawing.Color.White
        Me.txt_dept.Location = New System.Drawing.Point(48, 197)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(0, 42)
        Me.txt_dept.TabIndex = 16
        '
        'FRM_DETST
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
        Me.Name = "FRM_DETST"
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lb_Title As Label
    Public WithEvents txt_email As Label
    Public WithEvents txt_phone As Label
    Public WithEvents txt_location As Label
    Public WithEvents txt_name As Label
    Public WithEvents txt_dept As Label
    Public WithEvents txt_school As Label
End Class
