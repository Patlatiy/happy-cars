Public Class frmPrintOrder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Application.DoEvents()
        Button1.Visible = True
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Overloads Sub Show(ByRef Order As HCOrder)
        Me.Show()
        lblParts.Text = ""
        For Each Part In Order.PartList
            If Part.Count = 1 Then
                lblParts.Text &= Part.Name & vbNewLine
            Else
                lblParts.Text &= Part.Name & " (" & CStr(Part.Count) & " шт.)" & vbNewLine
            End If

        Next
        lblPrintDate.Text = My.Computer.Clock.LocalTime.ToString("dd MMMM yyyy") & " г."
        lblPrice.Text = CStr(Order.GetTotalPrice & " р.")
        lblDate.Text = Order.DeliveryDate.ToString("dd MMMM yyyy") & " г."
        lblComment.Text = ""
        lblExecutor.Text = ""
        lblExecutorPhone.Text = ""
        lblRecipient.Text = Order.Customer.GetFullName
        lblRecipientPhone.Text = Order.Customer.Phone
        lblRecipientAddress.Text = ""
    End Sub
End Class