Module mdlRandomFunctions
    Function ToMoney(value As Double) As String
        If (value Mod 1) = 0 Then Return CStr(value) & " р."
        Dim rouble As String, kop As String
        rouble = CStr(Math.Truncate(value))
        kop = CStr(CInt((value Mod 1) * 100))
        Return rouble & " р. " & kop & " коп."
    End Function
End Module
