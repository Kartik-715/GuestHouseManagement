<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnUpdatePassword = New WindowsApplication1.RoundButton()
        Me.btnRoomStatus = New WindowsApplication1.RoundButton()
        Me.btnBookARoom = New WindowsApplication1.RoundButton()
        Me.btnLogOut = New WindowsApplication1.RoundButton()
        Me.btnApproveUsers = New WindowsApplication1.RoundButton()
        Me.labelNonApproved = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAddRoom = New WindowsApplication1.RoundButton()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.RoomTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSet = New WindowsApplication1.guestHouseDataSet()
        Me.btnPendingBookings = New WindowsApplication1.RoundButton()
        Me.BookingTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.UserControl_dynamiccontrol1 = New WindowsApplication1.UserControl_dynamiccontrol()
        Me.UserControl_admindashboardnontabular1 = New WindowsApplication1.UserControl_admindashboardnontabular()
        Me.btnAllBookings = New WindowsApplication1.RoundButton()
        Me.PictureBoxGrey = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxHeader = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblPendingBooking = New System.Windows.Forms.Label()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxGrey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.Transparent
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHello.Location = New System.Drawing.Point(840, 85)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(154, 36)
        Me.lblHello.TabIndex = 13
        Me.lblHello.Text = "Hello User"
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdatePassword.FlatAppearance.BorderSize = 0
        Me.btnUpdatePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.White
        Me.btnUpdatePassword.Location = New System.Drawing.Point(-11, 466)
        Me.btnUpdatePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(269, 52)
        Me.btnUpdatePassword.TabIndex = 12
        Me.btnUpdatePassword.Text = "Update Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = False
        '
        'btnRoomStatus
        '
        Me.btnRoomStatus.BackColor = System.Drawing.Color.Transparent
        Me.btnRoomStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRoomStatus.FlatAppearance.BorderSize = 0
        Me.btnRoomStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRoomStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomStatus.ForeColor = System.Drawing.Color.White
        Me.btnRoomStatus.Location = New System.Drawing.Point(-11, 407)
        Me.btnRoomStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRoomStatus.Name = "btnRoomStatus"
        Me.btnRoomStatus.Size = New System.Drawing.Size(269, 52)
        Me.btnRoomStatus.TabIndex = 11
        Me.btnRoomStatus.Text = "Room Status"
        Me.btnRoomStatus.UseVisualStyleBackColor = False
        '
        'btnBookARoom
        '
        Me.btnBookARoom.BackColor = System.Drawing.Color.Transparent
        Me.btnBookARoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookARoom.FlatAppearance.BorderSize = 0
        Me.btnBookARoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBookARoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBookARoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookARoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookARoom.ForeColor = System.Drawing.Color.White
        Me.btnBookARoom.Location = New System.Drawing.Point(-11, 347)
        Me.btnBookARoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBookARoom.Name = "btnBookARoom"
        Me.btnBookARoom.Size = New System.Drawing.Size(269, 52)
        Me.btnBookARoom.TabIndex = 10
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
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(-11, 226)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(269, 52)
        Me.btnLogOut.TabIndex = 9
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnApproveUsers
        '
        Me.btnApproveUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnApproveUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApproveUsers.FlatAppearance.BorderSize = 0
        Me.btnApproveUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnApproveUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnApproveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproveUsers.ForeColor = System.Drawing.Color.White
        Me.btnApproveUsers.Location = New System.Drawing.Point(-11, 587)
        Me.btnApproveUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnApproveUsers.Name = "btnApproveUsers"
        Me.btnApproveUsers.Size = New System.Drawing.Size(269, 52)
        Me.btnApproveUsers.TabIndex = 14
        Me.btnApproveUsers.Text = "Approve Users"
        Me.btnApproveUsers.UseVisualStyleBackColor = False
        Me.btnApproveUsers.Visible = False
        '
        'labelNonApproved
        '
        Me.labelNonApproved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelNonApproved.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNonApproved.Location = New System.Drawing.Point(268, 158)
        Me.labelNonApproved.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNonApproved.Name = "labelNonApproved"
        Me.labelNonApproved.Size = New System.Drawing.Size(276, 29)
        Me.labelNonApproved.TabIndex = 15
        Me.labelNonApproved.Text = "Label1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnAddRoom
        '
        Me.btnAddRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnAddRoom.FlatAppearance.BorderSize = 0
        Me.btnAddRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoom.ForeColor = System.Drawing.Color.White
        Me.btnAddRoom.Location = New System.Drawing.Point(-11, 527)
        Me.btnAddRoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(269, 52)
        Me.btnAddRoom.TabIndex = 17
        Me.btnAddRoom.Text = "Add/Remove Room"
        Me.btnAddRoom.UseVisualStyleBackColor = False
        Me.btnAddRoom.Visible = False
        '
        'UserTableTableAdapter1
        '
        Me.UserTableTableAdapter1.ClearBeforeFill = True
        '
        'RoomTableAdapter1
        '
        Me.RoomTableAdapter1.ClearBeforeFill = True
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.GuestHouseDataSet
        '
        'GuestHouseDataSet
        '
        Me.GuestHouseDataSet.DataSetName = "guestHouseDataSet"
        Me.GuestHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPendingBookings
        '
        Me.btnPendingBookings.BackColor = System.Drawing.Color.Transparent
        Me.btnPendingBookings.FlatAppearance.BorderSize = 0
        Me.btnPendingBookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPendingBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPendingBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendingBookings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendingBookings.ForeColor = System.Drawing.Color.White
        Me.btnPendingBookings.Location = New System.Drawing.Point(-11, 647)
        Me.btnPendingBookings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPendingBookings.Name = "btnPendingBookings"
        Me.btnPendingBookings.Size = New System.Drawing.Size(269, 52)
        Me.btnPendingBookings.TabIndex = 20
        Me.btnPendingBookings.Text = "Pending Bookings"
        Me.btnPendingBookings.UseVisualStyleBackColor = False
        Me.btnPendingBookings.Visible = False
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'UserControl_dynamiccontrol1
        '
        Me.UserControl_dynamiccontrol1.AutoScroll = True
        Me.UserControl_dynamiccontrol1.Location = New System.Drawing.Point(723, 370)
        Me.UserControl_dynamiccontrol1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControl_dynamiccontrol1.Name = "UserControl_dynamiccontrol1"
        Me.UserControl_dynamiccontrol1.Size = New System.Drawing.Size(872, 691)
        Me.UserControl_dynamiccontrol1.TabIndex = 24
        '
        'UserControl_admindashboardnontabular1
        '
        Me.UserControl_admindashboardnontabular1.BackColor = System.Drawing.Color.Azure
        Me.UserControl_admindashboardnontabular1.Location = New System.Drawing.Point(876, 226)
        Me.UserControl_admindashboardnontabular1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserControl_admindashboardnontabular1.Name = "UserControl_admindashboardnontabular1"
        Me.UserControl_admindashboardnontabular1.Size = New System.Drawing.Size(1, 1)
        Me.UserControl_admindashboardnontabular1.TabIndex = 23
        '
        'btnAllBookings
        '
        Me.btnAllBookings.BackColor = System.Drawing.Color.Transparent
        Me.btnAllBookings.FlatAppearance.BorderSize = 0
        Me.btnAllBookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAllBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAllBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllBookings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllBookings.ForeColor = System.Drawing.Color.White
        Me.btnAllBookings.Location = New System.Drawing.Point(-11, 287)
        Me.btnAllBookings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAllBookings.Name = "btnAllBookings"
        Me.btnAllBookings.Size = New System.Drawing.Size(269, 52)
        Me.btnAllBookings.TabIndex = 25
        Me.btnAllBookings.Text = "Current Bookings"
        Me.btnAllBookings.UseVisualStyleBackColor = False
        '
        'PictureBoxGrey
        '
        Me.PictureBoxGrey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxGrey.Image = Global.WindowsApplication1.My.Resources.Resources.greySolid
        Me.PictureBoxGrey.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxGrey.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxGrey.Name = "PictureBoxGrey"
        Me.PictureBoxGrey.Size = New System.Drawing.Size(229, 745)
        Me.PictureBoxGrey.TabIndex = 26
        Me.PictureBoxGrey.TabStop = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = Global.WindowsApplication1.My.Resources.Resources.IITG_logo_png
        Me.PictureBoxLogo.Location = New System.Drawing.Point(61, 57)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(131, 130)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 27
        Me.PictureBoxLogo.TabStop = False
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.Image = Global.WindowsApplication1.My.Resources.Resources.tealAbstract
        Me.PictureBoxHeader.Location = New System.Drawing.Point(229, 0)
        Me.PictureBoxHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxHeader.Name = "PictureBoxHeader"
        Me.PictureBoxHeader.Size = New System.Drawing.Size(989, 130)
        Me.PictureBoxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHeader.TabIndex = 28
        Me.PictureBoxHeader.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Georgia", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(88, 43)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1064, 56)
        Me.lblWelcome.TabIndex = 29
        Me.lblWelcome.Text = "Welcome to IITG Guest House Staff Portal"
        '
        'lblPendingBooking
        '
        Me.lblPendingBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPendingBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingBooking.Location = New System.Drawing.Point(898, 158)
        Me.lblPendingBooking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPendingBooking.Name = "lblPendingBooking"
        Me.lblPendingBooking.Size = New System.Drawing.Size(279, 29)
        Me.lblPendingBooking.TabIndex = 30
        Me.lblPendingBooking.Text = "Label1"
        '
        'GuestHouseDataSet1
        '
        Me.GuestHouseDataSet1.DataSetName = "guestHouseDataSet"
        Me.GuestHouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1190, 709)
        Me.Controls.Add(Me.lblPendingBooking)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBoxHeader)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.PictureBoxGrey)
        Me.Controls.Add(Me.btnAllBookings)
        Me.Controls.Add(Me.UserControl_dynamiccontrol1)
        Me.Controls.Add(Me.UserControl_admindashboardnontabular1)
        Me.Controls.Add(Me.btnPendingBookings)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.labelNonApproved)
        Me.Controls.Add(Me.btnApproveUsers)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnRoomStatus)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.btnBookARoom)
        Me.Controls.Add(Me.btnLogOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "AdminDashboard"
        Me.Text = "Admin Dashboard"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxGrey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents labelNonApproved As System.Windows.Forms.Label
    Friend WithEvents UserTableTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents RoomTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents GuestHouseDataSet As WindowsApplication1.guestHouseDataSet
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents UserControl_admindashboardnontabular1 As WindowsApplication1.UserControl_admindashboardnontabular
    Friend WithEvents UserControl_dynamiccontrol1 As WindowsApplication1.UserControl_dynamiccontrol
    Friend WithEvents PictureBoxGrey As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpdatePassword As WindowsApplication1.RoundButton
    Friend WithEvents btnRoomStatus As WindowsApplication1.RoundButton
    Friend WithEvents btnBookARoom As WindowsApplication1.RoundButton
    Friend WithEvents btnLogOut As WindowsApplication1.RoundButton
    Friend WithEvents btnApproveUsers As WindowsApplication1.RoundButton
    Friend WithEvents btnAddRoom As WindowsApplication1.RoundButton
    Friend WithEvents btnPendingBookings As WindowsApplication1.RoundButton
    Friend WithEvents btnAllBookings As WindowsApplication1.RoundButton
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents PictureBoxHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblPendingBooking As System.Windows.Forms.Label
    Friend WithEvents GuestHouseDataSet1 As WindowsApplication1.guestHouseDataSet
End Class
