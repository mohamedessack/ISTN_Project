<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.v = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShangrilaDS1 = New Spa_Appointment_Management_System.ShangrilaDS()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.AppointmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentStartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerFnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerLnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainPhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentEndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffFnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffLnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtViewAppointmentTableAdapter1 = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.dtViewAppointmentTableAdapter()
        Me.DTAppointmentViewerTableAdapter = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.DTAppointmentViewerTableAdapter()
        Me.InvoiceTableAdapter = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.InvoiceTableAdapter()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomDataGrid2 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityAvailableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroTextBox7 = New MetroFramework.Controls.MetroTextBox()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.DtProductTableAdapter1 = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.DTProductTableAdapter()
        Me.LinE_ITEMTableAdapter1 = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.LINE_ITEMTableAdapter()
        Me.BunifuCustomDataGrid3 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.AppointmentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityPurchasedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShangrilaDS = New Spa_Appointment_Management_System.ShangrilaDS()
        Me.imgPrint = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PRODUCTTableAdapter = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.PRODUCTTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShangrilaDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShangrilaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(-1, 76)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 108)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Shop 6, 28th Avenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Umhlatuzana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4092" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 061 218 9935 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "info@shangrilaspa.co.za"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(304, 12)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 70)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "INVOICE"
        '
        'v
        '
        Me.v.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.v.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v.Location = New System.Drawing.Point(462, 11)
        Me.v.Multiline = True
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(174, 44)
        Me.v.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(304, 87)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(106, 33)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = " Date"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Invoice"
        Me.BindingSource1.DataSource = Me.ShangrilaDS1
        '
        'ShangrilaDS1
        '
        Me.ShangrilaDS1.DataSetName = "ShangrilaDS"
        Me.ShangrilaDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(304, 138)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(124, 60)
        Me.TextBox5.TabIndex = 6
        Me.TextBox5.Text = "Amount Due:"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(472, 133)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(164, 51)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(12, 190)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(124, 33)
        Me.TextBox7.TabIndex = 8
        Me.TextBox7.Text = "Bill To"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.BindingSource2
        Me.ComboBox1.DisplayMember = "CUSTOMER FIRST NAME"
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(95, 190)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "dtViewAppointment"
        Me.BindingSource2.DataSource = Me.ShangrilaDS1
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.BunifuCustomDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn, Me.AppointmentDateDataGridViewTextBoxColumn, Me.AppointmentStartTimeDataGridViewTextBoxColumn, Me.CustomerFnameDataGridViewTextBoxColumn, Me.CustomerLnameDataGridViewTextBoxColumn, Me.MainPhoneNumberDataGridViewTextBoxColumn, Me.ServiceNameDataGridViewTextBoxColumn, Me.ServicePriceDataGridViewTextBoxColumn, Me.AppointmentEndTimeDataGridViewTextBoxColumn, Me.StaffFnameDataGridViewTextBoxColumn, Me.StaffLnameDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.BindingSource1
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Gray
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(163, 319)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(641, 135)
        Me.BunifuCustomDataGrid1.TabIndex = 10
        '
        'AppointmentIDDataGridViewTextBoxColumn
        '
        Me.AppointmentIDDataGridViewTextBoxColumn.DataPropertyName = "Appointment_ID"
        Me.AppointmentIDDataGridViewTextBoxColumn.HeaderText = "Appointment_ID"
        Me.AppointmentIDDataGridViewTextBoxColumn.Name = "AppointmentIDDataGridViewTextBoxColumn"
        Me.AppointmentIDDataGridViewTextBoxColumn.Visible = False
        Me.AppointmentIDDataGridViewTextBoxColumn.Width = 128
        '
        'AppointmentDateDataGridViewTextBoxColumn
        '
        Me.AppointmentDateDataGridViewTextBoxColumn.DataPropertyName = "Appointment_Date"
        Me.AppointmentDateDataGridViewTextBoxColumn.HeaderText = "Appointment_Date"
        Me.AppointmentDateDataGridViewTextBoxColumn.Name = "AppointmentDateDataGridViewTextBoxColumn"
        Me.AppointmentDateDataGridViewTextBoxColumn.Visible = False
        Me.AppointmentDateDataGridViewTextBoxColumn.Width = 146
        '
        'AppointmentStartTimeDataGridViewTextBoxColumn
        '
        Me.AppointmentStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Appointment_Start_Time"
        Me.AppointmentStartTimeDataGridViewTextBoxColumn.HeaderText = "Appointment_Start_Time"
        Me.AppointmentStartTimeDataGridViewTextBoxColumn.Name = "AppointmentStartTimeDataGridViewTextBoxColumn"
        Me.AppointmentStartTimeDataGridViewTextBoxColumn.Visible = False
        Me.AppointmentStartTimeDataGridViewTextBoxColumn.Width = 178
        '
        'CustomerFnameDataGridViewTextBoxColumn
        '
        Me.CustomerFnameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Fname"
        Me.CustomerFnameDataGridViewTextBoxColumn.HeaderText = "Customer_Fname"
        Me.CustomerFnameDataGridViewTextBoxColumn.Name = "CustomerFnameDataGridViewTextBoxColumn"
        Me.CustomerFnameDataGridViewTextBoxColumn.Visible = False
        Me.CustomerFnameDataGridViewTextBoxColumn.Width = 134
        '
        'CustomerLnameDataGridViewTextBoxColumn
        '
        Me.CustomerLnameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Lname"
        Me.CustomerLnameDataGridViewTextBoxColumn.HeaderText = "Customer_Lname"
        Me.CustomerLnameDataGridViewTextBoxColumn.Name = "CustomerLnameDataGridViewTextBoxColumn"
        Me.CustomerLnameDataGridViewTextBoxColumn.Visible = False
        Me.CustomerLnameDataGridViewTextBoxColumn.Width = 134
        '
        'MainPhoneNumberDataGridViewTextBoxColumn
        '
        Me.MainPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Main_Phone_Number"
        Me.MainPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Main_Phone_Number"
        Me.MainPhoneNumberDataGridViewTextBoxColumn.Name = "MainPhoneNumberDataGridViewTextBoxColumn"
        Me.MainPhoneNumberDataGridViewTextBoxColumn.Visible = False
        Me.MainPhoneNumberDataGridViewTextBoxColumn.Width = 156
        '
        'ServiceNameDataGridViewTextBoxColumn
        '
        Me.ServiceNameDataGridViewTextBoxColumn.DataPropertyName = "Service_Name"
        Me.ServiceNameDataGridViewTextBoxColumn.HeaderText = "Service_Name"
        Me.ServiceNameDataGridViewTextBoxColumn.Name = "ServiceNameDataGridViewTextBoxColumn"
        Me.ServiceNameDataGridViewTextBoxColumn.Width = 111
        '
        'ServicePriceDataGridViewTextBoxColumn
        '
        Me.ServicePriceDataGridViewTextBoxColumn.DataPropertyName = "Service_Price"
        Me.ServicePriceDataGridViewTextBoxColumn.HeaderText = "Service_Price"
        Me.ServicePriceDataGridViewTextBoxColumn.Name = "ServicePriceDataGridViewTextBoxColumn"
        Me.ServicePriceDataGridViewTextBoxColumn.Width = 105
        '
        'AppointmentEndTimeDataGridViewTextBoxColumn
        '
        Me.AppointmentEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Appointment_End_Time"
        Me.AppointmentEndTimeDataGridViewTextBoxColumn.HeaderText = "Appointment_End_Time"
        Me.AppointmentEndTimeDataGridViewTextBoxColumn.Name = "AppointmentEndTimeDataGridViewTextBoxColumn"
        Me.AppointmentEndTimeDataGridViewTextBoxColumn.Visible = False
        Me.AppointmentEndTimeDataGridViewTextBoxColumn.Width = 170
        '
        'StaffFnameDataGridViewTextBoxColumn
        '
        Me.StaffFnameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Fname"
        Me.StaffFnameDataGridViewTextBoxColumn.HeaderText = "Staff_Fname"
        Me.StaffFnameDataGridViewTextBoxColumn.Name = "StaffFnameDataGridViewTextBoxColumn"
        '
        'StaffLnameDataGridViewTextBoxColumn
        '
        Me.StaffLnameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Lname"
        Me.StaffLnameDataGridViewTextBoxColumn.HeaderText = "Staff_Lname"
        Me.StaffLnameDataGridViewTextBoxColumn.Name = "StaffLnameDataGridViewTextBoxColumn"
        '
        'DtViewAppointmentTableAdapter1
        '
        Me.DtViewAppointmentTableAdapter1.ClearBeforeFill = True
        '
        'DTAppointmentViewerTableAdapter
        '
        Me.DTAppointmentViewerTableAdapter.ClearBeforeFill = True
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(-3, 292)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(151, 33)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = "Select Invoice "
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(397, 87)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(239, 33)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(12, 229)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(265, 43)
        Me.TextBox9.TabIndex = 15
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.BindingSource1
        Me.ComboBox2.DisplayMember = "Appointment_ID"
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(154, 292)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox2.TabIndex = 16
        Me.ComboBox2.ValueMember = "Appointment_ID"
        '
        'BunifuCustomDataGrid2
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.BunifuCustomDataGrid2.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.BunifuCustomDataGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.BunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.BunifuCustomDataGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductPriceDataGridViewTextBoxColumn, Me.ProductCostDataGridViewTextBoxColumn, Me.QuantityAvailableDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.ProductStatusDataGridViewTextBoxColumn, Me.ProductTypeIDDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid2.DataSource = Me.BindingSource3
        Me.BunifuCustomDataGrid2.DoubleBuffered = True
        Me.BunifuCustomDataGrid2.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.Gray
        Me.BunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid2.Location = New System.Drawing.Point(163, 497)
        Me.BunifuCustomDataGrid2.Name = "BunifuCustomDataGrid2"
        Me.BunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid2.Size = New System.Drawing.Size(667, 105)
        Me.BunifuCustomDataGrid2.TabIndex = 17
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Visible = False
        Me.ProductIDDataGridViewTextBoxColumn.Width = 96
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.Width = 113
        '
        'ProductPriceDataGridViewTextBoxColumn
        '
        Me.ProductPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Price"
        Me.ProductPriceDataGridViewTextBoxColumn.HeaderText = "Product_Price"
        Me.ProductPriceDataGridViewTextBoxColumn.Name = "ProductPriceDataGridViewTextBoxColumn"
        Me.ProductPriceDataGridViewTextBoxColumn.Width = 107
        '
        'ProductCostDataGridViewTextBoxColumn
        '
        Me.ProductCostDataGridViewTextBoxColumn.DataPropertyName = "Product_Cost"
        Me.ProductCostDataGridViewTextBoxColumn.HeaderText = "Product_Cost"
        Me.ProductCostDataGridViewTextBoxColumn.Name = "ProductCostDataGridViewTextBoxColumn"
        Me.ProductCostDataGridViewTextBoxColumn.Visible = False
        Me.ProductCostDataGridViewTextBoxColumn.Width = 111
        '
        'QuantityAvailableDataGridViewTextBoxColumn
        '
        Me.QuantityAvailableDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Available"
        Me.QuantityAvailableDataGridViewTextBoxColumn.HeaderText = "Quantity_Available"
        Me.QuantityAvailableDataGridViewTextBoxColumn.Name = "QuantityAvailableDataGridViewTextBoxColumn"
        Me.QuantityAvailableDataGridViewTextBoxColumn.Width = 130
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.Visible = False
        Me.SupplierIDDataGridViewTextBoxColumn.Width = 97
        '
        'ProductStatusDataGridViewTextBoxColumn
        '
        Me.ProductStatusDataGridViewTextBoxColumn.DataPropertyName = "Product_Status"
        Me.ProductStatusDataGridViewTextBoxColumn.HeaderText = "Product_Status"
        Me.ProductStatusDataGridViewTextBoxColumn.Name = "ProductStatusDataGridViewTextBoxColumn"
        Me.ProductStatusDataGridViewTextBoxColumn.Visible = False
        Me.ProductStatusDataGridViewTextBoxColumn.Width = 121
        '
        'ProductTypeIDDataGridViewTextBoxColumn
        '
        Me.ProductTypeIDDataGridViewTextBoxColumn.DataPropertyName = "Product_Type_ID"
        Me.ProductTypeIDDataGridViewTextBoxColumn.HeaderText = "Product_Type_ID"
        Me.ProductTypeIDDataGridViewTextBoxColumn.Name = "ProductTypeIDDataGridViewTextBoxColumn"
        Me.ProductTypeIDDataGridViewTextBoxColumn.Visible = False
        Me.ProductTypeIDDataGridViewTextBoxColumn.Width = 129
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 74
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "PRODUCT"
        Me.BindingSource3.DataSource = Me.ShangrilaDS1
        '
        'MetroTextBox7
        '
        Me.MetroTextBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MetroTextBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.MetroTextBox7.CustomButton.Image = Nothing
        Me.MetroTextBox7.CustomButton.Location = New System.Drawing.Point(322, 2)
        Me.MetroTextBox7.CustomButton.Name = ""
        Me.MetroTextBox7.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MetroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox7.CustomButton.TabIndex = 1
        Me.MetroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox7.CustomButton.UseSelectable = True
        Me.MetroTextBox7.CustomButton.Visible = False
        Me.MetroTextBox7.DisplayIcon = True
        Me.MetroTextBox7.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox7.Icon = CType(resources.GetObject("MetroTextBox7.Icon"), System.Drawing.Image)
        Me.MetroTextBox7.IconRight = True
        Me.MetroTextBox7.Lines = New String(-1) {}
        Me.MetroTextBox7.Location = New System.Drawing.Point(163, 461)
        Me.MetroTextBox7.MaxLength = 32767
        Me.MetroTextBox7.Name = "MetroTextBox7"
        Me.MetroTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox7.PromptText = "Search Product By Name"
        Me.MetroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox7.SelectedText = ""
        Me.MetroTextBox7.SelectionLength = 0
        Me.MetroTextBox7.SelectionStart = 0
        Me.MetroTextBox7.ShortcutsEnabled = True
        Me.MetroTextBox7.Size = New System.Drawing.Size(350, 30)
        Me.MetroTextBox7.TabIndex = 18
        Me.MetroTextBox7.UseSelectable = True
        Me.MetroTextBox7.WaterMark = "Search Product By Name"
        Me.MetroTextBox7.WaterMarkColor = System.Drawing.Color.Gray
        Me.MetroTextBox7.WaterMarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(7, 461)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(141, 90)
        Me.GunaCircleButton1.TabIndex = 19
        Me.GunaCircleButton1.Text = "ADD PRODUCT"
        Me.GunaCircleButton1.TextImageOffsetY = -10
        '
        'DtProductTableAdapter1
        '
        Me.DtProductTableAdapter1.ClearBeforeFill = True
        '
        'LinE_ITEMTableAdapter1
        '
        Me.LinE_ITEMTableAdapter1.ClearBeforeFill = True
        '
        'BunifuCustomDataGrid3
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.BunifuCustomDataGrid3.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.BunifuCustomDataGrid3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.BunifuCustomDataGrid3.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.BunifuCustomDataGrid3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn1, Me.QuantityPurchasedDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn1, Me.ProductPriceDataGridViewTextBoxColumn1})
        Me.BunifuCustomDataGrid3.DataSource = Me.BindingSource4
        Me.BunifuCustomDataGrid3.DoubleBuffered = True
        Me.BunifuCustomDataGrid3.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid3.HeaderBgColor = System.Drawing.Color.Gray
        Me.BunifuCustomDataGrid3.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid3.Location = New System.Drawing.Point(163, 497)
        Me.BunifuCustomDataGrid3.Name = "BunifuCustomDataGrid3"
        Me.BunifuCustomDataGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid3.Size = New System.Drawing.Size(576, 105)
        Me.BunifuCustomDataGrid3.TabIndex = 20
        '
        'AppointmentIDDataGridViewTextBoxColumn1
        '
        Me.AppointmentIDDataGridViewTextBoxColumn1.DataPropertyName = "Appointment_ID"
        Me.AppointmentIDDataGridViewTextBoxColumn1.HeaderText = "Appointment_ID"
        Me.AppointmentIDDataGridViewTextBoxColumn1.Name = "AppointmentIDDataGridViewTextBoxColumn1"
        Me.AppointmentIDDataGridViewTextBoxColumn1.Visible = False
        Me.AppointmentIDDataGridViewTextBoxColumn1.Width = 128
        '
        'QuantityPurchasedDataGridViewTextBoxColumn
        '
        Me.QuantityPurchasedDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Purchased"
        Me.QuantityPurchasedDataGridViewTextBoxColumn.HeaderText = "Quantity_Purchased"
        Me.QuantityPurchasedDataGridViewTextBoxColumn.Name = "QuantityPurchasedDataGridViewTextBoxColumn"
        Me.QuantityPurchasedDataGridViewTextBoxColumn.Width = 140
        '
        'ProductNameDataGridViewTextBoxColumn1
        '
        Me.ProductNameDataGridViewTextBoxColumn1.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn1.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn1.Name = "ProductNameDataGridViewTextBoxColumn1"
        Me.ProductNameDataGridViewTextBoxColumn1.Width = 113
        '
        'ProductPriceDataGridViewTextBoxColumn1
        '
        Me.ProductPriceDataGridViewTextBoxColumn1.DataPropertyName = "Product_Price"
        Me.ProductPriceDataGridViewTextBoxColumn1.HeaderText = "Product_Price"
        Me.ProductPriceDataGridViewTextBoxColumn1.Name = "ProductPriceDataGridViewTextBoxColumn1"
        Me.ProductPriceDataGridViewTextBoxColumn1.Width = 107
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "LINE_ITEM"
        Me.BindingSource4.DataSource = Me.ShangrilaDS
        '
        'ShangrilaDS
        '
        Me.ShangrilaDS.DataSetName = "ShangrilaDS"
        Me.ShangrilaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'imgPrint
        '
        Me.imgPrint.Image = Global.Spa_Appointment_Management_System.My.Resources.Resources.print
        Me.imgPrint.Location = New System.Drawing.Point(797, 319)
        Me.imgPrint.Name = "imgPrint"
        Me.imgPrint.Size = New System.Drawing.Size(137, 86)
        Me.imgPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPrint.TabIndex = 21
        Me.imgPrint.TabStop = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(434, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 33)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "R"
        '
        'PRODUCTTableAdapter
        '
        Me.PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 497)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "*Please Double Click To Add A Product"
        Me.Label2.Visible = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1092, 614)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgPrint)
        Me.Controls.Add(Me.BunifuCustomDataGrid3)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.MetroTextBox7)
        Me.Controls.Add(Me.BunifuCustomDataGrid2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSource1, "Appointment_Date", True))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Invoice"
        Me.Text = "Invoice"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShangrilaDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShangrilaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents v As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DtViewAppointmentTableAdapter1 As ShangrilaDSTableAdapters.dtViewAppointmentTableAdapter
    Friend WithEvents ShangrilaDS1 As ShangrilaDS
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DTAppointmentViewerTableAdapter As ShangrilaDSTableAdapters.DTAppointmentViewerTableAdapter
    Friend WithEvents InvoiceTableAdapter As ShangrilaDSTableAdapters.InvoiceTableAdapter
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentStartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerLnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MainPhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServicePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentEndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffFnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffLnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCustomDataGrid2 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents MetroTextBox7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents DtProductTableAdapter1 As ShangrilaDSTableAdapters.DTProductTableAdapter
    Friend WithEvents LinE_ITEMTableAdapter1 As ShangrilaDSTableAdapters.LINE_ITEMTableAdapter
    Friend WithEvents BunifuCustomDataGrid3 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BindingSource4 As BindingSource
    Friend WithEvents ShangrilaDS As ShangrilaDS
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityPurchasedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents imgPrint As PictureBox
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PRODUCTTableAdapter As ShangrilaDSTableAdapters.PRODUCTTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityAvailableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
