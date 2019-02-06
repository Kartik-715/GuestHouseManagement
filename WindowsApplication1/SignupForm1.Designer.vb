<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class SignupForm1
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
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupForm1))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuestHouseDataSet = New WindowsApplication1.guestHouseDataSet()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblCaptcha = New System.Windows.Forms.Label()
        Me.txtCaptcha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.picCaptcha = New System.Windows.Forms.PictureBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.UserTableTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.UserTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(284, 35)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(165, 28)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "&User name"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(284, 135)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(165, 28)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "&Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "username", True))
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtUsername.Location = New System.Drawing.Point(494, 35)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.txtUsername.Location = New System.Drawing.Point(696, 50)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(258, 28)
        Me.txtUsername.TabIndex = 1
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
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "password", True))
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtPassword.Location = New System.Drawing.Point(494, 135)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.txtPassword.Location = New System.Drawing.Point(696, 166)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(258, 28)
        Me.txtPassword.TabIndex = 3
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.OK.Location = New System.Drawing.Point(494, 397)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.OK.Location = New System.Drawing.Point(696, 428)
        Me.OK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 40)
        Me.OK.TabIndex = 6
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Cancel.Location = New System.Drawing.Point(652, 397)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.Cancel.Location = New System.Drawing.Point(906, 428)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 40)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "&Cancel"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtConfirmPassword.Location = New System.Drawing.Point(494, 185)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.txtConfirmPassword.Location = New System.Drawing.Point(696, 228)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(258, 28)
        Me.txtConfirmPassword.TabIndex = 4
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(284, 185)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
<<<<<<< HEAD
        Me.lblConfirmPassword.Size = New System.Drawing.Size(204, 28)
=======
        Me.lblConfirmPassword.Size = New System.Drawing.Size(288, 34)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.lblConfirmPassword.TabIndex = 6
        Me.lblConfirmPassword.Text = "&Confirm Password"
        Me.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCaptcha
        '
        Me.lblCaptcha.AutoSize = True
        Me.lblCaptcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptcha.Location = New System.Drawing.Point(284, 286)
        Me.lblCaptcha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCaptcha.Name = "lblCaptcha"
        Me.lblCaptcha.Size = New System.Drawing.Size(79, 24)
        Me.lblCaptcha.TabIndex = 9
        Me.lblCaptcha.Text = "Captcha"
        '
        'txtCaptcha
        '
        Me.txtCaptcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtCaptcha.Location = New System.Drawing.Point(494, 350)
        Me.txtCaptcha.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
=======
        Me.txtCaptcha.Location = New System.Drawing.Point(696, 371)
        Me.txtCaptcha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.Size = New System.Drawing.Size(176, 28)
        Me.txtCaptcha.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(779, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 11
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.WindowsApplication1.My.Resources.Resources.redo__2_
<<<<<<< HEAD
        Me.btnRefresh.Location = New System.Drawing.Point(715, 286)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.btnRefresh.Location = New System.Drawing.Point(993, 292)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(37, 37)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'picCaptcha
        '
        Me.picCaptcha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
<<<<<<< HEAD
        Me.picCaptcha.Location = New System.Drawing.Point(494, 286)
        Me.picCaptcha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
=======
        Me.picCaptcha.Location = New System.Drawing.Point(696, 292)
        Me.picCaptcha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.picCaptcha.Name = "picCaptcha"
        Me.picCaptcha.Size = New System.Drawing.Size(175, 57)
        Me.picCaptcha.TabIndex = 8
        Me.picCaptcha.TabStop = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.WindowsApplication1.My.Resources.Resources.main_gate5
<<<<<<< HEAD
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, -2)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(250, 453)
=======
        Me.LogoPictureBox.Location = New System.Drawing.Point(-1, -2)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(335, 567)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "MobileNo", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.TextBox1.Location = New System.Drawing.Point(494, 85)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
=======
        Me.TextBox1.Location = New System.Drawing.Point(696, 111)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 28)
        Me.TextBox1.TabIndex = 2
        '
        'lblMobileNo
        '
        Me.lblMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNo.Location = New System.Drawing.Point(284, 85)
        Me.lblMobileNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(105, 25)
        Me.lblMobileNo.TabIndex = 13
        Me.lblMobileNo.Text = "&Mobile No."
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = True
        '
        'UserTableBindingSource1
        '
        Me.UserTableBindingSource1.DataMember = "userTable"
        Me.UserTableBindingSource1.DataSource = Me.GuestHouseDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
<<<<<<< HEAD
        Me.ComboBox1.Items.AddRange(New Object() {"Student", "Professor", "Staff"})
        Me.ComboBox1.Location = New System.Drawing.Point(494, 235)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.ComboBox1.Location = New System.Drawing.Point(569, 384)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'lblCategory
        '
<<<<<<< HEAD
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(284, 235)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(105, 28)
        Me.lblCategory.TabIndex = 16
        Me.lblCategory.Text = "I am a"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
=======
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(384, 371)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 15
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        '
        'SignupForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(808, 451)
        Me.Controls.Add(Me.lblCategory)
=======
        Me.ClientSize = New System.Drawing.Size(1125, 554)
        Me.Controls.Add(Me.ListBox1)
>>>>>>> 6a852f95e336b83ff9364f7f118fe8d2b139d0f1
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblMobileNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtCaptcha)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblCaptcha)
        Me.Controls.Add(Me.picCaptcha)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "SignupForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign up"
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestHouseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents picCaptcha As System.Windows.Forms.PictureBox
    Friend WithEvents lblCaptcha As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtCaptcha As System.Windows.Forms.TextBox
    Friend WithEvents GuestHouseDataSet As WindowsApplication1.guestHouseDataSet
    Friend WithEvents UserTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMobileNo As System.Windows.Forms.Label
    Friend WithEvents UserTableBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
End Class
