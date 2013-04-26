Public Class frmCustomer
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
        Silently = True
        txt1stName.Text = MyCustomer.FirstName
        txtLastName.Text = MyCustomer.LastName
        txtPatron.Text = MyCustomer.Patron
        txtPhoneCode.Text = MyCustomer._Code
        txtPhone.Text = MyCustomer._Phone
        txtAddress.Text = MyCustomer.Address
        Me.Text = MyCustomer.FullName
        RefreshOrders()
        Silently = False
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
        If MyCustomer Is Nothing Then Exit Sub
        If MyCustomer.IsEmpty Then
            HCCustomer.CustomerList.Remove(MyCustomer)
        End If
        If MyOwner Is Form1 Then Form1.RefreshCustomersAndOrders()
        MyOwner.Enabled = True
        Form1.SaveCustomers()
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
        MyCustomer.LastName = txtLastName.Text.Trim
        Me.Text = MyCustomer.GetShortName
    End Sub

    Private Sub txt1stName_TextChanged(sender As Object, e As EventArgs) Handles txt1stName.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        MyCustomer.FirstName = txt1stName.Text.Trim
        Me.Text = MyCustomer.GetShortName
    End Sub

    Private Sub txtPatron_TextChanged(sender As Object, e As EventArgs) Handles txtPatron.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        MyCustomer.Patron = txtPatron.Text.Trim
        Me.Text = MyCustomer.GetShortName
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        MyCustomer.Phone = "+7 (" & txtPhoneCode.Text.Trim & ") " & txtPhone.Text.Trim
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        If Silently Then Exit Sub
        If MyCustomer Is Nothing Then CreateCustomer()
        MyCustomer.Address = txtAddress.Text.Trim
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
            Case Form1.WriteRights.Master, Form1.WriteRights.Bookkeeper
                frmNewOrder.Show(MyCustomer, Me)
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
                Order.Kill()
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

    Private Sub txtPhoneCode_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneCode.TextChanged
        If Silently Or txtPhoneCode.Text = "" Then Exit Sub
        If txtPhoneCode.Text(0) = "9" And txtPhoneCode.Text.Length = 3 Then
            txtPhone.Focus()
        ElseIf txtPhoneCode.Text = "4852" Then
            txtPhone.Focus()
        ElseIf txtPhoneCode.Text.Length = 4 Then
            txtPhone.Focus()
        End If
        If MyCustomer Is Nothing Then CreateCustomer()
        MyCustomer.Phone = "+7 (" & txtPhoneCode.Text.Trim & ") " & txtPhone.Text.Trim
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
