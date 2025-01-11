<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DADD
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
        Me.Lb_Title = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lb_Title
        '
        Me.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lb_Title.AutoSize = True
        Me.Lb_Title.Font = New System.Drawing.Font("Wide Latin", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Title.ForeColor = System.Drawing.Color.White
        Me.Lb_Title.Location = New System.Drawing.Point(343, 233)
        Me.Lb_Title.Name = "Lb_Title"
        Me.Lb_Title.Size = New System.Drawing.Size(243, 42)
        Me.Lb_Title.TabIndex = 5
        Me.Lb_Title.Text = "تمت الاضافة بنجاح"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'FRM_DADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(948, 595)
        Me.Controls.Add(Me.Lb_Title)
        Me.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FRM_DADD"
        Me.Opacity = 0.85R
        Me.Text = "FRM_DADD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_Title As Label
    Private WithEvents Timer1 As Timer
End Class
