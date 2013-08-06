Public Class StateForm
    Dim EDIT_MODE As Boolean = True

    Private Sub StateForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.SaveAll()
    End Sub

    Private Sub StateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EDIT_MODE = False
        StateList.Groups.Add(New ListViewGroup("Group_Wash", "Мойка"))
        StateList.Groups.Add(New ListViewGroup("Group_Mount", "Шиномонтаж"))
        StateList.Groups.Add(New ListViewGroup("Group_Service", "Сервис"))
        StateList.ShowGroups = True
        For Each wrkr In Worker.AllOfThem
            StateList.Items.Add(wrkr.FullName)
            StateList.Items.Item(StateList.Items.Count - 1).Group = StateList.Groups(wrkr.GetWorkshopInt)
            StateList.Items.Item(StateList.Items.Count - 1).Tag = wrkr.GetID
        Next
        EDIT_MODE = True
    End Sub

    Private Sub StateList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StateList.SelectedIndexChanged
        EDIT_MODE = False
        For Each SI In StateList.SelectedItems
            Dim w As Worker = Worker.FindByID(SI.Tag)
            txtName.Text = w.GetName
            txt2Name.Text = w.Get2Name
            txtPatron.Text = w.GetPatron
            txtJob.Text = w.GetJob
            ComboWorkshop.SelectedIndex = w.GetWorkshopInt
            nudSalary.Value = w.GetSalary
            nudNorm.Value = w.GetNorm
            nudHour.Value = w.GetHourCost
            FixedSalaryBox.CheckState = CheckState.Unchecked
            FixedSalaryBox.Checked = w.wFixedSalary
            nudAdvance.Value = w.wAdvance
            nudBonus.Value = w.wBonus
            nudOP.Value = w.wOtherPayments
            nudOC.Value = w.wOtherCharges
        Next
        EDIT_MODE = True
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If EDIT_MODE Then
            For Each SI In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(SI.tag)
                w.SetName(txtName.Text)
                SI.Text = w.FullName
            Next
        End If
    End Sub

    Private Sub txt2Name_TextChanged(sender As Object, e As EventArgs) Handles txt2Name.TextChanged
        If EDIT_MODE Then
            For Each SI In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(SI.tag)
                w.Set2Name(txt2Name.Text)
                SI.Text = w.FullName
                'Form1.dTable.Item(1, Form1.FindRowByID(SI.tag)).Value = SI.text
            Next
        End If
    End Sub

    Private Sub txtPatron_TextChanged(sender As Object, e As EventArgs) Handles txtPatron.TextChanged
        If EDIT_MODE Then
            For Each SI In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(SI.tag)
                w.SetPatron(txtPatron.Text)
                SI.Text = w.FullName
                'Form1.dTable.Item(1, Form1.FindRowByID(SI.tag)).Value = SI.text
            Next
        End If
    End Sub

    Private Sub txtJob_TextChanged(sender As Object, e As EventArgs) Handles txtJob.TextChanged
        If EDIT_MODE Then
            For Each SI In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(SI.tag)
                w.SetJob(txtJob.Text)
                'Form1.dTable.Item(2, Form1.FindRowByID(SI.tag)).Value = txtJob.Text
            Next
        End If
    End Sub

    Private Sub ComboWorkshop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboWorkshop.SelectedIndexChanged
        If EDIT_MODE Then
            For Each SI In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(SI.tag)
                w.SetWorkshop(ComboWorkshop.SelectedIndex)
                SI.Group = StateList.Groups(w.GetWorkshopInt)
                'If Form1.ComboWorkshops.SelectedIndex = ComboWorkshop.SelectedIndex Then
                '    Form1.dTable.Rows(Form1.FindRowByID(SI.tag)).Visible = True
                'Else
                '    Form1.dTable.Rows(Form1.FindRowByID(SI.tag)).Visible = False
                'End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim w As New Worker("Имя", "Фамилия", "Отчество", 0, "Должность", 0, 11, False)
        StateList.Items.Add(w.FullName)
        StateList.Items.Item(StateList.Items.Count - 1).Group = StateList.Groups(w.GetWorkshopInt)
        StateList.Items.Item(StateList.Items.Count - 1).Tag = w.GetID
        'Form1.dTable.Rows.Add(CStr(w.GetID), w.FullName)
        'If Form1.ComboWorkshops.SelectedIndex <> 0 Then Form1.dTable.Rows(Form1.dTable.RowCount - 1).Visible = False
        'For Each cell In Form1.dTable.Rows(Form1.dTable.RowCount - 1).Cells
        '    cell.style.backcolor = Form1.DefaultBackColor
        '    cell.style.forecolor = Form1.DefaultForeColor
        'Next
        StateList.Items.Item(StateList.Items.Count - 1).Selected = True
    End Sub

    Private Sub nudSalary_ValueChanged(sender As Object, e As EventArgs) Handles nudSalary.ValueChanged
        If EDIT_MODE Then
            For Each SI In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(SI.tag)
                w.SetSalary(nudSalary.Value)
                EDIT_MODE = False
                w.CalculateHourCost()
                nudHour.Value = w.GetHourCost
                EDIT_MODE = True
            Next
        End If
    End Sub

    Private Sub nudHour_ValueChanged(sender As Object, e As EventArgs) Handles nudHour.ValueChanged
        If EDIT_MODE Then
            For Each SI In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(SI.tag)
                w.SetHourCost(nudHour.Value)
            Next
        End If
    End Sub

    Private Sub FixedSalaryBox_CheckedChanged(sender As Object, e As EventArgs) Handles FixedSalaryBox.CheckedChanged
        If EDIT_MODE Then
            For Each si In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(si.tag)
                w.wFixedSalary = FixedSalaryBox.Checked
            Next
        End If
    End Sub

    Private Sub nudAdvance_ValueChanged(sender As Object, e As EventArgs) Handles nudAdvance.ValueChanged
        If EDIT_MODE Then
            For Each si In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(si.tag)
                w.wAdvance = sender.value
            Next
        End If
    End Sub

    Private Sub nudBonus_ValueChanged(sender As Object, e As EventArgs) Handles nudBonus.ValueChanged
        If EDIT_MODE Then
            For Each si In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(si.tag)
                w.wBonus = sender.value
            Next
        End If
    End Sub

    Private Sub nudOC_ValueChanged(sender As Object, e As EventArgs) Handles nudOC.ValueChanged
        If EDIT_MODE Then
            For Each si In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(si.tag)
                w.wOtherCharges = sender.value
            Next
        End If
    End Sub

    Private Sub nudOP_ValueChanged(sender As Object, e As EventArgs) Handles nudOP.ValueChanged
        If EDIT_MODE Then
            For Each si In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(si.tag)
                w.wOtherPayments = sender.value
            Next
        End If
    End Sub

    Private Sub nudNorm_ValueChanged(sender As Object, e As EventArgs) Handles nudNorm.ValueChanged
        If EDIT_MODE Then
            For Each SI In StateList.SelectedItems
                Dim w As Worker = Worker.FindByID(SI.tag)
                EDIT_MODE = False
                w.SetNorm(nudNorm.Value)
                w.CalculateHourCost()
                nudHour.Value = w.GetHourCost
                EDIT_MODE = True
            Next
        End If
    End Sub

    Private Sub SaveState()
        Form1.SaveState()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each SI In StateList.SelectedItems

            Worker.FindByID(SI.tag).Dispose()
            StateList.Items.Remove(SI)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveState()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveState()
    End Sub
End Class
