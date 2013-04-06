Public Class HCOrder
    Public Customer As HCCustomer
    Public DeliveryDate As Date

    Public PaymentSum As ULong
    Public PaymentDate As Date

    Public AdvanceSum As ULong
    Public AdvanceDate As Date
    Public Parts As List(Of HCPart)
    Public Number As OrderNumber
    Public Shared OrderList As New List(Of HCOrder)

    Structure HCPart
        Public Name As String
        Public Count As UInteger
        Public Price As UInteger
        Sub New(nName As String, nCount As UInteger, nPrice As UInteger)
            Name = nName
            Count = nCount
            Price = nPrice
        End Sub
    End Structure

    Structure OrderNumber
        Public Year As Short
        Public Month As Short
        Public ID As UInteger
        Public Shared GlobalID As UInteger = 1

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

        Sub New(ByVal nYear As Short, ByVal nMonth As UShort)
            Year = nYear
            Month = nMonth
            ID = GlobalID
            GlobalID += 1
        End Sub
    End Structure

    Sub New(ByRef nCustomer As HCCustomer, _
            ByVal nDeliveryDate As Date, _
            ByVal nPaymentSum As ULong, _
            ByVal nPaymentDate As Date, _
            ByVal nAdvanceSum As ULong, _
            ByVal nAdvanceDate As Date, _
            ByVal nParts As List(Of HCPart))
        Customer = nCustomer
        Customer.MyOrderList.Add(Me)
        DeliveryDate = nDeliveryDate
        PaymentSum = nPaymentSum
        PaymentDate = nPaymentDate
        AdvanceSum = nAdvanceSum
        AdvanceDate = nAdvanceDate
        Parts = nParts
        Number = New OrderNumber(Form1.curDate.Year, Form1.curDate.Month)
        OrderList.Add(Me)
    End Sub
End Class
