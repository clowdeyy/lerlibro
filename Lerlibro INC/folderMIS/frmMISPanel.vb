Public Class frmMISPanel
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim users As New ucUsers
        toPanelMIS(users.Width, users.Height, users)

        sidePanel.Height = btnUser.Height()
        sidePanel.Top = btnUser.Top()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        sidePanel.Height = btnLogout.Height()
        sidePanel.Top = btnLogout.Top()
        If (MessageBox.Show("Are you sure to Exit?", "Exit from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            frmMain.txtUsername.Text = ""
            frmMain.txtPassword.Text = ""
            frmMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lblTime_TextChanged(sender As Object, e As EventArgs) Handles lblTime.TextChanged
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss dddd, dd MMMM yyyy")
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss dddd, dd MMMM yyyy")
    End Sub
End Class