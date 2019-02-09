Public Class Check_Availability
    Private Sub max()
        Dim CW As Integer = Me.Width ' Current Width
        Dim CH As Integer = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1080)
        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * (RW + 1)), Ctrl.Font.Style)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
    End Sub

    Private Sub btnCheckAval_Click(sender As Object, e As EventArgs) Handles btnCheckAval.Click
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
            allRooms = allRooms.Concat({row.RoomNo}).ToArray
        Next

        For Each room As String In allRooms
            If Not nonAvailRooms.Contains(room) Then
                availRooms = availRooms.Concat({room}).ToArray
            End If
        Next

        lblnumAvail.Text = CStr(availRooms.Length)
        lblnumAvail.Show()

        If availRooms.Length >= 1 Then
            comboBoxAvailRooms.Items.AddRange(availRooms)
            comboBoxAvailRooms.Show()
            btnBookNow.Show()
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
        If comboBoxAvailRooms.Text = Nothing Or (Not comboBoxAvailRooms.Items.Contains(comboBoxAvailRooms.Text)) Then
            MsgBox("Please Select A Room!")
        Else
            BookingTableAdapter1.BookRoom(comboBoxAvailRooms.Text, "admin", CInt(DateTimePickerFrom.Value.ToString("yyyyMMdd")), CInt(DateTimePickerTo.Value.ToString("yyyyMMdd")))
            MsgBox("Room: " & comboBoxAvailRooms.Text & " booked Successfully!")
        End If
        reloadForm()
    End Sub
End Class