Public Class DebtForm
    Dim curID As Integer = 1

    Private Sub DebtForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim DirPath As String = Application.StartupPath & "\data\" & CStr(Form1.curDate.Year) & "\" & CStr(Form1.curDate.Month) & "\"
        For j = 1 To Date.DaysInMonth(Form1.curDate.Year, Form1.curDate.Month)
            Dim DayFilePath As String = DirPath & CStr(j) & ".ini"
            Dim NightFilePath As String = DirPath & CStr(j) & "N.ini"
            Dim MountFilePath As String = DirPath & CStr(j) & "m.ini"
            Dim ServiceFilePath As String = DirPath & CStr(j) & "s.ini"
            Dim curRow As String()
            If My.Computer.FileSystem.FileExists(DayFilePath) Then
                Using DayFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(DayFilePath)
                    DayFile.TextFieldType = FileIO.FieldType.Delimited
                    DayFile.SetDelimiters("|")
                    While Not DayFile.EndOfData
                        curRow = DayFile.ReadFields
                        For i As ULong = 0 To Form1.NextDebtID
                            If j = Form1.DebtID(i, 0) And curRow(7) = CStr(Form1.DebtID(i, 1)) Then
                                dWashDebt.Rows.Add(CStr(i), CStr(curID), CStr(j) & "." & CStr(Form1.curDate.Month) & "." & CStr(Form1.curDate.Year), curRow(1), curRow(3), curRow(4), curRow(6), "Закрыть")
                                curID += 1
                            End If
                        Next
                    End While
                End Using
            End If
            If My.Computer.FileSystem.FileExists(NightFilePath) Then
                Using NightFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(NightFilePath)
                    NightFile.TextFieldType = FileIO.FieldType.Delimited
                    NightFile.SetDelimiters("|")
                    NightFile.ReadFields()
                    While Not NightFile.EndOfData
                        curRow = NightFile.ReadFields
                        For i As ULong = 0 To Form1.NextDebtID
                            If j = Form1.DebtID(i, 0) And curRow(7) = CStr(Form1.DebtID(i, 1)) Then
                                dWashDebt.Rows.Add(CStr(i), CStr(curID), CStr(j) & "." & CStr(Form1.curDate.Month) & "." & CStr(Form1.curDate.Year), curRow(1), curRow(3), curRow(4), curRow(6), "Закрыть")
                                curID += 1
                            End If
                        Next
                    End While
                End Using
            End If
            curID = 1
            If My.Computer.FileSystem.FileExists(MountFilePath) Then
                Using MountFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(MountFilePath)
                    MountFile.TextFieldType = FileIO.FieldType.Delimited
                    MountFile.SetDelimiters("|")
                    While Not MountFile.EndOfData
                        curRow = MountFile.ReadFields
                        For i As ULong = 0 To Form1.NextDebtID
                            If j = Form1.DebtID(i, 0) And curRow(7) = CStr(Form1.DebtID(i, 1)) Then
                                dMountDebt.Rows.Add(CStr(i), CStr(curID), CStr(j) & "." & CStr(Form1.curDate.Month) & "." & CStr(Form1.curDate.Year), curRow(1), curRow(3), curRow(4), curRow(6), "Закрыть")
                                curID += 1
                            End If
                        Next
                    End While
                End Using
            End If
            curID = 1
            If My.Computer.FileSystem.FileExists(ServiceFilePath) Then
                Using ServiceFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(ServiceFilePath)
                    ServiceFile.TextFieldType = FileIO.FieldType.Delimited
                    ServiceFile.SetDelimiters("|")
                    While Not ServiceFile.EndOfData
                        curRow = ServiceFile.ReadFields
                        For i As ULong = 0 To Form1.NextDebtID
                            If j = Form1.DebtID(i, 0) And curRow(9) = CStr(Form1.DebtID(i, 1)) Then
                                dServiceDebt.Rows.Add(CStr(i), CStr(curID), CStr(j) & "." & CStr(Form1.curDate.Month) & "." & CStr(Form1.curDate.Year), curRow(2), curRow(3), curRow(4), CStr(CInt(curRow(5)) + CInt(curRow(7))), "Закрыть")
                                curID += 1
                            End If
                        Next
                    End While
                End Using
            End If
        Next
    End Sub

    Private Sub dWashDebt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dWashDebt.CellContentClick, dMountDebt.CellContentClick, dServiceDebt.CellContentClick
        If e.ColumnIndex = 7 Then
            Form1.AddCash("Погашение долга", sender.Item(6, e.RowIndex).value, "0", "За " & sender.item(2, e.RowIndex).value & ", " & sender.item(3, e.RowIndex).value & " " & sender.item(4, e.RowIndex).value & ". " & sender.item(5, e.RowIndex).value)
            Form1.RemoveDebt(CInt(sender.item(0, e.RowIndex).value))
            sender.Rows.RemoveAt(e.RowIndex)
            RecountRows()
        End If
    End Sub

    Private Sub RecountRows()
        For i = 0 To dWashDebt.RowCount - 1
            dWashDebt.Item(1, i).Value = i + 1
        Next
        For i = 0 To dMountDebt.RowCount - 1
            dMountDebt.Item(1, i).Value = i + 1
        Next
        For i = 0 To dServiceDebt.RowCount - 1
            dServiceDebt.Item(1, i).Value = i + 1
        Next
    End Sub
End Class