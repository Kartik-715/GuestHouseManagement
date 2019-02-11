Public Class Check_Availability
    Public loggedUser As String = "anonymous"

    Public Function createDateTimeStamp(currDate As Date) As Integer
        Return CInt(currDate.ToString("yyyyMMdd"))
    End Function

    Private Sub max()
        Dim CW As Integer = Me.Width ' Current Width
        Dim CH As Integer = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1080)
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

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        lblWelcome.Parent = PictureBoxHeader
        DateTimePickerFrom.MinDate = Date.Today
        If loggedUser = "admin" Then
            rbtnIsVIP.Show()
        End If
    End Sub

    Private Sub btnCheckAval_Click(sender As Object, e As EventArgs) Handles btnCheckAval.Click

        ' Replace Time Stamp by Functions ' TO DOOOOO
        Dim timeFrom As Integer = CInt(DateTimePickerFrom.Value.ToString("yyyyMMdd"))
        Dim timeTo As Integer = CInt(DateTimePickerTo.Value.ToString("yyyyMMdd"))
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
        Controls.Clear()
        InitializeComponent()
        Show()
    End Sub

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
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
                If loggedUser = "admin" Or user.Category = "Staff" Then
                    BookingTableAdapter1.BookRoom(comboBoxAvailRooms.Text, loggedUser, CInt(DateTimePickerFrom.Value.ToString("yyyyMMdd")), CInt(DateTimePickerTo.Value.ToString("yyyyMMdd")), txtName.Text, txtLastName.Text, txtPhone.Text, True)
                    MsgBox("Room: " & comboBoxAvailRooms.Text & " Booked Successfully!")
                Else
                    If BookingTableAdapter1.GetCurrentBooking(createDateTimeStamp(Date.Now), loggedUser).Rows.Count > 0 Then
                        MsgBox("You Have Already Booked A Room!")
                    Else
                        BookingTableAdapter1.BookRoom(comboBoxAvailRooms.Text, loggedUser, CInt(DateTimePickerFrom.Value.ToString("yyyyMMdd")), CInt(DateTimePickerTo.Value.ToString("yyyyMMdd")), txtName.Text, txtLastName.Text, txtPhone.Text, False)
                        MsgBox("Room: " & comboBoxAvailRooms.Text & " Booked Successfully!")
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