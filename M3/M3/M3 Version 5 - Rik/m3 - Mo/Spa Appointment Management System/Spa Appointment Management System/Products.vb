Public Class Products
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShangrilaDS.SUPPLIER' table. You can move, or remove it, as needed.
        Me.SUPPLIERTableAdapter.Fill(Me.ShangrilaDS.SUPPLIER)
        'TODO: This line of code loads data into the 'ShangrilaDS.PRODUCT_TYPE' table. You can move, or remove it, as needed.
        Me.PRODUCT_TYPETableAdapter.Fill(Me.ShangrilaDS.PRODUCT_TYPE)
        'TODO: This line of code loads data into the 'ShangrilaDS.PRODUCT_TYPE' table. You can move, or remove it, as needed.
        Me.PRODUCT_TYPETableAdapter.Fill(Me.ShangrilaDS.PRODUCT_TYPE)
        'TODO: This line of code loads data into the 'ShangrilaDS.SERVICE_TYPE' table. You can move, or remove it, as needed.
        Me.SERVICE_TYPETableAdapter.Fill(Me.ShangrilaDS.SERVICE_TYPE)
        'TODO: This line of code loads data into the 'ShangrilaDS.SERVICE' table. You can move, or remove it, as needed.
        Me.ServiceTA.Fill(Me.ShangrilaDS.SERVICE)
        'TODO: This line of code loads data into the 'ShangrilaDS.PRODUCT' table. You can move, or remove it, as needed.
        Me.ProductTA.Fill(Me.ShangrilaDS.PRODUCT)

    End Sub

    Private Sub GunaCircleButton5_Click(sender As Object, e As EventArgs) Handles GunaCircleButton5.Click
        Try

            Dim ProductType As Integer

            If ProdTypeComboBox.SelectedIndex = 0 Then
                ProductType = 1

            ElseIf ProdTypeComboBox.SelectedIndex = 1 Then
                ProductType = 2

            ElseIf ProdTypeComboBox.SelectedIndex = 2 Then
                ProductType = 3

            ElseIf ProdTypeComboBox.SelectedIndex = 3 Then
                ProductType = 4

            ElseIf ProdTypeComboBox.SelectedIndex = 4 Then
                ProductType = 5

            ElseIf ProdTypeComboBox.SelectedIndex = 5 Then
                ProductType = 6

            ElseIf ProdTypeComboBox.SelectedIndex = 6 Then
                ProductType = 7

            ElseIf ProdTypeComboBox.SelectedIndex = 7 Then
                ProductType = 8

            ElseIf ProdTypeComboBox.SelectedIndex = 8 Then
                ProductType = 9
            End If

            Dim SupplierType As Integer

            If SupplierComboBox.SelectedIndex = 0 Then
                SupplierType = 1

            Else SupplierType = 2
            End If

            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to Add a new Product?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then


                ProductTA.Insert(ProductType, ProductNameTextBox.Text, CInt(PriceTextBox.Text), CInt(CostTextBox.Text), CInt(QtyAvailTextBox.Text), SupplierType, PStatusComboBox.SelectedItem)
                ProductTA.Fill(ShangrilaDS.PRODUCT)
                ProductDGV.Refresh()
                MessageBox.Show("New Product Added")

            Else
                MessageBox.Show("Cancelled")
            End If
            ProductNameTextBox.ResetText()
            PriceTextBox.ResetText()
            CostTextBox.ResetText()
            QtyAvailTextBox.ResetText()
            ProdTypeComboBox.ResetText()
            SupplierComboBox.ResetText()
            PStatusComboBox.ResetText()
        Catch exception As Exception
            MessageBox.Show("Please do not leave any blank fields", "Blank fields")

        End Try

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Try

            Dim ServiceType As Integer

            If STypeCombobox.SelectedIndex = 0 Then
                ServiceType = 1
            ElseIf STypeCombobox.SelectedIndex = 1 Then
                ServiceType = 2
            ElseIf STypeCombobox.SelectedIndex = 2 Then
                ServiceType = 3
            ElseIf STypeCombobox.SelectedIndex = 3 Then
                ServiceType = 4
            ElseIf STypeCombobox.SelectedIndex = 4 Then
                ServiceType = 5
            ElseIf STypeCombobox.SelectedIndex = 5 Then
                ServiceType = 6
            ElseIf STypeCombobox.SelectedIndex = 6 Then
                ServiceType = 7
            ElseIf STypeCombobox.SelectedIndex = 7 Then
                ServiceType = 8
            ElseIf STypeCombobox.SelectedIndex = 8 Then
                ServiceType = 9
            ElseIf STypeCombobox.SelectedIndex = 9 Then
                ServiceType = 10
            Else ServiceType = 11
            End If

            Dim d As TimeSpan
            Dim time As DateTime = TimeValue(DurationMTextBox.Text)
            Dim timeCheckin As String = Format(time, "HH:mm:00")
            d = TimeSpan.Parse(timeCheckin)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to Add a new Service?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then


                ServiceTA.Insert(ServiceNameTextBox.Text, TimeSpan.Parse(d.ToString), ServiceType, CInt(SPriceTextBox.Text), ServStatusComboBox.SelectedItem)
                ServiceTA.Fill(ShangrilaDS.SERVICE)
                ServiceDGV.Refresh()
                MessageBox.Show("New Service Added")

            Else
                MessageBox.Show("Cancelled")
            End If

            ServiceNameTextBox.ResetText()
            SPriceTextBox.ResetText()
            DurationMTextBox.ResetText()
            STypeCombobox.ResetText()
            ServStatusComboBox.ResetText()

        Catch Exception As Exception
            MessageBox.Show("Please do not leave any blank fields", "Blank fields")
        End Try

    End Sub

    Private Sub GunaCircleButton6_Click(sender As Object, e As EventArgs) Handles GunaCircleButton6.Click
        Try
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Service Price?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then


                ServiceTA.UpdateServPrice(CInt(SPriceTextBox.Text), ServiceDGV.CurrentRow.Cells(0).Value)
                ServiceTA.Fill(ShangrilaDS.SERVICE)
                MessageBox.Show("Update has been confirmed")

            Else
                MessageBox.Show("Update cancelled")
            End If

            SPriceTextBox.ResetText()

        Catch Exception As Exception
            MessageBox.Show("Invalid Format")
            SPriceTextBox.ResetText()
        End Try
    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click
        Try
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Product Price?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then


                ProductTA.UpdateProdPrice(CInt(PriceTextBox.Text), ProductDGV.CurrentRow.Cells(0).Value)
                ProductTA.Fill(ShangrilaDS.PRODUCT)
                MessageBox.Show("Update has been confirmed")

            Else
                MessageBox.Show("Update cancelled")
            End If

            PriceTextBox.ResetText()
        Catch exception As Exception
            MessageBox.Show("Invalid Format")
            PriceTextBox.ResetText()
        End Try


    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        Try
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Product Cost?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then


                ProductTA.UpdateProdCost(CInt(CostTextBox.Text), ProductDGV.CurrentRow.Cells(0).Value)
                ProductTA.Fill(ShangrilaDS.PRODUCT)
                MessageBox.Show("Update has been confirmed")

            Else
                MessageBox.Show("Update cancelled")
            End If

            CostTextBox.ResetText()
        Catch exception As Exception
            MessageBox.Show("Invalid Format")
            CostTextBox.ResetText()
        End Try
    End Sub

    Private Sub GunaCircleButton4_Click(sender As Object, e As EventArgs) Handles GunaCircleButton4.Click
        Try

            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Product Quantity Available?", "Confirm", MessageBoxButtons.YesNo)

            If Result = DialogResult.Yes Then


                ProductTA.UpdateProdQty(CInt(QtyAvailTextBox.Text), ProductDGV.CurrentRow.Cells(0).Value)
                ProductTA.Fill(ShangrilaDS.PRODUCT)
                MessageBox.Show("Update has been confirmed")

            Else
                MessageBox.Show("Update cancelled")
            End If

            QtyAvailTextBox.ResetText()

        Catch Exception As Exception
            MessageBox.Show("Invalid Format")
            QtyAvailTextBox.ResetText()
        End Try
    End Sub

    Private Sub GunaCircleButton7_Click(sender As Object, e As EventArgs) Handles GunaCircleButton7.Click

        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to update the Service Duration?", "Confirm", MessageBoxButtons.YesNo)

        If Result = DialogResult.Yes Then


            ServiceTA.UpdateServDuration(TimeValue(DurationMTextBox.Text), ServiceDGV.CurrentRow.Cells(0).Value)
            ServiceTA.Fill(ShangrilaDS.SERVICE)
            MessageBox.Show("Update has been confirmed")

        Else
            MessageBox.Show("Update cancelled")
        End If

        DurationMTextBox.ResetText()
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchProdTextBox.TextChanged
        ProductTA.FillBy(ShangrilaDS.PRODUCT, SearchProdTextBox.Text)
    End Sub

    Private Sub SearchServiceTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchServiceTextBox.TextChanged
        ServiceTA.FillBy(ShangrilaDS.SERVICE, SearchServiceTextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub ProductDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDGV.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = ProductDGV.Rows(index)
        ProductNameTextBox.Text = selectedRow.Cells(2).Value.ToString
        PriceTextBox.Text = selectedRow.Cells(3).Value.ToString
        CostTextBox.Text = selectedRow.Cells(4).Value.ToString
        QtyAvailTextBox.Text = selectedRow.Cells(5).Value.ToString
        ProdTypeComboBox.Text = selectedRow.Cells(1).Value.ToString
        SupplierComboBox.Text = selectedRow.Cells(6).Value.ToString
        PStatusComboBox.Text = selectedRow.Cells(7).Value.ToString


    End Sub

    Private Sub ServiceDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiceDGV.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = ServiceDGV.Rows(index)
        ServiceNameTextBox.Text = selectedRow.Cells(1).Value.ToString
        SPriceTextBox.Text = selectedRow.Cells(4).Value.ToString
        DurationMTextBox.Text = selectedRow.Cells(2).Value.ToString
        STypeCombobox.Text = selectedRow.Cells(3).Value.ToString
        ServStatusComboBox.Text = selectedRow.Cells(5).Value.ToString
    End Sub
End Class