Module mdlRandomFunctions
    Function ToMoney(value As Double) As String
        If (value Mod 1) = 0 Then Return CStr(value) & " р."
        Dim rouble As String, kop As String
        rouble = CStr(Math.Truncate(value))
        kop = CStr(CInt((value Mod 1) * 100))
        Return rouble & " р. " & kop & " коп."
    End Function

    Public Function ToStringMoney(number As Double)
        Dim nul As String = "ноль"
        Dim ten As String(,) = {
            {"", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"},
            {"", "одна", "две", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"}
            }
        Dim a20 As String() = {"десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"}
        Dim tens As String() = {"", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто"}
        Return Nothing
    End Function
End Module
