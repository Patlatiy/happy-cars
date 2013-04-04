Public Class Form2
    Dim currentDate As Date
    Dim fpath As String
    Dim dummieString As String
    Dim Page As Integer = 0
    Dim currentType As String

    Public Sub LoadMonth(WhatToLoad As String, ByVal StartingDay As Integer, ByVal EndingDay As Integer, intMonth As Integer, intYear As Integer)
        Dim sum As ULong = 0
        Dim diff As ULong = 0
        Dim cnt As UInteger = 0
        fpath = Application.StartupPath & "\data\" & CStr(intYear) & "\" & CStr(intMonth) & "\"
        Dim CurRow As String()
        Select Case WhatToLoad
            Case "Wash"
                Dim DayCarCount As Integer = 0
                Dim NightCarCount As Integer = 0
                dataDay.Rows.Clear()
                dataNight.Rows.Clear()
                dataDay.AllowUserToAddRows = True
                dataNight.AllowUserToAddRows = True
                dataDay.Show()
                dataNight.Show()
                dataDay1.Hide()
                dataCash.Hide()
                If My.Computer.FileSystem.DirectoryExists(fpath) Then
                    For i = StartingDay To EndingDay
                        If My.Computer.FileSystem.FileExists(fpath & CStr(i) & "N.ini") Then
                            Using baseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(fpath & CStr(i) & "N.ini")
                                baseFile.TextFieldType = FileIO.FieldType.Delimited
                                baseFile.SetDelimiters("|")
                                While Not baseFile.EndOfData
                                    CurRow = baseFile.ReadFields
                                    If CurRow.Length > 1 Then sum = sum + CULng(CurRow(6))
                                    cnt = cnt + 1
                                End While
                            End Using
                        End If
                        dataNight.Rows.Add()
                        dataNight.Item("nSum", dataNight.RowCount - 2).Value = CStr(sum)
                        sum = 0
                        dataNight.Item("nCount", dataNight.RowCount - 2).Value = CStr(cnt)
                        NightCarCount += cnt
                        cnt = 0
                        If i = 1 Then
                            dataNight.Item("nDay", dataNight.RowCount - 2).Value = CStr(Form1.curDatePicker.Value.AddDays(0 - Form1.curDatePicker.Value.Day).ToString("dd")) & "-" & CStr(i)
                        Else
                            dataNight.Item("nDay", dataNight.RowCount - 2).Value = CStr(i - 1) & "-" & CStr(i)
                        End If
                        If My.Computer.FileSystem.FileExists(fpath & CStr(i) & ".ini") Then
                            Using baseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(fpath & CStr(i) & ".ini")
                                baseFile.TextFieldType = FileIO.FieldType.Delimited
                                baseFile.SetDelimiters("|")
                                While Not baseFile.EndOfData
                                    CurRow = baseFile.ReadFields
                                    sum = sum + CULng(CurRow(6))
                                    cnt = cnt + 1
                                End While
                            End Using
                        End If
                        dataDay.Rows.Add()
                        dataDay.Item("cmnSum", dataDay.RowCount - 2).Value = CStr(sum)
                        sum = 0
                        dataDay.Item("cmnCount", dataDay.RowCount - 2).Value = CStr(cnt)
                        DayCarCount += cnt
                        cnt = 0
                        dataDay.Item("cmnDay", dataDay.RowCount - 2).Value = CStr(i)
                    Next
                    Dim tmpInt As Integer = 0
                    dataNight.Rows.Add()
                    dataNight.Item("nCount", dataNight.RowCount - 2).Value = CStr(NightCarCount)
                    dataNight.Item("nDay", dataNight.RowCount - 2).Value = "Ночь:"
                    dataNight.Item("nDay", dataNight.RowCount - 2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    For i = 0 To dataNight.RowCount - 2
                        tmpInt += CInt(dataNight.Item("nSum", i).Value)
                    Next
                    dataNight.Item("nSum", dataNight.RowCount - 2).Value = CStr(tmpInt)
                    dataDay.Rows.Add()
                    dataDay.Item("cmnCount", dataDay.RowCount - 2).Value = CStr(DayCarCount)
                    dataDay.Item("cmnDay", dataDay.RowCount - 2).Value = "День:"
                    dataDay.Item("cmnDay", dataDay.RowCount - 2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    Dim tmpint2 = 0
                    For i = 0 To dataDay.RowCount - 2
                        tmpint2 += CInt(dataDay.Item("cmnSum", i).Value)
                    Next
                    dataDay.Item("cmnSum", dataDay.RowCount - 2).Value = CStr(tmpint2)
                    dataNight.Rows.Add()
                    dataNight.Item("nDay", dataNight.RowCount - 2).Value = "Итого:"
                    dataNight.Item("nDay", dataNight.RowCount - 2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    dataNight.Item("nCount", dataNight.RowCount - 2).Value = CStr(NightCarCount + DayCarCount)
                    dataNight.Item("nSum", dataNight.RowCount - 2).Value = CStr(tmpInt + tmpint2)
                End If
                dataDay.AllowUserToAddRows = False
                dataNight.AllowUserToAddRows = False
                dataDay.Height = 22 + 22 * dataDay.RowCount
                dataNight.Height = 22 + 22 * dataNight.RowCount
                dataDay.ClearSelection()
                dataNight.ClearSelection()
                Label1.Text = "Месячный отчёт по автомойке с " & CStr(StartingDay) & " по " & CStr(EndingDay) & ", " & NumberToMonth(intMonth) & " " & CStr(intYear)
            Case "Mount"
                Dim CarCount As Integer = 0
                dataDay.Rows.Clear()
                dataNight.Rows.Clear()
                dataDay.AllowUserToAddRows = True
                dataNight.AllowUserToAddRows = True
                dataDay.Show()
                dataNight.Hide()
                dataDay1.Hide()
                dataCash.Hide()
                If My.Computer.FileSystem.DirectoryExists(fpath) Then
                    For i = StartingDay To EndingDay
                        If My.Computer.FileSystem.FileExists(fpath & CStr(i) & "m.ini") Then
                            Using baseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(fpath & CStr(i) & "m.ini")
                                baseFile.TextFieldType = FileIO.FieldType.Delimited
                                baseFile.SetDelimiters("|")
                                While Not baseFile.EndOfData
                                    CurRow = baseFile.ReadFields
                                    sum += CULng(CurRow(6))
                                    cnt += 1
                                End While
                                dataDay.Rows.Add()
                                dataDay.Item(2, dataDay.RowCount - 2).Value = CStr(sum)
                                sum = 0
                                dataDay.Item(1, dataDay.RowCount - 2).Value = CStr(cnt)
                                CarCount += cnt
                                cnt = 0
                                dataDay.Item(0, dataDay.RowCount - 2).Value = CStr(i)
                            End Using
                        End If
                    Next
                    Dim tmpInt As Integer = 0
                    dataDay.Rows.Add()
                    dataDay.Item(0, dataDay.RowCount - 2).Value = "Итого:"
                    dataDay.Item(0, dataDay.RowCount - 2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    dataDay.Item(1, dataDay.RowCount - 2).Value = CStr(CarCount)
                    Dim tmpint2 = 0
                    For i = 0 To dataDay.RowCount - 2
                        tmpint2 += CInt(dataDay.Item(2, i).Value)
                    Next
                    dataDay.Item(2, dataDay.RowCount - 2).Value = CStr(tmpint2)
                End If
                dataDay.AllowUserToAddRows = False
                dataNight.AllowUserToAddRows = False
                dataDay.Height = 22 + 22 * dataDay.RowCount
                dataNight.Height = 22 + 22 * dataNight.RowCount
                dataDay.ClearSelection()
                dataNight.ClearSelection()
                Label1.Text = "Месячный отчёт по шиномонтажу с " & CStr(StartingDay) & " по " & CStr(EndingDay) & ", " & NumberToMonth(intMonth) & " " & CStr(intYear)
            Case "Service"
                Dim CarCount As Integer = 0
                dataDay.Rows.Clear()
                dataNight.Rows.Clear()
                dataDay.AllowUserToAddRows = True
                dataNight.AllowUserToAddRows = True
                dataDay.Show()
                dataNight.Hide()
                dataDay1.Hide()
                dataCash.Hide()
                If My.Computer.FileSystem.DirectoryExists(fpath) Then
                    For i = StartingDay To EndingDay
                        If My.Computer.FileSystem.FileExists(fpath & CStr(i) & "s.ini") Then
                            Using baseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(fpath & CStr(i) & "s.ini")
                                baseFile.TextFieldType = FileIO.FieldType.Delimited
                                baseFile.SetDelimiters("|")
                                While Not baseFile.EndOfData
                                    CurRow = baseFile.ReadFields
                                    sum += CULng(CurRow(7)) + CULng(CurRow(9)) - CULng(CurRow(10))
                                    cnt += 1
                                End While
                                dataDay.Rows.Add()
                                dataDay.Item(2, dataDay.RowCount - 2).Value = CStr(sum)
                                sum = 0
                                dataDay.Item(1, dataDay.RowCount - 2).Value = CStr(cnt)
                                CarCount += cnt
                                cnt = 0
                                dataDay.Item(0, dataDay.RowCount - 2).Value = CStr(i)
                            End Using
                        End If
                    Next
                    Dim tmpInt As Integer = 0
                    dataDay.Rows.Add()
                    dataDay.Item(0, dataDay.RowCount - 2).Value = "Итого:"
                    dataDay.Item(0, dataDay.RowCount - 2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    dataDay.Item(1, dataDay.RowCount - 2).Value = CStr(CarCount)
                    Dim tmpint2 = 0
                    For i = 0 To dataDay.RowCount - 2
                        tmpint2 += CInt(dataDay.Item(2, i).Value)
                    Next
                    dataDay.Item(2, dataDay.RowCount - 2).Value = CStr(tmpint2)
                End If
                dataDay.AllowUserToAddRows = False
                dataNight.AllowUserToAddRows = False
                dataDay.Height = 22 + 22 * dataDay.RowCount
                dataDay.ClearSelection()
                Label1.Text = "Месячный отчёт по сервису с " & CStr(StartingDay) & " по " & CStr(EndingDay) & ", " & NumberToMonth(intMonth) & " " & CStr(intYear)
            Case "Cash"
                Dim sum2 As ULong = 0
                Dim diff2 As ULong = 0
                dataCash.Rows.Clear()
                dataDay.Hide()
                dataNight.Hide()
                dataDay1.Hide()
                dataCash.Show()
                dataCash.Columns.Clear()
                dataCash.AllowUserToAddRows = True
                dataCash.Columns.Add("cmn0", "")
                dataCash.Columns.Add("cmn1", "Приход")
                dataCash.Columns.Add("cmn2", "Расход")
                dataCash.Columns.Add("cmn3", "Общ. приход")
                dataCash.Columns.Add("cmn4", "Общ. расход")
                If My.Computer.FileSystem.DirectoryExists(fpath) Then
                    For i = StartingDay To EndingDay
                        If My.Computer.FileSystem.FileExists(fpath & CStr(i) & "c.ini") Then
                            Using baseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(fpath & CStr(i) & "c.ini")
                                baseFile.TextFieldType = FileIO.FieldType.Delimited
                                baseFile.SetDelimiters("|")
                                While Not baseFile.EndOfData
                                    CurRow = baseFile.ReadFields
                                    If dataCash.RowCount = 1 And CurRow(0) = "x" Then
                                        dataCash.Rows.Add()
                                        dataCash.Item(0, dataCash.RowCount - 2).Value = "Остаток"
                                        dataCash.Item(1, dataCash.RowCount - 2).Value = CurRow(4)
                                        sum2 = CULng(CurRow(4))
                                    End If
                                    If CurRow.Length > 1 And CurRow(0) <> "x" And CurRow(0) <> "xxx" Then
                                        sum += CULng(CurRow(4))
                                        diff += CULng(CurRow(5))
                                        cnt += 1
                                    End If
                                End While
                                If sum <> 0 Or diff <> 0 Then
                                    dataCash.Rows.Add()
                                    dataCash.Item(1, dataCash.RowCount - 2).Value = CStr(sum)
                                    sum2 += sum
                                    sum = 0
                                    dataCash.Item(3, dataCash.RowCount - 2).Value = CStr(sum2)
                                    dataCash.Item(2, dataCash.RowCount - 2).Value = CStr(diff)
                                    diff2 += diff
                                    diff = 0
                                    dataCash.Item(4, dataCash.RowCount - 2).Value = CStr(diff2)
                                    cnt = 0
                                    dataCash.Item(0, dataCash.RowCount - 2).Value = CStr(i)
                                End If
                            End Using
                        End If
                    Next
                    Dim tmpInt As Integer = 0
                    dataCash.Rows.Add()
                    dataCash.Item(0, dataCash.RowCount - 2).Value = "Итого:"
                    dataCash.Item(0, dataCash.RowCount - 2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    Dim tmpint2 = 0
                    Dim tmpint3 = 0
                    For i = 0 To dataCash.RowCount - 2
                        tmpint2 += CInt(dataCash.Item(2, i).Value)
                        tmpint3 += CInt(dataCash.Item(1, i).Value)
                    Next
                    dataCash.Item(1, dataCash.RowCount - 2).Value = CStr(tmpint3)
                    dataCash.Item(2, dataCash.RowCount - 2).Value = CStr(tmpint2)
                End If
                dataCash.AllowUserToAddRows = False
                dataCash.Height = 22 + 22 * dataCash.RowCount
                dataCash.ClearSelection()
                Label1.Text = "Месячный отчёт по кассе с " & CStr(StartingDay) & " по " & CStr(EndingDay) & ", " & NumberToMonth(intMonth) & " " & CStr(intYear)
        End Select

    End Sub

    Public Sub LoadDay(WhatToLoad As String, Optional CopyFromForm1 As Boolean = True, Optional Repeated As Boolean = False)
        Dim tmpI As Integer = 0
        currentType = WhatToLoad
        Dim dataSrc As DataGridView = Form1.dataDay
        Dim dataDst As DataGridView = dataDay1
        Select Case WhatToLoad
            Case "Wash"
                dataSrc = Form1.dataDay
            Case "Mount"
                dataSrc = Form1.dataDayMount
            Case "Service"
                dataSrc = Form1.dataService
        End Select
        If Repeated Then GoTo 1
        ComboPages.Items.Clear()
        dataDay1.Hide()
        dataDay.Hide()
        dataNight.Hide()
        dataCash.Hide()
        dataDst.Show()
        While tmpI < (dataSrc.RowCount - 2) \ 39 + 1
            ComboPages.Items.Add("Страница " & CStr(tmpI + 1) & " из " & CStr((dataSrc.RowCount - 2) \ 39 + 1))
            tmpI += 1
        End While
        If ComboPages.Items.Count <> 0 Then ComboPages.Text = ComboPages.Items(0).ToString
        dataDst.Columns.Clear()
        For i = 0 To dataSrc.ColumnCount - 1
            dataDst.Columns.Add("cmn" & CStr(i), dataSrc.Columns(i).HeaderText)
            dataDst.Columns(i).Width = dataSrc.Columns(i).Width
            dataDst.Columns(i).Visible = dataSrc.Columns(i).Visible
        Next

1:
        dataDst.AllowUserToAddRows = True
        dataDst.Rows.Clear()
        If CopyFromForm1 Then
            For i = 0 To 39
                If i + (Page * 39) > dataSrc.RowCount - 2 Then GoTo 2
                dataDst.Rows.Add()
                For j = 0 To dataSrc.ColumnCount - 1
                    dataDst.Item(j, i).Value = dataSrc.Item(j, i + (Page * 40)).Value
                Next
            Next
2:
            If ComboPages.SelectedIndex = ComboPages.Items.Count - 1 Then
                dataDst.Rows.Add()
                dataDst.Item(4, dataDst.RowCount - 2).Value = "Итого:"
                dataDst.Item(4, dataDst.RowCount - 2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                If dataDst.ColumnCount > 5 Then
                    If dataDst.Columns(5).Visible = True Then
                        dataDst.Item(5, dataDst.RowCount - 2).Value = Form1.daySum
                    Else
                        dataDst.Item(6, dataDst.RowCount - 2).Value = Form1.daySum
                    End If
                End If
            End If
        End If
0:
        If WhatToLoad = "Wash" And Form1.NightBox.Checked Then Label1.Text = "Ночной отчёт за " & Form1.curDate.AddDays(-1).ToString("dd.MM.yyyy") & " - " & Form1.curDate.ToString("dd.MM.yyyy") Else Label1.Text = "Дневной отчёт за " & Form1.curDatePicker.Value.ToString("dd.MM.yyyy")
        dataDst.AllowUserToAddRows = False
        dataDst.Height = 22 * dataDst.RowCount + 44
        dataDst.ClearSelection()
    End Sub

    Public Sub LoadSchedule(Day As Boolean)
        Dim tmpI As Integer = 0
        Dim dataSrc1 As DataGridView = Form1.dSchedule1
        Dim datadst1 As DataGridView
        If Day Then
            datadst1 = dataDay
        Else
            datadst1 = dataNight
        End If

        ComboPages.Items.Clear()
        dataDay1.Hide()
        dataDay.Show()
        dataNight.Show()
        dataCash.Hide()

        datadst1.Columns.Clear()
        For i = 0 To dataSrc1.ColumnCount - 1
            datadst1.Columns.Add("cmn" & CStr(i), dataSrc1.Columns(i).HeaderText)
            datadst1.Columns(i).Width = dataSrc1.Columns(i).Width
            datadst1.Columns(i).Visible = dataSrc1.Columns(i).Visible
        Next
        If Not Day Then dataNight.Columns(0).Visible = False

        datadst1.AllowUserToAddRows = True
        datadst1.Rows.Clear()
        For i = 0 To dataSrc1.RowCount - 1
            datadst1.Rows.Add()
            For j = 0 To dataSrc1.ColumnCount - 1
                datadst1.Item(j, i).Value = dataSrc1.Item(j, i + (Page * 39)).Value
            Next
        Next
0:
        Label1.Text = "Шиномонтаж, запись на " & Form1.curDatePicker.Value.ToString("dd.MM.yyyy")
        datadst1.AllowUserToAddRows = False
        datadst1.Height = 22 * datadst1.RowCount + 44
        datadst1.ClearSelection()
    End Sub

    Public Function NumberToMonth(ByVal MonthNumber As Integer) As String
        Select Case MonthNumber
            Case 1
                Return "Январь"
            Case 2
                Return "Февраль"
            Case 3
                Return "Март"
            Case 4
                Return "Апрель"
            Case 5
                Return "Май"
            Case 6
                Return "Июнь"
            Case 7
                Return "Июль"
            Case 8
                Return "Август"
            Case 9
                Return "Сентябрь"
            Case 10
                Return "Октябрь"
            Case 11
                Return "Ноябрь"
            Case 12
                Return "Декабрь"
            Case Else
                Return "Незнабрь"
        End Select
    End Function

    Public Sub LoadCash(Optional Repeated As Boolean = False)
        Dim tmpI As Integer = 0
        If Repeated Then GoTo 1
        ComboPages.Items.Clear()
        While tmpI < (Form1.dCash.RowCount - 2) \ 39 + 1
            ComboPages.Items.Add("Страница " & CStr(tmpI + 1) & " из " & CStr((Form1.dataDay.RowCount - 2) \ 39 + 1))
            tmpI += 1
        End While
        If ComboPages.Items.Count <> 0 Then ComboPages.Text = ComboPages.Items(0).ToString
        dataDay1.Hide()
        dataDay.Hide()
        dataNight.Hide()
1:
        dataCash.AllowUserToAddRows = True
        dataCash.Rows.Clear()
        For i = 0 To 39
            If i + (Page * 39) > Form1.dCash.RowCount - 2 Then GoTo 0
            dataCash.Rows.Add()
            For j = 0 To Form1.dCash.ColumnCount - 2
                dataCash.Item(j, i).Value = Form1.dCash.Item(j + 1, i + (Page * 39)).Value
            Next
        Next
0:
        Label1.Text = "Кассовая книга за " & Form1.curDatePicker.Value.ToString("dd.MM.yyyy")
        dataCash.Show()
        dataCash.AllowUserToAddRows = False
        dataCash.Height = 22 + 22 * dataCash.RowCount
        dataCash.ClearSelection()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        dataDay.ClearSelection()
        dataDay1.ClearSelection()
        dataNight.ClearSelection()
        dataCash.ClearSelection()
        Application.DoEvents()
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Application.DoEvents()
        Button1.Visible = True
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub Form2_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        dataDay.ClearSelection()
        dataDay1.ClearSelection()
        dataNight.ClearSelection()
        dataCash.ClearSelection()
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dataDay.DefaultCellStyle.SelectionForeColor = Color.Black
        dataDay1.DefaultCellStyle.SelectionForeColor = Color.Black
        dataNight.DefaultCellStyle.SelectionForeColor = Color.Black
    End Sub

    Private Sub ComboPages_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboPages.SelectedIndexChanged
        If dataCash.Visible Then
            Page = ComboPages.SelectedIndex
            LoadCash(True)
        ElseIf dataDay1.Visible Then
            Page = ComboPages.SelectedIndex
            LoadDay(currentType, , True)
        End If
    End Sub
End Class