Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        Me.WindowState = FormWindowState.Maximized
        If (loginForm.loggedIn = False) Then
            btnProdServ.Hide()
            ' Just adjust which buttons need to be hidden for a average staff member viewing this page here guys...'
            btnStaff.Hide()
            btnDash.Hide()
            btnPromo.Hide()
            btnLogout.Hide()
        Else
            btnProdServ.Show()
            ' Just adjust which buttons need to be shown for a average staff member viewing this page here guys...'
            btnStaff.Show()
            btnDash.Show()
            btnPromo.Show()
        End If

    End Sub
    Private Sub hideSubmenu()
        SubmenuPanel.Visible = False
    End Sub
    Private Sub showSubmenu(ByVal submenu)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        childPanel.Controls.Add(childForm)
        childPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles logoPanel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        openChildForm(New loginForm())
        hideSubmenu()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New Appointment())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub childPanel_Paint(sender As Object, e As PaintEventArgs) Handles childPanel.Paint

    End Sub

    Private Sub AppointmentBtn_Click(sender As Object, e As EventArgs) Handles AppointmentBtn.Click
        showSubmenu(SubmenuPanel)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openChildForm(New UpdateAppointment())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnPromo.Click
        openChildForm(New Promotion())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnProdServ.Click
        openChildForm(New Products())
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        openChildForm(New Staff())
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        ' openChildForm(New DASHBOARD())
        openChildForm(New Reports())
        ' <dxdash:Dashboardcontrol dashboardsource = "..\..\Dashboard designer reports.xml" />

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If (MessageBox.Show("Are you sure you want to log out, Anneline?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.Yes Then
            loginForm.loggedIn = False     'Double check this variable name, can't view at the moment'
            btnProdServ.Hide()
            btnStaff.Hide()
            btnDash.Hide()
            btnPromo.Hide()
            btnLogout.Hide()
            loginButton.Show()

            currentForm.Hide()

            MessageBox.Show("Log out Successful!")
        Else
            MessageBox.Show("Current Status: Logged In")
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        openChildForm(New Invoice())
    End Sub
End Class
