<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnBookARoom = New System.Windows.Forms.Button()
        Me.btnMyBills = New System.Windows.Forms.Button()
        Me.btnUpdatePassword = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(957, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 57)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Log Out"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnBookARoom
        '
        Me.btnBookARoom.Location = New System.Drawing.Point(957, 64)
        Me.btnBookARoom.Name = "btnBookARoom"
        Me.btnBookARoom.Size = New System.Drawing.Size(164, 57)
        Me.btnBookARoom.TabIndex = 5
        Me.btnBookARoom.Text = "Book A Room"
        Me.btnBookARoom.UseVisualStyleBackColor = True
        '
        'btnMyBills
        '
        Me.btnMyBills.Location = New System.Drawing.Point(957, 127)
        Me.btnMyBills.Name = "btnMyBills"
        Me.btnMyBills.Size = New System.Drawing.Size(164, 57)
        Me.btnMyBills.TabIndex = 6
        Me.btnMyBills.Text = "My Bills"
        Me.btnMyBills.UseVisualStyleBackColor = True
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.Location = New System.Drawing.Point(957, 190)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(164, 57)
        Me.btnUpdatePassword.TabIndex = 7
        Me.btnUpdatePassword.Text = "Update Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblHello.Location = New System.Drawing.Point(779, 29)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(131, 29)
        Me.lblHello.TabIndex = 8
        Me.lblHello.Text = "Hello User"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 721)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.btnMyBills)
        Me.Controls.Add(Me.btnBookARoom)
        Me.Controls.Add(Me.Button5)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnBookARoom As System.Windows.Forms.Button
    Friend WithEvents btnMyBills As System.Windows.Forms.Button
    Friend WithEvents btnUpdatePassword As System.Windows.Forms.Button
    Friend WithEvents lblHello As System.Windows.Forms.Label
End Class
