Public Class AdvanceForm
    Dim WorkerIDForComboBox1(1000) As Integer
    Dim count As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Hide()
        ComboBox1.Hide()
        ComboBox2.Hide()
        dAdvance.ClearSelection()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Application.DoEvents()
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Application.DoEvents()
        Button2.Show()
        ComboBox1.Show()
        ComboBox2.Show()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub AdvanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Аванс за " & frmReport.NumberToMonth(Form1.curDate.Month)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim w As Worker = Worker.FindByID(WorkerIDForComboBox1(sender.selectedindex))
        For i = 0 To dAdvance.RowCount - 1
            If dAdvance.Item(0, i).Value = CStr(w.GetID) Then Exit Sub
        Next
        count += 1
        dAdvance.Rows.Add(CStr(w.GetID), CStr(count), w.FullName, w.GetJob, CStr(w.GetSalary), CStr(w.wAdvance))
        dAdvance.Height = dAdvance.ColumnHeadersHeight + dAdvance.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 4
        dAdvance.ClearSelection()
    End Sub

    Private Sub dAdvance_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dAdvance.CellEndEdit
        On Error Resume Next
        Dim w As Worker = Worker.FindByID(dAdvance.Item(0, e.RowIndex).Value)
        If e.ColumnIndex = 4 Then
            w.SetSalary(CInt(dAdvance.Item(e.ColumnIndex, e.RowIndex).Value))
        ElseIf e.ColumnIndex = 5 Then
            w.wAdvance = CInt(dAdvance.Item(e.ColumnIndex, e.RowIndex).Value)
        End If
    End Sub

    Private Sub dAdvance_RowHeightChanged(sender As Object, e As DataGridViewRowEventArgs) Handles dAdvance.RowHeightChanged
        dAdvance.Height = dAdvance.ColumnHeadersHeight + dAdvance.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 4
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        count = 0
        ComboBox1.Items.Clear()
        dAdvance.Rows.Clear()
        For Each w In Worker.AllOfThem
            If ComboBox2.SelectedIndex = w.GetWorkshopInt Then
                ComboBox1.Items.Add(w.FullName)
                WorkerIDForComboBox1(ComboBox1.Items.Count - 1) = w.GetID
            End If
        Next
        Select Case ComboBox2.SelectedIndex
            Case 0
                Label2.Text = "Цех: Мойка"
            Case 1
                Label2.Text = "Цех: Шиномонтаж"
            Case 2
                Label2.Text = "Цех: Сервис"
        End Select
    End Sub
End Class
