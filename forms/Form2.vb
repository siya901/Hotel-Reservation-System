Public Class Form2
    Private Sub ReservationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationFormToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub RoomAvaliabiltityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomAvaliabiltityToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class