Public Class frmNewOrder
    Private MyOwner As Windows.Forms.Form
    Private MyCustomer As HCCustomer
    Private MyExecutor As HCExecutor
    Private MyPartList As New List(Of HCPart)
    Private CurPartPosition As UInteger
    Private CurPart As HCPart

    Overloads Sub Show(ByRef Customer As HCCustomer, ByRef Owner As Windows.Forms.Form)
        Me.Show()
        MyOwner = Owner
        MyOwner.Enabled = False
        MyCustomer = Customer
        RefreshCustomers(MyCustomer)
        RefreshExecutors()
        dtpDelivery.Value = Date.Now
    End Sub

    Private Sub btnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click
        frmNewPart.Show(Me)
    End Sub

    Private Sub frmNewOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MyOwner.Enabled = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If MyCustomer Is Nothing Then
            MsgBox("Пожалуйста, выберите заказчика.", MsgBoxStyle.Critical, "Внимание!")
            Exit Sub
        ElseIf MyExecutor Is Nothing Then
            MsgBox("Пожалуйста, выберите исполнителя.", MsgBoxStyle.Critical, "Внимание!")
            Exit Sub
        ElseIf MyPartList.Count = 0 Then
            MsgBox("Пожалуйста, добавьте к заказу хотя бы одну запчасть.", MsgBoxStyle.Critical, "Внимание!")
            Exit Sub
        End If
        Dim newOrder = New HCOrder(MyCustomer, MyExecutor, dtpDelivery.Value, 0, Date.Now, 0, Date.Now, nudDiscount.Value, MyPartList, False)
        If MyOwner Is FormCustomer Then
            FormCustomer.RefreshOrders()
        ElseIf MyOwner Is Form1 Then
            Form1.RefreshOrders()
        End If
        Close()
    End Sub

    Public Sub AddPart(pName As String, pCount As UInteger, pUnits As String, pPrice As Double, pMargin As Double)
        Dim newPart As HCPart = New HCPart(pName, pCount, pUnits, pPrice, pMargin)
        MyPartList.Add(newPart)
        Dim newArr() As String = {CStr(lwParts.Items.Count + 1), pName, CStr(pCount) & " " & pUnits, CStr(newPart.GetSellPrice)}
        Dim newItem As New ListViewItem(newArr)
        lwParts.Items.Add(newItem)
        FillTotal()
    End Sub

    Public Sub UpdatePart(pName As String, pCount As UInteger, pPrice As Double, pMargin As Double)
        CurPart.Name = pName
        CurPart.Count = pCount
        CurPart.Price = pPrice
        CurPart.Margin = pMargin
        Dim newArr() As String = {CStr(CurPartPosition), pName, CStr(pCount), CStr(CurPart.GetSellPrice)}
        Dim newItem As New ListViewItem(newArr)
        lwParts.Items(lwParts.SelectedIndices(0)) = newItem
        FillTotal()
    End Sub

    Private Sub lwParts_ItemActivate(sender As Object, e As EventArgs) Handles lwParts.ItemActivate
        If CurPart Is Nothing Then Exit Sub
        frmNewPart.Show(Me, CurPart)
    End Sub

    Private Sub lwParts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lwParts.SelectedIndexChanged
        If lwParts.SelectedItems.Count = 0 Then
            CurPartPosition = Nothing
            CurPart = Nothing
        Else
            CurPartPosition = lwParts.SelectedIndices(0)
            CurPart = MyPartList.Item(lwParts.SelectedIndices(0))
        End If
    End Sub

    Private Sub btnShowExecutor_Click(sender As Object, e As EventArgs) Handles btnShowExecutor.Click
        If comboExecutor.SelectedIndex = -1 Then
            Dim newExecutor As New HCExecutor()
            Dim newItem As New HCListItem(newExecutor.FullName, newExecutor.ID)
            comboExecutor.Items.Add(newItem)
            frmExecutor.Show(newExecutor, Me)
        Else
            frmExecutor.Show(HCExecutor.GetById(comboExecutor.SelectedItem.Value), Me)
        End If
    End Sub

    Public Sub RefreshExecutors(Optional Selected As HCExecutor = Nothing)
        comboExecutor.Items.Clear()
        For Each Exec As HCExecutor In HCExecutor.ExecList
            Dim newItem = New HCListItem(Exec.FullName, Exec.ID)
            comboExecutor.Items.Add(newItem)
            If Not Selected Is Nothing Then
                If Selected.ID = newItem.Value Then
                    comboExecutor.SelectedItem = newItem
                End If
            End If
        Next
        Dim newExecItem = New HCListItem("(Новый исполнитель)", (-1))
        comboExecutor.Items.Add(newExecItem)
    End Sub

    Public Sub RefreshCustomers(Optional Selected As HCCustomer = Nothing)
        comboCustomer.Items.Clear()
        For Each cust As HCCustomer In HCCustomer.CustomerList
            Dim newItem = New HCListItem(cust.FullName, cust.ID)
            comboCustomer.Items.Add(newItem)
            If Selected Is Nothing Then Continue For
            If cust.ID = Selected.ID Then comboCustomer.SelectedItem = newItem
        Next
    End Sub

    Private Sub comboExecutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboExecutor.SelectedIndexChanged
        If comboExecutor.SelectedItem.Value = (-1) Then
            Dim newExec As New HCExecutor()
            frmExecutor.Show(newExec, Me)
        Else
            MyExecutor = HCExecutor.GetById(comboExecutor.SelectedItem.Value)
        End If
    End Sub

    Private Function GetRawPrice() As Double
        Dim TotalOrderPrice As Double = 0
        For Each Part In MyPartList
            TotalOrderPrice += Part.GetSellPrice()
        Next
        TotalOrderPrice = Math.Round(TotalOrderPrice, 2)
        Return TotalOrderPrice
    End Function

    Dim Silently As Boolean = False
    Private Sub nudDiscountPc_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscountPc.ValueChanged
        If Silently Then Exit Sub
        Dim dblDiscount As Double = GetRawPrice() * nudDiscountPc.Value / 100
        nudDiscount.Value = dblDiscount
    End Sub

    Private Sub nudDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscount.ValueChanged
        Dim newValue = Math.Round(nudDiscount.Value * 100 / GetRawPrice())
        If newValue >= nudDiscountPc.Minimum And newValue <= nudDiscountPc.Maximum Then
            Silently = True
            nudDiscountPc.Value = newValue
            Silently = False
        End If
        FillTotal()
    End Sub

    Private Sub FillTotal()
        txtTotal.Text = CStr(Math.Round(GetRawPrice() - nudDiscount.Value, 2))
    End Sub

    Private Sub comboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCustomer.SelectedIndexChanged
        MyCustomer = HCCustomer.FindByID(comboCustomer.SelectedItem.Value)
    End Sub
End Class