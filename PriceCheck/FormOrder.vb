Public Class frmOrder
    Dim MyOrder As HCOrder
    Dim txtAdvanceLastValue As String
    Dim txtPaymentLastValue As String

    Overloads Sub Show(ByRef Order As HCOrder)
        Me.Show()
        MyOrder = Order
        Me.Text = "Заказ № " & MyOrder.Number.GetFullNumber

        lwParts.Items.Clear()
        For Each Part As HCOrder.HCPart In MyOrder.Parts
            Dim newArr(1) As String
            newArr(0) = Part.Name
            newArr(1) = CStr(Part.Count)
            Dim newItem As New ListViewItem(newArr)
            lwParts.Items.Add(newItem)
        Next

        comboCustomers.Items.Clear()
        For Each Customer As HCCustomer In HCCustomer.CustomerList
            Dim newItem = New HCListItem(Customer.GetFullName, Customer.ID)
            comboCustomers.Items.Add(newItem)
            If Customer.ID = MyOrder.Customer.ID Then comboCustomers.SelectedItem = newItem
        Next

        dtpDelivery.Value = Order.DeliveryDate
        txtAdvance.Text = CStr(MyOrder.AdvanceSum)
        dtpAdvance.Value = MyOrder.AdvanceDate
        txtPayment.Text = CStr(MyOrder.PaymentSum)
        dtpPayment.Value = MyOrder.PaymentDate
    End Sub

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub comboCustomers_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboCustomers.SelectedValueChanged
        Dim newCustomer As HCCustomer = HCCustomer.FindByID(comboCustomers.Items(comboCustomers.SelectedIndex).value)
        If newCustomer.ID = MyOrder.Customer.ID Then Exit Sub
        If newCustomer Is Nothing Then
            MsgBox("Что-то пошло не так", MsgBoxStyle.Critical)
        Else
            MyOrder.Customer = newCustomer
            Form1.RefreshCustomersAndOrders()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub dtpDelivery_ValueChanged(sender As Object, e As EventArgs) Handles dtpDelivery.ValueChanged
        If MyOrder.DeliveryDate <> dtpDelivery.Value Then MyOrder.DeliveryDate = dtpDelivery.Value
    End Sub

    Private Sub txtAdvance_TextChanged(sender As Object, e As EventArgs) Handles txtAdvance.TextChanged
        If txtAdvance.Text = txtAdvanceLastValue Then Exit Sub
        Try
            MyOrder.AdvanceSum = CULng(txtAdvance.Text)
            txtAdvanceLastValue = txtAdvance.Text
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
End Class