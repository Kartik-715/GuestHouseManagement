Imports System.Runtime.InteropServices
Public Class UserControl_dynamiccontrol

    <DllImport("user32.dll", EntryPoint:="SetProcessDPIAware")> _
    Public Shared Function SetProcessDPIAware() As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Dim length As Integer
    Private Sub UserControl_dynamiccontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetProcessDPIAware()
        BookingTableAdapter1.FillByPendingBookings(GuestHouseDataSet1.Booking)
        length = GuestHouseDataSet1.Booking.Rows.Count
        Me.Top = AdminDashboard.btnPendingBookings.Top
        Me.Left = AdminDashboard.btnPendingBookings.Right + 10
        Console.Write(length.ToString)
        Dim n As Integer = 0
        Dim BookingID(length - 1) As System.Windows.Forms.GroupBox
        Dim cancel(length - 1) As System.Windows.Forms.Button
        Dim Confirm(length - 1) As System.Windows.Forms.Button
        Dim RoomNo(length - 1) As System.Windows.Forms.Label
        Dim BookedFrom(length - 1) As System.Windows.Forms.Label
        Dim BookedBy(length - 1) As System.Windows.Forms.Label
        Dim BookedTill(length - 1) As System.Windows.Forms.Label

        For i As Integer = 0 To length - 1   ' making the button array and initialising it
            cancel(i) = New System.Windows.Forms.Button
            Confirm(i) = New System.Windows.Forms.Button
            BookingID(i) = New System.Windows.Forms.GroupBox
            RoomNo(i) = New System.Windows.Forms.Label
            BookedFrom(i) = New System.Windows.Forms.Label
            BookedBy(i) = New System.Windows.Forms.Label
            BookedTill(i) = New System.Windows.Forms.Label
        Next i

        Dim xPos As Integer = 0  ' these two lines set the location for making the button array
        Dim yPos As Integer = 0
        While (n < length)
            With (BookingID(n))
                .Width = 500 ' Width of button
                .Height = 250 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booking ID   " & GuestHouseDataSet1.Booking.Rows(n)("ID").ToString
                Me.Controls.Add(BookingID(n))
                xPos = xPos + 2 ' Left of next button
                yPos = 50
            End With
            With (RoomNo(n))
                .Width = 100 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Room No    " & GuestHouseDataSet1.Booking.Rows(n)("RoomNo").ToString
                BookingID(n).Controls.Add(RoomNo(n))
                yPos = yPos + .Height ' Left of next button
            End With
            With (BookedBy(n))
                .Width = 100 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booked By   " & GuestHouseDataSet1.Booking.Rows(n)("BookedBy").ToString
                BookingID(n).Controls.Add(BookedBy(n))
                xPos = xPos + 200 ' Left of next button
            End With
            With (Confirm(n))
                .Width = 100 ' Width of button
                .Height = 30 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Confirm"
                .Tag = n
                BookingID(n).Controls.Add(Confirm(n))
                yPos = yPos + 50 ' Left of next button
            End With
            AddHandler Confirm(n).Click, AddressOf confirmbutton_click
            With (cancel(n))
                .Width = 100 ' Width of button
                .Height = 30 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Cancel"
                .Tag = n
                BookingID(n).Controls.Add(cancel(n))
                xPos = 2 ' Left of next button
            End With
            AddHandler cancel(n).Click, AddressOf cancelbutton_click
            With (BookedFrom(n))
                .Width = 100 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booked From    " & DateTime.ParseExact((GuestHouseDataSet1.Booking.Rows(n)("BookedFrom").ToString), "yyyyMMdd", Nothing)
                BookingID(n).Controls.Add(BookedFrom(n))
                yPos = yPos + .Height ' Left of next button
            End With
            With (BookedTill(n))
                .Width = 100 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booked Till   " & DateTime.ParseExact((GuestHouseDataSet1.Booking.Rows(n)("BookedTill").ToString), "yyyyMMdd", Nothing)
                BookingID(n).Controls.Add(BookedTill(n))
                yPos = (50 + BookingID(n).Height) * (n + 1) 'Left of next button
                n += 1
            End With
        End While
    End Sub

    Private Sub confirmbutton_click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim str As String = btn.Tag
        Dim row As guestHouseDataSet.BookingRow
        row = GuestHouseDataSet1.Booking.Rows(CInt(str))
        row.BookingConfirmed = True
        BookingTableAdapter1.Update(GuestHouseDataSet1.Booking)
        Me.Controls.Clear()
        InitializeComponent()
        UserControl_dynamiccontrol_Load(e, e)
    End Sub

    Private Sub cancelbutton_click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim str As String = btn.Tag
        GuestHouseDataSet1.Booking.Rows(CInt(str)).Delete()
        BookingTableAdapter1.Update(GuestHouseDataSet1.Booking)
        Me.Controls.Clear()
        InitializeComponent()
        UserControl_dynamiccontrol_Load(e, e)
    End Sub
End Class
