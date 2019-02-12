<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgotPass))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        Me.ForgotPassTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.ForgotPassTableAdapter()
        Me.lblOTP = New System.Windows.Forms.Label()
        Me.txtOTP = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVerify = New WindowsApplication1.RoundButton()
        Me.btnForgot = New WindowsApplication1.RoundButton()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(135, 84)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(199, 28)
        Me.txtEmail.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(24, 85)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(94, 32)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email: "
        '
        'UserTableTableAdapter1
        '
        Me.UserTableTableAdapter1.ClearBeforeFill = True
        '
        'GuestHouseDataSet1
        '
        Me.GuestHouseDataSet1.DataSetName = "guestHouseDataSet"
        Me.GuestHouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ForgotPassTableAdapter
        '
        Me.ForgotPassTableAdapter.ClearBeforeFill = True
        '
        'lblOTP
        '
        Me.lblOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTP.Location = New System.Drawing.Point(24, 124)
        Me.lblOTP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOTP.Name = "lblOTP"
        Me.lblOTP.Size = New System.Drawing.Size(94, 32)
        Me.lblOTP.TabIndex = 5
        Me.lblOTP.Text = "Token: "
        Me.lblOTP.Visible = False
        '
        'txtOTP
        '
        Me.txtOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOTP.Location = New System.Drawing.Point(135, 123)
        Me.txtOTP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOTP.Name = "txtOTP"
        Me.txtOTP.Size = New System.Drawing.Size(199, 28)
        Me.txtOTP.TabIndex = 6
        Me.txtOTP.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.tealAbstract
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 63)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.Teal
        Me.btnVerify.FlatAppearance.BorderSize = 0
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.ForeColor = System.Drawing.Color.White
        Me.btnVerify.Location = New System.Drawing.Point(114, 212)
        Me.btnVerify.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(125, 36)
        Me.btnVerify.TabIndex = 4
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = False
        Me.btnVerify.Visible = False
        '
        'btnForgot
        '
        Me.btnForgot.BackColor = System.Drawing.Color.Teal
        Me.btnForgot.FlatAppearance.BorderSize = 0
        Me.btnForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgot.ForeColor = System.Drawing.Color.White
        Me.btnForgot.Location = New System.Drawing.Point(114, 172)
        Me.btnForgot.Margin = New System.Windows.Forms.Padding(2)
        Me.btnForgot.Name = "btnForgot"
        Me.btnForgot.Size = New System.Drawing.Size(125, 36)
        Me.btnForgot.TabIndex = 0
        Me.btnForgot.Text = "Recover"
        Me.btnForgot.UseVisualStyleBackColor = False
        '
        'forgotPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(361, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtOTP)
        Me.Controls.Add(Me.lblOTP)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnForgot)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "forgotPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents UserTableTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents GuestHouseDataSet1 As WindowsApplication1.guestHouseDataSet
    Friend WithEvents ForgotPassTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.ForgotPassTableAdapter
    Friend WithEvents lblOTP As System.Windows.Forms.Label
    Friend WithEvents txtOTP As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnForgot As WindowsApplication1.RoundButton
    Friend WithEvents btnVerify As WindowsApplication1.RoundButton
End Class
