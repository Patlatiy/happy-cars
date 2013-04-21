Public Class frmShowPayments

    Public Sub ShowPayments(dFrom As Date, dTo As Date)
        dFrom = dFrom.AddTicks(-dFrom.TimeOfDay.Ticks)
        dTo = dTo.AddTicks(TimeSpan.TicksPerDay - dTo.TimeOfDay.Ticks - 1)
        dgvPayments.Rows.Clear()
        If Me.Visible = False Then Me.Show() Else Me.BringToFront()
        dtpFrom.Value = dFrom
        dtpTo.Value = dTo
        For Each Order In HCOrder.OrderList
            If Order.AdvanceSum <> 0 And Order.AdvanceDate >= dFrom And Order.AdvanceDate <= dTo Then
                AddPayment(Order.Number.GetFullNumber, Order.AdvanceDate, "Аванс", Order.AdvanceSum)
            End If
            If Order.PaymentSum <> 0 And Order.PaymentDate >= dFrom And Order.PaymentDate <= dTo Then
                AddPayment(Order.Number.GetFullNumber, Order.PaymentDate, "Оплата", Order.PaymentSum)
            End If
        Next
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ShowPayments(dtpFrom.Value, dtpTo.Value)
    End Sub

    Private Sub AddPayment(OrderNumber As String, PaymentDate As Date, PaymentType As String, PaymentSum As Double)
        dgvPayments.Rows.Add({OrderNumber, PaymentDate.ToString("dd.MM.yyyy"), PaymentType, Math.Round(PaymentSum, 2).ToString})
    End Sub

    Private Sub frmShowPayments_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dtpFrom.Value = Form1.curDate.AddDays(1 - Form1.curDate.Day)
        dtpTo.Value = dtpFrom.Value.AddDays(Date.DaysInMonth(Form1.curDate.Year, Form1.curDate.Month) - 1)
    End Sub
End Class