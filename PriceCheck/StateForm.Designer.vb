<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StateForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StateForm))
        Me.StateList = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txt2Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPatron = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJob = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboWorkshop = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudSalary = New System.Windows.Forms.NumericUpDown()
        Me.nudNorm = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudHour = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FixedSalaryBox = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudAdvance = New System.Windows.Forms.NumericUpDown()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.nudBonus = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudOP = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudOC = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.nudSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNorm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StateList
        '
        Me.StateList.Location = New System.Drawing.Point(12, 12)
        Me.StateList.MultiSelect = False
        Me.StateList.Name = "StateList"
        Me.StateList.Size = New System.Drawing.Size(195, 307)
        Me.StateList.TabIndex = 0
        Me.StateList.UseCompatibleStateImageBehavior = False
        Me.StateList.View = System.Windows.Forms.View.Tile
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Имя"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(283, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(198, 20)
        Me.txtName.TabIndex = 2
        '
        'txt2Name
        '
        Me.txt2Name.Location = New System.Drawing.Point(283, 19)
        Me.txt2Name.Name = "txt2Name"
        Me.txt2Name.Size = New System.Drawing.Size(198, 20)
        Me.txt2Name.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Фамилия"
        '
        'txtPatron
        '
        Me.txtPatron.Location = New System.Drawing.Point(283, 71)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.Size = New System.Drawing.Size(198, 20)
        Me.txtPatron.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Отчество"
        '
        'txtJob
        '
        Me.txtJob.Location = New System.Drawing.Point(283, 97)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Size = New System.Drawing.Size(198, 20)
        Me.txtJob.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Должность"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Цех"
        '
        'ComboWorkshop
        '
        Me.ComboWorkshop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboWorkshop.FormattingEnabled = True
        Me.ComboWorkshop.Items.AddRange(New Object() {"Мойка", "Шиномонтаж", "Сервис"})
        Me.ComboWorkshop.Location = New System.Drawing.Point(283, 123)
        Me.ComboWorkshop.Name = "ComboWorkshop"
        Me.ComboWorkshop.Size = New System.Drawing.Size(198, 21)
        Me.ComboWorkshop.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Добавить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(109, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Удалить"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Оклад"
        Me.Label6.Visible = False
        '
        'nudSalary
        '
        Me.nudSalary.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudSalary.Location = New System.Drawing.Point(283, 150)
        Me.nudSalary.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSalary.Name = "nudSalary"
        Me.nudSalary.Size = New System.Drawing.Size(91, 20)
        Me.nudSalary.TabIndex = 14
        Me.nudSalary.Visible = False
        '
        'nudNorm
        '
        Me.nudNorm.Location = New System.Drawing.Point(283, 176)
        Me.nudNorm.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudNorm.Name = "nudNorm"
        Me.nudNorm.Size = New System.Drawing.Size(34, 20)
        Me.nudNorm.TabIndex = 16
        Me.nudNorm.Value = New Decimal(New Integer() {11, 0, 0, 0})
        Me.nudNorm.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Норма ч/д"
        Me.Label7.Visible = False
        '
        'nudHour
        '
        Me.nudHour.DecimalPlaces = 2
        Me.nudHour.Location = New System.Drawing.Point(417, 176)
        Me.nudHour.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(64, 20)
        Me.nudHour.TabIndex = 17
        Me.nudHour.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "В час"
        Me.Label8.Visible = False
        '
        'FixedSalaryBox
        '
        Me.FixedSalaryBox.AutoSize = True
        Me.FixedSalaryBox.Location = New System.Drawing.Point(383, 151)
        Me.FixedSalaryBox.Name = "FixedSalaryBox"
        Me.FixedSalaryBox.Size = New System.Drawing.Size(91, 17)
        Me.FixedSalaryBox.TabIndex = 19
        Me.FixedSalaryBox.Text = "Фикс. оклад"
        Me.FixedSalaryBox.UseVisualStyleBackColor = True
        Me.FixedSalaryBox.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(222, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Аванс"
        Me.Label9.Visible = False
        '
        'nudAdvance
        '
        Me.nudAdvance.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAdvance.Location = New System.Drawing.Point(258, 226)
        Me.nudAdvance.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudAdvance.Name = "nudAdvance"
        Me.nudAdvance.Size = New System.Drawing.Size(61, 20)
        Me.nudAdvance.TabIndex = 21
        Me.nudAdvance.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(493, 352)
        Me.ShapeContainer1.TabIndex = 22
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.Visible = False
        Me.LineShape1.X1 = 217
        Me.LineShape1.X2 = 484
        Me.LineShape1.Y1 = 205
        Me.LineShape1.Y2 = 205
        '
        'nudBonus
        '
        Me.nudBonus.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBonus.Location = New System.Drawing.Point(258, 252)
        Me.nudBonus.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudBonus.Name = "nudBonus"
        Me.nudBonus.Size = New System.Drawing.Size(61, 20)
        Me.nudBonus.TabIndex = 24
        Me.nudBonus.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(213, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Премия"
        Me.Label10.Visible = False
        '
        'nudOP
        '
        Me.nudOP.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudOP.Location = New System.Drawing.Point(420, 252)
        Me.nudOP.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudOP.Name = "nudOP"
        Me.nudOP.Size = New System.Drawing.Size(61, 20)
        Me.nudOP.TabIndex = 28
        Me.nudOP.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(331, 254)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Прочие выплаты"
        Me.Label11.Visible = False
        '
        'nudOC
        '
        Me.nudOC.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudOC.Location = New System.Drawing.Point(420, 226)
        Me.nudOC.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudOC.Name = "nudOC"
        Me.nudOC.Size = New System.Drawing.Size(61, 20)
        Me.nudOC.TabIndex = 26
        Me.nudOC.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(321, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Прочие удержания"
        Me.Label12.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Применить"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(413, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "ОК"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'StateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 352)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.nudOP)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nudOC)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.nudBonus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.nudAdvance)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.FixedSalaryBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nudHour)
        Me.Controls.Add(Me.nudNorm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudSalary)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboWorkshop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtJob)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPatron)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt2Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StateList)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StateForm"
        Me.Text = "Сотрудники"
        CType(Me.nudSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNorm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBonus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StateList As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txt2Name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPatron As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJob As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboWorkshop As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudSalary As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudNorm As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FixedSalaryBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nudAdvance As System.Windows.Forms.NumericUpDown
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents nudBonus As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nudOP As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nudOC As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
