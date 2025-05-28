Imports System.Data
Imports System.Data.SqlClient
Public Class Form8
    Dim con As SqlConnection = New SqlConnection("Data Source=SIYA\SQLEXPRESS;Initial Catalog=signupdetails;Integrated Security=True;Encrypt=False")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[room]
      ([R_no]
      ,[R_type]
      ,[R_price]
      ,[No_of_person])
VALUES
   ('" + ComboBox1.SelectedItem + "','" + ComboBox2.SelectedItem + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Room added successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        con.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("DELETE FROM room WHERE R_no = @R_no", con)
            cmd.Parameters.AddWithValue("@R_no", ComboBox1.SelectedItem)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("UPDATE room SET R_type = @R_type, R_price = @R_price, No_of_person = @No_of_person WHERE R_no = @R_no", con)
            cmd.Parameters.AddWithValue("@R_no", ComboBox1.SelectedItem)
            cmd.Parameters.AddWithValue("@R_type", ComboBox2.SelectedItem)
            cmd.Parameters.AddWithValue("@R_price", TextBox3.Text)
            cmd.Parameters.AddWithValue("@No_of_person", TextBox4.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SignupdetailsDataSet8.room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.SignupdetailsDataSet8.room)

        con.Close()
    End Sub
End Class
