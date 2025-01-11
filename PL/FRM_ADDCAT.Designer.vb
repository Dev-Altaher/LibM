<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ADDCAT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ADDCAT))
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.txt_catname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnadd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(0, 1)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(42, 39)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Lb_Title
        '
        Me.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lb_Title.AutoSize = True
        Me.Lb_Title.Font = New System.Drawing.Font("Wide Latin", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.Location = New System.Drawing.Point(208, 115)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(380, 103)
        Me.Lb_Title.TabIndex = 2
        Me.Lb_Title.Text = "اسم الصنف"
        '
        'txt_catname
        '
        Me.txt_catname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_catname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_catname.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.txt_catname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_catname.HintForeColor = System.Drawing.Color.Empty
        Me.txt_catname.HintText = "اسم الصنف"
        Me.txt_catname.isPassword = False
        Me.txt_catname.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_catname.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_catname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_catname.LineThickness = 5
        Me.txt_catname.Location = New System.Drawing.Point(147, 292)
        Me.txt_catname.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.txt_catname.Name = "txt_catname"
        Me.txt_catname.Size = New System.Drawing.Size(512, 52)
        Me.txt_catname.TabIndex = 3
        Me.txt_catname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnadd.Location = New System.Drawing.Point(110, 505)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(9)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(603, 90)
        Me.btnadd.TabIndex = 4
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'FRM_ADDCAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 613)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txt_catname)
        Me.Controls.Add(Me.Lb_Title)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FRM_ADDCAT"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ADDCAT"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Lb_Title As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Public WithEvents btnadd As Bunifu.Framework.UI.BunifuThinButton2
    Public WithEvents txt_catname As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
