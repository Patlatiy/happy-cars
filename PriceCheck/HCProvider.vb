Public Class HCProvider
    Public Shared GlobalID As Integer = 1
    Public ID As Integer
    Public Name As String
    Public PartList As New List(Of HCPart)
    Public Shared ProviderList As New List(Of HCProvider)

    Sub New(nName As String)
        Me.New()
        Name = nName
    End Sub

    Sub New()
        Me.New(GlobalID, "")
        If GlobalID = ID Then GlobalID += 1
    End Sub

    Sub New(nID As Integer, nName As String, nPartList As List(Of HCPart))
        Me.New(nID, nName)
        PartList = nPartList
    End Sub

    Sub New(nID As Integer, nName As String)
        ID = nID
        Name = nName
        ProviderList.Add(Me)
        If GlobalID <= ID Then GlobalID = ID + 1
    End Sub

    Public Shared Function GetByID(sID As Integer) As HCProvider
        For Each Provider In ProviderList
            If Provider.ID = sID Then Return Provider
        Next
        Return Nothing
    End Function

    Public Shared Function GetByName(sName As String) As HCProvider
        If sName Is Nothing Then Return Nothing
        If sName = "" Then Return Nothing
        For Each Provider In ProviderList
            If Provider.Name = sName Then Return Provider
        Next
        Dim newProv As New HCProvider(sName)
        Return newProv
    End Function
End Class
