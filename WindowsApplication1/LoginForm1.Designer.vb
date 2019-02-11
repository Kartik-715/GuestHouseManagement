<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.GuestHouseDataSet = New WindowsApplication1.guestHouseDataSet()
        Me.UserTableTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PassButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(348, 25)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(318, 71)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "&Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEmail.UseCompatibleTextRendering = True
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(348, 196)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(376, 71)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "&Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(356, 104)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(520, 50)
        Me.txtEmail.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(356, 275)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(520, 50)
        Me.txtPassword.TabIndex = 3
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(356, 385)
        Me.OK.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(180, 62)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(698, 385)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(180, 62)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
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
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "userTable"
        Me.UserTableBindingSource.DataSource = Me.GuestHouseDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(908, 227)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 26)
        Me.Label1.TabIndex = 6
        '
        'PassButton
        '
        Me.PassButton.BackColor = System.Drawing.Color.Transparent
        Me.PassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PassButton.Image = Global.WindowsApplication1.My.Resources.Resources.vision_off
        Me.PassButton.Location = New System.Drawing.Point(828, 275)
        Me.PassButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PassButton.Name = "PassButton"
        Me.PassButton.Size = New System.Drawing.Size(52, 54)
        Me.PassButton.TabIndex = 6
        Me.PassButton.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.WindowsApplication1.My.Resources.Resources.main_gate5
        Me.LogoPictureBox.Location = New System.Drawing.Point(-6, -2)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(322, 488)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Forgot Password?"
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(966, 471)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PassButton)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GuestHouseDataSet As WindowsApplication1.guestHouseDataSet
    Friend WithEvents UserTableTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents UserTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PassButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
