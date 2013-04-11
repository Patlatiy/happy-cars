Public Class HCCustomer
    Public ID As UInteger
    Shared GlobalID As UInteger = 0
    Public FirstName As String = ""
    Public LastName As String = ""
    Public Patron As String = ""
    Public Phone As String = ""
    Public MyOrderList As New List(Of HCOrder)
    Public Shared CustomerList As New List(Of HCCustomer)

    Sub New(nFirstName As String, nLastName As String, nPatron As String, nPhone As String)
        FirstName = nFirstName.Trim
        LastName = nLastName.Trim
        Patron = nPatron.Trim
        Phone = nPhone.Trim
        ID = GlobalID
        GlobalID += 1
        CustomerList.Add(Me)
    End Sub

    Public Function GetFullName() As String
        Return (Me.LastName & " " & Me.FirstName & " " & Me.Patron).Trim()
    End Function

    Public Function GetShortName() As String
        If LastName = "" Then Return GetFullName()
        If FirstName = "" And Patron = "" Then Return LastName
        If FirstName = "" Then Return LastName
        If Patron = "" Then Return (LastName & " " & FirstName(0).ToString & ".")
        Return (Me.LastName & " " & Me.FirstName(0) & ". " & Me.Patron(0) & ".")
    End Function

    Public Shared Function FindByID(sID As UInteger) As HCCustomer
        For Each Customer As HCCustomer In CustomerList
            If Customer.ID = sID Then Return Customer
        Next
        Return Nothing
    End Function

    Public Function IsEmpty() As Boolean
        If FirstName = "" And LastName = "" And Patron = "" And Phone = "" And MyOrderList.Count = 0 Then
            Return True
        End If
        Return False
    End Function
End Class
