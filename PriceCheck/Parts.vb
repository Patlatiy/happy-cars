Public Class HCPart
    Public Name As String
    Public Count As UInteger
    Public Price As ULong
    Private Margin As ULong = 0
    Private Discount As ULong = 0

    Sub New(nName As String, nCount As UInteger, nPrice As ULong)
        Name = nName
        Count = nCount
        Price = nPrice
    End Sub

    Sub New(nName As String, nCount As UInteger, nPrice As UInteger, nMargin As Double, nDiscount As Double)
        Name = nName
        Count = nCount
        Price = nPrice
        SetMargin(nMargin)
        SetDiscount(nDiscount)
    End Sub

    Public Function GetMargin() As Double
        Return Margin / 100
    End Function

    Public Sub SetMargin(sMargin As Double)
        Margin = CULng(sMargin * 100)
    End Sub

    Public Function GetDiscount() As Double
        Return Discount / 100
    End Function

    Public Sub SetDiscount(sDiscount As Double)
        Discount = CULng(sDiscount * 100)
    End Sub
End Class
