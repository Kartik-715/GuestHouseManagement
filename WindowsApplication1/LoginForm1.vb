Public Class LoginForm1
    Private Sub max()
        'Adjusts our form based on screen resolution'
        Dim CW As Integer = Me.Width                ' Current Width
        Dim CH As Integer = Me.Height               ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1080)
        Dim RW As Double = (Me.Width - CW) / CW     ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH    ' Ratio change of height
        Dim min As Double = RW
        If RW > RH Then
            min = RH
        End If
        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            'Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * min), Ctrl.Font.Style)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim userData As guestHouseDataSet.userTableRow
        userData = GuestHouseDataSet.userTable.FindByusername(txtEmail.Text)
        'Userdata stores data of user with given EmailID if present

        If userData Is Nothing Then
            'Check if username doesn't exists
            MessageBox.Show("Username doesn't exist")
        Else
            If userData.password = SignupForm1.GenerateSHA256String(txtPassword.Text) Then
                'Matches stored hashed password with hash of input password
                If userData.isApproved = False Then
                    'If user is not approved by admin, no dashboard is displayed
                    MessageBox.Show("You have not been approved Yet!")
                Else
                    MessageBox.Show("Login Successful")
                    'if login is successful, we direct to different dashboards of user based on category of user
                    If userData.username = "admin" Or userData.Category = "Staff" Then
                        'Display Admin dashboard if user if admin or staff
                        AdminDashboard.loggedUser = userData.username
                        Check_Availability.loggedUser = userData.username
                        AdminDashboard.Show()
                    Else
                        'Display user dashboard for other users
                        Dashboard.loggedUser = userData.username
                        Check_Availability.loggedUser = userData.username
                        Dashboard.Show()
                    End If
                    Form1.Hide()
                    Me.Close()
                End If
            Else
                'If credentials are wrong
                MessageBox.Show("Wrong Password")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Closes form on click on Cancel
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        'TODO: This line of code loads data into the 'GuestHouseDataSet.userTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.GuestHouseDataSet.userTable)
    End Sub

    Private Sub PassButton_MouseDown(sender As Object, e As EventArgs) Handles PassButton.MouseDown
        'Makes password visible on holding mouse click'
        txtPassword.PasswordChar = ""
        PassButton.Image = My.Resources.eye             'changes image of eye
        PassButton.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PassButton_MouseLeave(sender As Object, e As EventArgs) Handles PassButton.MouseUp
        'Hides password on removing mouse click'
        txtPassword.PasswordChar = "*"
        PassButton.Image = My.Resources.vision_off      'changes image of eye
        PassButton.FlatStyle = FlatStyle.Popup
        PassButton.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        Me.Hide()
        forgotPass.Show()
    End Sub
    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles lblForgotPass.MouseHover
        Dim standardFont As Font = lblForgotPass.Font
        Dim underFont As New Font(standardFont, FontStyle.Underline)
        Me.lblForgotPass.Font = underFont
    End Sub
    Private Sub Label2_Mouseleave(sender As Object, e As EventArgs) Handles lblForgotPass.MouseLeave
        Dim standardFont As Font = lblForgotPass.Font
        Dim underFont As New Font(standardFont, FontStyle.Regular)
        Me.lblForgotPass.Font = underFont
    End Sub
End Class
