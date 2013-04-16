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
    End Sub

    Private Sub btnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click
        frmNewPart.Show(Me)
    End Sub

    Private Sub frmNewOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MyOwner.Enabled = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Public Sub AddPart(pName As String, pCount As UInteger, pPrice As Double, pMargin As Double)
        Dim newPart As HCPart = New HCPart(pName, pCount, pPrice, pMargin)
        MyPartList.Add(newPart)
        Dim newArr() As String = {CStr(lwParts.Items.Count + 1), pName, CStr(pCount), CStr(Math.Round(pPrice, 2))}
        Dim newItem As New ListViewItem(newArr)
        lwParts.Items.Add(newItem)
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

    Public Sub UpdatePart(pName As String, pCount As UInteger, pPrice As Double, pMargin As Double)
        CurPart.Name = pName
        CurPart.Count = pCount
        CurPart.Price = pPrice
        CurPart.Margin = pMargin
        Dim newArr() As String = {CStr(CurPartPosition), pName, CStr(pCount), CStr(Math.Round(pPrice, 2))}
        Dim newItem As New ListViewItem(newArr)
        lwParts.Items(lwParts.SelectedIndices(0)) = newItem
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
            If Not Selected Is Nothing And Selected.ID = newItem.Value Then
                comboExecutor.SelectedItem = newItem
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
End Class