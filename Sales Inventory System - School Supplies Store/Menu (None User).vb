Public Class Menu__None_User_

    Private Sub Menu__None_User__Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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