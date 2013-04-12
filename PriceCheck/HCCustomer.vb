Public Class HCCustomer
    Public ID As UInteger
    Shared GlobalID As UInteger = 1
    Public FirstName As String = ""
    Public LastName As String = ""
    Public Patron As String = ""
    Public Phone As String = ""
    Public MyOrderList As New List(Of HCOrder)
    Public MyOrderIDList As New List(Of String)
    Public Shared CustomerList As New List(Of HCCustomer)

    Sub New()
        Me.New("", "", "", "")
    End Sub

    Sub New(nID As UInteger, nFirstName As String, nLastName As String, nPatron As String, nPhone As String)
        Me.New(nFirstName, nLastName, nPatron, nPhone)
        Me.ID = nID
        If GlobalID <= nID Then GlobalID = nID + 1
    End Sub

    Sub New(nFirstName As String, nLastName As String, nPatron As String, nPhone As String)
        FirstName = nFirstName.Trim
        LastName = nLastName.Trim
        Patron = nPatron.Trim
        Phone = nPhone.Trim
        ID = GlobalID
        GlobalID += 1
        CustomerList.Add(Me)
    End Sub

    ''' <summary>
    ''' Returns last name, first name and patronage
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFullName() As String
        Return (Me.LastName & " " & Me.FirstName & " " & Me.Patron).Trim()
    End Function

    ''' <summary>
    ''' Returns last name with the initials
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetShortName() As String
        If LastName = "" Then Return GetFullName()
        If FirstName = "" And Patron = "" Then Return LastName
        If FirstName = "" Then Return LastName
        If Patron = "" Then Return (LastName & " " & FirstName(0).ToString & ".")
        Return (Me.LastName & " " & Me.FirstName(0) & ". " & Me.Patron(0) & ".")
    End Function

    ''' <summary>
    ''' Returns an instance with given ID
    ''' </summary>
    ''' <param name="sID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function FindByID(sID As UInteger) As HCCustomer
        For Each Customer As HCCustomer In CustomerList
            If Customer.ID = sID Then Return Customer
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Tells if this instance is empty
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsEmpty() As Boolean
        If FirstName = "" And LastName = "" And Patron = "" And Phone = "" And MyOrderList.Count = 0 Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Prepares the class for reload
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub KillAll()
        GlobalID = 1
        CustomerList.Clear()
    End Sub

    ''' <summary>
    ''' Sets GlobalID to the maximum ID + 1 value
    ''' </summary>
    ''' <remarks></remarks>
    Shared Sub SettleGlobalID()
        Dim MaxID As UInteger = 0
        For Each Customer In CustomerList
            If Customer.ID > MaxID Then MaxID = Customer.ID
        Next
        GlobalID = MaxID + 1
    End Sub
End Class
