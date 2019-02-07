Imports System.Drawing.Drawing2D
Public Class SignupForm1
    Dim str As String
    Dim RW As Double ' Ratio change of width
    Dim RH As Double ' Ratio change of height
    Private Sub max()
        Dim CW As Integer = Me.Width ' Current Width
        Dim CH As Integer = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1080)
        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            If TypeOf Ctrl Is Label Then
                'Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * RW), Ctrl.Font.Style)
            End If
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtCaptcha.Text = str Then
            Dim userData As guestHouseDataSet.userTableRow
            userData = GuestHouseDataSet.userTable.FindByusername(txtUsername.Text)
            If userData Is Nothing Then
                UserTableBindingSource.EndEdit()
                UserTableTableAdapter.Update(GuestHouseDataSet.userTable)
                UserTableTableAdapter.changeApprovalStatus(False, txtUsername.Text)
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
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        str = ""
        Dim R As New Random
        For i As Integer = 0 To 5
            str = str + NumCaptcha(R.Next(0, 60))
        Next
        Dim b As New Bitmap(141 * 2, 36 * 2, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim Hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        g.DrawString(str, New Font("Monotype Corsiva", 26, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 5, 5)
        picCaptcha.Image = b
    End Sub

    Private Sub SignupForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuestHouseDataSet.userTable' table. You can move, or remove it, as needed.
        max()
        Me.UserTableTableAdapter.Fill(Me.GuestHouseDataSet.userTable)
        UserTableBindingSource.AddNew()
        btnRefresh.PerformClick()
    End Sub

    Private Sub SignupForm1_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        UserTableBindingSource.RemoveCurrent()
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub lblMobileNo_Click(sender As Object, e As EventArgs) Handles lblMobileNo.Click

    End Sub

    Private Sub lblCategory_Click(sender As Object, e As EventArgs) Handles lblCategory.Click

    End Sub

    Private Sub lblConfirmPassword_Click(sender As Object, e As EventArgs) Handles lblConfirmPassword.Click

    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub

    Private Sub picCaptcha_Click(sender As Object, e As EventArgs) Handles picCaptcha.Click

    End Sub

    Private Sub lblCaptcha_Click(sender As Object, e As EventArgs) Handles lblCaptcha.Click

    End Sub

    Private Sub txtCaptcha_TextChanged(sender As Object, e As EventArgs) Handles txtCaptcha.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
