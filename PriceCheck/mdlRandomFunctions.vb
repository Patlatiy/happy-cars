﻿Module mdlRandomFunctions
    Public masterHash As Integer
    Public girlHash As Integer
    Public bkHash As Integer

    Public Sub LoadHashes()
        Dim pswFile As String = Application.StartupPath & "\data\hash"
        If My.Computer.FileSystem.FileExists(pswFile) Then
            Using pfile As New Microsoft.VisualBasic.FileIO.TextFieldParser(pswFile)
                pfile.TextFieldType = FileIO.FieldType.Delimited
                pfile.SetDelimiters(":")
                Dim curRow As String()
                curRow = pfile.ReadFields
                masterHash = Integer.Parse(curRow(0))
                curRow = pfile.ReadFields
                girlHash = Integer.Parse(curRow(0))
                curRow = pfile.ReadFields
                bkHash = Integer.Parse(curRow(0))
            End Using
        End If
    End Sub

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

    Public Function LoadPartList() As List(Of String)
        Dim partList As New List(Of String)
        frmLog.Add("Loading parts")
        Try
            Dim curRow As String
            Using pFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data\Parts.ini")
                pFile.TextFieldType = FileIO.FieldType.Delimited
                pFile.SetDelimiters("|")
                While Not pFile.EndOfData
                    curRow = pFile.ReadLine
                    partList.Add(curRow)
                End While
            End Using
        Catch ex As Exception
        End Try
        Return partList
    End Function
End Module
