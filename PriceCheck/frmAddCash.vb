Public Class frmAddCash
    Private MyOwner As Windows.Forms.Form
    Private MyOrder As HCOrder

    Overloads Sub Show(ByRef Order As HCOrder, ByRef Owner As Windows.Forms.Form)
        Me.Show()
        MyOrder = Order
        MyOwner = Owner
        MyOwner.Enabled = False
        Me.Text = "Заказ № " & MyOrder.Number.GetFullNumber
        txtOrderDate.Text = MyOrder.Number.GetDate
        txtOrderNumber.Text = MyOrder.Number.GetID
        nudAdvance.Value = MyOrder.AdvanceSum
        dtpAdvance.Value = MyOrder.AdvanceDate
        nudPayment.Value = MyOrder.PaymentSum
        dtpPayment.Value = MyOrder.PaymentDate
    End Sub

    Private Sub frmAddCash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MyOwner.Enabled = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MyOrder.AdvanceSum = CDbl(nudAdvance.Value)
        MyOrder.AdvanceDate = dtpAdvance.Value
        MyOrder.PaymentSum = CDbl(nudPayment.Value)
        MyOrder.PaymentDate = dtpPayment.Value
        Close()
    End Sub
End Class