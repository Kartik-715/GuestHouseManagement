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
        Me.components = New System.ComponentModel.Container()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtConfirmNewPass = New System.Windows.Forms.TextBox()
        Me.btnUpdatePass = New System.Windows.Forms.Button()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSet = New WindowsApplication1.guestHouseDataSet()
        Me.UserTableTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.PassButton1 = New System.Windows.Forms.Button()
        Me.PassButton2 = New System.Windows.Forms.Button()
        Me.PassButton3 = New System.Windows.Forms.Button()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Tai Le", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(206, 25)
        Me.lblHello.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(125, 29)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "Hello User"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Old Password"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter New Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm Password"
        '
        'txtOldPass
        '
        Me.txtOldPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPass.Location = New System.Drawing.Point(257, 72)
        Me.txtOldPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPass.Size = New System.Drawing.Size(220, 28)
        Me.txtOldPass.TabIndex = 4
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(257, 117)
        Me.txtNewPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(220, 28)
        Me.txtNewPass.TabIndex = 5
        '
        'txtConfirmNewPass
        '
        Me.txtConfirmNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPass.Location = New System.Drawing.Point(257, 162)
        Me.txtConfirmNewPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConfirmNewPass.Name = "txtConfirmNewPass"
        Me.txtConfirmNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmNewPass.Size = New System.Drawing.Size(220, 28)
        Me.txtConfirmNewPass.TabIndex = 6
        '
        'btnUpdatePass
        '
        Me.btnUpdatePass.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePass.Location = New System.Drawing.Point(162, 213)
        Me.btnUpdatePass.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdatePass.Name = "btnUpdatePass"
        Me.btnUpdatePass.Size = New System.Drawing.Size(190, 40)
        Me.btnUpdatePass.TabIndex = 7
        Me.btnUpdatePass.Text = "Update Password"
        Me.btnUpdatePass.UseVisualStyleBackColor = True
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "userTable"
        Me.UserTableBindingSource.DataSource = Me.GuestHouseDataSet
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
        'PassButton1
        '
        Me.PassButton1.BackColor = System.Drawing.Color.Transparent
        Me.PassButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassButton1.Image = Global.WindowsApplication1.My.Resources.Resources.vision_off
        Me.PassButton1.Location = New System.Drawing.Point(451, 72)
        Me.PassButton1.Name = "PassButton1"
        Me.PassButton1.Size = New System.Drawing.Size(26, 28)
        Me.PassButton1.TabIndex = 8
        Me.PassButton1.UseVisualStyleBackColor = False
        '
        'PassButton2
        '
        Me.PassButton2.BackColor = System.Drawing.Color.Transparent
        Me.PassButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassButton2.Image = Global.WindowsApplication1.My.Resources.Resources.vision_off
        Me.PassButton2.Location = New System.Drawing.Point(451, 117)
        Me.PassButton2.Name = "PassButton2"
        Me.PassButton2.Size = New System.Drawing.Size(26, 28)
        Me.PassButton2.TabIndex = 9
        Me.PassButton2.UseVisualStyleBackColor = False
        '
        'PassButton3
        '
        Me.PassButton3.BackColor = System.Drawing.Color.Transparent
        Me.PassButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassButton3.Image = Global.WindowsApplication1.My.Resources.Resources.vision_off
        Me.PassButton3.Location = New System.Drawing.Point(451, 162)
        Me.PassButton3.Name = "PassButton3"
        Me.PassButton3.Size = New System.Drawing.Size(26, 28)
        Me.PassButton3.TabIndex = 10
        Me.PassButton3.UseVisualStyleBackColor = False
        '
        'formUpdatePassword
        '
        Me.AcceptButton = Me.btnUpdatePass
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 271)
        Me.Controls.Add(Me.PassButton3)
        Me.Controls.Add(Me.PassButton2)
        Me.Controls.Add(Me.PassButton1)
        Me.Controls.Add(Me.btnUpdatePass)
        Me.Controls.Add(Me.txtConfirmNewPass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHello)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "formUpdatePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Password"
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents UserTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuestHouseDataSet As WindowsApplication1.guestHouseDataSet
    Friend WithEvents UserTableTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents PassButton1 As System.Windows.Forms.Button
    Friend WithEvents PassButton2 As System.Windows.Forms.Button
    Friend WithEvents PassButton3 As System.Windows.Forms.Button
End Class
