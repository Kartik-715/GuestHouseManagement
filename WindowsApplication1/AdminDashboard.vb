﻿Public Class AdminDashboard
    Public loggedUser As String
    Public approveuser As Integer
    Public bookroom As Integer
    Public addremoveroom As Integer
    Dim check As Integer = 0

    Public Sub forminit()
        approveuser = 0
        bookroom = 0
        addremoveroom = 0
    End Sub

    Private Sub btnclicks()
        With UserControl_admindashboard1
            .GroupBox1.Hide()
            .DataGridView1.Hide()
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
            'Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * RW), Ctrl.Font.Style)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub AdminDashboard_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If check = 1 Then
            Form1.Show()
        Else
            Form1.Close()
        End If
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuestHouseDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.GuestHouseDataSet.Booking)
        max()
        Form1.Hide()
        Me.WindowState = FormWindowState.Maximized
        btnApproveUsers.Parent = PictureBoxSidebar
        btnAddRoom.Parent = PictureBoxSidebar
        btnBookARoom.Parent = PictureBoxSidebar
        btnConfirmBookings.Parent = PictureBoxSidebar
        PictureBox1.Parent = PictureBoxSidebar
        btnLogOut.Parent = PictureBoxSidebar
        btnMyBills.Parent = PictureBoxSidebar
        btnUpdatePassword.Parent = PictureBoxSidebar
        btnPendingBookings.Parent = PictureBoxSidebar
        lblWelcome.Parent = PictureBoxHeader
        lblHello.Text = "Hello! " & loggedUser
        reload_data()
    End Sub

    Public Sub reload_data()
        labelNonApproved.Text = "There are " & UserTableTableAdapter1.numNonApproved & " non Approved Users "
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        formUpdatePassword.loggedUser = loggedUser
        formUpdatePassword.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        check = 1
        Me.Close()
    End Sub

    Private Sub btnApproveUsers_Click(sender As Object, e As EventArgs) Handles btnApproveUsers.Click
        btnclicks()
        UserControl_admindashboard1.DataGridView1.Show()
        UserControl_admindashboard1.GroupBox2.Hide()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        btnclicks()
        UserControl_admindashboard1.GroupBox1.Show()
        UserControl_admindashboard1.GroupBox2.Hide()
    End Sub

    Private Sub btnBookARoom_Click(sender As Object, e As EventArgs) Handles btnBookARoom.Click
        Check_Availability.loggedUser = loggedUser
        Check_Availability.Show()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BookingTableAdapter.FillBy(Me.GuestHouseDataSet.Booking)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnPendingBookings_Click(sender As Object, e As EventArgs) Handles btnPendingBookings.Click
        DataGridPendingBookings.Show()
        btnConfirmBookings.Show()
        Me.BookingTableAdapter.FillByPendingBookings(Me.GuestHouseDataSet.Booking)
    End Sub

    Private Sub btnConfirmBookings_Click(sender As Object, e As EventArgs) Handles btnConfirmBookings.Click
        Me.BookingTableAdapter.Update(GuestHouseDataSet.Booking)
        Me.BookingTableAdapter.FillByPendingBookings(Me.GuestHouseDataSet.Booking)
    End Sub

    Private Sub FillByPendingBookingsToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BookingTableAdapter.FillByPendingBookings(Me.GuestHouseDataSet.Booking)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByPendingBookingsToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.BookingTableAdapter.FillByPendingBookings(Me.GuestHouseDataSet.Booking)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class