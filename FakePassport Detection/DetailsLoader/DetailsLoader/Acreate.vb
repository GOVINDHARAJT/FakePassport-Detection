Imports System.IO
Imports System.Data.SqlClient
Public Class Acreate
    Dim connection1 As New SqlConnection("Server = RAJU\SQLEXPRESS; Database = DetailsLoader; Integrated Security = true")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim checkedRadioButton As RadioButton
        checkedRadioButton =
    GroupBox1.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked)
        Dim command As New SqlCommand("insert into Aadhardetails(FirstName,
LastName,DOB,Gender,Age,HouseNo,Street,Town,District,State,Pincode,Mailid
,Mobno,Aid,Fingerprint)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Text & "',
'" & checkedRadioButton.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox11.Text & "'
,'" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "'
,'" & Label17.Text & "',@img)", connection1)
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        command.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()

        connection1.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Enrolled Sucessfull")
        Else
            MessageBox.Show("Enroll error")

        End If
        Me.Hide()
        Selection.Show()
        Close()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Selection.Show()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Admin.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ran As New Random
        Label17.Text = ran.Next(1000000000, 1999999999)
    End Sub

    Private Sub Acreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

End Class