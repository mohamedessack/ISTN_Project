Imports Bunifu.Framework.UI

Public Class Promotion
    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PromoFormPnl.Controls.Add(childForm)
        PromoFormPnl.Tag = childForm
        childForm.BringToFront()
        childForm.Show()


    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        openChildForm(New newPromotion())
        slider1.Left = BunifuFlatButton1.Left
        slider1.Width = BunifuFlatButton1.Width



    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        openChildForm(New viewPromotion())
        slider1.Left = BunifuFlatButton2.Left
        slider1.Width = BunifuFlatButton2.Width
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        openChildForm(New UpdatePromotion())
        slider1.Left = BunifuFlatButton3.Left
        slider1.Width = BunifuFlatButton1.Width

    End Sub
    Private Sub newPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openChildForm(New newPromotion())
    End Sub

End Class