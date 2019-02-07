Public Class formUpdatePassword

    Public loggedUser As String

    Private Sub formUpdatePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHello.Text = "Hello! " & loggedUser
    End Sub

    Private Sub btnUpdatePass_Click(sender As Object, e As EventArgs) Handles btnUpdatePass.Click
        Console.WriteLine("hi" & UserTableTableAdapter.getPassword(loggedUser))
        If txtOldPass.Text = UserTableTableAdapter.getPassword(loggedUser) Then
            If txtNewPass.Text = txtConfirmNewPass.Text Then
                UserTableTableAdapter.UpdatePassword(txtNewPass.Text, loggedUser)
                MessageBox.Show("Password changed successfully!")
                Me.Close()
                Dashboard.Show()
            Else
                MessageBox.Show("New passwords dont match!")
            End If
        Else
            MessageBox.Show("Incorrect password!")
        End If
    End Sub
End Class