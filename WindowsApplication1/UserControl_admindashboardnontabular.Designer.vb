<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_admindashboardnontabular
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnAddARoomToService = New System.Windows.Forms.RadioButton()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.lblRoomNo = New System.Windows.Forms.Label()
        Me.rbtnRemoveARoomFromService = New System.Windows.Forms.RadioButton()
        Me.rbtnIsVIP = New System.Windows.Forms.RadioButton()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSet = New WindowsApplication1.guestHouseDataSet()
        Me.UserTableTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.RoomTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnAddARoomToService)
        Me.GroupBox1.Controls.Add(Me.txtRoomNo)
        Me.GroupBox1.Controls.Add(Me.lblRoomNo)
        Me.GroupBox1.Controls.Add(Me.rbtnRemoveARoomFromService)
        Me.GroupBox1.Controls.Add(Me.rbtnIsVIP)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 321)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Or Remove Rooms"
        Me.GroupBox1.Visible = False
        '
        'rbtnAddARoomToService
        '
        Me.rbtnAddARoomToService.AutoSize = True
        Me.rbtnAddARoomToService.Checked = True
        Me.rbtnAddARoomToService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnAddARoomToService.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAddARoomToService.Location = New System.Drawing.Point(19, 60)
        Me.rbtnAddARoomToService.Name = "rbtnAddARoomToService"
        Me.rbtnAddARoomToService.Size = New System.Drawing.Size(209, 24)
        Me.rbtnAddARoomToService.TabIndex = 7
        Me.rbtnAddARoomToService.TabStop = True
        Me.rbtnAddARoomToService.Text = "Add A Room To Service"
        Me.rbtnAddARoomToService.UseVisualStyleBackColor = True
        '
        'txtRoomNo
        '
        Me.txtRoomNo.Location = New System.Drawing.Point(152, 157)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(94, 22)
        Me.txtRoomNo.TabIndex = 9
        '
        'lblRoomNo
        '
        Me.lblRoomNo.AutoSize = True
        Me.lblRoomNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNo.Location = New System.Drawing.Point(14, 159)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(98, 25)
        Me.lblRoomNo.TabIndex = 10
        Me.lblRoomNo.Text = "Room No."
        '
        'rbtnRemoveARoomFromService
        '
        Me.rbtnRemoveARoomFromService.AutoSize = True
        Me.rbtnRemoveARoomFromService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnRemoveARoomFromService.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnRemoveARoomFromService.Location = New System.Drawing.Point(239, 60)
        Me.rbtnRemoveARoomFromService.Name = "rbtnRemoveARoomFromService"
        Me.rbtnRemoveARoomFromService.Size = New System.Drawing.Size(217, 24)
        Me.rbtnRemoveARoomFromService.TabIndex = 8
        Me.rbtnRemoveARoomFromService.Text = "Remove A Room Service"
        Me.rbtnRemoveARoomFromService.UseVisualStyleBackColor = True
        '
        'rbtnIsVIP
        '
        Me.rbtnIsVIP.AutoSize = True
        Me.rbtnIsVIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIsVIP.Location = New System.Drawing.Point(153, 196)
        Me.rbtnIsVIP.Name = "rbtnIsVIP"
        Me.rbtnIsVIP.Size = New System.Drawing.Size(85, 29)
        Me.rbtnIsVIP.TabIndex = 11
        Me.rbtnIsVIP.TabStop = True
        Me.rbtnIsVIP.Text = "Is VIP"
        Me.rbtnIsVIP.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(115, 434)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(160, 44)
        Me.btnSaveChanges.TabIndex = 18
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
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
        'UserControl_admindashboardnontabular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Name = "UserControl_admindashboardnontabular"
        Me.Size = New System.Drawing.Size(824, 680)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnAddARoomToService As System.Windows.Forms.RadioButton
    Friend WithEvents txtRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomNo As System.Windows.Forms.Label
    Friend WithEvents rbtnRemoveARoomFromService As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnIsVIP As System.Windows.Forms.RadioButton
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents UserTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuestHouseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuestHouseDataSet As WindowsApplication1.guestHouseDataSet
    Friend WithEvents UserTableTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents RoomTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.RoomTableAdapter

End Class
