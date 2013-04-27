Public Class frmManagePasswords
    Dim MyOwner As Object
    Dim bMasterChanged As Boolean = False
    Dim bGirlChanged As Boolean = False
    Dim bBKChanged As Boolean = False

    Public Overloads Sub Show(owner As System.Windows.Forms.IWin32Window)
        Me.Show()
        MyOwner = owner
        MyOwner.Enabled = False
        If MyOwner Is Form1 Then
            txtBKPassword.Text = "*****"
            txtGirlPassword.Text = txtBKPassword.Text
            txtMasterPassword.Text = txtBKPassword.Text
            txtMasterPassword.SelectAll()
            txtMasterPassword.Focus()
        End If
        AddHandler txtMasterPassword.TextChanged, AddressOf MasterChanged
        AddHandler txtGirlPassword.TextChanged, AddressOf GirlChanged
        AddHandler txtBKPassword.TextChanged, AddressOf BKChanged
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtMasterPassword.Text = "" Or txtGirlPassword.Text = "" Or txtBKPassword.Text = "" Then
            MsgBox("Пароли не могут быть пустыми.", MsgBoxStyle.Critical, "Ошибка!")
            Exit Sub
        End If
        If bMasterChanged Then masterHash = txtMasterPassword.Text.GetHashCode
        If bGirlChanged Then girlHash = txtGirlPassword.Text.GetHashCode
        If bBKChanged Then bkHash = txtBKPassword.Text.GetHashCode
        Dim pswFile As String = Application.StartupPath & "\data\hash"
        Dim content As String = ""
        content &= masterHash.ToString & vbNewLine
        content &= girlHash.ToString & vbNewLine
        content &= bkHash.ToString
        My.Computer.FileSystem.WriteAllText(pswFile, content, False)
        Close()
    End Sub

    Private Sub frmManagePasswords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MyOwner.Enabled = True
        MyOwner.BringToFront()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub MasterChanged()
        If Not bMasterChanged Then bMasterChanged = True
    End Sub

    Private Sub GirlChanged()
        If Not bGirlChanged Then bGirlChanged = True
    End Sub

    Private Sub BKChanged()
        If Not bBKChanged Then bBKChanged = True
    End Sub
End Class