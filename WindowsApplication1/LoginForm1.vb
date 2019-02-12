Public Class LoginForm1
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

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim userData As guestHouseDataSet.userTableRow
        userData = GuestHouseDataSet.userTable.FindByusername(txtEmail.Text)
        If userData Is Nothing Then
            MessageBox.Show("Username doesn't exist")
        Else
            If userData.password = SignupForm1.GenerateSHA256String(txtPassword.Text) Then
                If userData.isApproved = False Then
                    MessageBox.Show("You have not been approved Yet!")
                Else
                    MessageBox.Show("Login Successful")
                    If userData.username = "admin" Or userData.Category = "Staff" Then
                        AdminDashboard.loggedUser = userData.username
                        Check_Availability.loggedUser = userData.username
                        AdminDashboard.Show()
                    Else
                        Dashboard.loggedUser = userData.username
                        Check_Availability.loggedUser = userData.username
                        Dashboard.Show()
                    End If
                    Form1.Hide()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Wrong Password")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        'lblLogin.Parent = PictureBoxGrey
        'TODO: This line of code loads data into the 'GuestHouseDataSet.userTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.GuestHouseDataSet.userTable)
    End Sub

    Private Sub PassButton_MouseDown(sender As Object, e As EventArgs) Handles PassButton.MouseDown
        txtPassword.PasswordChar = ""
        PassButton.Image = My.Resources.eye
        PassButton.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PassButton_MouseLeave(sender As Object, e As EventArgs) Handles PassButton.MouseUp
        txtPassword.PasswordChar = "*"
        PassButton.Image = My.Resources.vision_off
        PassButton.FlatStyle = FlatStyle.Popup
        PassButton.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub PassButton_MouseLeave(sender As Object, e As MouseEventArgs) Handles PassButton.MouseUp

    End Sub

    Private Sub PassButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PassButton.MouseDown

    End Sub
End Class
