Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And MaskedTextBox1.Text = "psg" Then
            Me.Hide()
            Selection.Show()
        Else
            MessageBox.Show("Incorrect Username or Password")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class
