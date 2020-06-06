Imports System.Data.SqlClient
Public Class Plist
    Dim connection As New SqlConnection("Server = RAJU\SQLEXPRESS; Database = DetailsLoader; Integrated Security = true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adapter As New SqlDataAdapter("select * from Passportdetails where Pid='" & TextBox1.Text & "'", connection)

        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Selection.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim adapter1 As New SqlDataAdapter("select * from Passportdetails", connection)

        Dim table As New DataTable()
        adapter1.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class