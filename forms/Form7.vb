Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SignupdetailsDataSet6.RoomStatus' table. You can move, or remove it, as needed.
        Me.RoomStatusTableAdapter.Fill(Me.SignupdetailsDataSet6.RoomStatus)



    End Sub

End Class