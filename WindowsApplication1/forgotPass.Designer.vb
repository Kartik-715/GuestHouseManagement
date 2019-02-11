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
        Me.btnForgot = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.UserTableTableAdapter1 = New WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter()
        Me.GuestHouseDataSet1 = New WindowsApplication1.guestHouseDataSet()
        Me.ForgotPassTableAdapter = New WindowsApplication1.guestHouseDataSetTableAdapters.ForgotPassTableAdapter()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.lblOTP = New System.Windows.Forms.Label()
        Me.txtOTP = New System.Windows.Forms.TextBox()
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnForgot
        '
        Me.btnForgot.Location = New System.Drawing.Point(334, 268)
        Me.btnForgot.Name = "btnForgot"
        Me.btnForgot.Size = New System.Drawing.Size(182, 37)
        Me.btnForgot.TabIndex = 0
        Me.btnForgot.Text = "Recover"
        Me.btnForgot.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(308, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(279, 31)
        Me.txtEmail.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(198, 144)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(80, 26)
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
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(352, 311)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(151, 37)
        Me.btnVerify.TabIndex = 4
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        Me.btnVerify.Visible = False
        '
        'lblOTP
        '
        Me.lblOTP.AutoSize = True
        Me.lblOTP.Location = New System.Drawing.Point(198, 196)
        Me.lblOTP.Name = "lblOTP"
        Me.lblOTP.Size = New System.Drawing.Size(83, 26)
        Me.lblOTP.TabIndex = 5
        Me.lblOTP.Text = "Token: "
        Me.lblOTP.Visible = False
        '
        'txtOTP
        '
        Me.txtOTP.Location = New System.Drawing.Point(308, 193)
        Me.txtOTP.Name = "txtOTP"
        Me.txtOTP.Size = New System.Drawing.Size(279, 31)
        Me.txtOTP.TabIndex = 6
        Me.txtOTP.Visible = False
        '
        'forgotPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 433)
        Me.Controls.Add(Me.txtOTP)
        Me.Controls.Add(Me.lblOTP)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnForgot)
        Me.Name = "forgotPass"
        Me.Text = "Form2"
        CType(Me.GuestHouseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnForgot As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents UserTableTableAdapter1 As WindowsApplication1.guestHouseDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents GuestHouseDataSet1 As WindowsApplication1.guestHouseDataSet
    Friend WithEvents ForgotPassTableAdapter As WindowsApplication1.guestHouseDataSetTableAdapters.ForgotPassTableAdapter
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents lblOTP As System.Windows.Forms.Label
    Friend WithEvents txtOTP As System.Windows.Forms.TextBox
End Class
