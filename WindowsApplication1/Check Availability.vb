Imports System.Runtime.InteropServices
Public Class Check_Availability
    Dim count As Integer = 0
    Public loggedUser As String = "anonymous"

    <DllImport("user32.dll", EntryPoint:="SetProcessDPIAware")> _
    Public Shared Function SetProcessDPIAware() As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Public Function createDateTimeStamp(currDate As Date) As Integer
        Return CInt(currDate.ToString("yyyyMMdd"))
    End Function

    Public Function genBookingID(userData As guestHouseDataSet.userTableRow, Id As Integer) As String
        Dim BookingID As String = ""
        Dim prefix As String = ""

        ' Assigning the Prefix ' 
        If userData.Category = "Staff" Then
            prefix = "STA"
        ElseIf userData.Category = "Student" Then
            prefix = "STU"
        ElseIf userData.Category = "Guest" Then
            prefix = "GUE"
        ElseIf userData.Category = "Faculty" Then
            prefix = "FAC"
        End If

        BookingID = BookingID & prefix

        Dim randomData As String = ""
        ' Get Random Details of the Logged User ' 
        Dim randNum = CInt(Math.Ceiling(Rnd() * (userData.First_Name.Length - 1)))
        randomData = randomData & userData.First_Name(randNum).ToString.ToUpper
        randNum = CInt(Math.Ceiling(Rnd() * (userData.Last_Name.Length - 1)))
        randomData = randomData & userData.Last_Name(randNum).ToString.ToUpper
        randNum = CInt(Math.Ceiling(Rnd() * (userData.username.Length - 1)))
        randomData = randomData & userData.username(randNum).ToString.ToUpper

        BookingID = BookingID & randomData

        BookingID = BookingID & Id.ToString()

        Return BookingID

    End Function

    Dim CW As Integer ' Current Width
    Dim CH As Integer  ' Current Height
    Dim RW As Double  ' Ratio change of width
    Dim RH As Double  ' Ratio change of height
    Dim min As Double
    Private Sub max()
        CW = Me.Width ' Current Width
        CH = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1024)
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
            If TypeOf Ctrl Is Button Then
                Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * Form1.Width / 1920), Ctrl.Font.Style)
            End If
            If TypeOf Ctrl Is RadioButton Then
                Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * Form1.Width / 1920), Ctrl.Font.Style)
            End If
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Public Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If count = 0 Then
            SetProcessDPIAware()
            max()
            count = 1
        End If
        Me.Top = 100
        Me.Left = (Form1.Width - Me.Width) / 2
        lblWelcome.Parent = PictureBoxHeader
        DateTimePickerFrom.MinDate = Date.Today
        If loggedUser = "admin" Then
            rbtnIsVIP.Show()
        End If
    End Sub

    Private Sub btnCheckAval_Click(sender As Object, e As EventArgs) Handles btnCheckAval.Click
        lblWelcome.Parent = PictureBoxHeader
        ' Replace Time Stamp by Functions ' TO DOOOOO
        Dim timeFrom As Integer = createDateTimeStamp(DateTimePickerFrom.Value)
        Dim timeTo As Integer = createDateTimeStamp(DateTimePickerTo.Value)
        BookingTableAdapter1.fillNonAvailRooms(GuestHouseDataSet1.Booking, timeFrom, timeFrom, timeTo, timeTo)
        RoomTableAdapter1.Fill(GuestHouseDataSet1.Room)

        Dim allRooms(-1) As String
        Dim nonAvailRooms(-1) As String
        Dim availRooms(-1) As String
        comboBoxAvailRooms.Items.Clear()


        For Each row As guestHouseDataSet.BookingRow In GuestHouseDataSet1.Booking
            nonAvailRooms = nonAvailRooms.Concat({row.RoomNo}).ToArray
        Next

        For Each row As guestHouseDataSet.RoomRow In GuestHouseDataSet1.Room
            If rbtnIsVIP.Checked Then
                If row.isVIP Then
                    allRooms = allRooms.Concat({row.RoomNo}).ToArray
                End If
            Else
                allRooms = allRooms.Concat({row.RoomNo}).ToArray
            End If
        Next

        For Each room As String In allRooms
            If Not nonAvailRooms.Contains(room) Then
                availRooms = availRooms.Concat({room}).ToArray
            End If
        Next

        lblnumAvail.Text = CStr(availRooms.Length)
        lblnumAvail.Show()

        If availRooms.Length >= 1 Then
            Me.Height = 700 * Form1.Height / 1024
            Me.StartPosition = FormStartPosition.CenterScreen
            lblFirstName.Show()
            lblLastName.Show()
            lblMobileNo.Show()
            txtPhone.Show()
            txtLastName.Show()
            txtName.Show()
            comboBoxAvailRooms.Items.AddRange(availRooms)
            comboBoxAvailRooms.Show()
            btnBookNow.Show()
            lblSelectRoom.Show()
        Else
            comboBoxAvailRooms.Hide()
            btnBookNow.Hide()
        End If
    End Sub

    Public Sub reloadForm()
        For Each ctrl In Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.text = ""
            End If
        Next
        lblWelcome.Parent = PictureBoxHeader
        Me.Show()
    End Sub

    Public Function calculateBill(type As String, occupancy As Integer) As Integer
        lblWelcome.Parent = PictureBoxHeader
        Dim initialBill As Integer = 0
        Dim RoomChargesSingle() As Integer = {500, 900, 1500, 3000}
        Dim RoomChargesDouble() As Integer = {700, 1100, 1700, 3500}
        Dim noOfDays As Integer = (createDateTimeStamp(DateTimePickerTo.Value) - createDateTimeStamp(DateTimePickerFrom.Value)) + 1
        If loggedUser = "admin" Then
            initialBill = 0
        ElseIf type = "Staff" Then
            If occupancy = 1 Then
                initialBill = noOfDays * RoomChargesSingle(3)
            Else
                initialBill = noOfDays * RoomChargesDouble(3)
            End If
        Else
            If type = "Student" Then
                If occupancy = 1 Then
                    initialBill = Math.Min(noOfDays, 3) * RoomChargesSingle(1) + Math.Max(0, (noOfDays - 3)) * RoomChargesSingle(2)
                Else
                    initialBill = Math.Min(noOfDays, 3) * RoomChargesDouble(1) + Math.Max(0, (noOfDays - 3)) * RoomChargesDouble(2)
                End If
            ElseIf type = "Faculty" Then
                If occupancy = 1 Then
                    initialBill = noOfDays * RoomChargesSingle(2)
                Else
                    initialBill = noOfDays * RoomChargesDouble(2)
                End If
            Else
                If occupancy = 1 Then
                    initialBill = noOfDays * RoomChargesSingle(0)
                Else
                    initialBill = noOfDays * RoomChargesDouble(0)
                End If
            End If
        End If

        Return initialBill

    End Function

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        lblWelcome.Parent = PictureBoxHeader
        If loggedUser = "anonymous" Then
            MessageBox.Show("You need to login first!")
            Me.Hide()
            LoginForm1.Show()
        Else
            If comboBoxAvailRooms.Text = Nothing Or (Not comboBoxAvailRooms.Items.Contains(comboBoxAvailRooms.Text)) Then
                MsgBox("Please Select A Room!")
            Else
                Dim Table As guestHouseDataSet.userTableDataTable
                Table = UserTableTableAdapter1.GetUserData(loggedUser)
                Dim user As guestHouseDataSet.userTableRow
                user = Table.Rows(0)

                Dim Occpancy As Integer = 1
                If rbtnSingle.Checked = True Then
                    Occpancy = 1
                Else
                    Occpancy = 2
                End If

                Dim initialBill As Integer = 0
                initialBill = calculateBill(user.Category, Occpancy)
                If loggedUser = "admin" Or user.Category = "Staff" Then
                    BookingTableAdapter1.BookRoom(comboBoxAvailRooms.Text, loggedUser, createDateTimeStamp(DateTimePickerFrom.Value), createDateTimeStamp(DateTimePickerTo.Value), txtName.Text, txtLastName.Text, txtPhone.Text, True, initialBill, Occpancy)
                    ' Room Booked ' 
                    Dim lastAdded As Integer = BookingTableAdapter1.getLatestID()
                    Dim bookingID As String = genBookingID(user, lastAdded)
                    BookingTableAdapter1.updateBookingID(bookingID, lastAdded)
                    MsgBox("Room: " & comboBoxAvailRooms.Text & " Booked Successfully!")
                    Booking_Load(e, e)
                Else
                    If BookingTableAdapter1.GetCurrentBooking(createDateTimeStamp(Date.Now), loggedUser).Rows.Count > 0 Then
                        MsgBox("You Have Already Booked A Room!")
                    Else
                        BookingTableAdapter1.BookRoom(comboBoxAvailRooms.Text, loggedUser, createDateTimeStamp(DateTimePickerFrom.Value), createDateTimeStamp(DateTimePickerTo.Value), txtName.Text, txtLastName.Text, txtPhone.Text, False, initialBill, Occpancy)
                        Dim lastAdded As Integer = BookingTableAdapter1.getLatestID()
                        Dim bookingID As String = genBookingID(user, lastAdded)
                        BookingTableAdapter1.updateBookingID(bookingID, lastAdded)
                        MsgBox("Room: " & comboBoxAvailRooms.Text & " Booked Successfully!")
                        Booking_Load(e, e)
                    End If
                End If
                reloadForm()
            End If
        End If

    End Sub

    Private Sub DateTimePickerFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFrom.ValueChanged
        DateTimePickerTo.MinDate = DateTimePickerFrom.Value
    End Sub

    Private Sub DateTimePickerTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePickerTo.KeyPress
        DateTimePickerTo.MinDate = DateTimePickerFrom.Value
    End Sub

    Private Sub DateTimePickerTo_DropDown(sender As Object, e As EventArgs) Handles DateTimePickerTo.DropDown
        DateTimePickerTo.MinDate = DateTimePickerFrom.Value
    End Sub

    Private Sub DateTimePickerFrom_DropDown(sender As Object, e As EventArgs) Handles DateTimePickerFrom.DropDown
        DateTimePickerTo.MinDate = DateTimePickerFrom.Value
    End Sub

End Class