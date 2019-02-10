Imports System.Runtime.InteropServices
Public Class UserControl_admindashboardnontabular

    <DllImport("user32.dll", EntryPoint:="SetProcessDPIAware")> _
    Private Shared Function SetProcessDPIAware() As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function


    Private Sub max()
        Dim CW As Integer = Me.Width ' Current Width
        Dim CH As Integer = Me.Height ' Current Height
        Me.Size = New Size(CW * Form1.Width / 1920, CH * Form1.Height / 1080)
        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height
        Dim min As Double = RW
        If RW > RH Then
            min = RH
        End If
        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            'Ctrl.Font = New Font(Ctrl.Font.Name, CInt(Ctrl.Font.Size * min), Ctrl.Font.Style)
        Next
        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub usercontrol_load(sender As Object, e As EventArgs) Handles MyBase.Load
        max()
        Try
            Me.UserTableTableAdapter.getNonApproved(Me.GuestHouseDataSet.userTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveReload_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If AdminDashboard.addremoveroom = 1 Then
            If rbtnAddARoomToService.Checked = True Then
                If rbtnIsVIP.Checked = True Then
                    RoomTableAdapter1.AddRoom(txtRoomNo.Text, True)
                Else
                    Try
                        RoomTableAdapter1.AddRoom(txtRoomNo.Text, False)
                    Catch ex As Exception
                        MsgBox("Room Already Exists!")
                    End Try
                End If
            Else
                RoomTableAdapter1.DeleteRoom(txtRoomNo.Text)
            End If
        End If
    End Sub
End Class