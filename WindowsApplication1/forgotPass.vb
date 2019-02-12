Imports System.Net.Mail
Public Class forgotPass

    Dim CW As Integer ' Current Width
    Dim CH As Integer  ' Current Height
    Dim RW As Double  ' Ratio change of width
    Dim RH As Double  ' Ratio change of height
    Dim min As Double

    'Function to adjust form in all resolutions
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
            'Adjusts all controls of form
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

    Private Function genToken() As String
        'Function to generate token for password recovery
        Dim AllLetters As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim Str As String = ""
        Dim R As New Random
        'Random function used
        For i As Integer = 0 To 10
            Str = Str + AllLetters(R.Next(0, 60))
        Next
        Return Str
        'Returns a random string of length 10
    End Function

    Private Function sendMail(token As String, email As String) As String
        'Function to send mail to user for password recovery
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        'Set values for smtp server to send mail
        Smtp_Server.UseDefaultCredentials = False
        'Credentails of emailID to send mail from
        Smtp_Server.Credentials = New Net.NetworkCredential("iitgguesthouse@gmail.com", "MMMM1234")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.gmail.com"
        'Details of Email
        e_mail = New MailMessage()
        e_mail.From = New MailAddress("iitgguesthouse@gmail.com")
        e_mail.To.Add(email)
        e_mail.Subject = "Password Recovery"
        e_mail.IsBodyHtml = False
        ' Passing a random token
        e_mail.Body = "Enter This Token into the App: " & token & " Do Not Share With Anyone!" 'Body Here' 
        Smtp_Server.Send(e_mail)                    'Sending mail
    End Function

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click
        Dim Rows As guestHouseDataSet.userTableDataTable
        Dim user As guestHouseDataSet.userTableRow
        Rows = UserTableTableAdapter1.GetUserData(txtEmail.Text)
        ' Loading data of user in table 
        If Rows.Rows.Count = 0 Then
            'Checking if email is unregistered
            MsgBox("Email Not Registered!")
        Else
            user = Rows.Rows(0)
            Dim token As String = genToken()
            If ForgotPassTableAdapter.getToken(txtEmail.Text) <> Nothing Then
                'if database doesn't contain token against username
                Dim question As Integer
                question = MessageBox.Show("Already Sent the Token! Do You Want to Resend the Token", "Want To Resend", MessageBoxButtons.YesNo)

                If question = vbNo Then

                Else
                    'Sending a new token again
                    ForgotPassTableAdapter.DeleteToken(txtEmail.Text)
                    btnForgot.PerformClick()
                End If
            Else
                Try
                    sendMail(token, txtEmail.Text) ' Send Mail ' 
                    ForgotPassTableAdapter.insertToken(txtEmail.Text, token)        'inserting token in database
                    MsgBox("Token Generated! Please Check Your Mail!")
                    txtOTP.Show()                   ' textbox to input OTP
                    lblOTP.Show()
                    btnVerify.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If

    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim Rows As guestHouseDataSet.userTableDataTable
        Dim user As guestHouseDataSet.userTableRow
        Rows = UserTableTableAdapter1.GetUserData(txtEmail.Text)
        'Loading details of user

        If Rows.Rows.Count = 0 Then
            MsgBox("Email Not Registered!")
        Else
            user = Rows.Rows(0)
            If ForgotPassTableAdapter.getToken(user.username) = txtOTP.Text Then
                'Allow Him to Generate New Password!'
                formUpdatePassword.forgottenPassword = True
                formUpdatePassword.loggedUser = user.username
                Me.Close()
                formUpdatePassword.Show()
            Else
                'if input token value doesn't match
                MsgBox("Invalid Token!")
            End If
        End If
    End Sub

    Private Sub forgotPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
    End Sub

End Class