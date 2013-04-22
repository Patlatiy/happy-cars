Public Class frmNewPart
    Private Silently As Boolean
    Private MyOwner As Windows.Forms.Form
    Private CreateNew As Boolean

    Overloads Sub Show(ByRef owner As Windows.Forms.Form, Optional Part As HCPart = Nothing)
        Me.Show()
        owner.Enabled = False
        MyOwner = owner
        CreateNew = Part Is Nothing
        comboUnits.Items.Clear()
        For Each Unit In HCPart.UnitsList
            comboUnits.Items.Add(Unit)
        Next
        For Each prov In HCProvider.ProviderList
            Dim newItem As New HCListItem(prov.Name, prov.ID)
            comboProvider.Items.Add(newItem)
        Next

        If Not Part Is Nothing Then
            txtPartName.Text = Part.Name
            nudPartCount.Value = Part.Count
            nudPartPrice.Value = Part.Price
            nudMargin.Value = Part.Margin
            comboUnits.Text = Part.Units
            If Not Part.Provider Is Nothing Then comboProvider.Text = Part.Provider.Name
            FillPrice()
        End If
    End Sub

    Private Sub FillPrice()
        txtRawPrice.Text = ToMoney(nudPartPrice.Value * nudPartCount.Value)
        Silently = True
        nudSellPrice.Value = (nudPartPrice.Value * nudPartCount.Value) + nudMargin.Value
        Silently = False
        txtSellPrice.Text = ToMoney(nudSellPrice.Value)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If MyOwner Is frmNewOrder Then
            If CreateNew Then
                frmNewOrder.AddPart(txtPartName.Text, CInt(nudPartCount.Value), comboUnits.Text, nudPartPrice.Value, nudMargin.Value, HCProvider.GetByName(comboProvider.Text))
            Else
                frmNewOrder.UpdatePart(txtPartName.Text, CInt(nudPartCount.Value), nudPartPrice.Value, nudMargin.Value, HCProvider.GetByName(comboProvider.Text))
            End If
        End If
        Close()
    End Sub

    Private Sub nudPartCount_ValueChanged(sender As Object, e As EventArgs) Handles nudPartCount.ValueChanged, nudMargin.ValueChanged, nudPartPrice.ValueChanged
        FillPrice()
    End Sub

    Private Sub nudSellPrice_ValueChanged(sender As Object, e As EventArgs) Handles nudSellPrice.ValueChanged
        If Silently Then Exit Sub
        Dim dblMargin As Double = Math.Round(nudSellPrice.Value - nudPartPrice.Value * nudPartCount.Value, 2)
        nudMargin.Value = dblMargin
    End Sub

    Private Sub nudMarginPc_ValueChanged(sender As Object, e As EventArgs) Handles nudMarginPc.ValueChanged
        If Silently Then Exit Sub
        Dim dblMargin As Double = Math.Round(nudPartPrice.Value * nudPartCount.Value * nudMarginPc.Value / 100, 2)
        nudMargin.Value = dblMargin
    End Sub

    Private Sub nudMargin_ValueChanged(sender As Object, e As EventArgs) Handles nudMargin.ValueChanged
        If nudPartPrice.Value <= 0 Then Exit Sub
        Dim dblmargin As Double = Math.Round((nudMargin.Value * 100) / (nudPartPrice.Value * nudPartCount.Value))
        Silently = True
        nudMarginPc.Value = dblmargin
        nudSellPrice.Value = nudPartPrice.Value * nudPartCount.Value + nudMargin.Value
        Silently = False
    End Sub

    Private Sub frmNewPart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MyOwner.Enabled = True
    End Sub

End Class
