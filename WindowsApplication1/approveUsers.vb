Public Class approveUsers

    Private Sub approveUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.UserTableTableAdapter.getNonApproved(Me.GuestHouseDataSet.userTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        UserTableTableAdapter.Update(Me.GuestHouseDataSet.userTable)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnSaveReload_Click(sender As Object, e As EventArgs) Handles btnSaveReload.Click
        Dim ans As DialogResult
        ans = MessageBox.Show("Are You Sure?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            btnSaveChanges.PerformClick()
            Try
                Me.UserTableTableAdapter.getNonApproved(Me.GuestHouseDataSet.userTable)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class