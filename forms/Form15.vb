
Imports System.Data
Imports System.Data.SqlClient
Public Class Form15
    Public Property pass As String
    Public Property rno As String
    Public Property days As String



    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = pass
        Label2.Text = rno
        Label3.Text = days

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("THANK YOU!!")
        Me.Close()
    End Sub
End Class