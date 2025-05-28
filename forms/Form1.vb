
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Data Source=SIYA\SQLEXPRESS;Initial Catalog=signupdetails;Integrated Security=True;Encrypt=False")
        Dim command As New SqlCommand("select * from signupdetails where Username = @username and Password = @password", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).value = TextBox1.Text
        Command.Parameters.Add("@password", SqlDbType.VarChar).value = TextBox2.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Try
            If (TextBox1.Text = "Admin" And TextBox2.Text = "Admin") Then
                MessageBox.Show("Login successful! Welcome Admin")
                Form6.Show()
                Me.Hide()
            ElseIf table.Rows.Count <= 0 Then
                MessageBox.Show("Username or Password is invalid")
                TextBox1.Text = ""
                TextBox2.Text = ""
            Else

                MessageBox.Show("Login successful")
                Form2.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        form13.ShowDialog()
        Me.Close()
    End Sub


End Class
