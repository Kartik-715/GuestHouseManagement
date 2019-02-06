Public Class Dashboard

    Public loggedUser As String

    Private Sub Dashboard_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        lblHello.Text = "Hello! " & loggedUser
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        formUpdatePassword.loggedUser = loggedUser
        formUpdatePassword.Show()
    End Sub
End Class