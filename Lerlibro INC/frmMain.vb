Public Class frmMain
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If (MessageBox.Show("Are you sure to Exit?", "Exit from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If (MessageBox.Show("Are you sure to Exit?", "Exit from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMISPanel.ShowDialog()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class
