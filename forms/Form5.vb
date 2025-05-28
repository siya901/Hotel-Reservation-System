Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form5



    'New Booking
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Check if a room is selected and dates are valid
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select a room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Convert DateTime values to string in a format SQL Server understands (e.g., yyyy-MM-dd)
        Dim Dt1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim Dt2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        ' Check if the selected check-in date is not less than today's date
        If DateTimePicker1.Value.Date < DateTime.Now.Date OrElse DateTimePicker2.Value.Date < DateTime.Now.Date Then
            MessageBox.Show("Check-in and check-out date cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Open connection to the database
            Using con As New SqlConnection("Data Source=SIYA\SQLEXPRESS;Initial Catalog=signupdetails;Integrated Security=True;Encrypt=False")
                con.Open()

                ' Insert booking information into the database
                Dim query As String = "INSERT INTO [dbo].[RoomStatus] ([R_no], [checkin_date], [checkout_date]) VALUES (@R_no, @checkin_date, @checkout_date)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@R_no", ComboBox1.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@checkin_date", Dt1)
                    cmd.Parameters.AddWithValue("@checkout_date", Dt2)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Booking Done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'show form4'
                Dim ob As New Form3
                ob.rn = ComboBox1.SelectedItem.ToString()
                ob.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    'step 1

    Private Sub Add_columns()
        DataGridView1.Columns.Add("R_no", "Room no")
        Dim Daysinmonths As Integer = DateTime.DaysInMonth(MonthCalendar1.SelectionStart.Year, MonthCalendar1.SelectionStart.Month)

        For i = 1 To Daysinmonths
            DataGridView1.Columns.Add(i, i)

        Next


    End Sub


    'step 2


    Private Sub Add_rows()
        For i = 101 To 110
            DataGridView1.Rows.Add(i.ToString)

        Next
    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()
        Add_columns()
        Add_rows()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim constring As String = "Data Source=SIYA\SQLEXPRESS;Initial Catalog=signupdetails;Integrated Security=True;Encrypt=False"
        Dim con As New SqlConnection(constring)
        con.Open()

        Dim query As String = "select * from RoomStatus where checkin_date>=@st AND checkout_date<=@et"
        Dim startdate As DateTime = New DateTime(MonthCalendar1.SelectionStart.Year, MonthCalendar1.SelectionStart.Month, 1)
        Dim Enddate As DateTime = startdate.AddMonths(1)

        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@st", startdate)
        cmd.Parameters.AddWithValue("@et", Enddate)

        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            Dim R_num As Integer = dr.GetInt32(1)
            Dim start_date As DateTime = dr.GetDateTime(2)
            Dim End_date As DateTime = dr.GetDateTime(3)
            Dim totalDays As Integer = (End_date - start_date).Days

            For i As Integer = 0 To totalDays
                DataGridView1.Rows(R_num - 101).Cells(start_date.Day + i).Style.BackColor = Color.Red
            Next
        End While
    End Sub


End Class