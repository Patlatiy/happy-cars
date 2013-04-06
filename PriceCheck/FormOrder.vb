Public Class frmOrder
    Dim MyOrder As HCOrder

    Overloads Sub Show(ByRef Order As HCOrder)
        Me.Show()
        MyOrder = Order
        Me.Text = Me.Text & MyOrder.Number.GetFullNumber

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
End Class