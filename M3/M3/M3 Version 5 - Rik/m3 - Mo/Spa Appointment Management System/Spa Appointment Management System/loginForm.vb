Public Class loginForm
    Public Shared loggedIn As Boolean = False
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' tboxPass.PasswordChar = "*"
        tboxPass.UseSystemPasswordChar = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (tboxUsername.Text = "Anneline") And (tboxPass.Text = "Scarlett@14") Then
            loggedIn = True
            MsgBox("Success. Welcome Anneline! ")
            Form1.btnProdServ.Show()
            ' Just adjust which buttons need to be shown for a average staff member viewing this page here guys...'
            Form1.btnStaff.Show()
            Form1.btnDash.Show()
            Form1.btnPromo.Show()
            Form1.btnLogout.Show()
            tboxPass.Text = ""
            tboxUsername.Text = ""
            Form1.Show()
            Form1.loginButton.Hide()
            Me.Hide()


        Else
            MsgBox("Incorrect Username or Password entered.")
            tboxPass.Text = ""
            tboxUsername.Text = ""


        End If
    End Sub

    Private Sub picPass_Click(sender As Object, e As EventArgs)
        If tboxPass.UseSystemPasswordChar = False Then
            tboxPass.UseSystemPasswordChar = True
        Else
            tboxPass.UseSystemPasswordChar = False
        End If
    End Sub
End Class