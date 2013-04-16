Public Class frmExecutor
    Private MyExecutor As HCExecutor
    Private MyOwner As Windows.Forms.Form

    Public Overloads Sub Show(ByRef Executor As HCExecutor, Owner As Windows.Forms.Form)
        Me.Show()
        txt1stName.Text = Executor.FirstName
        txtLastName.Text = Executor.LastName
        txtPatron.Text = Executor.Patronage
        txtPhone.Text = Executor.Phone
        MyExecutor = Executor
        MyOwner = Owner
        MyOwner.Enabled = False
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MyExecutor.FirstName = txt1stName.Text
        MyExecutor.LastName = txtLastName.Text
        MyExecutor.Patronage = txtPatron.Text
        MyExecutor.Phone = txtPhone.Text
        MyOwner.Enabled = True
        If MyOwner Is frmNewOrder Then
            frmNewOrder.RefreshExecutors(MyExecutor)
        End If
        Close()
    End Sub
End Class