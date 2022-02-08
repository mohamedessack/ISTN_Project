<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash_Screen))
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.CircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = CType(resources.GetObject("GunaTransfarantPictureBox1.Image"), System.Drawing.Image)
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(66, 12)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(395, 172)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 0
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'CircleProgressbar1
        '
        Me.CircleProgressbar1.animated = True
        Me.CircleProgressbar1.animationIterval = 5
        Me.CircleProgressbar1.animationSpeed = 300
        Me.CircleProgressbar1.BackColor = System.Drawing.Color.Honeydew
        Me.CircleProgressbar1.BackgroundImage = CType(resources.GetObject("CircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.CircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.CircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen
        Me.CircleProgressbar1.LabelVisible = True
        Me.CircleProgressbar1.LineProgressThickness = 8
        Me.CircleProgressbar1.LineThickness = 5
        Me.CircleProgressbar1.Location = New System.Drawing.Point(145, 193)
        Me.CircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.CircleProgressbar1.MaxValue = 100
        Me.CircleProgressbar1.Name = "CircleProgressbar1"
        Me.CircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.CircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.CircleProgressbar1.Size = New System.Drawing.Size(201, 201)
        Me.CircleProgressbar1.TabIndex = 1
        Me.CircleProgressbar1.Value = 0
        '
        'Timer1
        '
        '
        'Splash_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(519, 412)
        Me.Controls.Add(Me.CircleProgressbar1)
        Me.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash_Screen"
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents CircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Timer1 As Timer
End Class
