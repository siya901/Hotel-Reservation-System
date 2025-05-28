Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SignupdetailsDataSet4.signupdetails' table. You can move, or remove it, as needed.
        Me.SignupdetailsTableAdapter.Fill(Me.SignupdetailsDataSet4.signupdetails)

    End Sub
End Class