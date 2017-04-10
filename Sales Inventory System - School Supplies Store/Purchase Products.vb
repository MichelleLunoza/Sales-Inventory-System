Public Class Purchase_Products

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub Purchase_Products_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProductsDataGridView.Refresh()
        Purchase.Visible = False
        'TODO: This line of code loads data into the 'Database2DataSet.Report_Table' table. You can move, or remove it, as needed.
        Me.Report_TableTableAdapter.Fill(Me.Database2DataSet.Report_Table)
        'TODO: This line of code loads data into the 'Database2DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Database2DataSet.Products)
        Label2.Text = LoginForm.ComboBox1.SelectedItem.ToString()
        TextBox1.Clear()
        TextBox2.Clear()
  
    End Sub

    Private Sub Calculate_Click(sender As System.Object, e As System.EventArgs) Handles Calculate.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter quantity", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With TextBox1
                .Focus()
            End With
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please enter cash", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With TextBox4
                .Focus()
                Purchase.Visible = False
            End With
        Else

            Dim totalCost, change As Integer

            totalCost = PriceTextBox.Text * TextBox1.Text
            change = TextBox3.Text - totalCost

            TextBox2.Text = totalCost.ToString
            TextBox4.Text = change.ToString

            Purchase.Visible = True
        End If
      
    End Sub

    Private Sub AddToCart_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Home_Click(sender As System.Object, e As System.EventArgs) Handles Home.Click
        MenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Dim dialogResut As DialogResult
        dialogResut = MessageBox.Show("Are you sure you want to cancel this transaction?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResut = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Transaction has been canceled. You are now in the menu", "Cancelled")
            MenuForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ExitButton2_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton2.Click
        Dim dialogResult As DialogResult

        dialogResult = MessageBox.Show("Are you sure you want to close the program?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Purchase_Click(sender As System.Object, e As System.EventArgs) Handles Purchase.Click
        Me.ReportTableBindingSource.AddNew()
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter quantity", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please enter cash", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            PrintPreviewDialog1.Document = PurchasePrint
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PurchasePrint_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PurchasePrint.PrintPage
        Dim printfont As New Font("Arial", 12)
        Dim Heading As New Font("Arial", 15)
        Dim vertical As Single = e.MarginBounds.Left
        Dim horizontal As Single = e.MarginBounds.Top
        Dim lineHeight As Single = lineHeight + 2
        Dim printString As String


        printString = "Sherly's School Supplies Store"
        e.Graphics.DrawString(printString, Heading, Brushes.Red, horizontal, vertical)
        vertical += lineHeight * 12

        printString = "Lumbang Lipa City, Batangas"
        e.Graphics.DrawString(printString, printfont, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 12

        printString = "Contact # 09499023599"
        e.Graphics.DrawString(printString, printfont, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 25

        printString = "Product ID: " & Product_IDTextBox1.Text
        e.Graphics.DrawString(printString, printfont, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 10

        printString = "Product Name: " & Product_NameTextBox.Text
        e.Graphics.DrawString(printString, printfont, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 10

        printString = "Price: " & PriceTextBox.Text
        e.Graphics.DrawString(printString, printfont, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 10

        printString = "Quantity: " & TextBox1.Text
        e.Graphics.DrawString(printString, printfont, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 10

        printString = "Total Cost: " & TextBox2.Text
        e.Graphics.DrawString(printString, Heading, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 20

        printString = "CASH: " & TextBox3.Text
        e.Graphics.DrawString(printString, printfont, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 12

        printString = "CHANGE DUE: " & TextBox4.Text
        e.Graphics.DrawString(printString, printfont, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 25

        printString = "*****OFFICIAL RECEIPT***** "
        e.Graphics.DrawString(printString, Heading, Brushes.Black, horizontal, vertical)
        vertical += lineHeight * 12


    End Sub

End Class