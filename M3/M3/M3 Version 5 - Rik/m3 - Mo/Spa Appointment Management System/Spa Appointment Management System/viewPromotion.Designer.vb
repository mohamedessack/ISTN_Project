<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewPromotion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewPromotion))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
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
        Me.PROMOTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShangrilaDS = New Spa_Appointment_Management_System.ShangrilaDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PROMOTIONTableAdapter = New Spa_Appointment_Management_System.ShangrilaDSTableAdapters.PROMOTIONTableAdapter()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMOTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShangrilaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.Honeydew
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 1)
        Me.GunaGradientPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(1251, 122)
        Me.GunaGradientPanel1.TabIndex = 2
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = CType(resources.GetObject("GunaTransfarantPictureBox1.Image"), System.Drawing.Image)
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(419, 4)
        Me.GunaTransfarantPictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(164, 114)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 1
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Azure
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromoIDDataGridViewTextBoxColumn, Me.ServiceIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.PromoStartDateDataGridViewTextBoxColumn, Me.PromoEndDateDataGridViewTextBoxColumn, Me.PromoTypeDataGridViewTextBoxColumn, Me.DiscountValueDataGridViewTextBoxColumn, Me.VolumeDiscountDataGridViewTextBoxColumn, Me.PromoDescriptionDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.PROMOTIONBindingSource
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Azure
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(16, 194)
        Me.BunifuCustomDataGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1027, 401)
        Me.BunifuCustomDataGrid1.TabIndex = 3
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
        'PROMOTIONBindingSource
        '
        Me.PROMOTIONBindingSource.DataMember = "PROMOTION"
        Me.PROMOTIONBindingSource.DataSource = Me.ShangrilaDS
        '
        'ShangrilaDS
        '
        Me.ShangrilaDS.DataSetName = "ShangrilaDS"
        Me.ShangrilaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PROMOTIONS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(17, 182)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 12)
        Me.Panel1.TabIndex = 5
        '
        'PROMOTIONTableAdapter
        '
        Me.PROMOTIONTableAdapter.ClearBeforeFill = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(431, 1)
        Me.MetroTextBox1.CustomButton.Margin = New System.Windows.Forms.Padding(4)
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
        Me.MetroTextBox1.Location = New System.Drawing.Point(269, 137)
        Me.MetroTextBox1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.MetroTextBox1.TabIndex = 56
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "Search Promo Type"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.Gray
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'viewPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1248, 630)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "viewPromotion"
        Me.Text = "viewPromotion"
        Me.GunaGradientPanel1.ResumeLayout(False)
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMOTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShangrilaDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShangrilaDS As ShangrilaDS
    Friend WithEvents PROMOTIONBindingSource As BindingSource
    Friend WithEvents PROMOTIONTableAdapter As ShangrilaDSTableAdapters.PROMOTIONTableAdapter
    Friend WithEvents PromoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VolumeDiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromoDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
End Class
