Public Class CashLeaf
    Dim PanelList As New List(Of Panel)
    Dim ComboList As New List(Of ComboBox)
    Dim NameList As New List(Of Label)
    Dim SalaryList As New List(Of Label)
    Dim PercentList As New List(Of Label)
    Dim OtherPaymentsList As New List(Of Label)
    Dim AdvanceList As New List(Of Label)
    Dim OtherChargeList As New List(Of Label)
    Dim TotalList As New List(Of Label)
    Dim WorkerIdForCombos(1000) As Integer

    Private Sub CashLeaf_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub CashLeaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelList.Add(p1)
        PanelList.Add(p2)
        PanelList.Add(p3)
        PanelList.Add(p4)
        PanelList.Add(p5)
        PanelList.Add(p6)
        PanelList.Add(p7)
        PanelList.Add(p8)

        ComboList.Add(ComboName1)
        ComboList.Add(ComboName2)
        ComboList.Add(ComboName3)
        ComboList.Add(ComboName4)
        ComboList.Add(ComboName5)
        ComboList.Add(ComboName6)
        ComboList.Add(ComboName7)
        ComboList.Add(ComboName8)

        NameList.Add(lblName1)
        NameList.Add(lblName2)
        NameList.Add(lblName3)
        NameList.Add(lblName4)
        NameList.Add(lblName5)
        NameList.Add(lblName6)
        NameList.Add(lblName7)
        NameList.Add(lblName8)

        SalaryList.Add(lblSalary1)
        SalaryList.Add(lblSalary2)
        SalaryList.Add(lblSalary3)
        SalaryList.Add(lblSalary4)
        SalaryList.Add(lblSalary5)
        SalaryList.Add(lblSalary6)
        SalaryList.Add(lblSalary7)
        SalaryList.Add(lblSalary8)

        PercentList.Add(lblPercent1)
        PercentList.Add(lblPercent2)
        PercentList.Add(lblPercent3)
        PercentList.Add(lblPercent4)
        PercentList.Add(lblPercent5)
        PercentList.Add(lblPercent6)
        PercentList.Add(lblPercent7)
        PercentList.Add(lblPercent8)

        OtherPaymentsList.Add(lblOtherPayments1)
        OtherPaymentsList.Add(lblOtherPayments2)
        OtherPaymentsList.Add(lblOtherPayments3)
        OtherPaymentsList.Add(lblOtherPayments4)
        OtherPaymentsList.Add(lblOtherPayments5)
        OtherPaymentsList.Add(lblOtherPayments6)
        OtherPaymentsList.Add(lblOtherPayments7)
        OtherPaymentsList.Add(lblOtherPayments8)

        AdvanceList.Add(lblAdvance1)
        AdvanceList.Add(lblAdvance2)
        AdvanceList.Add(lblAdvance3)
        AdvanceList.Add(lblAdvance4)
        AdvanceList.Add(lblAdvance5)
        AdvanceList.Add(lblAdvance6)
        AdvanceList.Add(lblAdvance7)
        AdvanceList.Add(lblAdvance8)

        OtherChargeList.Add(lblOtherCharges1)
        OtherChargeList.Add(lblOtherCharges2)
        OtherChargeList.Add(lblOtherCharges3)
        OtherChargeList.Add(lblOtherCharges4)
        OtherChargeList.Add(lblOtherCharges5)
        OtherChargeList.Add(lblOtherCharges6)
        OtherChargeList.Add(lblOtherCharges7)
        OtherChargeList.Add(lblOtherCharges8)

        TotalList.Add(lblTotal1)
        TotalList.Add(lblTotal2)
        TotalList.Add(lblTotal3)
        TotalList.Add(lblTotal4)
        TotalList.Add(lblTotal5)
        TotalList.Add(lblTotal6)
        TotalList.Add(lblTotal7)
        TotalList.Add(lblTotal8)
        Dim i As Integer = 0
        For Each Combo In ComboList
            Combo.Items.Add("Никто")
            For Each w In Worker.AllOfThem
                Combo.Items.Add(w.FullName)
                WorkerIdForCombos(Combo.Items.Count - 1) = w.GetID

            Next
            Combo.SelectedIndex = 0
            Combo.Left = PanelList(i).Left + 5
            Combo.Top = PanelList(i).Top + 5
            i += 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        For Each Combo In ComboList
            Combo.Hide()
        Next
        Application.DoEvents()
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Button1.Show()
        For Each Combo In ComboList
            Combo.Show()
        Next
    End Sub

    Private Sub ComboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboName1.SelectedIndexChanged, ComboName2.SelectedIndexChanged, ComboName3.SelectedIndexChanged, ComboName4.SelectedIndexChanged, ComboName5.SelectedIndexChanged, ComboName6.SelectedIndexChanged, ComboName7.SelectedIndexChanged, ComboName8.SelectedIndexChanged
        Dim w As Worker = Worker.FindByID(WorkerIdForCombos(sender.selectedindex))
        If sender.selectedindex = 0 Then
            PanelList(sender.tag).Hide()
        Else
            Form1.zpWorkshops.SelectedIndex = 0
            For i = 0 To 1000
                If Form1.WorkerIDForzpWorkers(i) = w.GetID Then
                    Form1.zpWorkers.SelectedIndex = i
                    Application.DoEvents()
                    Exit For
                End If
            Next
            PanelList(sender.tag).Show()
            NameList(sender.tag).Text = w.FullName
            SalaryList(sender.tag).Text = CStr(Math.Round(w.wSalarySum, 0))
            PercentList(sender.tag).Text = CStr(Math.Round(w.wPercentSum, 2))
            OtherPaymentsList(sender.tag).Text = CStr(Math.Round(w.wNightSum + w.wOtherPayments, 2))
            AdvanceList(sender.tag).Text = CStr(Math.Round(w.wAdvance))
            OtherChargeList(sender.tag).Text = CStr(Math.Round(w.wOtherCharges, 2))
            TotalList(sender.tag).Text = CStr(Math.Round(w.wSalarySum + w.wPercentSum + w.wNightSum - w.wAdvance))
        End If
    End Sub
End Class
