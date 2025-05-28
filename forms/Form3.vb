Imports System.Data
Imports System.Data.SqlClient
Public Class Form3
    Public Property rn As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" OrElse TextBox2.Text = "" OrElse TextBox3.Text = "" OrElse TextBox6.Text = "" Then
            MessageBox.Show("Please fill in all the * fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim con As SqlConnection = New SqlConnection("Data Source=SIYA\SQLEXPRESS;Initial Catalog=signupdetails;Integrated Security=True;Encrypt=False")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[reservation]
           ([username]
           ,[F_name]
           ,[L_name]
           ,[Address]
           ,[Pin_code]
           ,[Mobile_no]
           ,[Gender]
           ,[Age]
           ,[Id_proof_type]
           ,[Id_proof_no])
     VALUES
             ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + ComboBox1.SelectedItem + "','" + TextBox7.Text + "','" + ComboBox2.SelectedItem + "','" + TextBox9.Text + "')", con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Registration Successful👍")
            Me.Close()

            ' Show Form4 with username
            Dim obj As New Form4
            obj.nam = TextBox1.Text
            obj.rno = Label11.Text
            obj.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox7.Clear()
        ComboBox2.SelectedIndex = -1
        TextBox9.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label11.Text = rn
        Label11.Hide()
    End Sub
End Class