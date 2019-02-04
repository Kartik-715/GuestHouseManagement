Public Class Form1
    Dim CW As Integer ' Current Width
    Dim CH As Integer ' Current Height
    Dim IW As Integer ' Initial Width
    Dim IH As Integer ' Initial Height

    Private Sub max()
        Me.WindowState = FormWindowState.Maximized
        CW = Me.Width
        CH = Me.Height
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

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignupForm1.Show()
        max()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        max()
        LoginForm1.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load     
        IW = Me.Width
        IH = Me.Height
        max()
        btnSignUp.PerformClick()
        SignupForm1.Close()
        Me.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
