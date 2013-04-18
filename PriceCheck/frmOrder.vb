Public Class frmOrder
    Dim MyOrder As HCOrder
    Dim curPart As HCPart
    Dim curPartPosition As Integer
    Dim MyOwner As Object 'Not Windows.Forms.Form because of the error with the RefreshOrders() procedure in FormClosing event handler. I will fix it eventually

    Overloads Sub Show(ByRef Order As HCOrder, ByRef Owner As Windows.Forms.Form)
        Me.Show(Owner)
        MyOrder = Order
        MyOwner = Owner
        MyOwner.Enabled = False
        Me.Text = "Заказ № " & MyOrder.Number.GetFullNumber

        Select Case Form1.WriteRight
            Case Form1.WriteRights.Master
                boxCompleted.Enabled = False
                nudAdvance.Enabled = False
                dtpAdvance.Enabled = False
                nudPayment.Enabled = False
                dtpPayment.Enabled = False
        End Select

        lwParts.Items.Clear()
        For Each Part As HCPart In MyOrder.PartList
            AddPartToList(Part.Name, Part.Count, Part.Units, Part.GetSellPrice)
        Next

        comboCustomer.Items.Clear()
        For Each Customer In HCCustomer.CustomerList
            Dim newItem = New HCListItem(Customer.FullName, Customer.ID)
            comboCustomer.Items.Add(newItem)
            If Customer.ID = MyOrder.Customer.ID Then comboCustomer.SelectedItem = newItem
        Next

        comboExecutor.Items.Clear()
        For Each Executor In HCExecutor.ExecList
            Dim newItem = New HCListItem(Executor.ShortName, Executor.ID)
            comboExecutor.Items.Add(newItem)
            If Not MyOrder.Executor Is Nothing Then
                If Executor.ID = MyOrder.Executor.ID Then comboExecutor.SelectedItem = newItem
            End If
        Next

        RefreshUnits()
        RefreshProviders()

        txtOrderDate.Text = MyOrder.Number.GetDate
        txtOrderNumber.Text = MyOrder.Number.GetID
        dtpDelivery.Value = Order.DeliveryDate
        nudAdvance.Value = MyOrder.AdvanceSum
        dtpAdvance.Value = MyOrder.AdvanceDate
        nudPayment.Value = MyOrder.PaymentSum
        dtpPayment.Value = MyOrder.PaymentDate
        txtComment.Text = MyOrder.Comment
        boxCompleted.Checked = MyOrder.Completed
        FillDiscount()
        FillTotal()
    End Sub

    Sub AddPartToList(NewPartName As String, NewPartCount As UInteger, NewPartUnits As String, NewPartPrice As Double)
        Dim newArr() As String = {CStr(lwParts.Items.Count + 1), NewPartName, CStr(NewPartCount) & " " & NewPartUnits, CStr(Math.Round(NewPartPrice, 2))}
        Dim newItem As New ListViewItem(newArr)
        lwParts.Items.Add(newItem)
    End Sub

    Sub RecountParts()
        Dim i = 1
        For Each Part As ListViewItem In lwParts.Items
            Part.Text = CStr(i)
            i += 1
        Next
    End Sub

    Private Sub frmOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            MyOwner.RefreshOrders()
        Catch ex As Exception
        End Try
        MyOwner.Enabled = True
        Form1.SaveCustomers()
        Form1.SaveProviders()
        Form1.SaveExecutors()
    End Sub

    Private Sub comboCustomers_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboCustomer.SelectedValueChanged
        Dim newCustomer As HCCustomer = HCCustomer.FindByID(comboCustomer.Items(comboCustomer.SelectedIndex).Value)
        If newCustomer Is Nothing Then
            MsgBox("Что-то пошло не так...", MsgBoxStyle.Critical, "Ошибка!")
        Else
            If newCustomer.ID = MyOrder.Customer.ID Then Exit Sub
            MyOrder.Customer.MyOrderList.Remove(MyOrder)
            newCustomer.MyOrderList.Add(MyOrder)
            newCustomer.MyOrderList.Sort(AddressOf HCOrder.CompareByNumber)
            MyOrder.Customer = newCustomer
        End If
    End Sub

    Private Sub comboExecutor_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboExecutor.SelectedValueChanged
        Dim newExecutor = HCExecutor.GetById(comboExecutor.Items(comboExecutor.SelectedIndex).Value)
        If newExecutor Is Nothing Then
            MsgBox("Что-то пошло не так...", MsgBoxStyle.Critical, "Ошибка!")
        Else
            If Not MyOrder.Executor Is Nothing Then
                If newExecutor.ID = MyOrder.Executor.ID Then Exit Sub
            End If
            MyOrder.Executor = newExecutor
        End If
    End Sub

    Private Sub dtpDelivery_ValueChanged(sender As Object, e As EventArgs) Handles dtpDelivery.ValueChanged
        If MyOrder.DeliveryDate <> dtpDelivery.Value Then MyOrder.DeliveryDate = dtpDelivery.Value
    End Sub

    Private Sub dtpAdvance_ValueChanged(sender As Object, e As EventArgs) Handles dtpAdvance.ValueChanged
        If MyOrder.AdvanceDate <> dtpAdvance.Value Then MyOrder.AdvanceDate = dtpAdvance.Value
    End Sub

    Private Sub dtpPayment_ValueChanged(sender As Object, e As EventArgs) Handles dtpPayment.ValueChanged
        If MyOrder.PaymentDate <> dtpPayment.Value Then MyOrder.PaymentDate = dtpPayment.Value
    End Sub

    Private Sub txtComment_TextChanged(sender As Object, e As EventArgs) Handles txtComment.TextChanged
        If MyOrder Is Nothing Then Exit Sub
        MyOrder.Comment = txtComment.Text
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
        Dim newPart As New HCPart("Новая запчасть", 1, "шт.", 0, MyOrder, Nothing)
        MyOrder.PartList.Add(newPart)
        AddPartToList(newPart.Name, newPart.Count, newPart.Units, 0)
        lwParts.SelectedIndices.Clear()
        lwParts.SelectedIndices.Add(lwParts.Items.Count - 1)
        lwParts.Focus()
    End Sub

    Private Sub txtPartName_TextChanged(sender As Object, e As EventArgs) Handles txtPartName.TextChanged
        If curPart Is Nothing Then Exit Sub
        If txtPartName.Text = "" Then Exit Sub
        If curPart.Name <> txtPartName.Text Then
            curPart.Name = txtPartName.Text
            lwParts.Items(curPartPosition).SubItems(1).Text = curPart.Name
        End If
    End Sub

    Private Sub nudPartCount_ValueChanged(sender As Object, e As EventArgs) Handles nudPartCount.ValueChanged
        If curPart Is Nothing Then Exit Sub
        If curPart.Count <> nudPartCount.Value Then
            curPart.Count = nudPartCount.Value
            lwParts.Items(curPartPosition).SubItems(2).Text = CStr(curPart.Count) & " " & curPart.Units
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
        If (Form1.WriteRight = Form1.WriteRights.The_Girl) Or (Form1.WriteRight = Form1.WriteRights.Read_Only) Or MyOrder.Completed Then Exit Sub
        txtPartName.Enabled = True
        nudPartCount.Enabled = True
        nudPartPrice.Enabled = True
        nudMargin.Enabled = True
        nudMarginPc.Enabled = True
        txtSellPrice.Enabled = True
        txtRawPrice.Enabled = True
        comboUnits.Enabled = True
        comboProvider.Enabled = True
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
        txtRawPrice.Enabled = False
        txtRawPrice.Text = ""
        comboUnits.Enabled = False
        comboUnits.Text = "шт."
        comboProvider.Enabled = False
        comboProvider.Text = ""
    End Sub

    Sub UpdatePart()
        If curPart Is Nothing Then Exit Sub
        txtPartName.Text = curPart.Name
        nudPartCount.Value = curPart.Count
        nudPartPrice.Value = curPart.Price
        comboUnits.Text = curPart.Units
        If Not curPart.Provider Is Nothing Then comboProvider.Text = curPart.Provider.Name

        'Чтобы не вызывать 2 раза подряд nudMargin_ValueChanged() нужно условие:
        If nudMargin.Value = curPart.Margin Then
            nudMargin_ValueChanged(nudMargin, e:=New EventArgs())
        Else
            nudMargin.Value = curPart.Margin
        End If

        RefreshUnits()
        RefreshProviders()
        FillDiscount()
        FillSellPrice()
        FillTotal()
        FillTotalReceived()
    End Sub

    Sub FillSellPrice()
        txtSellPrice.Text = ToMoney(curPart.GetSellPrice())
        txtRawPrice.Text = ToMoney(curPart.Price * curPart.Count)
    End Sub

    Sub FillTotal()
        CheckParts()
        txtTotal.Text = ToMoney(MyOrder.GetTotalPrice)
    End Sub

    Sub FillTotalReceived()
        txtTotalReceived.Text = ToMoney(nudAdvance.Value + nudPayment.Value)
    End Sub

    Sub FillDiscount()
        CheckParts()
        'Чтобы не вызывать 2 раза подряд nudDiscount_ValueChanged() нужно условие:
        If nudDiscount.Value = MyOrder.Discount Then
            nudDiscount_ValueChanged(nudDiscount, e:=New EventArgs())
        Else
            nudDiscount.Value = MyOrder.Discount
        End If
    End Sub

    Private Sub nudMarginPc_ValueChanged(sender As Object, e As EventArgs) Handles nudMarginPc.ValueChanged
        If Silently Then Exit Sub
        If curPart Is Nothing Then Exit Sub
        Dim dblMargin As Double = Math.Round(curPart.Price * curPart.Count * nudMarginPc.Value / 100, 2)
        nudMargin.Value = dblMargin
        curPart.Margin = dblMargin
    End Sub

    Private Sub nudMargin_ValueChanged(sender As Object, e As EventArgs) Handles nudMargin.ValueChanged
        If curPart Is Nothing Then Exit Sub
        If curPart.Price = 0 Then Exit Sub
        Dim dblmargin As Double = Math.Round((nudMargin.Value * 100) / (curPart.Price * curPart.Count))
        Silently = True
        nudMarginPc.Value = dblmargin
        Silently = False
        curPart.Margin = nudMargin.Value
        FillSellPrice()
        FillTotal()
    End Sub

    Private Sub RefreshUnits()
        comboUnits.Items.Clear()
        For Each Unit In HCPart.UnitsList
            comboUnits.Items.Add(Unit)
        Next
    End Sub

    Private Sub RefreshProviders()
        comboProvider.Items.Clear()
        For Each Provider In HCProvider.ProviderList
            Dim newItem As New HCListItem(Provider.Name, Provider.ID)
            comboProvider.Items.Add(newItem)
        Next
    End Sub

    Private Sub comboUnits_KeyDown(sender As Object, e As KeyEventArgs) Handles comboUnits.KeyDown
        If curPart Is Nothing Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            curPart.Units = comboUnits.Text
            lwParts.Items(curPartPosition).SubItems(2).Text = CStr(curPart.Count) & " " & curPart.Units
        End If
    End Sub

    Private Sub comboUnits_Leave(sender As Object, e As EventArgs) Handles comboUnits.Leave, Me.FormClosing
        If curPart Is Nothing Then Exit Sub
        curPart.Units = comboUnits.Text
        lwParts.Items(curPartPosition).SubItems(2).Text = CStr(curPart.Count) & " " & curPart.Units
    End Sub

    Private Sub comboUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboUnits.SelectedIndexChanged
        If curPart Is Nothing Then Exit Sub
        comboUnits.Text = comboUnits.SelectedItem
        curPart.Units = comboUnits.Text
        lwParts.Items(curPartPosition).SubItems(2).Text = CStr(curPart.Count) & " " & curPart.Units
    End Sub

    Dim Silently As Boolean = False
    Private Sub nudDiscountPc_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscountPc.ValueChanged
        If Silently Then Exit Sub
        Dim dblDiscount As Double = MyOrder.GetRawPrice * nudDiscountPc.Value / 100
        nudDiscount.Value = dblDiscount
    End Sub

    Private Sub nudDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscount.ValueChanged
        MyOrder.Discount = nudDiscount.Value
        Dim newValue = Math.Round(nudDiscount.Value * 100 / MyOrder.GetRawPrice)
        If newValue >= nudDiscountPc.Minimum And newValue <= nudDiscountPc.Maximum Then
            Silently = True
            nudDiscountPc.Value = newValue
            Silently = False
        End If
        FillTotal()
    End Sub

    Private Sub btnDeletePart_Click(sender As Object, e As EventArgs) Handles btnDeletePart.Click
        If curPart Is Nothing Then Exit Sub
        MyOrder.PartList.Remove(MyOrder.PartList.Item(lwParts.SelectedItems.Item(0).Index))
        lwParts.Items.RemoveAt(lwParts.SelectedIndices(0))
        curPart = Nothing
        CheckParts()
        FillTotal()
        RecountParts()
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
        If Form1.WriteRight <> Form1.WriteRights.Bookkeeper Then Exit Sub
        nudDiscount.Enabled = True
        nudDiscountPc.Enabled = True
    End Sub

    Private Sub txtSellPrice_TextChanged(sender As Object, e As EventArgs) Handles txtSellPrice.TextChanged, txtRawPrice.TextChanged
        If curPart Is Nothing Then Exit Sub
        lwParts.Items(curPartPosition).SubItems(3).Text = txtSellPrice.Text
    End Sub

    Private Sub boxCompleted_CheckedChanged(sender As Object, e As EventArgs) Handles boxCompleted.CheckedChanged
        MyOrder.Completed = boxCompleted.Checked

        Dim BkOrMaster As Boolean = (Not MyOrder.Completed) And (Form1.WriteRight = Form1.WriteRights.Bookkeeper Or Form1.WriteRight = Form1.WriteRights.Master)
        Dim BkOrTheGirl As Boolean = (Not MyOrder.Completed) And (Form1.WriteRight = Form1.WriteRights.Bookkeeper Or Form1.WriteRight = Form1.WriteRights.The_Girl)
        Dim Bk As Boolean = (Not MyOrder.Completed) And (Form1.WriteRight = Form1.WriteRights.Bookkeeper)
        comboCustomer.Enabled = BkOrMaster
        comboExecutor.Enabled = BkOrMaster
        dtpDelivery.Enabled = BkOrMaster
        nudAdvance.Enabled = Bk
        dtpAdvance.Enabled = Bk
        nudPayment.Enabled = Bk
        dtpPayment.Enabled = Bk
        btnDeletePart.Enabled = BkOrMaster
        btnNewPart.Enabled = BkOrMaster
        nudDiscount.Enabled = BkOrMaster
        nudDiscountPc.Enabled = BkOrMaster
        txtComment.Enabled = BkOrMaster
    End Sub

    Private Sub ПечатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПечатьToolStripMenuItem.Click
        frmPrintOrder.Show(MyOrder)
    End Sub

    Private Sub УдалитьЗаказToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьЗаказToolStripMenuItem.Click
        If Form1.WriteRight <> Form1.WriteRights.Bookkeeper Then
            MsgBox("У вас недостаточно прав чтобы сделать это.", MsgBoxStyle.Critical, "Извините")
            Exit Sub
        End If
        If MsgBox("Вы действительно хотите удалить этот заказ?", MsgBoxStyle.YesNo, "Внимание!") = MsgBoxResult.Yes Then
            For Each Part In MyOrder.PartList
                Form1.RemovePaymentsByPID(Part.ID)
                Part.Order = Nothing
                Part.Provider = Nothing
            Next
            MyOrder.PartList = Nothing
            HCOrder.OrderList.Remove(MyOrder)
            MyOrder.Customer.MyOrderList.Remove(MyOrder)
            Me.Close()
        End If
    End Sub

    Private Sub nudPayment_ValueChanged(sender As Object, e As EventArgs) Handles nudPayment.ValueChanged
        MyOrder.PaymentSum = nudPayment.Value
        FillTotalReceived()
    End Sub

    Private Sub nudAdvance_ValueChanged(sender As Object, e As EventArgs) Handles nudAdvance.ValueChanged
        MyOrder.AdvanceSum = nudAdvance.Value
        FillTotalReceived()
    End Sub

    Private Sub comboProvider_KeyDown(sender As Object, e As KeyEventArgs) Handles comboProvider.KeyDown
        If curPart Is Nothing Then Exit Sub
        Dim newProv As HCProvider = HCProvider.GetByID(comboProvider.SelectedItem.Value)
        If newProv Is curPart.Provider Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If Not curPart.Provider Is Nothing Then curPart.Provider.PartList.Remove(curPart)
            curPart.Provider = newProv
            If Not curPart.Provider Is Nothing Then curPart.Provider.PartList.Add(curPart)
            Form1.UpdateProviderForPID(curPart.ID, curPart.Provider)
        End If
    End Sub

    Private Sub comboProvider_Leave(sender As Object, e As EventArgs) Handles comboProvider.Leave
        If curPart Is Nothing Then Exit Sub
        Dim newProv As HCProvider = HCProvider.GetByID(comboProvider.SelectedItem.Value)
        If newProv Is curPart.Provider Then Exit Sub
        If Not curPart.Provider Is Nothing Then curPart.Provider.PartList.Remove(curPart)
        curPart.Provider = newProv
        If Not curPart.Provider Is Nothing Then curPart.Provider.PartList.Add(curPart)
        Form1.UpdateProviderForPID(curPart.ID, curPart.Provider)
    End Sub

    Private Sub comboProvider_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProvider.SelectedIndexChanged
        If curPart Is Nothing Then Exit Sub
        Dim newProv As HCProvider = HCProvider.GetByID(comboProvider.SelectedItem.Value)
        If newProv Is curPart.Provider Then Exit Sub
        If Not curPart.Provider Is Nothing Then curPart.Provider.PartList.Remove(curPart)
        curPart.Provider = newProv
        If Not curPart.Provider Is Nothing Then curPart.Provider.PartList.Add(curPart)
        Form1.UpdateProviderForPID(curPart.ID, curPart.Provider)
    End Sub
End Class
