<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.AvailibilityUpdate = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LNameTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FNameTextBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaCircleButton5 = New Guna.UI.WinForms.GunaCircleButton()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.StaffDGV = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffFnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffLnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffAvailibilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShangrilaDS = New Spa_Appointment_Management_System.ShangrilaDS()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.PreviousBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GunaCircleButton6 = New Guna.UI.WinForms.GunaCircleButton()
        Me.SearchStaffTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.EndDate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.StartDate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.AbsentDGV = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Staff_Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Staff_Lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbsentStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbsentEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTAbsentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AbsentBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.STAFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShangrilaDS1 = New Spa_Appointment_Management_System.ShangrilaDS()
        Me.StaffTA = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.STAFFTableAdapter()
        Me.AbsentTA = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.STAFF_ABSENTTableAdapter()
        Me.DTAbsentTableAdapter = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.DTAbsentTableAdapter()
        Me.StaffAbsentTA = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.STAFF_ABSENTTableAdapter()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.StaffDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShangrilaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.AbsentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTAbsentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.AbsentBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShangrilaDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 114)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(1351, 542)
        Me.MetroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTabControl1.TabIndex = 14
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.Color.White
        Me.MetroTabPage1.Controls.Add(Me.AvailibilityUpdate)
        Me.MetroTabPage1.Controls.Add(Me.Label6)
        Me.MetroTabPage1.Controls.Add(Me.ComboBox1)
        Me.MetroTabPage1.Controls.Add(Me.LNameTextBox)
        Me.MetroTabPage1.Controls.Add(Me.Label2)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.Controls.Add(Me.FNameTextBox)
        Me.MetroTabPage1.Controls.Add(Me.GunaCircleButton5)
        Me.MetroTabPage1.Controls.Add(Me.BunifuCards2)
        Me.MetroTabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTabPage1.HorizontalScrollbarBarColor = False
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 0
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1343, 500)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Add Staff"
        Me.MetroTabPage1.VerticalScrollbarBarColor = False
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 0
        '
        'AvailibilityUpdate
        '
        Me.AvailibilityUpdate.AnimationHoverSpeed = 0.07!
        Me.AvailibilityUpdate.AnimationSpeed = 0.03!
        Me.AvailibilityUpdate.BaseColor = System.Drawing.Color.White
        Me.AvailibilityUpdate.BorderColor = System.Drawing.Color.Black
        Me.AvailibilityUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AvailibilityUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.AvailibilityUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AvailibilityUpdate.ForeColor = System.Drawing.Color.White
        Me.AvailibilityUpdate.Image = CType(resources.GetObject("AvailibilityUpdate.Image"), System.Drawing.Image)
        Me.AvailibilityUpdate.ImageSize = New System.Drawing.Size(30, 30)
        Me.AvailibilityUpdate.Location = New System.Drawing.Point(1255, 202)
        Me.AvailibilityUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.AvailibilityUpdate.Name = "AvailibilityUpdate"
        Me.AvailibilityUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AvailibilityUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.AvailibilityUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.AvailibilityUpdate.OnHoverImage = Nothing
        Me.AvailibilityUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.AvailibilityUpdate.Size = New System.Drawing.Size(51, 55)
        Me.AvailibilityUpdate.TabIndex = 91
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(981, 187)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Availibility"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.ComboBox1.Location = New System.Drawing.Point(985, 213)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 32)
        Me.ComboBox1.TabIndex = 63
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LNameTextBox.HintForeColor = System.Drawing.Color.White
        Me.LNameTextBox.HintText = ""
        Me.LNameTextBox.isPassword = False
        Me.LNameTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.LNameTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.LNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.LNameTextBox.LineThickness = 3
        Me.LNameTextBox.Location = New System.Drawing.Point(981, 126)
        Me.LNameTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(265, 41)
        Me.LNameTextBox.TabIndex = 62
        Me.LNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(983, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(983, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "First Name"
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.FNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FNameTextBox.HintForeColor = System.Drawing.Color.White
        Me.FNameTextBox.HintText = ""
        Me.FNameTextBox.isPassword = False
        Me.FNameTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.FNameTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.FNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.FNameTextBox.LineThickness = 3
        Me.FNameTextBox.Location = New System.Drawing.Point(981, 43)
        Me.FNameTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(265, 41)
        Me.FNameTextBox.TabIndex = 58
        Me.FNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaCircleButton5
        '
        Me.GunaCircleButton5.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton5.AnimationSpeed = 0.03!
        Me.GunaCircleButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton5.ForeColor = System.Drawing.Color.Black
        Me.GunaCircleButton5.Image = CType(resources.GetObject("GunaCircleButton5.Image"), System.Drawing.Image)
        Me.GunaCircleButton5.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton5.Location = New System.Drawing.Point(1029, 273)
        Me.GunaCircleButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaCircleButton5.Name = "GunaCircleButton5"
        Me.GunaCircleButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton5.OnHoverImage = Nothing
        Me.GunaCircleButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton5.Size = New System.Drawing.Size(168, 139)
        Me.GunaCircleButton5.TabIndex = 57
        Me.GunaCircleButton5.Text = "Add Staff"
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = False
        Me.BunifuCards2.color = System.Drawing.Color.Tomato
        Me.BunifuCards2.Controls.Add(Me.StaffDGV)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(29, 17)
        Me.BunifuCards2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = False
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(852, 395)
        Me.BunifuCards2.TabIndex = 56
        '
        'StaffDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StaffDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StaffDGV.AutoGenerateColumns = False
        Me.StaffDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StaffDGV.BackgroundColor = System.Drawing.Color.White
        Me.StaffDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StaffDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StaffDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffFnameDataGridViewTextBoxColumn, Me.StaffLnameDataGridViewTextBoxColumn, Me.StaffTypeDataGridViewTextBoxColumn, Me.StaffAvailibilityDataGridViewTextBoxColumn})
        Me.StaffDGV.DataSource = Me.StaffBS
        Me.StaffDGV.DoubleBuffered = True
        Me.StaffDGV.EnableHeadersVisualStyles = False
        Me.StaffDGV.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.StaffDGV.HeaderForeColor = System.Drawing.Color.White
        Me.StaffDGV.Location = New System.Drawing.Point(0, 2)
        Me.StaffDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.StaffDGV.Name = "StaffDGV"
        Me.StaffDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StaffDGV.Size = New System.Drawing.Size(852, 374)
        Me.StaffDGV.TabIndex = 1
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StaffFnameDataGridViewTextBoxColumn
        '
        Me.StaffFnameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Fname"
        Me.StaffFnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.StaffFnameDataGridViewTextBoxColumn.Name = "StaffFnameDataGridViewTextBoxColumn"
        '
        'StaffLnameDataGridViewTextBoxColumn
        '
        Me.StaffLnameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Lname"
        Me.StaffLnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.StaffLnameDataGridViewTextBoxColumn.Name = "StaffLnameDataGridViewTextBoxColumn"
        '
        'StaffTypeDataGridViewTextBoxColumn
        '
        Me.StaffTypeDataGridViewTextBoxColumn.DataPropertyName = "Staff_Type"
        Me.StaffTypeDataGridViewTextBoxColumn.HeaderText = "Staff Type"
        Me.StaffTypeDataGridViewTextBoxColumn.Name = "StaffTypeDataGridViewTextBoxColumn"
        '
        'StaffAvailibilityDataGridViewTextBoxColumn
        '
        Me.StaffAvailibilityDataGridViewTextBoxColumn.DataPropertyName = "Staff_Availibility"
        Me.StaffAvailibilityDataGridViewTextBoxColumn.HeaderText = "Availibility"
        Me.StaffAvailibilityDataGridViewTextBoxColumn.Name = "StaffAvailibilityDataGridViewTextBoxColumn"
        '
        'StaffBS
        '
        Me.StaffBS.DataMember = "STAFF"
        Me.StaffBS.DataSource = Me.ShangrilaDS
        '
        'ShangrilaDS
        '
        Me.ShangrilaDS.DataSetName = "ShangrilaDS"
        Me.ShangrilaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BackColor = System.Drawing.Color.White
        Me.MetroTabPage2.Controls.Add(Me.PreviousBtn)
        Me.MetroTabPage2.Controls.Add(Me.NextBtn)
        Me.MetroTabPage2.Controls.Add(Me.Label5)
        Me.MetroTabPage2.Controls.Add(Me.Label4)
        Me.MetroTabPage2.Controls.Add(Me.Label3)
        Me.MetroTabPage2.Controls.Add(Me.TextBox3)
        Me.MetroTabPage2.Controls.Add(Me.TextBox2)
        Me.MetroTabPage2.Controls.Add(Me.TextBox1)
        Me.MetroTabPage2.Controls.Add(Me.GunaCircleButton6)
        Me.MetroTabPage2.Controls.Add(Me.SearchStaffTextBox)
        Me.MetroTabPage2.Controls.Add(Me.EndDate)
        Me.MetroTabPage2.Controls.Add(Me.StartDate)
        Me.MetroTabPage2.Controls.Add(Me.Panel1)
        Me.MetroTabPage2.Controls.Add(Me.Panel7)
        Me.MetroTabPage2.Controls.Add(Me.Label7)
        Me.MetroTabPage2.Controls.Add(Me.Label8)
        Me.MetroTabPage2.Controls.Add(Me.GunaCircleButton1)
        Me.MetroTabPage2.Controls.Add(Me.BunifuCards1)
        Me.MetroTabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTabPage2.HorizontalScrollbarBarColor = False
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 0
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1343, 500)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Absent"
        Me.MetroTabPage2.VerticalScrollbarBarColor = False
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 0
        '
        'PreviousBtn
        '
        Me.PreviousBtn.BackColor = System.Drawing.Color.PaleGreen
        Me.PreviousBtn.ForeColor = System.Drawing.Color.Black
        Me.PreviousBtn.Location = New System.Drawing.Point(965, 188)
        Me.PreviousBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.PreviousBtn.Name = "PreviousBtn"
        Me.PreviousBtn.Size = New System.Drawing.Size(100, 28)
        Me.PreviousBtn.TabIndex = 98
        Me.PreviousBtn.Text = "Previous"
        Me.PreviousBtn.UseVisualStyleBackColor = False
        '
        'NextBtn
        '
        Me.NextBtn.BackColor = System.Drawing.Color.PaleGreen
        Me.NextBtn.Location = New System.Drawing.Point(1101, 188)
        Me.NextBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(100, 28)
        Me.NextBtn.TabIndex = 97
        Me.NextBtn.Text = "Next"
        Me.NextBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(960, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Staff Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(960, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Staff First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(961, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Staff ID"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBS, "Staff_Fname", True))
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(959, 89)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(241, 26)
        Me.TextBox3.TabIndex = 93
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBS, "Staff_Lname", True))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(959, 143)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(241, 26)
        Me.TextBox2.TabIndex = 92
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBS, "Staff_ID", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(959, 34)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 26)
        Me.TextBox1.TabIndex = 91
        '
        'GunaCircleButton6
        '
        Me.GunaCircleButton6.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton6.AnimationSpeed = 0.03!
        Me.GunaCircleButton6.BaseColor = System.Drawing.Color.White
        Me.GunaCircleButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton6.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton6.Image = CType(resources.GetObject("GunaCircleButton6.Image"), System.Drawing.Image)
        Me.GunaCircleButton6.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton6.Location = New System.Drawing.Point(1268, 346)
        Me.GunaCircleButton6.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaCircleButton6.Name = "GunaCircleButton6"
        Me.GunaCircleButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton6.OnHoverImage = Nothing
        Me.GunaCircleButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton6.Size = New System.Drawing.Size(51, 55)
        Me.GunaCircleButton6.TabIndex = 90
        '
        'SearchStaffTextBox
        '
        '
        '
        '
        Me.SearchStaffTextBox.CustomButton.Image = Nothing
        Me.SearchStaffTextBox.CustomButton.Location = New System.Drawing.Point(361, 1)
        Me.SearchStaffTextBox.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchStaffTextBox.CustomButton.Name = ""
        Me.SearchStaffTextBox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.SearchStaffTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchStaffTextBox.CustomButton.TabIndex = 1
        Me.SearchStaffTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchStaffTextBox.CustomButton.UseSelectable = True
        Me.SearchStaffTextBox.CustomButton.Visible = False
        Me.SearchStaffTextBox.DisplayIcon = True
        Me.SearchStaffTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.SearchStaffTextBox.Icon = CType(resources.GetObject("SearchStaffTextBox.Icon"), System.Drawing.Image)
        Me.SearchStaffTextBox.IconRight = True
        Me.SearchStaffTextBox.Lines = New String(-1) {}
        Me.SearchStaffTextBox.Location = New System.Drawing.Point(11, 11)
        Me.SearchStaffTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchStaffTextBox.MaxLength = 32767
        Me.SearchStaffTextBox.Name = "SearchStaffTextBox"
        Me.SearchStaffTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchStaffTextBox.PromptText = "Search Absent Staff By First Name"
        Me.SearchStaffTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchStaffTextBox.SelectedText = ""
        Me.SearchStaffTextBox.SelectionLength = 0
        Me.SearchStaffTextBox.SelectionStart = 0
        Me.SearchStaffTextBox.ShortcutsEnabled = True
        Me.SearchStaffTextBox.Size = New System.Drawing.Size(397, 37)
        Me.SearchStaffTextBox.TabIndex = 78
        Me.SearchStaffTextBox.UseSelectable = True
        Me.SearchStaffTextBox.WaterMark = "Search Absent Staff By First Name"
        Me.SearchStaffTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.SearchStaffTextBox.WaterMarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'EndDate
        '
        Me.EndDate.BaseColor = System.Drawing.Color.White
        Me.EndDate.BorderColor = System.Drawing.Color.Transparent
        Me.EndDate.CustomFormat = Nothing
        Me.EndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.EndDate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EndDate.ForeColor = System.Drawing.Color.Black
        Me.EndDate.Location = New System.Drawing.Point(959, 351)
        Me.EndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.EndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.EndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.OnHoverBaseColor = System.Drawing.Color.White
        Me.EndDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EndDate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EndDate.OnPressedColor = System.Drawing.Color.Black
        Me.EndDate.Size = New System.Drawing.Size(301, 37)
        Me.EndDate.TabIndex = 77
        Me.EndDate.Text = "Monday, 03 August 2020"
        Me.EndDate.Value = New Date(2020, 8, 3, 1, 49, 6, 945)
        '
        'StartDate
        '
        Me.StartDate.BaseColor = System.Drawing.Color.White
        Me.StartDate.BorderColor = System.Drawing.Color.Transparent
        Me.StartDate.CustomFormat = Nothing
        Me.StartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.StartDate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StartDate.ForeColor = System.Drawing.Color.Black
        Me.StartDate.Location = New System.Drawing.Point(964, 261)
        Me.StartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.StartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.StartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.OnHoverBaseColor = System.Drawing.Color.White
        Me.StartDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StartDate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StartDate.OnPressedColor = System.Drawing.Color.Black
        Me.StartDate.Size = New System.Drawing.Size(299, 37)
        Me.StartDate.TabIndex = 76
        Me.StartDate.Text = "Monday, 03 August 2020"
        Me.StartDate.Value = New Date(2020, 8, 3, 1, 49, 6, 945)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Location = New System.Drawing.Point(965, 305)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 6)
        Me.Panel1.TabIndex = 75
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DimGray
        Me.Panel7.Location = New System.Drawing.Point(965, 395)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(265, 6)
        Me.Panel7.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(960, 327)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 20)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Absent End Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(961, 238)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Absent Start Date"
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(1049, 409)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(152, 95)
        Me.GunaCircleButton1.TabIndex = 69
        Me.GunaCircleButton1.Text = "Insert Absent Staff"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = False
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.AbsentDGV)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(11, 80)
        Me.BunifuCards1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = False
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(913, 401)
        Me.BunifuCards1.TabIndex = 57
        '
        'AbsentDGV
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AbsentDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.AbsentDGV.AutoGenerateColumns = False
        Me.AbsentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AbsentDGV.BackgroundColor = System.Drawing.Color.White
        Me.AbsentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AbsentDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AbsentDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.AbsentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AbsentDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Staff_Fname, Me.Staff_Lname, Me.StaffIDDataGridViewTextBoxColumn1, Me.AbsentStartDateDataGridViewTextBoxColumn, Me.AbsentEndDateDataGridViewTextBoxColumn})
        Me.AbsentDGV.DataSource = Me.DTAbsentBindingSource
        Me.AbsentDGV.DoubleBuffered = True
        Me.AbsentDGV.EnableHeadersVisualStyles = False
        Me.AbsentDGV.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.AbsentDGV.HeaderForeColor = System.Drawing.Color.White
        Me.AbsentDGV.Location = New System.Drawing.Point(0, 4)
        Me.AbsentDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.AbsentDGV.Name = "AbsentDGV"
        Me.AbsentDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AbsentDGV.Size = New System.Drawing.Size(913, 304)
        Me.AbsentDGV.TabIndex = 1
        '
        'Staff_Fname
        '
        Me.Staff_Fname.DataPropertyName = "Staff_Fname"
        Me.Staff_Fname.HeaderText = "First Name"
        Me.Staff_Fname.Name = "Staff_Fname"
        '
        'Staff_Lname
        '
        Me.Staff_Lname.DataPropertyName = "Staff_Lname"
        Me.Staff_Lname.HeaderText = "Last Name"
        Me.Staff_Lname.Name = "Staff_Lname"
        '
        'StaffIDDataGridViewTextBoxColumn1
        '
        Me.StaffIDDataGridViewTextBoxColumn1.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn1.HeaderText = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn1.Name = "StaffIDDataGridViewTextBoxColumn1"
        '
        'AbsentStartDateDataGridViewTextBoxColumn
        '
        Me.AbsentStartDateDataGridViewTextBoxColumn.DataPropertyName = "Absent_Start_Date"
        Me.AbsentStartDateDataGridViewTextBoxColumn.HeaderText = "Absent Start Date"
        Me.AbsentStartDateDataGridViewTextBoxColumn.Name = "AbsentStartDateDataGridViewTextBoxColumn"
        '
        'AbsentEndDateDataGridViewTextBoxColumn
        '
        Me.AbsentEndDateDataGridViewTextBoxColumn.DataPropertyName = "Absent_End_Date"
        Me.AbsentEndDateDataGridViewTextBoxColumn.HeaderText = "Absent End Date"
        Me.AbsentEndDateDataGridViewTextBoxColumn.Name = "AbsentEndDateDataGridViewTextBoxColumn"
        '
        'DTAbsentBindingSource
        '
        Me.DTAbsentBindingSource.DataMember = "DTAbsent"
        Me.DTAbsentBindingSource.DataSource = Me.ShangrilaDS
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Honeydew
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(559, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(171, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Honeydew
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1351, 114)
        Me.Panel4.TabIndex = 13
        '
        'AbsentBS
        '
        Me.AbsentBS.DataMember = "STAFF_ABSENT"
        Me.AbsentBS.DataSource = Me.ShangrilaDS
        '
        'STAFFBindingSource
        '
        Me.STAFFBindingSource.DataMember = "STAFF"
        Me.STAFFBindingSource.DataSource = Me.ShangrilaDS1
        '
        'ShangrilaDS1
        '
        Me.ShangrilaDS1.DataSetName = "ShangrilaDS"
        Me.ShangrilaDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffTA
        '
        Me.StaffTA.ClearBeforeFill = True
        '
        'AbsentTA
        '
        Me.AbsentTA.ClearBeforeFill = True
        '
        'DTAbsentTableAdapter
        '
        Me.DTAbsentTableAdapter.ClearBeforeFill = True
        '
        'StaffAbsentTA
        '
        Me.StaffAbsentTA.ClearBeforeFill = True
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1351, 656)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Staff"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        CType(Me.StaffDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShangrilaDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.AbsentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTAbsentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.AbsentBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STAFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShangrilaDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents LNameTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FNameTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents StaffDGV As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents EndDate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents StartDate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents SearchStaffTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ShangrilaDS As ShangrilaDS
    Friend WithEvents StaffBS As BindingSource
    Friend WithEvents StaffTA As ShangrilaDSTableAdapters.STAFFTableAdapter
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffFnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffLnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffAvailibilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShangrilaDS1 As ShangrilaDS
    Friend WithEvents AbsentBS As BindingSource
    Friend WithEvents AbsentTA As ShangrilaDSTableAdapters.STAFF_ABSENTTableAdapter
    Friend WithEvents AbsentDGV As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents STAFFBindingSource As BindingSource
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton6 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents DTAbsentBindingSource As BindingSource
    Friend WithEvents DTAbsentTableAdapter As ShangrilaDSTableAdapters.DTAbsentTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PreviousBtn As Button
    Friend WithEvents NextBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AvailibilityUpdate As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Staff_Fname As DataGridViewTextBoxColumn
    Friend WithEvents Staff_Lname As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AbsentStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbsentEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffAbsentTA As ShangrilaDSTableAdapters.STAFF_ABSENTTableAdapter
    Friend WithEvents GunaCircleButton5 As Guna.UI.WinForms.GunaCircleButton
End Class
