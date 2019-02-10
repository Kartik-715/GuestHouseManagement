<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_admindashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsApprovedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSet = New WindowsApplication1.guestHouseDataSet()
        Me.UserTableTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.RoomTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter()
        Me.DataGridPendingBookings = New System.Windows.Forms.DataGridView()
        Me.BookingTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingConfirmedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BookedFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedTillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingForFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingForLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingForMobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsVIPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridPendingBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(58, 437)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(160, 44)
        Me.btnSaveChanges.TabIndex = 6
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.MobileNoDataGridViewTextBoxColumn, Me.IsApprovedDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.UserTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(58, 93)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(592, 303)
        Me.DataGridView1.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'MobileNoDataGridViewTextBoxColumn
        '
        Me.MobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo"
        Me.MobileNoDataGridViewTextBoxColumn.HeaderText = "MobileNo"
        Me.MobileNoDataGridViewTextBoxColumn.Name = "MobileNoDataGridViewTextBoxColumn"
        '
        'IsApprovedDataGridViewCheckBoxColumn
        '
        Me.IsApprovedDataGridViewCheckBoxColumn.DataPropertyName = "isApproved"
        Me.IsApprovedDataGridViewCheckBoxColumn.HeaderText = "isApproved"
        Me.IsApprovedDataGridViewCheckBoxColumn.Name = "IsApprovedDataGridViewCheckBoxColumn"
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "userTable"
        Me.UserTableBindingSource.DataSource = Me.GuestHouseDataSetBindingSource
        '
        'GuestHouseDataSetBindingSource
        '
        Me.GuestHouseDataSetBindingSource.DataSource = Me.GuestHouseDataSet
        Me.GuestHouseDataSetBindingSource.Position = 0
        '
        'GuestHouseDataSet
        '
        Me.GuestHouseDataSet.DataSetName = "guestHouseDataSet"
        Me.GuestHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = True
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
        Me.DataGridPendingBookings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.RoomNoDataGridViewTextBoxColumn, Me.BookedByDataGridViewTextBoxColumn, Me.BillDataGridViewTextBoxColumn, Me.BookingConfirmedDataGridViewCheckBoxColumn, Me.BookedFromDataGridViewTextBoxColumn, Me.BookedTillDataGridViewTextBoxColumn, Me.BookingForFirstNameDataGridViewTextBoxColumn, Me.BookingForLastNameDataGridViewTextBoxColumn, Me.BookingForMobileNoDataGridViewTextBoxColumn, Me.IsVIPDataGridViewCheckBoxColumn})
        Me.DataGridPendingBookings.DataSource = Me.BookingBindingSource
        Me.DataGridPendingBookings.Location = New System.Drawing.Point(58, 93)
        Me.DataGridPendingBookings.Name = "DataGridPendingBookings"
        Me.DataGridPendingBookings.RowTemplate.Height = 24
        Me.DataGridPendingBookings.Size = New System.Drawing.Size(711, 196)
        Me.DataGridPendingBookings.TabIndex = 20
        Me.DataGridPendingBookings.Visible = False
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.GuestHouseDataSet
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
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
        'BillDataGridViewTextBoxColumn
        '
        Me.BillDataGridViewTextBoxColumn.DataPropertyName = "Bill"
        Me.BillDataGridViewTextBoxColumn.HeaderText = "Bill"
        Me.BillDataGridViewTextBoxColumn.Name = "BillDataGridViewTextBoxColumn"
        '
        'BookingConfirmedDataGridViewCheckBoxColumn
        '
        Me.BookingConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "BookingConfirmed"
        Me.BookingConfirmedDataGridViewCheckBoxColumn.HeaderText = "BookingConfirmed"
        Me.BookingConfirmedDataGridViewCheckBoxColumn.Name = "BookingConfirmedDataGridViewCheckBoxColumn"
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
        'BookingForFirstNameDataGridViewTextBoxColumn
        '
        Me.BookingForFirstNameDataGridViewTextBoxColumn.DataPropertyName = "BookingForFirstName"
        Me.BookingForFirstNameDataGridViewTextBoxColumn.HeaderText = "BookingForFirstName"
        Me.BookingForFirstNameDataGridViewTextBoxColumn.Name = "BookingForFirstNameDataGridViewTextBoxColumn"
        '
        'BookingForLastNameDataGridViewTextBoxColumn
        '
        Me.BookingForLastNameDataGridViewTextBoxColumn.DataPropertyName = "BookingForLastName"
        Me.BookingForLastNameDataGridViewTextBoxColumn.HeaderText = "BookingForLastName"
        Me.BookingForLastNameDataGridViewTextBoxColumn.Name = "BookingForLastNameDataGridViewTextBoxColumn"
        '
        'BookingForMobileNoDataGridViewTextBoxColumn
        '
        Me.BookingForMobileNoDataGridViewTextBoxColumn.DataPropertyName = "BookingForMobileNo"
        Me.BookingForMobileNoDataGridViewTextBoxColumn.HeaderText = "BookingForMobileNo"
        Me.BookingForMobileNoDataGridViewTextBoxColumn.Name = "BookingForMobileNoDataGridViewTextBoxColumn"
        '
        'IsVIPDataGridViewCheckBoxColumn
        '
        Me.IsVIPDataGridViewCheckBoxColumn.DataPropertyName = "isVIP"
        Me.IsVIPDataGridViewCheckBoxColumn.HeaderText = "isVIP"
        Me.IsVIPDataGridViewCheckBoxColumn.Name = "IsVIPDataGridViewCheckBoxColumn"
        '
        'UserControl_admindashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridPendingBookings)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "UserControl_admindashboard"
        Me.Size = New System.Drawing.Size(928, 667)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridPendingBookings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsApprovedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents UserTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuestHouseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuestHouseDataSet As WindowsApplication1.guestHouseDataSet
    Friend WithEvents UserTableTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents RoomTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents DataGridPendingBookings As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingConfirmedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BookedFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookedTillDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingForFirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingForLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingForMobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsVIPDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.BookingTableAdapter

End Class
