Public Class HCOrder
    Public Customer As HCCustomer
    Public DeliveryDate As Date

    Public PaymentSum As ULong
    Public PaymentDate As Date

    Public AdvanceSum As ULong
    Public AdvanceDate As Date
    Public Parts As List(Of HCPart)

    Structure HCPart
        Public Name As String
        Public Count As UInteger
        Public Price As UInteger
    End Structure

    Sub New(ByRef nCustomer As HCCustomer, _
            ByVal nDeliveryDate As Date, _
            ByVal nPaymentSum As ULong, _
            ByVal nPaymentDate As Date, _
            ByVal nAdvanceSum As ULong, _
            ByVal nAdvanceDate As Date, _
            ByVal nParts As List(Of HCPart))
        Customer = nCustomer
        DeliveryDate = nDeliveryDate
        PaymentSum = nPaymentSum
        PaymentDate = nPaymentDate
        AdvanceSum = nAdvanceSum
        AdvanceDate = nAdvanceDate
        Parts = nParts
    End Sub
End Class
