Imports System.Drawing.Drawing2D
Public Class SignupForm1
    Dim str As String
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtCaptcha.Text = str Then
            UserTableBindingSource.EndEdit()
            UserTableTableAdapter.Update(GuestHouseDataSet.userTable)
            MsgBox("Register Success")
            Me.Close()
        Else
            MsgBox("Register Failed")
            btnRefresh.PerformClick()
            txtCaptcha.Clear()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UserTableBindingSource.RemoveCurrent()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        str = ""
        Dim R As New Random
        For i As Integer = 0 To 5
            str = str + NumCaptcha(R.Next(0, 60))
        Next
        Dim b As New Bitmap(141, 36, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim Hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        g.DrawString(str, New Font("Monotype Corsiva", 16, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 5, 5)
        picCaptcha.Image = b
    End Sub

    Private Sub picCaptcha_Click(sender As Object, e As EventArgs) Handles picCaptcha.Click

    End Sub

    Private Sub SignupForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuestHouseDataSet.userTable' table. You can move, or remove it, as needed.
        Me.UserTableTableAdapter.Fill(Me.GuestHouseDataSet.userTable)
        UserTableBindingSource.AddNew()
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        str = ""
        Dim R As New Random
        For i As Integer = 0 To 5
            str = str + NumCaptcha(R.Next(0, 60))
        Next
        Dim b As New Bitmap(141, 36, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim Hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        g.DrawString(str, New Font("Monotype Corsiva", 16, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 5, 5)
        picCaptcha.Image = b
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub
End Class
