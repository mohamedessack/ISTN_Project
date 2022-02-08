<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.btnDash = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnProdServ = New System.Windows.Forms.Button()
        Me.btnPromo = New System.Windows.Forms.Button()
        Me.SubmenuPanel = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AppointmentBtn = New System.Windows.Forms.Button()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logoPanel = New System.Windows.Forms.PictureBox()
        Me.childPanel = New System.Windows.Forms.Panel()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuPanel.SuspendLayout()
        Me.SubmenuPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.logoPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.childPanel.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.btnDash)
        Me.MenuPanel.Controls.Add(Me.btnStaff)
        Me.MenuPanel.Controls.Add(Me.btnProdServ)
        Me.MenuPanel.Controls.Add(Me.btnPromo)
        Me.MenuPanel.Controls.Add(Me.SubmenuPanel)
        Me.MenuPanel.Controls.Add(Me.AppointmentBtn)
        Me.MenuPanel.Controls.Add(Me.loginButton)
        Me.MenuPanel.Controls.Add(Me.Panel3)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(211, 600)
        Me.MenuPanel.TabIndex = 0
        '
        'btnDash
        '
        Me.btnDash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDash.FlatAppearance.BorderSize = 0
        Me.btnDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDash.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDash.ForeColor = System.Drawing.Color.Black
        Me.btnDash.Image = CType(resources.GetObject("btnDash.Image"), System.Drawing.Image)
        Me.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDash.Location = New System.Drawing.Point(0, 517)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Size = New System.Drawing.Size(211, 59)
        Me.btnDash.TabIndex = 7
        Me.btnDash.Text = "   Dashboard"
        Me.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDash.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.Black
        Me.btnStaff.Image = CType(resources.GetObject("btnStaff.Image"), System.Drawing.Image)
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(0, 458)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(211, 59)
        Me.btnStaff.TabIndex = 6
        Me.btnStaff.Text = "   Staff"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnProdServ
        '
        Me.btnProdServ.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProdServ.FlatAppearance.BorderSize = 0
        Me.btnProdServ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnProdServ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnProdServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdServ.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdServ.ForeColor = System.Drawing.Color.Black
        Me.btnProdServ.Image = CType(resources.GetObject("btnProdServ.Image"), System.Drawing.Image)
        Me.btnProdServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProdServ.Location = New System.Drawing.Point(0, 399)
        Me.btnProdServ.Name = "btnProdServ"
        Me.btnProdServ.Size = New System.Drawing.Size(211, 59)
        Me.btnProdServ.TabIndex = 5
        Me.btnProdServ.Text = " Product \ Service"
        Me.btnProdServ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProdServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProdServ.UseVisualStyleBackColor = True
        '
        'btnPromo
        '
        Me.btnPromo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPromo.FlatAppearance.BorderSize = 0
        Me.btnPromo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnPromo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPromo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromo.ForeColor = System.Drawing.Color.Black
        Me.btnPromo.Image = CType(resources.GetObject("btnPromo.Image"), System.Drawing.Image)
        Me.btnPromo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPromo.Location = New System.Drawing.Point(0, 341)
        Me.btnPromo.Name = "btnPromo"
        Me.btnPromo.Size = New System.Drawing.Size(211, 58)
        Me.btnPromo.TabIndex = 4
        Me.btnPromo.Text = "  Promotion"
        Me.btnPromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPromo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPromo.UseVisualStyleBackColor = True
        '
        'SubmenuPanel
        '
        Me.SubmenuPanel.Controls.Add(Me.Button6)
        Me.SubmenuPanel.Controls.Add(Me.Button5)
        Me.SubmenuPanel.Controls.Add(Me.Button1)
        Me.SubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubmenuPanel.Location = New System.Drawing.Point(0, 200)
        Me.SubmenuPanel.Name = "SubmenuPanel"
        Me.SubmenuPanel.Size = New System.Drawing.Size(211, 141)
        Me.SubmenuPanel.TabIndex = 3
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 90)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(211, 44)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "   Invoice"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 50)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(211, 40)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "        Update"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(211, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "  Create"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AppointmentBtn
        '
        Me.AppointmentBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppointmentBtn.FlatAppearance.BorderSize = 0
        Me.AppointmentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.AppointmentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.AppointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AppointmentBtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentBtn.ForeColor = System.Drawing.Color.Black
        Me.AppointmentBtn.Image = CType(resources.GetObject("AppointmentBtn.Image"), System.Drawing.Image)
        Me.AppointmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AppointmentBtn.Location = New System.Drawing.Point(0, 150)
        Me.AppointmentBtn.Name = "AppointmentBtn"
        Me.AppointmentBtn.Size = New System.Drawing.Size(211, 50)
        Me.AppointmentBtn.TabIndex = 2
        Me.AppointmentBtn.Text = "  Appointment"
        Me.AppointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AppointmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AppointmentBtn.UseVisualStyleBackColor = True
        '
        'loginButton
        '
        Me.loginButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.loginButton.FlatAppearance.BorderSize = 0
        Me.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.Color.Black
        Me.loginButton.Image = CType(resources.GetObject("loginButton.Image"), System.Drawing.Image)
        Me.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginButton.Location = New System.Drawing.Point(0, 100)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(211, 50)
        Me.loginButton.TabIndex = 1
        Me.loginButton.Text = "  Login"
        Me.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.logoPanel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(211, 100)
        Me.Panel3.TabIndex = 0
        '
        'logoPanel
        '
        Me.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.logoPanel.Image = CType(resources.GetObject("logoPanel.Image"), System.Drawing.Image)
        Me.logoPanel.InitialImage = CType(resources.GetObject("logoPanel.InitialImage"), System.Drawing.Image)
        Me.logoPanel.Location = New System.Drawing.Point(0, 0)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(211, 100)
        Me.logoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPanel.TabIndex = 0
        Me.logoPanel.TabStop = False
        '
        'childPanel
        '
        Me.childPanel.BackColor = System.Drawing.Color.White
        Me.childPanel.BackgroundImage = CType(resources.GetObject("childPanel.BackgroundImage"), System.Drawing.Image)
        Me.childPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.childPanel.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.childPanel.Controls.Add(Me.Panel1)
        Me.childPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.childPanel.ForeColor = System.Drawing.Color.Black
        Me.childPanel.Location = New System.Drawing.Point(211, 0)
        Me.childPanel.Name = "childPanel"
        Me.childPanel.Size = New System.Drawing.Size(739, 600)
        Me.childPanel.TabIndex = 1
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = CType(resources.GetObject("GunaTransfarantPictureBox1.Image"), System.Drawing.Image)
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(114, 165)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(474, 253)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 3
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 33)
        Me.Panel1.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(658, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(27, 33)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(685, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 33)
        Me.Button4.TabIndex = 1
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(712, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 33)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(950, 600)
        Me.Controls.Add(Me.childPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuPanel.ResumeLayout(False)
        Me.SubmenuPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.logoPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.childPanel.ResumeLayout(False)
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents logoPanel As PictureBox
    Friend WithEvents childPanel As Panel
    Friend WithEvents loginButton As Button
    Friend WithEvents AppointmentBtn As Button
    Friend WithEvents SubmenuPanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnPromo As Button
    Friend WithEvents btnProdServ As Button
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button6 As Button
End Class
