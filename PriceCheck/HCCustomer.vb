Public Class HCCustomer
    Public ID As UInteger
    Shared GlobalID As UInteger = 0
    Public FirstName As String
    Public SecondName As String
    Public Patron As String
    Public Phone As String
    Public MyOrderList As New List(Of HCOrder)
    Public Shared CustomerList As New List(Of HCCustomer)

    Sub New(nFirstName As String, nSecondName As String, nPatron As String, nPhone As String)
        FirstName = nFirstName
        SecondName = nSecondName
        Patron = nPatron
        Phone = nPhone
        ID = GlobalID
        GlobalID += 1
        CustomerList.Add(Me)
    End Sub

    Public Function GetFullName() As String
        Return Me.SecondName & " " & Me.FirstName & " " & Me.Patron
    End Function

    Public Shared Function FindByID(sID As UInteger) As HCCustomer
        For Each Customer As HCCustomer In CustomerList
            If Customer.ID = sID Then Return Customer
        Next
        Return Nothing
    End Function
End Class
