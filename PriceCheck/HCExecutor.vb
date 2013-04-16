Public Class HCExecutor
    Public Shared ExecList As New List(Of HCExecutor)
    Public ID As UInteger
    Private Shared GlobalID As UInteger = 1
    Public LastName As String
    Public FirstName As String
    Public Patronage As String
    Public Phone As String
    Public ReadOnly Property FullName As String
        Get
            Return (Me.LastName & " " & Me.FirstName & " " & Me.Patronage).Trim()
        End Get
    End Property

    Sub New()
        Me.New("", "", "", "")
    End Sub

    Sub New(eLastName As String, eFirstName As String, ePatronage As String, ePhone As String)
        FirstName = eFirstName
        LastName = eLastName
        Patronage = ePatronage
        Phone = ePhone
        ID = GlobalID
        GlobalID += 1
        ExecList.Add(Me)
    End Sub

    Public Shared Function GetById(sID As UInteger) As HCExecutor
        For Each Exec In ExecList
            If Exec.ID = sID Then Return Exec
        Next
        Return Nothing
    End Function
End Class
