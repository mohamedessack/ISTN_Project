Public Class newPromotion
    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click

    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub newPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShangrilaDS.SERVICE' table. You can move, or remove it, as needed.
        Me.SERVICETableAdapter.Fill(Me.ShangrilaDS.SERVICE)
        'TODO: This line of code loads data into the 'ShangrilaDS.PRODUCT' table. You can move, or remove it, as needed.
        Me.PRODUCTTableAdapter.Fill(Me.ShangrilaDS.PRODUCT)
        GunaDateTimePicker1.MinDate = DateTime.Today
        GunaDateTimePicker2.MinDate = DateTime.Today
        MetroTabControl1.SelectedTab = TabPage1

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaCircleButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton6_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub GunaCircleButton8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaCircleButton2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton8_Click_1(sender As Object, e As EventArgs)
        MetroTabPage2.Select()
    End Sub

    Private Sub GunaCircleButton6_Click_1(sender As Object, e As EventArgs)
        MetroTabPage3.Select()
    End Sub

    Private Sub GunaCircleButton7_Click_1(sender As Object, e As EventArgs)
        MetroTabPage1.Select()
    End Sub

    Private Sub GunaCircleButton1_Click_1(sender As Object, e As EventArgs)
        MetroTabPage2.Select()
    End Sub

    Private Sub GunaCircleButton4_Click_1(sender As Object, e As EventArgs)
        TabPage1.Select()
    End Sub

    Private Sub GunaCircleButton2_Click_2(sender As Object, e As EventArgs)
        MetroTabPage1.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProdSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProdSearchTextBox.TextChanged
        PRODUCTTableAdapter.FillBy(ShangrilaDS.PRODUCT, ProdSearchTextBox.Text)
    End Sub

    Private Sub GunaCircleButton1_Click_2(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        MetroTabControl1.SelectedTab = MetroTabPage1
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaCircleButton2_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton10_Click(sender As Object, e As EventArgs)
        MetroTabControl1.SelectedTab = MetroTabPage3
    End Sub

    Private Sub GunaCircleButton4_Click_2(sender As Object, e As EventArgs) Handles GunaCircleButton4.Click
        MetroTabControl1.SelectedTab = MetroTabPage2
    End Sub

    Private Sub GunaCircleButton6_Click_2(sender As Object, e As EventArgs) Handles GunaCircleButton6.Click
        MetroTabControl1.SelectedTab = MetroTabPage2
    End Sub

    Private Sub GunaCircleButton5_Click(sender As Object, e As EventArgs) Handles GunaCircleButton5.Click

        Dim p As Integer

            p = PromoProductDGV.CurrentRow.Cells(0).Value
            ProdID.Text = p
        If RadioButton1.Checked = True Then
            MetroTabControl1.SelectedTab = MetroTabPage4
        Else
            MetroTabControl1.SelectedTab = MetroTabPage3
        End If

    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub step4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaGradientPanel1_Click(sender As Object, e As EventArgs) Handles GunaGradientPanel1.Click

    End Sub

    Private Sub GunaCircleButton7_Click_2(sender As Object, e As EventArgs) Handles GunaCircleButton7.Click
        MetroTabControl1.SelectedTab = MetroTabPage3
    End Sub

    Private Sub GunaCircleButton8_Click_2(sender As Object, e As EventArgs) Handles GunaCircleButton8.Click
        MetroTabControl1.SelectedTab = MetroTabPage4
    End Sub

    Private Sub GunaCircleButton10_Click_1(sender As Object, e As EventArgs) Handles GunaCircleButton10.Click
        MetroTabControl1.SelectedTab = MetroTabPage3
    End Sub

    Private Sub GunaCircleButton9_Click(sender As Object, e As EventArgs) Handles GunaCircleButton9.Click
        Dim s As Integer

        s = PromoServiceDGV.CurrentRow.Cells(0).Value
        ServiceID.Text = s
        MetroTabControl1.SelectedTab = MetroTabPage4
    End Sub

    Private Sub GunaCircleButton3_Click_1(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click
        Try
            Dim SDate As String = GunaDateTimePicker1.Value.Year.ToString & "-"
            If GunaDateTimePicker1.Value.Month.ToString.Length = 1 Then
                SDate &= "0"
            End If
            SDate &= GunaDateTimePicker1.Value.Month.ToString & "-"
            If GunaDateTimePicker1.Value.Day.ToString.Length = 1 Then
                SDate &= "0"
            End If
            SDate &= GunaDateTimePicker1.Value.Day.ToString

            Dim EDate As String = GunaDateTimePicker2.Value.Year.ToString & "-"
            If GunaDateTimePicker2.Value.Month.ToString.Length = 1 Then
                EDate &= "0"
            End If
            EDate &= GunaDateTimePicker2.Value.Month.ToString & "-"
            If GunaDateTimePicker2.Value.Day.ToString.Length = 1 Then
                EDate &= "0"
            End If
            EDate &= GunaDateTimePicker2.Value.Day.ToString

            If RadioButton1.Checked = True Then

                PromotionTA.InsertPromoProduct(CInt(ProdID.Text), SDate, EDate, BunifuDropdown1.selectedValue, GunaNumeric1.Value, GunaNumeric2.Value, BunifuTextbox2.text)
                MessageBox.Show("PromoAdded Successfully", "Promo Added")
            ElseIf RadioButton2.Checked = True Then

                PromotionTA.InsertPromoService(CInt(ServiceID.Text), SDate, EDate, BunifuDropdown1.selectedValue, GunaNumeric1.Value, GunaNumeric2.Value, BunifuTextbox2.text)
                MessageBox.Show("PromoAdded Successfully", "Promo Added")
            Else
                PromotionTA.Insert(CInt(ServiceID.Text), CInt(ProdID.Text), SDate, EDate, BunifuDropdown1.selectedValue, GunaNumeric1.Value, GunaNumeric2.Value, BunifuTextbox2.text)
                MessageBox.Show("PromoAdded Successfully", "Promo Added")
            End If

        Catch Exception As Exception
            MessageBox.Show("Please do not leave any fields blank", "Blank fields")
            MetroTabControl1.SelectedTab = TabPage1
            GunaCircleButton11.Enabled = True
            'GunaCircleButton2.Enabled = True
            GunaCircleButton8.Enabled = True
            GunaCircleButton7.Enabled = True
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then

            MetroTabControl1.SelectedTab = MetroTabPage2
            MetroTabPage3.Enabled = False
            MetroTabPage2.Enabled = True
            PromoServiceDGV.Hide()
            PromoProductDGV.Show()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then

            MetroTabControl1.SelectedTab = MetroTabPage3
            MetroTabPage2.Enabled = False
            MetroTabPage3.Enabled = True
            PromoProductDGV.Hide()
            PromoServiceDGV.Show()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then

            MetroTabControl1.SelectedTab = MetroTabPage2
            MetroTabPage2.Enabled = True
            MetroTabPage3.Enabled = True
            PromoProductDGV.Show()
            PromoServiceDGV.Show()
        End If
    End Sub

    Private Sub ServiceSearchTextBox_Textchanged(sender As Object, e As EventArgs) Handles ServiceSearchTextBox.TextChanged
        SERVICETableAdapter.FillBy(ShangrilaDS.SERVICE, ServiceSearchTextBox.Text)
    End Sub

    Private Sub GunaCircleButton2_Click_4(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaCircleButton11_Click(sender As Object, e As EventArgs) Handles GunaCircleButton11.Click
        MetroTabControl1.SelectedTab = MetroTabPage2
    End Sub
End Class