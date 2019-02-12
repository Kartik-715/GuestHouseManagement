Public Class Dashboard
    Public loggedUser As String
    Public NameofUser As String
    Public updatepasword As Boolean = False
    Public mybookings As Boolean = False
    Public mybills As Boolean = False
    Dim steps As Integer = 20
    Dim togglBok As Boolean = False
    Dim togglUP As Boolean = False
    Dim togglMB As Boolean = False
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

    Dim CW As Integer ' Current Width
    Dim CH As Integer  ' Current Height
    Dim RW As Double  ' Ratio change of width
    Dim RH As Double  ' Ratio change of height
    Dim min As Double
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
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            If TypeOf Ctrl Is TextBox Then
                Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * (min + 1)), Ctrl.Font.Style)
            End If
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

    Private Sub frminit()
        Check_Availability.Hide()
        GroupBox1.Hide()
        UserControl_admindashboardnontabular1.Hide()
        GroupBoxBill.Hide()
    End Sub

    Private Sub btnclicks()
        mybills = False
        mybookings = False
        updatepasword = False
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

    Public Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()
        max()
        lblHello.Parent = PictureBox1
        lblDashboard.Parent = PictureBox1
        lblGH.Parent = PictureBox1
        IITGLogo.Parent = PictureBox1
        btnclicks()
        frminit()
        GroupBoxBill.Top = 2
        GroupBoxBill.Left = 0
        NameofUser = UserTableTableAdapter1.getNamebyUsername(loggedUser)
        lblHello.Text = "Hello! " & NameofUser
        BookingTableAdapter1.FillCurrentBooking(GuestHouseDataSet1.Booking, CInt(Date.Now.ToString("yyyyMMdd")), loggedUser)
        Dim currBooking As guestHouseDataSet.BookingRow
        If GuestHouseDataSet1.Booking.Rows.Count = 0 Then
        Else
            ' Get The Most Recent Booking of the User '
            currBooking = GuestHouseDataSet1.Booking.Rows(0)
            lblBookingID.Text = "Booking ID:     " & currBooking.ID.ToString
            lblBookedFor.Text = "Booking For:    " & currBooking.BookingForFirstName & " " & currBooking.BookingForLastName
            lblBookedTill.Text = "Booked Till:   " & DateTime.ParseExact(currBooking.BookedTill.ToString, "yyyyMMdd", Nothing)
            lblBookedFrom.Text = "Booked From:   " & DateTime.ParseExact(currBooking.BookedFrom.ToString, "yyyyMMdd", Nothing)
            'Calculation of Bill'
            lblRoomCharges.Text = "Room Charges :    " & currBooking.Bill.ToString
            lblTax.Text = "Tax ( 5% ):              " & (currBooking.Bill * 0.05).ToString
            lblTotal.Text = "Total Amount:        " & (currBooking.Bill + (currBooking.Bill * 0.05)).ToString

        End If
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        frminit()
        btnclicks()
        togglBok = False
        togglMB = False
        upsize()
        togglUP = Not (togglUP)
        updatepasword = True
        UserControl_admindashboardnontabular1.btnSaveChanges.Visible = False
        UserControl_admindashboardnontabular1.Visible = True
        UserControl_admindashboardnontabular1.BringToFront()
        UserControl_admindashboardnontabular1.GroupBox2.Show()
        Timer2.Start()
    End Sub

    Private Sub upsize()
        UserControl_admindashboardnontabular1.GroupBox2.Left = 50
        UserControl_admindashboardnontabular1.Width = 600
        UserControl_admindashboardnontabular1.Height = 300
        UserControl_admindashboardnontabular1.Top = 0
        If togglUP = False Or updatepasword = False Then
            UserControl_admindashboardnontabular1.Left = -810
        End If
        If togglUP = True Then
            UserControl_admindashboardnontabular1.Left = 0
        End If
    End Sub

    Private Sub myboksize()
        If togglBok = False Or mybookings = False Then
            GroupBox1.Left = GroupBox1.Left - GroupBox1.Width + 10
        End If
        If togglBok = True Then
            GroupBox1.Left = 2
        End If
    End Sub

    Private Sub mybillsize()
        If togglMB = False Or mybills = False Then
            GroupBoxBill.Left = GroupBoxBill.Left - GroupBox1.Width + 10
        End If
        If togglMB = True Then
            GroupBoxBill.Left = 2
        End If
    End Sub

    Private Sub btnUpdatePassword_MouseDown(sender As Object, e As EventArgs) Handles btnUpdatePassword.MouseHover
        btnUpdatePassword.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnUpdatePassword_MouseOver(sender As Object, e As EventArgs) Handles btnUpdatePassword.MouseLeave
        btnUpdatePassword.FlatAppearance.BorderSize = 0
    End Sub


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        check = 1
        Me.Close()
    End Sub
    Private Sub btnLogout_MouseDown(sender As Object, e As EventArgs) Handles btnLogOut.MouseHover
        btnLogOut.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnLogout_MouseOver(sender As Object, e As EventArgs) Handles btnLogOut.MouseLeave
        btnLogOut.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnMyBookings_MouseDown(sender As Object, e As EventArgs) Handles btnMyBookings.MouseHover
        btnMyBookings.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnMyBookings_MouseOver(sender As Object, e As EventArgs) Handles btnMyBookings.MouseLeave
        btnMyBookings.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnMyBills_MouseDown(sender As Object, e As EventArgs) Handles btnMyBills.MouseHover
        btnMyBills.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnMyBills_MouseOver(sender As Object, e As EventArgs) Handles btnMyBills.MouseLeave
        btnMyBills.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnBookARoom_MouseDown(sender As Object, e As EventArgs) Handles btnBookARoom.MouseHover
        btnBookARoom.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnBookARoom_MouseOver(sender As Object, e As EventArgs) Handles btnBookARoom.MouseLeave
        btnBookARoom.FlatAppearance.BorderSize = 0
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
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        If togglUP = True Or togglBok = True Or togglMB = True Then
            steps = 20
        Else
            steps = -20
        End If
        If mybookings = True Then
            If (GroupBox1.Left < 0 And togglBok = True) Or (GroupBox1.Left > -GroupBox1.Width And togglBok = False) Then
                GroupBox1.Left += steps
            End If
            If GroupBox1.Left > 0 Then
                GroupBox1.Left = 0
            End If
        End If
        If mybills = True Then
            If (GroupBoxBill.Left < 0 And togglMB = True) Or (GroupBoxBill.Left > -GroupBoxBill.Width And togglMB = False) Then
                GroupBoxBill.Left += steps
            End If
            If GroupBoxBill.Left > 0 Then
                GroupBoxBill.Left = 0
            End If
        End If
        If updatepasword = True Then
            If (UserControl_admindashboardnontabular1.Left < 0 And togglUP = True) Or (UserControl_admindashboardnontabular1.Left > -810 And togglUP = False) Then
                UserControl_admindashboardnontabular1.Left += steps
            End If
            If UserControl_admindashboardnontabular1.Left > 0 Then
                UserControl_admindashboardnontabular1.Left = 0
            End If
        End If
        Timer2.Start()
    End Sub

    Private Sub btnBookARoom_Click(sender As Object, e As EventArgs) Handles btnBookARoom.Click
        Check_Availability.loggedUser = loggedUser
        Check_Availability.BringToFront()
        Check_Availability.Show()
    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles btnMyBookings.Click
        frminit()
        btnclicks()
        togglUP = False
        togglMB = False
        myboksize()
        togglBok = Not (togglBok)
        mybookings = True
        GroupBox1.Visible = True
        Timer2.Start()
    End Sub

    Private Sub btnMyBills_Click(sender As Object, e As EventArgs) Handles btnMyBills.Click
        frminit()
        btnclicks()
        togglUP = False
        togglBok = False
        mybillsize()
        togglMB = Not (togglMB)
        mybills = True
        GroupBoxBill.Visible = True
        Timer2.Start()
    End Sub
End Class