Public Class AdminDashboard
    Public loggedUser As String

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
            Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * RW), Ctrl.Font.Style)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub AdminDashboard_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        Form1.Hide()
        Me.WindowState = FormWindowState.Maximized
        lblHello.Text = "Hello! " & loggedUser
        labelNonApproved.Text = "There are " & UserTableTableAdapter1.numNonApproved & " non Approved Users "
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        formUpdatePassword.loggedUser = loggedUser
        formUpdatePassword.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
    End Sub

    Private Sub btnApproveUsers_Click(sender As Object, e As EventArgs) Handles btnApproveUsers.Click
        approveUsers.Show()
    End Sub
End Class