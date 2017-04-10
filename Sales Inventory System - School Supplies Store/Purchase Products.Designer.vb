<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_Products
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
        Dim Product_IDLabel As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim Product_DescriptionLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase_Products))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Product_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet = New Sales_Inventory_System___School_Supplies_Store.Database2DataSet()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Product_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Purchase = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.TableAdapterManager()
        Me.ProductsTableAdapter = New Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.ProductsTableAdapter()
        Me.PurchasePrint = New System.Drawing.Printing.PrintDocument()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ExitButton2 = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.Report_TableTableAdapter = New Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.Report_TableTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Product_IDLabel = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        Product_DescriptionLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Product_IDLabel
        '
        Product_IDLabel.AutoSize = True
        Product_IDLabel.Location = New System.Drawing.Point(19, 41)
        Product_IDLabel.Name = "Product_IDLabel"
        Product_IDLabel.Size = New System.Drawing.Size(84, 16)
        Product_IDLabel.TabIndex = 54
        Product_IDLabel.Text = "Product ID:"
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(19, 69)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(110, 16)
        Product_NameLabel.TabIndex = 56
        Product_NameLabel.Text = "Product Name:"
        '
        'Product_DescriptionLabel
        '
        Product_DescriptionLabel.AutoSize = True
        Product_DescriptionLabel.Location = New System.Drawing.Point(19, 97)
        Product_DescriptionLabel.Name = "Product_DescriptionLabel"
        Product_DescriptionLabel.Size = New System.Drawing.Size(148, 16)
        Product_DescriptionLabel.TabIndex = 58
        Product_DescriptionLabel.Text = "Product Description:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(19, 180)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(48, 16)
        PriceLabel.TabIndex = 60
        PriceLabel.Text = "Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(621, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(694, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 46
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Product_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Product_IDTextBox1)
        Me.GroupBox1.Controls.Add(Product_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Product_NameTextBox)
        Me.GroupBox1.Controls.Add(Product_DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.Product_DescriptionTextBox)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Purchase)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Calculate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(361, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 368)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'Product_IDTextBox1
        '
        Me.Product_IDTextBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Product_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Product ID", True))
        Me.Product_IDTextBox1.Location = New System.Drawing.Point(173, 38)
        Me.Product_IDTextBox1.Name = "Product_IDTextBox1"
        Me.Product_IDTextBox1.ReadOnly = True
        Me.Product_IDTextBox1.Size = New System.Drawing.Size(187, 22)
        Me.Product_IDTextBox1.TabIndex = 55
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.Database2DataSet
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Product Name", True))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(173, 66)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.ReadOnly = True
        Me.Product_NameTextBox.Size = New System.Drawing.Size(187, 22)
        Me.Product_NameTextBox.TabIndex = 57
        '
        'Product_DescriptionTextBox
        '
        Me.Product_DescriptionTextBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Product_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Product Description", True))
        Me.Product_DescriptionTextBox.Location = New System.Drawing.Point(173, 94)
        Me.Product_DescriptionTextBox.Multiline = True
        Me.Product_DescriptionTextBox.Name = "Product_DescriptionTextBox"
        Me.Product_DescriptionTextBox.ReadOnly = True
        Me.Product_DescriptionTextBox.Size = New System.Drawing.Size(187, 77)
        Me.Product_DescriptionTextBox.TabIndex = 59
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(173, 177)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(187, 22)
        Me.PriceTextBox.TabIndex = 61
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox4.Location = New System.Drawing.Point(173, 289)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(187, 22)
        Me.TextBox4.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Change:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(173, 261)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(187, 22)
        Me.TextBox3.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Cash:"
        '
        'Purchase
        '
        Me.Purchase.Location = New System.Drawing.Point(226, 325)
        Me.Purchase.Name = "Purchase"
        Me.Purchase.Size = New System.Drawing.Size(110, 23)
        Me.Purchase.TabIndex = 50
        Me.Purchase.Text = "Purchase"
        Me.Purchase.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportTableBindingSource, "Total Cost", True))
        Me.TextBox2.Location = New System.Drawing.Point(173, 233)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 22)
        Me.TextBox2.TabIndex = 49
        '
        'ReportTableBindingSource
        '
        Me.ReportTableBindingSource.DataMember = "Report Table"
        Me.ReportTableBindingSource.DataSource = Me.Database2DataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Total Cost:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Database2DataSet, "Report Table.Quantity", True))
        Me.TextBox1.Location = New System.Drawing.Point(173, 205)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 22)
        Me.TextBox1.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Quantity:"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(99, 325)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(110, 23)
        Me.Calculate.TabIndex = 36
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(830, 49)
        Me.Panel2.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Sale - Products"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.PurchasedTableAdapter = Nothing
        Me.TableAdapterManager.Report_TableTableAdapter = Nothing
        Me.TableAdapterManager.ReportTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'PurchasePrint
        '
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.AutoGenerateColumns = False
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.ProductsDataGridView.DataSource = Me.ProductsBindingSource
        Me.ProductsDataGridView.Location = New System.Drawing.Point(13, 42)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.Size = New System.Drawing.Size(324, 364)
        Me.ProductsDataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Product Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 275
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ExitButton2
        '
        Me.ExitButton2.BackgroundImage = Global.Sales_Inventory_System___School_Supplies_Store.My.Resources.Resources._exit
        Me.ExitButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton2.Location = New System.Drawing.Point(762, 264)
        Me.ExitButton2.Name = "ExitButton2"
        Me.ExitButton2.Size = New System.Drawing.Size(53, 48)
        Me.ExitButton2.TabIndex = 53
        Me.ExitButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.ExitButton2, "Exit Program")
        Me.ExitButton2.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.BackgroundImage = Global.Sales_Inventory_System___School_Supplies_Store.My.Resources.Resources.cancel
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.Location = New System.Drawing.Point(762, 210)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(53, 48)
        Me.Cancel.TabIndex = 52
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancel, "Cancel Transaction")
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.BackgroundImage = Global.Sales_Inventory_System___School_Supplies_Store.My.Resources.Resources.home
        Me.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Home.Location = New System.Drawing.Point(762, 156)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(53, 48)
        Me.Home.TabIndex = 51
        Me.Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Home, "Home")
        Me.Home.UseVisualStyleBackColor = True
        '
        'Report_TableTableAdapter
        '
        Me.Report_TableTableAdapter.ClearBeforeFill = True
        '
        'Purchase_Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(830, 481)
        Me.Controls.Add(Me.ProductsDataGridView)
        Me.Controls.Add(Me.ExitButton2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Purchase_Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase_Products"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExitButton2 As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents Calculate As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Purchase As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductsTableAdapter As Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents Database2DataSet As Sales_Inventory_System___School_Supplies_Store.Database2DataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchasePrint As System.Drawing.Printing.PrintDocument
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product_IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Product_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Product_DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Report_TableTableAdapter As Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.Report_TableTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
