Imports System.Data
Imports System.Data.SqlClient
Public Class form13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ' Check if any of the textboxes is empty
        If TextBox1.Text = "" OrElse TextBox2.Text = "" OrElse TextBox3.Text = "" OrElse TextBox4.Text = "" OrElse TextBox5.Text = "" Then
            MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' If all textboxes are filled, proceed with database operation
        Dim con As SqlConnection = New SqlConnection("Data Source=SIYA\SQLEXPRESS;Initial Catalog=signupdetails;Integrated Security=True;Encrypt=False")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[signupdetails] ([username], [password], [phoneno], [email], [state]) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", con)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class