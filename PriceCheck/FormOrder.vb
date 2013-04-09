Public Class frmOrder
    Dim MyOrder As HCOrder
    Dim txtAdvanceLastValue As String
    Dim txtPaymentLastValue As String
    Dim curPart As HCPart
    Dim curPartPosition As Integer

    Overloads Sub Show(ByRef Order As HCOrder)
        Me.Show()
        MyOrder = Order
        Me.Text = "Заказ № " & MyOrder.Number.GetFullNumber

        lwParts.Items.Clear()
        For Each Part As HCPart In MyOrder.PartList
            AddPart(Part.Name, Part.Count)
        Next

        comboCustomers.Items.Clear()
        For Each Customer As HCCustomer In HCCustomer.CustomerList
            Dim newItem = New HCListItem(Customer.GetFullName, Customer.ID)
            comboCustomers.Items.Add(newItem)
            If Customer.ID = MyOrder.Customer.ID Then comboCustomers.SelectedItem = newItem
        Next

        txtOrderNumber.Text = MyOrder.Number.GetFullNumber
        dtpDelivery.Value = Order.DeliveryDate
        txtAdvance.Text = CStr(MyOrder.AdvanceSum)
        dtpAdvance.Value = MyOrder.AdvanceDate
        txtPayment.Text = CStr(MyOrder.PaymentSum)
        dtpPayment.Value = MyOrder.PaymentDate
        FillDiscount()
        FillTotal()
    End Sub

    Sub AddPart(NewPartName As String, NewPartCount As UInteger)
        Dim newArr() As String = {NewPartName, CStr(NewPartCount)}
        Dim newItem As New ListViewItem(newArr)
        lwParts.Items.Add(newItem)
    End Sub

    Private Sub frmOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Enabled = True
    End Sub

    Private Sub comboCustomers_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboCustomers.SelectedValueChanged
        Dim newCustomer As HCCustomer = HCCustomer.FindByID(comboCustomers.Items(comboCustomers.SelectedIndex).value)
        If newCustomer.ID = MyOrder.Customer.ID Then Exit Sub
        If newCustomer Is Nothing Then
            MsgBox("Что-то пошло не так", MsgBoxStyle.Critical)
        Else
            MyOrder.Customer.MyOrderList.Remove(MyOrder)
            newCustomer.MyOrderList.Add(MyOrder)
            newCustomer.MyOrderList.Sort(AddressOf HCOrder.CompareByNumber)
            MyOrder.Customer = newCustomer
            Form1.RefreshOrders()
        End If
    End Sub

    Private Sub dtpDelivery_ValueChanged(sender As Object, e As EventArgs) Handles dtpDelivery.ValueChanged
        If MyOrder.DeliveryDate <> dtpDelivery.Value Then MyOrder.DeliveryDate = dtpDelivery.Value
    End Sub

    Private Sub txtAdvance_TextChanged(sender As Object, e As EventArgs) Handles txtAdvance.TextChanged
        If txtAdvance.Text = txtAdvanceLastValue Then Exit Sub
        Try
            MyOrder.AdvanceSum = CULng(txtAdvance.Text)
            txtAdvanceLastValue = txtAdvance.Text
            FillTotalReceived()
        Catch ex As Exception
            If txtAdvance.Text = "" Then
                txtAdvance.Text = 0
                txtAdvance.SelectAll()
                Exit Sub
            End If
            txtAdvance.Text = txtAdvanceLastValue
            txtAdvance.Select(txtAdvance.MaxLength, 0)
        End Try
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged
        If txtPayment.Text = txtPaymentLastValue Then Exit Sub
        Try
            MyOrder.PaymentSum = CULng(txtPayment.Text)
            txtPaymentLastValue = txtPayment.Text
            FillTotalReceived()
        Catch ex As Exception
            If txtPayment.Text = "" Then
                txtPayment.Text = 0
                txtPayment.SelectAll()
                Exit Sub
            End If
            txtPayment.Text = txtPaymentLastValue
            txtPayment.Select(txtPayment.MaxLength, 0)
        End Try
    End Sub

    Private Sub dtpAdvance_ValueChanged(sender As Object, e As EventArgs) Handles dtpAdvance.ValueChanged
        If MyOrder.AdvanceDate <> dtpAdvance.Value Then MyOrder.AdvanceDate = dtpAdvance.Value
    End Sub

    Private Sub dtpPayment_ValueChanged(sender As Object, e As EventArgs) Handles dtpPayment.ValueChanged
        If MyOrder.PaymentDate <> dtpPayment.Value Then MyOrder.PaymentDate = dtpPayment.Value
    End Sub

    Private Sub lwParts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lwParts.SelectedIndexChanged
        curPart = Nothing
        If lwParts.SelectedItems.Count = 0 Then
            DisablePartControls()
            Exit Sub
        End If
        curPart = MyOrder.PartList.Item(lwParts.SelectedItems.Item(0).Index)
        curPartPosition = lwParts.SelectedItems.Item(0).Index
        UpdatePart()
        EnablePartControls()
    End Sub

    Private Sub btnNewPart_Click(sender As Object, e As EventArgs) Handles btnNewPart.Click
        Dim newPart As New HCPart("Новая запчасть", 1, 0)
        MyOrder.PartList.Add(newPart)
        AddPart(newPart.Name, newPart.Count)
        lwParts.SelectedIndices.Clear()
        lwParts.SelectedIndices.Add(lwParts.Items.Count - 1)
        lwParts.Focus()
    End Sub

    Private Sub txtPartName_TextChanged(sender As Object, e As EventArgs) Handles txtPartName.TextChanged
        If curPart Is Nothing Then Exit Sub
        If txtPartName.Text = "" Then Exit Sub
        If curPart.Name <> txtPartName.Text Then
            curPart.Name = txtPartName.Text
            lwParts.Items(curPartPosition).Text = curPart.Name
        End If
    End Sub

    Private Sub nudPartCount_ValueChanged(sender As Object, e As EventArgs) Handles nudPartCount.ValueChanged
        If curPart Is Nothing Then Exit Sub
        If curPart.Count <> nudPartCount.Value Then
            curPart.Count = nudPartCount.Value
            lwParts.Items(curPartPosition).SubItems(1).Text = CStr(curPart.Count)
            UpdatePart()
        End If
    End Sub

    Private Sub nudPartPrice_ValueChanged(sender As Object, e As EventArgs) Handles nudPartPrice.ValueChanged
        If curPart Is Nothing Then Exit Sub
        If curPart.Price <> nudPartPrice.Value Then
            curPart.Price = nudPartPrice.Value
            UpdatePart()
        End If
    End Sub

    Sub EnablePartControls()
        txtPartName.Enabled = True
        nudPartCount.Enabled = True
        nudPartPrice.Enabled = True
        nudMargin.Enabled = True
        nudMarginPc.Enabled = True
        txtSellPrice.Enabled = True
    End Sub

    Sub DisablePartControls()
        txtPartName.Enabled = False
        txtPartName.Text = ""
        nudPartCount.Enabled = False
        nudPartCount.Value = 1
        nudPartPrice.Enabled = False
        nudPartPrice.Value = 0
        nudMarginPc.Enabled = False
        nudMarginPc.Value = 0
        nudMargin.Enabled = False
        nudMargin.Value = 0
        txtSellPrice.Enabled = False
        txtSellPrice.Text = ""
    End Sub

    Sub UpdatePart()
        If curPart Is Nothing Then Exit Sub
        txtPartName.Text = curPart.Name
        nudPartCount.Value = curPart.Count
        nudPartPrice.Value = curPart.Price

        'Чтобы не вызывать 2 раза подряд nudMargin_ValueChanged() нужно условие:
        If nudMargin.Value = curPart.GetMargin Then
            nudMargin_ValueChanged(nudMargin, e:=New EventArgs())
        Else
            nudMargin.Value = curPart.GetMargin
        End If

        FillDiscount()
        FillSellPrice()
        FillTotal()
    End Sub

    Sub FillSellPrice()
        txtSellPrice.Text = CStr(curPart.GetSellPrice())
    End Sub

    Sub FillTotal()
        CheckParts()
        txtTotal.Text = CStr(MyOrder.GetTotalPrice)
    End Sub

    Sub FillTotalReceived()
        txtTotalReceived.Text = CStr(CDbl(txtAdvance.Text) + CDbl(txtPayment.Text))
    End Sub

    Sub FillDiscount()
        CheckParts()
        'Чтобы не вызывать 2 раза подряд nudDiscount_ValueChanged() нужно условие:
        If nudDiscount.Value = MyOrder.GetDiscount Then
            nudDiscount_ValueChanged(nudDiscount, e:=New EventArgs())
        Else
            nudDiscount.Value = MyOrder.GetDiscount
        End If
    End Sub

    Private Sub nudMarginPc_ValueChanged(sender As Object, e As EventArgs) Handles nudMarginPc.ValueChanged
        If Silent_Change Then Exit Sub
        If curPart Is Nothing Then Exit Sub
        Dim dblMargin As Double = Math.Round(curPart.Price * nudMarginPc.Value / 100, 2)
        nudMargin.Value = dblMargin
        curPart.SetMargin(dblMargin)
    End Sub

    Private Sub nudMargin_ValueChanged(sender As Object, e As EventArgs) Handles nudMargin.ValueChanged
        If curPart Is Nothing Then Exit Sub
        If curPart.Price = 0 Then Exit Sub
        Dim dblmargin As Double = Math.Round(nudMargin.Value * 100 / curPart.Price)
        Silent_Change = True
        nudMarginPc.Value = dblmargin
        Silent_Change = False
        curPart.SetMargin(nudMargin.Value)
        FillSellPrice()
        FillTotal()
    End Sub

    Dim Silent_Change As Boolean = False
    Private Sub nudDiscountPc_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscountPc.ValueChanged
        If Silent_Change Then Exit Sub
        Dim dblDiscount As Double = MyOrder.GetTotalPrice * nudDiscountPc.Value / 100
        nudDiscount.Value = dblDiscount
    End Sub

    Private Sub nudDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscount.ValueChanged
        Dim newValue = Math.Round(nudDiscount.Value * 100 / MyOrder.GetTotalPrice)
        If newValue >= nudDiscountPc.Minimum And newValue <= nudDiscountPc.Maximum Then
            Silent_Change = True
            nudDiscountPc.Value = newValue
            Silent_Change = False
            MyOrder.SetDiscount(nudDiscount.Value)
        End If
    End Sub

    Private Sub btnDeletePart_Click(sender As Object, e As EventArgs) Handles btnDeletePart.Click
        If curPart Is Nothing Then Exit Sub
        MyOrder.PartList.Remove(MyOrder.PartList.Item(lwParts.SelectedItems.Item(0).Index))
        lwParts.Items.RemoveAt(lwParts.SelectedIndices(0))
        curPart = Nothing
        CheckParts()
        FillTotal()
    End Sub

    ''' <summary>
    ''' Checks if there is any parts in MyOrder.PartList and Enables/Disables some controls on the form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CheckParts()
        If MyOrder.PartList.Count = 0 Then
            DisableDiscountControls()
            txtTotal.Text = "0"
        Else
            EnableDiscountControls()
        End If
    End Sub

    Private Sub DisableDiscountControls()
        nudDiscount.Enabled = False
        nudDiscount.Value = nudDiscount.Minimum
        nudDiscountPc.Enabled = False
        nudDiscountPc.Value = nudDiscountPc.Minimum
    End Sub

    Private Sub EnableDiscountControls()
        nudDiscount.Enabled = True
        nudDiscountPc.Enabled = True
    End Sub
End Class
