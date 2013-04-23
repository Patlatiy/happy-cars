Public Class HCExecutor
    Public Shared ExecList As New List(Of HCExecutor)
    Public ID As UInteger
    Public Shared GlobalID As UInteger = 1
    Public LastName As String
    Public FirstName As String
    Public Patronage As String
    Public _Phone As String = ""
    Public _Code As String = ""
    Public Property Phone As String
        Get
            Return "+7 (" & _Code & ") " & _Phone
        End Get
        Set(value As String)
            If value = "" Then
                _Code = ""
                _Phone = ""
                Exit Property
            End If
            Dim j As Integer = value.IndexOf(CChar("(")) + 1 'Index where code starts
            Dim i As Integer = value.IndexOf(CChar(")")) + 1 ' Index where code ends
            _Code = value.Substring(j, i - j - 1).Trim
            _Phone = value.Substring(i, value.Length - i).Trim
        End Set
    End Property
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

    Public Shared Function GetById(sID As Integer) As HCExecutor
        If sID < 0 Then Return Nothing
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
