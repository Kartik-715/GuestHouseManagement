Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogin = New WindowsApplication1.RoundButton()
        Me.btnCheckAvailabality = New WindowsApplication1.RoundButton()
        Me.btnSignUp = New WindowsApplication1.RoundButton()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Tai Le", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Ivory
        Me.lblWelcome.Location = New System.Drawing.Point(117, 33)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(943, 67)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Welcome to IITG Guest House Portal"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(328, 295)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(124, 40)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCheckAvailabality
        '
        Me.btnCheckAvailabality.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCheckAvailabality.FlatAppearance.BorderSize = 0
        Me.btnCheckAvailabality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckAvailabality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAvailabality.Location = New System.Drawing.Point(456, 295)
        Me.btnCheckAvailabality.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckAvailabality.Name = "btnCheckAvailabality"
        Me.btnCheckAvailabality.Size = New System.Drawing.Size(124, 40)
        Me.btnCheckAvailabality.TabIndex = 2
        Me.btnCheckAvailabality.Text = "Check Availability"
        Me.btnCheckAvailabality.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(200, 295)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(124, 40)
        Me.btnSignUp.TabIndex = 0
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ghover
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 346)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnCheckAvailabality)
        Me.Controls.Add(Me.btnSignUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "IITG Guest House Portal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSignUp As WindowsApplication1.RoundButton
    Friend WithEvents btnLogin As WindowsApplication1.RoundButton
    Friend WithEvents btnCheckAvailabality As WindowsApplication1.RoundButton
    Friend WithEvents lblWelcome As System.Windows.Forms.Label

End Class

Public Class RoundButton
    Inherits Button
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddArc(0, 0, ClientSize.Height, ClientSize.Height, 90, 180)
        grPath.AddLine(grPath.GetLastPoint, New Point(ClientSize.Width - grPath.GetLastPoint.X * 2, 0))
        grPath.AddArc(New RectangleF(grPath.GetLastPoint, New Size(ClientSize.Height, ClientSize.Height)), 270, 180)
        grPath.CloseFigure()
        Me.Region = New Region(grPath)
        MyBase.OnPaint(e)
    End Sub
End Class
