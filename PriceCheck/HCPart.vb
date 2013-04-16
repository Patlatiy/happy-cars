Public Class HCPart
    Public Name As String
    Public Count As UInteger
    Private _Price As ULong
    Public Property Price As Double
        Get
            Return Math.Round(CDbl(_Price / 100), 2)
        End Get
        Set(value As Double)
            _Price = Math.Round(value * 100)
        End Set
    End Property
    Private _Margin As ULong = 0
    Public Property Margin As Double
        Get
            Return Math.Round(_Margin / 100, 2)
        End Get
        Set(value As Double)
            _Margin = CULng(value * 100)
        End Set
    End Property

    Sub New(nName As String, nCount As UInteger, nPrice As Double)
        Name = nName
        Count = nCount
        Price = nPrice
    End Sub

    Sub New(nName As String, nCount As UInteger, nPrice As Double, nMargin As Double)
        Name = nName
        Count = nCount
        Price = nPrice
        Margin = nMargin
    End Sub

    Public Function GetSellPrice() As Double
        Return Math.Round((Price * Count) + Margin, 2)
    End Function
End Class
