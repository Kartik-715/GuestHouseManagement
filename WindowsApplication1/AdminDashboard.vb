Public Class AdminDashboard
    Public loggedUser As String
    Public approveuser As Integer
    Public bookroom As Integer
    Public pendingbooking As Integer
    Public allBooking As Integer
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
            'Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * min), Ctrl.Font.Style)
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
        max()
        Form1.Hide()
        UserControl_admindashboardnontabular1.Width = 800
        UserControl_admindashboardnontabular1.Height = 800
        UserControl_dynamiccontrol1.Width = Form1.Width - btnLogOut.Right - 250
        UserControl_dynamiccontrol1.Height = Form1.Height - btnLogOut.Top + 70
        UserControl_admindashboardnontabular1.Top = btnLogOut.Top
        UserControl_admindashboardnontabular1.Left = btnLogOut.Right + 46
        UserControl_dynamiccontrol1.Top = btnLogOut.Top + 56
        UserControl_dynamiccontrol1.Left = btnLogOut.Right + 200
        Me.WindowState = FormWindowState.Maximized
        lblHello.Text = "Hello! " & loggedUser
        reload_data()
        btnclicks()
    End Sub

    Public Sub reload_data()
        labelNonApproved.Text = "There are " & UserTableTableAdapter1.numNonApproved & " non Approved Users "
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

    Private Sub btnMyBills_Click(sender As Object, e As EventArgs) Handles btnMyBills.Click
        forminit()
        btnclicks()
    End Sub

    Private Sub btnAllBookings_Click(sender As Object, e As EventArgs) Handles btnAllBookings.Click
        forminit()
        btnclicks()
        allBooking = 1
        UserControl_dynamiccontrol1.UserControl_dynamiccontrol_Load(e, e)
        UserControl_dynamiccontrol1.Show()
    End Sub
End Class