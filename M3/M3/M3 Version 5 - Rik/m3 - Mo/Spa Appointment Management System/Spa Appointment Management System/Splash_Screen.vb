Public Class Splash_Screen
    Private Sub Splash_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircleProgressbar1.Value = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircleProgressbar1.Value += 1
        If CircleProgressbar1.Value = 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()


        End If

    End Sub
End Class