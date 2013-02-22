Public Class ZPForm

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Hide()
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 20
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 20
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 30
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 30
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Application.DoEvents()
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Button2.Show()
    End Sub

    Private Sub ZPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Рассчетная ведомость за " & Form2.NumberToMonth(Form1.curDate.Month)
        dZP.Rows.Add("", "", "Ремонтный цех")
        For i = 0 To dZP.ColumnCount - 1
            dZP.Item(i, dZP.RowCount - 1).Style.BackColor = Color.LightGray
        Next
        Dim cnt As Integer = 1
        For Each w In Worker.AllOfThem
            If w.GetWorkshopInt = 2 Then
                dZP.Rows.Add(w.GetID, Str(cnt), w.FullName, w.GetJob, CStr(Math.Round(w.HoursWorkedInCurMonth / w.GetNorm, 1)), "", CStr(w.GetSalary), CStr(w.wBonus), CStr(w.wOtherPayments), CStr(w.wAdvance), CStr(w.wOtherCharges), CStr(w.GetSalary + w.wBonus + w.wOtherPayments - w.wAdvance - w.wOtherCharges))
                cnt += 1
            End If
        Next
        dZP.Rows.Add("", "", "Моечный цех")
        For i = 0 To dZP.ColumnCount - 1
            dZP.Item(i, dZP.RowCount - 1).Style.BackColor = Color.LightGray
        Next
        For Each w In Worker.AllOfThem
            If w.GetWorkshopInt = 0 Then
                Form1.zpWorkshops.SelectedIndex = 0
                For i = 0 To 1000
                    If Form1.WorkerIDForzpWorkers(i) = w.GetID Then
                        Form1.zpWorkers.SelectedIndex = i
                        Application.DoEvents()
                        Exit For
                    End If
                Next
                dZP.Rows.Add(w.GetID, Str(cnt), w.FullName, w.GetJob, CStr(Math.Round(w.HoursWorkedInCurMonth / w.GetNorm, 1)), CStr(Math.Round(w.wNightSum)), CStr(w.GetSalary), CStr(w.wBonus), CStr(w.wOtherPayments), CStr(w.wAdvance), CStr(w.wOtherCharges), CStr(w.GetSalary + Math.Round(w.wNightSum) + w.wBonus + w.wOtherPayments - w.wAdvance - w.wOtherCharges))
                cnt += 1
            End If
        Next
        dZP.Rows.Add("", "", "Шиномонтажный цех")
        For i = 0 To dZP.ColumnCount - 1
            dZP.Item(i, dZP.RowCount - 1).Style.BackColor = Color.LightGray
        Next
        For Each w In Worker.AllOfThem
            If w.GetWorkshopInt = 1 Then
                dZP.Rows.Add(w.GetID, Str(cnt), w.FullName, w.GetJob, CStr(Math.Round(w.HoursWorkedInCurMonth / w.GetNorm, 1)), "", CStr(w.GetSalary), CStr(w.wBonus), CStr(w.wOtherPayments), CStr(w.wAdvance), CStr(w.wOtherCharges), CStr(w.GetSalary + w.wBonus + w.wOtherPayments - w.wAdvance - w.wOtherCharges))
                cnt += 1
            End If
        Next
        dZP.Height = dZP.ColumnHeadersHeight + dZP.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 4
        dZP.ClearSelection()
    End Sub

    Private Sub dZP_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dZP.CellEndEdit
        On Error Resume Next
        Dim w As Worker = Worker.FindByID(CInt(sender.item(0, e.RowIndex).value))
        Select Case e.ColumnIndex
            Case 6
                w.SetSalary(CLng(sender.item(e.ColumnIndex, e.RowIndex).value))
            Case 7
                w.wBonus = CDbl(sender.item(e.ColumnIndex, e.RowIndex).value)
            Case 8
                w.wOtherPayments = CDbl(sender.item(e.ColumnIndex, e.RowIndex).value)
            Case 9
                w.wAdvance = CDbl(sender.item(e.ColumnIndex, e.RowIndex).value)
            Case 10
                w.wOtherCharges = CDbl(sender.item(e.ColumnIndex, e.RowIndex).value)
            Case Else
                Exit Sub
        End Select
        sender.item(11, e.RowIndex).value = CStr(w.GetSalary + Math.Round(w.wNightSum) + w.wBonus + w.wOtherPayments - w.wAdvance - w.wOtherCharges)
    End Sub
End Class