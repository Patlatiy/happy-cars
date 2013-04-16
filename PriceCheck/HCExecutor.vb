Public Class HCExecutor
    Public Shared ExecList As New List(Of HCExecutor)
    Public ID As UInteger
    Public Shared GlobalID As UInteger = 1
    Public LastName As String
    Public FirstName As String
    Public Patronage As String
    Public Phone As String
    Public ReadOnly Property FullName As String
        Get
            Return (Me.LastName & " " & Me.FirstName & " " & Me.Patronage).Trim()
        End Get
    End Property
    Public ReadOnly Property ShortName As String
        Get
            If LastName = "" Then Return FullName
            If FirstName = "" And Patronage = "" Then Return LastName
            If FirstName = "" Then Return LastName
            If Patronage = "" Then Return (LastName & " " & FirstName(0).ToString & ".")
            Return (Me.LastName & " " & Me.FirstName(0) & ". " & Me.Patronage(0) & ".")
        End Get
    End Property

    Sub New()
        Me.New("", "", "", "")
    End Sub

    Sub New(eLastName As String, eFirstName As String, ePatronage As String, ePhone As String)
        Me.New(GlobalID, eLastName, eFirstName, ePatronage, ePhone)
        GlobalID += 1
    End Sub

    Sub New(eID As UInteger, eLastName As String, eFirstName As String, ePatronage As String, ePhone As String)
        FirstName = eFirstName
        LastName = eLastName
        Patronage = ePatronage
        Phone = ePhone
        ID = eID
        ExecList.Add(Me)
    End Sub

    Public Shared Function GetById(sID As UInteger) As HCExecutor
        For Each Exec In ExecList
            If Exec.ID = sID Then Return Exec
        Next
        Return Nothing
    End Function

    Public Shared Sub KillAll()
        GlobalID = 1
        ExecList.Clear()
    End Sub
End Class
