<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Information
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Product_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet = New Sales_Inventory_System___School_Supplies_Store.Database2DataSet()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Product_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductsTableAdapter = New Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Product_IDLabel = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        Product_DescriptionLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Product_IDLabel
        '
        Product_IDLabel.AutoSize = True
        Product_IDLabel.Location = New System.Drawing.Point(6, 42)
        Product_IDLabel.Name = "Product_IDLabel"
        Product_IDLabel.Size = New System.Drawing.Size(84, 16)
        Product_IDLabel.TabIndex = 35
        Product_IDLabel.Text = "Product ID:"
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(6, 70)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(110, 16)
        Product_NameLabel.TabIndex = 37
        Product_NameLabel.Text = "Product Name:"
        '
        'Product_DescriptionLabel
        '
        Product_DescriptionLabel.AutoSize = True
        Product_DescriptionLabel.Location = New System.Drawing.Point(6, 98)
        Product_DescriptionLabel.Name = "Product_DescriptionLabel"
        Product_DescriptionLabel.Size = New System.Drawing.Size(148, 16)
        Product_DescriptionLabel.TabIndex = 39
        Product_DescriptionLabel.Text = "Product Description:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(6, 218)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(48, 16)
        PriceLabel.TabIndex = 41
        PriceLabel.Text = "Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(621, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(694, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Product_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Product_IDTextBox)
        Me.GroupBox1.Controls.Add(Product_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Product_NameTextBox)
        Me.GroupBox1.Controls.Add(Product_DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.Product_DescriptionTextBox)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(351, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 312)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'Product_IDTextBox
        '
        Me.Product_IDTextBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Product_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Product ID", True))
        Me.Product_IDTextBox.Location = New System.Drawing.Point(160, 39)
        Me.Product_IDTextBox.Name = "Product_IDTextBox"
        Me.Product_IDTextBox.ReadOnly = True
        Me.Product_IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Product_IDTextBox.TabIndex = 36
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
        Me.Product_NameTextBox.Location = New System.Drawing.Point(160, 67)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.ReadOnly = True
        Me.Product_NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Product_NameTextBox.TabIndex = 38
        '
        'Product_DescriptionTextBox
        '
        Me.Product_DescriptionTextBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Product_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Product Description", True))
        Me.Product_DescriptionTextBox.Location = New System.Drawing.Point(160, 95)
        Me.Product_DescriptionTextBox.Multiline = True
        Me.Product_DescriptionTextBox.Name = "Product_DescriptionTextBox"
        Me.Product_DescriptionTextBox.ReadOnly = True
        Me.Product_DescriptionTextBox.Size = New System.Drawing.Size(200, 114)
        Me.Product_DescriptionTextBox.TabIndex = 40
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(160, 215)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PriceTextBox.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(273, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 26)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.Button1, "Save")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(1, 378)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(809, 49)
        Me.Panel2.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Product Information"
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Product Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.AutoGenerateColumns = False
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.ProductsDataGridView.DataSource = Me.ProductsBindingSource
        Me.ProductsDataGridView.Location = New System.Drawing.Point(23, 45)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.Size = New System.Drawing.Size(303, 312)
        Me.ProductsDataGridView.TabIndex = 43
        '
        'Delete
        '
        Me.Delete.BackgroundImage = Global.Sales_Inventory_System___School_Supplies_Store.My.Resources.Resources.delete
        Me.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Delete.Location = New System.Drawing.Point(745, 205)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(53, 48)
        Me.Delete.TabIndex = 40
        Me.Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Delete, "Delete Product")
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.BackgroundImage = Global.Sales_Inventory_System___School_Supplies_Store.My.Resources.Resources.edit
        Me.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Edit.Location = New System.Drawing.Point(745, 259)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(53, 48)
        Me.Edit.TabIndex = 41
        Me.Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Edit, "Edit Product")
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.BackgroundImage = Global.Sales_Inventory_System___School_Supplies_Store.My.Resources.Resources.add
        Me.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add.Location = New System.Drawing.Point(745, 151)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(54, 48)
        Me.Add.TabIndex = 39
        Me.Add.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.Add, "Add Product")
        Me.Add.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.BackgroundImage = Global.Sales_Inventory_System___School_Supplies_Store.My.Resources.Resources.home
        Me.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Home.Location = New System.Drawing.Point(745, 97)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(53, 48)
        Me.Home.TabIndex = 36
        Me.Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Home, "Home")
        Me.Home.UseVisualStyleBackColor = True
        '
        'Product_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(810, 432)
        Me.Controls.Add(Me.ProductsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Product_Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Database2DataSet As Sales_Inventory_System___School_Supplies_Store.Database2DataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As Sales_Inventory_System___School_Supplies_Store.Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Product_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Product_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Product_DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
