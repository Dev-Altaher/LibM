<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LOGIN))
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnadd = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(-2, -2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(49, 39)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(598, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 59)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "الاسم المستخدم"
        '
        'txt_user
        '
        Me.txt_user.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.txt_user.Location = New System.Drawing.Point(182, 145)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_user.Size = New System.Drawing.Size(369, 75)
        Me.txt_user.TabIndex = 12
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(612, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 59)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "كلمت السر"
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.txt_password.Location = New System.Drawing.Point(182, 296)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_password.Size = New System.Drawing.Size(369, 75)
        Me.txt_password.TabIndex = 14
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(279, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 83)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "تسجيل الدخول"
        '
        'btnadd
        '
        Me.btnadd.ActiveBorderThickness = 1
        Me.btnadd.ActiveCornerRadius = 20
        Me.btnadd.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnadd.ActiveForecolor = System.Drawing.Color.White
        Me.btnadd.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnadd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnadd.BackColor = System.Drawing.SystemColors.Control
        Me.btnadd.BackgroundImage = CType(resources.GetObject("btnadd.BackgroundImage"), System.Drawing.Image)
        Me.btnadd.ButtonText = "تسجيل الدخول"
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnadd.IdleBorderThickness = 1
        Me.btnadd.IdleCornerRadius = 20
        Me.btnadd.IdleFillColor = System.Drawing.Color.White
        Me.btnadd.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnadd.Location = New System.Drawing.Point(204, 589)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(9)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(501, 62)
        Me.btnadd.TabIndex = 17
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRM_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 669)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Name = "FRM_LOGIN"
        Me.Text = "FRM_LOGIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Public WithEvents txt_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Public WithEvents txt_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Public WithEvents btnadd As Bunifu.Framework.UI.BunifuThinButton2
End Class
