Public Class FormCustomer
    Dim MyCustomer As HCCustomer
    Dim MyOwner As Object

    Overloads Sub Show(Customer As HCCustomer, ByRef Owner As Object)
        Me.Show(Owner)
        MyCustomer = Customer
        MyOwner = Owner
        MyOwner.Enabled = False
        FillForm()
    End Sub

    Sub FillForm()
        txt1stName.Text = MyCustomer.FirstName
        txtLastName.Text = MyCustomer.LastName
        txtPatron.Text = MyCustomer.Patron
        txtPhone.Text = MyCustomer.Phone
        Me.Text = MyCustomer.GetFullName
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
        If MyCustomer.IsEmpty Then
            HCCustomer.CustomerList.Remove(MyCustomer)
        End If
        If MyOwner Is Form1 Then Form1.RefreshCustomersAndOrders()
        MyOwner.Enabled = True
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
        Me.Text = MyCustomer.GetFullName
    End Sub

    Private Sub txt1stName_TextChanged(sender As Object, e As EventArgs) Handles txt1stName.TextChanged
        If MyCustomer Is Nothing Then Exit Sub
        MyCustomer.FirstName = txt1stName.Text
        Me.Text = MyCustomer.GetFullName
    End Sub

    Private Sub txtPatron_TextChanged(sender As Object, e As EventArgs) Handles txtPatron.TextChanged
        If MyCustomer Is Nothing Then Exit Sub
        MyCustomer.Patron = txtPatron.Text
        Me.Text = MyCustomer.GetFullName
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        If MyCustomer Is Nothing Then Exit Sub
        MyCustomer.Phone = txtPhone.Text
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        Dim testPartList = New List(Of HCPart)
        Dim testOrder = New HCOrder(MyCustomer, Form1.curDate, 0, Form1.curDate, 0, Form1.curDate, 0, testPartList, False)
        dgvCustomerOrders.Rows.Add(testOrder.Number.GetFullNumber, CStr(testOrder.GetTotalPrice), testOrder.Completed, "Открыть...")
        dgvCustomerOrders.FirstDisplayedScrollingRowIndex = dgvCustomerOrders.Rows.Count - 1
        frmOrder.Show(testOrder, Me)
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        Dim Message As String
        If MyCustomer.IsEmpty Then
            GoTo Deletion
        ElseIf MyCustomer.MyOrderList.Count = 0 Then
            Message = "Вы действительно хотите удалить клиента " & MyCustomer.GetFullName & "?"
        Else
            Message = "Вы действительно хотите удалить клиента " & MyCustomer.GetFullName & " и все его заказы (" & CStr(MyCustomer.MyOrderList.Count) & " шт.)?"
        End If
        If MsgBox(Message, MsgBoxStyle.YesNo, "Внимание!") = MsgBoxResult.Yes Then
Deletion:
            For Each Order In MyCustomer.MyOrderList
                HCOrder.OrderList.Remove(Order)
            Next
            HCCustomer.CustomerList.Remove(MyCustomer)
            Me.Close()
        End If
    End Sub
End Class