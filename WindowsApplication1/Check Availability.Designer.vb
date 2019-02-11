<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check_Availability
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Check_Availability))
        Me.CheckIn = New System.Windows.Forms.Label()
        Me.Checkout = New System.Windows.Forms.Label()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.lblBooking = New System.Windows.Forms.Label()
        Me.BookingTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        Me.RoomTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter()
        Me.lblAvailRoom = New System.Windows.Forms.Label()
        Me.comboBoxAvailRooms = New System.Windows.Forms.ComboBox()
        Me.lblnumAvail = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.rbtnIsVIP = New System.Windows.Forms.CheckBox()
        Me.lblSelectRoom = New System.Windows.Forms.Label()
        Me.PictureBoxHeader = New System.Windows.Forms.PictureBox()
        Me.btnBookNow = New WindowsApplication1.RoundButton()
        Me.btnCheckAval = New WindowsApplication1.RoundButton()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckIn
        '
        Me.CheckIn.AutoSize = True
        Me.CheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.Location = New System.Drawing.Point(87, 132)
        Me.CheckIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(55, 24)
        Me.CheckIn.TabIndex = 0
        Me.CheckIn.Text = "From"
        '
        'Checkout
        '
        Me.Checkout.AutoSize = True
        Me.Checkout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkout.Location = New System.Drawing.Point(109, 187)
        Me.Checkout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Checkout.Name = "Checkout"
        Me.Checkout.Size = New System.Drawing.Size(33, 24)
        Me.Checkout.TabIndex = 1
        Me.Checkout.Text = "To"
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(211, 132)
        Me.DateTimePickerFrom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(258, 29)
        Me.DateTimePickerFrom.TabIndex = 2
        Me.DateTimePickerFrom.Value = New Date(2019, 2, 10, 0, 0, 0, 0)
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTo.Location = New System.Drawing.Point(211, 187)
        Me.DateTimePickerTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(258, 29)
        Me.DateTimePickerTo.TabIndex = 3
        '
        'lblBooking
        '
        Me.lblBooking.AutoSize = True
        Me.lblBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooking.Location = New System.Drawing.Point(44, 90)
        Me.lblBooking.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBooking.Name = "lblBooking"
        Me.lblBooking.Size = New System.Drawing.Size(98, 26)
        Me.lblBooking.TabIndex = 5
        Me.lblBooking.Text = "Booking"
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'GuestHouseDataSet1
        '
        Me.GuestHouseDataSet1.DataSetName = "guestHouseDataSet"
        Me.GuestHouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomTableAdapter1
        '
        Me.RoomTableAdapter1.ClearBeforeFill = True
        '
        'lblAvailRoom
        '
        Me.lblAvailRoom.AutoSize = True
        Me.lblAvailRoom.Font = New System.Drawing.Font("Microsoft Tai Le", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailRoom.Location = New System.Drawing.Point(38, 313)
        Me.lblAvailRoom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAvailRoom.Name = "lblAvailRoom"
        Me.lblAvailRoom.Size = New System.Drawing.Size(204, 29)
        Me.lblAvailRoom.TabIndex = 6
        Me.lblAvailRoom.Text = "Available Rooms: "
        '
        'comboBoxAvailRooms
        '
        Me.comboBoxAvailRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxAvailRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxAvailRooms.FormattingEnabled = True
        Me.comboBoxAvailRooms.Location = New System.Drawing.Point(211, 499)
        Me.comboBoxAvailRooms.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.comboBoxAvailRooms.Name = "comboBoxAvailRooms"
        Me.comboBoxAvailRooms.Size = New System.Drawing.Size(258, 28)
        Me.comboBoxAvailRooms.TabIndex = 7
        Me.comboBoxAvailRooms.Visible = False
        '
        'lblnumAvail
        '
        Me.lblnumAvail.AutoSize = True
        Me.lblnumAvail.Font = New System.Drawing.Font("Microsoft Tai Le", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumAvail.Location = New System.Drawing.Point(274, 313)
        Me.lblnumAvail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnumAvail.Name = "lblnumAvail"
        Me.lblnumAvail.Size = New System.Drawing.Size(83, 29)
        Me.lblnumAvail.TabIndex = 8
        Me.lblnumAvail.Text = "Label1"
        Me.lblnumAvail.Visible = False
        '
        'lblFirstName
        '
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(39, 353)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(140, 31)
        Me.lblFirstName.TabIndex = 1390
        Me.lblFirstName.Text = "&First Name"
        Me.lblFirstName.Visible = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(211, 356)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(258, 28)
        Me.txtName.TabIndex = 1386
        Me.txtName.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(211, 403)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLastName.Size = New System.Drawing.Size(258, 28)
        Me.txtLastName.TabIndex = 1387
        Me.txtLastName.Visible = False
        '
        'lblLastName
        '
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(39, 403)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(165, 28)
        Me.lblLastName.TabIndex = 1389
        Me.lblLastName.Text = "&Last Name"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLastName.Visible = False
        '
        'lblMobileNo
        '
        Me.lblMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNo.Location = New System.Drawing.Point(39, 451)
        Me.lblMobileNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(105, 25)
        Me.lblMobileNo.TabIndex = 1392
        Me.lblMobileNo.Text = "&Mobile No."
        Me.lblMobileNo.Visible = False
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(211, 448)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(258, 28)
        Me.txtPhone.TabIndex = 1388
        Me.txtPhone.Visible = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(68, 19)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(383, 41)
        Me.lblWelcome.TabIndex = 1395
        Me.lblWelcome.Text = "Check Room Availability"
        '
        'rbtnIsVIP
        '
        Me.rbtnIsVIP.AutoSize = True
        Me.rbtnIsVIP.BackColor = System.Drawing.Color.PaleTurquoise
        Me.rbtnIsVIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIsVIP.Location = New System.Drawing.Point(387, 252)
        Me.rbtnIsVIP.Name = "rbtnIsVIP"
        Me.rbtnIsVIP.Padding = New System.Windows.Forms.Padding(5, 3, 1, 3)
        Me.rbtnIsVIP.Size = New System.Drawing.Size(82, 34)
        Me.rbtnIsVIP.TabIndex = 1396
        Me.rbtnIsVIP.Text = "is VIP"
        Me.rbtnIsVIP.UseVisualStyleBackColor = False
        Me.rbtnIsVIP.Visible = False
        '
        'lblSelectRoom
        '
        Me.lblSelectRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectRoom.Location = New System.Drawing.Point(39, 499)
        Me.lblSelectRoom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectRoom.Name = "lblSelectRoom"
        Me.lblSelectRoom.Size = New System.Drawing.Size(152, 25)
        Me.lblSelectRoom.TabIndex = 1397
        Me.lblSelectRoom.Text = "Select Room"
        Me.lblSelectRoom.Visible = False
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.tealAbstract
        Me.PictureBoxHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxHeader.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBoxHeader.Name = "PictureBoxHeader"
        Me.PictureBoxHeader.Size = New System.Drawing.Size(523, 74)
        Me.PictureBoxHeader.TabIndex = 1394
        Me.PictureBoxHeader.TabStop = False
        '
        'btnBookNow
        '
        Me.btnBookNow.BackColor = System.Drawing.Color.Teal
        Me.btnBookNow.FlatAppearance.BorderSize = 0
        Me.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookNow.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookNow.ForeColor = System.Drawing.Color.White
        Me.btnBookNow.Location = New System.Drawing.Point(191, 550)
        Me.btnBookNow.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBookNow.Name = "btnBookNow"
        Me.btnBookNow.Size = New System.Drawing.Size(135, 42)
        Me.btnBookNow.TabIndex = 9
        Me.btnBookNow.Text = "Book Now"
        Me.btnBookNow.UseVisualStyleBackColor = False
        Me.btnBookNow.Visible = False
        '
        'btnCheckAval
        '
        Me.btnCheckAval.BackColor = System.Drawing.Color.Teal
        Me.btnCheckAval.FlatAppearance.BorderSize = 0
        Me.btnCheckAval.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckAval.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAval.ForeColor = System.Drawing.Color.White
        Me.btnCheckAval.Location = New System.Drawing.Point(211, 248)
        Me.btnCheckAval.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCheckAval.Name = "btnCheckAval"
        Me.btnCheckAval.Size = New System.Drawing.Size(94, 42)
        Me.btnCheckAval.TabIndex = 4
        Me.btnCheckAval.Text = "Check"
        Me.btnCheckAval.UseVisualStyleBackColor = False
        '
        'UserTableTableAdapter1
        '
        Me.UserTableTableAdapter1.ClearBeforeFill = True
        '
        'Check_Availability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(514, 624)
        Me.Controls.Add(Me.lblSelectRoom)
        Me.Controls.Add(Me.rbtnIsVIP)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBoxHeader)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblMobileNo)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.btnBookNow)
        Me.Controls.Add(Me.lblnumAvail)
        Me.Controls.Add(Me.comboBoxAvailRooms)
        Me.Controls.Add(Me.lblAvailRoom)
        Me.Controls.Add(Me.lblBooking)
        Me.Controls.Add(Me.btnCheckAval)
        Me.Controls.Add(Me.DateTimePickerTo)
        Me.Controls.Add(Me.DateTimePickerFrom)
        Me.Controls.Add(Me.Checkout)
        Me.Controls.Add(Me.CheckIn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "Check_Availability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Availability"
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckIn As System.Windows.Forms.Label
    Friend WithEvents Checkout As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents BookingTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents GuestHouseDataSet1 As WindowsApplication1.guestHouseDataSet
    Friend WithEvents RoomTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents lblAvailRoom As System.Windows.Forms.Label
    Friend WithEvents comboBoxAvailRooms As System.Windows.Forms.ComboBox
    Friend WithEvents lblnumAvail As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblMobileNo As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox

    Friend WithEvents PictureBoxHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents rbtnIsVIP As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheckAval As WindowsApplication1.RoundButton
    Friend WithEvents btnBookNow As WindowsApplication1.RoundButton
    Friend WithEvents lblSelectRoom As System.Windows.Forms.Label


    Friend WithEvents UserTableTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter

End Class
