Public Class MenuForm

    Private Sub Products_Click(sender As System.Object, e As System.EventArgs) Handles Products.Click
        Product_Information.Show()
        Me.Hide()
    End Sub

    Private Sub MenuForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = LoginForm.ComboBox1.SelectedItem.ToString()
    End Sub

    Private Sub Sale_Click(sender As System.Object, e As System.EventArgs) Handles Sale.Click
        Purchase_Products.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton4_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton4.Click
        Me.Close()
    End Sub
End Class