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
        Public ID As UInteger

        Function GetDate() As String
            Dim tmpMonth As String
            tmpMonth = CStr(Month)
            If Month < 10 Then tmpMonth = "0" & tmpMonth
            Return CStr(Year) & "-" & tmpMonth
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
            ID = CUInt(FullNumber(8).ToString & FullNumber(9).ToString & FullNumber(10).ToString & FullNumber(11).ToString)
            If GlobalID <= ID Then GlobalID = ID + 1
        End Sub

        Sub New(ByVal nYear As Short, ByVal nMonth As UShort)
            Year = nYear
            Month = nMonth
            ID = GlobalID
            GlobalID += 1
        End Sub

        Sub New(nID As UInteger, ByVal nYear As Short, ByVal nMonth As UShort)
            Year = nYear
            Month = nMonth
            ID = nID
        End Sub
    End Structure

    Sub New()
        PartList = New List(Of HCPart)
        Number = New OrderNumber(Form1.curDate.Year, Form1.curDate.Month)
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
        Number = New OrderNumber(Form1.curDate.Year, Form1.curDate.Month)
        Discount = nDiscount
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
        Number = New OrderNumber(0, 0, 0)
        Number.SetFullNumber(nNumber)
        Discount = nDiscount
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
    ''' Returns price of whole order, without discount
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
End Class
