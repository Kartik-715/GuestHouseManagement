Public Class formUpdatePassword

    Public loggedUser As String

    Private Sub max()
        Dim CW As Integer = Me.Width ' Current Width
        Dim CH As Integer = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1500, CH * Form1.Height / 1024)
        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * RW), Ctrl.Font.Style)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub formUpdatePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
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