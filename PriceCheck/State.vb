Public Class Worker
    Private wName As String
    Private w2Name As String
    Private wPatron As String
    Private wWorkshop As Integer
    Private wJob As String
    Private wID As Integer
    Private wSalary As Long
    Private wNorm As Integer
    Public TableForCurMonth(31) As Integer
    Public WorkingDaysInCurMonth As Integer
    Public HoursWorkedInCurMonth As Integer
    Private wHourCost As Single
    Public Shared nextID As Integer = 0
    Public Shared AllOfThem As New List(Of Worker)
    Public wPercent As Integer
    Public wPercentSum As Double
    Public wSalarySum As Double
    Public wNightSum As Double
    Public wTotalSum As Double
    Public wFixedSalary As Boolean
    Public wAdvance As Double
    Public wBonus As Double
    Public wOtherPayments As Double
    Public wOtherCharges As Double

    Public Sub New(WorkerName As String, Worker2ndName As String, WorkerPatronymic As String, WorkerWorkshop As Integer, WorkerJob As String, WorkerSalary As Long, WorkerNorm As Integer, FixedSalary As Boolean)
        Me.New(nextID, WorkerName, Worker2ndName, WorkerPatronymic, WorkerWorkshop, WorkerJob, WorkerSalary, WorkerNorm, FixedSalary)
        nextID += 1
    End Sub

    Public Sub New(ID As Integer, WorkerName As String, Worker2ndName As String, WorkerPatronymic As String, WorkerWorkshop As Integer, WorkerJob As String, WorkerSalary As Long, WorkerNorm As Integer, FixedSalary As Boolean)
        If ID >= nextID Then nextID = ID + 1
        AllOfThem.Add(Me)
        wName = WorkerName
        w2Name = Worker2ndName
        wPatron = WorkerPatronymic
        wWorkshop = WorkerWorkshop
        wJob = WorkerJob
        wID = ID
        wSalary = WorkerSalary
        wNorm = WorkerNorm
        wFixedSalary = FixedSalary
    End Sub

    Public Sub Dispose()
        AllOfThem.Remove(Me)
    End Sub

    Public Shared Sub Clear()
        AllOfThem.Clear()
    End Sub

    Public Function FullName() As String
        Return (Me.Get2Name & " " & Me.GetName & " " & Me.GetPatron).Trim()
    End Function

    Public Function GetName() As String
        Return wName
    End Function

    Public Function Get2Name() As String
        Return w2Name
    End Function

    Public Function GetPatron() As String
        Return wPatron
    End Function

    Public Function GetJob() As String
        Return wJob
    End Function

    Public Function GetID() As Integer
        Return wID
    End Function

    Public Function GetWorkshopStr() As String
        Select Case wWorkshop
            Case 0
                Return "Wash"
            Case 1
                Return "Mount"
            Case 2
                Return "Service"
            Case Else
                Return CStr(wWorkshop)
        End Select
    End Function

    Public Function GetWorkshopInt() As Integer
        Return wWorkshop
    End Function

    Shared Function FindByID(ID As Integer) As Worker
        For Each w In AllOfThem
            If w.wID = ID Then Return w
        Next
        Return Nothing
    End Function

    Public Sub SetName(strName As String)
        wName = strName
        Update()
    End Sub

    Public Sub Set2Name(str2Name As String)
        w2Name = str2Name
        Update()
    End Sub

    Public Sub SetPatron(strPatron As String)
        wPatron = strPatron
        Update()
    End Sub

    Public Sub SetJob(strJob As String)
        wJob = strJob
        Update()
    End Sub

    Public Sub SetWorkshop(intWorkshop As Integer)
        wWorkshop = intWorkshop
        Update()
    End Sub

    Public Sub SetWorkshop(strWorkshop As String)
        Select Case strWorkshop
            Case "Wash"
                wWorkshop = 0
            Case "Mount"
                wWorkshop = 1
            Case "Service"
                wWorkshop = 2
        End Select
        Update()
    End Sub

    Public Sub Update()
        If Form1.dTable.ColumnCount > 1 Then
            Form1.dTable.Item(1, Form1.FindRowByID(Me.GetID)).Value = FullName()
            Form1.dTable.Item(2, Form1.FindRowByID(Me.GetID)).Value = Me.GetJob
        End If
    End Sub

    Public Function GetSalary() As Long
        Return wSalary
    End Function

    Public Sub SetSalary(Salary As Long)
        wSalary = Salary
    End Sub

    Public Function GetNorm() As Integer
        Return wNorm
    End Function

    Public Sub SetNorm(Norm As Integer)
        wNorm = Norm
    End Sub

    Public Function GetHourCost() As Single
        Return wHourCost
    End Function

    Public Sub SetHourCost(HourCost As Single)
        wHourCost = HourCost
    End Sub

    Public Sub CalculateHourCost()
        If WorkingDaysInCurMonth = 0 Then Exit Sub
        wHourCost = Math.Round(wSalary / WorkingDaysInCurMonth / wNorm, 4)
    End Sub

    Public Shared Sub CalculateAllHourCosts()
        For Each w In AllOfThem
            w.CalculateHourCost()
        Next
    End Sub
End Class
