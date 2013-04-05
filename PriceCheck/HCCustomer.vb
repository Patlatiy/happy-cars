Public Class HCCustomer
    Public FirstName As String
    Public SecondName As String
    Public Patron As String
    Public Phone As String
    Public OrderList As List(Of HCOrder)

    Sub New(nFirstName As String, nSecondName As String, nPatron As String, nPhone As String)
        FirstName = nFirstName
        SecondName = nSecondName
        Patron = nPatron
        Phone = nPhone
    End Sub

    Public Function GetFullName() As String
        Return Me.SecondName & " " & Me.FirstName & " " & Me.Patron
    End Function
End Class
