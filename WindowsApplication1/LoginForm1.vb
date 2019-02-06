Public Class LoginForm1
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim RW As Double = (screenWidth) / 1920 ' Ratio change of width
    Dim RH As Double = (screenHeight) / 1080 ' Ratio change of height
    Private Sub max()
        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next
        Me.Width = CInt(Me.Width * RW)
        Me.Height = CInt(Me.Height * RH)
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim userData As guestHouseDataSet.userTableRow
        userData = GuestHouseDataSet.userTable.FindByusername(UsernameTextBox.Text)
        If userData Is Nothing Then
            MessageBox.Show("Username doesn't exist")
        Else
            If userData.password = PasswordTextBox.Text Then
                MessageBox.Show("Login Successful")
                Dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong Password")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        'TODO: This line of code loads data into the 'GuestHouseDataSet.userTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.GuestHouseDataSet.userTable)
    End Sub

    Private Sub PassButton_MouseDown(sender As Object, e As EventArgs) Handles PassButton.MouseDown
        PasswordTextBox.PasswordChar = ""
        PassButton.Image = My.Resources.eye
        PassButton.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PassButton_MouseLeave(sender As Object, e As EventArgs) Handles PassButton.MouseUp
        PasswordTextBox.PasswordChar = "*"
        PassButton.Image = My.Resources.vision_off
        PassButton.FlatStyle = FlatStyle.Popup
        PassButton.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub LoginForm1_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        UserTableBindingSource.RemoveCurrent()
        Form1.Show()
    End Sub
End Class
