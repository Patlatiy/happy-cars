Public Class frmExecutor
    Private MyExecutor As HCExecutor
    Private MyOwner As Windows.Forms.Form

    Public Overloads Sub Show(ByRef Executor As HCExecutor, Owner As Windows.Forms.Form)
        Me.Show()
        txt1stName.Text = Executor.FirstName
        txtLastName.Text = Executor.LastName
        txtPatron.Text = Executor.Patronage
        txtPhoneCode.Text = Executor._Code
        txtPhone.Text = Executor._Phone
        MyExecutor = Executor
        MyOwner = Owner
        MyOwner.Enabled = False
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MyExecutor.FirstName = txt1stName.Text
        MyExecutor.LastName = txtLastName.Text
        MyExecutor.Patronage = txtPatron.Text
        MyExecutor.Phone = "+7 (" & txtPhoneCode.Text.Trim & ") " & txtPhone.Text.Trim
        Close()
    End Sub

    Private Sub frmExecutor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MyExecutor.FirstName = "" And MyExecutor.LastName = "" And MyExecutor.Patronage = "" Then HCExecutor.ExecList.Remove(MyExecutor)
        MyOwner.Enabled = True
        If MyOwner Is frmNewOrder Then
            frmNewOrder.RefreshExecutors(MyExecutor)
        End If
    End Sub

    Private Sub txtPhoneCode_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneCode.TextChanged
        If txtPhoneCode.Text(0) = "9" And txtPhoneCode.Text.Length = 3 Then
            txtPhone.Focus()
        ElseIf txtPhoneCode.Text = "4852" Then
            txtPhone.Focus()
        ElseIf txtPhoneCode.Text.Length = 4 Then
            txtPhone.Focus()
        End If
    End Sub
End Class
