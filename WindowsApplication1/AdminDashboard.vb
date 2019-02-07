Public Class AdminDashboard

    Private Sub max()
        Dim CW As Integer = Me.Width ' Current Width
        Dim CH As Integer = Me.Height ' Current Height
        Me.WindowState = FormWindowState.Maximized
        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Public loggedUser As String

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        Me.WindowState = FormWindowState.Maximized
        lblHello.Text = "Hello! " & loggedUser
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Console.WriteLine(loggedUser)
        formUpdatePassword.loggedUser = loggedUser
        formUpdatePassword.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Form1.Show()
        Me.Close()
        'LoginForm1.Close()
    End Sub

    Private Sub btnApproveUsers_Click(sender As Object, e As EventArgs) Handles btnApproveUsers.Click
        approveUsers.Show()
    End Sub
End Class