Public Class Invoice
    Dim iSales As Integer


    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load        'TODO: This line of code loads data into the 'ShangrilaDS1.DTAppointmentViewer' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'ShangrilaDS1.PRODUCT' table. You can move, or remove it, as needed.
        Me.PRODUCTTableAdapter.Fill(Me.ShangrilaDS1.PRODUCT)
        'TODO: This line of code loads data into the 'ShangrilaDS.LINE_ITEM' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ShangrilaDS1.PRODUCT' table. You can move, or remove it, as needed.

        Me.DtViewAppointmentTableAdapter1.Fill(Me.ShangrilaDS1.dtViewAppointment)
        BunifuCustomDataGrid1.Visible = False
        BunifuCustomDataGrid2.Visible = False
        MetroTextBox7.Visible = False
        BunifuCustomDataGrid3.Visible = False

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.InvoiceTableAdapter.Fill(Me.ShangrilaDS1.Invoice, ComboBox1.Text)
    End Sub













    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        Me.InvoiceTableAdapter.Fill(Me.ShangrilaDS1.Invoice, ComboBox1.Text)
        iSales = 0
    End Sub

    Private Sub ComboBox2_Leave(sender As Object, e As EventArgs) Handles ComboBox2.Leave
        Me.InvoiceTableAdapter.FillGrid(Me.ShangrilaDS1.Invoice, ComboBox1.Text, CInt(ComboBox2.Text))

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted

        ComboBox2.Text = ComboBox2.SelectedValue.ToString
        ComboBox1.Focus()
        BunifuCustomDataGrid1.Visible = True
        If BunifuCustomDataGrid1.RowCount > 1 Then

            iSales = 0
            'if you have the other column to get the result you  could add a new one like these above 
            For index As Integer = 0 To BunifuCustomDataGrid1.RowCount - 1

                iSales += Convert.ToInt32(BunifuCustomDataGrid1.Rows(index).Cells(7).Value)
                'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
            Next

            TextBox6.Text = iSales
            'if you have the other column to get the result you  could add a new one like these above 
        End If

    End Sub


    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick

    End Sub

    Private Sub BunifuCustomDataGrid1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellEnter
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = BunifuCustomDataGrid1.Rows(index)
        v.Text = selectedRow.Cells(0).Value.ToString
        TextBox3.Text = selectedRow.Cells(2).Value
        TextBox9.Text = selectedRow.Cells(3).Value + " " + selectedRow.Cells(4).Value + vbNewLine + selectedRow.Cells(5).Value

    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        BunifuCustomDataGrid1.Visible = False
        iSales = 0
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        BunifuCustomDataGrid2.Visible = True
        MetroTextBox7.Visible = True
        Label2.Visible = True
    End Sub


    Private Sub BunifuCustomDataGrid2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid2.CellDoubleClick
        Dim ProductId As Integer

        Dim qty As Integer
        qty = 0
        Dim index As Integer
        index = 0
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = BunifuCustomDataGrid2.Rows(index)


        ProductId = selectedRow.Cells(0).Value

        qty = selectedRow.Cells(8).Value
        Dim id As Integer
        id = CInt(v.Text)
        Dim qtyAvail As Integer
        qtyAvail = selectedRow.Cells(4).Value
        If qty > qtyAvail Then
            MessageBox.Show("Insufficient Stock ! " + " " + qtyAvail.ToString + " " + "Units Available", "Insufficient Stock")

        Else
            LinE_ITEMTableAdapter1.InsertProduct(id, ProductId, qty)
            MessageBox.Show("Product Added Successfully")
            BunifuCustomDataGrid2.Visible = False
            BunifuCustomDataGrid3.Visible = True
            Me.LinE_ITEMTableAdapter1.Fill(Me.ShangrilaDS.LINE_ITEM, CInt(v.Text))
            If BunifuCustomDataGrid3.RowCount > 1 Then


                'if you have the other column to get the result you  could add a new one like these above 
                For i As Integer = 0 To BunifuCustomDataGrid3.RowCount - 1

                    iSales += Convert.ToInt32(BunifuCustomDataGrid3.Rows(i).Cells(1).Value) * Convert.ToInt32(BunifuCustomDataGrid3.Rows(i).Cells(3).Value)
                    'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
                Next

                TextBox6.Text = iSales
                'if you have the other column to get the result you  could add a new one like these above 
            End If
            Dim AvailQty As Integer
            AvailQty = qtyAvail - qty
            PRODUCTTableAdapter.UpdateProdQty(AvailQty, ProductId)

        End If

    End Sub

    Private Sub MetroTextBox7_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox7.TextChanged
        PRODUCTTableAdapter.FillBy(ShangrilaDS1.PRODUCT, MetroTextBox7.Text)
    End Sub

    Private Sub MetroTextBox7_Click(sender As Object, e As EventArgs) Handles MetroTextBox7.Click
        BunifuCustomDataGrid2.Visible = True
        BunifuCustomDataGrid3.Visible = False
    End Sub

    Private Sub imgPrint_Click(sender As Object, e As EventArgs) Handles imgPrint.Click
        GunaCircleButton1.Visible = False
        Label2.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()





    End Sub


End Class