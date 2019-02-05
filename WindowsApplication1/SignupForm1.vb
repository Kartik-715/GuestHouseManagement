Imports System.Drawing.Drawing2D
Public Class SignupForm1
    Dim str As String
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
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
        If txtCaptcha.Text = str Then
            Dim userData As guestHouseDataSet.userTableRow
            userData = GuestHouseDataSet.userTable.FindByusername(txtUsername.Text)
            If userData Is Nothing Then
                UserTableBindingSource.EndEdit()
                UserTableTableAdapter.Update(GuestHouseDataSet.userTable)
                MsgBox("Register Success")
                Me.Close()
            Else
                MsgBox("User Already Exists! Please Try Again!")
                txtCaptcha.Clear()
                txtUsername.Clear()
                btnRefresh.PerformClick()
            End If
        Else
            MsgBox("Register Failed")
            txtCaptcha.Clear()
            btnRefresh.PerformClick()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UserTableBindingSource.RemoveCurrent()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        str = ""
        Dim R As New Random
        For i As Integer = 0 To 5
            str = str + NumCaptcha(R.Next(0, 60))
        Next
        Dim b As New Bitmap(141 * 2 / RW, 36 * 2 / RH, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim Hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        g.DrawString(str, New Font("Monotype Corsiva", 16 / RW, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 5 * RW, 5 * RH)
        picCaptcha.Image = b
    End Sub

    Private Sub SignupForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuestHouseDataSet.userTable' table. You can move, or remove it, as needed.
        Form1.Hide()
        max()
        Me.UserTableTableAdapter.Fill(Me.GuestHouseDataSet.userTable)
        UserTableBindingSource.AddNew()
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        str = ""
        Dim R As New Random
        For i As Integer = 0 To 5
            str = str + NumCaptcha(R.Next(0, 60))
        Next
        Dim b As New Bitmap(141 * 2 / RW, 36 * 2 / RH, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim Hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        g.DrawString(str, New Font("Monotype Corsiva", 26 / RW, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 5 * RW, 5 * RH)
        picCaptcha.Image = b
    End Sub

    Private Sub SignupForm1_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class
