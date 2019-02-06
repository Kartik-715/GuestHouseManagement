<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUpdatePassword
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
        Me.lblHello = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtConfirmNewPass = New System.Windows.Forms.TextBox()
        Me.btnUpdatePass = New System.Windows.Forms.Button()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblHello.Location = New System.Drawing.Point(456, 34)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(131, 29)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "Hello User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm Password"
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(296, 113)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(166, 22)
        Me.txtOldPass.TabIndex = 4
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(296, 168)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(166, 22)
        Me.txtNewPass.TabIndex = 5
        '
        'txtConfirmNewPass
        '
        Me.txtConfirmNewPass.Location = New System.Drawing.Point(296, 223)
        Me.txtConfirmNewPass.Name = "txtConfirmNewPass"
        Me.txtConfirmNewPass.Size = New System.Drawing.Size(166, 22)
        Me.txtConfirmNewPass.TabIndex = 6
        '
        'btnUpdatePass
        '
        Me.btnUpdatePass.Location = New System.Drawing.Point(207, 295)
        Me.btnUpdatePass.Name = "btnUpdatePass"
        Me.btnUpdatePass.Size = New System.Drawing.Size(143, 37)
        Me.btnUpdatePass.TabIndex = 7
        Me.btnUpdatePass.Text = "Update Password"
        Me.btnUpdatePass.UseVisualStyleBackColor = True
        '
        'GuestHouseDataSet1
        '
        Me.GuestHouseDataSet1.DataSetName = "guestHouseDataSet"
        Me.GuestHouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableTableAdapter1
        '
        Me.UserTableTableAdapter1.ClearBeforeFill = True
        '
        'formUpdatePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 396)
        Me.Controls.Add(Me.btnUpdatePass)
        Me.Controls.Add(Me.txtConfirmNewPass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHello)
        Me.Name = "formUpdatePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formUpdatePassword"
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmNewPass As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdatePass As System.Windows.Forms.Button
    Friend WithEvents GuestHouseDataSet1 As WindowsApplication1.guestHouseDataSet
    Friend WithEvents UserTableTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
End Class
