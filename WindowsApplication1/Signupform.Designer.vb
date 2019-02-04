<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signupform
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
        Me.txtCaptcha = New System.Windows.Forms.TextBox()
        Me.lblCaptcha = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.picCaptcha = New System.Windows.Forms.PictureBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCaptcha
        '
        Me.txtCaptcha.Location = New System.Drawing.Point(317, 320)
        Me.txtCaptcha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.Size = New System.Drawing.Size(179, 22)
        Me.txtCaptcha.TabIndex = 24
        '
        'lblCaptcha
        '
        Me.lblCaptcha.AutoSize = True
        Me.lblCaptcha.Location = New System.Drawing.Point(255, 266)
        Me.lblCaptcha.Name = "lblCaptcha"
        Me.lblCaptcha.Size = New System.Drawing.Size(60, 17)
        Me.lblCaptcha.TabIndex = 22
        Me.lblCaptcha.Text = "Captcha"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(259, 216)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(307, 22)
        Me.txtConfirmPassword.TabIndex = 20
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.Location = New System.Drawing.Point(255, 189)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(220, 23)
        Me.lblConfirmPassword.TabIndex = 19
        Me.lblConfirmPassword.Text = "&Confirm Password"
        Me.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(459, 350)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(107, 31)
        Me.Cancel.TabIndex = 18
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(259, 350)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(107, 31)
        Me.OK.TabIndex = 17
        Me.OK.Text = "&OK"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(259, 161)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(307, 22)
        Me.txtPassword.TabIndex = 16
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(259, 105)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(307, 22)
        Me.txtUsername.TabIndex = 14
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(255, 133)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(220, 23)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "&Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(255, 78)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(220, 23)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "&User name"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Global.WindowsApplication1.My.Resources.Resources.redo__2_
        Me.btnRefresh.Location = New System.Drawing.Point(527, 257)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(39, 36)
        Me.btnRefresh.TabIndex = 23
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'picCaptcha
        '
        Me.picCaptcha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picCaptcha.Location = New System.Drawing.Point(317, 257)
        Me.picCaptcha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCaptcha.Name = "picCaptcha"
        Me.picCaptcha.Size = New System.Drawing.Size(179, 55)
        Me.picCaptcha.TabIndex = 21
        Me.picCaptcha.TabStop = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.WindowsApplication1.My.Resources.Resources.main_gate
        Me.LogoPictureBox.Location = New System.Drawing.Point(80, 67)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 314)
        Me.LogoPictureBox.TabIndex = 13
        Me.LogoPictureBox.TabStop = False
        '
        'Signupform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 448)
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
        Me.Name = "Signupform"
        Me.Text = "Signupform"
        CType(Me.picCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCaptcha As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblCaptcha As System.Windows.Forms.Label
    Friend WithEvents picCaptcha As System.Windows.Forms.PictureBox
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
End Class
