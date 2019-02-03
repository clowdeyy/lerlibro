Public Class ucUsers

    Sub disable()
        cboDept.Enabled = False
        txtName.Enabled = False
        txtUser.Enabled = False
        txtPass.Enabled = False
        txtConfirm.Enabled = False
        cboQues.Enabled = False
        txtAns.Enabled = False

    End Sub

    Sub enable()
        cboDept.Enabled = True
        txtName.Enabled = True
        txtUser.Enabled = True
        txtPass.Enabled = True
        txtConfirm.Enabled = True
        cboQues.Enabled = True
        txtAns.Enabled = True
    End Sub

    Private Sub ucUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disable()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        enable()
    End Sub
End Class
