Public Class Form1
    Const WASH_GROUP_COUNT As UShort = 3 'Количество групп автомобилей на мойке
    Const MOUNT_GROUP_COUNT As UShort = 9 'Количество групп колёс на шиномонтаже
    Const SVC_DIVIDER As String = ", " 'Разделитель между услугами в поле "Услуги"
    Const GLOBAL_PASSWORD As String = "***" 'Пароль для смены глобального режима
    Const START_HOUR As UShort = 9, END_HOUR As UShort = 21 'Рабочий день
    Public culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("eu-ES")
    Const specifier As String = "f2"

    Public WriteRight As WriteRights = WriteRights.Read_Only
    Dim Random As New Random

    'Переменные текущих цен на мойку:
    Dim plexPrice As UInteger 'Цена за комплекс
    Dim bodyPrice As UInteger 'Цена за кузов
    Dim expressPrice As UInteger 'Цена за экспресс
    Dim waxPrice As UInteger 'Цена за воск
    Dim showerPrice As UInteger 'Цена за облив
    Dim drivePrice As UInteger 'Цена за движок
    Dim bottomPrice As UInteger 'Цена за днище
    Dim cabinPrice As UInteger 'Цена за салон
    Dim vacuumPrice As UInteger 'Цена за пылесос
    Dim trunkPrice As UInteger 'Цена за багажник
    Dim wetPrice As UInteger 'Цена за влажную уборку
    Dim carpetsPrice As UInteger 'Цена за коврики
    Dim glassPrice As UInteger 'Цена за стёкла
    Dim frontGlassPrice As UInteger 'Цена за лобовое стекло
    Dim polishTorpPrice As UInteger 'Цена за полировку торпеды
    Dim polishPlasticPrice As UInteger 'Цена за полировку пластика салона
    Dim leatherPrice As UInteger 'Цена за кондиционер кожи
    Dim arcPrice As UInteger 'Цена за мойку арок
    Dim arcFoamPrice As UInteger 'Цена за мойку арок с пеной
    Dim discInsidePressurePrice As UInteger 'Цена за мойку дисков давлением
    Dim discInsideFoamPrice As UInteger 'Цена за мойку дисков пеной
    Dim blackTyrePrice As UInteger 'Цена за чернение шин
    Dim blackBumpPrice As UInteger 'Цена за чернение бамперов
    Dim blackMouldPrice As UInteger 'Цена за чернение молдингов
    Dim airBlowPrice As UInteger 'Цена за продувку воздухом
    Dim resinSiliconePrice As UInteger 'Цена за обработку резиновых уплотнителей дверей силиконом
    Dim locksWDPrice As UInteger 'Цена за обработку замков WD-40
    Dim bicycle1Price As UInteger 'Цена за велосипед
    Dim bicycle2Price As UInteger 'Цена за велосипед 2 (не используется)
    Dim bike1Price As UInteger 'Цена за облив мотоцикла
    Dim bike2Price As UInteger 'Цена за мойку мотоцикла с пеной
    Dim carpWashPrice As UInteger 'Цена мойки 1 кв.м. ковриков
    Dim carpChemPrice As UInteger 'Цена химчистки 1 кв.м. ковриков
    Dim techWashPrice As UInteger 'Цена тех.мойки
    Dim DiscountValues(30) As Integer 'Массив скидок
    Public DebtID(1000, 1) As Integer 'Массив Id долгов
    Public NextDebtID As Integer = 0 'Следующий ID долга

    Dim sum As Double 'Текущая сумма
    Dim cSum As Double 'Текущая сумма в кассовой книге
    Dim WashPrices(WASH_GROUP_COUNT, 100) As UInteger 'Массив с ценами на мойку (до 100 штук)
    Dim MountPrices(MOUNT_GROUP_COUNT, 100) As UInteger 'Массив с ценами на шиномонтаж (до 100 штук)
    Dim comment(100) As String 'Название услуги в файле цен, пока нигде не используется
    Dim mcomment(100) As String 'Название услуги в файле цен, пока нигде не используется
    Dim curGr As UInteger 'Индекс текущей группы автомобиля
    Dim dayCC As Integer 'Количество автомобилей на мойке за текущий день [daily car count]
    Dim DayCCMount As Integer 'Количество автомобилей на шиномонтаже за текущий день {daily car count mount]
    Dim DayCCService As UInteger 'Количество автомобилей на сервисе за текущий день [daily car count service]
    Public dPath As String 'Директория с рабочими файлами
    Dim fPath As String 'Путь к файлу дневной/ночной базы мойки (.ini) [file path]
    Dim fmPath As String 'Путь к файлу дневной базы шиномонтажа (.ini) [file mount path]
    Dim sPath As String 'Путь к файлу дневной базы сервиса (.ini) [service path]
    Dim rPath As String 'Путь к шаблону отчёта для мойки (.xlsx) [report path]
    Dim rmPath As String 'Путь к шаблону отчёта для шиномонтажа (.xlsx) [report mount path]
    Dim ePath As String 'Путь к файлу отчёта для мойки (.xlsx) [excel path]
    Dim emPath As String 'Путь к файлу отчёта для шиномонтажа (.xlsx) [excel mount path]
    Dim cPath As String 'Путь к файлу кассы [cash path]
    Dim nPath As String 'Путь к файлу ночной базы автомойки
    Dim ndPath As String '[Next day path]
    Dim nddPath As String 'Next Day Directory path
    Dim cdPath As String '[current day path]
    Dim sc1Path As String 'Schedule1 path
    Dim sc2Path As String 'Schedule2 path
    Dim tPath As String 'Table path
    Public curDate As Date 'Дата последнего запуска процедуры загрузки LoadProcedure
    Dim nextDay As Date 'Следующий день
    Dim curID As Long = 0 'Текущий ID для кассовой книги
    Dim GlobalMode As Integer = 0 '0 - рабочий режим, 1 - режим администратора. Чтобы сменить режим нужно ввести GLOBAL_PASSWORD вместо марки машины
    Public Shadows DefaultBackColor As Color = Color.White 'Дефолтный цвет ячейки
    Public Shadows DefaultForeColor As Color = Color.Black 'Дефолтный цвет шрифта в ячейке
    Public WorkerIDForzpWorkers(1000) As Integer
    Dim WorkerIDForNightWorkers(1000) As Integer
    Dim CurNightWorkerID As Integer
    Dim DayTotal(3, 32) As Integer
    Dim DayWorkerCount(3, 32) As Integer
    Dim DayPercent(3, 32) As Integer

    Dim WashHashCode As Byte()
    Dim MountHashCode As Byte()
    Dim ServiceHashCode As Byte()
    Dim CashHashCode As Byte()
    Dim sc1HashCode As Byte()
    Dim sc2HashCode As Byte()
    Dim TableHashCode As Byte()
    Dim AdvanceHashCode As Byte()
    Dim DebtsHashCode As Byte()
    Dim StateHashCode As Byte()
    Dim CustomersHashCode As Byte()
    Dim OrdersHashCode As Byte()
    Dim ExecutorsHashCode As Byte()
    Dim PaymentsHashCode As Byte()
    Dim ProvHashCode As Byte()

    Dim ServiceMode As Integer = 0 '0 - Автомойка, 1 - Шиномонтаж
    Dim DayMode As Boolean = True 'Дневной/ночной режим
    Dim CurSche As Integer = 1 'Текущая запись

    Public daySum As Long 'Дневная сумма
    Dim LOADING As Boolean = True
    Dim LoadProcedureRunning As Boolean = True
    Dim ClosingNow As Boolean = False

    Dim CustomerList As List(Of HCCustomer) = HCCustomer.CustomerList
    Dim OrderList As List(Of HCOrder) = HCOrder.OrderList
    Dim curCustomer As HCCustomer
    Dim HiddenPages As New List(Of TabPage)
    Dim curProv As HCProvider

    Public Enum WriteRights
        Read_Only = 0
        Master = 1
        The_Girl = 2
        Bookkeeper = 3
    End Enum

    ''' <summary>
    ''' Процедура пересчёта цен
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Commit()
        On Error Resume Next
        If LOADING Then Exit Sub
        sum = 0
        daySum = 0
        cSum = 0
        For i = 0 To dCash.RowCount - 2
            If CStr(dCash.Rows(i).Cells(0).Value) = "xxx" Then GoTo 8
            cSum += CLng(dCash.Rows(i).Cells(4).Value)
            cSum -= CLng(dCash.Rows(i).Cells(5).Value)
8:
        Next
        Select Case ServiceMode
            Case 0
                If curGr = 5 Then
                    If RadioButton6.Checked Then sum = -bicycle1Price
                    If RadioButton7.Checked Then
                        sum += napCarpetsBox.Checked * carpWashPrice * CDec(txtSquare.Text)
                        sum += chemCarpetsBox.Checked * carpChemPrice * CDec(txtSquare.Text)
                    End If
                    If RadioButton8.Checked Then sum = -bike1Price
                    If RadioButton9.Checked Then sum = -bike2Price
                    GoTo 0
                End If
                If plexBox.Checked Then
                    sum = sum - plexPrice
                Else
                    sum = sum + bodyPrice * bodyBox.Checked
                    If cabinBox.Checked Then
                        sum = sum - cabinPrice
                    Else
                        sum = sum + wetPrice * wetBox.Checked
                        sum = sum + vacuumPrice * vacuumBox.Checked
                        sum = sum + carpetsPrice * carpetsBox.Checked * (CarpCounter.Value / 4)
                    End If
                End If
                sum = sum + showerPrice * showerBox.Checked
                sum = sum + waxPrice * waxBox.Checked
                sum = sum + trunkPrice * trunkBox.Checked
                sum = sum + expressPrice * expressBox.Checked
                sum = sum + drivePrice * driveBox.Checked
                sum = sum + bottomPrice * bottomBox.Checked
                If glassBox.Checked Then
                    sum = sum - glassPrice
                Else
                    sum = sum + frontGlassPrice * frontGlassBox.Checked
                End If
                sum = sum + polishTorpPrice * polishTorpBox.Checked
                sum = sum + polishPlasticPrice * polishPlasticBox.Checked
                sum = sum + leatherPrice * leatherBox.Checked
                sum = sum + arcPrice * arcBox.Checked
                sum = sum + arcFoamPrice * arcFoamBox.Checked
                sum = sum + discInsidePressurePrice * discBox.Checked
                sum = sum + discInsideFoamPrice * discFoamBox.Checked
                sum = sum + blackTyrePrice * blackTyreBox.Checked
                sum = sum + blackBumpPrice * blackBumperBox.Checked
                sum = sum + blackMouldPrice * blackMouldBox.Checked
                sum = sum + udStain.Value * stainBitumenBox.Checked
                sum = sum + techWashPrice * techWashBox.Checked
                sum = sum + airBlowPrice * airBox.Checked
                sum = sum + resinSiliconePrice * resinBox.Checked
                sum = sum + locksWDPrice * WD40Box.Checked
                sum = sum + CDbl(OtherNUD.Value) * OtherBox.Checked
                Select Case DayMode
                    Case True
                        For i = 0 To dataDay.RowCount - 1
                            daySum += CLng(dataDay.Item(6, i).Value)
                        Next
                        lblDaySum.Text = "Сумма за день: " & CStr(daySum) & "р."
                    Case False
                        For i = 0 To dataDay.RowCount - 1
                            daySum += CLng(dataDay.Item(6, i).Value)
                        Next
                        lblDaySum.Text = "Сумма за ночь: " & CStr(daySum) & "р."
                End Select
                sum = 0 - sum
            Case 1
                sum += MountPrices(curGr, 1) * serviceBox1.Checked * nud1.Value
                sum += MountPrices(curGr, 2) * serviceBox2.Checked * nud2.Value
                sum += MountPrices(curGr, 3) * serviceBox3.Checked * nud3.Value
                sum += MountPrices(curGr, 4) * serviceBox4.Checked * nud4.Value
                sum += MountPrices(curGr, 5) * serviceBox5.Checked * nud5.Value
                sum += MountPrices(curGr, 6) * serviceBox6.Checked * nud6.Value
                sum += MountPrices(curGr, 7) * serviceBox7.Checked * nud7.Value
                sum += MountPrices(curGr, 8) * serviceBox8.Checked * nud8.Value
                sum += MountPrices(curGr, 9) * serviceBox9.Checked * nud9.Value
                sum += MountPrices(curGr, 10) * serviceBox10.Checked * nud10.Value
                sum += MountPrices(curGr, 11) * serviceBox11.Checked * nud11.Value
                sum += MountPrices(curGr, 12) * serviceBox12.Checked * nud12.Value
                sum += MountPrices(curGr, 13) * serviceBox13.Checked * nud13.Value
                sum += MountPrices(curGr, 14) * serviceBox14.Checked * nud14.Value
                sum += MountPrices(curGr, 15) * serviceBox15.Checked * nud15.Value
                sum += MountPrices(curGr, 16) * ServiceBox16.Checked * nud16.Value
                sum += MountPrices(curGr, 17) * ServiceBox17.Checked * nud17.Value
                sum += CDbl(OtherNUD2.Value) * OtherBox2.Checked
                For i = 0 To dataDayMount.RowCount - 1
                    daySum += CLng(dataDayMount.Item("mSum", i).Value)
                Next
                lblDaySum.Text = "Сумма за день: " & CStr(daySum) & "р."
                sum = 0 - sum
            Case 2
                For i = 0 To dataService.RowCount - 1
                    daySum += CLng(dataService.Item(5, i).Value)
                    daySum += CLng(dataService.Item(7, i).Value)
                    daySum -= CLng(dataService.Item(8, i).Value)
                Next
                lblDaySum.Text = "Сумма: " & CStr(daySum) & "р."
                WorkDiscounted.Text = CLng(workSumBox.Text) - Math.Floor((CLng(workSumBox.Text) * DiscountNud.Value / 100) / 10) * 10
                PartsSumDiscounted.Text = CLng(partsSumBox.Text) - Math.Floor((CLng(partsSumBox.Text) * DiscountNud.Value / 100) / 10) * 10
                PartsOutDiscounted.Text = CLng(partsOutBox.Text) - Math.Floor((CLng(partsOutBox.Text) * DiscountNud.Value / 100) / 10) * 10
                sum += CLng(WorkDiscounted.Text)
                sum += CLng(PartsSumDiscounted.Text)
                sum -= CLng(PartsOutDiscounted.Text)
            Case 4
                lblDaySum.Text = "В кассе: " & CStr(cSum) & "р."
            Case Else
                lblDaySum.Text = ""
        End Select
0:

        If DiscountNud.Value <> 0 And ServiceMode < 2 Then
            sum = sum - Math.Floor(sum * DiscountNud.Value / 100)
        End If

        Label1.Text = CStr(sum) & " р."
        Log(CStr(ServiceMode))
    End Sub

    Private Sub CheckForComplex()
        plexBox.Checked = bodyBox.Checked And cabinBox.Checked
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClosingNow = True
        RecountRows()
        SaveAll()
    End Sub

    Public Overloads Sub Show(rights As WriteRights, Optional log As Boolean = False)
        Select Case rights
            Case WriteRights.Bookkeeper
                WriteRight = WriteRights.Bookkeeper
                ПаролиToolStripMenuItem.Visible = True
            Case WriteRights.Master
                WriteRight = WriteRights.Master
                EnablePage(tabWash, False)
                EnablePage(tabMount, False)
                EnablePage(tabService, False)
                EnablePage(tabCash, False)
                EnablePage(tabAnalytics, False)
                EnablePage(tabStats, False)
                EnablePage(tabProviders, False)
                EnablePage(tabPayments, False)
                EnablePage(tabSchedule, False)
                cmnPayment.Visible = False
                ReportsToolStripMenuItem.Enabled = False
            Case WriteRights.The_Girl
                WriteRight = WriteRights.The_Girl
                EnablePage(tabAnalytics, False)
                EnablePage(tabStats, False)
                EnablePage(tabProviders, False)
                EnablePage(tabPayments, False)
                cmnEdit.Visible = False
                cmnOpen.Visible = False
            Case WriteRights.Read_Only
                ComboBox1.Hide()
                txtNumber.Hide()
                Button1.Hide()
                Button4.Hide()
                Button5.Hide()
                Button6.Hide()
                Button7.Hide()
                AddCashButton.Hide()
                OweBox.Hide()
                OweBox2.Hide()
                OweBox3.Hide()
                GroupBox1.Hide()
                GroupBox2.Hide()
                GroupBox5.Hide()
                GroupBox6.Hide()
                GroupBox7.Hide()
                Label14.Hide()
                DiscountNud.Hide()
                DiscountCombo.Hide()
                Label1.Hide()
                Label12.Hide()
                Button12.Hide()
                ComboTLS2.Hide()
                lblTomorrow.Hide()
                For i = 0 To dCash.ColumnCount - 1
                    dCash.Columns(i).ReadOnly = True
                Next
                dataDay.Left = 10
                NightBox.Left = dataDay.Width + 20
                NightBox.Top = 10
                btnDebt1.Left = NightBox.Left
                btnDebt1.Top = 35
                TabControl1.Top = 30
                Me.Height = Me.Height - 30
                lblDaySum.Top = lblDaySum.Top - 30
                dataDayMount.Left = 10
                btnDebt2.Left = dataDayMount.Width + 20
                btnDebt2.Top = 10
                dataService.Left = 10
                btnDebt3.Left = dataService.Width + 15
                btnDebt3.Top = 10
                btnNewCustomer.Hide()
                btnNewOrder.Hide()
                btnAddPayment.Hide()
                Me.Text = Me.Text & " - ТОЛЬКО ЧТЕНИЕ"
        End Select
        If log Then frmLog.Show()
        Me.Show()
        Me.BringToFront()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLogin.Show(Me)
        'Unused tabs atm:
        EnablePage(tabTable, False)
        EnablePage(tabZP, False)

        LoadCars()
        LoadDiscounts()
        LoadProcedure(My.Computer.Clock.LocalTime.Date)
        LOADING = False
    End Sub

    Public Sub LoadWash()
        Try
            Log("Loading wash")
            dayCC = 1 'Устанавлиаем номер последней машины
            dataDay.Rows.Clear() 'Очищаем все строки дневного отчёта мойки
            ComboNightWorkers.Items.Clear()
            Dim curRow As String()
            For Each wrkr In Worker.AllOfThem
                If wrkr.GetWorkshopInt = 0 Then
                    ComboNightWorkers.Items.Add(wrkr.FullName)
                    WorkerIDForNightWorkers(ComboNightWorkers.Items.Count - 1) = wrkr.GetID
                End If
            Next
            'Считываем базу сегодняшнего дня или ночи:
            If My.Computer.FileSystem.FileExists(fPath) Then
                Using baseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(fPath)
                    baseFile.TextFieldType = FileIO.FieldType.Delimited
                    baseFile.SetDelimiters("|")
                    CurNightWorkerID = Nothing
                    While Not baseFile.EndOfData
                        curRow = baseFile.ReadFields
                        If curRow.Length = 1 And curRow(0) <> "" Then
                            CurNightWorkerID = CInt(curRow(0))
                            For i = 0 To 1000
                                If WorkerIDForNightWorkers(i) = CurNightWorkerID Then
                                    ComboNightWorkers.SelectedIndex = i
                                    Exit For
                                End If
                            Next
                            Continue While
                        End If
                        Try
                            AddRecord(CLng(curRow(7)), CLng(curRow(0)), curRow(1), curRow(3), curRow(4), curRow(5), CLng(curRow(6)), CLng(curRow(2)), 0)
                        Catch ex As Exception
                            AddRecord(9999, CLng(curRow(0)), curRow(1), curRow(3), curRow(4), curRow(5), CLng(curRow(6)), CLng(curRow(2)), 0)
                        End Try
                    End While
                End Using
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadMount()
        Try
            Log("Loading mount")
            DayCCMount = 1 'Устанавлиаем номер последней машины на шиномонтаже
            dataDayMount.Rows.Clear() 'Очищаем все строки дневного отчёта шиномонтажа
            Dim curRow As String()
            If My.Computer.FileSystem.FileExists(fmPath) Then
                Using mbaseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(fmPath)
                    mbaseFile.TextFieldType = FileIO.FieldType.Delimited
                    mbaseFile.SetDelimiters("|")
                    While Not mbaseFile.EndOfData
                        curRow = mbaseFile.ReadFields
                        Try
                            AddRecord(CLng(curRow(7)), CLng(curRow(0)), curRow(1), curRow(3), curRow(4), curRow(5), CLng(curRow(6)), CLng(curRow(2)), 1)
                        Catch ex As Exception
                            AddRecord(9999, CLng(curRow(0)), curRow(1), curRow(3), curRow(4), curRow(5), CLng(curRow(6)), CLng(curRow(2)), 1)
                        End Try
                    End While
                End Using
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadService()
        Try
            Log("Loading service")
            DayCCService = 1 'Устанавливаем ... ну вы поняли
            dataService.Rows.Clear() 'очищаем... ну вы поняли
            Dim curRow As String()
            If My.Computer.FileSystem.FileExists(sPath) Then
                Using sbaseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(sPath)
                    sbaseFile.TextFieldType = FileIO.FieldType.Delimited
                    sbaseFile.SetDelimiters("|")
                    While Not sbaseFile.EndOfData
                        curRow = sbaseFile.ReadFields
                        Try
                            If curRow.Length = 10 Then 'Обеспечиваем совместимость со старым форматом
                                AddRecord(CLng(curRow(9)), CLng(curRow(0)), curRow(2), curRow(3), curRow(1), curRow(4), CLng(curRow(5)), curRow(6), CLng(curRow(7)), "~", "~", CLng(curRow(8)))
                            Else
                                AddRecord(CLng(curRow(11)), CLng(curRow(0)), curRow(2), curRow(3), curRow(1), curRow(4), CLng(curRow(7)), curRow(8), CLng(curRow(9)), curRow(5), curRow(6), CLng(curRow(10)))
                            End If
                        Catch ex As Exception
                            If curRow.Length = 9 Then
                                AddRecord(9999, CLng(curRow(0)), curRow(2), curRow(3), curRow(1), curRow(4), CLng(curRow(5)), curRow(6), CLng(curRow(7)), "~", "~", CLng(curRow(8)))
                            Else
                                AddRecord(9999, CLng(curRow(0)), curRow(2), curRow(3), curRow(1), curRow(4), CLng(curRow(7)), curRow(8), CLng(curRow(9)), curRow(5), curRow(6), CLng(curRow(10)))
                            End If
                        End Try
                    End While
                End Using
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadCash()
        Try
            Log("Loading cash")
            dCash.Rows.Clear() 'Очищаем кассовуюю книгу
            Dim curRow As String()
            'Считываем базу кассовой книги:
            Dim EXISTS As Boolean = False
            If My.Computer.FileSystem.FileExists(cdPath) Then
                EXISTS = True
                Using cdBaseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(cdPath)
                    cdBaseFile.TextFieldType = FileIO.FieldType.Delimited
                    cdBaseFile.SetDelimiters("|")
                    curRow = cdBaseFile.ReadFields
                    AddCash("x", "Остаток в кассе", "", "", curRow(0), "0", "")
                End Using
                'If Not READ_ONLY_MODE Then My.Computer.FileSystem.DeleteFile(cdPath)
            End If
            If My.Computer.FileSystem.FileExists(cPath) Then
                Using cbaseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(cPath)
                    cbaseFile.TextFieldType = FileIO.FieldType.Delimited
                    cbaseFile.SetDelimiters("|")
                    curRow = cbaseFile.ReadFields
                    curID = CLng(curRow(0))
                    While Not cbaseFile.EndOfData
                        curRow = cbaseFile.ReadFields
                        If EXISTS And curRow(1) = "Остаток в кассе" Then Continue While
                        AddCash(curRow(0), curRow(1), curRow(2), curRow(3), curRow(4), curRow(5), curRow(6))
                    End While
                End Using
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadTable()
        'Try
        '    Log("Loading table")
        '    dTable.Rows.Clear() 'Чистим табель
        '    dTable.Columns.Clear() 'Чистим табель
        '    Dim curRow As String()
        '    For Each wrkr In Worker.AllOfThem
        '        wrkr.WorkingDaysInCurMonth = 0
        '        wrkr.HoursWorkedInCurMonth = 0
        '        For i = 0 To 31
        '            wrkr.TableForCurMonth(i) = 0
        '        Next
        '    Next
        '    'Создаём первые столбцы табеля:
        '    dTable.Columns.Add("dTable_ID", "ID")
        '    dTable.Columns("dTable_ID").Width = 30
        '    dTable.Columns("dTable_ID").Visible = False
        '    dTable.Columns.Add("dTable_name", "Сотрудник")
        '    dTable.Columns("dTable_name").Width = 190
        '    dTable.Columns("dTable_name").Frozen = True
        '    dTable.Columns.Add("dTable_job", "Должность")
        '    dTable.Columns("dTable_job").Width = 70
        '    dTable.Columns("dTable_job").Frozen = True
        '    'Создаём столбцы и строки табеля:
        '    For i = 1 To Date.DaysInMonth(curDate.Year, curDate.Month)
        '        dTable.Columns.Add("column_day" & CStr(i), CStr(i))
        '        dTable.Columns("column_day" & CStr(i)).Width = 30
        '    Next
        '    For Each wrkr In Worker.AllOfThem
        '        dTable.Rows.Add(CStr(wrkr.GetID), wrkr.Get2Name & " " & wrkr.GetName & " " & wrkr.GetPatron, wrkr.GetJob)
        '        For Each cell In dTable.Rows(dTable.RowCount - 1).Cells
        '            cell.style.backcolor = DefaultBackColor
        '            cell.style.forecolor = DefaultForeColor
        '        Next
        '    Next
        '    'Заполняем табель:
        '    If My.Computer.FileSystem.FileExists(tPath) Then
        '        Using tFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(tPath)
        '            tFile.TextFieldType = FileIO.FieldType.Delimited
        '            tFile.SetDelimiters("|")
        '            While Not tFile.EndOfData
        '                curRow = tFile.ReadFields
        '                Dim RowID As Integer = FindRowByID(curRow(0))
        '                If RowID = -1 Then Continue While
        '                For i = 1 To curRow.Count \ 4
        '                    dTable.Item("column_day" & CStr(i), RowID).Value = curRow(i * 4 - 3)
        '                    dTable.Item("column_day" & CStr(i), RowID).Style.BackColor = System.Drawing.Color.FromArgb(CInt(curRow(i * 4 - 2)), CInt(curRow(i * 4 - 1)), CInt(curRow(i * 4)))
        '                    Dim w As Worker = Worker.FindByID(CInt(dTable.Item("dTable_ID", RowID).Value))
        '                    If curRow(i * 4 - 3) <> "" Then w.HoursWorkedInCurMonth += CDbl(curRow(i * 4 - 3))
        '                    If curRow(i * 4 - 2) <> "255" Or curRow(i * 4 - 1) <> "255" Or curRow(i * 4) <> "255" Then
        '                        w.TableForCurMonth(i) = w.GetNorm
        '                        w.WorkingDaysInCurMonth += 1
        '                    Else
        '                        w.TableForCurMonth(i) = 0
        '                    End If
        '                Next
        '            End While
        '        End Using
        '    End If
        '    If ComboWorkshops.SelectedIndex = 0 Then
        '        ComboWorkshops_SelectedIndexChanged(ComboWorkshops, Nothing) 'Обновляем табель
        '    Else
        '        ComboWorkshops.SelectedIndex = 0 'Показываем мойку
        '    End If
        '    RecountWorkers()
        '    Worker.CalculateAllHourCosts()
        'Catch ex As Exception
        'End Try
    End Sub

    Public Sub LoadSchedule(Optional RefreshHash As Boolean = False)
        Try
            Log("Loading schedule")
            sc1Path = Application.StartupPath & "\data\" & CStr(curDate.Year) & "\" & CStr(curDate.Month) & "\" & CStr(curDate.Day) & CStr(CurSche) & "sc.ini"
            sc2Path = Application.StartupPath & "\data\" & CStr(nextDay.Year) & "\" & CStr(nextDay.Month) & "\" & CStr(nextDay.Day) & CStr(CurSche) & "sc.ini"
            dSchedule1.Rows.Clear() 'Очищаем сегодняшние записи
            dSchedule2.Rows.Clear() 'Очищаем завтрашние записи
            comboTLS.SelectedIndex = 1
            ComboTLS2.SelectedIndex = 1
            Dim curRow As String()
            For i = START_HOUR To END_HOUR - 1
                dSchedule1.Rows.Add(CStr(i) & ":00", "", "", "+", "-")
                dSchedule1.Rows.Add(CStr(i) & ":30", "", "", "+", "-")
                dSchedule2.Rows.Add(CStr(i) & ":00", "", "", "+", "-")
                dSchedule2.Rows.Add(CStr(i) & ":30", "", "", "+", "-")
            Next
            If My.Computer.FileSystem.FileExists(sc1Path) Then
                Using sc1File As New Microsoft.VisualBasic.FileIO.TextFieldParser(sc1Path)
                    sc1File.TextFieldType = FileIO.FieldType.Delimited
                    sc1File.SetDelimiters("|")
                    Dim ji As Integer = 0
                    While Not sc1File.EndOfData
                        curRow = sc1File.ReadFields
                        dSchedule1.Rows(ji).SetValues(curRow(0), curRow(1), curRow(2))
                        ji += 1
                    End While
                End Using
            End If
            If My.Computer.FileSystem.FileExists(sc2Path) Then
                Using sc2File As New Microsoft.VisualBasic.FileIO.TextFieldParser(sc2Path)
                    sc2File.TextFieldType = FileIO.FieldType.Delimited
                    sc2File.SetDelimiters("|")
                    Dim ji As Integer = 0
                    While Not sc2File.EndOfData
                        curRow = sc2File.ReadFields
                        dSchedule2.Rows(ji).SetValues(curRow(0), curRow(1), curRow(2))
                        ji += 1
                    End While
                End Using
            End If
            If RefreshHash Then
                If My.Computer.FileSystem.FileExists(sc1Path) Then
                    Using stream As System.IO.Stream = System.IO.File.OpenRead(sc1Path)
                        sc1HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    End Using
                Else
                    sc1HashCode = Nothing
                End If
                If My.Computer.FileSystem.FileExists(sc2Path) Then
                    Using stream As System.IO.Stream = System.IO.File.OpenRead(sc2Path)
                        sc2HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    End Using
                End If
            Else
                sc2HashCode = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadAdvance()
        Try
            Log("Loading advance")
            Dim CurRow As String()
            For Each wrkr In Worker.AllOfThem
                wrkr.wBonus = 0
                wrkr.wOtherPayments = 0
                wrkr.wAdvance = 0
                wrkr.wOtherCharges = 0
            Next
            If My.Computer.FileSystem.FileExists(dPath & "\Advance.ini") Then
                Using tFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(dPath & "\Advance.ini")
                    tFile.TextFieldType = FileIO.FieldType.Delimited
                    tFile.SetDelimiters("|")
                    Dim curType As Integer
                    While Not tFile.EndOfData
                        CurRow = tFile.ReadFields
                        If CurRow.Length = 1 Then
                            Select Case CurRow(0)
                                Case "[Advance]"
                                    curType = 1
                                Case "[Bonus]"
                                    curType = 2
                                Case "[OP]"
                                    curType = 3
                                Case "[OC]"
                                    curType = 4
                            End Select
                        Else
                            Select Case curType
                                Case 1
                                    Worker.FindByID(CInt(CurRow(0))).wAdvance = CDbl(CurRow(1))
                                Case 2
                                    Worker.FindByID(CInt(CurRow(0))).wBonus = CDbl(CurRow(1))
                                Case 3
                                    Worker.FindByID(CInt(CurRow(0))).wOtherPayments = CDbl(CurRow(1))
                                Case 4
                                    Worker.FindByID(CInt(CurRow(0))).wOtherCharges = CDbl(CurRow(1))
                            End Select
                        End If
                    End While
                End Using
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadDebts()
        Try
            Log("Loading debts")
            Dim CurRow As String()
            If My.Computer.FileSystem.FileExists(dPath & "\Debts.ini") Then
                Using dFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(dPath & "\Debts.ini")
                    dFile.TextFieldType = FileIO.FieldType.Delimited
                    dFile.SetDelimiters("|")
                    CurRow = dFile.ReadFields
                    NextDebtID = CInt(CurRow(0))
                    Dim i As Integer = 0
                    While Not dFile.EndOfData
                        CurRow = dFile.ReadFields
                        DebtID(i, 0) = CInt(CurRow(0))
                        DebtID(i, 1) = CInt(CurRow(1))
                        i += 1
                    End While
                End Using
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadState()
        Try
            Log("Loading state")
            Worker.Clear()
            Dim curRow As String()
            Using tFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\State.ini")
                tFile.TextFieldType = FileIO.FieldType.Delimited
                tFile.SetDelimiters("|")
                Worker.nextID = CInt(tFile.ReadFields(0))
                Dim curShop As Integer
                While Not tFile.EndOfData
                    curRow = tFile.ReadFields
                    Select Case curRow(0)
                        Case "[Wash]"
                            curShop = 0
                        Case "[Mount]"
                            curShop = 1
                        Case "[Service]"
                            curShop = 2
                        Case Else
                            Dim w As New Worker(CInt(curRow(0)), curRow(1), curRow(2), curRow(3), curShop, curRow(4), CLng(curRow(5)), CInt(curRow(6)), CBool(curRow(7)))
                    End Select
                End While
            End Using
            comboMaster.Items.Clear()
            comboExecutor.Items.Clear()
            For Each w As Worker In Worker.AllOfThem
                If w.GetWorkshopInt = 2 Then
                    If w.GetJob.ToLower = "мастер" Then comboMaster.Items.Add(w.FullName)
                    comboExecutor.Items.Add(w.FullName)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Sub LoadCustomers()
        Dim curRow As String()
        Try
            Log("Loading customers")
            HCOrder.KillAll()
            HCCustomer.KillAll()
            LoadExecutors()
            LoadProviders()
            Using cFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\Customers.ini")
                cFile.TextFieldType = FileIO.FieldType.Delimited
                cFile.SetDelimiters("|")
                While Not cFile.EndOfData
                    curRow = cFile.ReadFields
                    If curRow.Count = 1 Then
                        HCCustomer.GlobalID = CUInt(curRow(0))
                    Else
                        Dim newCustomer = New HCCustomer(CInt(curRow(0)), curRow(2), curRow(1), curRow(3), curRow(4), curRow(5))
                    End If
                End While
            End Using
        Catch ex As Exception
        End Try
        Try
            Log("Loading orders")
            Using oFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Orders.ini")
                oFile.TextFieldType = FileIO.FieldType.Delimited
                oFile.SetDelimiters("|")
                curRow = oFile.ReadFields
                HCOrder.GlobalID = CUInt(curRow(0))
                curRow = oFile.ReadFields
                HCPart.GlobalID = CUInt(curRow(0))
                While Not oFile.EndOfData
                    curRow = oFile.ReadFields
                    Dim PartList = New List(Of HCPart)
                    For i = 11 To curRow.Length - 1 Step 8
                        Dim newPart = New HCPart(CInt(curRow(i)), curRow(i + 1), CUInt(curRow(i + 2)), curRow(i + 3), Double.Parse(curRow(i + 4), culture), Double.Parse(curRow(i + 5), culture), Nothing, HCProvider.GetByID(CInt(curRow(i + 6))), CBool(curRow(i + 7)))
                        PartList.Add(newPart)
                    Next
                    Dim newOrder = New HCOrder(curRow(0), HCCustomer.FindByID(CInt(curRow(1))), HCExecutor.GetById(CInt(curRow(2))), Date.Parse(curRow(7)), Double.Parse(curRow(6), culture), Date.Parse(curRow(5)), Double.Parse(curRow(4), culture), Date.Parse(curRow(3)), 0, PartList, CBool(curRow(8)))
                    newOrder.Discount = CDbl(curRow(9))
                    newOrder.Comment = curRow(10)
                End While
            End Using
            If TabControl1.SelectedTab Is tabCustomersOrders Then RefreshCustomersAndOrders()
        Catch ex As Exception
        End Try
    End Sub

    Sub LoadExecutors()
        Try
            Log("Loading executors")
            HCExecutor.KillAll()
            Dim curRow As String()
            Using eFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\Executors.ini")
                eFile.TextFieldType = FileIO.FieldType.Delimited
                eFile.SetDelimiters("|")
                While Not eFile.EndOfData
                    curRow = eFile.ReadFields
                    Dim newExec = New HCExecutor(CInt(curRow(0)), curRow(1), curRow(2), curRow(3), curRow(4))
                End While
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Sub LoadUnits()
        Try
            Log("Loading units")
            HCPart.UnitsList.Clear()
            Dim curRow As String()
            Using uFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\Units.ini")
                uFile.TextFieldType = FileIO.FieldType.Delimited
                uFile.SetDelimiters("|")
                While Not uFile.EndOfData
                    curRow = uFile.ReadFields
                    HCPart.UnitsList.Add(curRow(0))
                End While
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Sub LoadProviders()
        Try
            Log("Loading providers")
            HCProvider.ProviderList.Clear()
            Dim curRow As String()
            Using pFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\Providers.ini")
                pFile.TextFieldType = FileIO.FieldType.Delimited
                pFile.SetDelimiters("|")
                curRow = pFile.ReadFields
                HCProvider.GlobalID = CInt(curRow(0))
                While Not pFile.EndOfData
                    curRow = pFile.ReadFields
                    Dim newProv As New HCProvider(CInt(curRow(0)), curRow(1))
                End While
            End Using
            RefreshProviders()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RefreshProviderFilter()
        Dim index As Integer = cmnProvider.Index
        For Each row As DataGridViewRow In dgvPayments.Rows
            Dim foundFlag As Boolean = False
            For Each item As String In comboProviderFilter.Items
                If item = row.Cells(index).Value Then foundFlag = True
            Next
            If Not foundFlag And Not row.Cells(index).Value Is Nothing Then comboProviderFilter.Items.Add(row.Cells(index).Value)
        Next
    End Sub

    Public Sub LoadPayments()
        If SavingPayments Then
            Log("Saving payments now! Could not load payments")
            Exit Sub
        End If
        Try
            Log("Loading payments")
            comboProviderFilter.Items.Clear()
            comboProviderFilter.Items.Add("Показать все")
            dgvPayments.Rows.Clear()
            Dim curRow As String()
            Using pFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\" & curDate.Year.ToString & "\Payments.ini")
                pFile.TextFieldType = FileIO.FieldType.Delimited
                pFile.SetDelimiters("|")
                While Not pFile.EndOfData
                    curRow = pFile.ReadFields
                    AddPayment(curRow(0), curRow(1), curRow(2), curRow(3), curRow(4), curRow(5), curRow(6))
                End While
            End Using
            RefreshProviders()
            RefreshProviderFilter()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Процедура загрузки формы
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadProcedure(ByVal DateOfLoad As Date)
        'Static RunCount As Integer
        'RunCount += 1
        'MsgBox(CStr(RunCount))
        LoadProcedureRunning = True
        Log("Load procedure started")
        curDate = DateOfLoad 'Устанавливаем дату для сверки
        nextDay = curDate.AddDays(1) 'Устанавливаем следующий день
        curDatePicker.Value = curDate 'Устанавливаем дату в элемент выбора даты
        dtpFrom.Value = curDate.AddDays(1 - curDate.Day) 'Устанавливаем значения DateTimePicker'ов на вкладке "Аналитика"
        dtpTo.Value = curDate.AddDays(Date.DaysInMonth(curDate.Year, curDate.Month) - curDate.Day) 'Устанавливаем значения DateTimePicker'ов на вкладке "Аналитика"
        comboMonth.SelectedIndex = curDate.Month - 1
        comboYear.Text = CStr(curDate.Year)
        ComboBox2.SelectedIndex = 6
        'Устанавливаем переменные файловых путей:
        fPath = Application.StartupPath & "\data\" & CStr(curDate.Year) & "\" & CStr(curDate.Month)
        nddPath = Application.StartupPath & "\data\" & CStr(nextDay.Year) & "\" & CStr(nextDay.Month)
        ndPath = nddPath & "\" & CStr(nextDay.Day) & "ndtmp.ini"
        cdPath = Application.StartupPath & "\data\" & CStr(curDate.Year) & "\" & CStr(curDate.Month) & "\" & CStr(curDate.Day) & "ndtmp.ini"
        sc1Path = Application.StartupPath & "\data\" & CStr(curDate.Year) & "\" & CStr(curDate.Month) & "\" & CStr(curDate.Day) & CStr(CurSche) & "sc.ini"
        sc2Path = Application.StartupPath & "\data\" & CStr(nextDay.Year) & "\" & CStr(nextDay.Month) & "\" & CStr(nextDay.Day) & CStr(CurSche) & "sc.ini"
        If DayMode Then ePath = My.Computer.FileSystem.CombinePath(fPath, CStr(curDate.Day) & ".xlsx") Else ePath = My.Computer.FileSystem.CombinePath(fPath, CStr(curDate.Day) & "N.xlsx")
        emPath = My.Computer.FileSystem.CombinePath(fPath, CStr(curDate.Day) & "M.xlsx")
        rPath = Application.StartupPath & "\Report.xlsx"
        rmPath = Application.StartupPath & "\MReport.xlsx"
        dPath = fPath
        cPath = My.Computer.FileSystem.CombinePath(dPath, CStr(curDate.Day) & "c.ini")
        fmPath = My.Computer.FileSystem.CombinePath(fPath, CStr(curDate.Day) & "m.ini")
        sPath = My.Computer.FileSystem.CombinePath(fPath, CStr(curDate.Day) & "s.ini")
        nPath = My.Computer.FileSystem.CombinePath(fPath, CStr(curDate.Day) & "N.ini")
        tPath = My.Computer.FileSystem.CombinePath(fPath, "Table.ini")
        If DayMode Then fPath = My.Computer.FileSystem.CombinePath(fPath, CStr(curDate.Day) & ".ini") Else fPath = nPath

        'Работаем со штатом и табелем:
        'Считываем работников:
        If LOADING Then 'Только при первом запуске:
            LoadState()
        End If

        zpWorkshops.SelectedIndex = 0 'Заполняем работников на вкладке "ЗП"

        'Работаем с папкой месяца:
        If My.Computer.FileSystem.DirectoryExists(dPath) Then
            LoadWash()
            LoadMount()
            LoadService()
            LoadCash()
            LoadSchedule()
            LoadTable()
            LoadAdvance()
            LoadDebts()
            LoadPayments()
        Else
            If Not WriteRight = WriteRights.Read_Only Then My.Computer.FileSystem.CreateDirectory(dPath)
        End If
        LoadCustomers()

        If Not My.Computer.FileSystem.DirectoryExists(nddPath) And Not WriteRight = WriteRights.Read_Only Then My.Computer.FileSystem.CreateDirectory(nddPath)
        'Считываем цены:
        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\GroupsPrice.ini")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("=")
                Dim currentRow As String()
                Dim j As UInteger = 0
                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields
                    comment(j) = currentRow(0)
                    If currentRow.GetLength(0) <> WASH_GROUP_COUNT + 1 Then
                        For i = 1 To WASH_GROUP_COUNT
                            WashPrices(i, j) = currentRow(1)
                        Next
                        GoTo 7
                    End If
                    For i = 1 To WASH_GROUP_COUNT
                        WashPrices(i, j) = currentRow(i)
                    Next
7:
                    j += 1
                End While
            End Using
        Catch ex As Exception
        End Try

        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\MountPrice.ini")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("=")
                Dim currentRow As String()
                Dim j As UInteger = 1
                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields
                    mcomment(j) = currentRow(0)
                    If currentRow.GetLength(0) <> MOUNT_GROUP_COUNT + 1 Then
                        For i = 1 To MOUNT_GROUP_COUNT
                            MountPrices(i, j) = currentRow(1)
                        Next
                        GoTo 8
                    End If
                    For i = 1 To MOUNT_GROUP_COUNT
                        MountPrices(i, j) = currentRow(i)
                    Next
8:
                    j += 1
                End While
            End Using
        Catch ex As Exception
        End Try

        'Сразу присвоим кастомные цены на лисапед и мотоциклы:
        bicycle1Price = WashPrices(1, 30)
        bike1Price = WashPrices(2, 30)
        bike2Price = WashPrices(3, 30)
        'Заполняем строку статистики:
        Dim strWashDayTotal As String = CStr(CountAverage(1, Date.DaysInMonth(curDate.Year, curDate.Month), dPath, ".ini", 6, True))
        Dim strWashNightTotal As String = CStr(CountAverage(1, Date.DaysInMonth(curDate.Year, curDate.Month), dPath, "N.ini", 6, True))
        Dim strMountTotal As String = CStr(CountAverage(1, Date.DaysInMonth(curDate.Year, curDate.Month), dPath, "m.ini", 6, True))
        Dim strServiceTotal As String = CStr(CountAverage(1, Date.DaysInMonth(curDate.Year, curDate.Month), dPath, "s.ini", 7, True))
        Dim strTotal As String = CStr(CInt(strWashDayTotal) + CInt(strWashNightTotal) + CInt(strMountTotal) + CInt(strServiceTotal))
        Label19.Text = Form2.NumberToMonth(curDate.Month) & ": Дневная выручка по мойке: " & strWashDayTotal & " Ночная выручка по мойке: " & strWashNightTotal & " Выручка по шиномонтажу: " & strMountTotal & " Выручка по сервису: " & strServiceTotal & " Общая выручка: " & strTotal
        'Заполнение хэш-кодов
        If My.Computer.FileSystem.FileExists(fPath) Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(fPath)
                WashHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(fmPath) Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(fmPath)
                MountHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(sPath) Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(sPath)
                ServiceHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(cPath) Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(cPath)
                CashHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(tPath) Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(tPath)
                TableHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(sc1Path) Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(sc1Path)
                sc1HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(sc2Path) Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(sc2Path)
                sc2HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(dPath & "\Advance.ini") Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(dPath & "\Advance.ini")
                AdvanceHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(dPath & "\Debts.ini") Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(dPath & "\Debts.ini")
                DebtsHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\data\State.ini") Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\State.ini")
                StateHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\data\Customers.ini") Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Customers.ini")
                CustomersHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Orders.ini") Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Orders.ini")
                OrdersHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
        UpdateExecHC()
        UpdateProvHC()
        UpdatePaymentsHC()

        'Завершающие процедуры:
        FillPrices()
        RecountRows()
        If LOADING Then
            CreateWatchers()
        Else
            UpdateWatchers()
        End If
        LoadProcedureRunning = False
        Log("Load procedure finished")
    End Sub

    Public Sub UpdatePaymentsHC()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Payments.ini") Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Payments.ini")
                PaymentsHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
    End Sub

    Public Sub UpdateExecHC()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\data\Executors.ini") Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Executors.ini")
                ExecutorsHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
    End Sub

    Public Sub UpdateProvHC()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\data\Providers.ini") Then
            Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Providers.ini")
                ProvHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        End If
    End Sub

    Private Sub LoadDiscounts()
        Try
            Log("Loading discounts")
            DiscountCombo.Items.Clear()
            'Читаем скидки:
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\Discounts.ini")
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters("=")
                Dim currentRow As String()
                Dim j As UInteger = 0
                While Not MyReader.EndOfData
                    currentRow = MyReader.ReadFields
                    DiscountCombo.Items.Add(currentRow(0))
                    DiscountValues(j) = CInt(currentRow(1))
                    j += 1
                End While
            End Using
            DiscountCombo.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub


    ''' <summary>
    ''' Заполняет переменные ценами текущей группы
    ''' </summary>
    Public Sub FillPrices()
        Select Case ServiceMode
            Case 0
                curGr = Nothing
                If RadioButton1.Checked Then
                    curGr = 1
                ElseIf RadioButton2.Checked Then
                    curGr = 2
                ElseIf RadioButton3.Checked Then
                    curGr = 3
                ElseIf RadioButton4.Checked Then
                    curGr = 4
                ElseIf RadioButton5.Checked Then
                    curGr = 5
                    Exit Sub
                End If
                plexPrice = WashPrices(curGr, 0)
                bodyPrice = WashPrices(curGr, 1)
                expressPrice = WashPrices(curGr, 2)
                waxPrice = WashPrices(curGr, 3)
                showerPrice = WashPrices(curGr, 4)
                drivePrice = WashPrices(curGr, 5)
                bottomPrice = WashPrices(curGr, 6)
                cabinPrice = WashPrices(curGr, 7)
                vacuumPrice = WashPrices(curGr, 8)
                trunkPrice = WashPrices(curGr, 9)
                wetPrice = WashPrices(curGr, 10)
                carpetsPrice = WashPrices(curGr, 11)
                glassPrice = WashPrices(curGr, 12)
                frontGlassPrice = WashPrices(curGr, 13)
                polishTorpPrice = WashPrices(curGr, 14)
                polishPlasticPrice = WashPrices(curGr, 15)
                leatherPrice = WashPrices(curGr, 16)
                arcPrice = WashPrices(curGr, 17)
                arcFoamPrice = WashPrices(curGr, 18)
                discInsidePressurePrice = WashPrices(curGr, 19)
                discInsideFoamPrice = WashPrices(curGr, 20)
                blackTyrePrice = WashPrices(curGr, 21)
                blackBumpPrice = WashPrices(curGr, 22)
                blackMouldPrice = WashPrices(curGr, 23)
                airBlowPrice = WashPrices(curGr, 24)
                resinSiliconePrice = WashPrices(curGr, 25)
                carpWashPrice = WashPrices(curGr, 26)
                carpChemPrice = WashPrices(curGr, 27)
                locksWDPrice = WashPrices(curGr, 28)
                techWashPrice = WashPrices(curGr, 29)
            Case 1
                curGr = Nothing
                If RadioButton10.Checked Then
                    curGr = 1
                ElseIf RadioButton11.Checked Then
                    curGr = 2
                ElseIf RadioButton12.Checked Then
                    curGr = 3
                ElseIf RadioButton13.Checked Then
                    curGr = 4
                ElseIf RadioButton14.Checked Then
                    curGr = 5
                ElseIf RadioButton15.Checked Then
                    curGr = 6
                ElseIf RadioButton16.Checked Then
                    curGr = 7
                ElseIf RadioButton17.Checked Then
                    curGr = 8
                ElseIf RadioButton18.Checked Then
                    curGr = 9
                Else
                    Exit Sub
                End If
        End Select
        Commit()
    End Sub

    ''' <summary>
    ''' Процедура загрузки списка марок автомобилей из файлов CarsDBgX.ini
    ''' </summary>
    ''' <remarks>Стоило реализовать всё в одном файле вместо нескольких, но теперь уже лень...</remarks>
    Public Sub LoadCars()
        Try
            Log("Loading cars")
            For i = 1 To WASH_GROUP_COUNT
                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\CarsDBg" & CStr(i) & ".ini")
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters("=")
                    Dim currentRow As String()
                    Dim currentField As String
                    Dim currentCar As Car
                    While Not MyReader.EndOfData
                        currentRow = MyReader.ReadFields()
                        For Each currentField In currentRow
                            currentCar = New Car(currentField, i)
                            ComboBox1.Items.Add(currentField)
                        Next
                    End While
                End Using
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox2.Visible = True
            GroupBox4.Visible = False
            FillPrices()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupBox2.Visible = True
            GroupBox4.Visible = False
            FillPrices()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            GroupBox2.Visible = True
            GroupBox4.Visible = False
            FillPrices()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GroupBox2.Visible = True
            GroupBox4.Visible = False
            FillPrices()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = False Then
            RadioButton6.Checked = False
            RadioButton7.Checked = False
        Else
            GroupBox2.Visible = False
            GroupBox4.Visible = True
        End If
        FillPrices()
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As System.EventArgs) Handles ComboBox1.Enter
        If ComboBox1.Text = "Введите марку машины..." Then ComboBox1.Text = ""
    End Sub

    Private Sub ComboBox1_LostFocus(sender As Object, e As System.EventArgs) Handles ComboBox1.LostFocus
        If ComboBox1.Text = "" Then ComboBox1.Text = "Введите марку машины..."
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Select Case Car.carStack.Item(ComboBox1.SelectedIndex + 1).GetGroup()
        '    Case 1
        '        RadioButton1.Checked = True
        '    Case 2
        '        RadioButton2.Checked = True
        '    Case 3
        '        RadioButton3.Checked = True
        '    Case 4
        '        RadioButton4.Checked = True
        'End Select
    End Sub

    Private Sub plexBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles plexBox.CheckedChanged
        bodyBox.Checked = plexBox.Checked
        cabinBox.Checked = plexBox.Checked
    End Sub

    Private Sub bodyBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles bodyBox.CheckedChanged
        If bodyBox.Checked Then
            showerBox.Checked = False
            expressBox.Checked = False
            techWashBox.Checked = False
        Else
            If plexBox.Checked Then bodyBox.Checked = True
        End If
        'expressBox.Enabled = Not bodyBox.Checked
        'showerBox.Enabled = Not bodyBox.Checked
    End Sub

    Private Sub cabinBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cabinBox.CheckedChanged
        wetBox.Checked = cabinBox.Checked
        vacuumBox.Checked = cabinBox.Checked
        If cabinBox.Checked Then
            If carpetsBox.Checked = False And napCarpetsBox.Checked = False Then carpetsBox.Checked = True
        ElseIf plexBox.Checked Then
            cabinBox.Checked = True
        Else
            carpetsBox.Checked = False
            napCarpetsBox.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' Проверяет все галочки из раздела "Салон" и ставит галочку "Салон" если они все проставлены
    ''' </summary>
    Public Sub CheckForCabin()
        If wetBox.CheckState = CheckState.Unchecked Or vacuumBox.CheckState = CheckState.Unchecked Or carpetsBox.CheckState = CheckState.Unchecked Then cabinBox.Checked = False
    End Sub

    ''' <summary>
    ''' Таймер для разных служебных нужд
    ''' </summary>
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Commit()
        Timer1.Enabled = False
    End Sub

    Private Sub glassBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles glassBox.CheckedChanged
        frontGlassBox.Checked = glassBox.Checked
    End Sub

    Private Sub arcBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles arcBox.CheckedChanged
        If arcBox.Checked = True Then arcFoamBox.Checked = False
    End Sub

    Private Sub arcFoamBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles arcFoamBox.CheckedChanged
        If arcFoamBox.Checked = True Then arcBox.Checked = False
    End Sub

    Private Sub AnyBoxChecked() Handles plexBox.CheckedChanged, airBox.CheckedChanged, arcBox.CheckedChanged, arcFoamBox.CheckedChanged, blackBumperBox.CheckedChanged, blackMouldBox.CheckedChanged, blackTyreBox.CheckedChanged, bodyBox.CheckedChanged, bottomBox.CheckedChanged, cabinBox.CheckedChanged, carpetsBox.CheckedChanged, discBox.CheckedChanged, discFoamBox.CheckedChanged, driveBox.CheckedChanged, expressBox.CheckedChanged, frontGlassBox.CheckedChanged, glassBox.CheckedChanged, leatherBox.CheckedChanged, napCarpetsBox.CheckedChanged, polishPlasticBox.CheckedChanged, polishTorpBox.CheckedChanged, resinBox.CheckedChanged, showerBox.CheckedChanged, stainBitumenBox.CheckedChanged, trunkBox.CheckedChanged, chemCarpetsBox.CheckedChanged, vacuumBox.CheckedChanged, waxBox.CheckedChanged, WD40Box.CheckedChanged, wetBox.CheckedChanged, serviceBox1.CheckedChanged, serviceBox2.CheckedChanged, serviceBox3.CheckedChanged, serviceBox4.CheckedChanged, serviceBox5.CheckedChanged, serviceBox6.CheckedChanged, serviceBox7.CheckedChanged, serviceBox8.CheckedChanged, serviceBox9.CheckedChanged, serviceBox10.CheckedChanged, serviceBox11.CheckedChanged, serviceBox12.CheckedChanged, serviceBox13.CheckedChanged, serviceBox14.CheckedChanged, serviceBox15.CheckedChanged, CarpCounter.ValueChanged, udStain.ValueChanged, nud1.ValueChanged, nud2.ValueChanged, nud3.ValueChanged, nud4.ValueChanged, nud5.ValueChanged, nud6.ValueChanged, nud7.ValueChanged, nud8.ValueChanged, nud9.ValueChanged, nud10.ValueChanged, nud11.ValueChanged, nud12.ValueChanged, nud13.ValueChanged, nud14.ValueChanged, nud15.ValueChanged
        Commit()
    End Sub

    Private Function AnyWheelGroupChecked() As Boolean
        If RadioButton10.Checked Or RadioButton11.Checked Or RadioButton12.Checked Or RadioButton13.Checked Or RadioButton14.Checked Or RadioButton15.Checked Or RadioButton16.Checked Or RadioButton17.Checked Or RadioButton18.Checked Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AddRecordButton_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click, Button4.Click, Button7.Click
        'Проверка на лисапед:
        If RadioButton6.Checked Or RadioButton7.Checked Then
            ComboBox1.Text = "Велосипед"
            txtNumber.Text = "--"
        End If

        'Проверка на дурака:
        If ComboBox1.Text = "Введите марку машины..." Then
            MsgBox("Вы забыли ввести марку машины!", MsgBoxStyle.Critical, "Внимание!")
            Exit Sub
        ElseIf txtNumber.Text = "... и номер машины" Then
            MsgBox("Вы забыли ввести номер машины!", MsgBoxStyle.Critical, "Внимание!")
            Exit Sub
        ElseIf ServiceMode = 1 And Not AnyWheelGroupChecked() Then
            MsgBox("Пожалуйста, выберите группу колеса", MsgBoxStyle.Critical, "Ахтунг!")
            Exit Sub
        End If

        'Всё ОК, начинаем работу:
        Button1.Enabled = False
        Button1.Text = "..."
        Application.DoEvents()
        Dim service As String = ""
        Select Case ServiceMode
            Case 0
                'На первый взгляд сложный алгоритм образования строки услуг автомойки:
                If RadioButton5.Checked Then
                    If RadioButton6.Checked Then
                        service = "Велосипед (облив)"
                        ' ElseIf RadioButton7.Checked Then
                        'service = "Велосипед (пена)"
                    ElseIf RadioButton8.Checked Then
                        service = "Мотоцикл (облив)"
                    ElseIf RadioButton9.Checked Then
                        service = "Мотоцикл (пена)"
                    End If
                Else
                    If plexBox.Checked Then
                        service = "Комплекс"
                    Else
                        If bodyBox.Checked Then
                            service = "Кузов"
                        ElseIf showerBox.Checked Then
                            service = "Облив"
                        ElseIf expressBox.Checked Then
                            service = "Экспресс"
                        ElseIf techWashBox.Checked Then
                            service = "Тех.мойка"
                        Else
                            service = "Без кузова"
                        End If
                        If cabinBox.Checked Then
                            service = service & SVC_DIVIDER & "Салон"
                        Else
                            If wetBox.Checked Then service = service & SVC_DIVIDER & "Влажная уборка"
                            If vacuumBox.Checked Then service = service & SVC_DIVIDER & "Пылесос"
                            If carpetsBox.Checked Then service = service & SVC_DIVIDER & "Коврики x" & CStr(CarpCounter.Value)
                        End If
                    End If
                    If waxBox.Checked Then service = service & SVC_DIVIDER & "Воск"
                    If trunkBox.Checked Then service = service & SVC_DIVIDER & "Багажник"
                    If airBox.Checked Then service = service & SVC_DIVIDER & "Продувка"
                    If driveBox.Checked Then service = service & SVC_DIVIDER & "Двигатель"
                    If bottomBox.Checked Then service = service & SVC_DIVIDER & "Днище"
                    If glassBox.Checked Then service = service & SVC_DIVIDER & "Стёкла" Else If frontGlassBox.Checked Then service = service & SVC_DIVIDER & "Лобовое стекло"
                    If polishTorpBox.Checked Then service = service & SVC_DIVIDER & "Полировка торпеды"
                    If polishPlasticBox.Checked Then service = service & SVC_DIVIDER & "Полировка пластика"
                    If leatherBox.Checked Then service = service & SVC_DIVIDER & "Кондиционер кожи"
                    If arcBox.Checked Then service = service & SVC_DIVIDER & "Арки" Else If arcFoamBox.Checked Then service = service & SVC_DIVIDER & "Арки (пена)"
                    If discBox.Checked Then service = service & SVC_DIVIDER & "Диски (давл.)" Else If discFoamBox.Checked Then service = service & SVC_DIVIDER & "Диски (пена)"
                    If blackTyreBox.Checked Then service = service & SVC_DIVIDER & "Чернение шин"
                    If blackBumperBox.Checked Then service = service & SVC_DIVIDER & "Чернение бамперов"
                    If blackMouldBox.Checked Then service = service & SVC_DIVIDER & "Чернение молдингов"
                    If stainBitumenBox.Checked Then service = service & SVC_DIVIDER & "Удаление пятен"
                    If resinBox.Checked Then service = service & SVC_DIVIDER & "Резиновые уплотнители (силикон)"
                    If WD40Box.Checked Then service = service & SVC_DIVIDER & "Замки WD-40"
                    If napCarpetsBox.Checked Then service = service & SVC_DIVIDER & "Мойка: " & txtSquare.Text & " м.кв."
                    If chemCarpetsBox.Checked Then service = service & SVC_DIVIDER & "Химчистка: " & txtSquare.Text & " м.кв."
                    If OtherBox.CheckState = CheckState.Checked Then service = service & SVC_DIVIDER & OtherText.Text & " (" & CStr(OtherNUD.Value) & ")"
                End If
                If DayMode Then
                    If OweBox.CheckState = CheckState.Unchecked Then
                        AddRecord(curID, CLng(dayCC), ComboBox1.Text, txtNumber.Text, service, FormattedTime(), CLng(sum), curGr)
                        AddCash("Автомойка", curDate.ToString("dd.MM.yyyy"), FormattedTime(), sum, 0, ComboBox1.Text & " " & txtNumber.Text & "; " & service)
                        SaveCash()
                    Else
                        AddRecord(curID, CLng(dayCC), ComboBox1.Text, txtNumber.Text, service, FormattedTime(), CLng(sum), curGr)
                        AddDebt(curID)
                        curID += 1
                        SaveDebts()
                    End If
                Else
                    If OweBox.CheckState = CheckState.Unchecked Then
                        AddRecord(curID, CLng(dayCC), ComboBox1.Text, txtNumber.Text, service, "Ночь", CLng(sum), curGr)
                        AddCash("Автомойка", curDate.ToString("dd.MM.yyyy"), "Ночь", sum, 0, ComboBox1.Text & " " & txtNumber.Text & "; " & service)
                        SaveCash()
                    Else
                        AddRecord(curID, CLng(dayCC), ComboBox1.Text, txtNumber.Text, service, "Ночь", CLng(sum), curGr)
                        AddDebt(curID)
                        curID += 1
                        SaveDebts()
                    End If
                End If
                SaveWash()
            Case 1
                'На первый взгляд простой алгоритм образования строки услуг шиномонтажа:
                If serviceBox1.Checked Then service = service & serviceBox1.Text & " x" & CStr(nud1.Value) & SVC_DIVIDER
                If serviceBox2.Checked Then service = service & serviceBox2.Text & " x" & CStr(nud2.Value) & SVC_DIVIDER
                If serviceBox3.Checked Then service = service & serviceBox3.Text & " x" & CStr(nud3.Value) & SVC_DIVIDER
                If serviceBox4.Checked Then service = service & serviceBox4.Text & " x" & CStr(nud4.Value) & SVC_DIVIDER
                If serviceBox5.Checked Then service = service & serviceBox5.Text & " x" & CStr(nud5.Value) & SVC_DIVIDER
                If serviceBox6.Checked Then service = service & serviceBox6.Text & " x" & CStr(nud6.Value) & SVC_DIVIDER
                If serviceBox7.Checked Then service = service & serviceBox7.Text & " x" & CStr(nud7.Value) & SVC_DIVIDER
                If serviceBox8.Checked Then service = service & serviceBox8.Text & " x" & CStr(nud8.Value) & SVC_DIVIDER
                If serviceBox9.Checked Then service = service & serviceBox9.Text & " x" & CStr(nud9.Value) & SVC_DIVIDER
                If serviceBox10.Checked Then service = service & serviceBox10.Text & " x" & CStr(nud10.Value) & SVC_DIVIDER
                If serviceBox11.Checked Then service = service & serviceBox11.Text & " x" & CStr(nud11.Value) & SVC_DIVIDER
                If serviceBox12.Checked Then service = service & serviceBox12.Text & " x" & CStr(nud12.Value) & SVC_DIVIDER
                If serviceBox13.Checked Then service = service & serviceBox13.Text & " x" & CStr(nud13.Value) & SVC_DIVIDER
                If serviceBox14.Checked Then service = service & serviceBox14.Text & " x" & CStr(nud14.Value) & SVC_DIVIDER
                If serviceBox15.Checked Then service = service & serviceBox15.Text & " x" & CStr(nud15.Value) & SVC_DIVIDER
                If ServiceBox16.Checked Then service = service & ServiceBox16.Text & " x" & CStr(nud16.Value) & SVC_DIVIDER
                If ServiceBox17.Checked Then service = service & ServiceBox17.Text & " x" & CStr(nud17.Value) & SVC_DIVIDER
                If OtherBox2.CheckState = CheckState.Checked Then service = service & OtherText2.Text & " (" & CStr(OtherNUD2.Value) & ")" & SVC_DIVIDER
                If service = "" Then
                    MsgBox("Вы забыли выбрать услуги!", MsgBoxStyle.Critical)
                    GoTo 9
                End If
                service = service.Remove(service.Length - 2, 2)
                If OweBox2.CheckState = CheckState.Unchecked Then
                    AddRecord(CLng(curID), DayCCMount, ComboBox1.Text, txtNumber.Text, service, FormattedTime(), sum, curGr)
                    AddCash("Шиномонтаж", curDate.ToString("dd.MM.yyyy"), FormattedTime(), sum, 0, ComboBox1.Text & " " & txtNumber.Text & "; " & service)
                Else
                    AddRecord(curID, DayCCMount, ComboBox1.Text, txtNumber.Text, service, FormattedTime(), sum, curGr)
                    AddDebt(curID)
                    curID += 1
                    SaveDebts()
                End If
                SaveMount()
                SaveCash()
            Case 2
                Dim Executor As String = ""
                If listExecutors.Items.Count = 0 Then
                    Executor = comboExecutor.Text
                Else
                    For Each item In listExecutors.Items
                        Executor &= item & ", "
                    Next
                    Executor = Executor.Remove(Executor.Length - 2, 2)
                End If
                AddRecord(CLng(curID), DayCCService, ComboBox1.Text, txtNumber.Text, FormattedTime, workBox.Text, CLng(WorkDiscounted.Text), partsBox.Text, CLng(PartsSumDiscounted.Text), comboMaster.Text, Executor, CLng(PartsOutDiscounted.Text))
                If OweBox3.CheckState = CheckState.Checked Then
                    AddDebt(curID)
                    curID += 1
                    SaveDebts()
                Else
                    If partsBox.Text <> "" Or (partsSumBox.Text <> "0" And partsSumBox.Text <> "") Or (partsOutBox.Text <> "0" And partsOutBox.Text <> "") Then
                        AddCash("Автосервис", CLng(WorkDiscounted.Text) + CLng(PartsSumDiscounted.Text), CLng(PartsOutDiscounted.Text), ComboBox1.Text & " " & txtNumber.Text & "; Работы: " & workBox.Text & ". Расходные материалы: " & partsBox.Text & " на сумму " & partsSumBox.Text & "; Мастер: " & comboMaster.Text & ", исполнители: " & Executor)
                    Else
                        AddCash("Автосервис", CLng(WorkDiscounted.Text), 0, ComboBox1.Text & " " & txtNumber.Text & "; Работы: " & workBox.Text & "; Мастер: " & comboMaster.Text & ", исполнители: " & Executor)
                    End If
                    SaveCash()
                End If
                SaveService()
        End Select
        Me.Clear()
        FillPrices()
9:
        Button1.Enabled = True
        Button1.Text = "Записать >>"
    End Sub

    Public Sub AddDebt(ID As Integer)
        DebtID(NextDebtID, 0) = curDate.Day
        DebtID(NextDebtID, 1) = ID
        NextDebtID += 1
    End Sub

    Public Sub RemoveDebt(dID As Integer)
        DebtID(dID, 0) = 0
    End Sub

    ''' <summary>
    ''' Добавляет запись в базу данных автомойки или шиномонтажа
    ''' </summary>
    ''' <param name="uintCount">Порядкоый номер записи</param>
    ''' <param name="strMark">Марка машины</param>
    ''' <param name="strNumber">Номер машины</param>
    ''' <param name="strService">Услуга</param>
    ''' <param name="strTime">Время</param>
    ''' <param name="uintSum">Сумма</param>
    ''' <param name="uintGroup">Группа</param>
    ''' <param name="SMode">Режим (0 - автомойка, 1 - шиномонтаж)</param>
    Public Sub AddRecord(ulngID As Long, uintCount As Long, strMark As String, strNumber As String, strService As String, strTime As String, uintSum As Long, Optional uintGroup As Long = 0, Optional SMode As Integer = -9)
        Dim rowcount As Integer
        Select Case SMode
            Case -9
                Select Case ServiceMode
                    Case 0
                        GoTo 0
                    Case 1
                        GoTo 1
                End Select
            Case 0
                GoTo 0
            Case 1
                GoTo 1
        End Select
0:
        rowcount = dataDay.RowCount - 1
        dataDay.Rows.Add()
        dataDay.Item(0, rowcount).Value = CStr(uintCount)
        dataDay.Item(1, rowcount).Value = strTime
        dataDay.Item(2, rowcount).Value = strMark
        dataDay.Item(3, rowcount).Value = strNumber
        dataDay.Item(4, rowcount).Value = strService
        dataDay.Item(5, rowcount).Value = CStr(uintGroup)
        dataDay.Item(6, rowcount).Value = CStr(uintSum)
        dataDay.Item(7, rowcount).Value = CStr(ulngID)
        dataDay.ClearSelection()
        dayCC += 1
        dataDay.FirstDisplayedScrollingRowIndex = dataDay.RowCount - 1
        Exit Sub
1:
        rowcount = dataDayMount.RowCount - 1
        dataDayMount.Rows.Add()
        dataDayMount.Item(0, rowcount).Value = CStr(uintCount)
        dataDayMount.Item(1, rowcount).Value = strTime
        dataDayMount.Item(2, rowcount).Value = strMark
        dataDayMount.Item(3, rowcount).Value = strNumber
        dataDayMount.Item(4, rowcount).Value = strService
        dataDayMount.Item(5, rowcount).Value = CStr(uintGroup)
        dataDayMount.Item(6, rowcount).Value = CStr(uintSum)
        dataDayMount.Item(7, rowcount).Value = CStr(ulngID)
        dataDayMount.ClearSelection()
        DayCCMount += 1
        dataDayMount.FirstDisplayedScrollingRowIndex = dataDayMount.RowCount - 1
        Exit Sub
    End Sub

    ''' <summary>
    ''' Добавляет запись во вкладке автосервиса
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub AddRecord(ulngID As Long, ulngCount As Long, strMark As String, strNumber As String, strTime As String, strService As String, ulngServiceSum As Long, strParts As String, ulngPartsSum As Long, strMaster As String, strExecutor As String, Optional ulngPartsOut As Long = 0)
        Dim rowcount As Integer
        rowcount = dataService.RowCount - 1
        dataService.Rows.Add()
        dataService.Item(0, rowcount).Value = CStr(ulngCount)
        dataService.Item(1, rowcount).Value = strTime
        dataService.Item(2, rowcount).Value = strMark
        dataService.Item(3, rowcount).Value = strNumber
        dataService.Item(4, rowcount).Value = strService
        dataService.Item(5, rowcount).Value = strMaster
        dataService.Item(6, rowcount).Value = strExecutor
        dataService.Item(7, rowcount).Value = CStr(ulngServiceSum)
        dataService.Item(8, rowcount).Value = strParts
        dataService.Item(9, rowcount).Value = CStr(ulngPartsSum)
        dataService.Item(10, rowcount).Value = CStr(ulngPartsOut)
        dataService.Item(11, rowcount).Value = CStr(ulngID)
        dataService.ClearSelection()
        DayCCService += 1
        dataService.FirstDisplayedScrollingRowIndex = dataService.RowCount - 1
    End Sub

    Public Sub AddCash(strOperation As String, ulngIncome As Long, ulngOutcome As Long, strComment As String)
        AddCash(strOperation, curDate.ToString("dd.MM.yyyy"), FormattedTime, ulngIncome, ulngOutcome, strComment)
    End Sub

    Public Sub AddCash(strOperation As String, strDate As String, strTime As String, uintIncome As Long, uintOutcome As Long, strComment As String)
        Dim rowcount As Integer
        rowcount = dCash.RowCount - 1
        dCash.Rows.Add()
        dCash.Item(0, rowcount).Value = curID
        curID += 1
        dCash.Item(1, rowcount).Value = strOperation
        dCash.Item(2, rowcount).Value = strDate
        dCash.Item(3, rowcount).Value = strTime
        dCash.Item(4, rowcount).Value = CStr(uintIncome)
        dCash.Item(5, rowcount).Value = CStr(uintOutcome)
        dCash.Item(6, rowcount).Value = strComment
        dCash.ClearSelection()
        dCash.FirstDisplayedScrollingRowIndex = dCash.RowCount - 1
    End Sub

    Public Sub AddCash(strID As String, strOperation As String, strDate As String, strTime As String, strIncome As String, strOutcome As String, strComment As String)
        Dim rowcount As Integer
        rowcount = dCash.RowCount - 1
        dCash.Rows.Add()
        dCash.Item(0, rowcount).Value = strID
        dCash.Item(1, rowcount).Value = strOperation
        dCash.Item(2, rowcount).Value = strDate
        dCash.Item(3, rowcount).Value = strTime
        dCash.Item(4, rowcount).Value = strIncome
        dCash.Item(5, rowcount).Value = strOutcome
        dCash.Item(6, rowcount).Value = strComment
        dCash.ClearSelection()
        dCash.FirstDisplayedScrollingRowIndex = dCash.RowCount - 1
    End Sub

    Public Sub AddPayment(strID As String, stroID As String, strOperation As String, strDate As String, strIncome As String, strOutcome As String, strComment As String)
        Dim rowcount As Integer
        rowcount = dgvPayments.RowCount
        dgvPayments.Rows.Add({strID, stroID, strOperation, strDate, strIncome, strOutcome, strComment})
        'dgvPayments.Item(0, rowcount).Value = strID
        'dgvPayments.Item(1, rowcount).Value = stroID
        'dgvPayments.Item(2, rowcount).Value = strOperation
        'dgvPayments.Item(3, rowcount).Value = strDate
        'dgvPayments.Item(4, rowcount).Value = strIncome
        'dgvPayments.Item(5, rowcount).Value = strOutcome
        'dgvPayments.Item(6, rowcount).Value = strComment
        'dgvPayments.Rows(rowcount).SetValues({strID, strPID, strOperation, strDate, strTime, strIncome, strOutcome, strComment})
        dgvPayments.ClearSelection()
        dgvPayments.FirstDisplayedScrollingRowIndex = dgvPayments.RowCount - 1
        SavePayments()
    End Sub

    ''' <summary>
    ''' Возвращает текущее время в формате String (xx:xx)
    ''' </summary>
    Public Function FormattedTime() As String
        Dim tmpHour As String
        Dim tmpMinute As String
        tmpHour = My.Computer.Clock.LocalTime.Hour
        tmpMinute = My.Computer.Clock.LocalTime.Minute
        If tmpHour.Length = 1 Then tmpHour = "0" & tmpHour
        If tmpMinute.Length = 1 Then tmpMinute = "0" & tmpMinute
        Return tmpHour & ":" & tmpMinute
        tmpHour = Nothing
        tmpMinute = Nothing
    End Function

    ''' <summary>
    ''' Сохраняет списки оказанных услуг в файлы fPath и fmPath
    ''' </summary>
    Public Sub SaveAll()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving all...")
        SaveWash()
        SaveMount()
        SaveService()
        SaveCash()
        SaveSchedule()
        SaveTable()
        SaveState()
        SaveAdvance()
        SaveDebts()
        SaveCustomers()
        SaveProviders()
        SavePayments()
        'SavePrincess()
        'SaveWorld()
        'SaveYourself()
    End Sub

    Public Sub SaveWash()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving wash...")
        RecountRows()
        Dim tmpSTR As String = ""
        If Not DayMode Then tmpSTR = CStr(CurNightWorkerID) & vbNewLine
        For i = 0 To dataDay.RowCount - 2
            tmpSTR = tmpSTR & dataDay.Item(0, i).Value & "|"
            tmpSTR = tmpSTR & dataDay.Item(2, i).Value & "|"
            tmpSTR = tmpSTR & dataDay.Item(5, i).Value & "|"
            tmpSTR = tmpSTR & dataDay.Item(3, i).Value & "|"
            tmpSTR = tmpSTR & dataDay.Item(4, i).Value & "|"
            tmpSTR = tmpSTR & dataDay.Item(1, i).Value & "|"
            tmpSTR = tmpSTR & dataDay.Item(6, i).Value & "|"
            tmpSTR = tmpSTR & dataDay.Item(7, i).Value & vbNewLine
        Next
        My.Computer.FileSystem.WriteAllText(fPath, tmpSTR, False)
        Application.DoEvents()
        Using stream As System.IO.Stream = System.IO.File.OpenRead(fPath)
            WashHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Public Sub SaveMount()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving mount...")
        RecountRows()
        Dim tmpSTR As String = ""
        For i = 0 To dataDayMount.RowCount - 2
            tmpSTR = tmpSTR & dataDayMount.Item(0, i).Value & "|"
            tmpSTR = tmpSTR & dataDayMount.Item(2, i).Value & "|"
            tmpSTR = tmpSTR & dataDayMount.Item(5, i).Value & "|"
            tmpSTR = tmpSTR & dataDayMount.Item(3, i).Value & "|"
            tmpSTR = tmpSTR & dataDayMount.Item(4, i).Value & "|"
            tmpSTR = tmpSTR & dataDayMount.Item(1, i).Value & "|"
            tmpSTR = tmpSTR & dataDayMount.Item(6, i).Value & "|"
            tmpSTR = tmpSTR & dataDayMount.Item(7, i).Value & vbNewLine
        Next
        My.Computer.FileSystem.WriteAllText(fmPath, tmpSTR, False)
        Application.DoEvents()
        Using stream As System.IO.Stream = System.IO.File.OpenRead(fmPath)
            MountHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Public Sub SaveService()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving service...")
        RecountRows()
        Dim tmpSTR As String = ""
        For i = 0 To dataService.RowCount - 2
            For j = 0 To dataService.ColumnCount - 1
                tmpSTR = tmpSTR & dataService.Item(j, i).Value & "|"
            Next
            tmpSTR = tmpSTR.Remove(tmpSTR.Length - 1)
            tmpSTR = tmpSTR & vbNewLine
        Next
        My.Computer.FileSystem.WriteAllText(sPath, tmpSTR, False)
        Application.DoEvents()
        Using stream As System.IO.Stream = System.IO.File.OpenRead(sPath)
            ServiceHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Public Sub SaveCash()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving cash...")
        Dim tmpSTR As String = CStr(curID) & vbNewLine
        For i = 0 To dCash.RowCount - 2
            For j = 0 To dCash.ColumnCount - 1
                tmpSTR = tmpSTR & dCash.Item(j, i).Value & "|"
            Next j
            tmpSTR = tmpSTR.Remove(tmpSTR.Length - 1)
            tmpSTR = tmpSTR & vbNewLine
        Next i
        My.Computer.FileSystem.WriteAllText(cPath, tmpSTR, False)
        tmpSTR = CStr(cSum)
        My.Computer.FileSystem.WriteAllText(ndPath, tmpSTR, False)
        Application.DoEvents()
        Using stream As System.IO.Stream = System.IO.File.OpenRead(cPath)
            CashHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Dim SavingPayments As Boolean = False
    Public Sub SavePayments()
        SavingPayments = True
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving payments...")
        Dim tmpSTR As String = ""
        For i = 0 To dgvPayments.RowCount - 1
            For j = 0 To dgvPayments.ColumnCount - 1
                tmpSTR = tmpSTR & dgvPayments.Item(j, i).Value & "|"
            Next j
            tmpSTR = tmpSTR.Remove(tmpSTR.Length - 1)
            tmpSTR = tmpSTR & vbNewLine
        Next i
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\data\" & curDate.Year.ToString & "\Payments.ini", tmpSTR, False)
        Application.DoEvents()
        UpdatePaymentsHC()
        SavingPayments = False
    End Sub

    Dim ScheduleSaving As Boolean = False
    Public Sub SaveSchedule()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving schedule...")
        Dim tmpSTR As String = ""
        For i = 0 To dSchedule1.RowCount - 1
            For j = 0 To dSchedule1.ColumnCount - 1
                tmpSTR = tmpSTR & dSchedule1.Item(j, i).Value & "|"
            Next j
            tmpSTR = tmpSTR.Remove(tmpSTR.Length - 1)
            tmpSTR = tmpSTR & vbNewLine
        Next i
        My.Computer.FileSystem.WriteAllText(sc1Path, tmpSTR, False)
        tmpSTR = ""
        For i = 0 To dSchedule2.RowCount - 1
            For j = 0 To dSchedule2.ColumnCount - 1
                tmpSTR = tmpSTR & dSchedule2.Item(j, i).Value & "|"
            Next j
            tmpSTR = tmpSTR.Remove(tmpSTR.Length - 1)
            tmpSTR = tmpSTR & vbNewLine
        Next i
        My.Computer.FileSystem.WriteAllText(sc2Path, tmpSTR, False)

        ScheduleTimer.Start()
        ScheduleSaving = True
    End Sub

    Public Sub SaveTable()
        'If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        'Log("Saving table...")
        'Dim tmpSTR As String = ""
        'For i = 0 To dTable.RowCount - 1
        '    tmpSTR = tmpSTR & dTable.Item("dTable_ID", i).Value & "|"
        '    For j = 3 To dTable.ColumnCount - 1
        '        tmpSTR = tmpSTR & dTable.Item(j, i).Value & "|" & CStr(dTable.Item(j, i).Style.BackColor.R) & "|" & CStr(dTable.Item(j, i).Style.BackColor.G) & "|" & CStr(dTable.Item(j, i).Style.BackColor.B) & "|"
        '    Next
        '    tmpSTR = tmpSTR.Remove(tmpSTR.Length - 1)
        '    tmpSTR = tmpSTR & vbNewLine
        'Next
        'My.Computer.FileSystem.WriteAllText(tPath, tmpSTR, False)
        'Application.DoEvents()
        'Using stream As System.IO.Stream = System.IO.File.OpenRead(tPath)
        '    TableHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        'End Using
    End Sub

    Public Sub SaveAdvance()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving advance...")
        Dim tmpSTR As String = "[Advance]" & vbNewLine
        For Each w In Worker.AllOfThem
            If w.wAdvance <> 0 Then
                tmpSTR = tmpSTR & w.GetID & "|" & CStr(w.wAdvance) & vbNewLine
            End If
        Next
        tmpSTR &= "[Bonus]" & vbNewLine
        For Each w In Worker.AllOfThem
            If w.wAdvance <> 0 Then
                tmpSTR = tmpSTR & w.GetID & "|" & CStr(w.wBonus) & vbNewLine
            End If
        Next
        tmpSTR &= "[OP]" & vbNewLine
        For Each w In Worker.AllOfThem
            If w.wAdvance <> 0 Then
                tmpSTR = tmpSTR & w.GetID & "|" & CStr(w.wOtherPayments) & vbNewLine
            End If
        Next
        tmpSTR &= "[OC]" & vbNewLine
        For Each w In Worker.AllOfThem
            If w.wAdvance <> 0 Then
                tmpSTR = tmpSTR & w.GetID & "|" & CStr(w.wOtherCharges) & vbNewLine
            End If
        Next
        My.Computer.FileSystem.WriteAllText(dPath & "\Advance.ini", tmpSTR, False)
        Application.DoEvents()
        Using stream As System.IO.Stream = System.IO.File.OpenRead(dPath & "\Advance.ini")
            AdvanceHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Public Sub SaveDebts()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving debts")
        Dim ReduceFor As Integer = 0
        Dim tmpSTR As String = CStr(NextDebtID) & vbNewLine
        For i = 0 To NextDebtID - 1
            If DebtID(i, 0) = 0 Then
                ReduceFor += 1
                Continue For
            End If
            tmpSTR &= CStr(DebtID(i, 0)) & "|" & CStr(DebtID(i, 1)) & vbNewLine
        Next
        If ReduceFor <> 0 Then
            tmpSTR = tmpSTR.Remove(0, CStr(NextDebtID).Length)
            NextDebtID -= ReduceFor
            tmpSTR &= CStr(NextDebtID)
        End If
        My.Computer.FileSystem.WriteAllText(dPath & "\Debts.ini", tmpSTR, False)
        Application.DoEvents()
        Using stream As System.IO.Stream = System.IO.File.OpenRead(dPath & "\Debts.ini")
            DebtsHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Public Sub SaveState()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving state...")
        Dim tmpSTR As String = CStr(Worker.nextID) & vbNewLine
        For i = 0 To 2
            Select Case i
                Case 0
                    tmpSTR = tmpSTR & "[Wash]" & vbNewLine
                Case 1
                    tmpSTR = tmpSTR & "[Mount]" & vbNewLine
                Case 2
                    tmpSTR = tmpSTR & "[Service]" & vbNewLine
            End Select
            For Each wrkr In Worker.AllOfThem
                If wrkr.GetWorkshopInt = i Then
                    tmpSTR = tmpSTR & CStr(wrkr.GetID) & "|" & wrkr.GetName & "|" & wrkr.Get2Name & "|" & wrkr.GetPatron & "|" & wrkr.GetJob & "|" & CStr(wrkr.GetSalary) & "|" & CStr(wrkr.GetNorm) & "|" & CStr(wrkr.wFixedSalary) & vbNewLine
                End If
            Next
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\data\State.ini", tmpSTR, False)
        Application.DoEvents()
        Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\State.ini")
            StateHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Sub SaveCustomers()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        SaveExecutors()
        Log("Saving customers...")
        Dim TextToWrite As String = CStr(HCCustomer.GlobalID) & vbNewLine
        For Each Customer In CustomerList
            TextToWrite &= Customer.ID.ToString & "|"
            TextToWrite &= Customer.LastName & "|" & Customer.FirstName & "|" & Customer.Patron & "|"
            TextToWrite &= Customer.Phone & "|" & Customer.Address & vbNewLine
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\data\Customers.ini", TextToWrite, False)
        Log("Saving orders...")
        TextToWrite = CStr(HCOrder.GlobalID) & vbNewLine
        TextToWrite &= CStr(HCPart.GlobalID) & vbNewLine
        For Each Order In OrderList
            TextToWrite &= Order.Number.GetFullNumber & "|"
            TextToWrite &= CStr(Order.Customer.ID) & "|"
            If Order.Executor Is Nothing Then
                TextToWrite &= "-1|"
            Else
                TextToWrite &= CStr(Order.Executor.ID) & "|"
            End If
            TextToWrite &= Order.AdvanceDate.ToString & "|" & Order.AdvanceSum.ToString(specifier, culture) & "|"
            TextToWrite &= Order.PaymentDate.ToString & "|" & Order.PaymentSum.ToString(specifier, culture) & "|"
            TextToWrite &= Order.DeliveryDate.ToString & "|" & Order.Completed.ToString() & "|"
            TextToWrite &= Order.Discount.ToString(specifier, culture) & "|" & Order.Comment & "|"
            For Each Part In Order.PartList
                Dim PartProviderID As String
                If Part.Provider Is Nothing Then
                    PartProviderID = "-1"
                Else
                    PartProviderID = Part.Provider.ID.ToString
                End If
                TextToWrite &= Part.ID.ToString() & "|" & Part.Name & "|" & Part.Count.ToString & "|" & Part.Units & "|" & Part.Price.ToString(specifier, culture) & "|" & Part.Margin.ToString(specifier, culture) & "|" & PartProviderID & "|" & Part.PaymentAdded.ToString & "|"
            Next
            TextToWrite = TextToWrite.Remove(TextToWrite.Length - 1)
            TextToWrite &= vbNewLine
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Orders.ini", TextToWrite, False)

        Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Customers.ini")
            CustomersHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
        Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Orders.ini")
            OrdersHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Sub SaveExecutors()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving executors...")
        Dim ttw As String = ""
        For Each exec As HCExecutor In HCExecutor.ExecList
            ttw &= exec.ID.ToString & "|"
            ttw &= exec.LastName & "|"
            ttw &= exec.FirstName & "|"
            ttw &= exec.Patronage & "|"
            ttw &= exec.Phone & vbNewLine
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\data\Executors.ini", ttw, False)
        Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Executors.ini")
            ExecutorsHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Sub SaveProviders()
        If WriteRight = WriteRights.Read_Only Or LoadProcedureRunning Then Exit Sub
        Log("Saving providers...")
        Dim ttw As String = HCProvider.GlobalID.ToString & vbNewLine
        For Each prov In HCProvider.ProviderList
            ttw &= prov.ID.ToString & "|"
            ttw &= prov.Name & vbNewLine
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\data\Providers.ini", ttw, False)
        Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Providers.ini")
            ProvHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As System.EventArgs) Handles txtNumber.Enter
        If txtNumber.Text = "... и номер машины" Then txtNumber.Clear()
    End Sub

    Private Sub txtNumber_LostFocus(sender As Object, e As System.EventArgs) Handles txtNumber.LostFocus
        If txtNumber.Text = "" Then txtNumber.Text = "... и номер машины"
    End Sub

    Private Sub Report(Optional ByVal Silently As Boolean = True)
        '    Dim Exc As New Microsoft.Office.Interop.Excel.Application
        '    Me.Enabled = False
        '     'Exc = CreateObject("Excel.Application")
        '    If Not Silently And ServiceMode = 0 Then Exc.Visible = True
        '    Exc.Workbooks.Open(rPath).Activate()
        '    Dim tmpStr As String
        '    tmpStr = ""
        '    If CStr(My.Computer.Clock.LocalTime.Day).Length = 1 Then tmpStr = tmpStr & "0"
        '    tmpStr = tmpStr & My.Computer.Clock.LocalTime.Date.Day & "."
        '    If CStr(My.Computer.Clock.LocalTime.Month).Length = 1 Then tmpStr = tmpStr & "0"
        '    tmpStr = tmpStr & CStr(My.Computer.Clock.LocalTime.Date.Month) & "."
        '    tmpStr = tmpStr & CStr(My.Computer.Clock.LocalTime.Date.Year)
        '    Exc.Cells(2, 4) = tmpStr
        '    If DayMode Then
        '        Exc.Cells(2, 2) = "Дневной отчет за"
        '    Else
        '        Exc.Cells(2, 2) = "Ночной отчет за"
        '    End If
        '    For i = 0 To dataDay.RowCount - 1
        '        Exc.Cells(i + 5, 2) = dataDay.Item("cmnCount", i).Value
        '        Exc.Cells(i + 5, 3) = dataDay.Item("cmnTime", i).Value
        '        Exc.Cells(i + 5, 4) = dataDay.Item("cmnMark", i).Value
        '        Exc.Cells(i + 5, 5) = dataDay.Item("cmnNumber", i).Value
        '        Exc.Cells(i + 5, 6) = dataDay.Item("cmnService", i).Value
        '        Exc.Cells(i + 5, 7) = dataDay.Item("cmnSum", i).Value
        '    Next
        '    If My.Computer.FileSystem.FileExists(ePath) Then My.Computer.FileSystem.DeleteFile(ePath)
        '    Exc.ActiveWorkbook.SaveAs(ePath)
        '    If Silently Or ServiceMode = 1 Then
        '        Threading.Thread.Sleep(1500)
        '        Exc.ActiveWorkbook.Close()
        '        Exc.Quit()
        '    End If
        '    Exc = Nothing
        '    Exc = New Microsoft.Office.Interop.Excel.Application
        '    If Not Silently And ServiceMode = 1 Then Exc.Visible = True
        '    Exc.Workbooks.Open(rmPath).Activate()
        '    tmpStr = ""
        '    If CStr(My.Computer.Clock.LocalTime.Day).Length = 1 Then tmpStr = tmpStr & "0"
        '    tmpStr = tmpStr & My.Computer.Clock.LocalTime.Date.Day & "."
        '    If CStr(My.Computer.Clock.LocalTime.Month).Length = 1 Then tmpStr = tmpStr & "0"
        '    tmpStr = tmpStr & CStr(My.Computer.Clock.LocalTime.Date.Month) & "."
        '    tmpStr = tmpStr & CStr(My.Computer.Clock.LocalTime.Date.Year)
        '    Exc.Cells(2, 4) = tmpStr
        '    Exc.Cells(2, 2) = "Дневной отчет за"
        '    For i = 0 To dataDayMount.RowCount - 1
        '        Exc.Cells(i + 5, 2) = dataDayMount.Item("mCount", i).Value
        '        Exc.Cells(i + 5, 3) = dataDayMount.Item("mTime", i).Value
        '        Exc.Cells(i + 5, 4) = dataDayMount.Item("mMark", i).Value
        '        Exc.Cells(i + 5, 5) = dataDayMount.Item("mNumber", i).Value
        '        Exc.Cells(i + 5, 6) = dataDayMount.Item("mService", i).Value
        '        Exc.Cells(i + 5, 7) = dataDayMount.Item("mSum", i).Value
        '    Next
        '    If My.Computer.FileSystem.FileExists(emPath) Then My.Computer.FileSystem.DeleteFile(emPath)
        '    Exc.ActiveWorkbook.SaveAs(emPath)
        '    If Silently Or ServiceMode = 0 Then
        '        Threading.Thread.Sleep(1500)
        '        Exc.ActiveWorkbook.Close()
        '        Exc.Quit()
        '    End If
        '    Me.Enabled = True
        '    Exc = Nothing
        '    tmpStr = Nothing
    End Sub

    ''' <summary>
    ''' Таймер для обнаружения смены даты и перехода в соответствующий режим
    ''' </summary>
    Private Sub midnightTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles midnightTimer.Tick
        If curDate.Day <> My.Computer.Clock.LocalTime.Day Then
            SaveAll()
            LoadProcedure(My.Computer.Clock.LocalTime.Date)
        End If
    End Sub

    Private Sub CarpCounter_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarpCounter.ValueChanged
        Commit()
    End Sub

    Private Sub showerBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showerBox.CheckedChanged
        If showerBox.Checked Then
            bodyBox.Checked = False
            expressBox.Checked = False
            plexBox.Checked = False
            techWashBox.Checked = False
        End If
    End Sub

    Private Sub expressBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles expressBox.CheckedChanged
        If expressBox.Checked Then
            showerBox.Checked = False
            bodyBox.Checked = False
            plexBox.Checked = False
            techWashBox.Checked = False
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = GLOBAL_PASSWORD And WriteRight <> WriteRights.Read_Only Then
            Static Title As String
            ComboBox1.Text = "Введите марку машины..."
            ComboBox1.SelectAll()
            GlobalMode = 1 - GlobalMode
            Select Case GlobalMode
                Case 1
                    For i = 0 To dataDay.ColumnCount - 1
                        dataDay.Columns.Item(i).ReadOnly = False
                    Next
                    For i = 0 To dataDayMount.ColumnCount - 1
                        dataDayMount.Columns.Item(i).ReadOnly = False
                    Next
                    For i = 0 To dataService.ColumnCount - 1
                        dataService.Columns.Item(i).ReadOnly = False
                    Next
                    Title = Me.Text
                    Me.Text = Title & " - РЕЖИМ РЕДАКТИРОВАНИЯ"
                Case 0
                    For i = 0 To dataDay.ColumnCount - 1
                        dataDay.Columns.Item(i).ReadOnly = True
                    Next
                    For i = 0 To dataDayMount.ColumnCount - 1
                        dataDayMount.Columns.Item(i).ReadOnly = True
                    Next
                    For i = 0 To dataService.ColumnCount - 1
                        dataService.Columns.Item(i).ReadOnly = True
                    Next
                    Me.Text = Title
            End Select
            dataDay.ClearSelection()
            dataDayMount.ClearSelection()
        End If
    End Sub

    Private Sub dataDay_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDay.CellDoubleClick
        If GlobalMode = 1 Then
            If MsgBox("Удалить запись?!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DelID As Long = 9999
                DelID = CLng(dataDay.Item(7, e.RowIndex).Value)
                dataDay.Rows.RemoveAt(e.RowIndex)
                For i = 0 To dCash.RowCount - 1
                    Try
                        If CLng(dCash.Item(0, i).Value) = DelID Then
                            dCash.Rows.RemoveAt(i)
                            SaveCash()
                            Exit For
                        End If
                    Catch ex As Exception
                    End Try
                Next
            End If
        End If
        RecountRows()
        Commit()
        SaveWash()
    End Sub

    ''' <summary>
    ''' Пересчитывает записи в таблицах и меняет индексы записей так, чтобы не было пропусков
    ''' </summary>
    Public Sub RecountRows()
        Dim lastRN As Integer
        lastRN = 0
        For i = 0 To dataDay.RowCount - 2
            If dataDay.Item("cmnCount", i).Value - 1 <> lastRN Then dataDay.Item("cmnCount", i).Value = lastRN + 1
            lastRN = dataDay.Item("cmnCount", i).Value
            dayCC = i + 2
        Next
        lastRN = 0
        For i = 0 To dataDayMount.RowCount - 2
            If dataDayMount.Item("mCount", i).Value - 1 <> lastRN Then dataDayMount.Item("mCount", i).Value = lastRN + 1
            lastRN = dataDayMount.Item("mCount", i).Value
            DayCCMount = i + 2
        Next
        lastRN = 0
        For i = 0 To dataService.RowCount - 2
            If dataService.Item(0, i).Value - 1 <> lastRN Then dataService.Item(0, i).Value = lastRN + 1
            lastRN = dataService.Item(0, i).Value
            DayCCMount = i + 2
        Next
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            ComboBox1.Text = "Велосипед"
            txtNumber.Text = "--"
        Else
            ComboBox1.Text = "Введите марку машины..."
            txtNumber.Text = "... и номер машины"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            ComboBox1.Text = "Ковёр"
            txtNumber.Text = "--"
        Else
            ComboBox1.Text = "Введите марку машины..."
            txtNumber.Text = "... и номер машины"
        End If
    End Sub

    ''' <summary>
    ''' Сбрасывает все "галочки" на форме
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Clear()
        'clearing all checkboxes:
        plexBox.CheckState = CheckState.Unchecked
        bodyBox.CheckState = CheckState.Unchecked
        cabinBox.CheckState = CheckState.Unchecked
        wetBox.CheckState = CheckState.Unchecked
        vacuumBox.CheckState = CheckState.Unchecked
        carpetsBox.CheckState = CheckState.Unchecked
        expressBox.CheckState = CheckState.Unchecked
        showerBox.CheckState = CheckState.Unchecked
        waxBox.CheckState = CheckState.Unchecked
        trunkBox.CheckState = CheckState.Unchecked
        airBox.CheckState = CheckState.Unchecked
        driveBox.CheckState = CheckState.Unchecked
        bottomBox.CheckState = CheckState.Unchecked
        glassBox.CheckState = CheckState.Unchecked
        frontGlassBox.CheckState = CheckState.Unchecked
        polishTorpBox.CheckState = CheckState.Unchecked
        polishPlasticBox.CheckState = CheckState.Unchecked
        arcBox.CheckState = CheckState.Unchecked
        arcFoamBox.CheckState = CheckState.Unchecked
        blackBumperBox.CheckState = CheckState.Unchecked
        blackMouldBox.CheckState = CheckState.Unchecked
        blackTyreBox.CheckState = CheckState.Unchecked
        stainBitumenBox.CheckState = CheckState.Unchecked
        WD40Box.CheckState = CheckState.Unchecked
        discBox.CheckState = CheckState.Unchecked
        discFoamBox.CheckState = CheckState.Unchecked
        resinBox.CheckState = CheckState.Unchecked
        leatherBox.CheckState = CheckState.Unchecked
        OtherBox.CheckState = CheckState.Unchecked
        OtherBox2.CheckState = CheckState.Unchecked
        napCarpetsBox.CheckState = CheckState.Unchecked
        chemCarpetsBox.CheckState = CheckState.Unchecked
        techWashBox.CheckState = CheckState.Unchecked

        'clearing other:
        CarpCounter.Value = 4
        txtNumber.Text = "... и номер машины"
        ComboBox1.Text = "Введите марку машины..."
        OtherText.Text = "Другие услуги"
        OtherText2.Text = "Другие услуги"
        RadioButton1.Checked = True
        OweBox.CheckState = CheckState.Unchecked
        OweBox2.CheckState = CheckState.Unchecked
        DiscountCombo.SelectedIndex = 0
        listExecutors.Items.Clear()
        DiscountNud.Value = 0
        DiscountCombo.SelectedIndex = 0


        'clearing mount checkboxes:
        serviceBox1.CheckState = CheckState.Unchecked
        serviceBox2.CheckState = CheckState.Unchecked
        serviceBox3.CheckState = CheckState.Unchecked
        serviceBox4.CheckState = CheckState.Unchecked
        serviceBox5.CheckState = CheckState.Unchecked
        serviceBox6.CheckState = CheckState.Unchecked
        serviceBox7.CheckState = CheckState.Unchecked
        serviceBox8.CheckState = CheckState.Unchecked
        serviceBox9.CheckState = CheckState.Unchecked
        serviceBox10.CheckState = CheckState.Unchecked
        serviceBox11.CheckState = CheckState.Unchecked
        serviceBox12.CheckState = CheckState.Unchecked
        serviceBox13.CheckState = CheckState.Unchecked
        serviceBox14.CheckState = CheckState.Unchecked
        serviceBox15.CheckState = CheckState.Unchecked
        ServiceBox16.CheckState = CheckState.Unchecked
        ServiceBox17.CheckState = CheckState.Unchecked

        'clearing service tab:
        workBox.Text = ""
        workSumBox.Text = "0"
        partsBox.Text = ""
        partsSumBox.Text = "0"
        partsOutBox.Text = "0"
        comboMaster.Text = "Мастер"
        comboExecutor.Text = "Исполнитель"

        'clearing UpDown Counters:
        nud1.Value = 4
        nud2.Value = nud2.Minimum
        nud3.Value = nud3.Minimum
        nud4.Value = nud4.Minimum
        nud5.Value = nud5.Minimum
        nud6.Value = nud6.Minimum
        nud7.Value = nud7.Minimum
        nud8.Value = nud8.Minimum
        nud9.Value = nud9.Minimum
        nud10.Value = nud10.Minimum
        nud11.Value = nud11.Minimum
        nud12.Value = nud12.Minimum
        nud13.Value = nud13.Minimum
        nud14.Value = nud14.Minimum
        nud15.Value = nud15.Minimum
        nud16.Value = nud16.Minimum
        OtherNUD.Value = OtherNUD.Minimum
        OtherNUD2.Value = OtherNUD2.Minimum

        'clearing selection on DataGridViews:
        dCash.ClearSelection()
        dataDay.ClearSelection()
        dataDayMount.ClearSelection()
        dataService.ClearSelection()

        'clearing cash tab:
        AddComboBox.SelectedIndex = 0
        AddIncomeBox.Text = "0"
        AddOutcomeBox.Text = "0"
        AddCommentBox.Text = ""
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If WriteRight = WriteRights.Read_Only Then GoTo 0
        Select Case ServiceMode
            Case 0
                Label12.Show()
                Label1.Show()
                If NightBox.Checked Then
                    lblNightWorkers.Show()
                    ComboNightWorkers.Show()
                End If
                lblDaySum.Show()
            Case 7, 8
                Label12.Hide()
                Label1.Hide()
                lblNightWorkers.Hide()
                ComboNightWorkers.Hide()
                lblDaySum.Hide()
            Case 6, 9
                Label12.Show()
                Label1.Show()
                lblNightWorkers.Hide()
                ComboNightWorkers.Hide()
                lblDaySum.Hide()
            Case Else
                lblNightWorkers.Hide()
                ComboNightWorkers.Hide()
                lblDaySum.Show()
        End Select
0:
        FillPrices()
        Commit()
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        FillPrices()
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        FillPrices()
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        FillPrices()
    End Sub

    Private Sub dataDay_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDay.CellEndEdit
        If e.ColumnIndex = 6 Then
            Dim DelID As Long = 9999
            DelID = CLng(dataDay.Item(7, e.RowIndex).Value)
            For i = 0 To dCash.RowCount - 1
                Try
                    If CLng(dCash.Item(0, i).Value) = DelID Then
                        dCash.Item(4, i).Value = dataDay.Item(6, e.RowIndex).Value
                        SaveCash()
                        Exit For
                    End If
                Catch ex As Exception
                End Try
            Next
        End If
        Commit()
        SaveWash()
    End Sub

    Private Sub curDatePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles curDatePicker.ValueChanged
        If Not LoadProcedureRunning Then SaveAll()
        lblDOW.Text = DOW(curDatePicker.Value)
        lblToday.Text = DOW(curDatePicker.Value, True)
        lblToday.Text = lblToday.Text & " - " & curDatePicker.Value.ToString("dd.MM.yyyy")
        lblTomorrow.Text = DOW(curDatePicker.Value.AddDays(1), True)
        lblTomorrow.Text = lblTomorrow.Text & " - " & curDatePicker.Value.AddDays(1).ToString("dd.MM.yyyy")
        If LoadProcedureRunning Then Exit Sub
        LoadProcedure(curDatePicker.Value)
        Commit()
    End Sub

    Private Sub NightBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles NightBox.CheckedChanged
        If Not LoadProcedureRunning Then SaveWash()
        DayMode = Not NightBox.Checked
        lblDOW.Text = DOW(curDatePicker.Value)
        lblNightWorkers.Visible = Not DayMode And WriteRight <> WriteRights.Read_Only
        ComboNightWorkers.Visible = Not DayMode And WriteRight <> WriteRights.Read_Only
        If LoadProcedureRunning Then Exit Sub
        If DayMode Then
            fPath = Application.StartupPath & "\data\" & CStr(curDate.Year) & "\" & CStr(curDate.Month) & "\" & CStr(curDate.Day) & ".ini"
        Else
            fPath = Application.StartupPath & "\data\" & CStr(curDate.Year) & "\" & CStr(curDate.Month) & "\" & CStr(curDate.Day) & "N.ini"
        End If
        Try
            Using stream As System.IO.Stream = System.IO.File.OpenRead(fPath)
                WashHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
            End Using
        Catch ex As Exception
        End Try
        LoadWash()
        Commit()
    End Sub

    Public Function DOW(DayToTransform As Date, Optional NoNightPlease As Boolean = False) As String
        Select Case DayToTransform.DayOfWeek
            Case DayOfWeek.Monday
                If NightBox.Checked And Not NoNightPlease Then Return "Воскресенье-понедельник" Else Return "Понедельник"
            Case DayOfWeek.Tuesday
                If NightBox.Checked And Not NoNightPlease Then Return "Понедельник-вторник" Else Return "Вторник"
            Case DayOfWeek.Wednesday
                If NightBox.Checked And Not NoNightPlease Then Return "Вторник-среда" Else Return "Среда"
            Case DayOfWeek.Thursday
                If NightBox.Checked And Not NoNightPlease Then Return "Среда-четверг" Else Return "Четверг"
            Case DayOfWeek.Friday
                If NightBox.Checked And Not NoNightPlease Then Return "Четверг-пятница" Else Return "Пятница"
            Case DayOfWeek.Saturday
                If NightBox.Checked And Not NoNightPlease Then Return "Пятница-суббота" Else Return "Суббота"
            Case DayOfWeek.Sunday
                If NightBox.Checked And Not NoNightPlease Then Return "Суббота-воскресенье" Else Return "Воскресенье"
            Case Else
                Return "Неизвестный день недели"
        End Select
    End Function

    Private Sub RadioButton13_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton13.CheckedChanged
        FillPrices()
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton14.CheckedChanged
        FillPrices()
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton15.CheckedChanged
        FillPrices()
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton16.CheckedChanged
        FillPrices()
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton17.CheckedChanged
        FillPrices()
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton18.CheckedChanged
        FillPrices()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If MsgBox("Удалить выбранные записи?", MsgBoxStyle.YesNo, "Осторожно!") = MsgBoxResult.No Then Exit Sub
        Try
            For Each SelectedRow In dCash.SelectedRows
                dCash.Rows.RemoveAt(SelectedRow.Index)
            Next
            Commit()
            SaveCash()
        Catch er As Exception
            MsgBox(er.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dCash_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dCash.CellBeginEdit
        If dCash.SelectedRows(0).Cells(0).Value = "" Then
            dCash.SelectedRows(0).Cells(0).Value = CStr(curID)
            curID += 1
            dCash.SelectedRows(0).Cells(2).Value = My.Computer.Clock.LocalTime.Date.ToString("dd.MM.yyyy")
            dCash.SelectedRows(0).Cells(3).Value = FormattedTime()
        End If
        If dCash.SelectedRows(0).Cells(4).Value = "" Then dCash.SelectedRows(0).Cells(4).Value = "0"
        If dCash.SelectedRows(0).Cells(5).Value = "" Then dCash.SelectedRows(0).Cells(5).Value = "0"
    End Sub

    Private Sub dCash_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dCash.CellEndEdit
        Commit()
        SaveCash()
    End Sub

    Private Sub dataDayMount_CellDoubleClick1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDayMount.CellDoubleClick
        If GlobalMode = 1 Then
            If MsgBox("Удалить запись?!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DelID As Long = 9999
                DelID = CLng(dataDayMount.Item(7, e.RowIndex).Value)
                dataDayMount.Rows.RemoveAt(e.RowIndex)
                For i = 0 To dCash.RowCount - 1
                    Try
                        If CLng(dCash.Item(0, i).Value) = DelID Then
                            dCash.Rows.RemoveAt(i)
                            SaveCash()
                            Exit For
                        End If
                    Catch ex As Exception
                    End Try
                Next
            End If
        End If
        RecountRows()
        Commit()
        SaveMount()
    End Sub

    Private Sub dataDayMount_CellEndEdit1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataDayMount.CellEndEdit
        If e.ColumnIndex = 6 Then
            Dim DelID As Long = 9999
            DelID = CLng(dataDayMount.Item(7, e.RowIndex).Value)
            For i = 0 To dCash.RowCount - 1
                Try
                    If CLng(dCash.Item(0, i).Value) = DelID Then
                        dCash.Item(4, i).Value = dataDayMount.Item(6, e.RowIndex).Value
                        SaveCash()
                        Exit For
                    End If
                Catch ex As Exception
                End Try
            Next
        End If
        Commit()
        SaveMount()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
        Commit()
        If dCash.AllowUserToAddRows = True Then
            Dim Income As Long = 0
            Dim Outcome As Long = 0
            Dim i As Integer = 0
            Do Until i > dCash.RowCount - 2
                If CStr(dCash.Item(0, i).Value).ToLower = "xxx" Then
                    dCash.Rows.RemoveAt(i)
                    Continue Do
                End If
                If dCash.Item(4, i).Value = "" Then dCash.Item(4, i).Value = "0"
                If dCash.Item(5, i).Value = "" Then dCash.Item(5, i).Value = "0"
                Income += CLng(dCash.Item(4, i).Value)
                Outcome += CLng(dCash.Item(5, i).Value)
                i += 1
            Loop
            AddCash("xxx", "День закрыт", curDate.ToString("dd.MM.yyyy"), FormattedTime, CStr(Income) & " р.", CStr(Outcome) & " р.", "В кассе: " & CStr(cSum))
        End If
        SaveCash()
        Form2.LoadCash()
        Form2.Show()
    End Sub

    Private Sub OB2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OweBox2.CheckedChanged
        OweBox.CheckState = OweBox2.CheckState
        OweBox3.CheckState = OweBox2.CheckState
    End Sub

    Private Sub AnyBoxChecked(sender As System.Object, e As System.EventArgs) Handles wetBox.CheckedChanged, WD40Box.CheckedChanged, waxBox.CheckedChanged, vacuumBox.CheckedChanged, udStain.ValueChanged, trunkBox.CheckedChanged, stainBitumenBox.CheckedChanged, serviceBox9.CheckedChanged, serviceBox8.CheckedChanged, serviceBox7.CheckedChanged, serviceBox6.CheckedChanged, serviceBox5.CheckedChanged, serviceBox4.CheckedChanged, serviceBox3.CheckedChanged, serviceBox2.CheckedChanged, ServiceBox16.CheckedChanged, nud16.ValueChanged, serviceBox15.CheckedChanged, serviceBox14.CheckedChanged, serviceBox13.CheckedChanged, serviceBox12.CheckedChanged, serviceBox11.CheckedChanged, serviceBox10.CheckedChanged, serviceBox1.CheckedChanged, resinBox.CheckedChanged, polishTorpBox.CheckedChanged, polishPlasticBox.CheckedChanged, nud9.ValueChanged, nud8.ValueChanged, nud7.ValueChanged, nud6.ValueChanged, nud5.ValueChanged, nud4.ValueChanged, nud3.ValueChanged, nud2.ValueChanged, nud15.ValueChanged, nud14.ValueChanged, nud13.ValueChanged, nud12.ValueChanged, nud11.ValueChanged, nud10.ValueChanged, nud1.ValueChanged, leatherBox.CheckedChanged, frontGlassBox.CheckedChanged, expressBox.CheckedChanged, driveBox.CheckedChanged, discFoamBox.CheckedChanged, discBox.CheckedChanged, CarpCounter.ValueChanged, bottomBox.CheckedChanged, blackTyreBox.CheckedChanged, blackMouldBox.CheckedChanged, blackBumperBox.CheckedChanged, airBox.CheckedChanged, OtherBox.CheckedChanged, OtherNUD.ValueChanged, OtherBox2.CheckedChanged, OtherNUD2.ValueChanged, ServiceBox17.CheckedChanged, nud17.ValueChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged, DiscountNud.ValueChanged, napCarpetsBox.CheckedChanged, chemCarpetsBox.CheckedChanged, showerBox.CheckedChanged, carpetsBox.CheckedChanged
        If sender.name = "wetBox" Or sender.name = "vacuumBox" Or sender.name = "carpetsBox" Then
            If plexBox.Checked Then sender.checked = True
        End If
        Commit()
    End Sub

    Private Sub NapChecked(sender As System.Object, e As System.EventArgs) Handles napCarpetsBox.CheckedChanged
        If napCarpetsBox.CheckState = CheckState.Checked Then
            chemCarpetsBox.CheckState = CheckState.Unchecked
        End If
        Commit()
    End Sub

    Private Sub ChemChecked(sender As System.Object, e As System.EventArgs) Handles chemCarpetsBox.CheckedChanged
        If chemCarpetsBox.CheckState = CheckState.Checked Then
            napCarpetsBox.CheckState = CheckState.Unchecked
        End If
        Commit()
    End Sub

    Private Sub OtherText_Enter(sender As Object, e As System.EventArgs) Handles OtherText.Enter
        OtherBox.CheckState = CheckState.Checked
    End Sub

    Private Sub OtherText_Leave(sender As Object, e As System.EventArgs) Handles OtherText.Leave
        If OtherText.Text = "" Then OtherText.Text = "Другие услуги"
    End Sub

    Private Sub AnyServiceNumericBox_GotFocus(sender As Object, e As System.EventArgs) Handles workSumBox.Click, partsSumBox.Click, partsOutBox.Click
        sender.SelectAll()
    End Sub

    Private Sub AddOutcomeBox_Click(sender As Object, e As System.EventArgs) Handles AddOutcomeBox.Click, AddIncomeBox.Click
        sender.SelectAll()
    End Sub

    Private Sub workSumBox_Leave(sender As Object, e As System.EventArgs) Handles workSumBox.Leave, partsSumBox.Leave, partsOutBox.Leave, AddIncomeBox.Leave, AddOutcomeBox.Leave
        If sender.text = "" Then sender.text = "0"
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles AddCashButton.Click
        AddCash(AddComboBox.Text, CLng(AddIncomeBox.Text), CLng(AddOutcomeBox.Text), AddCommentBox.Text)
        Me.Clear()
        Commit()
        SaveCash()
    End Sub

    Private Sub dataService_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataService.CellDoubleClick
        If GlobalMode = 1 Then
            If MsgBox("Удалить запись?!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DelID As Long = 9999
                DelID = CLng(dataService.Item("Column10", e.RowIndex).Value)
                dataService.Rows.RemoveAt(e.RowIndex)
                For i = 0 To dCash.RowCount - 1
                    Try
                        If CLng(dCash.Item(0, i).Value) = DelID Then
                            dCash.Rows.RemoveAt(i)
                            Exit For
                        End If
                    Catch ex As Exception
                    End Try
                Next
            End If
        End If
        RecountRows()
        Commit()
        SaveService()
        SaveCash()
    End Sub

    Private Sub ClearAllSelection(sender As System.Object, e As System.EventArgs) Handles tabWash.Click, tabMount.Click, tabService.Click, Me.Click, tabCash.Click
        dataDay.ClearSelection()
        dataDayMount.ClearSelection()
        dataService.ClearSelection()
        dCash.ClearSelection()
    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim dpath As String = Application.StartupPath & "\data\" & comboYear.Text & "\" & CStr(comboMonth.SelectedIndex + 1)
        Select Case ComboBox2.SelectedIndex
            Case 0
                Dim SName As String = "Мойка " & comboMonth.Text & " " & comboYear.Text
                Dim YVals(31) As Long
                AddGraph(dpath, "N.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName, True, YVals)
                AddGraph(dpath, ".ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName, False, YVals)
            Case 1
                Dim sum As Long = CountAverage(CInt(comboDayFrom.Text), CInt(comboDayTo.Text), dpath, ".ini", 6)
                sum += CountAverage(CInt(comboDayFrom.Text), CInt(comboDayTo.Text), dpath, "N.ini", 6)
                Dim GraphName = "Мойка ср. " & comboMonth.Text & " " & CStr(curDate.Year)
                If Not Chart1.Series.IsUniqueName(GraphName) Then Chart1.Series.Remove(Chart1.Series.FindByName(GraphName))
                Chart1.Series.Add(GraphName)
                Chart1.Series(GraphName).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart1.Series(GraphName).IsValueShownAsLabel = valuesBox.Checked
                Chart1.Series(GraphName).Points.AddXY(CInt(comboDayFrom.Text), sum)
                Chart1.Series(GraphName).Points.AddXY(CInt(comboDayTo.Text), sum)
            Case 2
                Dim SName As String = "Шиномонтаж " & comboMonth.Text & " " & CStr(curDate.Year)
                AddGraph(dpath, "m.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName)
            Case 3
                Dim sum As Long = CountAverage(CInt(comboDayFrom.Text), CInt(comboDayTo.Text), dpath, "m.ini", 6)
                Dim GraphName = "Шиномонтаж ср. " & comboMonth.Text & " " & CStr(curDate.Year)
                If Not Chart1.Series.IsUniqueName(GraphName) Then Chart1.Series.Remove(Chart1.Series.FindByName(GraphName))
                Chart1.Series.Add(GraphName)
                Chart1.Series(GraphName).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart1.Series(GraphName).IsValueShownAsLabel = valuesBox.Checked
                Chart1.Series(GraphName).Points.AddXY(CInt(comboDayFrom.Text), sum)
                Chart1.Series(GraphName).Points.AddXY(CInt(comboDayTo.Text), sum)
            Case 4
                Dim SName As String = "Сервис " & comboMonth.Text & " " & CStr(curDate.Year)
                AddGraph(dpath, "s.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 7, SName)
            Case 5
                Dim sum As Long = CountAverage(CInt(comboDayFrom.Text), CInt(comboDayTo.Text), dpath, "s.ini", 7)
                Dim GraphName = "Сервис ср. " & comboMonth.Text & " " & CStr(curDate.Year)
                If Not Chart1.Series.IsUniqueName(GraphName) Then Chart1.Series.Remove(Chart1.Series.FindByName(GraphName))
                Chart1.Series.Add(GraphName)
                Chart1.Series(GraphName).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart1.Series(GraphName).IsValueShownAsLabel = valuesBox.Checked
                Chart1.Series(GraphName).Points.AddXY(CInt(comboDayFrom.Text), sum)
                Chart1.Series(GraphName).Points.AddXY(CInt(comboDayTo.Text), sum)
            Case 6
                Dim SName As String = "Выручка " & comboMonth.Text & " " & CStr(curDate.Year)
                Dim YVals(31) As Long
                AddGraph(dpath, "N.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName, True, YVals)
                AddGraph(dpath, ".ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName, True, YVals)
                AddGraph(dpath, "m.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName, True, YVals)
                AddGraph(dpath, "s.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 7, SName, False, YVals)
            Case 7
                Dim SName As String = "Ср. выручка " & comboMonth.Text & " " & CStr(curDate.Year)
                Dim YVals(31) As Long
                Dim sum As Long = 0
                AddGraph(dpath, "N.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName, True, YVals)
                AddGraph(dpath, ".ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName, True, YVals)
                AddGraph(dpath, "m.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 6, SName, True, YVals)
                AddGraph(dpath, "s.ini", CInt(comboDayFrom.Text), CInt(comboDayTo.Text), 7, SName, True, YVals)
                For Each i As Long In YVals
                    sum += i
                Next
                sum = sum / (CInt(comboDayTo.Text) - CInt(comboDayFrom.Text))
                If Not Chart1.Series.IsUniqueName(SName) Then Chart1.Series.Remove(Chart1.Series.FindByName(SName))
                Chart1.Series.Add(SName)
                Chart1.Series(SName).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart1.Series(SName).IsValueShownAsLabel = valuesBox.Checked
                Chart1.Series(SName).Points.AddXY(CInt(comboDayFrom.Text), sum)
                Chart1.Series(SName).Points.AddXY(CInt(comboDayTo.Text), sum)
        End Select
    End Sub

    Private Sub AddGraph(DirPath As String, FilePostfix As String, fromNum As Integer, toNum As Integer, SumPos As UInteger, GraphName As String, Optional Fake As Boolean = False, Optional ByRef PYValues() As Long = Nothing)
        Dim summ As Long = 0
        Dim cnt As UInteger = 0
        Dim CurRow As String()
        If Not Fake And Not Chart1.Series.IsUniqueName(GraphName) Then Chart1.Series.Remove(Chart1.Series.FindByName(GraphName))
        If Not Fake Then
            Chart1.Series.Add(GraphName)
            Chart1.Series(GraphName).ChartType = DataVisualization.Charting.SeriesChartType.Line
            Chart1.Series(GraphName).IsValueShownAsLabel = valuesBox.Checked
        End If
        If My.Computer.FileSystem.DirectoryExists(DirPath) Then
            For i = fromNum To toNum
                If My.Computer.FileSystem.FileExists(DirPath & "\" & CStr(i) & FilePostfix) Then
                    Using baseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(DirPath & "\" & CStr(i) & FilePostfix)
                        baseFile.TextFieldType = FileIO.FieldType.Delimited
                        baseFile.SetDelimiters("|")
                        While Not baseFile.EndOfData
                            CurRow = baseFile.ReadFields
                            If CurRow.Length > 1 Then
                                summ = summ + CLng(CurRow(SumPos))
                                cnt = cnt + 1
                            End If
                        End While
                    End Using
                End If
                If Not Fake Then
                    If PYValues Is Nothing Then
                        Chart1.Series(GraphName).Points.AddXY(i, summ)
                    Else
                        Chart1.Series(GraphName).Points.AddXY(i, summ + PYValues(i))
                    End If
                    If Chart1.ChartAreas(0).AxisX.Maximum < i Then Chart1.ChartAreas(0).AxisX.Maximum = i
                Else
                    PYValues(i) += summ
                End If
                summ = 0
            Next
        End If
    End Sub

    Public Function CountAverage(CountFrom As Integer, CountTo As Integer, DirPath As String, FilePostfix As String, CountPosition As Integer, Optional SumNotAverage As Boolean = False, Optional ByRef CarCount As Integer = 0) As Long
        On Error Resume Next
        Dim sum As Long = 0
        Dim CurRow() As String
        For i = CountFrom To CountTo
            If My.Computer.FileSystem.FileExists(DirPath & "\" & CStr(i) & FilePostfix) Then
                Using CntFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(DirPath & "\" & CStr(i) & FilePostfix)
                    CntFile.TextFieldType = FileIO.FieldType.Delimited
                    CntFile.SetDelimiters("|")
                    While Not CntFile.EndOfData
                        CurRow = CntFile.ReadFields
                        If CurRow.Length > 1 Then sum += CLng(CurRow(CountPosition))
                        CarCount += 1
                    End While
                End Using
            End If
        Next
        If SumNotAverage Then
            Return sum
        Else
            Return Math.Round(sum / (CountTo - CountFrom))
        End If
    End Function

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Chart1.Series.Clear()
    End Sub

    Private Sub DiscountCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DiscountCombo.SelectedIndexChanged
        DiscountNud.Value = DiscountValues(DiscountCombo.SelectedIndex)
    End Sub

    Private Sub Button10_Click_1(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        txtSquare.Text = CDec(txtSquare.Text) + (udx.Value * udy.Value)
        udx.Value = 0
        udy.Value = 0
        Commit()
    End Sub

    Private Sub txtSquare_LostFocus(sender As Object, e As System.EventArgs) Handles txtSquare.LostFocus
        If sender.text = "" Then sender.text = "0"
    End Sub

    Private Sub txtSquare_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSquare.TextChanged
        Try
            Commit()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dSchedule1_CellClick(sender As System.Windows.Forms.DataGridView, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dSchedule1.CellClick, dSchedule2.CellClick
        If e.ColumnIndex = 3 And e.RowIndex <> sender.RowCount - 1 Then
            sender.Item(1, e.RowIndex + 1).Value = sender.Item(1, e.RowIndex).Value
            sender.Item(2, e.RowIndex + 1).Value = sender.Item(2, e.RowIndex).Value
            SaveSchedule()
        ElseIf e.ColumnIndex = 4 Then
            sender.Item(1, e.RowIndex).Value = ""
            sender.Item(2, e.RowIndex).Value = ""
            SaveSchedule()
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        TimeSearch(dSchedule1, comboTLS.SelectedIndex)
    End Sub

    Private Sub TimeSearch(SearchObject As System.Windows.Forms.DataGridView, SearchTime As Integer)
        SearchObject.ClearSelection()
        Dim TimeNeeded As Integer
        Dim TimeFound As Integer
        Dim Answer As String = "Можно записаться на:" & vbNewLine
        TimeNeeded = SearchTime
        For i As Integer = 0 To SearchObject.RowCount - SearchTime - 1
            If SearchObject.Item(1, i).Value = "" Then
                TimeFound = 0
                If TimeNeeded = 0 Then
                    Answer = Answer & SearchObject.Item(0, i).Value & vbNewLine
                    For k = 0 To SearchObject.ColumnCount - 3
                        SearchObject.Item(k, i).Selected = True
                    Next
                Else
                    For j As Integer = i + 1 To i + TimeNeeded
                        If SearchObject.Item(1, j).Value = "" Then
                            TimeFound += 1
                            If TimeFound >= TimeNeeded Then
                                Answer = Answer & SearchObject.Item(0, i).Value & vbNewLine
                                For k = 0 To SearchObject.ColumnCount - 3
                                    SearchObject.Item(k, i).Selected = True
                                Next
                                Exit For
                            End If
                        Else
                            Exit For
                        End If
                    Next
                End If
            End If
        Next
        If Answer = "Можно записаться на:" & vbNewLine Then Answer = "Свободного времени нет!"
        MsgBox(Answer)
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        TimeSearch(dSchedule2, ComboTLS2.SelectedIndex)
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton19.CheckedChanged
        If sender.checked = True Then CurSche = 1
        If Not LOADING Then LoadSchedule(True)
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton20.CheckedChanged
        If sender.checked = True Then CurSche = 2
        If Not LOADING Then LoadSchedule(True)
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton21.CheckedChanged
        If sender.checked = True Then CurSche = 3
        If Not LOADING Then LoadSchedule(True)
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton22.CheckedChanged
        If sender.checked = True Then CurSche = 4
        If Not LOADING Then LoadSchedule(True)
    End Sub

    Private Sub dSchedule1_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dSchedule1.CellEndEdit
        SaveSchedule()
    End Sub

    Private Sub techWashBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles techWashBox.CheckedChanged
        If sender.checked Then
            plexBox.Checked = False
            bodyBox.Checked = False
            showerBox.Checked = False
            expressBox.Checked = False
        End If
        Commit()
    End Sub

    Private Sub vb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles valuesBox.CheckedChanged
        For i = 0 To Chart1.Series.Count - 1
            Chart1.Series(i).IsValueShownAsLabel = sender.checked
        Next
    End Sub

    Private Sub workSumBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles workSumBox.TextChanged
        Commit()
    End Sub

    Private Sub partsSumBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles partsSumBox.TextChanged
        Commit()
    End Sub

    Private Sub partsOutBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles partsOutBox.TextChanged
        Commit()
    End Sub

    Private Sub dSchedule2_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dSchedule2.CellEndEdit
        SaveSchedule()
    End Sub

    Private Sub dataService_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataService.CellEndEdit
        If e.ColumnIndex = 7 Or e.ColumnIndex = 9 Then
            Dim DelID As Long = 9999
            DelID = CLng(dataService.Item("Column10", e.RowIndex).Value)
            For i = 0 To dCash.RowCount - 1
                Try
                    If CLng(dCash.Item(0, i).Value) = DelID Then
                        dCash.Item(4, i).Value = CStr(CLng(dataService.Item(7, e.RowIndex).Value) + CLng(dataService.Item(9, e.RowIndex).Value))
                        SaveCash()
                        Exit For
                    End If
                Catch ex As Exception
                End Try
            Next
        ElseIf e.ColumnIndex = 10 Then
            Dim DelID As Long = 9999
            DelID = CLng(dataService.Item("Column10", e.RowIndex).Value)
            For i = 0 To dCash.RowCount - 1
                Try
                    If CLng(dCash.Item(0, i).Value) = DelID Then
                        dCash.Item(5, i).Value = dataService.Item(10, e.RowIndex).Value
                        SaveCash()
                        Exit For
                    End If
                Catch ex As Exception
                End Try
            Next
        End If
        Commit()
        SaveService()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        For Each SelCell In dTable.SelectedCells
            If SelCell.OwningColumn.Index < 3 Then Continue For
            SelCell.Value = CStr(nudHoursToAdd.Value)
            RecountWorkers(SelCell.ColumnIndex - 2)
        Next
        SaveTable()
    End Sub

    Public Function FindRowByID(IDToFind As Integer) As Integer
        Dim tmpSTR As String = CStr(IDToFind)
        For i = 0 To dTable.RowCount - 1
            If dTable.Item("dTable_ID", i).Value = tmpSTR Then Return i
        Next
        Return -1
    End Function

    Private Function FindRowByID(IDToFind As String) As Integer
        For i = 0 To dTable.RowCount - 1
            If dTable.Item("dTable_ID", i).Value = IDToFind Then Return i
        Next
        Return -1
    End Function

    Private Sub comboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMonth.SelectedIndexChanged
        comboDayFrom.Items.Clear()
        comboDayTo.Items.Clear()
        For i = 1 To Date.DaysInMonth(CInt(comboYear.Text), comboMonth.SelectedIndex + 1)
            comboDayFrom.Items.Add(CStr(i))
            comboDayTo.Items.Add(CStr(i))
        Next
        comboDayFrom.SelectedIndex = 0
        If Form2.NumberToMonth(curDate.Month) = comboMonth.Text And CStr(curDate.Year) = comboYear.Text Then
            comboDayTo.SelectedIndex = curDate.Day - 1
        Else
            comboDayTo.SelectedIndex = comboDayTo.Items.Count - 1
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click, ColorPanel.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ColorPanel.BackColor = ColorDialog1.Color
            'If ColorPanel.BackColor <> Color.White Then
            '    For i = 0 To dTable.ColumnCount - 1
            '        For j = 0 To dTable.RowCount - 1
            '            dTable.Item(i, j).Style.SelectionBackColor = ColorPanel.BackColor
            '        Next
            '    Next
            'Else
            '    For i = 0 To dTable.ColumnCount - 1
            '        For j = 0 To dTable.RowCount - 1
            '            dTable.Item(i, j).Style.SelectionBackColor = Color.LightGray
            '        Next
            '    Next
            'End If
        End If
    End Sub

    Private Sub ColorCommitButton_Click(sender As Object, e As EventArgs) Handles ColorCommitButton.Click
        For Each cell As System.Windows.Forms.DataGridViewCell In dTable.SelectedCells
            Dim w As Worker = Worker.FindByID(CInt(dTable.Item(0, cell.RowIndex).Value))
            If cell.Style.BackColor.R = 255 And cell.Style.BackColor.G = 255 And cell.Style.BackColor.B = 255 And Not (ColorPanel.BackColor.R = 255 And ColorPanel.BackColor.G = 255 And ColorPanel.BackColor.B = 255) Then
                w.WorkingDaysInCurMonth += 1
            ElseIf Not (cell.Style.BackColor.R = 255 And cell.Style.BackColor.G = 255 And cell.Style.BackColor.B = 255) And ColorPanel.BackColor.R = 255 And ColorPanel.BackColor.G = 255 And ColorPanel.BackColor.B = 255 Then
                w.WorkingDaysInCurMonth -= 1
            End If
            cell.Style.BackColor = ColorPanel.BackColor
        Next
    End Sub

    Private Sub ComboWorkshops_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboWorkshops.SelectedIndexChanged
        For Each wrkr In Worker.AllOfThem
            If wrkr.GetWorkshopInt = ComboWorkshops.SelectedIndex Then
                dTable.Rows(FindRowByID(wrkr.GetID)).Visible = True
            Else
                dTable.Rows(FindRowByID(wrkr.GetID)).Visible = False
            End If
        Next
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If StateForm.Visible Then
            StateForm.BringToFront()
        Else
            StateForm.Show()
        End If
    End Sub

    Private Sub zpWorkshops_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zpWorkshops.SelectedIndexChanged
        Exit Sub
        zpWorkers.Items.Clear()
        For Each w In Worker.AllOfThem
            If w.GetWorkshopInt = zpWorkshops.SelectedIndex Then
                zpWorkers.Items.Add(w.FullName)
                WorkerIDForzpWorkers(zpWorkers.Items.Count - 1) = w.GetID
            End If
        Next
    End Sub

    Private Sub zpWorkers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zpWorkers.SelectedIndexChanged
        Exit Sub
        'dSalary.Rows.Clear()
        'Dim D_I_M As Integer = Date.DaysInMonth(curDate.Year, curDate.Month)
        'Dim tmpSTR As String
        'Dim tmpSTR2 As String
        'Dim w As Worker = Worker.FindByID(WorkerIDForzpWorkers(zpWorkers.SelectedIndex))
        'Dim NightIncome As Double
        'Dim tmpAppearance As String
        'Dim tmpCarCount As Integer = 0
        'For i = 1 To D_I_M
        '    DayTotal(0, i) = CountAverage(i, i, dPath, ".ini", 6, True, tmpCarCount)
        '    DayPercent(0, i) = 20
        '    tmpSTR = dTable.Item(i + 2, FindRowByID(WorkerIDForzpWorkers(zpWorkers.SelectedIndex))).Value
        '    If tmpSTR = "" Then tmpSTR = "0"
        '    If tmpSTR = "0" Then
        '        tmpSTR2 = "0"
        '    Else
        '        tmpSTR2 = CStr(Math.Round((DayTotal(0, i) - tmpCarCount * 20) / DayWorkerCount(0, i) / 100 * DayPercent(0, i), 2))
        '    End If
        '    NightIncome = CountNightIncome(i, i, w.GetID) / 2
        '    If w.wFixedSalary Then
        '        tmpAppearance = CStr(Math.Round(w.GetSalary / Date.DaysInMonth(curDate.Year, curDate.Month), 2))
        '    Else
        '        tmpAppearance = CStr(Math.Round(CInt(tmpSTR) * w.GetHourCost, 2))
        '    End If
        '    dSalary.Rows.Add(CStr(i) & "." & CStr(curDate.Month) & "." & CStr(curDate.Year), _
        '                     CStr(DayPercent(0, i)), _
        '                     CStr(DayWorkerCount(0, i)), _
        '                     CStr(DayTotal(0, i) - tmpCarCount * 20), _
        '                     CStr(tmpCarCount), _
        '                     tmpSTR2, _
        '                     tmpAppearance, _
        '                     CStr(NightIncome), _
        '                     CStr(Math.Round(CSng(tmpSTR2) + CSng(tmpAppearance) + NightIncome, 2)))
        '    tmpCarCount = 0
        'Next
        'w.wPercentSum = ComeGetSum(dSalary, 5)
        'w.wSalarySum = ComeGetSum(dSalary, 6)
        'w.wNightSum = ComeGetSum(dSalary, 7)
        'w.wTotalSum = ComeGetSum(dSalary, 8)
        'Commit()
    End Sub

    Public Function CountNightIncome(StartingDay As Integer, EndingDay As Integer, WorkerID As Integer) As Double
        On Error Resume Next
        Dim curFPath As String
        Dim curSum As Double
        For i = StartingDay To EndingDay
            curFPath = dPath & "\" & CStr(i) & "N.ini"
            If My.Computer.FileSystem.FileExists(curFPath) Then
                Using nFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(curFPath)
                    nFile.TextFieldType = FileIO.FieldType.Delimited
                    nFile.SetDelimiters("|")
                    Dim curRow As String()
                    curRow = nFile.ReadFields
                    If curRow(0) = CStr(WorkerID) Then
                        While Not nFile.EndOfData
                            curRow = nFile.ReadFields
                            curSum += CInt(curRow(6))
                        End While
                    End If
                End Using
            End If
        Next
        Return curSum
    End Function

    Private Sub RecountWorkers()
        For i = 1 To Date.DaysInMonth(curDate.Year, curDate.Month)
            RecountWorkers(i)
        Next
    End Sub

    Private Sub RecountWorkers(DayToCount As Integer)
        Dim tmpSTR As String
        DayWorkerCount(0, DayToCount) = 0
        DayWorkerCount(1, DayToCount) = 0
        DayWorkerCount(2, DayToCount) = 0
        For Each w In Worker.AllOfThem
            tmpSTR = dTable.Item(DayToCount + 2, FindRowByID(w.GetID)).Value
            If tmpSTR <> "" And tmpSTR <> "0" Then
                DayWorkerCount(w.GetWorkshopInt, DayToCount) += 1
            End If
        Next
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        CashLeaf.Show()
    End Sub

    Public Function ComeGetSum(Source As DataGridView, Column As Integer, Optional StartRow As Integer = 0, Optional EndRow As Integer = -1, Optional VisibleOnly As Boolean = False) As Double
        On Error Resume Next
        Dim dblSum As Double = 0
        If EndRow = -1 Then EndRow = Source.RowCount - 1
        For i = StartRow To EndRow
            If VisibleOnly And Not Source.Rows(i).Visible Then Continue For
            dblSum += CDbl(Source.Item(Column, i).Value)
        Next
        Return dblSum
    End Function

    Private Sub ComboNightWorkers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboNightWorkers.SelectedIndexChanged
        If LoadProcedureRunning Then Exit Sub
        CurNightWorkerID = WorkerIDForNightWorkers(sender.selectedindex)
        SaveWash()
    End Sub

    Private Sub OweBox3_CheckedChanged(sender As Object, e As EventArgs) Handles OweBox3.CheckedChanged
        OweBox.CheckState = OweBox3.CheckState
        OweBox2.CheckState = OweBox3.CheckState
    End Sub

    Private Sub OweBox_CheckedChanged(sender As Object, e As EventArgs) Handles OweBox.CheckedChanged
        OweBox2.CheckState = OweBox.CheckState
        OweBox3.CheckState = OweBox.CheckState
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If AdvanceForm.Visible Then
            AdvanceForm.BringToFront()
        Else
            AdvanceForm.Show()
        End If
    End Sub

    Private Sub btnDebt_Click(sender As Object, e As EventArgs) Handles btnDebt1.Click, btnDebt2.Click, btnDebt3.Click
        If DebtForm.Visible Then
            DebtForm.BringToFront()
        Else
            DebtForm.Show()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ZPForm.Show()
    End Sub

    Private Sub btnLoadAnalytics_Click(sender As Object, e As EventArgs) Handles btnLoadAnalytics.Click
        If dtpTo.Value < dtpFrom.Value Then
            Exit Sub
        End If
        dgvAnalytics.Rows.Clear()
        comboFilter.Items.Clear()
        comboFilter.Items.Add("Показать все")
        Dim curRow As String()
        Dim CurrentDate As Date = dtpFrom.Value
        Dim cPath As String
        While CurrentDate <= dtpTo.Value
            cPath = Application.StartupPath & "\data\" & CStr(CurrentDate.Year) & "\" & CStr(CurrentDate.Month) & "\" & CStr(CurrentDate.Day) & "c.ini"
            If My.Computer.FileSystem.FileExists(cPath) Then
                Using cbaseFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(cPath)
                    cbaseFile.TextFieldType = FileIO.FieldType.Delimited
                    cbaseFile.SetDelimiters("|")
                    While Not cbaseFile.EndOfData
                        curRow = cbaseFile.ReadFields
                        If curRow.Length = 1 Or curRow(0) = "x" Or curRow(0) = "xxx" Then Continue While
                        For i = 0 To comboFilter.Items.Count - 1
                            If comboFilter.Items(i) = curRow(1) Then GoTo 7
                        Next
                        comboFilter.Items.Add(curRow(1))
7:
                        dgvAnalytics.Rows.Add(curRow(0), curRow(1), curRow(2), curRow(3), curRow(4), curRow(5), curRow(6))
                    End While
                End Using
            End If
            CurrentDate = CurrentDate.AddDays(1)
        End While
        dgvAnalytics.Rows.Add("autosum", "СУММА", "", "", ComeGetSum(dgvAnalytics, 4), ComeGetSum(dgvAnalytics, 5))
        dgvAnalytics.ClearSelection()
    End Sub

    Private Sub btnClearAnalytics_Click(sender As Object, e As EventArgs) Handles btnClearAnalytics.Click
        dgvAnalytics.Rows.Clear()
    End Sub

    Private Sub comboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboFilter.SelectedIndexChanged
        Dim showall As Boolean = False
        If comboFilter.SelectedIndex = 0 Then showall = True
        For i = 0 To dgvAnalytics.RowCount - 1
            If showall Or dgvAnalytics.Item(1, i).Value = comboFilter.Text Then
                dgvAnalytics.Rows(i).Visible = True
            Else
                dgvAnalytics.Rows(i).Visible = False
            End If
            If dgvAnalytics.Item(0, i).Value = "autosum" Then
                dgvAnalytics.Rows(i).Visible = True
                dgvAnalytics.Item(4, i).Value = ComeGetSum(dgvAnalytics, 4, 0, dgvAnalytics.RowCount - 2, True)
                dgvAnalytics.Item(5, i).Value = ComeGetSum(dgvAnalytics, 5, 0, dgvAnalytics.RowCount - 2, True)
            End If
        Next
    End Sub

    Private Sub dgvAnalytics_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAnalytics.SelectionChanged
        On Error Resume Next
        Dim sum As Long
        For Each cell As DataGridViewCell In dgvAnalytics.SelectedCells
            sum += CLng(cell.Value)
        Next
        Label1.Text = CStr(sum)
    End Sub

    Dim CurDirWatcher As System.IO.FileSystemWatcher
    Dim AppDirWatcher As System.IO.FileSystemWatcher
    Dim YearDirWatcher As System.IO.FileSystemWatcher

    Sub CreateWatchers()
        CurDirWatcher = New System.IO.FileSystemWatcher()
        CurDirWatcher.Path = dPath
        CurDirWatcher.NotifyFilter = (System.IO.NotifyFilters.LastWrite Or System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName)
        CurDirWatcher.Filter = "*.ini"
        CurDirWatcher.EnableRaisingEvents = True
        AddHandler CurDirWatcher.Created, AddressOf SomethingChanged
        AddHandler CurDirWatcher.Changed, AddressOf SomethingChanged
        AddHandler CurDirWatcher.Deleted, AddressOf SomethingChanged
        AddHandler CurDirWatcher.Renamed, AddressOf SomethingChanged

        AppDirWatcher = New System.IO.FileSystemWatcher()
        AppDirWatcher.Path = Application.StartupPath & "\data"
        AppDirWatcher.NotifyFilter = (System.IO.NotifyFilters.LastWrite Or System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName)
        AppDirWatcher.Filter = "*.ini"
        AppDirWatcher.EnableRaisingEvents = True
        AddHandler AppDirWatcher.Created, AddressOf SomethingChanged
        AddHandler AppDirWatcher.Changed, AddressOf SomethingChanged
        AddHandler AppDirWatcher.Deleted, AddressOf SomethingChanged
        AddHandler AppDirWatcher.Renamed, AddressOf SomethingChanged

        YearDirWatcher = New System.IO.FileSystemWatcher()
        YearDirWatcher.Path = Application.StartupPath & "\data\" & curDate.Year.ToString
        YearDirWatcher.NotifyFilter = (System.IO.NotifyFilters.LastWrite Or System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName)
        YearDirWatcher.Filter = "*.ini"
        YearDirWatcher.EnableRaisingEvents = True
        AddHandler YearDirWatcher.Created, AddressOf SomethingChanged
        AddHandler YearDirWatcher.Changed, AddressOf SomethingChanged
        AddHandler YearDirWatcher.Deleted, AddressOf SomethingChanged
        AddHandler YearDirWatcher.Renamed, AddressOf SomethingChanged
    End Sub

    Sub UpdateWatchers()
        CurDirWatcher.Path = dPath
        CurDirWatcher.NotifyFilter = (System.IO.NotifyFilters.LastWrite Or System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName)
        CurDirWatcher.Filter = "*.ini"
        CurDirWatcher.EnableRaisingEvents = True
        AppDirWatcher.Path = Application.StartupPath & "\data"
        AppDirWatcher.NotifyFilter = (System.IO.NotifyFilters.LastWrite Or System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName)
        AppDirWatcher.Filter = "*.ini"
        AppDirWatcher.EnableRaisingEvents = True
        YearDirWatcher.Path = Application.StartupPath & "\data\" & curDate.Year.ToString
        YearDirWatcher.NotifyFilter = (System.IO.NotifyFilters.LastWrite Or System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName)
        YearDirWatcher.Filter = "*.ini"
        YearDirWatcher.EnableRaisingEvents = True
    End Sub

    Sub SomethingChanged(source As Object, e As System.IO.FileSystemEventArgs)
        If ClosingNow Then Exit Sub
        On Error Resume Next

        Log(e.Name & " has been changed!")
        Dim Appendix As String
        Dim CDD As String = CStr(curDate.Day)
        Dim NDD As String = CStr(curDate.AddDays(1).Day)
        Appendix = e.Name
        Appendix = Appendix.Remove(Appendix.Length - 4, 4)
        Select Case Appendix
            Case CDD, CDD & "N"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(fPath)
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, WashHashCode) Then Exit Sub
                End Using
                WashHashCode = HashCode
                Me.Invoke(Sub() LoadWash())
                Me.Invoke(Sub() Commit())
            Case CDD & "m"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(fmPath)
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, MountHashCode) Then Exit Sub
                End Using
                MountHashCode = HashCode
                Me.Invoke(Sub() LoadMount())
                Me.Invoke(Sub() Commit())
            Case CDD & "s"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(sPath)
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, ServiceHashCode) Then Exit Sub
                End Using
                ServiceHashCode = HashCode
                Me.Invoke(Sub() LoadService())
                Me.Invoke(Sub() Commit())
            Case CDD & "c"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(cPath)
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, CashHashCode) Then Exit Sub
                End Using
                CashHashCode = HashCode
                Me.Invoke(Sub() LoadCash())
                Me.Invoke(Sub() Commit())
            Case CDD & CStr(CurSche) & "sc"
                If ScheduleSaving Then Exit Select
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(sc1Path)
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, sc1HashCode) Then Exit Sub
                End Using
                sc1HashCode = HashCode
                Me.Invoke(Sub() LoadSchedule())
            Case NDD & CStr(CurSche) & "sc"
                If ScheduleSaving Then Exit Select
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(sc2Path)
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, sc2HashCode) Then Exit Sub
                End Using
                sc2HashCode = HashCode
                Me.Invoke(Sub() LoadSchedule())
            Case "Table"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(dPath & "\Table.ini")
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, TableHashCode) Then Exit Sub
                End Using
                TableHashCode = HashCode
                Me.Invoke(Sub() LoadTable())
            Case "Advance"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(dPath & "\Advance.ini")
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, AdvanceHashCode) Then Exit Sub
                End Using
                AdvanceHashCode = HashCode
                Me.Invoke(Sub() LoadAdvance())
            Case "Debts"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(dPath & "\Debts.ini")
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, DebtsHashCode) Then Exit Sub
                End Using
                DebtsHashCode = HashCode
                Me.Invoke(Sub() LoadDebts())
            Case "State"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\State.ini")
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, StateHashCode) Then Exit Sub
                End Using
                StateHashCode = HashCode
                Me.Invoke(Sub() LoadState())
            Case "Customers", "Orders"
                Dim cHashCode As Byte()
                Dim fQuit As Boolean = True 'quit flag
                Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Customers.ini")
                    cHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If Not HashCodeEquals(cHashCode, CustomersHashCode) Then
                        CustomersHashCode = cHashCode
                        fQuit = False
                    End If
                End Using
                Dim oHashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Orders.ini")
                    oHashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If Not HashCodeEquals(oHashCode, OrdersHashCode) Then
                        OrdersHashCode = oHashCode
                        fQuit = False
                    End If
                End Using
                If fQuit Then Exit Sub 'if nothing really changed - there is no need to reload, so exit sub
                Me.Invoke(Sub() LoadCustomers())
            Case "Payments"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\" & CStr(curDate.Year) & "\Payments.ini")
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, PaymentsHashCode) Then Exit Sub
                End Using
                PaymentsHashCode = HashCode
                Me.Invoke(Sub() LoadPayments())
            Case "Providers"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Providers.ini")
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, ProvHashCode) Then Exit Sub
                End Using
                ProvHashCode = HashCode
                Me.Invoke(Sub() LoadProviders())
            Case "Executors"
                Dim HashCode As Byte()
                Using stream As System.IO.Stream = System.IO.File.OpenRead(Application.StartupPath & "\data\Executors.ini")
                    HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
                    If HashCodeEquals(HashCode, ExecutorsHashCode) Then Exit Sub
                End Using
                ExecutorsHashCode = HashCode
                Me.Invoke(Sub() LoadExecutors())
        End Select
    End Sub

    Public Function HashCodeEquals(FirstHashCode As Byte(), SecondHashCode As Byte()) As Boolean
        If FirstHashCode.Length <> SecondHashCode.Length Then Return False
        For i = 0 To FirstHashCode.Length - 1
            If FirstHashCode(i) <> SecondHashCode(i) Then Return False
        Next
        Return True
    End Function

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        SaveTable()
        RecountWorkers()
        Worker.CalculateAllHourCosts()
    End Sub

    Private Sub ScheduleTimer_Tick(sender As Object, e As EventArgs) Handles ScheduleTimer.Tick
        On Error Resume Next
        ScheduleTimer.Stop()
        sc1HashCode = Nothing
        Using stream As System.IO.Stream = System.IO.File.OpenRead(sc1Path)
            sc1HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
        sc2HashCode = Nothing
        Using stream As System.IO.Stream = System.IO.File.OpenRead(sc2Path)
            sc2HashCode = System.Security.Cryptography.MD5.Create.ComputeHash(stream)
        End Using
        ScheduleSaving = False
    End Sub

    Private Sub btnAddExecutor_Click(sender As Object, e As EventArgs) Handles btnAddExecutor.Click
        If comboExecutor.Text = "Исполнитель" Then Exit Sub
        For Each lstItem In listExecutors.Items
            If comboExecutor.Text = lstItem Then Exit Sub
        Next
        listExecutors.Items.Add(comboExecutor.Text)
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        Select Case WriteRight
            Case WriteRights.Bookkeeper, WriteRights.Master
                'Dim newCustomer = New HCCustomer("", "", "", "")
                frmCustomer.Show(Nothing, Me)
        End Select
    End Sub

    Private Sub dgvOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrders.CellContentClick
        If e.ColumnIndex = cmnEdit.Index Then
            NumberToFind = dgvOrders.Item(0, e.RowIndex).Value
            frmOrder.Show(OrderList.Find(AddressOf FindOrderByNumber), Me)
        ElseIf e.ColumnIndex = cmnPayment.Index Then
            NumberToFind = dgvOrders.Item(0, e.RowIndex).Value
            frmAddCash.Show(OrderList.Find(AddressOf FindOrderByNumber), Me)
        ElseIf e.ColumnIndex = cmnPrint.Index Then
            NumberToFind = dgvOrders.Item(0, e.RowIndex).Value
            frmPrintOrder.Show(OrderList.Find(AddressOf FindOrderByNumber))
        End If
    End Sub

    Public NumberToFind As String
    Public Function FindOrderByNumber(ByVal Order As HCOrder) As Boolean
        If Order.Number.GetFullNumber = NumberToFind Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub RefreshOrders()
        dgvOrders.Rows.Clear()
        If curCustomer Is Nothing Then
            For Each Order As HCOrder In OrderList
                dgvOrders.Rows.Add(Order.Number.GetFullNumber, Order.Customer.GetShortName, Order.Completed, "Оплата...", "Открыть...", "Печать")
            Next
            btnShowAllOrders.Hide()
        Else
            For Each Order In curCustomer.MyOrderList
                dgvOrders.Rows.Add(Order.Number.GetFullNumber, Order.Customer.GetShortName, Order.Completed, "Оплата...", "Открыть...", "Печать")
            Next
            btnShowAllOrders.Show()
        End If
    End Sub

    Public Sub RefreshCustomers()
        dgvCustomers.Rows.Clear()
        For Each Customer As HCCustomer In CustomerList
            dgvCustomers.Rows.Add(CStr(Customer.ID), Customer.FullName, Customer.Phone, "Клиент...", "Заказы >")
        Next
    End Sub

    Public Sub RefreshCustomersAndOrders()
        RefreshCustomers()
        RefreshOrders()
    End Sub

    Private Sub btnShowAllOrders_Click(sender As Object, e As EventArgs) Handles btnShowAllOrders.Click
        curCustomer = Nothing
        RefreshOrders()
        btnShowAllOrders.Hide()
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        Try
            If e.ColumnIndex = cmnOpen.Index Then
                frmCustomer.Show(HCCustomer.FindByID(CUInt(dgvCustomers.Rows(e.RowIndex).Cells("cmnID").Value)), Me)
            ElseIf e.ColumnIndex = ColumnOrders.Index Then
                curCustomer = HCCustomer.FindByID(CUInt(dgvCustomers.Rows(e.RowIndex).Cells("cmnID").Value))
                RefreshOrders()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        If CustomerList.Count = 0 Then
            MsgBox("Сначала добавьте хотя бы одного клиента", MsgBoxStyle.Information, "Info")
            Exit Sub
        End If
        If WriteRight = WriteRights.Bookkeeper Or WriteRight = WriteRights.Master Then
            frmNewOrder.Show(Nothing, Me)
        End If
    End Sub

    Private Sub TabPage10_Enter(sender As Object, e As EventArgs) Handles tabCustomersOrders.Enter
        ServiceMode = 7
        RefreshCustomersAndOrders()
    End Sub

    Private Sub EnablePage(ByRef Page As TabPage, Enable As Boolean)
        If Enable Then
            TabControl1.TabPages.Add(Page)
            HiddenPages.Remove(Page)
        Else
            HiddenPages.Add(Page)
            TabControl1.TabPages.Remove(Page)
        End If
    End Sub

    Private Sub tabWash_Enter(sender As Object, e As EventArgs) Handles tabWash.Enter
        ServiceMode = 0
    End Sub

    Private Sub tabMount_Enter(sender As Object, e As EventArgs) Handles tabMount.Enter
        ServiceMode = 1
    End Sub

    Private Sub tabService_Enter(sender As Object, e As EventArgs) Handles tabService.Enter
        ServiceMode = 2
    End Sub

    Public Sub RefreshProviders()
        lwProviders.Items.Clear()
        For Each prov In HCProvider.ProviderList
            Dim newItem = New ListViewItem({prov.Name, prov.PartList.Count.ToString})
            lwProviders.Items.Add(newItem)
        Next
    End Sub

    Private Sub lwProviders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lwProviders.SelectedIndexChanged
        lwOrders.Items.Clear()
        If lwProviders.SelectedItems.Count = 0 Then
            lwOrders.Visible = False
            lblOrdersCaption.Visible = False
        Else
            lwOrders.Visible = True
            lblOrdersCaption.Visible = True
            curProv = HCProvider.GetByName(lwProviders.SelectedItems(0).Text)
            For Each Part In curProv.PartList
                Dim PartNumber As String = Part.Order.Number.GetFullNumber
                Dim fFound As Boolean = False
                For Each item As ListViewItem In lwOrders.Items
                    If item.Text = PartNumber Then fFound = True
                Next
                If Not fFound Then
                    Dim newItem = New ListViewItem({Part.Order.Number.GetFullNumber, ToMoney(Part.Order.GetProviderPrice(curProv))})
                    newItem.Tag = Part
                    lwOrders.Items.Add(newItem)
                End If
            Next
        End If
    End Sub

    Dim curPart As HCPart
    Private Sub lwOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lwOrders.SelectedIndexChanged
        curPart = Nothing
        If lwOrders.SelectedItems.Count <> 0 Then curPart = lwOrders.SelectedItems(0).Tag
        RefreshOrder()
    End Sub

    Sub RefreshOrder()
        If curPart Is Nothing Then
            gbPart.Visible = False
        Else
            gbPart.Visible = True
            txtOrderNumber.Text = curPart.Order.Number.GetFullNumber
            txtPartList.Text = ""
            For Each part As HCPart In curPart.Order.PartList
                If part.Provider Is curProv Then txtPartList.Text &= part.Name & " (" & part.Count & " " & part.Units & ") " & ToMoney(part.Price * part.Count) & vbNewLine
            Next
            txtOrderPrice.Text = ToMoney(curPart.Order.GetProviderPrice(curPart.Provider))
            dtpPayment.Value = curDate
        End If
    End Sub

    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click
        If curPart Is Nothing Then Exit Sub
        If curPart.PaymentAdded Then
            If MsgBox("Вы уже оплачивали эти запчасти. Вы уверены, что хотите сделать это снова?", MsgBoxStyle.YesNo, "Внимание!") <> MsgBoxResult.Yes Then
                Exit Sub
            End If
        End If
        Dim Result As String = InputBox("Оплата:", "Оплата запчастей поставщику", curPart.Order.GetProviderPrice(curPart.Provider))
        If Result Is Nothing Then Exit Sub
        If Result = "" Or Result = "0" Then Exit Sub
        Dim dblResult = Math.Round(CDbl(Result), 2)
        AddPayment(curProv.ID.ToString, _
                   curPart.Order.Number.GetFullNumber, _
                   curProv.Name, _
                   dtpPayment.Value.ToString("dd.MM.yyyy"), _
                   CStr(dblResult), _
                   "0", _
                   "За заказ № " & curPart.Order.Number.GetFullNumber)
        For Each part In curPart.Order.PartList
            If part.Provider.ID = curPart.Provider.ID Then
                part.PaymentAdded = True
            End If
        Next

    End Sub

    Private Sub comboProviderFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProviderFilter.SelectedIndexChanged
        Dim showall As Boolean = False
        If comboProviderFilter.SelectedIndex = 0 Then showall = True
        Dim strFilter As String = comboProviderFilter.Text
        For Each row As DataGridViewRow In dgvPayments.Rows
            If showall Then
                row.Visible = True
            Else
                If row.Cells.Item(cmnProvider.Index).Value = strFilter Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next
        UpdateDebitCredit()
        'If dgvPayments.Item(0, i).Value = "autosum" Then
        ' dgvPayments.Rows(i).Visible = True
        ' dgvPayments.Item(4, i).Value = ComeGetSum(dgvPayments, 4, 0, dgvPayments.RowCount - 2, True)
        ' dgvPayments.Item(5, i).Value = ComeGetSum(dgvPayments, 5, 0, dgvPayments.RowCount - 2, True)
        ' End If
    End Sub

    Private Sub tabPayments_Enter(sender As Object, e As EventArgs) Handles tabPayments.Enter
        ServiceMode = 9
        RefreshProviderFilter()
        UpdateDebitCredit()
    End Sub

    Private Sub tabProviders_Enter(sender As Object, e As EventArgs) Handles tabProviders.Enter
        ServiceMode = 8
        RefreshProviders()
    End Sub

    Private Sub dgvPayments_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayments.CellEndEdit
        If LoadProcedureRunning Or SavingPayments Then Exit Sub
        SavePayments()
    End Sub

    Private Sub dgvPayments_RowsAdded(sender As Object, e As EventArgs) Handles dgvPayments.RowsAdded, dgvPayments.RowsRemoved, dgvPayments.CellValueChanged
        If LoadProcedureRunning Then Exit Sub
        UpdateDebitCredit()
    End Sub

    Private Sub UpdateDebitCredit()
        On Error Resume Next
        Dim DebitSum As Double = 0
        Dim CreditSum As Double = 0
        For Each row As DataGridViewRow In dgvPayments.Rows
            If row.Visible Then
                DebitSum += Double.Parse(row.Cells(cmnDebit.Index).Value, culture)
                CreditSum += Double.Parse(row.Cells(cmnCredit.Index).Value, culture)
            End If
        Next
        txtDebitSum.Text = DebitSum.ToString(specifier, culture)
        txtCreditSum.Text = CreditSum.ToString(specifier, culture)
        txtDebitDiff.Text = ""
        txtCreditDiff.Text = ""
        Dim Diff As Double = Math.Round(DebitSum - CreditSum, 2)
        If Diff < 0 Then
            txtCreditDiff.Text = (-Diff).ToString(specifier, culture)
        ElseIf Diff > 0 Then
            txtDebitDiff.Text = Diff.ToString(specifier, culture)
        End If
    End Sub

    Private Sub dgvPayments_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPayments.SelectionChanged
        On Error Resume Next
        Dim sum As Long
        For Each cell As DataGridViewCell In dgvPayments.SelectedCells
            sum += CLng(cell.Value)
        Next
        Label1.Text = CStr(sum)
    End Sub

    Public Function RemovePaymentsByID(strID As String) As Integer
        Dim counter As Integer = 0
        For Each row As DataGridViewRow In dgvPayments.Rows
            If row.Cells(cmnProvID.Index).Value = strID Then
                dgvPayments.Rows.Remove(row)
                counter += 1
            End If
        Next
        Return counter
    End Function

    Public Function RemovePaymentsByID(ID As Integer) As Integer
        Dim strPID As String = CStr(ID)
        Return RemovePaymentsByID(strPID)
    End Function

    Public Function RemovePaymentsByOID(strID As String) As Integer
        Dim counter As Integer = 0
        For Each row As DataGridViewRow In dgvPayments.Rows
            If row.Cells(cmnOrderID.Index).Value = strID Then
                dgvPayments.Rows.Remove(row)
                counter += 1
            End If
        Next
        Return counter
    End Function

    Public Sub RegisterPartList(ByRef PartList As List(Of HCPart))
        Dim sums As New List(Of Double)
        Dim names As New List(Of String)
        Dim IDs As New List(Of Integer)
        For Each Part In PartList
            Dim bFound As Boolean = False
            For i = 0 To names.Count - 1
                If IDs(i) = Part.Provider.ID Then
                    sums(i) += Part.Price * Part.Count
                    bFound = True
                End If
            Next
            If Not bFound Then
                sums.Add(Part.Price * Part.Count)
                names.Add(Part.Provider.Name)
                IDs.Add(Part.Provider.ID)
            End If
        Next
        For i = 0 To sums.Count - 1
            AddPayment(-IDs(i).ToString(), PartList(0).Order.Number.GetFullNumber, names(i), Date.Now.ToString("dd.MM.yyyy"), "0", sums(i).ToString(specifier, culture), _
                       "За заказ № " & PartList(0).Order.Number.GetFullNumber)
        Next
    End Sub

    Public Sub UpdatePart(ByRef Part As HCPart)
        Dim fFound As Boolean = False
        For Each row As DataGridViewRow In dgvPayments.Rows
            If row.Cells(cmnOrderID.Index).Value = Part.Order.Number.GetFullNumber And CInt(row.Cells(cmnProvID.Index).Value) = -Part.Provider.ID Then
                row.Cells(cmnCredit.Index).Value = Part.Order.GetProviderPrice(Part.Provider).ToString(specifier, culture)
                fFound = True
                SavePayments()
                Exit For
            End If
        Next
        If Not fFound Then
            AddPayment((-Part.Provider.ID).ToString(), Part.Order.Number.GetFullNumber, Part.Provider.Name, Date.Now.ToString("dd.MM.yyyy"), "0", (Part.Price * Part.Count).ToString(specifier, culture), _
                       "За заказ № " & Part.Order.Number.GetFullNumber)
        End If
    End Sub

    Public Sub RemovePart(ByRef Part As HCPart)
        For Each row As DataGridViewRow In dgvPayments.Rows
            If row.Cells(cmnOrderID.Index).Value = Part.Order.Number.GetFullNumber And CInt(row.Cells(cmnProvID.Index).Value) = -Part.Provider.ID Then
                If Double.Parse(row.Cells(cmnCredit.Index).Value, culture) = Part.Price * Part.Count Then
                    dgvPayments.Rows.Remove(row)
                Else
                    row.Cells(cmnCredit.Index).Value = (Part.Order.GetProviderPrice(Part.Provider) - (Part.Price * Part.Count)).ToString(specifier, culture)
                End If
            End If
        Next
        SavePayments()
    End Sub

    Public Sub UpdateProviderForID(ID As Integer, newProvider As HCProvider)
        Dim npID As String = ""
        Dim npName As String = ""
        If Not newProvider Is Nothing Then
            npID = newProvider.ID.ToString
            npName = newProvider.Name
        End If
        Dim strID As String = CStr(ID)
        For Each row As DataGridViewRow In dgvPayments.Rows
            If row.Cells(cmnProvID.Index).Value = strID Then
                If row.Cells(cmnProvider.Index).Value = newProvider.Name Then Exit Sub
                NumberToFind = row.Cells(cmnOrderID.Index).Value
                Dim MyOrder As HCOrder = OrderList.Find(AddressOf FindOrderByNumber)
                'row.Cells(cmnProvID.Index).Value = npID
                'row.Cells(cmnProvider.Index).Value = npName
            End If
        Next
    End Sub

    Private Sub ДневнойОтчётToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ДневнойОтчётToolStripMenuItem2.Click
        Form2.Dispose()
        Form2.LoadDay("Wash")
        Form2.Show()
    End Sub

    Private Sub ДневнойОтчётToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ДневнойОтчётToolStripMenuItem3.Click
        Form2.Dispose()
        Form2.LoadDay("Mount")
        Form2.Show()
    End Sub

    Private Sub ДневнойОтчётToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ДневнойОтчётToolStripMenuItem4.Click
        Form2.Dispose()
        Form2.LoadDay("Service")
        Form2.Show()
    End Sub

    Private Sub ДневнойОтчётToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ДневнойОтчётToolStripMenuItem5.Click
        Form2.Dispose()
        Form2.LoadCash()
        Form2.Show()
    End Sub

    Private Sub МесячныйОтчётToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles МесячныйОтчётToolStripMenuItem2.Click
        Form2.Dispose()
        Form2.LoadMonth("Wash", 1, Date.DaysInMonth(curDate.Year, curDate.Month), curDate.Month, curDate.Year)
        Form2.Show()
    End Sub

    Private Sub МесячныйОтчётToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles МесячныйОтчётToolStripMenuItem3.Click
        Form2.Dispose()
        Form2.LoadMonth("Mount", 1, Date.DaysInMonth(curDate.Year, curDate.Month), curDate.Month, curDate.Year)
        Form2.Show()
    End Sub

    Private Sub МесячныйОтчётToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles МесячныйОтчётToolStripMenuItem4.Click
        Form2.Dispose()
        Form2.LoadMonth("Service", 1, Date.DaysInMonth(curDate.Year, curDate.Month), curDate.Month, curDate.Year)
        Form2.Show()
    End Sub

    Private Sub МесячныйОтчётToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles МесячныйОтчётToolStripMenuItem5.Click
        Form2.Dispose()
        Form2.LoadMonth("Cash", 1, Date.DaysInMonth(curDate.Year, curDate.Month), curDate.Month, curDate.Year)
        Form2.Show()
    End Sub

    Private Sub ЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗаписьToolStripMenuItem.Click
        Form2.Dispose()
        dSchedule1.Columns.Item(3).Visible = False
        dSchedule1.Columns.Item(4).Visible = False
        RadioButton19.Checked = True
        Application.DoEvents()
        Form2.LoadSchedule(True)
        RadioButton20.Checked = True
        Application.DoEvents()
        Form2.LoadSchedule(False)
        dSchedule1.Columns.Item(3).Visible = True
        dSchedule1.Columns.Item(4).Visible = True
        Form2.Show()
    End Sub

    Private Sub ПринятыеПлатежиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПринятыеПлатежиToolStripMenuItem.Click
        frmShowPayments.Show()
    End Sub

    Private Sub tabAnalytics_Enter(sender As Object, e As EventArgs) Handles tabAnalytics.Enter
        ServiceMode = 6
    End Sub

    Private Sub Log(Message)
        frmLog.Add(Message)
    End Sub

    Private Sub tabCash_Enter(sender As Object, e As EventArgs) Handles tabCash.Enter
        ServiceMode = 4
    End Sub

    Private Sub tabSchedule_Enter(sender As Object, e As EventArgs) Handles tabSchedule.Enter
        ServiceMode = 3
    End Sub

    Private Sub ИзменитьПаролиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИзменитьПаролиToolStripMenuItem.Click
        frmManagePasswords.Show(Me)
    End Sub
End Class
