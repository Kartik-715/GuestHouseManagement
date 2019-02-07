Imports System.Runtime.InteropServices
Public Class Form1

    <DllImport("user32.dll", EntryPoint:="SetProcessDPIAware")> _
    Private Shared Function SetProcessDPIAware() As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub

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

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignupForm1.Close()
        LoginForm1.Close()
        SignupForm1.Show()
        SignupForm1.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        SignupForm1.Close()
        LoginForm1.Close()
        LoginForm1.Show()
        LoginForm1.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        SetProcessDPIAware()
        max()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
    End Sub
End Class

