<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrder))
        Me.lwParts = New System.Windows.Forms.ListView()
        Me.cmnPartName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnPartCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.comboCustomers = New System.Windows.Forms.ComboBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.lblAdvanceDate = New System.Windows.Forms.Label()
        Me.dtpAdvance = New System.Windows.Forms.DateTimePicker()
        Me.lblAdvance = New System.Windows.Forms.Label()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.dtpPayment = New System.Windows.Forms.DateTimePicker()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrderNumber = New System.Windows.Forms.TextBox()
        Me.btnNewPart = New System.Windows.Forms.Button()
        Me.txtPartName = New System.Windows.Forms.TextBox()
        Me.lblPartName = New System.Windows.Forms.Label()
        Me.lblPartCount = New System.Windows.Forms.Label()
        Me.nudPartCount = New System.Windows.Forms.NumericUpDown()
        Me.nudPartPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblPartPrice = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.nudPartCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lwParts
        '
        Me.lwParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lwParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cmnPartName, Me.cmnPartCount})
        Me.lwParts.FullRowSelect = True
        Me.lwParts.GridLines = True
        Me.lwParts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lwParts.Location = New System.Drawing.Point(250, 10)
        Me.lwParts.MultiSelect = False
        Me.lwParts.Name = "lwParts"
        Me.lwParts.Size = New System.Drawing.Size(216, 153)
        Me.lwParts.TabIndex = 0
        Me.lwParts.UseCompatibleStateImageBehavior = False
        Me.lwParts.View = System.Windows.Forms.View.Details
        '
        'cmnPartName
        '
        Me.cmnPartName.Text = "Наименование"
        Me.cmnPartName.Width = 150
        '
        'cmnPartCount
        '
        Me.cmnPartCount.Text = "Кол-во"
        Me.cmnPartCount.Width = 50
        '
        'comboCustomers
        '
        Me.comboCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCustomers.FormattingEnabled = True
        Me.comboCustomers.Location = New System.Drawing.Point(64, 37)
        Me.comboCustomers.Name = "comboCustomers"
        Me.comboCustomers.Size = New System.Drawing.Size(171, 21)
        Me.comboCustomers.Sorted = True
        Me.comboCustomers.TabIndex = 1
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(12, 40)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(46, 13)
        Me.lblCustomer.TabIndex = 2
        Me.lblCustomer.Text = "Клиент:"
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Location = New System.Drawing.Point(12, 66)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(60, 13)
        Me.lblDelivery.TabIndex = 3
        Me.lblDelivery.Text = "Доставка:"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelivery.Location = New System.Drawing.Point(147, 64)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(88, 20)
        Me.dtpDelivery.TabIndex = 4
        '
        'lblAdvanceDate
        '
        Me.lblAdvanceDate.AutoSize = True
        Me.lblAdvanceDate.Location = New System.Drawing.Point(12, 128)
        Me.lblAdvanceDate.Name = "lblAdvanceDate"
        Me.lblAdvanceDate.Size = New System.Drawing.Size(75, 13)
        Me.lblAdvanceDate.TabIndex = 3
        Me.lblAdvanceDate.Text = "Дата аванса:"
        '
        'dtpAdvance
        '
        Me.dtpAdvance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdvance.Location = New System.Drawing.Point(147, 126)
        Me.dtpAdvance.Name = "dtpAdvance"
        Me.dtpAdvance.Size = New System.Drawing.Size(88, 20)
        Me.dtpAdvance.TabIndex = 4
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Location = New System.Drawing.Point(12, 105)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(41, 13)
        Me.lblAdvance.TabIndex = 3
        Me.lblAdvance.Text = "Аванс:"
        '
        'txtAdvance
        '
        Me.txtAdvance.Location = New System.Drawing.Point(147, 100)
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(88, 20)
        Me.txtAdvance.TabIndex = 5
        Me.txtAdvance.Text = "0"
        Me.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Location = New System.Drawing.Point(12, 192)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(76, 13)
        Me.lblPaymentDate.TabIndex = 3
        Me.lblPaymentDate.Text = "Дата оплаты:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(12, 169)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(47, 13)
        Me.lblPayment.TabIndex = 3
        Me.lblPayment.Text = "Оплата:"
        '
        'dtpPayment
        '
        Me.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPayment.Location = New System.Drawing.Point(147, 190)
        Me.dtpPayment.Name = "dtpPayment"
        Me.dtpPayment.Size = New System.Drawing.Size(88, 20)
        Me.dtpPayment.TabIndex = 4
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(147, 164)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(88, 20)
        Me.txtPayment.TabIndex = 5
        Me.txtPayment.Text = "0"
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Номер заказа:"
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOrderNumber.Location = New System.Drawing.Point(147, 10)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.ReadOnly = True
        Me.txtOrderNumber.Size = New System.Drawing.Size(88, 20)
        Me.txtOrderNumber.TabIndex = 5
        Me.txtOrderNumber.Text = "0"
        Me.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNewPart
        '
        Me.btnNewPart.Location = New System.Drawing.Point(327, 176)
        Me.btnNewPart.Name = "btnNewPart"
        Me.btnNewPart.Size = New System.Drawing.Size(62, 22)
        Me.btnNewPart.TabIndex = 7
        Me.btnNewPart.Text = "Новая"
        Me.btnNewPart.UseVisualStyleBackColor = True
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(562, 24)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(152, 20)
        Me.txtPartName.TabIndex = 9
        '
        'lblPartName
        '
        Me.lblPartName.AutoSize = True
        Me.lblPartName.Location = New System.Drawing.Point(473, 27)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(83, 13)
        Me.lblPartName.TabIndex = 10
        Me.lblPartName.Text = "Наименование"
        '
        'lblPartCount
        '
        Me.lblPartCount.AutoSize = True
        Me.lblPartCount.Location = New System.Drawing.Point(473, 53)
        Me.lblPartCount.Name = "lblPartCount"
        Me.lblPartCount.Size = New System.Drawing.Size(66, 13)
        Me.lblPartCount.TabIndex = 10
        Me.lblPartCount.Text = "Количество"
        '
        'nudPartCount
        '
        Me.nudPartCount.Enabled = False
        Me.nudPartCount.Location = New System.Drawing.Point(669, 51)
        Me.nudPartCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPartCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPartCount.Name = "nudPartCount"
        Me.nudPartCount.Size = New System.Drawing.Size(45, 20)
        Me.nudPartCount.TabIndex = 11
        Me.nudPartCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPartPrice
        '
        Me.nudPartPrice.Enabled = False
        Me.nudPartPrice.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPartPrice.Location = New System.Drawing.Point(632, 77)
        Me.nudPartPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPartPrice.Name = "nudPartPrice"
        Me.nudPartPrice.Size = New System.Drawing.Size(82, 20)
        Me.nudPartPrice.TabIndex = 12
        '
        'lblPartPrice
        '
        Me.lblPartPrice.AutoSize = True
        Me.lblPartPrice.Location = New System.Drawing.Point(473, 79)
        Me.lblPartPrice.Name = "lblPartPrice"
        Me.lblPartPrice.Size = New System.Drawing.Size(77, 13)
        Me.lblPartPrice.TabIndex = 10
        Me.lblPartPrice.Text = "Цена закупки"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(735, 224)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(465, 10)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(259, 201)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(250, 162)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(215, 49)
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 224)
        Me.Controls.Add(Me.nudPartPrice)
        Me.Controls.Add(Me.nudPartCount)
        Me.Controls.Add(Me.lblPartPrice)
        Me.Controls.Add(Me.lblPartCount)
        Me.Controls.Add(Me.lblPartName)
        Me.Controls.Add(Me.txtPartName)
        Me.Controls.Add(Me.btnNewPart)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtOrderNumber)
        Me.Controls.Add(Me.txtAdvance)
        Me.Controls.Add(Me.dtpPayment)
        Me.Controls.Add(Me.dtpAdvance)
        Me.Controls.Add(Me.dtpDelivery)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPaymentDate)
        Me.Controls.Add(Me.lblAdvance)
        Me.Controls.Add(Me.lblAdvanceDate)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.comboCustomers)
        Me.Controls.Add(Me.lwParts)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Заказ № "
        CType(Me.nudPartCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lwParts As System.Windows.Forms.ListView
    Friend WithEvents cmnPartName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnPartCount As System.Windows.Forms.ColumnHeader
    Friend WithEvents comboCustomers As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents dtpDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAdvanceDate As System.Windows.Forms.Label
    Friend WithEvents dtpAdvance As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAdvance As System.Windows.Forms.Label
    Friend WithEvents txtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentDate As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents dtpPayment As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnNewPart As System.Windows.Forms.Button
    Friend WithEvents txtPartName As System.Windows.Forms.TextBox
    Friend WithEvents lblPartName As System.Windows.Forms.Label
    Friend WithEvents lblPartCount As System.Windows.Forms.Label
    Friend WithEvents nudPartCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPartPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPartPrice As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
