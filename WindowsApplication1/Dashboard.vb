Public Class Dashboard

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

    Private Sub Dashboard_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        lblHello.Parent = PictureBox1
        Me.WindowState = FormWindowState.Maximized
        lblHello.Text = "Hello! " & loggedUser
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Console.WriteLine(loggedUser)
        formUpdatePassword.loggedUser = loggedUser
        formUpdatePassword.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
    End Sub



    Private images(3) As System.Drawing.Image
    Private index As Integer

    Public Sub New()
        InitializeComponent()
        images(0) = My.Resources.ghgate
        images(1) = My.Resources.ghnight
        images(2) = My.Resources.GH_dinning
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If images.Count > 0 Then
            If index = 3 Then
                index = 0
            End If
            PictureBox2.Image = images(index)
            index += 1
        End If
    End Sub
End Class