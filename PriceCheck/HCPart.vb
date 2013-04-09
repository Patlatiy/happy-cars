Public Class HCPart
    Public Name As String
    Public Count As UInteger
    Public Price As ULong
    Private Margin As ULong = 0

    Sub New(nName As String, nCount As UInteger, nPrice As ULong)
        Name = nName
        Count = nCount
        Price = nPrice
    End Sub

    Sub New(nName As String, nCount As UInteger, nPrice As UInteger, nMargin As Double)
        Name = nName
        Count = nCount
        Price = nPrice
        SetMargin(nMargin)
    End Sub

    Public Function GetMargin() As Double
        Return Math.Round(Margin / 100, 2)
    End Function

    Public Sub SetMargin(sMargin As Double)
        Margin = CULng(sMargin * 100)
    End Sub

    Public Function GetSellPrice() As Double
        Return (Price + GetMargin()) * Count
    End Function
End Class
