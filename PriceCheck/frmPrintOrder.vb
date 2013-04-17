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
        For Each Part In Order.PartList
            If Part.Count = 1 Then
                lblParts.Text &= Part.Name & vbNewLine
            Else
                lblParts.Text &= Part.Name & " (" & CStr(Part.Count) & " шт.)" & vbNewLine
            End If
        Next
        lblPrintDate.Text = Date.Now.ToString("dd.MM.yyyy")
        lblPrice.Text = CStr(Order.GetTotalPrice & " р.")
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
    End Sub
End Class