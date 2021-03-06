﻿Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Public Class SignupForm1
    Dim str As String
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint      'Function for overlaying teal on background image
        Dim brushy As Brush
        brushy = New Drawing.SolidBrush(Color.FromArgb(100, 0, 128, 128))
        e.Graphics.FillRectangle(brushy, Me.ClientRectangle)
    End Sub

    'Function to resize the form according to screen resolution
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
        If IsValidEmailFormat(txtUsername.Text) = False Then        'validating Email Address
            MsgBox("Invalid Email Address")
            txtUsername.Clear()
            btnRefresh.PerformClick()
        ElseIf txtFirName.Text = "" Then
            MsgBox("Invalid First Name")
            txtFirName.Clear()
            btnRefresh.PerformClick()
        ElseIf IsPhoneNumberValid(txtPhone.Text) = False Then       'validating Phone number
            MsgBox("Invalid Phone Number")
            txtPhone.Clear()
            btnRefresh.PerformClick()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Invalid Password")
            txtPassword.Clear()
            btnRefresh.PerformClick()
        ElseIf txtPassword.Text = txtConfirmPassword.Text Then
            If txtCaptcha.Text = str Then                           'validating Captcha text
                Dim userData As guestHouseDataSet.userTableRow
                userData = GuestHouseDataSet.userTable.FindByusername(txtUsername.Text)         'checking if user already exists in the data set
                If userData Is Nothing Then
                    txtPassword.Text = GenerateSHA256String(txtPassword.Text)
                    txtConfirmPassword.Text = GenerateSHA256String(txtConfirmPassword.Text)
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
        Else
            MsgBox("Passfields Are Not Matching")
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            btnRefresh.PerformClick()
        End If


    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click       'removing the entry that could have been made in data set if cancel had not been clicked
        UserTableBindingSource.RemoveCurrent()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click     'function for generating Captcha
        Dim NumCaptcha As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"      'String from which captcha will be picked randomly
        str = ""
        Dim R As New Random
        For i As Integer = 0 To 5
            str = str + NumCaptcha(R.Next(0, 60))       'generating captcha string
        Next
        Dim b As New Bitmap(141 * 2, 36 * 2, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(b)
        Dim Hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        g.DrawString(str, New Font("Monotype Corsiva", 26, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 5, 5)
        picCaptcha.Image = b            'generating captcha image from the string
    End Sub

    Private Sub SignupForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load      'things to do when form loads
        'TODO: This line of code loads data into the 'GuestHouseDataSet.userTable' table. You can move, or remove it, as needed.
        max()
        Me.UserTableTableAdapter.Fill(Me.GuestHouseDataSet.userTable)
        UserTableBindingSource.AddNew()                                     'add new entry in the data set which is to be filled
        LblEmail1.Visible = False
        lblValidatioMessage.Visible = False
        btnRefresh.PerformClick()
        lblSignUp.Parent = LogoPictureBox
    End Sub

    Private Sub SignupForm1_closing(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        UserTableBindingSource.RemoveCurrent()              'removing the entry that could have been made in data set if cancel had not been clicked
    End Sub

    Public Shared Function GenerateSHA256String(ByVal inputString) As String        'function to generate hash values of passwords
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

    Public Function IsValidEmailFormat(ByVal s As String) As Boolean        'function to Valiadate email
        Return Regex.IsMatch(s, "^[A-Z0-9a-z._%+-]+[@][A-Za-z0-9-]+[.][a-z.]+$")
    End Function


    Protected Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged   'fn to valiadate number 
        If Not IsPhoneNumberValid(txtPhone.Text) Then
            Dim isvalid = False
            lblValidatioMessage.Visible = True
            lblValidatioMessage.Text = "!!"
        Else
            lblValidatioMessage.Visible = False
            lblValidatioMessage.Text = ""
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged 'Alerting user of wrong email
        If IsValidEmailFormat(txtUsername.Text) = True Then

            LblEmail1.Visible = False
            LblEmail1.Text = ""

        Else
            LblEmail1.Visible = True
            LblEmail1.Text = "!!"

        End If
    End Sub

    Private Shared Function IsPhoneNumberValid(phoneNumber As String) As Boolean
        Dim result As String = ""
        Dim chars As Char() = phoneNumber.ToCharArray()
        For count = 0 To chars.GetLength(0) - 1
            Dim tempChar As Char = chars(count)
            If [Char].IsDigit(tempChar) Or "".Contains(tempChar.ToString()) Then

                result += StripNonAlphaNumeric(tempChar)
            Else
                Return False
            End If

        Next

        Return result.Length = 10 'Length of US phone numbers is 10
    End Function

    Private Shared Function StripNonAlphaNumeric(value As String) As String
        Dim regex = New Regex("[^0-9a-zA-Z]", RegexOptions.None)
        Dim result As String = ""
        If regex.IsMatch(value) Then
            result = regex.Replace(value, "")
        Else
            result = value
        End If

        Return result
    End Function

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress 'Alerting users of wrong number
        If Asc(e.KeyChar) = 8 Then
        ElseIf (txtPhone.Text).Length = 10 Then
            e.Handled = True
        ElseIf (txtPhone.Text).Length = 0 And e.KeyChar = "0" Then
            e.Handled = True
        End If
    End Sub
End Class
