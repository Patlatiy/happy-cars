﻿Public Class frmLog
    Public Sub Clear()
        txtLog.Text = ""
    End Sub

    Public Sub Add(Text As String)
        If Me.Visible Then txtLog.Text = "(" & Date.Now.ToString("hh:mm:ss") & ") " & Text & vbNewLine & txtLog.Text
    End Sub
End Class