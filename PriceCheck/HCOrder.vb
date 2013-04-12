Public Class HCOrder
    Public Customer As HCCustomer
    Public DeliveryDate As Date

    Public PaymentSum As ULong
    Public PaymentDate As Date

    Public AdvanceSum As ULong
    Public AdvanceDate As Date
    Private Discount As ULong = 0
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

        Function GetFullNumber()
            Dim tmpMonth As String
            Dim tmpID As String
            tmpMonth = CStr(Month)
            If Month < 10 Then tmpMonth = "0" & tmpMonth
            tmpID = CStr(ID)
            Select Case ID
                Case Is < 10
                    tmpID = "000" & tmpID
                Case Is < 100
                    tmpID = "00" & tmpID
                Case Is < 1000
                    tmpID = "0" & tmpID
            End Select
            Return CStr(Year) & "-" & tmpMonth & "-" & tmpID
        End Function

        Sub SetFullNumber(FullNumber As String)
            Year = CShort(FullNumber(0).ToString & FullNumber(1).ToString & FullNumber(2).ToString & FullNumber(3).ToString)
            Month = CShort(FullNumber(5).ToString & FullNumber(6).ToString)
            ID = CUInt(FullNumber(8).ToString & FullNumber(9).ToString & FullNumber(10).ToString & FullNumber(11).ToString)
        End Sub

        Sub New(ByVal nYear As Short, ByVal nMonth As UShort)
            Year = nYear
            Month = nMonth
            ID = GlobalID
            GlobalID += 1
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

    Sub New(ByRef nCustomer As HCCustomer, _
            ByVal nDeliveryDate As Date, _
            ByVal nPaymentSum As ULong, _
            ByVal nPaymentDate As Date, _
            ByVal nAdvanceSum As ULong, _
            ByVal nAdvanceDate As Date, _
            ByVal nDiscount As Double, _
            ByVal nParts As List(Of HCPart), _
            ByVal nCompleted As Boolean)
        Customer = nCustomer
        Customer.MyOrderList.Add(Me)
        DeliveryDate = nDeliveryDate
        PaymentSum = nPaymentSum
        PaymentDate = nPaymentDate
        AdvanceSum = nAdvanceSum
        AdvanceDate = nAdvanceDate
        PartList = nParts
        Number = New OrderNumber(Form1.curDate.Year, Form1.curDate.Month)
        Me.SetDiscount(nDiscount)
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

    Public Function GetDiscount() As Double
        Return Discount / 100
    End Function

    Public Sub SetDiscount(sDiscount As Double)
        Discount = CULng(sDiscount * 100)
    End Sub

    Public Function GetTotalPrice() As Double
        Return Math.Round(Me.GetRawPrice() - Me.GetDiscount(), 2)
    End Function

    Public Function GetRawPrice() As Double
        Dim TotalOrderPrice As Double = 0
        For Each Part In PartList
            TotalOrderPrice += Part.GetSellPrice()
        Next
        TotalOrderPrice = Math.Round(TotalOrderPrice, 2)
        Return TotalOrderPrice
    End Function

    Public Shared Sub KillAll()
        GlobalID = 1
        OrderList.Clear()
    End Sub

    Shared Sub SettleGlobalID()
        Dim MaxID As UInteger = 0
        For Each Order In OrderList
            If Order.Number.ID > MaxID Then MaxID = Order.Number.ID
        Next
        GlobalID = MaxID + 1
    End Sub
End Class
