Public Class formUpdatePassword

    Public loggedUser As String
    Public forgottenPassword As Boolean = False

    Dim CW As Integer ' Current Width
    Dim CH As Integer  ' Current Height
    Dim RW As Double  ' Ratio change of width
    Dim RH As Double  ' Ratio change of height
    Dim min As Double
    Private Sub max()
        CW = Me.Width ' Current Width
        CH = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1080)
        RW = (Me.Width - CW) / CW ' Ratio change of width
        RH = (Me.Height - CH) / CH ' Ratio change of height
        min = RW
        If RW > RH Then
            min = RH
        End If
        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            If TypeOf Ctrl Is TextBox Then
                Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * (min + 1)), Ctrl.Font.Style)
            End If
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub formUpdatePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        lblHello.Text = "Hello! " & loggedUser
        If forgottenPassword Then
            txtOldPass.ReadOnly = True
            txtOldPass.Text = "asdkasjdkasjd"
        End If
    End Sub

    Private Sub btnUpdatePass_Click(sender As Object, e As EventArgs) Handles btnUpdatePass.Click
        If forgottenPassword Then
            If txtNewPass.Text = txtConfirmNewPass.Text Then
                UserTableTableAdapter.UpdatePassword(SignupForm1.GenerateSHA256String(txtNewPass.Text), loggedUser)
                ForgotPassTableAdapter.DeleteToken(loggedUser)
                forgottenPassword = False
                MessageBox.Show("Password changed successfully!")
                Me.Close()
                LoginForm1.Show()
            Else
                MessageBox.Show("New passwords dont match!")
            End If
        Else
            If UserTableTableAdapter.getPassword(loggedUser) = SignupForm1.GenerateSHA256String(txtOldPass.Text) Then
                If txtNewPass.Text = txtConfirmNewPass.Text Then
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
    Private Sub PassButton1_MouseDown(sender As Object, e As EventArgs) Handles PassButton1.MouseDown
        txtOldPass.PasswordChar = ""
        PassButton1.Image = My.Resources.eye
        PassButton1.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PassButton1_MouseLeave(sender As Object, e As EventArgs) Handles PassButton1.MouseUp
        txtOldPass.PasswordChar = "*"
        PassButton1.Image = My.Resources.vision_off
        PassButton1.FlatStyle = FlatStyle.Popup
        PassButton1.FlatAppearance.BorderSize = 0
    End Sub
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


    Private Sub PassButton1_MouseLeave(sender As Object, e As MouseEventArgs) Handles PassButton1.MouseUp

    End Sub
    Private Sub PassButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles PassButton1.MouseDown

    End Sub
    Private Sub PassButton2_MouseLeave(sender As Object, e As MouseEventArgs) Handles PassButton2.MouseUp

    End Sub
    Private Sub PassButton2_MouseDown(sender As Object, e As MouseEventArgs) Handles PassButton2.MouseDown

    End Sub
    Private Sub PassButton3_MouseLeave(sender As Object, e As MouseEventArgs) Handles PassButton3.MouseUp

    End Sub
    Private Sub PassButton3_MouseDown(sender As Object, e As MouseEventArgs) Handles PassButton3.MouseDown

    End Sub
End Class