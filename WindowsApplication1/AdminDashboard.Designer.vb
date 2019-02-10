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
        Me.UserControl_admindashboard1 = New WindowsApplication1.UserControl_admindashboard()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'UserControl_admindashboard1
        '
        Me.UserControl_admindashboard1.Location = New System.Drawing.Point(232, 172)
        Me.UserControl_admindashboard1.Name = "UserControl_admindashboard1"
        Me.UserControl_admindashboard1.Size = New System.Drawing.Size(264, 338)
        Me.UserControl_admindashboard1.TabIndex = 18
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
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
End Class
