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
    Public Shared UnitsList As New List(Of String)
    Private _Units As String
    Public Property Units As String
        Get
            Return _Units
        End Get
        Set(value As String)
            _Units = value
            Dim found As Boolean = False
            For Each tStr As String In UnitsList
                If tStr = value Then found = True
            Next
            If Not found Then UnitsList.Add(value)
        End Set
    End Property

    Sub New(nName As String, nCount As UInteger, nUnits As String, nPrice As Double)
        Name = nName
        Count = nCount
        Units = nUnits
        Price = nPrice
    End Sub

    Sub New(nName As String, nCount As UInteger, nUnits As String, nPrice As Double, nMargin As Double)
        Name = nName
        Count = nCount
        Units = nUnits
        Price = nPrice
        Margin = nMargin
    End Sub

    Public Function GetSellPrice() As Double
        Return Math.Round((Price * Count) + Margin, 2)
    End Function
End Class
