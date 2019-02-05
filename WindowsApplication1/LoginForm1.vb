Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim userData As guestHouseDataSet.userTableRow
        userData = GuestHouseDataSet.userTable.FindByusername(UsernameTextBox.Text)
        If userData Is Nothing Then
            MessageBox.Show("Username doesn't exist")
        Else
            If userData.password = PasswordTextBox.Text Then
                MessageBox.Show("Login Successful")
                Me.Close()
            Else
                MessageBox.Show("Wrong Password")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuestHouseDataSet.userTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.GuestHouseDataSet.userTable)
    End Sub
End Class
