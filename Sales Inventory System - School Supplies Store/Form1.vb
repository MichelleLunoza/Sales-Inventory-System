Public Class LoginForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim password As String

        password = TextBox1.Text

        If ComboBox1.Text = "None" Then
            MessageBox.Show("Successfully Login.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Menu__None_User_.Show()
            Me.Hide()
        ElseIf ComboBox1.Text = "Admin" And password = "admin" Then
            MessageBox.Show("Successfully Login. Welcome Admin", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MenuForm.Show()
            Me.Hide()
        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("Please choose your username", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("The password that you've enter is incorrect. Please try again", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With TextBox1
                .Focus()
                .SelectAll()
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
