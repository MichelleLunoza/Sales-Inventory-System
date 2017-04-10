Public Class Product_Information

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub Product_Information_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Database2DataSet.Products)
        Label2.Text = LoginForm.ComboBox1.SelectedItem.ToString()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

        PriceTextBox.ReadOnly = True
        Product_NameTextBox.ReadOnly = True
        Product_IDTextBox.ReadOnly = True
        Product_DescriptionTextBox.ReadOnly = True

        Product_NameTextBox.BackColor = Color.Gray
        Product_IDTextBox.BackColor = Color.Gray
        Product_DescriptionTextBox.BackColor = Color.Gray
        PriceTextBox.BackColor = Color.Gray
        MessageBox.Show("Succesfully Updated!", "Updated")


        Home.Visible = True
        Edit.Visible = True
        Delete.Visible = True
        Add.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Edit_Click(sender As System.Object, e As System.EventArgs) Handles Edit.Click
        PriceTextBox.ReadOnly = False
        Product_NameTextBox.ReadOnly = False
        Product_IDTextBox.ReadOnly = False
        Product_DescriptionTextBox.ReadOnly = False

        Product_NameTextBox.BackColor = Color.Beige
        Product_IDTextBox.BackColor = Color.Beige
        Product_DescriptionTextBox.BackColor = Color.Beige
        PriceTextBox.BackColor = Color.Beige

        Home.Visible = True
        Edit.Visible = True
        Delete.Visible = True
        Add.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Delete_Click(sender As System.Object, e As System.EventArgs) Handles Delete.Click
        Dim dialogResult As DialogResult

        dialogResult = MessageBox.Show("Do you really want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = Windows.Forms.DialogResult.Yes Then
            ProductsBindingSource.RemoveCurrent()
            Me.ProductsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)
            MessageBox.Show("Successfully Deleted", "Deleted")
        End If
    End Sub

    Private Sub Add_Click(sender As System.Object, e As System.EventArgs) Handles Add.Click
        Product_NameTextBox.ReadOnly = False
        Product_IDTextBox.ReadOnly = False
        Product_DescriptionTextBox.ReadOnly = False
        PriceTextBox.ReadOnly = False

        Product_NameTextBox.BackColor = Color.Beige
        Product_IDTextBox.BackColor = Color.Beige
        Product_DescriptionTextBox.BackColor = Color.Beige
        PriceTextBox.BackColor = Color.Beige

        Me.ProductsBindingSource.AddNew()
        Product_IDTextBox.Focus()

        Home.Visible = False
        Edit.Visible = False
        Delete.Visible = False
        Add.Visible = False

    End Sub

    Private Sub Home_Click(sender As System.Object, e As System.EventArgs) Handles Home.Click
        MenuForm.Show()
        Me.Hide()
    End Sub
End Class