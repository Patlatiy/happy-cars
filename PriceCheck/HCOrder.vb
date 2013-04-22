Public Class HCOrder
    Public Customer As HCCustomer
    Public Executor As HCExecutor
    Public DeliveryDate As Date

    Public _PaymentSum As ULong
    Public PaymentDate As Date
    Public Property PaymentSum As Double
        Get
            Return _PaymentSum / 100
        End Get
        Set(value As Double)
            _PaymentSum = CULng(value * 100)
        End Set
    End Property

    Public _AdvanceSum As ULong
    Public AdvanceDate As Date
    Public Property AdvanceSum As Double
        Get
            Return _AdvanceSum / 100
        End Get
        Set(value As Double)
            _AdvanceSum = CULng(value * 100)
        End Set
    End Property

    Private _Discount As ULong
    Public Property Discount As Double
        Get
            Return _Discount / 100
        End Get
        Set(value As Double)
            _Discount = CULng(value * 100)
        End Set
    End Property

    Public PartList As List(Of HCPart)
    Public Number As OrderNumber
    Public Shared OrderList As New List(Of HCOrder)
    Public Completed As Boolean = False
    Public Comment As String = "Комментарий"
    Public Shared GlobalID As UInteger = 1

    Structure OrderNumber
        Public Year As Short
        Public Month As Short
        Public Day As Short
        Public ID As UInteger

        Function GetDate() As String
            Dim tmpMonth As String
            tmpMonth = CStr(Month)
            If Month < 10 Then tmpMonth = "0" & tmpMonth
            Dim tmpDay As String
            tmpDay = CStr(Day)
            If Day < 10 Then tmpDay = "0" & tmpDay
            Return CStr(Year) & "." & tmpMonth & "." & tmpDay
        End Function

        Function GetID() As String
            Dim tmpID As String
            tmpID = CStr(ID)
            Select Case ID
                Case Is < 10
                    tmpID = "000" & tmpID
                Case Is < 100
                    tmpID = "00" & tmpID
                Case Is < 1000
                    tmpID = "0" & tmpID
            End Select
            Return tmpID
        End Function

        Function GetFullNumber() As String
            Return GetDate() & "-" & GetID()
        End Function

        Sub SetFullNumber(FullNumber As String)
            Year = CShort(FullNumber(0).ToString & FullNumber(1).ToString & FullNumber(2).ToString & FullNumber(3).ToString)
            Month = CShort(FullNumber(5).ToString & FullNumber(6).ToString)
            Day = CShort(FullNumber(8).ToString & FullNumber(9).ToString)
            ID = CUInt(FullNumber(11).ToString & FullNumber(12).ToString & FullNumber(13).ToString & FullNumber(14).ToString)
            If GlobalID <= ID Then GlobalID = ID + 1
        End Sub

        Sub New(ByVal nYear As Short, ByVal nMonth As Short, ByVal nDay As Short)
            Year = nYear
            Month = nMonth
            Day = nDay
            ID = GlobalID
            GlobalID += 1
        End Sub

        Sub New(nID As UInteger, ByVal nYear As Short, ByVal nMonth As Short, ByVal nDay As Short)
            Year = nYear
            Month = nMonth
            Day = nDay
            ID = nID
        End Sub
    End Structure

    Sub New()
        PartList = New List(Of HCPart)
        Number = New OrderNumber(Form1.curDate.Year, Form1.curDate.Month, Form1.curDate.Day)
        Customer = HCCustomer.CustomerList.Last
        Customer.MyOrderList.Add(Me)
        DeliveryDate = Form1.curDate
        PaymentSum = 0
        PaymentDate = Form1.curDate
        AdvanceSum = 0
        AdvanceDate = Form1.curDate
        OrderList.Add(Me)
    End Sub

    Sub New(ByRef nCustomer As HCCustomer, ByVal nDeliveryDate As Date, ByVal nPaymentSum As Double, ByVal nPaymentDate As Date, _
            ByVal nAdvanceSum As Double, ByVal nAdvanceDate As Date, ByVal nDiscount As Double, ByVal nParts As List(Of HCPart), ByVal nCompleted As Boolean)
        Me.New(nCustomer, Nothing, nDeliveryDate, nPaymentSum, nPaymentDate, nAdvanceSum, nAdvanceDate, nDiscount, nParts, nCompleted)
    End Sub

    Sub New(ByRef nCustomer As HCCustomer, ByRef nExecutor As HCExecutor, ByVal nDeliveryDate As Date, ByVal nPaymentSum As Double, ByVal nPaymentDate As Date, _
            ByVal nAdvanceSum As Double, ByVal nAdvanceDate As Date, ByVal nDiscount As Double, ByVal nParts As List(Of HCPart), ByVal nCompleted As Boolean)
        Customer = nCustomer
        Executor = nExecutor
        Customer.MyOrderList.Add(Me)
        DeliveryDate = nDeliveryDate
        PaymentSum = nPaymentSum
        PaymentDate = nPaymentDate
        AdvanceSum = nAdvanceSum
        AdvanceDate = nAdvanceDate
        PartList = nParts
        For Each Part In PartList
            Part.Order = Me
        Next
        Number = New OrderNumber(Form1.curDate.Year, Form1.curDate.Month, Form1.curDate.Day)
        Form1.RegisterPartList(PartList)
        Discount = nDiscount
        Completed = nCompleted
        OrderList.Add(Me)
    End Sub

    Sub New(nNumber As String, ByRef nCustomer As HCCustomer, ByRef nExecutor As HCExecutor, ByVal nDeliveryDate As Date, ByVal nPaymentSum As Double, ByVal nPaymentDate As Date, _
            ByVal nAdvanceSum As Double, ByVal nAdvanceDate As Date, ByVal nDiscount As Double, ByVal nParts As List(Of HCPart), ByVal nCompleted As Boolean)
        Customer = nCustomer
        Executor = nExecutor
        Customer.MyOrderList.Add(Me)
        DeliveryDate = nDeliveryDate
        PaymentSum = nPaymentSum
        PaymentDate = nPaymentDate
        AdvanceSum = nAdvanceSum
        AdvanceDate = nAdvanceDate
        PartList = nParts
        For Each Part In PartList
            Part.Order = Me
        Next
        'Form1.RegisterPartList(PartList)
        Number = New OrderNumber(0, 0, 0, 0)
        Number.SetFullNumber(nNumber)
        Discount = nDiscount
        Completed = nCompleted
        OrderList.Add(Me)
    End Sub

    Public Shared Function CompareByNumber(ByVal a As HCOrder, ByVal b As HCOrder) As Integer
        If a Is Nothing Then
            If b Is Nothing Then
                Return 0
            Else
                Return -1
            End If
        Else
            If b Is Nothing Then
                Return 1
            Else
                If a.Number.Year > b.Number.Year Then
                    Return 1
                ElseIf a.Number.Year < b.Number.Year Then
                    Return -1
                Else
                    If a.Number.Month > b.Number.Month Then
                        Return 1
                    ElseIf a.Number.Month < b.Number.Month Then
                        Return -1
                    Else
                        If a.Number.ID > b.Number.ID Then
                            Return 1
                        ElseIf a.Number.ID < b.Number.ID Then
                            Return -1
                        Else
                            Return 0
                        End If
                    End If
                End If
            End If
        End If
    End Function


    ''' <summary>
    ''' Returns price of whole order, including discount
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetTotalPrice() As Double
        Return Math.Round(Me.GetRawPrice() - Discount, 2)
    End Function

    ''' <summary>
    ''' Returns price of a whole order, without discount
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetRawPrice() As Double
        Dim TotalOrderPrice As Double = 0
        For Each Part In PartList
            TotalOrderPrice += Part.GetSellPrice()
        Next
        TotalOrderPrice = Math.Round(TotalOrderPrice, 2)
        Return TotalOrderPrice
    End Function

    ''' <summary>
    ''' Returns (Price*Count) for all parts of specific provider
    ''' </summary>
    ''' <param name="Provider"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetProviderPrice(Provider As HCProvider) As Double
        Dim Total As Double = 0
        For Each part In PartList
            If part.Provider Is Provider Then Total += part.Price * part.Count
        Next
        Total = Math.Round(Total, 2)
        Return Total
    End Function

    ''' <summary>
    ''' Prepares the class for reload
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub KillAll()
        GlobalID = 1
        OrderList.Clear()
    End Sub

    ''' <summary>
    ''' Sets GlobalID to the maximum ID + 1 value
    ''' </summary>
    ''' <remarks></remarks>
    Shared Sub SettleGlobalID()
        Dim MaxID As UInteger = 0
        For Each Order In OrderList
            If Order.Number.ID > MaxID Then MaxID = Order.Number.ID
        Next
        GlobalID = MaxID + 1
    End Sub

    ''' <summary>
    ''' Disposes of this order
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Kill()
        Form1.RemovePaymentsByOID(Me.Number.GetFullNumber)
        For Each Part In Me.PartList
            Part.Provider.PartList.Remove(Part)
            Part.Order = Nothing
            Part.Provider = Nothing
        Next
        Me.PartList = Nothing
        HCOrder.OrderList.Remove(Me)
        Me.Customer.MyOrderList.Remove(Me)
    End Sub
End Class
