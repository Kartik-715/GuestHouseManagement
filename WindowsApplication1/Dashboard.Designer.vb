<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.IITGLogo = New System.Windows.Forms.PictureBox()
        Me.lblGH = New System.Windows.Forms.Label()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxBill = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.UserControl_admindashboardnontabular1 = New WindowsApplication1.UserControl_admindashboardnontabular()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBookedFor = New System.Windows.Forms.Label()
        Me.lblBookedTill = New System.Windows.Forms.Label()
        Me.lblBookedFrom = New System.Windows.Forms.Label()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        Me.BookingTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnMyBookings = New WindowsApplication1.RoundButton()
        Me.btnUpdatePassword = New WindowsApplication1.RoundButton()
        Me.btnMyBills = New WindowsApplication1.RoundButton()
        Me.btnBookARoom = New WindowsApplication1.RoundButton()
        Me.btnLogOut = New WindowsApplication1.RoundButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IITGLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxBill.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.ghover
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(933, 554)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.IITgGH1
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1141, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblHello
        '
        Me.lblHello.BackColor = System.Drawing.Color.Transparent
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.White
        Me.lblHello.Location = New System.Drawing.Point(811, 146)
        Me.lblHello.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(213, 48)
        Me.lblHello.TabIndex = 11
        Me.lblHello.Text = "Hello! User"
        '
        'IITGLogo
        '
        Me.IITGLogo.BackColor = System.Drawing.Color.Transparent
        Me.IITGLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IITGLogo.Image = Global.WindowsApplication1.My.Resources.Resources.IITG_logo_png
        Me.IITGLogo.Location = New System.Drawing.Point(71, 39)
        Me.IITGLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.IITGLogo.Name = "IITGLogo"
        Me.IITGLogo.Size = New System.Drawing.Size(120, 111)
        Me.IITGLogo.TabIndex = 12
        Me.IITGLogo.TabStop = False
        '
        'lblGH
        '
        Me.lblGH.AutoSize = True
        Me.lblGH.BackColor = System.Drawing.Color.Transparent
        Me.lblGH.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGH.ForeColor = System.Drawing.Color.White
        Me.lblGH.Location = New System.Drawing.Point(223, 39)
        Me.lblGH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGH.Name = "lblGH"
        Me.lblGH.Size = New System.Drawing.Size(846, 69)
        Me.lblGH.TabIndex = 13
        Me.lblGH.Text = "IIT Guwahati Guest House"
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.Transparent
        Me.lblDashboard.Location = New System.Drawing.Point(443, 126)
        Me.lblDashboard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(264, 42)
        Me.lblDashboard.TabIndex = 16
        Me.lblDashboard.Text = "DASHBOARD"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.ghnight
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(933, 554)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.GH_dinning
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(933, 554)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.GroupBoxBill)
        Me.Panel1.Controls.Add(Me.UserControl_admindashboardnontabular1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(195, 194)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 566)
        Me.Panel1.TabIndex = 19
        '
        'GroupBoxBill
        '
        Me.GroupBoxBill.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBoxBill.Controls.Add(Me.lblTotal)
        Me.GroupBoxBill.Controls.Add(Me.lblTax)
        Me.GroupBoxBill.Controls.Add(Me.lblRoomCharges)
        Me.GroupBoxBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBill.Location = New System.Drawing.Point(0, 295)
        Me.GroupBoxBill.Name = "GroupBoxBill"
        Me.GroupBoxBill.Size = New System.Drawing.Size(655, 259)
        Me.GroupBoxBill.TabIndex = 20
        Me.GroupBoxBill.TabStop = False
        Me.GroupBoxBill.Text = "Your Bill"
        Me.GroupBoxBill.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(29, 187)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(196, 32)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total Amount"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(29, 151)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(169, 32)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "Tax ( 5% ) :"
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.AutoSize = True
        Me.lblRoomCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomCharges.Location = New System.Drawing.Point(29, 109)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(233, 32)
        Me.lblRoomCharges.TabIndex = 0
        Me.lblRoomCharges.Text = "Room Charges :"
        '
        'UserControl_admindashboardnontabular1
        '
        Me.UserControl_admindashboardnontabular1.BackColor = System.Drawing.Color.Azure
        Me.UserControl_admindashboardnontabular1.Location = New System.Drawing.Point(4, 436)
        Me.UserControl_admindashboardnontabular1.Margin = New System.Windows.Forms.Padding(0)
        Me.UserControl_admindashboardnontabular1.Name = "UserControl_admindashboardnontabular1"
        Me.UserControl_admindashboardnontabular1.Size = New System.Drawing.Size(1, 1)
        Me.UserControl_admindashboardnontabular1.TabIndex = 8
        Me.UserControl_admindashboardnontabular1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.lblBookedFor)
        Me.GroupBox1.Controls.Add(Me.lblBookedTill)
        Me.GroupBox1.Controls.Add(Me.lblBookedFrom)
        Me.GroupBox1.Controls.Add(Me.lblBookingID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(655, 286)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Booking"
        Me.GroupBox1.Visible = False
        '
        'lblBookedFor
        '
        Me.lblBookedFor.AutoSize = True
        Me.lblBookedFor.Location = New System.Drawing.Point(53, 121)
        Me.lblBookedFor.Name = "lblBookedFor"
        Me.lblBookedFor.Size = New System.Drawing.Size(171, 32)
        Me.lblBookedFor.TabIndex = 3
        Me.lblBookedFor.Text = "Booked For"
        '
        'lblBookedTill
        '
        Me.lblBookedTill.AutoSize = True
        Me.lblBookedTill.Location = New System.Drawing.Point(53, 220)
        Me.lblBookedTill.Name = "lblBookedTill"
        Me.lblBookedTill.Size = New System.Drawing.Size(168, 32)
        Me.lblBookedTill.TabIndex = 2
        Me.lblBookedTill.Text = "Booked Till"
        '
        'lblBookedFrom
        '
        Me.lblBookedFrom.AutoSize = True
        Me.lblBookedFrom.Location = New System.Drawing.Point(53, 170)
        Me.lblBookedFrom.Name = "lblBookedFrom"
        Me.lblBookedFrom.Size = New System.Drawing.Size(195, 32)
        Me.lblBookedFrom.TabIndex = 1
        Me.lblBookedFrom.Text = "Booked From"
        '
        'lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.Location = New System.Drawing.Point(53, 70)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(163, 32)
        Me.lblBookingID.TabIndex = 0
        Me.lblBookingID.Text = "Booking ID"
        '
        'UserTableTableAdapter1
        '
        Me.UserTableTableAdapter1.ClearBeforeFill = True
        '
        'GuestHouseDataSet1
        '
        Me.GuestHouseDataSet1.DataSetName = "guestHouseDataSet"
        Me.GuestHouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'btnMyBookings
        '
        Me.btnMyBookings.BackColor = System.Drawing.Color.Transparent
        Me.btnMyBookings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyBookings.FlatAppearance.BorderSize = 0
        Me.btnMyBookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMyBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyBookings.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyBookings.ForeColor = System.Drawing.Color.White
        Me.btnMyBookings.Location = New System.Drawing.Point(-5, 222)
        Me.btnMyBookings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMyBookings.Name = "btnMyBookings"
        Me.btnMyBookings.Size = New System.Drawing.Size(209, 74)
        Me.btnMyBookings.TabIndex = 15
        Me.btnMyBookings.Text = "My Bookings"
        Me.btnMyBookings.UseVisualStyleBackColor = False
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdatePassword.FlatAppearance.BorderSize = 0
        Me.btnUpdatePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.White
        Me.btnUpdatePassword.Location = New System.Drawing.Point(-5, 498)
        Me.btnUpdatePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(209, 74)
        Me.btnUpdatePassword.TabIndex = 7
        Me.btnUpdatePassword.Text = "Update Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = False
        '
        'btnMyBills
        '
        Me.btnMyBills.BackColor = System.Drawing.Color.Transparent
        Me.btnMyBills.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyBills.FlatAppearance.BorderSize = 0
        Me.btnMyBills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMyBills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMyBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyBills.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyBills.ForeColor = System.Drawing.Color.White
        Me.btnMyBills.Location = New System.Drawing.Point(-5, 406)
        Me.btnMyBills.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMyBills.Name = "btnMyBills"
        Me.btnMyBills.Size = New System.Drawing.Size(209, 74)
        Me.btnMyBills.TabIndex = 6
        Me.btnMyBills.Text = "My Bills"
        Me.btnMyBills.UseVisualStyleBackColor = False
        '
        'btnBookARoom
        '
        Me.btnBookARoom.BackColor = System.Drawing.Color.Transparent
        Me.btnBookARoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookARoom.FlatAppearance.BorderSize = 0
        Me.btnBookARoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBookARoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBookARoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookARoom.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookARoom.ForeColor = System.Drawing.Color.White
        Me.btnBookARoom.Location = New System.Drawing.Point(-5, 314)
        Me.btnBookARoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBookARoom.Name = "btnBookARoom"
        Me.btnBookARoom.Size = New System.Drawing.Size(209, 74)
        Me.btnBookARoom.TabIndex = 5
        Me.btnBookARoom.Text = "Book A Room"
        Me.btnBookARoom.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(-5, 591)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(209, 74)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.teal
        Me.ClientSize = New System.Drawing.Size(1005, 721)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDashboard)
        Me.Controls.Add(Me.btnMyBookings)
        Me.Controls.Add(Me.lblGH)
        Me.Controls.Add(Me.IITGLogo)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.btnMyBills)
        Me.Controls.Add(Me.btnBookARoom)
        Me.Controls.Add(Me.btnLogOut)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IITGLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxBill.ResumeLayout(False)
        Me.GroupBoxBill.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As WindowsApplication1.RoundButton
    Friend WithEvents btnBookARoom As WindowsApplication1.RoundButton
    Friend WithEvents btnMyBills As WindowsApplication1.RoundButton
    Friend WithEvents btnUpdatePassword As WindowsApplication1.RoundButton
    Friend WithEvents IITGLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblGH As System.Windows.Forms.Label
    Friend WithEvents btnMyBookings As WindowsApplication1.RoundButton
    Friend WithEvents lblDashboard As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBookedFor As System.Windows.Forms.Label
    Friend WithEvents lblBookedTill As System.Windows.Forms.Label
    Friend WithEvents lblBookedFrom As System.Windows.Forms.Label
    Friend WithEvents lblBookingID As System.Windows.Forms.Label
    Friend WithEvents UserTableTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents GuestHouseDataSet1 As WindowsApplication1.guestHouseDataSet
    Friend WithEvents BookingTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents UserControl_admindashboardnontabular1 As WindowsApplication1.UserControl_admindashboardnontabular
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents GroupBoxBill As System.Windows.Forms.GroupBox
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
