Public Class FormCustomer
    Dim MyCustomer As HCCustomer
    Dim MyParent As Object

    Overloads Sub Show(Customer As HCCustomer, ByRef Parent As Object)
        Me.Show()
        MyCustomer = Customer
        MyParent = Parent
        MyParent.Enabled = False
        FillForm()
    End Sub

    Sub FillForm()
        txt1stName.Text = MyCustomer.FirstName
        txtLastName.Text = MyCustomer.LastName
        txtPatron.Text = MyCustomer.Patron
        txtPhone.Text = MyCustomer.Phone
        RefreshOrders()
    End Sub

    Sub AddOrder(Order As HCOrder)
        dgvCustomerOrders.Rows.Add(Order.Number.GetFullNumber, Order.GetTotalPrice, Order.Completed, "Открыть...")
    End Sub

    Public Sub RefreshOrders()
        dgvCustomerOrders.Rows.Clear()
        For Each Order As HCOrder In MyCustomer.MyOrderList
            AddOrder(Order)
        Next
    End Sub

    Private Sub FormCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MyParent Is Form1 Then Form1.RefreshCustomersAndOrders()
        MyParent.Enabled = True
    End Sub

    Private Sub dgvCustomerOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerOrders.CellContentClick
        If e.ColumnIndex = 3 Then
            Me.Enabled = False
            Form1.NumberToFind = dgvCustomerOrders.Item(0, e.RowIndex).Value
            frmOrder.Show(MyCustomer.MyOrderList.Find(AddressOf Form1.FindOrderByNumber), Me)
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If MyCustomer Is Nothing Then Exit Sub
        MyCustomer.LastName = txtLastName.Text
    End Sub

    Private Sub txt1stName_TextChanged(sender As Object, e As EventArgs) Handles txt1stName.TextChanged
        If MyCustomer Is Nothing Then Exit Sub
        MyCustomer.FirstName = txt1stName.Text
    End Sub

    Private Sub txtPatron_TextChanged(sender As Object, e As EventArgs) Handles txtPatron.TextChanged
        If MyCustomer Is Nothing Then Exit Sub
        MyCustomer.Patron = txtPatron.Text
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        If MyCustomer Is Nothing Then Exit Sub
        MyCustomer.Phone = txtPhone.Text
    End Sub
End Class