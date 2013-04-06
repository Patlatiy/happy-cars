Public Class HCListItem
    Private mText As String
    Private mValue As UInteger

    Public Sub New(ByVal pText As String, ByVal pValue As UInteger)
        mText = pText
        mValue = pValue
    End Sub

    Public ReadOnly Property Text() As String
        Get
            Return mText
        End Get
    End Property

    Public ReadOnly Property Value() As UInteger
        Get
            Return mValue
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return mText
    End Function
End Class
