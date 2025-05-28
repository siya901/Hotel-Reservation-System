Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SignupdetailsDataSet11.payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.SignupdetailsDataSet11.payment)

    End Sub
End Class