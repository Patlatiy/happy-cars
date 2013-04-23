Public Class frmPrintOrder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Application.DoEvents()
        Button1.Visible = True
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Overloads Sub Show(ByRef Order As HCOrder)
        Me.Show()
        lblOrderNumber.Text = "Заявка на поставку № " & Order.Number.GetID
        lblParts.Text = ""
        lblUnits.Text = ""
        For Each Part In Order.PartList
            lblParts.Text &= vbNewLine & Part.Name
            lblUnits.Text &= vbNewLine & CStr(Part.Count) & " " & Part.Units
        Next
        lblParts.Text = lblParts.Text.Trim(vbNewLine.ToCharArray)
        lblUnits.Text = lblUnits.Text.Trim(vbNewLine.ToCharArray)
        lblPrice.Text = ToMoney(Order.GetTotalPrice)
        lblDate.Text = Order.DeliveryDate.ToString("dd.MM.yyyy")
        lblComment.Text = ""
        If Order.Executor Is Nothing Then
            lblExecutor.Text = ""
            lblExecutorPhone.Text = ""
        Else
            lblExecutor.Text = Order.Executor.FullName
            lblExecutorPhone.Text = Order.Executor.Phone
        End If
        lblRecipient.Text = Order.Customer.GetShortName
        lblRecipientPhone.Text = Order.Customer.Phone
        lblCustomerFullName.Text = Order.Customer.FullName
        lblRecipientAddress.Text = ""
        lblTicketNumber.Text = "Квитанция " & Order.Number.GetFullNumber
        Dim strMonth As String = Order.Number.Month.ToString
        If Order.Number.Month < 10 Then strMonth = "0" & strMonth
        Dim strDay As String = Order.Number.Day.ToString
        If Order.Number.Day < 10 Then strDay = "0" & strDay
        lblPrintDate.Text = strDay & "." & strMonth & "." & Order.Number.Year.ToString
        lblGlobalDate.Text = strDay & "." & strMonth & "." & Order.Number.Year.ToString
        lblCashString.Text = RSDN.RusCurrency.Str(Order.AdvanceSum)
    End Sub
End Class
