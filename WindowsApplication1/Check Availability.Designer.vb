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
        Me.CheckIn = New System.Windows.Forms.Label()
        Me.Checkout = New System.Windows.Forms.Label()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.btnCheckAval = New System.Windows.Forms.Button()
        Me.lblBooking = New System.Windows.Forms.Label()
        Me.BookingTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        Me.RoomTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter()
        Me.lblAvailRoom = New System.Windows.Forms.Label()
        Me.comboBoxAvailRooms = New System.Windows.Forms.ComboBox()
        Me.lblnumAvail = New System.Windows.Forms.Label()
        Me.btnBookNow = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.rbtnIsVIP = New System.Windows.Forms.RadioButton()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckIn
        '
        Me.CheckIn.AutoSize = True
        Me.CheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.Location = New System.Drawing.Point(334, 254)
        Me.CheckIn.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(84, 32)
        Me.CheckIn.TabIndex = 0
        Me.CheckIn.Text = "From"
        '
        'Checkout
        '
        Me.Checkout.AutoSize = True
        Me.Checkout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkout.Location = New System.Drawing.Point(332, 380)
        Me.Checkout.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Checkout.Name = "Checkout"
        Me.Checkout.Size = New System.Drawing.Size(50, 32)
        Me.Checkout.TabIndex = 1
        Me.Checkout.Text = "To"
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(808, 244)
        Me.DateTimePickerFrom.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(430, 42)
        Me.DateTimePickerFrom.TabIndex = 2
        Me.DateTimePickerFrom.Value = New Date(2019, 2, 10, 0, 0, 0, 0)
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTo.Location = New System.Drawing.Point(808, 376)
        Me.DateTimePickerTo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(430, 42)
        Me.DateTimePickerTo.TabIndex = 3
        '
        'btnCheckAval
        '
        Me.btnCheckAval.Location = New System.Drawing.Point(598, 548)
        Me.btnCheckAval.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCheckAval.Name = "btnCheckAval"
        Me.btnCheckAval.Size = New System.Drawing.Size(426, 108)
        Me.btnCheckAval.TabIndex = 4
        Me.btnCheckAval.Text = "Check Availability"
        Me.btnCheckAval.UseVisualStyleBackColor = True
        '
        'lblBooking
        '
        Me.lblBooking.AutoSize = True
        Me.lblBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooking.Location = New System.Drawing.Point(334, 153)
        Me.lblBooking.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBooking.Name = "lblBooking"
        Me.lblBooking.Size = New System.Drawing.Size(126, 32)
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
        Me.lblAvailRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailRoom.Location = New System.Drawing.Point(286, 728)
        Me.lblAvailRoom.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAvailRoom.Name = "lblAvailRoom"
        Me.lblAvailRoom.Size = New System.Drawing.Size(261, 32)
        Me.lblAvailRoom.TabIndex = 6
        Me.lblAvailRoom.Text = "Available Rooms: "
        '
        'comboBoxAvailRooms
        '
        Me.comboBoxAvailRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxAvailRooms.FormattingEnabled = True
        Me.comboBoxAvailRooms.Location = New System.Drawing.Point(752, 1192)
        Me.comboBoxAvailRooms.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.comboBoxAvailRooms.Name = "comboBoxAvailRooms"
        Me.comboBoxAvailRooms.Size = New System.Drawing.Size(238, 39)
        Me.comboBoxAvailRooms.TabIndex = 7
        Me.comboBoxAvailRooms.Visible = False
        '
        'lblnumAvail
        '
        Me.lblnumAvail.AutoSize = True
        Me.lblnumAvail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumAvail.Location = New System.Drawing.Point(916, 716)
        Me.lblnumAvail.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblnumAvail.Name = "lblnumAvail"
        Me.lblnumAvail.Size = New System.Drawing.Size(108, 32)
        Me.lblnumAvail.TabIndex = 8
        Me.lblnumAvail.Text = "Label1"
        Me.lblnumAvail.Visible = False
        '
        'btnBookNow
        '
        Me.btnBookNow.Location = New System.Drawing.Point(752, 1267)
        Me.btnBookNow.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnBookNow.Name = "btnBookNow"
        Me.btnBookNow.Size = New System.Drawing.Size(272, 76)
        Me.btnBookNow.TabIndex = 9
        Me.btnBookNow.Text = "Book Now"
        Me.btnBookNow.UseVisualStyleBackColor = True
        Me.btnBookNow.Visible = False
        '
        'lblFirstName
        '
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(288, 856)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(280, 60)
        Me.lblFirstName.TabIndex = 1390
        Me.lblFirstName.Text = "&First Name"
        Me.lblFirstName.Visible = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(752, 851)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(682, 34)
        Me.txtName.TabIndex = 1386
        Me.txtName.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(752, 963)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLastName.Size = New System.Drawing.Size(682, 34)
        Me.txtLastName.TabIndex = 1387
        Me.txtLastName.Visible = False
        '
        'lblLastName
        '
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(288, 963)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(440, 66)
        Me.lblLastName.TabIndex = 1389
        Me.lblLastName.Text = "&Last Name"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLastName.Visible = False
        '
        'lblMobileNo
        '
        Me.lblMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNo.Location = New System.Drawing.Point(288, 1077)
        Me.lblMobileNo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(280, 60)
        Me.lblMobileNo.TabIndex = 1392
        Me.lblMobileNo.Text = "&Mobile No."
        Me.lblMobileNo.Visible = False
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(752, 1071)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(682, 34)
        Me.txtPhone.TabIndex = 1388
        Me.txtPhone.Visible = False
        '
        'rbtnIsVIP
        '
        Me.rbtnIsVIP.AutoSize = True
        Me.rbtnIsVIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIsVIP.Location = New System.Drawing.Point(808, 480)
        Me.rbtnIsVIP.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rbtnIsVIP.Name = "rbtnIsVIP"
        Me.rbtnIsVIP.Size = New System.Drawing.Size(85, 29)
        Me.rbtnIsVIP.TabIndex = 1393
        Me.rbtnIsVIP.TabStop = True
        Me.rbtnIsVIP.Text = "Is VIP"
        Me.rbtnIsVIP.UseVisualStyleBackColor = True
        Me.rbtnIsVIP.Visible = False
        '
        'Check_Availability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1906, 1157)
        Me.Controls.Add(Me.rbtnIsVIP)
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
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "Check_Availability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Availability"
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckIn As System.Windows.Forms.Label
    Friend WithEvents Checkout As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCheckAval As System.Windows.Forms.Button
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents BookingTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents GuestHouseDataSet1 As WindowsApplication1.guestHouseDataSet
    Friend WithEvents RoomTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents lblAvailRoom As System.Windows.Forms.Label
    Friend WithEvents comboBoxAvailRooms As System.Windows.Forms.ComboBox
    Friend WithEvents lblnumAvail As System.Windows.Forms.Label
    Friend WithEvents btnBookNow As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblMobileNo As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents rbtnIsVIP As System.Windows.Forms.RadioButton
End Class
