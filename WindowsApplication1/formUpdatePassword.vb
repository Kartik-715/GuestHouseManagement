Public Class formUpdatePassword

    Public loggedUser As String                             ' string to store logged in user 
    Public forgottenPassword As Boolean = False             ' boolena if forgot password

    Private Sub max()
        ' function adjusts form in different resolutions
        Dim CW As Integer = Me.Width ' Current Width
        Dim CH As Integer = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1024)
        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height
        Dim min As Double = RW
        If RW > RH Then
            min = RH
        End If
        For Each Ctrl As Control In Controls
            'Adjsut all controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            'Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * min), Ctrl.Font.Style)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub formUpdatePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        lblHello.Text = "Hello! " & loggedUser                      ' display logged in user 
        If forgottenPassword Then
            txtOldPass.ReadOnly = True
            txtOldPass.Text = "*************"
            'dummy old password already filled if directed for new password change during recovery
        End If
    End Sub

    Private Sub btnUpdatePass_Click(sender As Object, e As EventArgs) Handles btnUpdatePass.Click
        If forgottenPassword Then
            ' if forgotten password
            If txtNewPass.Text = txtConfirmNewPass.Text Then
                UserTableTableAdapter.UpdatePassword(SignupForm1.GenerateSHA256String(txtNewPass.Text), loggedUser)
                ' store hash of new inuput password
                ForgotPassTableAdapter.DeleteToken(loggedUser)          ' delete token after used
                forgottenPassword = False
                MessageBox.Show("Password changed successfully!")
                Me.Close()
                LoginForm1.Show()
            Else
                MessageBox.Show("New passwords dont match!")
            End If
        Else
            ' normal update password
            'matching hash of input old password with hashed value stored in database
            If UserTableTableAdapter.getPassword(loggedUser) = SignupForm1.GenerateSHA256String(txtOldPass.Text) Then
                If txtNewPass.Text = txtConfirmNewPass.Text Then
                    'matching both textboxes of new password
                    UserTableTableAdapter.UpdatePassword(SignupForm1.GenerateSHA256String(txtNewPass.Text), loggedUser)
                    MessageBox.Show("Password changed successfully!")
                    Me.Close()
                    If loggedUser = "Admin" Then
                        AdminDashboard.Show()
                    Else
                        Dashboard.Show()
                    End If
                Else
                    MessageBox.Show("New passwords dont match!")
                End If
            Else
                MessageBox.Show("Incorrect password!")
            End If
        End If
    End Sub
    'function to show password on holding mouse click'
    Private Sub PassButton1_MouseDown(sender As Object, e As EventArgs) Handles PassButton1.MouseDown
        txtOldPass.PasswordChar = ""
        PassButton1.Image = My.Resources.eye
        PassButton1.FlatStyle = FlatStyle.Flat
    End Sub
    'function to show password on leave mouse click'
    Private Sub PassButton1_MouseLeave(sender As Object, e As EventArgs) Handles PassButton1.MouseUp
        txtOldPass.PasswordChar = "*"
        PassButton1.Image = My.Resources.vision_off
        PassButton1.FlatStyle = FlatStyle.Popup
        PassButton1.FlatAppearance.BorderSize = 0
    End Sub

    'Similarly repeated functions for other eye buttons
    Private Sub PassButton2_MouseDown(sender As Object, e As EventArgs) Handles PassButton2.MouseDown
        txtNewPass.PasswordChar = ""
        PassButton2.Image = My.Resources.eye
        PassButton2.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PassButton2_MouseLeave(sender As Object, e As EventArgs) Handles PassButton2.MouseUp
        txtNewPass.PasswordChar = "*"
        PassButton2.Image = My.Resources.vision_off
        PassButton2.FlatStyle = FlatStyle.Popup
        PassButton2.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub PassButton3_MouseDown(sender As Object, e As EventArgs) Handles PassButton3.MouseDown
        txtConfirmNewPass.PasswordChar = ""
        PassButton3.Image = My.Resources.eye
        PassButton3.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PassButton3_MouseLeave(sender As Object, e As EventArgs) Handles PassButton3.MouseUp
        txtConfirmNewPass.PasswordChar = "*"
        PassButton3.Image = My.Resources.vision_off
        PassButton3.FlatStyle = FlatStyle.Popup
        PassButton3.FlatAppearance.BorderSize = 0
    End Sub

End Class