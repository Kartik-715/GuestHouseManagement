Public Class AdminDashboard
    Public loggedUser As String
    Public approveuser As Integer
    Public bookroom As Integer
    Public pendingbooking As Integer
    Public allBooking As Integer
    Public RoomStatus As Integer
    Public addremoveroom As Integer
    Public updatepassword As Integer
   Dim check As Integer = 0

    Public Sub forminit()
        approveuser = 0
        bookroom = 0
        addremoveroom = 0
        pendingbooking = 0
        updatepassword = 0
        allBooking = 0
        RoomStatus = 0
    End Sub

    Private Sub btnclicks()
        With UserControl_admindashboardnontabular1
            .Hide()
            .GroupBox1.Hide()
            .GroupBox2.Hide()
        End With
        With UserControl_dynamiccontrol1
            .Hide()
        End With
        Check_Availability.Close()
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
                Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * Form1.Width / 1920), Ctrl.Font.Style)
            End If
            If TypeOf Ctrl Is Label Then
                Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * Form1.Width / 1920), Ctrl.Font.Style)
            End If
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub AdminDashboard_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
    End Sub

    Private Sub AdminDashboard_closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        If check = 1 Then
            Form1.Show()
        Else
            Form1.Close()
        End If
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuestHouseDataSet.Booking' table. You can move, or remove it, as needed.
        Form1.SetProcessDPIAware()
        Me.BookingTableAdapter.Fill(Me.GuestHouseDataSet.Booking)
        BookingTableAdapter.FillByPendingBookings(GuestHouseDataSet1.Booking)
        max()
        Form1.Hide()
        If loggedUser = "admin" Then
            btnAddRoom.Visible = True
            btnApproveUsers.Visible = True
            btnPendingBookings.Visible = True
        End If
        UserControl_admindashboardnontabular1.Width = 800 * (Form1.Width / 1920)
        UserControl_admindashboardnontabular1.Height = 800 * (Form1.Height / 1024)
        UserControl_dynamiccontrol1.Width = Form1.Width - btnLogOut.Right - 250
        UserControl_dynamiccontrol1.Height = Form1.Height - btnLogOut.Top + 70
        UserControl_admindashboardnontabular1.Top = btnLogOut.Top
        UserControl_admindashboardnontabular1.Left = btnLogOut.Right + 46
        UserControl_dynamiccontrol1.Top = btnLogOut.Top + 56
        UserControl_dynamiccontrol1.Left = btnLogOut.Right + 200
        Me.WindowState = FormWindowState.Maximized
        lblHello.Parent = PictureBoxHeader
        lblHello.Text = "Hello! " & loggedUser
        reload_data()
        btnclicks()
        btnLogOut.Parent = PictureBoxGrey
        btnAllBookings.Parent = PictureBoxGrey
        btnBookARoom.Parent = PictureBoxGrey
        btnRoomStatus.Parent = PictureBoxGrey
        btnUpdatePassword.Parent = PictureBoxGrey
        btnAddRoom.Parent = PictureBoxGrey
        btnApproveUsers.Parent = PictureBoxGrey
        btnPendingBookings.Parent = PictureBoxGrey
        PictureBoxLogo.Parent = PictureBoxGrey
        lblWelcome.Parent = PictureBoxHeader
        lblHello.Parent = PictureBoxHeader
    End Sub

    Public Sub reload_data()
        labelNonApproved.Text = "There are " & UserTableTableAdapter1.numNonApproved & " non Approved Users "
        lblPendingBooking.Text = "There are " & GuestHouseDataSet1.Booking.Rows.Count & " Pending Booking "
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        forminit()
        btnclicks()
        updatepassword = 1
        UserControl_admindashboardnontabular1.btnSaveChanges.Visible = False
        UserControl_admindashboardnontabular1.Show()
        UserControl_admindashboardnontabular1.GroupBox2.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        check = 1
        Me.Close()
    End Sub

    Private Sub btnApproveUsers_Click(sender As Object, e As EventArgs) Handles btnApproveUsers.Click
        forminit()
        btnclicks()
        approveuser = 1
        UserControl_dynamiccontrol1.UserControl_dynamiccontrol_Load(e, e)
        UserControl_dynamiccontrol1.Show()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        forminit()
        btnclicks()
        addremoveroom = 1
        UserControl_admindashboardnontabular1.btnSaveChanges.Visible = True
        UserControl_admindashboardnontabular1.Show()
        UserControl_admindashboardnontabular1.GroupBox1.Show()
    End Sub

    Private Sub btnBookARoom_Click(sender As Object, e As EventArgs) Handles btnBookARoom.Click
        forminit()
        btnclicks()
        Check_Availability.loggedUser = loggedUser
        Check_Availability.Show()
    End Sub

    Private Sub btnPendingBookings_Click(sender As Object, e As EventArgs) Handles btnPendingBookings.Click
        forminit()
        btnclicks()
        pendingbooking = 1
        UserControl_dynamiccontrol1.UserControl_dynamiccontrol_Load(e, e)
        UserControl_dynamiccontrol1.Show()
    End Sub

    Private Sub btnRoomStatus_Click(sender As Object, e As EventArgs) Handles btnRoomStatus.Click
        forminit()
        btnclicks()
        RoomStatus = 1
        UserControl_dynamiccontrol1.UserControl_dynamiccontrol_Load(e, e)
        UserControl_dynamiccontrol1.Show()
    End Sub

    Private Sub btnAllBookings_Click(sender As Object, e As EventArgs) Handles btnAllBookings.Click
        forminit()
        btnclicks()
        allBooking = 1
        UserControl_dynamiccontrol1.UserControl_dynamiccontrol_Load(e, e)
        UserControl_dynamiccontrol1.Show()
    End Sub

    Private Sub UserControl_dynamiccontrol1_Load(sender As Object, e As EventArgs) Handles UserControl_dynamiccontrol1.Load

    End Sub

    Private Sub btnLogout_MouseDown(sender As Object, e As EventArgs) Handles btnLogOut.MouseHover
        btnLogOut.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnLogout_MouseOver(sender As Object, e As EventArgs) Handles btnLogOut.MouseLeave
        btnLogOut.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnAllBookings_MouseDown(sender As Object, e As EventArgs) Handles btnAllBookings.MouseHover
        btnAllBookings.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnAllBookings_MouseOver(sender As Object, e As EventArgs) Handles btnAllBookings.MouseLeave
        btnAllBookings.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnPendingBookings_MouseDown(sender As Object, e As EventArgs) Handles btnPendingBookings.MouseHover
        btnPendingBookings.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnPendingBookings_MouseOver(sender As Object, e As EventArgs) Handles btnPendingBookings.MouseLeave
        btnPendingBookings.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnAddRoom_MouseDown(sender As Object, e As EventArgs) Handles btnAddRoom.MouseHover
        btnAddRoom.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnAddRoom_MouseOver(sender As Object, e As EventArgs) Handles btnAddRoom.MouseLeave
        btnAddRoom.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnApproveUsers_MouseDown(sender As Object, e As EventArgs) Handles btnApproveUsers.MouseHover
        btnApproveUsers.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnApproveUsers_MouseOver(sender As Object, e As EventArgs) Handles btnApproveUsers.MouseLeave
        btnApproveUsers.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnUpdatePassword_MouseDown(sender As Object, e As EventArgs) Handles btnUpdatePassword.MouseHover
        btnUpdatePassword.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnUpdatePassword_MouseOver(sender As Object, e As EventArgs) Handles btnUpdatePassword.MouseLeave
        btnUpdatePassword.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnMyBills_MouseDown(sender As Object, e As EventArgs) Handles btnRoomStatus.MouseHover
        btnRoomStatus.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnMyBills_MouseOver(sender As Object, e As EventArgs) Handles btnRoomStatus.MouseLeave
        btnRoomStatus.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub btnBookARoom_MouseDown(sender As Object, e As EventArgs) Handles btnBookARoom.MouseHover
        btnBookARoom.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnBookARoom_MouseOver(sender As Object, e As EventArgs) Handles btnBookARoom.MouseLeave
        btnBookARoom.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPendingBooking.Click

    End Sub
End Class