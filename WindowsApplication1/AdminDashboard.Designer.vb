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
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnUpdatePassword = New System.Windows.Forms.Button()
        Me.btnMyBills = New System.Windows.Forms.Button()
        Me.btnBookARoom = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnApproveUsers = New System.Windows.Forms.Button()
        Me.labelNonApproved = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.RoomTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter()
        Me.DataGridPendingBookings = New System.Windows.Forms.DataGridView()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSet = New WindowsApplication1.guestHouseDataSet()
        Me.btnPendingBookings = New System.Windows.Forms.Button()
        Me.BookingTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.btnConfirmBookings = New System.Windows.Forms.Button()
        Me.FillByPendingBookingsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UserControl_admindashboard1 = New WindowsApplication1.UserControl_admindashboard()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedTillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingConfirmedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FillByPendingBookingsToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FillByPendingBookingsToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridPendingBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByPendingBookingsToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblHello.Location = New System.Drawing.Point(351, 21)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(131, 29)
        Me.lblHello.TabIndex = 13
        Me.lblHello.Text = "Hello User"
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdatePassword.Location = New System.Drawing.Point(62, 441)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(164, 56)
        Me.btnUpdatePassword.TabIndex = 12
        Me.btnUpdatePassword.Text = "Update Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = True
        '
        'btnMyBills
        '
        Me.btnMyBills.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyBills.Location = New System.Drawing.Point(62, 316)
        Me.btnMyBills.Name = "btnMyBills"
        Me.btnMyBills.Size = New System.Drawing.Size(164, 56)
        Me.btnMyBills.TabIndex = 11
        Me.btnMyBills.Text = "My Bills"
        Me.btnMyBills.UseVisualStyleBackColor = True
        '
        'btnBookARoom
        '
        Me.btnBookARoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookARoom.Location = New System.Drawing.Point(62, 254)
        Me.btnBookARoom.Name = "btnBookARoom"
        Me.btnBookARoom.Size = New System.Drawing.Size(164, 56)
        Me.btnBookARoom.TabIndex = 10
        Me.btnBookARoom.Text = "Book A Room"
        Me.btnBookARoom.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.Location = New System.Drawing.Point(62, 503)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(164, 56)
        Me.btnLogOut.TabIndex = 9
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnApproveUsers
        '
        Me.btnApproveUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApproveUsers.Location = New System.Drawing.Point(62, 379)
        Me.btnApproveUsers.Name = "btnApproveUsers"
        Me.btnApproveUsers.Size = New System.Drawing.Size(164, 56)
        Me.btnApproveUsers.TabIndex = 14
        Me.btnApproveUsers.Text = "Approve Users"
        Me.btnApproveUsers.UseVisualStyleBackColor = True
        '
        'labelNonApproved
        '
        Me.labelNonApproved.AutoSize = True
        Me.labelNonApproved.Location = New System.Drawing.Point(374, 75)
        Me.labelNonApproved.Name = "labelNonApproved"
        Me.labelNonApproved.Size = New System.Drawing.Size(51, 17)
        Me.labelNonApproved.TabIndex = 15
        Me.labelNonApproved.Text = "Label1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Location = New System.Drawing.Point(62, 566)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(164, 50)
        Me.btnAddRoom.TabIndex = 17
        Me.btnAddRoom.Text = "Add Room"
        Me.btnAddRoom.UseVisualStyleBackColor = True
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
        Me.DataGridPendingBookings.Location = New System.Drawing.Point(259, 154)
        Me.DataGridPendingBookings.Name = "DataGridPendingBookings"
        Me.DataGridPendingBookings.RowTemplate.Height = 24
        Me.DataGridPendingBookings.Size = New System.Drawing.Size(711, 196)
        Me.DataGridPendingBookings.TabIndex = 19
        Me.DataGridPendingBookings.Visible = False
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
        Me.btnPendingBookings.Location = New System.Drawing.Point(62, 182)
        Me.btnPendingBookings.Name = "btnPendingBookings"
        Me.btnPendingBookings.Size = New System.Drawing.Size(164, 66)
        Me.btnPendingBookings.TabIndex = 20
        Me.btnPendingBookings.Text = "Pending Bookings"
        Me.btnPendingBookings.UseVisualStyleBackColor = True
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'btnConfirmBookings
        '
        Me.btnConfirmBookings.Location = New System.Drawing.Point(814, 389)
        Me.btnConfirmBookings.Name = "btnConfirmBookings"
        Me.btnConfirmBookings.Size = New System.Drawing.Size(159, 46)
        Me.btnConfirmBookings.TabIndex = 22
        Me.btnConfirmBookings.Text = "Confirm Bookings"
        Me.btnConfirmBookings.UseVisualStyleBackColor = True
        Me.btnConfirmBookings.Visible = False
        '
        'FillByPendingBookingsToolStrip
        '
        Me.FillByPendingBookingsToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByPendingBookingsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByPendingBookingsToolStrip.Name = "FillByPendingBookingsToolStrip"
        Me.FillByPendingBookingsToolStrip.Size = New System.Drawing.Size(1006, 25)
        Me.FillByPendingBookingsToolStrip.TabIndex = 23
        Me.FillByPendingBookingsToolStrip.Text = "FillByPendingBookingsToolStrip"
        '
        'UserControl_admindashboard1
        '
        Me.UserControl_admindashboard1.Location = New System.Drawing.Point(232, 172)
        Me.UserControl_admindashboard1.Name = "UserControl_admindashboard1"
        Me.UserControl_admindashboard1.Size = New System.Drawing.Size(6, 44)
        Me.UserControl_admindashboard1.TabIndex = 18
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
        'FillByPendingBookingsToolStrip1
        '
        Me.FillByPendingBookingsToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByPendingBookingsToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByPendingBookingsToolStripButton})
        Me.FillByPendingBookingsToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillByPendingBookingsToolStrip1.Name = "FillByPendingBookingsToolStrip1"
        Me.FillByPendingBookingsToolStrip1.Size = New System.Drawing.Size(111, 25)
        Me.FillByPendingBookingsToolStrip1.TabIndex = 24
        Me.FillByPendingBookingsToolStrip1.Text = "FillByPendingBookingsToolStrip1"
        '
        'FillByPendingBookingsToolStripButton
        '
        Me.FillByPendingBookingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByPendingBookingsToolStripButton.Name = "FillByPendingBookingsToolStripButton"
        Me.FillByPendingBookingsToolStripButton.Size = New System.Drawing.Size(23, 23)
        Me.FillByPendingBookingsToolStripButton.Text = "FillByPendingBookings"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.FillByPendingBookingsToolStrip1)
        Me.Controls.Add(Me.FillByPendingBookingsToolStrip)
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
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridPendingBookings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByPendingBookingsToolStrip1.ResumeLayout(False)
        Me.FillByPendingBookingsToolStrip1.PerformLayout()
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
    Friend WithEvents btnConfirmBookings As System.Windows.Forms.Button
    Friend WithEvents FillByPendingBookingsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookedFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookedTillDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingConfirmedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FillByPendingBookingsToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByPendingBookingsToolStripButton As System.Windows.Forms.ToolStripButton
End Class
