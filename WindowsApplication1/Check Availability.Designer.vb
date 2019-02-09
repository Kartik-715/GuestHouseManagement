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
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckIn
        '
        Me.CheckIn.AutoSize = True
        Me.CheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.Location = New System.Drawing.Point(167, 131)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(84, 32)
        Me.CheckIn.TabIndex = 0
        Me.CheckIn.Text = "From"
        '
        'Checkout
        '
        Me.Checkout.AutoSize = True
        Me.Checkout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkout.Location = New System.Drawing.Point(166, 196)
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
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(404, 126)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(217, 42)
        Me.DateTimePickerFrom.TabIndex = 2
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTo.Location = New System.Drawing.Point(404, 194)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(217, 42)
        Me.DateTimePickerTo.TabIndex = 3
        '
        'btnCheckAval
        '
        Me.btnCheckAval.Location = New System.Drawing.Point(284, 283)
        Me.btnCheckAval.Name = "btnCheckAval"
        Me.btnCheckAval.Size = New System.Drawing.Size(213, 56)
        Me.btnCheckAval.TabIndex = 4
        Me.btnCheckAval.Text = "Check Availability"
        Me.btnCheckAval.UseVisualStyleBackColor = True
        '
        'lblBooking
        '
        Me.lblBooking.AutoSize = True
        Me.lblBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooking.Location = New System.Drawing.Point(167, 79)
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
        Me.lblAvailRoom.Location = New System.Drawing.Point(170, 442)
        Me.lblAvailRoom.Name = "lblAvailRoom"
        Me.lblAvailRoom.Size = New System.Drawing.Size(121, 17)
        Me.lblAvailRoom.TabIndex = 6
        Me.lblAvailRoom.Text = "Available Rooms: "
        '
        'comboBoxAvailRooms
        '
        Me.comboBoxAvailRooms.FormattingEnabled = True
        Me.comboBoxAvailRooms.Location = New System.Drawing.Point(172, 477)
        Me.comboBoxAvailRooms.Name = "comboBoxAvailRooms"
        Me.comboBoxAvailRooms.Size = New System.Drawing.Size(121, 24)
        Me.comboBoxAvailRooms.TabIndex = 7
        Me.comboBoxAvailRooms.Visible = False
        '
        'lblnumAvail
        '
        Me.lblnumAvail.AutoSize = True
        Me.lblnumAvail.Location = New System.Drawing.Point(307, 442)
        Me.lblnumAvail.Name = "lblnumAvail"
        Me.lblnumAvail.Size = New System.Drawing.Size(51, 17)
        Me.lblnumAvail.TabIndex = 8
        Me.lblnumAvail.Text = "Label1"
        Me.lblnumAvail.Visible = False
        '
        'btnBookNow
        '
        Me.btnBookNow.Location = New System.Drawing.Point(361, 477)
        Me.btnBookNow.Name = "btnBookNow"
        Me.btnBookNow.Size = New System.Drawing.Size(136, 23)
        Me.btnBookNow.TabIndex = 9
        Me.btnBookNow.Text = "Book Now"
        Me.btnBookNow.UseVisualStyleBackColor = True
        Me.btnBookNow.Visible = False
        '
        'Check_Availability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 632)
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
End Class
