Imports System.Data.SqlClient
Public Class UpdateAppointment

    Dim connection As String = "Data Source=146.230.177.46\ist3;Initial Catalog=group21;Persist Security Info=True;User ID=group21;Password=n9521"
    Private Sub MetroDateTime2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShangrilaDS3.DTAppointmentViewer' table. You can move, or remove it, as needed.
        Me.DTAppointmentViewerTableAdapter.Fill(Me.ShangrilaDS3.DTAppointmentViewer)
        'TODO: This line of code loads data into the 'ShangrilaDS2.STAFF' table. You can move, or remove it, as needed.
        Me.STAFFTableAdapter.Fill(Me.ShangrilaDS2.STAFF)
        'TODO: This line of code loads data into the 'ShangrilaDS1.DTAppointmentViewer' table. You can move, or remove it, as needed.
        Me.DTAppointmentViewerTableAdapter.Fill(Me.ShangrilaDS1.DTAppointmentViewer)
        'TODO: This line of code loads data into the 'ShangrilaDS.DTUpdateAppointment' table. You can move, or remove it, as needed.
        Me.DTUpdateAppointmentTA.Fill(Me.ShangrilaDS.DTUpdateAppointment)
        GunaDateTimePicker1.MinDate = DateTime.Today

    End Sub

    Private Sub MetroTextBox7_Textchanged(sender As Object, e As EventArgs)
        '  DTUpdateAppointmentTA.FillBy(ShangrilaDS.DTUpdateAppointment, MetroTextBox7.Text)
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Dim AppDate As String = GunaDateTimePicker1.Value.Year.ToString & "-"
        If GunaDateTimePicker1.Value.Month.ToString.Length = 1 Then
            AppDate &= "0"
        End If
        AppDate &= GunaDateTimePicker1.Value.Month.ToString & "-"
        If GunaDateTimePicker1.Value.Day.ToString.Length = 1 Then
            AppDate &= "0"
        End If
        AppDate &= GunaDateTimePicker1.Value.Day.ToString


        AppointmentTA.UpdateDate(AppDate, BunifuCustomDataGrid1.CurrentRow.Cells(8).Value)
        DTAppointmentViewerTableAdapter.Fill(ShangrilaDS3.DTAppointmentViewer)
        BunifuCustomDataGrid1.Refresh()
    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click

        AppointmentTA.UpdateStatus(MetroComboBox1.SelectedItem, BunifuCustomDataGrid1.CurrentRow.Cells(8).Value)
        DTAppointmentViewerTableAdapter.Fill(ShangrilaDS3.DTAppointmentViewer)
        BunifuCustomDataGrid1.Refresh()

    End Sub

    Private Sub MetroComboBox1_MouseEnter(sender As Object, e As EventArgs) Handles MetroComboBox1.MouseEnter
        'Error Handling for Status Update - Trying to get the clicked rows index so that the row's Status value can be extracted to display suitable options in the ComboBox'
        ' If BunifuCustomDataGrid1.Rows(BunifuCustomDataGrid1.SelectedRow).Cells(3).Value = "Completed" Then'
        'Dont show all other options'

        ' End If'
    End Sub

    Private Sub SNameSearch_Textchanged(sender As Object, e As EventArgs) Handles SNameSearch.TextChanged
        DTAppointmentViewerTableAdapter.SearchCust(ShangrilaDS3.DTAppointmentViewer, SNameSearch.Text)
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click

        SNameSearch.Clear()
        DTAppointmentViewerTableAdapter.SearchStaff(ShangrilaDS3.DTAppointmentViewer, MetroComboBox2.Text)
    End Sub

    Private Sub GunaCircleButton5_Click(sender As Object, e As EventArgs) Handles GunaCircleButton5.Click

        TextBox1.Clear()
        SNameSearch.Clear()

        Dim AppDate As String = GunaDateTimePicker2.Value.Year.ToString & "-"
        If GunaDateTimePicker2.Value.Month.ToString.Length = 1 Then
            AppDate &= "0"
        End If
        AppDate &= GunaDateTimePicker2.Value.Month.ToString & "-"
        If GunaDateTimePicker2.Value.Day.ToString.Length = 1 Then
            AppDate &= "0"
        End If
        AppDate &= GunaDateTimePicker2.Value.Day.ToString

        TextBox1.Text = AppDate

        DTAppointmentViewerTableAdapter.SearchDate(ShangrilaDS3.DTAppointmentViewer, TextBox1.Text)

    End Sub

    Private Sub MetroTextBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton4_Click(sender As Object, e As EventArgs) Handles GunaCircleButton4.Click
        BunifuCustomDataGrid1.Refresh()
        DTAppointmentViewerTableAdapter.Fill(ShangrilaDS3.DTAppointmentViewer)
    End Sub
    'Private Sub RatingControl1_ItemClick(sender As Object, e As DevExpress.XtraEditors.Repository.ItemEventArgs) 
    '  CustomeR_FEEDBACKTableAdapter1.InsertQuery(RatingControl1.Rating.ToString, 1, BunifuCustomDataGrid1.CurrentRow.Cells(5).Value)
    '   MessageBox.Show("Customer Review Added")
    'End Sub
End Class