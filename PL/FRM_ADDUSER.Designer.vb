<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ADDUSER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ADDUSER))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnadd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_prem = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.txt_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.txt_prem)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_user)
        Me.Panel1.Controls.Add(Me.Lb_Title)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(478, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 715)
        Me.Panel1.TabIndex = 0
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
        Me.btnadd.Location = New System.Drawing.Point(43, 635)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(9)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(431, 62)
        Me.btnadd.TabIndex = 6
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_prem
        '
        Me.txt_prem.FormattingEnabled = True
        Me.txt_prem.Items.AddRange(New Object() {"مدير ", "مستخدم"})
        Me.txt_prem.Location = New System.Drawing.Point(102, 557)
        Me.txt_prem.Name = "txt_prem"
        Me.txt_prem.Size = New System.Drawing.Size(342, 41)
        Me.txt_prem.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 494)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 42)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "الصلاحية"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 42)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "كلمت السر"
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_password.HintForeColor = System.Drawing.Color.Empty
        Me.txt_password.HintText = ""
        Me.txt_password.isPassword = False
        Me.txt_password.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_password.LineIdleColor = System.Drawing.Color.Black
        Me.txt_password.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_password.LineThickness = 4
        Me.txt_password.Location = New System.Drawing.Point(76, 370)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_password.Size = New System.Drawing.Size(368, 46)
        Me.txt_password.TabIndex = 12
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "الاسم المستخدم"
        '
        'txt_user
        '
        Me.txt_user.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.txt_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_user.HintForeColor = System.Drawing.Color.Empty
        Me.txt_user.HintText = ""
        Me.txt_user.isPassword = False
        Me.txt_user.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_user.LineIdleColor = System.Drawing.Color.Black
        Me.txt_user.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_user.LineThickness = 4
        Me.txt_user.Location = New System.Drawing.Point(76, 244)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_user.Size = New System.Drawing.Size(368, 46)
        Me.txt_user.TabIndex = 10
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_Title
        '
        Me.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lb_Title.AutoSize = True
        Me.Lb_Title.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.Location = New System.Drawing.Point(291, 55)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(160, 42)
        Me.Lb_Title.TabIndex = 9
        Me.Lb_Title.Text = "الاسم الكامل"
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
        Me.txt_name.LineIdleColor = System.Drawing.Color.Black
        Me.txt_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_name.LineThickness = 4
        Me.txt_name.Location = New System.Drawing.Point(76, 103)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_name.Size = New System.Drawing.Size(368, 46)
        Me.txt_name.TabIndex = 8
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Cyan
        Me.FlowLayoutPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(478, 715)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(-434, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(909, 39)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(475, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 42)
        Me.Label4.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 602)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FRM_ADDUSER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(961, 715)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FRM_ADDUSER"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ADDUSER"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Public WithEvents btnadd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_prem As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents txt_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Public WithEvents txt_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Lb_Title As Label
    Public WithEvents txt_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
