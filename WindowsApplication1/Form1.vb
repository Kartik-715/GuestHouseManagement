Imports System.Runtime.InteropServices
Public Class Form1

    <DllImport("user32.dll", EntryPoint:="SetProcessDPIAware")> _
    Public Shared Function SetProcessDPIAware() As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Sub PreVentFlicker()
        'function to prevent flickering by loading data before loading screen
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Dim CW As Integer ' Current Width
    Dim CH As Integer  ' Current Height
    Dim RW As Double  ' Ratio change of width
    Dim RH As Double  ' Ratio change of height
    Dim min As Double
    ' function to adjust form in different resolutiion
    Private Sub max()
        CW = Me.Width ' Current Width
        CH = Me.Height ' Current Height
        Me.WindowState = FormWindowState.Maximized
        RW = (Me.Width - CW) / CW ' Ratio change of width
        RH = (Me.Height - CH) / CH ' Ratio change of height
        min = RW
        If RW > RH Then
            min = RH
        End If
        For Each Ctrl As Control In Controls
            ' adjust all controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            If TypeOf Ctrl Is TextBox Then
                Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * (min + 1)), Ctrl.Font.Style)
            End If
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub init()
        SignupForm1.Close()
        Check_Availability.Close()
        LoginForm1.Close()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        init()
        ' display sign up form
        SignupForm1.Show()
        SignupForm1.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        init()
        ' display login form
        LoginForm1.Show()
        LoginForm1.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        SetProcessDPIAware()
        max()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        ' close all children form on closing this form
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
    End Sub

    Private Sub btnCheckAvailabality_Click(sender As Object, e As EventArgs) Handles btnCheckAvailabality.Click
        init()
        ' display check availability form
        Check_Availability.Show()
        Check_Availability.Focus()
    End Sub
End Class

