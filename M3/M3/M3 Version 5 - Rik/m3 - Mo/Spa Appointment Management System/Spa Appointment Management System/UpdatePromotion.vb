Public Class UpdatePromotion


    Private Sub UpdatePromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShangrilaDS.PROMOTION' table. You can move, or remove it, as needed.
        Me.TAPROMOTION.Fill(Me.ShangrilaDS.PROMOTION)
        GunaDateTimePicker1.MinDate = DateTime.Today
    End Sub

    Private Sub GunaCircleButton6_Click(sender As Object, e As EventArgs) Handles GunaCircleButton6.Click
        Dim PromoEDate As String = GunaDateTimePicker1.Value.Year.ToString & "-"
        If GunaDateTimePicker1.Value.Month.ToString.Length = 1 Then
            PromoEDate &= "0"
        End If
        PromoEDate &= GunaDateTimePicker1.Value.Month.ToString & "-"
        If GunaDateTimePicker1.Value.Day.ToString.Length = 1 Then
            PromoEDate &= "0"
        End If
        PromoEDate &= GunaDateTimePicker1.Value.Day.ToString


        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Promo end date?", "Confirm", MessageBoxButtons.YesNo)

        If Result = DialogResult.Yes Then

            TAPROMOTION.UpdatePromoEndDate(PromoEDate, BunifuCustomDataGrid1.CurrentRow.Cells(0).Value)
            TAPROMOTION.Fill(ShangrilaDS.PROMOTION)
            MessageBox.Show("Update has been confirmed")

        Else
            MessageBox.Show("Update cancelled")
        End If

    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click

        Try

            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Promo Type?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then

                TAPROMOTION.UpdatePromoType(PromoComboBox.SelectedItem, BunifuCustomDataGrid1.CurrentRow.Cells(0).Value)
                TAPROMOTION.Fill(ShangrilaDS.PROMOTION)
                MessageBox.Show("Update has been confirmed")

            Else
                MessageBox.Show("Update cancelled")
            End If

            PromoComboBox.ResetText()

        Catch exception As Exception
            MessageBox.Show("Please select a Promo type", "Promotype")
        End Try

    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click
        Try
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Promo Price?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then

                TAPROMOTION.UpdatePromoPrice((MetroTextBox3.Text), BunifuCustomDataGrid1.CurrentRow.Cells(0).Value)
                TAPROMOTION.Fill(ShangrilaDS.PROMOTION)
                MessageBox.Show("Update has been confirmed")

            Else
                MessageBox.Show("Update cancelled")
            End If

            MetroTextBox3.Clear()
        Catch exception As Exception
            MessageBox.Show("Please enter numerical values", "Promo Price")
            MetroTextBox3.Clear()
        End Try
    End Sub

    Private Sub GunaCircleButton4_Click(sender As Object, e As EventArgs) Handles GunaCircleButton4.Click
        Try

            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Promo Volume Discount?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then

                TAPROMOTION.UpdateVolumeDiscount(MetroTextBox4.Text, BunifuCustomDataGrid1.CurrentRow.Cells(0).Value)
                TAPROMOTION.Fill(ShangrilaDS.PROMOTION)
                MessageBox.Show("Update has been confirmed")

            Else
                MessageBox.Show("Update cancelled")
            End If

            MetroTextBox4.Clear()
        Catch exception As Exception
            MessageBox.Show("Please enter numerical values", "Volume discount")
            MetroTextBox4.Clear()
        End Try
    End Sub

    Private Sub MetroTextBox1_Textchanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged
        TAPROMOTION.FillBy(ShangrilaDS.PROMOTION, MetroTextBox1.Text)
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Try
            Dim PromoEDate As String = GunaDateTimePicker1.Value.Year.ToString & "-"
            If GunaDateTimePicker1.Value.Month.ToString.Length = 1 Then
                PromoEDate &= "0"
            End If
            PromoEDate &= GunaDateTimePicker1.Value.Month.ToString & "-"
            If GunaDateTimePicker1.Value.Day.ToString.Length = 1 Then
                PromoEDate &= "0"
            End If
            PromoEDate &= GunaDateTimePicker1.Value.Day.ToString

            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update All?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then

                TAPROMOTION.UpdateAllPromos(PromoEDate, PromoComboBox.SelectedItem, MetroTextBox3.Text, MetroTextBox4.Text, BunifuCustomDataGrid1.CurrentRow.Cells(0).Value)
                TAPROMOTION.Fill(ShangrilaDS.PROMOTION)
                MessageBox.Show("Update has been confirmed")

            Else
                MessageBox.Show("Update cancelled")
            End If
        Catch exception As Exception
            MessageBox.Show("Please do not leave any blank fields", "Blank Fields")
        End Try

    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = BunifuCustomDataGrid1.Rows(index)
        PromoComboBox.Text = selectedRow.Cells(5).Value.ToString
        MetroTextBox3.Text = selectedRow.Cells(6).Value.ToString
        MetroTextBox4.Text = selectedRow.Cells(7).Value.ToString
    End Sub


End Class