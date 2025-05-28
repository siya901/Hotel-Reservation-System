Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SignupdetailsDataSet12.payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.SignupdetailsDataSet12.payment)

    End Sub
End Class