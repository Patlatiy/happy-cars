Module Cars
    Public Class Car
        Private strMark As String
        Private shrtGrNumber As UShort
        Private Shared CarCount As UInteger
        Private ID As UInteger
        Public Shared carStack As New Microsoft.VisualBasic.Collection

        Sub New(Mark As String, GrNumber As UShort)
            ID = CarCount
            Modify(Mark)
            ModifyGroup(GrNumber)
            carStack.Add(Me, Mark)
            CarCount = CarCount + 1
        End Sub

        Public Sub Modify(Mark As String)
            strMark = Mark
        End Sub

        Public Sub ModifyGroup(GrNumber As UShort)
            shrtGrNumber = GrNumber
        End Sub

        Public Sub Modify(Mark As String, GrNumber As UShort)
            Modify(Mark)
            ModifyGroup(GrNumber)
        End Sub

        Public Function GetID() As Integer
            Return ID
        End Function

        Public Function GetMark() As String
            Return strMark
        End Function

        Public Function GetGroup() As UShort
            Return shrtGrNumber
        End Function
    End Class

End Module
