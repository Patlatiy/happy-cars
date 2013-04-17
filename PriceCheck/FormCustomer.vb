Public Class FormCustomer
    Dim MyCustomer As HCCustomer
    Dim MyOwner As Windows.Forms.Form

    Overloads Sub Show(Customer As HCCustomer, ByRef Owner As Windows.Forms.Form)
        Me.Show(Owner)
        MyCustomer = Customer
        MyOwner = Owner
        MyOwner.Enabled = False
        FillForm()
    End Sub

    Sub FillForm()
        If MyCustomer Is Nothing Then Exit Sub
        txt1stName.Text = MyCustomer.FirstName
        txtLastName.Text = MyCustomer.LastName
        txtPatron.Text = MyCustomer.Patron
        txtPhone.Text = MyCustomer.Phone
        Me.Text = MyCustomer.FullName
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

    Sub CreateCustomer()
        Dim newCustomer As HCCustomer = New HCCustomer()
        MyCustomer = newCustomer
    End Sub

    Dim Silently As Boolean = False
    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        Silently = True
        txtLastName.Text = txtLastName.Text.Trim()
        Silently = False
        MyCustomer.LastName = txtLastName.Text
        Me.Text = MyCustomer.GetShortName
    End Sub

    Private Sub txt1stName_TextChanged(sender As Object, e As EventArgs) Handles txt1stName.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        Silently = True
        txt1stName.Text = txt1stName.Text.Trim()
        Silently = False
        MyCustomer.FirstName = txt1stName.Text
        Me.Text = MyCustomer.GetShortName
    End Sub

    Private Sub txtPatron_TextChanged(sender As Object, e As EventArgs) Handles txtPatron.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        Silently = True
        txtPatron.Text = txtPatron.Text.Trim()
        Silently = False
        MyCustomer.Patron = txtPatron.Text
        Me.Text = MyCustomer.GetShortName
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        Silently = True
        txtPatron.Text = txtPatron.Text.Trim()
        Silently = False
        MyCustomer.Phone = txtPhone.Text
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        Silently = True
        txtAddress.Text = txtAddress.Text.Trim()
        Silently = False
        MyCustomer.Address = txtAddress.Text
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        Dim flag_empty As Boolean = False
        If MyCustomer Is Nothing Then
            flag_empty = True
        ElseIf MyCustomer.IsEmpty Then
            flag_empty = True
        End If
        If flag_empty Then
            MsgBox("Нельзя создавать заказы для пустого клиента", MsgBoxStyle.Critical, "Извините")
            Exit Sub
        End If
        Select Case Form1.WriteRight
            Case Form1.WriteRights.Bookkeeper
                Dim testPartList = New List(Of HCPart)
                Dim testOrder = New HCOrder(MyCustomer, Form1.curDate, 0, Form1.curDate, 0, Form1.curDate, 0, testPartList, False)
                dgvCustomerOrders.Rows.Add(testOrder.Number.GetFullNumber, CStr(testOrder.GetTotalPrice), testOrder.Completed, "Открыть...")
                dgvCustomerOrders.FirstDisplayedScrollingRowIndex = dgvCustomerOrders.Rows.Count - 1
                frmOrder.Show(testOrder, Me)
            Case Form1.WriteRights.Master
                If MyCustomer.IsIncomplete Then
                    MsgBox("Пожалуйста, заполните все поля", MsgBoxStyle.Critical, "Внимание")
                Else
                    frmNewOrder.Show(MyCustomer, Me)
                End If

        End Select
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If Form1.WriteRight <> Form1.WriteRights.Bookkeeper Or MyCustomer Is Nothing Then Exit Sub
        Dim Message As String
        If MyCustomer.IsEmpty Then
            GoTo Deletion
        ElseIf MyCustomer.MyOrderList.Count = 0 Then
            Message = "Вы действительно хотите удалить клиента " & MyCustomer.FullName & "?"
        Else
            Message = "Вы действительно хотите удалить клиента " & MyCustomer.FullName & " и все его заказы (" & CStr(MyCustomer.MyOrderList.Count) & " шт.)?"
        End If
        If MsgBox(Message, MsgBoxStyle.YesNo, "Внимание!") = MsgBoxResult.Yes Then
            For Each Order In MyCustomer.MyOrderList
                HCOrder.OrderList.Remove(Order)
            Next
Deletion:
            HCCustomer.CustomerList.Remove(MyCustomer)
            Me.Close()
        End If
    End Sub

    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Form1.WriteRight
            Case Form1.WriteRights.Master
                btnDeleteCustomer.Hide()
            Case Form1.WriteRights.The_Girl
                btnDeleteCustomer.Hide()
                btnNewOrder.Hide()
        End Select
    End Sub
End Class