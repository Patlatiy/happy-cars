Public Class frmLogin
    Dim log As Boolean = False
    Dim rights As Form1.WriteRights = Form1.WriteRights.Read_Only
    Dim curHash As Integer



    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show(rights, log)
        Form1.LoadProcedure(DateTime.Now)
        Form1.LOADING = False
        Form1.BringToFront()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load    
        For Each tmpSTR As String In My.Application.CommandLineArgs()
            tmpSTR = tmpSTR.ToLower
            Select Case tmpSTR
                Case "-log"
                    log = True
            End Select
        Next
        'Form1.Show(rights, log)
        'Me.Dispose()
        Dim pswFile As String = Application.StartupPath & "\data\hash"
        If My.Computer.FileSystem.FileExists(pswFile) Then
            LoadHashes()
        Else
            MsgBox("Файл с паролями не найден. Пожалуйста, установите пароли.", MsgBoxStyle.Exclamation, "Внимание!")
            frmManagePasswords.Show(Me)
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtPass.Text = "" Then
            btnEnterReadOnly_Click(sender, e)
            Exit Sub
        End If
        curHash = txtPass.Text.GetHashCode
        Select Case curHash
            Case masterHash
                rights = Form1.WriteRights.Master
                Close()
            Case girlHash
                rights = Form1.WriteRights.The_Girl
                Close()
            Case bkHash
                rights = Form1.WriteRights.Bookkeeper
                Close()
            Case Else
                txtPass.Text = ""
                MsgBox("Неверный пароль. Попробуйте ещё раз.", MsgBoxStyle.Critical, "Ошибка!")
        End Select
    End Sub

    Private Sub btnEnterReadOnly_Click(sender As Object, e As EventArgs) Handles btnEnterReadOnly.Click
        Form1.Show(Form1.WriteRights.Read_Only, log)
        Close()
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form1.Hide()
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEnter_Click(sender, e:=New System.EventArgs)
        End If
    End Sub
End Class