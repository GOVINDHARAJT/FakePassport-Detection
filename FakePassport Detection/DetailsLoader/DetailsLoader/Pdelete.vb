Imports System.Data.SqlClient
Public Class Pdelete
    Dim connection As New SqlConnection("Server = RAJU\SQLEXPRESS; Database = DetailsLoader; Integrated Security = true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim command As New SqlCommand("delete from Passportdetails where Pid='" & TextBox1.Text & "'", connection)
        connection.Open()
        command.ExecuteNonQuery()
        MessageBox.Show("User Deleted")

    End Sub

    Private Sub Pdelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class