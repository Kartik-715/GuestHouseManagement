Public Class Dashboard

    Private Sub Dashboard_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class