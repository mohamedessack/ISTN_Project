Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Appointment
    Public Function GetTotal() As Double
        Dim Sum As Double
        Dim x As Double
        Dim Final As Double
        For i As Integer = 0 To ShangrilaDS.Invoice.Rows.Count - 1
            x += ShangrilaDS.Invoice.Rows(i)("Quantity_Purchased") * ShangrilaDS.Invoice.Rows(i)("Product_Price")
            Sum += ShangrilaDS.Invoice.Rows(i)("Service_Price")
            Final = (x + Sum)
        Next
        Return Final
    End Function

    Private Valid As Boolean
    Private SurnameValid As Boolean
    Private EmailValid As Boolean
    Dim init As TimeSpan
    Dim CustomerId As Integer
    Dim id As Integer
    Dim StaffServiceId As Integer
    Dim connection As String = "Data Source=146.230.177.46\ist3;Initial Catalog=group21;Persist Security Info=True;User ID=group21;Password=n9521"

    Dim ServiceId As Integer
    Dim ProductId As Integer
    Dim QTY As Integer
    Dim Result As DialogResult
    Dim duration As TimeSpan
    Dim AppDate As String



    Private Sub customer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShangrilaDS.PROMOTION' table. You can move, or remove it, as needed.
        Me.PROMOTIONTableAdapter.Fill(Me.ShangrilaDS.PROMOTION)
        'TODO: This line of code loads data into the 'ShangrilaDS.DTAbsent' table. You can move, or remove it, as needed.
        Me.DTAbsentTableAdapter.Fill(Me.ShangrilaDS.DTAbsent)
        'TODO: This line of code loads data into the 'ShangrilaDS.STAFF' table. You can move, or remove it, as needed.
        Me.STAFFTableAdapter.Fill(Me.ShangrilaDS.STAFF)
        'TODO: This line of code loads data into the 'ShangrilaDS.DTService' table. You can move, or remove it, as needed.
        Me.DTServiceTableAdapter.Fill(Me.ShangrilaDS.DTService)
        'TODO: This line of code loads data into the 'ShangrilaDS.DTProduct' table. You can move, or remove it, as needed.
        Me.DTProductTableAdapter.Fill(Me.ShangrilaDS.DTProduct)
        'TODO: This line of code loads data into the 'ShangrilaDS.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.ShangrilaDS.CUSTOMER)

            Dim sr As IO.StreamReader = Nothing
            Dim MyContents As New AutoCompleteStringCollection()
            If IO.File.Exists("C:\Users\Student\Documents\visual studio 2015\Projects\Spa Appointment Management System\Spa Appointment Management System\Spa Appointment Management System\bin\cities.txt") Then
                sr = IO.File.OpenText("C:\Users\Student\Documents\visual studio 2015\Projects\Spa Appointment Management System\Spa Appointment Management System\Spa Appointment Management System\bin\cities.txt")
                While Not sr.EndOfStream
                    MyContents.Add(sr.ReadLine)
                End While
                sr.Close()
            End If
        txtCity.AutoCompleteCustomSource = MyContents
        txtCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCity.AutoCompleteSource = AutoCompleteSource.CustomSource


        Dim lst As New List(Of String)

            'AutoComplete Collection that will help to filter keep the records.
            Dim MySource As New AutoCompleteStringCollection()
        lst.Add("KwaZulu-Natal")
        lst.Add("Limpopo")
            lst.Add("Gauteng")
            lst.Add("Free State")
            lst.Add("Mpumalanga")
            lst.Add("Limpopo")
            lst.Add("North West")
            lst.Add("Limpopo")
            lst.Add("Eastern Cape")
            lst.Add("Western Cape")
            lst.Add("Northern Cape")




            'Records binded to the AutocompleteStringCollection.
            MySource.AddRange(lst.ToArray)

        'this AutocompleteStringcollection binded to the textbox as custom
        'source.
        txtProvince.AutoCompleteCustomSource = MySource

        'Auto complete mode set to suggest append so that it will sugesst one
        'or more suggested completion strings it has bith ‘Suggest’ and
        '‘Append’ functionality
        txtProvince.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        'Set to Custom source we have filled already
        txtProvince.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub







        Private Sub MetroTabPage1_Enter(sender As Object, e As EventArgs) Handles MetroTabPage1.Enter
        step1.Visible = True

        step2.Visible = False

        step3.Visible = False


    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click


        If (FNameTextBox.Text = String.Empty) Or (LNameTextBox.Text = String.Empty) Or (Valid = False) Then
            MessageBox.Show("Please enter customer details", "Error")

        Else
            step1.Visible = False
            step3.Visible = False
            step2.Visible = True
            step2.Location = New Point(230, 90)
        End If


    End Sub











    Private Sub MetroTextBox7_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox7.TextChanged
        CustomerTableAdapter.FillBy(ShangrilaDS.CUSTOMER, MetroTextBox7.Text)

    End Sub





    Private Sub GunaCircleButton8_Click(sender As Object, e As EventArgs) Handles GunaCircleButton8.Click
        'This updated code segment uses a query from CustomerDGV to update fields in the Customer table...'
        '  Dim conn1 As New SqlConnection(connection)
        ' For i As Integer = 0 To CustomerDGV.Rows.Count - 1
        'Dim cmd7 As New SqlCommand("", conn1)
        'cmd7.CommandText = "update CUSTOMER set Customer_Fname='" & CustomerDGV.Rows(i).Cells(1).Value & "',Customer_Lname='" & CustomerDGV.Rows(i).Cells(2).Value & "',Main_Phone_Number='" & CustomerDGV.Rows(i).Cells(3).Value & "',Alternate_Phone_Number='" & CustomerDGV.Rows(i).Cells(4).Value & "',Email_Address='" & CustomerDGV.Rows(i).Cells(5).Value & "'where Customer_ID=" & CustomerDGV.Rows(i).Cells(0).Value
        'conn1.Open()
        'cmd7.ExecuteNonQuery()
        'conn1.Close()

        'Next
        'MessageBox.Show("Customer details successfully updated!")
        CUSTOMERBindingSource.EndEdit()
        CustomerTableAdapter.Update(ShangrilaDS.CUSTOMER)
        MessageBox.Show("Customer details successfully updated!")

    End Sub


    Private Sub FNameTextBox_Leave(sender As Object, e As EventArgs) Handles FNameTextBox.Leave
        'If Not A Matching Format Entered
        If Not Regex.Match(FNameTextBox.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            FNameTextBox.Focus() 'Return Focus
            FNameTextBox.Clear() 'Clear TextBox


            Valid = False 'Boolean = False
        Else

            Valid = True 'Everything Fine

        End If
    End Sub

    Private Sub LNameTextBox_Leave(sender As Object, e As EventArgs) Handles LNameTextBox.Leave
        'Create A Pattern For Surname
        Dim strSurname As String = "^[a-zA-Z\s]+$"

        Dim reSurname As New Regex(strSurname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not reSurname.IsMatch(LNameTextBox.Text) Then

            MessageBox.Show("Please Enter Alphabetic Characters Only!")

            LNameTextBox.Focus()

            LNameTextBox.Clear()


            Valid = False

        Else

            Valid = True

        End If

    End Sub


    Private Sub ValidateEmail()

        'Set Up Reg Exp Pattern To Allow Most Characters, And No Special Characters
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})",
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled
        )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(Email.Text)

        If blnPossibleMatch Then

            'Check If Entered Email Is In Correct Format
            If Not Email.Text.Equals(reEmail.Match(Email.Text).ToString) Then

                MessageBox.Show("Invalid Email Address!")

            Else

                EmailValid = True 'Email is Perfect

            End If

        Else 'Not A Match To Pattern

            EmailValid = False 'Set Boolean Variable To False

            MessageBox.Show("Invalid Email Address!") 'Inform User

            Email.Clear() 'Clear Textbox

            Email.Focus() 'Set Focus To TextBox

        End If

    End Sub



    Private Sub GunaCircleButton1_Click_1(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        TabPane1.SelectNextPage()
    End Sub

    Private Sub GunaCircleButton12_Click(sender As Object, e As EventArgs) Handles GunaCircleButton12.Click
        If (TxtAddress.Text = String.Empty) Or (txtCity.Text = String.Empty) Or (txtProvince.Text = String.Empty) Or (txtZip.Text = String.Empty) Or (Valid = False) Then
            MessageBox.Show("Please enter address details", "Error")
        Else

            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to add new customer?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then

                CustomerTableAdapter.Insert(FNameTextBox.Text, LNameTextBox.Text, TxtAddress.Text, txtCity.Text, txtProvince.Text, txtZip.Text, PNTextbox.Text, ENTextbox.Text, GenderComboBox.SelectedItem, "0", Email.Text, Label10.Text)
                CustomerTableAdapter.Fill(ShangrilaDS.CUSTOMER)
                CustomerDGV.Refresh()
                MessageBox.Show("New Customer Added", "CONFIRMATION")


            Else
                MessageBox.Show("Cancelled")
            End If
        End If
    End Sub

    Private Sub GunaCircleButton10_Click(sender As Object, e As EventArgs) Handles GunaCircleButton10.Click
        step2.Visible = False
        step3.Visible = False

        step1.Visible = True
    End Sub

    Private Sub GunaCircleButton9_Click(sender As Object, e As EventArgs) Handles GunaCircleButton9.Click
        If (PNTextbox.Text = String.Empty) Or (Email.Text = String.Empty) Or (Valid = False) Then
            MessageBox.Show("Please enter contact details")
        Else
            step2.Visible = False
            step1.Visible = False

            step3.Visible = True
            step3.Location = New Point(230, 90)
        End If
    End Sub

    Private Sub GunaCircleButton11_Click(sender As Object, e As EventArgs) Handles GunaCircleButton11.Click
        step1.Visible = False
        step3.Visible = False

        step2.Visible = True
    End Sub

    Private Sub PNTextbox_Leave(sender As Object, e As EventArgs) Handles PNTextbox.Leave
        If PNTextbox.Text.Length < 10 Then

            MessageBox.Show("Please Enter Valid Phone Number!")

            PNTextbox.Focus()

            PNTextbox.Clear()
            Valid = False
        Else
            Valid = True

        End If
    End Sub

    Private Sub ENTextbox_Leave(sender As Object, e As EventArgs) Handles ENTextbox.Leave
        If ENTextbox.Text.Length < 10 Then

            MessageBox.Show("Please Enter Valid Phone Number!")

            ENTextbox.Focus()

            ENTextbox.Clear()
            Valid = False
        Else
            Valid = True

        End If
    End Sub

    Private Sub txtZip_Leave(sender As Object, e As EventArgs) Handles txtZip.Leave
        If txtZip.Text.Length < 4 Then

            MessageBox.Show("Please Enter Valid Postal Code!")

            txtZip.Focus()

            txtZip.Clear()
            Valid = False
        Else
            Valid = True
        End If
    End Sub

    Private Sub Email_Leave(sender As Object, e As EventArgs) Handles Email.Leave
        ValidateEmail() 'Check Email Validity
    End Sub

    Private Sub GunaCircleButton13_Click(sender As Object, e As EventArgs) Handles GunaCircleButton13.Click


        'Dim conn As New SqlConnection(connection)
        'conn.Open()
        'Dim query As String = "Select APPOINTMENT.Appointment_Start_Time, APPOINTMENT.Appointment_End_Time, STAFF.Staff_Fname  FROM  APPOINTMENT,STAFF 
        '                               BETWEEN '" & ("Select APPOINTMENT.Appointment_Start_Time From APPOINTMENT").ToString & "'  AND '" & ("Select APPOINTMENT.Appointment_end_Time From APPOINTMENT").ToString & "' "

        ''("yyyy/MM/dd HH:MM:ss")


        'Dim command As New SqlCommand(query, conn)
        'command.Parameters.Add(New SqlParameter("@Appointment_Start_Time", SqlDbType.DateTime)).Value = DateTime.Parse(query)
        'command.Parameters.Add(New SqlParameter("@Appointment_End_Time", SqlDbType.DateTime)).Value = DateTime.Parse(query)

        ' Return command.ExecuteScalar()

        Dim FAppDate As String = GunaDateTimePicker1.Value.Year.ToString & "-"
        If GunaDateTimePicker1.Value.Month.ToString.Length = 1 Then
            FAppDate &= "0"
        End If
        FAppDate &= GunaDateTimePicker1.Value.Month.ToString & "-"
        If GunaDateTimePicker1.Value.Day.ToString.Length = 1 Then
            FAppDate &= "0"
        End If
        FAppDate &= GunaDateTimePicker1.Value.Day.ToString

        If DtAppointmentViewerTableAdapter1.CheckBooking(ShangrilaDS.DTAppointmentViewer, FAppDate, ComboBox1.Text) Then
            ' DateTimePicker1.Value,

            MessageBox.Show("Please select an available staff member")

        ElseIf (DateTimePicker1.Value.TimeOfDay < Now.TimeOfDay) And (GunaDateTimePicker1.Value = Date.Today) Then
            MessageBox.Show("Please select a time later than " + Now.TimeOfDay.ToString)
        Else

            TabPane1.SelectNextPage()
        End If


    End Sub

    Private Sub TabNavigationPage2_Enter(sender As Object, e As EventArgs) Handles TabNavigationPage2.Enter
        GunaDateTimePicker1.MinDate = Today()
        Dim availableDate As String = CStr(GunaDateTimePicker1.Value.Date)
        DTAbsentTableAdapter.SelectAvailableStaff(ShangrilaDS.DTAbsent, availableDate)
    End Sub

    Private Sub DateTimePicker1_Leave(sender As Object, e As EventArgs) Handles DateTimePicker1.Leave
        If (DateTimePicker1.Value.TimeOfDay <= Today.TimeOfDay) And (GunaDateTimePicker1.Value = Date.Today) Then
            MessageBox.Show("Please select a time later than " + Today.TimeOfDay.ToString)
        End If
    End Sub

    'Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles SNameSearch.TextChanged
    '    ServiceTableAdapter1.FillBy(ShangrilaDS.SERVICE, SNameSearch.Text)
    'End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs)
        TabPane1.SelectNextPage()

    End Sub

    Private Sub GunaCircleButton16_Click(sender As Object, e As EventArgs)
        ' Dim d As TimeSpan
        '   Dim AST As DateTime
        '   AST = TimeValue(DateTimePicker1.Text)
        '   Dim timeCheckin As String = Format(AST, "HH:mm:00")
        '  'd = TimeSpan.Parse(timeCheckin)
        ' TextBox3.Text = AST

        'Dim CFN As String
        'CFN = CustomerDGV.CurrentRow.Cells(1).Value
        'TextBox4.Text = CFN

        'Dim CLN As String
        'CLN = CustomerDGV.CurrentRow.Cells(2).Value
        'TextBox5.Text = CLN

        'Dim PN As String
        'PN = BunifuCustomDataGrid2.CurrentRow.Cells(0).Value
        'TextBox9.Text = PN

        'Dim Q As Integer
        'Dim Dr As DataRow
        'If BunifuCustomDataGrid2.CurrentRow.Cells(7).Value <> "" And BunifuCustomDataGrid2.CurrentRow.Cells(7).Value > 0 Then
        ' Dr = ShangrilaDS.Invoice.NewRow
        'Q = BunifuCustomDataGrid2.CurrentRow.Cells(7).Value
        'TextBox10.Text = Q
        'Else
        'TextBox10.Text = 0
        '        End If

        'Dim PP As Decimal
        'PP = BunifuCustomDataGrid2.CurrentRow.Cells(3).Value
        'TextBox11.Text = PP

        'Dim SN As String

        'If Result = DialogResult.No Or ServiceDG.Enabled = False Then
        'TextBox12.Text = "No Service"
        'Else
        'SN = ServiceDG.CurrentRow.Cells(0).Value
        'TextBox12.Text = SN
        'End If


        'Dim SP As Decimal

        'If Result = DialogResult.No Or ServiceDG.Enabled = False Then
        'TextBox13.Text = 0
        'Else
        'SP = ServiceDG.CurrentRow.Cells(3).Value
        'TextBox13.Text = SP
        'End If

        'If Products.ServiceDGV.CurrentRow.Cells(0).Value = viewPromotion.BunifuCustomDataGrid1.CurrentRow.Cells(1).Value Then
        '    SP = viewPromotion.BunifuCustomDataGrid1.CurrentRow.Cells(6).Value
        'End If


        ' Dim DRINV As DataRow
        'Dim Q As Integer
        'Q = BunifuCustomDataGrid2.CurrentRow.Cells(7).Value
        'TextBox10.Text = Q

        'For i As Integer = 0 To DataGridView1.Rows.Count - 1


        '    If BunifuCustomDataGrid2.Rows(i).Cells(7).Value <> "" And BunifuCustomDataGrid2.Rows(i).Cells(7).Value > 0 Then


        '        DRINV = ShangrilaDS.Invoice.NewRow
        '        DRINV.Item(0) = TextBox3.Text
        '        DRINV.Item(1) = TextBox4.Text
        '        DRINV.Item(2) = TextBox5.Text
        '        DRINV.Item(3) = TextBox9.Text
        '        DRINV.Item(4) = CInt(TextBox10.Text)
        '        DRINV.Item(5) = CDec(TextBox11.Text)
        '        DRINV.Item(6) = TextBox12.Text
        '        DRINV.Item(7) = CDec(TextBox13.Text)
        '        ShangrilaDS.Invoice.AddInvoiceRow(DRINV)
        '    Else
        '        TextBox10.Text = 0
        '    End If


        ' If BunifuCustomDataGrid2.CurrentRow.Cells(7).Value = "" Then
        'MessageBox.Show("Please enter a quantity in the Quantity column", "Quantity error")

        'Else

        'DRINV = ShangrilaDS.Invoice.NewRow
        'DRINV.Item(0) = TextBox3.Text
        'DRINV.Item(1) = TextBox4.Text
        'DRINV.Item(2) = TextBox5.Text
        'DRINV.Item(3) = TextBox9.Text
        'DRINV.Item(4) = CInt(TextBox10.Text)
        'DRINV.Item(5) = CDec(TextBox11.Text)
        'DRINV.Item(6) = TextBox12.Text
        'DRINV.Item(7) = CDec(TextBox13.Text)
        '
        'ShangrilaDS.Invoice.AddInvoiceRow(DRINV)
        'DRINV.Item(8) = (CInt(TextBox10.Text) * CDec(TextBox11.Text)) + CDec(TextBox13.Text)
        'TabNavigationPage5.PageVisible = True
        'TabPane1.SelectNextPage()

        'Dim Sum As Decimal

        'For i As Integer = 0 To ShangrilaDS.Invoice.Rows.Count - 1
        '    Dim Total As Decimal
        '    Total = (CInt(TextBox10.Text) * CDec(TextBox11.Text)) + CDec(TextBox13.Text)
        '    Sum += Total
        'Next


        'TextBox17.Text = GetTotal()
        'End If



        ' Next

        'Dim DV As Decimal
        'DV = ServiceDG.CurrentRow.Cells(0).Value
        'TextBox13.Text = DV

        'Dim VD As Integer
        ''VD = ServiceDG.CurrentRow.Cells(0).Value
        'TextBox13.Text = VD

        'Dim PD As String
        ''PD = ServiceDG.CurrentRow.Cells(0).Value
        'TextBox13.Text = PD

        ' InvoiceTableAdapter.insert(AST, CFN, CLN, PN, Q)







    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs)
        '  TabNavigationPage5.PageVisible = True
        ' TabPane1.SelectedPage = TabNavigationPage5


    End Sub

    Private Sub GunaCircleButton15_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub SNameSearch_TextChanged(sender As Object, e As EventArgs) Handles SNameSearch.TextChanged
        DTServiceTableAdapter.FillBy(ShangrilaDS.DTService, SNameSearch.Text)
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs)
        '  DTProductTableAdapter.FillBy(ShangrilaDS.DTProduct, MetroTextBox7.Text)
    End Sub

    Private Sub CustomerDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDGV.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = CustomerDGV.Rows(index)
        CustomerTextBox.Text = selectedRow.Cells(1).Value.ToString + " " + selectedRow.Cells(2).Value.ToString
        CustomerId = selectedRow.Cells(0).Value
    End Sub

    Private Sub GunaDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles GunaDateTimePicker1.ValueChanged
        Dim availableDate As String = CStr(GunaDateTimePicker1.Value.Date)
        DTAbsentTableAdapter.SelectAvailableStaff(ShangrilaDS.DTAbsent, availableDate)
    End Sub

    Private Sub GunaCircleButton14_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ServiceDG_DoubleClick(sender As Object, e As Object) Handles ServiceDG.DoubleClick

        duration = duration.Add(ServiceDG.CurrentRow.Cells(2).Value)



        init = init + duration
        Dim AppEndTime As String
        AppEndTime = AppDate + " " + init.ToString
        AppointmentTableAdapter1.UpdateQuery1(CDate(AppEndTime), id)

        Dim conn As New SqlConnection(connection)
        conn.Open()
        Dim query As String = "INSERT INTO STAFF_SERVICE
                         (Staff_ID,Service_Id) Output Inserted.Staff_Service_Id
VALUES        (@Staff_ID,@Service_Id); "
        Dim command As New SqlCommand(query, conn)
        command.Parameters.Add(New SqlParameter("@Staff_ID", SqlDbType.Int)).Value = CInt(ComboBox1.SelectedValue)
        command.Parameters.Add(New SqlParameter("@Service_Id", SqlDbType.Int)).Value = ServiceId

        StaffServiceId = command.ExecuteScalar

        LinE_ITEMTableAdapter1.InsertNoProduct(id, vbNull, StaffServiceId)
        MessageBox.Show("Service Added Successfully")




    End Sub

    Private Sub ServiceDG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiceDG.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = ServiceDG.Rows(index)

        ServiceId = selectedRow.Cells(5).Value
    End Sub

    Private Sub BunifuCustomDataGrid2_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub TabNavigationPage5_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        '  If RadioButton2.Checked = True Then
        ' Dim d As TimeSpan
        '    Dim AST As DateTime
        '   AST = TimeValue(DateTimePicker1.Text)
        '  Dim timeCheckin As String = Format(AST, "HH:mm:00")
        ' 'd = TimeSpan.Parse(timeCheckin)
        'TextBox3.Text = AST
        '
        'dim CFN As String
        'CFN = CustomerDGV.CurrentRow.Cells(1).Value
        'TextBox4.Text = CFN
        '
        'Dim CLN As String
        'CLN = CustomerDGV.CurrentRow.Cells(2).Value
        'TextBox5.Text = CLN

        ' Dim PN As String
        'PN = BunifuCustomDataGrid2.CurrentRow.Cells(0).Value
        'TextBox9.Text = PN

        'Dim Q As Integer
        'Dim Dr As DataRow
        'If BunifuCustomDataGrid2.CurrentRow.Cells(7).Value <> "" And BunifuCustomDataGrid2.CurrentRow.Cells(7).Value > 0 Then
        ' Dr = ShangrilaDS.Invoice.NewRow
        'Q = BunifuCustomDataGrid2.CurrentRow.Cells(7).Value
        'TextBox10.Text = Q
        '    Else
        'TextBox10.Text = 0
        'End If

        'Dim PP As Decimal
        'PP = BunifuCustomDataGrid2.CurrentRow.Cells(3).Value
        'TextBox11.Text = PP

        'Dim SN As String

        'If Result = DialogResult.No Or ServiceDG.Enabled = False Then
        'TextBox12.Text = "No Service"
        'Else
        'SN = ServiceDG.CurrentRow.Cells(0).Value
        'TextBox12.Text = SN
        'End If


        'Dim SP As Decimal

        'If Result = DialogResult.No Or ServiceDG.Enabled = False Then
        'TextBox13.Text = 0
        'Else
        'SP = ServiceDG.CurrentRow.Cells(3).Value
        'TextBox13.Text = SP
        'End If



        'Dim DRINV As DataRow
        'Dim Q As Integer
        'Q = BunifuCustomDataGrid2.CurrentRow.Cells(7).Value
        'TextBox10.Text = Q

        'For i As Integer = 0 To DataGridView1.Rows.Count - 1


        '    If BunifuCustomDataGrid2.Rows(i).Cells(7).Value <> "" And BunifuCustomDataGrid2.Rows(i).Cells(7).Value > 0 Then


        '        DRINV = ShangrilaDS.Invoice.NewRow
        '        DRINV.Item(0) = TextBox3.Text
        '        DRINV.Item(1) = TextBox4.Text
        '        DRINV.Item(2) = TextBox5.Text
        '        DRINV.Item(3) = TextBox9.Text
        '        DRINV.Item(4) = CInt(TextBox10.Text)
        '        DRINV.Item(5) = CDec(TextBox11.Text)
        '        DRINV.Item(6) = TextBox12.Text
        '        DRINV.Item(7) = CDec(TextBox13.Text)
        '        ShangrilaDS.Invoice.AddInvoiceRow(DRINV)
        '    Else
        '        TextBox10.Text = 0
        '    End If



        'DRINV = ShangrilaDS.Invoice.NewRow
        'DRINV.Item(0) = TextBox3.Text
        'DRINV.Item(1) = TextBox4.Text
        'DRINV.Item(2) = TextBox5.Text
        'DRINV.Item(3) = TextBox9.Text
        'DRINV.Item(4) = CInt(TextBox10.Text)
        'DRINV.Item(5) = CDec(TextBox11.Text)
        'DRINV.Item(6) = TextBox12.Text
        'DRINV.Item(7) = CDec(TextBox13.Text)

        'ShangrilaDS.Invoice.AddInvoiceRow(DRINV)
        'DRINV.Item(8) = (CInt(TextBox10.Text) * CDec(TextBox11.Text)) + CDec(TextBox13.Text)
        'TabNavigationPage5.PageVisible = True
        'TabPane1.SelectNextPage()




        'TextBox17.Text = GetTotal()




        ' Next

        'Dim DV As Decimal
        'DV = ServiceDG.CurrentRow.Cells(0).Value
        'TextBox13.Text = DV

        'Dim VD As Integer
        ''VD = ServiceDG.CurrentRow.Cells(0).Value
        'TextBox13.Text = VD

        'Dim PD As String
        ''PD = ServiceDG.CurrentRow.Cells(0).Value
        'TextBox13.Text = PD



        'End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton14_Click_1(sender As Object, e As EventArgs)
        'TabPane1.SelectPrevPage()
        'TextBox12.Clear()
        'TextBox13.Clear()
        '  ServiceDG.Hide()
        ' ServiceDG.Enabled = False
    End Sub
    Private Sub TabNavigationPage3_Enter(sender As Object, e As EventArgs) Handles TabNavigationPage3.Enter
        init = DateTimePicker1.Value.TimeOfDay
        AppDate = GunaDateTimePicker1.Value.ToShortDateString
        Dim AppTime As String
        AppTime = DateTimePicker1.Value.TimeOfDay.ToString
        Dim AppStartTime As String
        AppStartTime = AppDate + " " + AppTime

        '' AppointmentTableAdapter1.InsertAppointment(AppDate, CDate(AppStartTime), "Booked", CDate(AppEndTime), CustomerId)
        '' AppointmentTableAdapter1.

        Dim conn As New SqlConnection(connection)
        conn.Open()
        Dim query As String = "INSERT INTO APPOINTMENT
                         (Appointment_Date, Appointment_Start_Time,Appointment_End_Time, Appointment_Status, Customer_ID) Output Inserted.AppointmentID
VALUES        (@Appointment_Date,@Appointment_Start_Time,@Appointment_End_Time,@Appointment_Status,@Customer_ID); "
        Dim command As New SqlCommand(query, conn)
        command.Parameters.Add(New SqlParameter("@Appointment_Date", SqlDbType.Date)).Value = CDate(AppDate)
        command.Parameters.Add(New SqlParameter("@Appointment_Start_Time", SqlDbType.DateTime)).Value = DateTime.Parse(AppStartTime)
        command.Parameters.Add(New SqlParameter("@Appointment_Status", SqlDbType.VarChar)).Value = "Scheduled"
        command.Parameters.Add(New SqlParameter("@Appointment_End_Time", SqlDbType.DateTime)).Value = DateTime.Parse(AppDate)
        command.Parameters.Add(New SqlParameter("@Customer_ID", SqlDbType.Int)).Value = CustomerId
        id = command.ExecuteScalar

    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BunifuCustomDataGrid2_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs)
        '' Dim index As Integer
        ''/   index = e.RowIndex
        ''  Dim selectedRow As DataGridViewRow
        ''   selectedRow = BunifuCustomDataGrid2.Rows(index)

        '' ProductId = selectedRow.Cells(0).Value

        ''QTY = selectedRow.Cells(2).Value


        ''Dim Promo As Integer
        ''ProductPromotionTableAdapter1.Fill(ShangrilaDS.ProductPromotion, ProductId)
        ''If ShangrilaDS.ProductPromotion.Rows.Count = 0 Then
        ''LinE_ITEMTableAdapter1.InsertProduct(id, ProductId, QTY, vbNull)
        ''MessageBox.Show("Product Added Successfully")
        'Else
        'For Each row As DataRow In ShangrilaDS.ProductPromotion
        'Promo = row.Field(Of Integer)(0)
        'LinE_ITEMTableAdapter1.InsertProduct(id, ProductId, QTY, Promo)

        'Next
        'MessageBox.Show("Product Added Successfully")
        'End If
    End Sub



    Private Sub SNameSearch_Click(sender As Object, e As EventArgs) Handles SNameSearch.Click

    End Sub

    Private Sub CustomerTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ServiceDG_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiceDG.CellDoubleClick

    End Sub

    Private Sub ServiceDG_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiceDG.CellContentDoubleClick

    End Sub
End Class


