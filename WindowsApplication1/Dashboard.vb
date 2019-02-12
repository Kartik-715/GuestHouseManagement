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
    'A function to prevent flickering when opening the windows form
    'We first load the windows form in buffer and then display it on the desktop
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub

    Private Function getCurrBookingData()
        BookingTableAdapter1.FillCurrentBooking(GuestHouseDataSet1.Booking, CInt(Date.Now.ToString("yyyyMMdd")), loggedUser)        'Fills data table adapter according to current booking
        Dim currBooking As guestHouseDataSet.BookingRow
        If GuestHouseDataSet1.Booking.Rows.Count = 0 Then
            'If there isnt current booking then the show it
            lblBookingID.Text = "Booking ID:     None"
            lblBookedFor.Text = "Booking For:    None"
            lblBookedFrom.Text = "Booking From: None"
            lblBookedTill.Text = "Booked Till:   None"
            lblConfirm.Text = "Booking Confirmed: No "
            'Calculation of Bill'
            lblRoomCharges.Text = "Room Charges :    00"
            lblTax.Text = "Tax ( 5% ):              00"
            lblTotal.Text = "Total Amount:        00"
        Else
            ' Get The Most Recent Booking of the User '
            currBooking = GuestHouseDataSet1.Booking.Rows(0)
            lblBookingID.Text = "Booking ID:     " & currBooking.ID.ToString
            lblBookedFor.Text = "Booking For:    " & currBooking.BookingForFirstName & " " & currBooking.BookingForLastName
            lblBookedTill.Text = "Booked Till:   " & DateTime.ParseExact(currBooking.BookedTill.ToString, "yyyyMMdd", Nothing)
            If currBooking.BookingConfirmed Then
                lblConfirm.Text = "Booking Confirmed:  Yes"
            Else

                lblConfirm.Text = "Booking Confirmed:  No"
            End If
            lblBookedFrom.Text = "Booked From:   " & DateTime.ParseExact(currBooking.BookedFrom.ToString, "yyyyMMdd", Nothing)
            'Calculation of Bill'
            lblRoomCharges.Text = "Room Charges :    " & currBooking.Bill.ToString
            lblTax.Text = "Tax ( 5% ):              " & (currBooking.Bill * 0.05).ToString
            lblTotal.Text = "Total Amount:        " & (currBooking.Bill + (currBooking.Bill * 0.05)).ToString

        End If
    End Function

    Dim CW As Integer ' Current Width
    Dim CH As Integer  ' Current Height
    Dim RW As Double  ' Ratio change of width
    Dim RH As Double  ' Ratio change of height
    Dim min As Double
    'A function to resize the windows form according to the screen resolution
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
    ' hides all the forms except the main dashboard 
    Private Sub frminit()
        Check_Availability.Hide()
        GroupBox1.Hide()
        UserControl_admindashboardnontabular1.Hide()
        GroupBoxBill.Hide()
    End Sub
    ' initialise every boolean variable of each button to false
    Private Sub btnclicks()
        mybills = False
        mybookings = False
        updatepasword = False
    End Sub
    'A function defining what happens if a user closes or logs out of dashboard
    'if he/she logs out then show form 1 else close the entire program. along with dashboard close all it's children
    Private Sub Dashboard_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        Form1.Show()
        If check = 0 Then
            Form1.Close()
        End If
    End Sub
    'funtion that defines what happens on loading of the dashboard
    Public Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreVentFlicker()                                            'prevent flicker
        max()                                                       'calling max fn
        lblHello.Parent = PictureBox1
        lblDashboard.Parent = PictureBox1
        lblGH.Parent = PictureBox1
        IITGLogo.Parent = PictureBox1
        btnclicks()
        frminit()
        GroupBoxBill.Top = 2                                        'initial positions of groupbox bill before the sliding
        GroupBoxBill.Left = 0
        NameofUser = UserTableTableAdapter1.getNamebyUsername(loggedUser)           'getting name of loged in user from database
        lblHello.Text = "Hello! " & NameofUser                                      'and displaying it with Hello
    End Sub
    'function that decides what happens when update password is clicked
    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        frminit()                                           'all buttons are closed
        btnclicks()                                         'all boolean variables are false
        togglBok = False                                    'toggle all the slides to false
        togglMB = False
        upsize()                                            'sets the initial position of slides 
        togglUP = Not (togglUP)                             'sets it's toggle to opposite
        updatepasword = True
        UserControl_admindashboardnontabular1.btnSaveChanges.Visible = False        'Selecting Update password in Usercontrol
        UserControl_admindashboardnontabular1.Visible = True
        UserControl_admindashboardnontabular1.BringToFront()
        UserControl_admindashboardnontabular1.GroupBox2.Show()
        Timer2.Start()
    End Sub
    'fn setting initial position and sizes of slides according to thier toggle
    Private Sub upsize()
        UserControl_admindashboardnontabular1.GroupBox2.Left = 50 * Form1.Width / 1920
        UserControl_admindashboardnontabular1.Width = 600 * 1920 / Form1.Width
        UserControl_admindashboardnontabular1.Height = 300 * 1024 / Form1.Height
        UserControl_admindashboardnontabular1.BackColor = System.Drawing.Color.PaleTurquoise
        UserControl_admindashboardnontabular1.Top = 0
        If togglUP = False Or updatepasword = False Then
            UserControl_admindashboardnontabular1.Left = -810
        End If
        If togglUP = True Then
            UserControl_admindashboardnontabular1.Left = 0
        End If
    End Sub
    'setting size of my bookings according to it's toggle
    Private Sub myboksize()
        If togglBok = False Or mybookings = False Then
            GroupBox1.Left = GroupBox1.Left - GroupBox1.Width + 10
        End If
        If togglBok = True Then
            GroupBox1.Left = 2
        End If
    End Sub
    'setting size of my bills according to it's toggle
    Private Sub mybillsize()
        If togglMB = False Or mybills = False Then
            GroupBoxBill.Left = GroupBoxBill.Left - GroupBox1.Width + 10
        End If
        If togglMB = True Then
            GroupBoxBill.Left = 2
        End If
    End Sub
    'showing the lines around the button when mouse is hovered over it
    Private Sub btnUpdatePassword_MouseDown(sender As Object, e As EventArgs) Handles btnUpdatePassword.MouseHover
        btnUpdatePassword.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnUpdatePassword_MouseOver(sender As Object, e As EventArgs) Handles btnUpdatePassword.MouseLeave
        btnUpdatePassword.FlatAppearance.BorderSize = 0
    End Sub

    'When user logs out check changes to 1 and dashboard is closed
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        check = 1
        Me.Close()
    End Sub
    'showing the lines around the button when mouse is hovered over it
    Private Sub btnLogout_MouseDown(sender As Object, e As EventArgs) Handles btnLogOut.MouseHover
        btnLogOut.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnLogout_MouseOver(sender As Object, e As EventArgs) Handles btnLogOut.MouseLeave
        btnLogOut.FlatAppearance.BorderSize = 0
    End Sub
    'showing the lines around the button when mouse is hovered over it
    Private Sub btnMyBookings_MouseDown(sender As Object, e As EventArgs) Handles btnMyBookings.MouseHover
        btnMyBookings.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnMyBookings_MouseOver(sender As Object, e As EventArgs) Handles btnMyBookings.MouseLeave
        btnMyBookings.FlatAppearance.BorderSize = 0
    End Sub
    'showing the lines around the button when mouse is hovered over it
    Private Sub btnMyBills_MouseDown(sender As Object, e As EventArgs) Handles btnMyBills.MouseHover
        btnMyBills.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnMyBills_MouseOver(sender As Object, e As EventArgs) Handles btnMyBills.MouseLeave
        btnMyBills.FlatAppearance.BorderSize = 0
    End Sub
    'showing the lines around the button when mouse is hovered over it
    Private Sub btnBookARoom_MouseDown(sender As Object, e As EventArgs) Handles btnBookARoom.MouseHover
        btnBookARoom.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnBookARoom_MouseOver(sender As Object, e As EventArgs) Handles btnBookARoom.MouseLeave
        btnBookARoom.FlatAppearance.BorderSize = 0
    End Sub

    'initialising timer
    Public Sub New()
        InitializeComponent()
        Timer1.Interval = 1
        Timer1.Start()
    End Sub
    'Function for setting the positions of the 3 pictures in slideshow according to count
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
    'starting slideshow of a picture with each tick of the timer
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
    'Function for slideshow of slides of button
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        If togglUP = True Or togglBok = True Or togglMB = True Then
            steps = 20                          'number of increments in each step
        Else
            steps = -20                         'number of decrements in each step
        End If
        If mybookings = True Then
            If (GroupBox1.Left < 0 And togglBok = True) Or (GroupBox1.Left > -GroupBox1.Width And togglBok = False) Then            'Moving the slides forward if toggle is true and it is slightly hidden 
                GroupBox1.Left += steps                                                                                             'Or moves the slide backwards till it's hidden width is less than actual width
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
        Timer2.Start()                                                                  'starting of timer
    End Sub
    'Opening the check availiblity form when user wants to book a room
    Private Sub btnBookARoom_Click(sender As Object, e As EventArgs) Handles btnBookARoom.Click
        Check_Availability.loggedUser = loggedUser
        Check_Availability.BringToFront()
        Check_Availability.Show()
    End Sub
    'showing slide of my bookings on clicking of the button
    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles btnMyBookings.Click
        frminit()
        btnclicks()
        togglUP = False
        togglMB = False
        myboksize()
        togglBok = Not (togglBok)
        mybookings = True
        getCurrBookingData()
        GroupBox1.Visible = True
        Timer2.Start()
    End Sub
    'showing slide of my bills on clicking of the button
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