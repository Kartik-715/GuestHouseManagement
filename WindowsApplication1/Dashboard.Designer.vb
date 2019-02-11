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
        Me.UserControl_admindashboardnontabular1 = New WindowsApplication1.UserControl_admindashboardnontabular()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBookedTillval = New System.Windows.Forms.Label()
        Me.lblBookedFromval = New System.Windows.Forms.Label()
        Me.lblBookedForval = New System.Windows.Forms.Label()
        Me.lblBookingIDval = New System.Windows.Forms.Label()
        Me.lblBookedFor = New System.Windows.Forms.Label()
        Me.lblBookedTill = New System.Windows.Forms.Label()
        Me.lblBookedFrom = New System.Windows.Forms.Label()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        Me.BookingTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.btnMyBookings = New WindowsApplication1.RoundButton()
        Me.btnUpdatePassword = New WindowsApplication1.RoundButton()
        Me.btnMyBills = New WindowsApplication1.RoundButton()
        Me.btnBookARoom = New WindowsApplication1.RoundButton()
        Me.btnLogOut = New WindowsApplication1.RoundButton()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        Me.BookingTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IITGLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(700, 450)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.IITgGH1
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(856, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.Transparent
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.White
        Me.lblHello.Location = New System.Drawing.Point(661, 118)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(168, 37)
        Me.lblHello.TabIndex = 11
        Me.lblHello.Text = "Hello! User"
        '
        'IITGLogo
        '
        Me.IITGLogo.BackColor = System.Drawing.Color.Transparent
        Me.IITGLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IITGLogo.Image = Global.WindowsApplication1.My.Resources.Resources.IITG_logo_png
        Me.IITGLogo.Location = New System.Drawing.Point(53, 32)
        Me.IITGLogo.Name = "IITGLogo"
        Me.IITGLogo.Size = New System.Drawing.Size(90, 90)
        Me.IITGLogo.TabIndex = 12
        Me.IITGLogo.TabStop = False
        '
        'lblGH
        '
        Me.lblGH.AutoSize = True
        Me.lblGH.BackColor = System.Drawing.Color.Transparent
        Me.lblGH.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGH.ForeColor = System.Drawing.Color.White
        Me.lblGH.Location = New System.Drawing.Point(167, 32)
        Me.lblGH.Name = "lblGH"
        Me.lblGH.Size = New System.Drawing.Size(675, 56)
        Me.lblGH.TabIndex = 13
        Me.lblGH.Text = "IIT Guwahati Guest House"
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.Transparent
        Me.lblDashboard.Location = New System.Drawing.Point(332, 102)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(207, 33)
        Me.lblDashboard.TabIndex = 16
        Me.lblDashboard.Text = "DASHBOARD"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.ghnight
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(700, 450)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApplication1.My.Resources.Resources.GH_dinning
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(700, 450)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.UserControl_admindashboardnontabular1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(146, 158)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 460)
        Me.Panel1.TabIndex = 19
        '
        'UserControl_admindashboardnontabular1
        '
        Me.UserControl_admindashboardnontabular1.BackColor = System.Drawing.Color.Azure
        Me.UserControl_admindashboardnontabular1.Location = New System.Drawing.Point(3, 354)
        Me.UserControl_admindashboardnontabular1.Margin = New System.Windows.Forms.Padding(0)
        Me.UserControl_admindashboardnontabular1.Name = "UserControl_admindashboardnontabular1"
        Me.UserControl_admindashboardnontabular1.Size = New System.Drawing.Size(9, 46)
        Me.UserControl_admindashboardnontabular1.TabIndex = 8
        Me.UserControl_admindashboardnontabular1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Azure
        Me.GroupBox1.Controls.Add(Me.lblBookedTillval)
        Me.GroupBox1.Controls.Add(Me.lblBookedFromval)
        Me.GroupBox1.Controls.Add(Me.lblBookedForval)
        Me.GroupBox1.Controls.Add(Me.lblBookingIDval)
        Me.GroupBox1.Controls.Add(Me.lblBookedFor)
        Me.GroupBox1.Controls.Add(Me.lblBookedTill)
        Me.GroupBox1.Controls.Add(Me.lblBookedFrom)
        Me.GroupBox1.Controls.Add(Me.lblBookingID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.GroupBox1.Location = New System.Drawing.Point(167, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(353, 232)

        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Booking"
        Me.GroupBox1.Visible = False
        '
        'lblBookedTillval
        '
        Me.lblBookedTillval.AutoSize = True
        Me.lblBookedTillval.Location = New System.Drawing.Point(231, 179)
        Me.lblBookedTillval.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)

        Me.lblBookedTillval.Name = "lblBookedTillval"
        Me.lblBookedTillval.Size = New System.Drawing.Size(83, 26)
        Me.lblBookedTillval.TabIndex = 7
        Me.lblBookedTillval.Text = "Label6"
        '
        'lblBookedFromval
        '
        Me.lblBookedFromval.AutoSize = True

        Me.lblBookedFromval.Location = New System.Drawing.Point(231, 138)
        Me.lblBookedFromval.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)

        Me.lblBookedFromval.Name = "lblBookedFromval"
        Me.lblBookedFromval.Size = New System.Drawing.Size(83, 26)
        Me.lblBookedFromval.TabIndex = 6
        Me.lblBookedFromval.Text = "Label5"
        '
        'lblBookedForval
        '
        Me.lblBookedForval.AutoSize = True

        Me.lblBookedForval.Location = New System.Drawing.Point(231, 98)
        Me.lblBookedForval.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)

        Me.lblBookedForval.Name = "lblBookedForval"
        Me.lblBookedForval.Size = New System.Drawing.Size(83, 26)
        Me.lblBookedForval.TabIndex = 5
        Me.lblBookedForval.Text = "Label4"
        '
        'lblBookingIDval
        '
        Me.lblBookingIDval.AutoSize = True

        Me.lblBookingIDval.Location = New System.Drawing.Point(231, 57)
        Me.lblBookingIDval.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)

        Me.lblBookingIDval.Name = "lblBookingIDval"
        Me.lblBookingIDval.Size = New System.Drawing.Size(83, 26)
        Me.lblBookingIDval.TabIndex = 4
        Me.lblBookingIDval.Text = "Label3"
        '
        'lblBookedFor
        '
        Me.lblBookedFor.AutoSize = True
        Me.lblBookedFor.Location = New System.Drawing.Point(40, 98)
        Me.lblBookedFor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookedFor.Name = "lblBookedFor"
        Me.lblBookedFor.Size = New System.Drawing.Size(134, 26)
        Me.lblBookedFor.TabIndex = 3
        Me.lblBookedFor.Text = "Booked For"
        '
        'lblBookedTill
        '
        Me.lblBookedTill.AutoSize = True
        Me.lblBookedTill.Location = New System.Drawing.Point(40, 179)
        Me.lblBookedTill.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookedTill.Name = "lblBookedTill"
        Me.lblBookedTill.Size = New System.Drawing.Size(130, 26)
        Me.lblBookedTill.TabIndex = 2
        Me.lblBookedTill.Text = "Booked Till"
        '
        'lblBookedFrom
        '
        Me.lblBookedFrom.AutoSize = True
        Me.lblBookedFrom.Location = New System.Drawing.Point(40, 138)
        Me.lblBookedFrom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookedFrom.Name = "lblBookedFrom"
        Me.lblBookedFrom.Size = New System.Drawing.Size(154, 26)
        Me.lblBookedFrom.TabIndex = 1
        Me.lblBookedFrom.Text = "Booked From"
        '
        'lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.Location = New System.Drawing.Point(40, 57)
        Me.lblBookingID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(129, 26)
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
        Me.btnMyBookings.Location = New System.Drawing.Point(-4, 180)
        Me.btnMyBookings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMyBookings.Name = "btnMyBookings"
        Me.btnMyBookings.Size = New System.Drawing.Size(157, 60)
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
        Me.btnUpdatePassword.Location = New System.Drawing.Point(-4, 405)
        Me.btnUpdatePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(157, 60)
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
        Me.btnMyBills.Location = New System.Drawing.Point(-4, 330)
        Me.btnMyBills.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMyBills.Name = "btnMyBills"
        Me.btnMyBills.Size = New System.Drawing.Size(157, 60)
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
        Me.btnBookARoom.Location = New System.Drawing.Point(-4, 255)
        Me.btnBookARoom.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBookARoom.Name = "btnBookARoom"
        Me.btnBookARoom.Size = New System.Drawing.Size(157, 60)
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
        Me.btnLogOut.Location = New System.Drawing.Point(-4, 480)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(157, 60)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '        'UserTableTableAdapter1
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
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.teal
        Me.ClientSize = New System.Drawing.Size(754, 586)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IITGLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents lblBookedTillval As System.Windows.Forms.Label
    Friend WithEvents lblBookedFromval As System.Windows.Forms.Label
    Friend WithEvents lblBookedForval As System.Windows.Forms.Label
    Friend WithEvents lblBookingIDval As System.Windows.Forms.Label
    Friend WithEvents lblBookedFor As System.Windows.Forms.Label
    Friend WithEvents lblBookedTill As System.Windows.Forms.Label
    Friend WithEvents lblBookedFrom As System.Windows.Forms.Label
    Friend WithEvents lblBookingID As System.Windows.Forms.Label
    Friend WithEvents UserTableTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents GuestHouseDataSet1 As WindowsApplication1.guestHouseDataSet
    Friend WithEvents BookingTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents UserControl_admindashboardnontabular1 As WindowsApplication1.UserControl_admindashboardnontabular
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
