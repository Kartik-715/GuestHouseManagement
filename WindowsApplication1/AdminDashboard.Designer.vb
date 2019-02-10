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
        Me.labelNonApproved = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.RoomTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter()
        Me.DataGridPendingBookings = New System.Windows.Forms.DataGridView()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedTillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingConfirmedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSet = New WindowsApplication1.guestHouseDataSet()
        Me.BookingTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.btnConfirmBookings = New WindowsApplication1.RoundButton()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBoxHeader = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSidebar = New System.Windows.Forms.PictureBox()
        Me.btnPendingBookings = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.btnApproveUsers = New System.Windows.Forms.Button()
        Me.btnUpdatePassword = New System.Windows.Forms.Button()
        Me.btnMyBills = New System.Windows.Forms.Button()
        Me.btnBookARoom = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.UserControl_admindashboard1 = New WindowsApplication1.UserControl_admindashboard()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridPendingBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblHello.Location = New System.Drawing.Point(625, 98)
        Me.lblHello.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(102, 25)
        Me.lblHello.TabIndex = 13
        Me.lblHello.Text = "Hello User"
        '
        'labelNonApproved
        '
        Me.labelNonApproved.AutoSize = True
        Me.labelNonApproved.Location = New System.Drawing.Point(280, 61)
        Me.labelNonApproved.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelNonApproved.Name = "labelNonApproved"
        Me.labelNonApproved.Size = New System.Drawing.Size(39, 13)
        Me.labelNonApproved.TabIndex = 15
        Me.labelNonApproved.Text = "Label1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UserTableTableAdapter1
        '
        Me.UserTableTableAdapter1.ClearBeforeFill = True
        '
        'RoomTableAdapter1
        '
        Me.RoomTableAdapter1.ClearBeforeFill = True
        '
        'DataGridPendingBookings
        '
        Me.DataGridPendingBookings.AllowUserToAddRows = False
        Me.DataGridPendingBookings.AutoGenerateColumns = False
        Me.DataGridPendingBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPendingBookings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNoDataGridViewTextBoxColumn, Me.BookedByDataGridViewTextBoxColumn, Me.BookedFromDataGridViewTextBoxColumn, Me.BookedTillDataGridViewTextBoxColumn, Me.BookingConfirmedDataGridViewCheckBoxColumn})
        Me.DataGridPendingBookings.DataSource = Me.BookingBindingSource
        Me.DataGridPendingBookings.Location = New System.Drawing.Point(194, 125)
        Me.DataGridPendingBookings.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridPendingBookings.Name = "DataGridPendingBookings"
        Me.DataGridPendingBookings.RowTemplate.Height = 24
        Me.DataGridPendingBookings.Size = New System.Drawing.Size(533, 159)
        Me.DataGridPendingBookings.TabIndex = 19
        Me.DataGridPendingBookings.Visible = False
        '
        'RoomNoDataGridViewTextBoxColumn
        '
        Me.RoomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo"
        Me.RoomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo"
        Me.RoomNoDataGridViewTextBoxColumn.Name = "RoomNoDataGridViewTextBoxColumn"
        '
        'BookedByDataGridViewTextBoxColumn
        '
        Me.BookedByDataGridViewTextBoxColumn.DataPropertyName = "BookedBy"
        Me.BookedByDataGridViewTextBoxColumn.HeaderText = "BookedBy"
        Me.BookedByDataGridViewTextBoxColumn.Name = "BookedByDataGridViewTextBoxColumn"
        '
        'BookedFromDataGridViewTextBoxColumn
        '
        Me.BookedFromDataGridViewTextBoxColumn.DataPropertyName = "BookedFrom"
        Me.BookedFromDataGridViewTextBoxColumn.HeaderText = "BookedFrom"
        Me.BookedFromDataGridViewTextBoxColumn.Name = "BookedFromDataGridViewTextBoxColumn"
        '
        'BookedTillDataGridViewTextBoxColumn
        '
        Me.BookedTillDataGridViewTextBoxColumn.DataPropertyName = "BookedTill"
        Me.BookedTillDataGridViewTextBoxColumn.HeaderText = "BookedTill"
        Me.BookedTillDataGridViewTextBoxColumn.Name = "BookedTillDataGridViewTextBoxColumn"
        '
        'BookingConfirmedDataGridViewCheckBoxColumn
        '
        Me.BookingConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "BookingConfirmed"
        Me.BookingConfirmedDataGridViewCheckBoxColumn.HeaderText = "BookingConfirmed"
        Me.BookingConfirmedDataGridViewCheckBoxColumn.Name = "BookingConfirmedDataGridViewCheckBoxColumn"
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
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'btnConfirmBookings
        '
        Me.btnConfirmBookings.BackColor = System.Drawing.Color.Teal
        Me.btnConfirmBookings.FlatAppearance.BorderSize = 0
        Me.btnConfirmBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmBookings.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmBookings.ForeColor = System.Drawing.Color.White
        Me.btnConfirmBookings.Location = New System.Drawing.Point(610, 316)
        Me.btnConfirmBookings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmBookings.Name = "btnConfirmBookings"
        Me.btnConfirmBookings.Size = New System.Drawing.Size(119, 37)
        Me.btnConfirmBookings.TabIndex = 22
        Me.btnConfirmBookings.Text = "Confirm Bookings"
        Me.btnConfirmBookings.UseVisualStyleBackColor = False
        Me.btnConfirmBookings.Visible = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Georgia Pro Cond", 44.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(195, 27)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(547, 56)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to IITG Guest House Admin Portal"
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.tealAbstract
        Me.PictureBoxHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxHeader.Location = New System.Drawing.Point(189, -1)
        Me.PictureBoxHeader.Name = "PictureBoxHeader"
        Me.PictureBoxHeader.Size = New System.Drawing.Size(575, 96)
        Me.PictureBoxHeader.TabIndex = 25
        Me.PictureBoxHeader.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.IITG_logo_png1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(34, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 123)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxSidebar
        '
        Me.PictureBoxSidebar.Image = Global.WindowsApplication1.My.Resources.Resources.greySolid
        Me.PictureBoxSidebar.Location = New System.Drawing.Point(0, -5)
        Me.PictureBoxSidebar.Name = "PictureBoxSidebar"
        Me.PictureBoxSidebar.Size = New System.Drawing.Size(189, 606)
        Me.PictureBoxSidebar.TabIndex = 23
        Me.PictureBoxSidebar.TabStop = False
        '
        'btnPendingBookings
        '
        Me.btnPendingBookings.BackColor = System.Drawing.Color.Transparent
        Me.btnPendingBookings.BackgroundImage = CType(resources.GetObject("btnPendingBookings.BackgroundImage"), System.Drawing.Image)
        Me.btnPendingBookings.FlatAppearance.BorderSize = 0
        Me.btnPendingBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendingBookings.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendingBookings.ForeColor = System.Drawing.Color.White
        Me.btnPendingBookings.Location = New System.Drawing.Point(5, 199)
        Me.btnPendingBookings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPendingBookings.Name = "btnPendingBookings"
        Me.btnPendingBookings.Size = New System.Drawing.Size(181, 50)
        Me.btnPendingBookings.TabIndex = 20
        Me.btnPendingBookings.Text = "Pending Bookings"
        Me.btnPendingBookings.UseVisualStyleBackColor = False
        '
        'btnAddRoom
        '
        Me.btnAddRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnAddRoom.BackgroundImage = CType(resources.GetObject("btnAddRoom.BackgroundImage"), System.Drawing.Image)
        Me.btnAddRoom.FlatAppearance.BorderSize = 0
        Me.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRoom.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoom.ForeColor = System.Drawing.Color.White
        Me.btnAddRoom.Location = New System.Drawing.Point(5, 523)
        Me.btnAddRoom.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(181, 50)
        Me.btnAddRoom.TabIndex = 17
        Me.btnAddRoom.Text = "Add Room"
        Me.btnAddRoom.UseVisualStyleBackColor = False
        '
        'btnApproveUsers
        '
        Me.btnApproveUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnApproveUsers.BackgroundImage = CType(resources.GetObject("btnApproveUsers.BackgroundImage"), System.Drawing.Image)
        Me.btnApproveUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApproveUsers.FlatAppearance.BorderSize = 0
        Me.btnApproveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveUsers.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproveUsers.ForeColor = System.Drawing.Color.White
        Me.btnApproveUsers.Location = New System.Drawing.Point(5, 361)
        Me.btnApproveUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnApproveUsers.Name = "btnApproveUsers"
        Me.btnApproveUsers.Size = New System.Drawing.Size(181, 50)
        Me.btnApproveUsers.TabIndex = 14
        Me.btnApproveUsers.Text = "Approve Users"
        Me.btnApproveUsers.UseVisualStyleBackColor = False
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.BackgroundImage = CType(resources.GetObject("btnUpdatePassword.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdatePassword.FlatAppearance.BorderSize = 0
        Me.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.White
        Me.btnUpdatePassword.Location = New System.Drawing.Point(5, 415)
        Me.btnUpdatePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(181, 50)
        Me.btnUpdatePassword.TabIndex = 12
        Me.btnUpdatePassword.Text = "Update Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = False
        '
        'btnMyBills
        '
        Me.btnMyBills.BackColor = System.Drawing.Color.Transparent
        Me.btnMyBills.BackgroundImage = CType(resources.GetObject("btnMyBills.BackgroundImage"), System.Drawing.Image)
        Me.btnMyBills.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyBills.FlatAppearance.BorderSize = 0
        Me.btnMyBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyBills.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyBills.ForeColor = System.Drawing.Color.White
        Me.btnMyBills.Location = New System.Drawing.Point(5, 307)
        Me.btnMyBills.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMyBills.Name = "btnMyBills"
        Me.btnMyBills.Size = New System.Drawing.Size(181, 50)
        Me.btnMyBills.TabIndex = 11
        Me.btnMyBills.Text = "My Bills"
        Me.btnMyBills.UseVisualStyleBackColor = False
        '
        'btnBookARoom
        '
        Me.btnBookARoom.BackColor = System.Drawing.Color.Transparent
        Me.btnBookARoom.BackgroundImage = CType(resources.GetObject("btnBookARoom.BackgroundImage"), System.Drawing.Image)
        Me.btnBookARoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookARoom.FlatAppearance.BorderSize = 0
        Me.btnBookARoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookARoom.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookARoom.ForeColor = System.Drawing.Color.White
        Me.btnBookARoom.Location = New System.Drawing.Point(5, 253)
        Me.btnBookARoom.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBookARoom.Name = "btnBookARoom"
        Me.btnBookARoom.Size = New System.Drawing.Size(181, 50)
        Me.btnBookARoom.TabIndex = 10
        Me.btnBookARoom.Text = "Book A Room"
        Me.btnBookARoom.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BackgroundImage = CType(resources.GetObject("btnLogOut.BackgroundImage"), System.Drawing.Image)
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(5, 469)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(181, 50)
        Me.btnLogOut.TabIndex = 9
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'UserControl_admindashboard1
        '
        Me.UserControl_admindashboard1.Location = New System.Drawing.Point(174, 140)
        Me.UserControl_admindashboard1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserControl_admindashboard1.Name = "UserControl_admindashboard1"
        Me.UserControl_admindashboard1.Size = New System.Drawing.Size(0, 1)
        Me.UserControl_admindashboard1.TabIndex = 18
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 586)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBoxHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBoxSidebar)
        Me.Controls.Add(Me.btnConfirmBookings)
        Me.Controls.Add(Me.btnPendingBookings)
        Me.Controls.Add(Me.DataGridPendingBookings)
        Me.Controls.Add(Me.UserControl_admindashboard1)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.labelNonApproved)
        Me.Controls.Add(Me.btnApproveUsers)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.btnMyBills)
        Me.Controls.Add(Me.btnBookARoom)
        Me.Controls.Add(Me.btnLogOut)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridPendingBookings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSidebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents btnUpdatePassword As System.Windows.Forms.Button
    Friend WithEvents btnMyBills As System.Windows.Forms.Button
    Friend WithEvents btnBookARoom As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnApproveUsers As System.Windows.Forms.Button
    Friend WithEvents labelNonApproved As System.Windows.Forms.Label
    Friend WithEvents UserTableTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents RoomTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents UserControl_admindashboard1 As WindowsApplication1.UserControl_admindashboard
    Friend WithEvents DataGridPendingBookings As System.Windows.Forms.DataGridView
    Friend WithEvents btnPendingBookings As System.Windows.Forms.Button
    Friend WithEvents GuestHouseDataSet As WindowsApplication1.guestHouseDataSet
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookedFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookedTillDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingConfirmedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PictureBoxSidebar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnConfirmBookings As WindowsApplication1.RoundButton
End Class
