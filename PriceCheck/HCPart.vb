Public Class HCPart
    Public Name As String
    Public Count As UInteger
    Public Provider As HCProvider
    Public Order As HCOrder
    Public Shared UnitsList As New List(Of String)
    Public Shared GlobalID As Integer
    Public ID As Integer
    Public PaymentAdded As Boolean = False

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

    Sub New(nName As String, nCount As UInteger, nUnits As String, nPrice As Double, ByRef nOrder As HCOrder, ByRef nProvider As HCProvider)
        Me.New(nName, nCount, nUnits, nPrice, 0, nOrder, nProvider)
    End Sub

    Sub New(nName As String, nCount As UInteger, nUnits As String, nPrice As Double, nMargin As Double, ByRef nOrder As HCOrder, ByRef nProvider As HCProvider)
        Me.New(GlobalID, nName, nCount, nUnits, nPrice, nMargin, nOrder, nProvider, False)
        If GlobalID = ID Then GlobalID += 1
    End Sub

    Sub New(nID As Integer, nName As String, nCount As UInteger, nUnits As String, nPrice As Double, nMargin As Double, ByRef nOrder As HCOrder, ByRef nProvider As HCProvider, nPA As Boolean)
        ID = nID
        Name = nName
        Count = nCount
        Units = nUnits
        Price = nPrice
        Margin = nMargin
        Provider = nProvider
        Order = nOrder
        PaymentAdded = nPA
        If Not Provider Is Nothing Then Provider.PartList.Add(Me)
        If GlobalID <= ID Then GlobalID = ID + 1
    End Sub

    Public Function GetSellPrice() As Double
        Return Math.Round((Price * Count) + Margin, 2)
    End Function
End Class
