Imports System.Runtime.InteropServices
Public Class UserControl_dynamiccontrol

    <DllImport("user32.dll", EntryPoint:="SetProcessDPIAware")> _
    Private Shared Function SetProcessDPIAware() As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function


    Dim CW As Integer ' Current Width
    Dim CH As Integer  ' Current Height
    Dim RW As Double  ' Ratio change of width
    Dim RH As Double  ' Ratio change of height
    Dim min As Double
    Private Sub max()
        CW = Me.Width ' Current Width
        CH = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1080)
        RW = (Me.Width - CW) / CW ' Ratio change of width
        RH = (Me.Height - CH) / CH ' Ratio change of height
        min = RW
        If RW > RH Then
            min = RH
        End If
        'adjusting all controls
        For Each Ctrl As Control In Controls
            'Console.WriteLine(Ctrl.Width & " " & RW)
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            If TypeOf Ctrl Is TextBox Then
                Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * min), Ctrl.Font.Style)
            End If
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    'function to change timestamp to date
    Public Function createDateTimeStamp(currDate As Date) As Integer
        Return CInt(currDate.ToString("yyyyMMdd"))
    End Function

    'array to store data of rooms
    Dim allRooms(-1) As String
    Dim nonAvailRooms(-1) As String
    Dim availRooms(-1) As String

    'funtion to fill data in arrays declared just above 
    Public Function getData()
        BookingTableAdapter1.fillNonAvailRooms(GuestHouseDataSet1.Booking, Check_Availability.createDateTimeStamp(Date.Now), Check_Availability.createDateTimeStamp(Date.Now), Check_Availability.createDateTimeStamp(Date.Now), Check_Availability.createDateTimeStamp(Date.Now))
        RoomTableAdapter1.Fill(GuestHouseDataSet1.Room)
        ReDim allRooms(-1)
        ReDim nonAvailRooms(-1)
        ReDim availRooms(-1)
        For Each row As guestHouseDataSet.BookingRow In GuestHouseDataSet1.Booking
            nonAvailRooms = nonAvailRooms.Concat({row.RoomNo}).ToArray
        Next

        For Each row As guestHouseDataSet.RoomRow In GuestHouseDataSet1.Room
            allRooms = allRooms.Concat({row.RoomNo}).ToArray
        Next

        For Each room As String In allRooms
            If Not nonAvailRooms.Contains(room) Then
                availRooms = availRooms.Concat({room}).ToArray
            End If
        Next
    End Function

    'function fir approve button
    Private Function loadApproveButtons()
        length = GuestHouseDataSet1.userTable.Rows.Count
        Dim n As Integer = 0
        'declaring arrays of necessary controls
        Dim cancel(length - 1) As System.Windows.Forms.Button
        Dim Confirm(length - 1) As System.Windows.Forms.Button
        Dim EmailID(length - 1) As System.Windows.Forms.GroupBox
        Dim Category(length - 1) As System.Windows.Forms.Label
        Dim Name(length - 1) As System.Windows.Forms.Label
        Dim Mobile(length - 1) As System.Windows.Forms.Label

        For i As Integer = 0 To length - 1   ' making the button array and initialising it
            cancel(i) = New System.Windows.Forms.Button
            Confirm(i) = New System.Windows.Forms.Button
            EmailID(i) = New System.Windows.Forms.GroupBox
            Category(i) = New System.Windows.Forms.Label
            Name(i) = New System.Windows.Forms.Label
            Mobile(i) = New System.Windows.Forms.Label
        Next i

        Dim xPos As Integer = 0  ' these two lines set the location for making the button array
        Dim yPos As Integer = 0
        While (n < length)
            With (EmailID(n))
                .Width = 1024 ' Width of button
                .Height = 250 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Email:   " & GuestHouseDataSet1.userTable.Rows(n)("username").ToString
                .BackColor = System.Drawing.Color.PaleTurquoise
                .Font = New Font(EmailID(n).Font.Name, CInt(13), EmailID(n).Font.Style)
                .BackColor = System.Drawing.Color.PaleTurquoise
                Me.Controls.Add(EmailID(n))
                xPos = xPos + 2 ' Left of next button
                yPos = 50
            End With
            With (Name(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Name:    " & GuestHouseDataSet1.userTable.Rows(n)("First Name").ToString & " " & GuestHouseDataSet1.userTable.Rows(n)("Last Name").ToString
                .Font = New Font(Name(n).Font.Name, CInt(13), Name(n).Font.Style)
                EmailID(n).Controls.Add(Name(n))
                yPos = yPos + .Height ' Left of next button
            End With
            With (Mobile(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Mobile No:   " & GuestHouseDataSet1.userTable.Rows(n)("MobileNo").ToString
                .Font = New Font(Mobile(n).Font.Name, CInt(13), Mobile(n).Font.Style)
                EmailID(n).Controls.Add(Mobile(n))
                xPos = xPos + 700 ' Left of next button
            End With
            With (Confirm(n))
                .Width = 150 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Confirm"
                .Font = New Font(Confirm(n).Font.Name, CInt(13), Confirm(n).Font.Style)
                .Tag = n
                .BackColor = System.Drawing.Color.LightGreen
                EmailID(n).Controls.Add(Confirm(n))
                yPos = yPos + 50 ' Left of next button
            End With
            AddHandler Confirm(n).Click, AddressOf confirmbutton_click
            With (cancel(n))
                .Width = 150 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Cancel"
                .Font = New Font(cancel(n).Font.Name, CInt(13), cancel(n).Font.Style)
                .Tag = n
                .BackColor = System.Drawing.Color.Tomato
                EmailID(n).Controls.Add(cancel(n))
                xPos = 2 ' Left of next button
            End With
            AddHandler cancel(n).Click, AddressOf cancelbutton_click
            With (Category(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Category:   " & GuestHouseDataSet1.userTable.Rows(n)("Category").ToString
                .Font = New Font(cancel(n).Font.Name, CInt(13), cancel(n).Font.Style)
                Name(n).Controls.Add(Mobile(n))
                yPos = (50 + EmailID(n).Height) * (n + 1) 'Left of next button
                n += 1
            End With
        End While
    End Function

    Private Function loadBookingButtons()
        length = GuestHouseDataSet1.Booking.Rows.Count
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
                .Width = 1024 ' Width of button
                .Height = 250 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booking ID:   " & GuestHouseDataSet1.Booking.Rows(n)("BookingID").ToString
                .Font = New Font(BookingID(n).Font.Name, CInt(13), BookingID(n).Font.Style)
                .BackColor = System.Drawing.Color.PaleTurquoise
                Me.Controls.Add(BookingID(n))
                xPos = xPos + 2 ' Left of next button
                yPos = 50
            End With
            With (BookedBy(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booked By:   " & GuestHouseDataSet1.Booking.Rows(n)("BookedBy").ToString
                .Font = New Font(BookedBy(n).Font.Name, CInt(13), BookedBy(n).Font.Style)
                yPos = yPos + .Height ' Left of next button
                BookingID(n).Controls.Add(BookedBy(n))
            End With
            With (RoomNo(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Room No:    " & GuestHouseDataSet1.Booking.Rows(n)("RoomNo").ToString
                .Font = New Font(RoomNo(n).Font.Name, CInt(13), RoomNo(n).Font.Style)
                BookingID(n).Controls.Add(RoomNo(n))
                xPos = xPos + 700 ' Left of next button
            End With
            With (Confirm(n))
                .Width = 150 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Confirm"
                .Tag = n
                .Font = New Font(Confirm(n).Font.Name, CInt(13), Confirm(n).Font.Style)
                .BackColor = System.Drawing.Color.MediumTurquoise
                BookingID(n).Controls.Add(Confirm(n))
                yPos = yPos + 50 ' Left of next button
            End With
            AddHandler Confirm(n).Click, AddressOf confirmbutton_click
            With (cancel(n))
                .Width = 150 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Cancel"
                .Tag = n
                .Font = New Font(cancel(n).Font.Name, CInt(13), cancel(n).Font.Style)
                .BackColor = System.Drawing.Color.MediumTurquoise
                BookingID(n).Controls.Add(cancel(n))
                xPos = 2 ' Left of next button
            End With
            AddHandler cancel(n).Click, AddressOf cancelbutton_click
            With (BookedFrom(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booked From:   " & DateTime.ParseExact((GuestHouseDataSet1.Booking.Rows(n)("BookedFrom").ToString), "yyyyMMdd", Nothing)
                .Font = New Font(BookedFrom(n).Font.Name, CInt(13), BookedFrom(n).Font.Style)
                BookingID(n).Controls.Add(BookedFrom(n))
                yPos = yPos + .Height ' Left of next button
            End With
            With (BookedTill(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booked Till:   " & DateTime.ParseExact((GuestHouseDataSet1.Booking.Rows(n)("BookedTill").ToString), "yyyyMMdd", Nothing)
                .Font = New Font(BookedTill(n).Font.Name, CInt(13), BookedTill(n).Font.Style)
                BookingID(n).Controls.Add(BookedTill(n))
                yPos = (50 + BookingID(n).Height) * (n + 1) 'Left of next button
                n += 1
            End With
        End While
    End Function

    Private Function loadAllBookings()
        length = GuestHouseDataSet1.Booking.Rows.Count
        Dim n As Integer = 0
        Dim BookingTill(length - 1) As System.Windows.Forms.Label
        Dim BookingFrom(length - 1) As System.Windows.Forms.Label
        Dim RoomNum(length - 1) As System.Windows.Forms.Label
        Dim BookingID(length - 1) As System.Windows.Forms.GroupBox
        Dim Name(length - 1) As System.Windows.Forms.Label

        For i As Integer = 0 To length - 1   ' making the button array and initialising it
            BookingTill(i) = New System.Windows.Forms.Label
            BookingFrom(i) = New System.Windows.Forms.Label
            BookingID(i) = New System.Windows.Forms.GroupBox
            Name(i) = New System.Windows.Forms.Label
            RoomNum(i) = New System.Windows.Forms.Label
        Next i

        Dim xPos As Integer = 0  ' these two lines set the location for making the button array
        Dim yPos As Integer = 0
        While (n < length)
            With (BookingID(n))
                .Width = 1024 ' Width of button
                .Height = 250 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Booking ID   " & GuestHouseDataSet1.Booking.Rows(n)("BookingID").ToString
                .Font = New Font("Microsoft Tai Le", CInt(13))
                .BackColor = System.Drawing.Color.PaleTurquoise
                .Padding = New Padding(5, 10, 5, 0)
                Me.Controls.Add(BookingID(n))
                xPos = xPos + 2 ' Left of next button
                yPos = 50
            End With
            With (Name(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "Name:    " & GuestHouseDataSet1.Booking.Rows(n)("BookingForFirstName").ToString & " " & GuestHouseDataSet1.Booking.Rows(n)("BookingForLastName").ToString
                .Font = New Font(Name(n).Font.Name, CInt(13), Name(n).Font.Style)
                BookingID(n).Controls.Add(Name(n))
                .Padding = New Padding(25, 0, 0, 0)
                 yPos = yPos + .Height ' Left of next button
            End With
            With (RoomNum(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Text = "RoomNum:   " & GuestHouseDataSet1.Booking.Rows(n)("RoomNo")
                .Font = New Font(RoomNum(n).Font.Name, CInt(13), RoomNum(n).Font.Style)
                BookingID(n).Controls.Add(RoomNum(n))
                .Padding = New Padding(25, 0, 0, 0)
                yPos = yPos + .Height ' adjust positioning of next control
            End With
            With (BookingFrom(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Padding = New Padding(25, 0, 0, 0)
                .Text = "Booked From:     " & DateTime.ParseExact((GuestHouseDataSet1.Booking.Rows(n)("BookedFrom").ToString), "yyyyMMdd", Nothing)
                .Font = New Font(BookingFrom(n).Font.Name, CInt(13), BookingFrom(n).Font.Style)
                BookingID(n).Controls.Add(BookingFrom(n)) 'add control to its parent
                yPos = yPos + .Height 'adjust positioning of  next control
            End With
            With (BookingTill(n))
                .Width = 500 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .Padding = New Padding(25, 0, 0, 0)
                .Text = "Booked Till:        " & DateTime.ParseExact((GuestHouseDataSet1.Booking.Rows(n)("BookedTill").ToString), "yyyyMMdd", Nothing)
                .Font = New Font(BookingTill(n).Font.Name, CInt(13), BookingTill(n).Font.Style)
                BookingID(n).Controls.Add(BookingTill(n))
                yPos = (50 + BookingID(n).Height) * (n + 1)  ' Next Y will be far ' 
                n += 1
            End With
        End While
    End Function

    Private Function loadRoomStatus()
        length = allRooms.Length
        'Console.WriteLine(length & " number of rooms available")
        Dim n As Integer = 0
        Dim RoomNo(length - 1) As System.Windows.Forms.Label


        For i As Integer = 0 To length - 1   ' making the button array and initialising it
            RoomNo(i) = New System.Windows.Forms.Label
        Next i

        Dim xPos As Integer = 0  ' these two lines set the location for making the button array
        Dim yPos As Integer = 20

        While (n < length)

            With (RoomNo(n))
                .Width = 70 ' Width of button
                .Height = 50 ' Height of button
                .Top = yPos  ' y coordinate of button
                .Left = xPos  ' x coordinate of button
                .BackColor = Color.Azure
                .Text = allRooms(n)
                If availRooms.Contains(allRooms(n)) Then
                    .BackColor = Color.LimeGreen
                    .ForeColor = Color.White
                    .Font = New Font("Microsoft Sans Serif", CInt(15))
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                    Dim tt As New ToolTip
                    tt.SetToolTip(RoomNo(n), "This room is available")
                Else
                    .BackColor = Color.Firebrick
                    .ForeColor = Color.White
                    .Font = New Font("Microsoft Sans Serif", CInt(15))
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BorderStyle = Windows.Forms.BorderStyle.Fixed3D

                    Dim data As guestHouseDataSet.BookingRow
                    data = BookingTableAdapter1.GetTodayBooking(allRooms(n), createDateTimeStamp(Date.Now), createDateTimeStamp(Date.Now)).Rows(0)
                    'Console.WriteLine(table.Rows.Count & "Rows Returned Bitch for Room Number" & allRooms(n))
                    Dim tt As New ToolTip
                    Dim tooltipText As String = "Booking ID: " & data.BookingID & vbNewLine & "Name: " & data.BookingForFirstName & " " & data.BookingForLastName & vbNewLine
                    tt.SetToolTip(RoomNo(n), tooltipText)
                End If
                If (n + 1) Mod 5 = 0 Then
                    yPos += .Height + 20 ' Next Y will be far 
                    xPos = 0
                Else
                    xPos += .Width + 20
                End If

                Me.Controls.Add(RoomNo(n))
                n += 1
            End With
        End While
    End Function
    Dim length As Integer

    Public Sub UserControl_dynamiccontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Clear()
        InitializeComponent()
        max()
        BookingTableAdapter1.FillByPendingBookings(GuestHouseDataSet1.Booking)
        UserTableTableAdapter1.getNonApproved(GuestHouseDataSet1.userTable)
        'Console.Write(length.ToString)
        If AdminDashboard.pendingbooking = 1 Then
            BookingTableAdapter1.FillByPendingBookings(GuestHouseDataSet1.Booking)
            loadBookingButtons()
        ElseIf AdminDashboard.approveuser = 1 Then
            loadApproveButtons()
        ElseIf AdminDashboard.allBooking = 1 Then
            BookingTableAdapter1.FillAllCurrent(GuestHouseDataSet1.Booking, createDateTimeStamp(Date.Now))
            loadAllBookings()
        ElseIf AdminDashboard.RoomStatus = 1 Then
            getData()
            loadRoomStatus()
        End If
    End Sub

    Private Sub confirmbutton_click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim str As String = btn.Tag
        If AdminDashboard.pendingbooking = 1 Then
            Dim row As guestHouseDataSet.BookingRow
            row = GuestHouseDataSet1.Booking.Rows(CInt(str))
            row.BookingConfirmed = True
            BookingTableAdapter1.Update(GuestHouseDataSet1.Booking)
        ElseIf AdminDashboard.approveuser = 1 Then
            Dim row As guestHouseDataSet.userTableRow
            row = GuestHouseDataSet1.userTable.Rows(CInt(str))
            row.isApproved = True
            UserTableTableAdapter1.Update(GuestHouseDataSet1.userTable)
            AdminDashboard.reload_data()
        End If
        Me.Controls.Clear()
        InitializeComponent()
        UserControl_dynamiccontrol_Load(e, e)
    End Sub

    Private Sub cancelbutton_click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim str As String = btn.Tag
        If AdminDashboard.pendingbooking = 1 Then
            GuestHouseDataSet1.Booking.Rows(CInt(str)).Delete()
            BookingTableAdapter1.Update(GuestHouseDataSet1.Booking)
        ElseIf AdminDashboard.approveuser = 1 Then
            GuestHouseDataSet1.userTable.Rows(CInt(str)).Delete()
            UserTableTableAdapter1.Update(GuestHouseDataSet1.userTable)
            AdminDashboard.reload_data()
        End If
        Me.Controls.Clear()
        InitializeComponent()
        UserControl_dynamiccontrol_Load(e, e)
    End Sub
End Class
