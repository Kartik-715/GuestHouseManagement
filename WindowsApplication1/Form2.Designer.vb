<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.CheckIn = New System.Windows.Forms.Label()
        Me.Checkout = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckIn
        '
        Me.CheckIn.AutoSize = True
        Me.CheckIn.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.Location = New System.Drawing.Point(143, 191)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(174, 31)
        Me.CheckIn.TabIndex = 0
        Me.CheckIn.Text = "CheckIn Date"
        '
        'Checkout
        '
        Me.Checkout.AutoSize = True
        Me.Checkout.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkout.Location = New System.Drawing.Point(121, 278)
        Me.Checkout.Name = "Checkout"
        Me.Checkout.Size = New System.Drawing.Size(196, 31)
        Me.Checkout.TabIndex = 1
        Me.Checkout.Text = "CheckOut Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(478, 199)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 42)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(478, 267)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(217, 42)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 56)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Check Availability"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 592)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Checkout)
        Me.Controls.Add(Me.CheckIn)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Name = "Booking"
        Me.Text = "BookingPortal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckIn As System.Windows.Forms.Label
    Friend WithEvents Checkout As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
