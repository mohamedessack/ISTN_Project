Public Class viewPromotion
    Private Sub viewPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShangrilaDS.PROMOTION' table. You can move, or remove it, as needed.
        Me.PROMOTIONTableAdapter.Fill(Me.ShangrilaDS.PROMOTION)

    End Sub

    Private Sub MetroTextBox1_Textchanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged
        PROMOTIONTableAdapter.FillBy(ShangrilaDS.PROMOTION, MetroTextBox1.Text)
    End Sub
End Class