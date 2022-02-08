Public Class Staff
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShangrilaDS.DTAbsent' table. You can move, or remove it, as needed.
        Me.DTAbsentTableAdapter.Fill(Me.ShangrilaDS.DTAbsent)
        'TODO: This line of code loads data into the 'ShangrilaDS.STAFF_ABSENT' table. You can move, or remove it, as needed.
        Me.AbsentTA.Fill(Me.ShangrilaDS.STAFF_ABSENT)
        'TODO: This line of code loads data into the 'ShangrilaDS.STAFF' table. You can move, or remove it, as needed.
        Me.StaffTA.Fill(Me.ShangrilaDS.STAFF)
        StaffTA.Fill(ShangrilaDS1.STAFF)
        StartDate.MinDate = DateTime.Today
        EndDate.MinDate = DateTime.Today
    End Sub

    Private Sub SearchStaffTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchStaffTextBox.TextChanged
        DTAbsentTableAdapter.FillBy(ShangrilaDS.DTAbsent, SearchStaffTextBox.Text)
    End Sub

    Private Sub GunaCircleButton5_Click(sender As Object, e As EventArgs) Handles GunaCircleButton5.Click
        StaffTA.Insert(FNameTextBox.Text, LNameTextBox.Text, "Employee", ComboBox1.SelectedItem)
        StaffTA.Fill(ShangrilaDS.STAFF)
        StaffDGV.Refresh()
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Dim SDate As String = StartDate.Value.Year.ToString & "-"
        If StartDate.Value.Month.ToString.Length = 1 Then
            SDate &= "0"
        End If
        SDate &= StartDate.Value.Month.ToString & "-"
        If StartDate.Value.Day.ToString.Length = 1 Then
            SDate &= "0"
        End If
        SDate &= StartDate.Value.Day.ToString

        Dim EDate As String = EndDate.Value.Year.ToString & "-"
        If EndDate.Value.Month.ToString.Length = 1 Then
            EDate &= "0"
        End If
        EDate &= EndDate.Value.Month.ToString & "-"
        If EndDate.Value.Day.ToString.Length = 1 Then
            EDate &= "0"
        End If
        EDate &= EndDate.Value.Day.ToString

        Dim Result As DialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo)

        If Result = DialogResult.Yes Then
            Dim x As Integer = AbsentDGV.RowCount + 1


            StaffAbsentTA.InsertAbsentStaff(x, CInt(TextBox1.Text), SDate, EDate)
            DTAbsentTableAdapter.Fill(ShangrilaDS.DTAbsent)
            AbsentDGV.Refresh()

            SearchStaffTextBox.Clear()

            MessageBox.Show("Changes has been made")

        Else
            SearchStaffTextBox.Clear()
            MessageBox.Show("Cancelled")
        End If

    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        StaffBS.MoveNext()
    End Sub

    Private Sub PreviousBtn_Click(sender As Object, e As EventArgs) Handles PreviousBtn.Click
        StaffBS.MovePrevious()
    End Sub

    Private Sub AvailibilityUpdate_Click(sender As Object, e As EventArgs) Handles AvailibilityUpdate.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo)

        If Result = DialogResult.Yes Then
            StaffTA.UpdateAvailibility(ComboBox1.SelectedItem, StaffDGV.CurrentRow.Cells(0).Value)
            StaffTA.Fill(ShangrilaDS.STAFF)
            StaffDGV.Refresh()
            MessageBox.Show("Update Completed")

            ComboBox1.ResetText()
        Else
            MessageBox.Show("Cancelled")
            ComboBox1.ResetText()
        End If
    End Sub

    Private Sub GunaCircleButton6_Click(sender As Object, e As EventArgs) Handles GunaCircleButton6.Click
        Dim EDate As String = EndDate.Value.Year.ToString & "-"
        If EndDate.Value.Month.ToString.Length = 1 Then
            EDate &= "0"
        End If
        EDate &= EndDate.Value.Month.ToString & "-"
        If EndDate.Value.Day.ToString.Length = 1 Then
            EDate &= "0"
        End If
        EDate &= EndDate.Value.Day.ToString

        StaffAbsentTA.UpdateEDate(EDate, AbsentDGV.CurrentRow.Cells(2).Value)
        DTAbsentTableAdapter.Fill(ShangrilaDS.DTAbsent)
    End Sub
End Class