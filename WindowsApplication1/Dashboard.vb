Public Class Dashboard
    Public loggedUser As String
    Public NameofUser As String
    Private images(3) As System.Drawing.Image
    Private index As Integer
    Dim check As Integer = 0
    Dim count As Integer = 0

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
        Dim min As Double = RW
        If RW > RH Then
            min = RH
        End If
        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            ' Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * min), Ctrl.Font.Style)
        Next
        With PictureBox2
            .Width += CInt(PictureBox2.Width * RW)
            .Height += CInt(PictureBox2.Height * RH)
        End With
        With PictureBox3
            .Width += CInt(PictureBox3.Width * RW)
            .Height += CInt(PictureBox3.Height * RH)
        End With
        With PictureBox4
            .Width += CInt(PictureBox4.Width * RW)
            .Height += CInt(PictureBox4.Height * RH)
        End With
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub Dashboard_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        Form1.Show()
        If check = 0 Then
            Form1.Close()
        End If
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        max()
        lblHello.Parent = PictureBox1
        lblDashboard.Parent = PictureBox1
        lblGH.Parent = PictureBox1
        IITGLogo.Parent = PictureBox1
        Me.WindowState = FormWindowState.Maximized
        NameofUser = UserTableTableAdapter1.getNamebyUsername(loggedUser)
        lblHello.Text = "Hello! " & NameofUser
        Console.WriteLine(lblHello.Text)
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Console.WriteLine(loggedUser)
        formUpdatePassword.loggedUser = loggedUser
        formUpdatePassword.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        check = 1
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub slideshow()
        If count = 0 Then
            PictureBox3.Left = PictureBox2.Width + PictureBox2.Left - 3
            PictureBox4.Left = PictureBox3.Width + PictureBox3.Left - 3
        ElseIf count = 1 Then
            PictureBox4.Left = PictureBox3.Width + PictureBox3.Left - 3
            PictureBox2.Left = PictureBox4.Width + PictureBox4.Left - 3
        Else
            PictureBox2.Left = PictureBox4.Width + PictureBox4.Left - 3
            PictureBox3.Left = PictureBox2.Width + PictureBox2.Left - 3
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If count = 0 Then
            PictureBox2.Left -= 1
            slideshow()
        ElseIf count = 1 Then
            PictureBox3.Left -= 1
            slideshow()
        Else
            PictureBox4.Left -= 1
            slideshow()
        End If
        If PictureBox2.Left = 0 Then
            count = 0
        ElseIf PictureBox3.Left = 0 Then
            count = 1
        ElseIf PictureBox4.Left = 0 Then
            count = 2
        End If
        Timer1.Start()
        Console.Write(count.ToString)
    End Sub

    Private Sub btnBookARoom_Click(sender As Object, e As EventArgs) Handles btnBookARoom.Click
        Check_Availability.loggedUser = loggedUser
        Check_Availability.Show()
    End Sub
End Class