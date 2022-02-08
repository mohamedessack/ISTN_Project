<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePromotion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatePromotion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.PromoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromoStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromoEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromoTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VolumeDiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromoDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROMOTIONBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShangrilaDS = New Spa_Appointment_Management_System.ShangrilaDS()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.PromoComboBox = New System.Windows.Forms.ComboBox()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaCircleButton4 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.GunaCircleButton3 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton6 = New Guna.UI.WinForms.GunaCircleButton()
        Me.TAPROMOTION = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.PROMOTIONTableAdapter()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMOTIONBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShangrilaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(8, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1176, 12)
        Me.Panel1.TabIndex = 8
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromoIDDataGridViewTextBoxColumn, Me.ServiceIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.PromoStartDateDataGridViewTextBoxColumn, Me.PromoEndDateDataGridViewTextBoxColumn, Me.PromoTypeDataGridViewTextBoxColumn, Me.DiscountValueDataGridViewTextBoxColumn, Me.VolumeDiscountDataGridViewTextBoxColumn, Me.PromoDescriptionDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.PROMOTIONBS
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Azure
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(7, 70)
        Me.BunifuCustomDataGrid1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1177, 228)
        Me.BunifuCustomDataGrid1.TabIndex = 6
        '
        'PromoIDDataGridViewTextBoxColumn
        '
        Me.PromoIDDataGridViewTextBoxColumn.DataPropertyName = "Promo_ID"
        Me.PromoIDDataGridViewTextBoxColumn.HeaderText = "Promo ID"
        Me.PromoIDDataGridViewTextBoxColumn.Name = "PromoIDDataGridViewTextBoxColumn"
        Me.PromoIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiceIDDataGridViewTextBoxColumn
        '
        Me.ServiceIDDataGridViewTextBoxColumn.DataPropertyName = "Service_ID"
        Me.ServiceIDDataGridViewTextBoxColumn.HeaderText = "Service ID"
        Me.ServiceIDDataGridViewTextBoxColumn.Name = "ServiceIDDataGridViewTextBoxColumn"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'PromoStartDateDataGridViewTextBoxColumn
        '
        Me.PromoStartDateDataGridViewTextBoxColumn.DataPropertyName = "Promo_Start_Date"
        Me.PromoStartDateDataGridViewTextBoxColumn.HeaderText = "Promo Start Date"
        Me.PromoStartDateDataGridViewTextBoxColumn.Name = "PromoStartDateDataGridViewTextBoxColumn"
        '
        'PromoEndDateDataGridViewTextBoxColumn
        '
        Me.PromoEndDateDataGridViewTextBoxColumn.DataPropertyName = "Promo_End_Date"
        Me.PromoEndDateDataGridViewTextBoxColumn.HeaderText = "Promo End Date"
        Me.PromoEndDateDataGridViewTextBoxColumn.Name = "PromoEndDateDataGridViewTextBoxColumn"
        '
        'PromoTypeDataGridViewTextBoxColumn
        '
        Me.PromoTypeDataGridViewTextBoxColumn.DataPropertyName = "Promo_Type"
        Me.PromoTypeDataGridViewTextBoxColumn.HeaderText = "Promo Type"
        Me.PromoTypeDataGridViewTextBoxColumn.Name = "PromoTypeDataGridViewTextBoxColumn"
        '
        'DiscountValueDataGridViewTextBoxColumn
        '
        Me.DiscountValueDataGridViewTextBoxColumn.DataPropertyName = "Discount_Value"
        Me.DiscountValueDataGridViewTextBoxColumn.HeaderText = "Discount Value"
        Me.DiscountValueDataGridViewTextBoxColumn.Name = "DiscountValueDataGridViewTextBoxColumn"
        '
        'VolumeDiscountDataGridViewTextBoxColumn
        '
        Me.VolumeDiscountDataGridViewTextBoxColumn.DataPropertyName = "Volume_Discount"
        Me.VolumeDiscountDataGridViewTextBoxColumn.HeaderText = "Volume Discount"
        Me.VolumeDiscountDataGridViewTextBoxColumn.Name = "VolumeDiscountDataGridViewTextBoxColumn"
        '
        'PromoDescriptionDataGridViewTextBoxColumn
        '
        Me.PromoDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Promo_Description"
        Me.PromoDescriptionDataGridViewTextBoxColumn.HeaderText = "Promo Description"
        Me.PromoDescriptionDataGridViewTextBoxColumn.Name = "PromoDescriptionDataGridViewTextBoxColumn"
        '
        'PROMOTIONBS
        '
        Me.PROMOTIONBS.DataMember = "PROMOTION"
        Me.PROMOTIONBS.DataSource = Me.ShangrilaDS
        '
        'ShangrilaDS
        '
        Me.ShangrilaDS.DataSetName = "ShangrilaDS"
        Me.ShangrilaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(431, 1)
        Me.MetroTextBox1.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.DisplayIcon = True
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Icon = CType(resources.GetObject("MetroTextBox1.Icon"), System.Drawing.Image)
        Me.MetroTextBox1.IconRight = True
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(8, 14)
        Me.MetroTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "Search Promo Type"
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(467, 37)
        Me.MetroTextBox1.TabIndex = 55
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "Search Promo Type"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.Gray
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 26)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Promotion End Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 26)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Enter Promo Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 26)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Promotion Price"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(815, 98)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(160, 148)
        Me.GunaCircleButton1.TabIndex = 65
        Me.GunaCircleButton1.Text = "UPDATE ALL"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.PromoComboBox)
        Me.BunifuCards1.Controls.Add(Me.GunaDateTimePicker1)
        Me.BunifuCards1.Controls.Add(Me.GunaCircleButton4)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.MetroTextBox4)
        Me.BunifuCards1.Controls.Add(Me.MetroTextBox3)
        Me.BunifuCards1.Controls.Add(Me.GunaCircleButton3)
        Me.BunifuCards1.Controls.Add(Me.GunaCircleButton2)
        Me.BunifuCards1.Controls.Add(Me.GunaCircleButton6)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.GunaCircleButton1)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(16, 282)
        Me.BunifuCards1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(1196, 421)
        Me.BunifuCards1.TabIndex = 67
        '
        'PromoComboBox
        '
        Me.PromoComboBox.FormattingEnabled = True
        Me.PromoComboBox.Items.AddRange(New Object() {"Book for 2", "Buy 1 Get 1 Free", "Express Package ", "Package Deal"})
        Me.PromoComboBox.Location = New System.Drawing.Point(20, 148)
        Me.PromoComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PromoComboBox.Name = "PromoComboBox"
        Me.PromoComboBox.Size = New System.Drawing.Size(377, 24)
        Me.PromoComboBox.TabIndex = 96
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaDateTimePicker1.CustomFormat = Nothing
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(40, 43)
        Me.GunaDateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(385, 39)
        Me.GunaDateTimePicker1.TabIndex = 58
        Me.GunaDateTimePicker1.Text = "Monday, 03 August 2020"
        Me.GunaDateTimePicker1.Value = New Date(2020, 8, 3, 1, 49, 6, 945)
        '
        'GunaCircleButton4
        '
        Me.GunaCircleButton4.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton4.AnimationSpeed = 0.03!
        Me.GunaCircleButton4.BaseColor = System.Drawing.Color.White
        Me.GunaCircleButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton4.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton4.Image = CType(resources.GetObject("GunaCircleButton4.Image"), System.Drawing.Image)
        Me.GunaCircleButton4.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton4.Location = New System.Drawing.Point(433, 304)
        Me.GunaCircleButton4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaCircleButton4.Name = "GunaCircleButton4"
        Me.GunaCircleButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton4.OnHoverImage = Nothing
        Me.GunaCircleButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton4.Size = New System.Drawing.Size(51, 55)
        Me.GunaCircleButton4.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(100, 293)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 26)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Volume discount"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = Nothing
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(464, 1)
        Me.MetroTextBox4.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(47, 43)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.DisplayIcon = True
        Me.MetroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox4.IconRight = True
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(15, 322)
        Me.MetroTextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.ShortcutsEnabled = True
        Me.MetroTextBox4.Size = New System.Drawing.Size(384, 37)
        Me.MetroTextBox4.TabIndex = 93
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.Gray
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GunaCircleButton3
        '
        Me.GunaCircleButton3.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton3.AnimationSpeed = 0.03!
        Me.GunaCircleButton3.BaseColor = System.Drawing.Color.White
        Me.GunaCircleButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton3.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton3.Image = CType(resources.GetObject("GunaCircleButton3.Image"), System.Drawing.Image)
        Me.GunaCircleButton3.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton3.Location = New System.Drawing.Point(433, 213)
        Me.GunaCircleButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaCircleButton3.Name = "GunaCircleButton3"
        Me.GunaCircleButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton3.OnHoverImage = Nothing
        Me.GunaCircleButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton3.Size = New System.Drawing.Size(51, 55)
        Me.GunaCircleButton3.TabIndex = 88
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.White
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = CType(resources.GetObject("GunaCircleButton2.Image"), System.Drawing.Image)
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(433, 118)
        Me.GunaCircleButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Size = New System.Drawing.Size(51, 55)
        Me.GunaCircleButton2.TabIndex = 87
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
        Me.GunaCircleButton6.Location = New System.Drawing.Point(433, 43)
        Me.GunaCircleButton6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaCircleButton6.Name = "GunaCircleButton6"
        Me.GunaCircleButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaCircleButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton6.OnHoverImage = Nothing
        Me.GunaCircleButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton6.Size = New System.Drawing.Size(51, 55)
        Me.GunaCircleButton6.TabIndex = 86
        '
        'TAPROMOTION
        '
        Me.TAPROMOTION.ClearBeforeFill = True
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(348, 1)
        Me.MetroTextBox3.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.DisplayIcon = True
        Me.MetroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox3.IconRight = True
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(20, 231)
        Me.MetroTextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.ShortcutsEnabled = True
        Me.MetroTextBox3.Size = New System.Drawing.Size(384, 37)
        Me.MetroTextBox3.TabIndex = 92
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.Gray
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'UpdatePromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1291, 718)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UpdatePromotion"
        Me.Text = "UpdatePromotion"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMOTIONBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShangrilaDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents GunaCircleButton3 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton6 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents ShangrilaDS As ShangrilaDS
    Friend WithEvents PROMOTIONBS As BindingSource
    Friend WithEvents TAPROMOTION As ShangrilaDSTableAdapters.PROMOTIONTableAdapter
    Friend WithEvents PromoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VolumeDiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GunaCircleButton4 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label7 As Label
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents PromoComboBox As ComboBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
End Class
