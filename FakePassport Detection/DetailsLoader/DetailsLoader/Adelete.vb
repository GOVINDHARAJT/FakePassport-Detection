Imports System.Data.SqlClient
Public Class Adelete
    Dim connection As New SqlConnection("Server = RAJU\SQLEXPRESS; Database = DetailsLoader; Integrated Security = true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim command As New SqlCommand("delete from Aadhardetails where Aid='" & TextBox1.Text & "'", connection)
        connection.Open()
        command.ExecuteNonQuery()
        MessageBox.Show("User Deleted")

    End Sub

End Class