Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SignupdetailsDataSet13.reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter1.Fill(Me.SignupdetailsDataSet13.reservation)


    End Sub
End Class