<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MAKESELL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MAKESELL))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnadd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txt_title = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_date = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_date)
        Me.GroupBox1.Controls.Add(Me.txt_title)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lb_Title)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 427)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(925, 181)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "المعلومات الاساسية"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(565, 456)
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
        Me.Label2.Location = New System.Drawing.Point(519, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 42)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "رقم الهاتف"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "التاريخ"
        '
        'Lb_Title
        '
        Me.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lb_Title.AutoSize = True
        Me.Lb_Title.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.Location = New System.Drawing.Point(817, 76)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(102, 46)
        Me.Lb_Title.TabIndex = 7
        Me.Lb_Title.Text = "السعر"
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
        Me.btnadd.Location = New System.Drawing.Point(146, 620)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(9)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(603, 77)
        Me.btnadd.TabIndex = 5
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 14.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 14.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(12, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.Size = New System.Drawing.Size(372, 355)
        Me.DataGridView1.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 46)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "اختر المشتري"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(659, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 46)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "اختر الكتاب"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Location = New System.Drawing.Point(500, 66)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView2.RowHeadersWidth = 51
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowTemplate.Height = 35
        Me.DataGridView2.Size = New System.Drawing.Size(439, 355)
        Me.DataGridView2.TabIndex = 19
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
        Me.txt_title.Location = New System.Drawing.Point(554, 76)
        Me.txt_title.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(263, 46)
        Me.txt_title.TabIndex = 14
        Me.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_date
        '
        Me.txt_date.BackColor = System.Drawing.Color.SeaGreen
        Me.txt_date.BorderRadius = 0
        Me.txt_date.ForeColor = System.Drawing.Color.White
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.txt_date.FormatCustom = Nothing
        Me.txt_date.Location = New System.Drawing.Point(16, 66)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(197, 46)
        Me.txt_date.TabIndex = 15
        Me.txt_date.Value = New Date(2025, 1, 13, 23, 48, 1, 489)
        '
        'FRM_MAKESELL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(963, 710)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnadd)
        Me.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FRM_MAKESELL"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ADDBOKKS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lb_Title As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Public WithEvents btnadd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Public WithEvents txt_title As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents txt_date As Bunifu.Framework.UI.BunifuDatepicker
End Class
