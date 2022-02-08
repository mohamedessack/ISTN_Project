<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Dim picPass As System.Windows.Forms.PictureBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboxPass = New System.Windows.Forms.TextBox()
        Me.tboxUsername = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        picPass = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(picPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.BackColor = System.Drawing.Color.White
        PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        PictureBox1.Location = New System.Drawing.Point(135, 0)
        PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(139, 124)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        AddHandler PictureBox1.Click, AddressOf Me.PictureBox1_Click
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Aquamarine
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.FlowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(983, 227)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(picPass)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tboxPass)
        Me.Panel1.Controls.Add(Me.tboxUsername)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(236, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 343)
        Me.Panel1.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(20, 298)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(115, 37)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "         Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(17, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "          Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(18, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "  Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tboxPass
        '
        Me.tboxPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tboxPass.Location = New System.Drawing.Point(60, 262)
        Me.tboxPass.Multiline = True
        Me.tboxPass.Name = "tboxPass"
        Me.tboxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboxPass.Size = New System.Drawing.Size(290, 27)
        Me.tboxPass.TabIndex = 6
        Me.tboxPass.UseSystemPasswordChar = True
        '
        'tboxUsername
        '
        Me.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tboxUsername.Location = New System.Drawing.Point(60, 181)
        Me.tboxUsername.Multiline = True
        Me.tboxUsername.Name = "tboxUsername"
        Me.tboxUsername.Size = New System.Drawing.Size(290, 27)
        Me.tboxUsername.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel3.Location = New System.Drawing.Point(60, 291)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(290, 1)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel2.Location = New System.Drawing.Point(60, 210)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 1)
        Me.Panel2.TabIndex = 3
        '
        'picPass
        '
        picPass.BackColor = System.Drawing.Color.White
        picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        picPass.Image = CType(resources.GetObject("picPass.Image"), System.Drawing.Image)
        picPass.Location = New System.Drawing.Point(353, 246)
        picPass.Margin = New System.Windows.Forms.Padding(0)
        picPass.Name = "picPass"
        picPass.Size = New System.Drawing.Size(47, 46)
        picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        picPass.TabIndex = 10
        picPass.TabStop = False
        AddHandler picPass.Click, AddressOf Me.picPass_Click
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(983, 610)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginForm"
        Me.Text = "loginForm"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(picPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tboxUsername As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tboxPass As TextBox
    Friend WithEvents btnLogin As Button
End Class
