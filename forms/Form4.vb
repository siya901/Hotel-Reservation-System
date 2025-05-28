Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form4
    Public Property nam As String
    Public Property rno As String

    Dim connectionString As String = "Data Source=SIYA\SQLEXPRESS;Initial Catalog=signupdetails;Integrated Security=True;Encrypt=False"
    Dim connection As New SqlConnection(connectionString)

    Private Sub TotalAmount()
        Dim roomNo As String = ComboBox1.SelectedItem
        Dim days As Integer = Convert.ToInt32(TextBox3.Text)

        Dim query As String = "SELECT R_price FROM room WHERE R_no = @RoomNo"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@RoomNo", roomNo)

        connection.Open()
        Dim price As Integer = Convert.ToInt32(command.ExecuteScalar())
        connection.Close()

        Dim totalAmount As Decimal = price * days
        TextBox4.Text = totalAmount.ToString()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = nam
        ComboBox1.SelectedItem = rno
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        ' Perform payment process
        Dim paymentProgress As Integer = 0

        ' Update progress bar value
        paymentProgress += 50
        ProgressBar1.Value = paymentProgress

        ' Execute SQL command to insert payment details
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[payment] ([username], [R_no], [R_price], [no_of_days], [mode], [Total_amount]) VALUES ('" + TextBox1.Text + "','" + ComboBox1.SelectedItem + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + ComboBox3.SelectedItem + "','" + TextBox4.Text + "')", connection)

        connection.Open()
        cmd.ExecuteNonQuery()

        ' Update progress bar value
        paymentProgress += 50
        ProgressBar1.Value = paymentProgress

        MessageBox.Show("Transaction successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim obj As New Form15
        obj.pass = TextBox1.Text
        obj.rno = ComboBox1.SelectedItem.ToString()
        obj.days = TextBox3.Text
        obj.ShowDialog()

        connection.Close()

        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox3.SelectedIndex = -1
        TextBox4.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox3.SelectedItem = "" OrElse TextBox1.Text = "" OrElse ComboBox1.SelectedItem = "" OrElse TextBox3.Text = "" Then
            MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        TotalAmount()
        Dim roomNo As String = ComboBox1.SelectedItem.ToString()

        Dim query As String = "SELECT R_price FROM room WHERE R_no = @RoomNo"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@RoomNo", roomNo)

        connection.Open()
        Dim price As Object = command.ExecuteScalar()
        connection.Close()

        If price IsNot Nothing Then
            TextBox2.Text = price.ToString()
        Else
            MessageBox.Show("Room price not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class