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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PassButton3 = New System.Windows.Forms.Button()
        Me.PassButton2 = New System.Windows.Forms.Button()
        Me.PassButton1 = New System.Windows.Forms.Button()
        Me.btnUpdatePass = New System.Windows.Forms.Button()
        Me.txtConfirmNewPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PassButton3)
        Me.GroupBox2.Controls.Add(Me.PassButton2)
        Me.GroupBox2.Controls.Add(Me.PassButton1)
        Me.GroupBox2.Controls.Add(Me.btnUpdatePass)
        Me.GroupBox2.Controls.Add(Me.txtConfirmNewPass)
        Me.GroupBox2.Controls.Add(Me.txtNewPass)
        Me.GroupBox2.Controls.Add(Me.txtOldPass)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(96, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(682, 333)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Change Password"
        '
        'PassButton3
        '
        Me.PassButton3.BackColor = System.Drawing.Color.Transparent
        Me.PassButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassButton3.Image = Global.WindowsApplication1.My.Resources.Resources.vision_off
        Me.PassButton3.Location = New System.Drawing.Point(600, 210)
        Me.PassButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.PassButton3.Name = "PassButton3"
        Me.PassButton3.Size = New System.Drawing.Size(35, 34)
        Me.PassButton3.TabIndex = 21
        Me.PassButton3.UseVisualStyleBackColor = False
        '
        'PassButton2
        '
        Me.PassButton2.BackColor = System.Drawing.Color.Transparent
        Me.PassButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassButton2.Image = Global.WindowsApplication1.My.Resources.Resources.vision_off
        Me.PassButton2.Location = New System.Drawing.Point(600, 155)
        Me.PassButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.PassButton2.Name = "PassButton2"
        Me.PassButton2.Size = New System.Drawing.Size(35, 34)
        Me.PassButton2.TabIndex = 20
        Me.PassButton2.UseVisualStyleBackColor = False
        '
        'PassButton1
        '
        Me.PassButton1.BackColor = System.Drawing.Color.Transparent
        Me.PassButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassButton1.Image = Global.WindowsApplication1.My.Resources.Resources.vision_off
        Me.PassButton1.Location = New System.Drawing.Point(600, 100)
        Me.PassButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.PassButton1.Name = "PassButton1"
        Me.PassButton1.Size = New System.Drawing.Size(35, 34)
        Me.PassButton1.TabIndex = 19
        Me.PassButton1.UseVisualStyleBackColor = False
        '
        'btnUpdatePass
        '
        Me.btnUpdatePass.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePass.Location = New System.Drawing.Point(342, 274)
        Me.btnUpdatePass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdatePass.Name = "btnUpdatePass"
        Me.btnUpdatePass.Size = New System.Drawing.Size(253, 49)
        Me.btnUpdatePass.TabIndex = 18
        Me.btnUpdatePass.Text = "Update Password"
        Me.btnUpdatePass.UseVisualStyleBackColor = True
        '
        'txtConfirmNewPass
        '
        Me.txtConfirmNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPass.Location = New System.Drawing.Point(342, 210)
        Me.txtConfirmNewPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConfirmNewPass.Name = "txtConfirmNewPass"
        Me.txtConfirmNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmNewPass.Size = New System.Drawing.Size(292, 34)
        Me.txtConfirmNewPass.TabIndex = 17
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(342, 155)
        Me.txtNewPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(292, 34)
        Me.txtNewPass.TabIndex = 16
        '
        'txtOldPass
        '
        Me.txtOldPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPass.Location = New System.Drawing.Point(342, 100)
        Me.txtOldPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPass.Size = New System.Drawing.Size(292, 34)
        Me.txtOldPass.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(494, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(463, 30)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Enter New Password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Enter Old Password"
        '
        'UserControl_admindashboardnontabular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Name = "UserControl_admindashboardnontabular"
        Me.Size = New System.Drawing.Size(824, 680)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PassButton3 As System.Windows.Forms.Button
    Friend WithEvents PassButton2 As System.Windows.Forms.Button
    Friend WithEvents PassButton1 As System.Windows.Forms.Button
    Friend WithEvents btnUpdatePass As System.Windows.Forms.Button
    Friend WithEvents txtConfirmNewPass As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
