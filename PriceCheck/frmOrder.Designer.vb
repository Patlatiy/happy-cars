﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmnNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnPartName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnPartCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.txtOrderNumber = New System.Windows.Forms.TextBox()
        Me.btnNewPart = New System.Windows.Forms.Button()
        Me.txtPartName = New System.Windows.Forms.TextBox()
        Me.lblPartName = New System.Windows.Forms.Label()
        Me.lblPartCount = New System.Windows.Forms.Label()
        Me.nudPartCount = New System.Windows.Forms.NumericUpDown()
        Me.nudPartPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblPartPrice = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblMargin = New System.Windows.Forms.Label()
        Me.nudMargin = New System.Windows.Forms.NumericUpDown()
        Me.nudMarginPc = New System.Windows.Forms.NumericUpDown()
        Me.lblMarginPc = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.nudDiscount = New System.Windows.Forms.NumericUpDown()
        Me.nudDiscountPc = New System.Windows.Forms.NumericUpDown()
        Me.lblDiscountPc = New System.Windows.Forms.Label()
        Me.lblSellPrice = New System.Windows.Forms.Label()
        Me.txtSellPrice = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblDiscountRbl = New System.Windows.Forms.Label()
        Me.lblMarginRbl = New System.Windows.Forms.Label()
        Me.lblTotalReceived = New System.Windows.Forms.Label()
        Me.txtTotalReceived = New System.Windows.Forms.TextBox()
        Me.btnDeletePart = New System.Windows.Forms.Button()
        Me.boxCompleted = New System.Windows.Forms.CheckBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.comboExecutor = New System.Windows.Forms.ComboBox()
        Me.lblExecutor = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ЗаказToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПечатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьЗаказToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCompleted = New System.Windows.Forms.Label()
        CType(Me.nudPartCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMarginPc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiscountPc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lwParts
        '
        Me.lwParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lwParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cmnNumber, Me.cmnPartName, Me.cmnPartCount, Me.cmnPrice})
        Me.lwParts.FullRowSelect = True
        Me.lwParts.GridLines = True
        Me.lwParts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lwParts.Location = New System.Drawing.Point(250, 25)
        Me.lwParts.MultiSelect = False
        Me.lwParts.Name = "lwParts"
        Me.lwParts.Size = New System.Drawing.Size(322, 153)
        Me.lwParts.TabIndex = 0
        Me.lwParts.UseCompatibleStateImageBehavior = False
        Me.lwParts.View = System.Windows.Forms.View.Details
        '
        'cmnNumber
        '
        Me.cmnNumber.Text = "№"
        Me.cmnNumber.Width = 30
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
        'cmnPrice
        '
        Me.cmnPrice.Text = "Цена"
        Me.cmnPrice.Width = 75
        '
        'comboCustomers
        '
        Me.comboCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCustomers.FormattingEnabled = True
        Me.comboCustomers.Location = New System.Drawing.Point(64, 52)
        Me.comboCustomers.Name = "comboCustomers"
        Me.comboCustomers.Size = New System.Drawing.Size(171, 21)
        Me.comboCustomers.Sorted = True
        Me.comboCustomers.TabIndex = 1
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(12, 55)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(46, 13)
        Me.lblCustomer.TabIndex = 2
        Me.lblCustomer.Text = "Клиент:"
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Location = New System.Drawing.Point(12, 114)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(60, 13)
        Me.lblDelivery.TabIndex = 3
        Me.lblDelivery.Text = "Доставка:"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelivery.Location = New System.Drawing.Point(147, 112)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(88, 20)
        Me.dtpDelivery.TabIndex = 4
        '
        'lblAdvanceDate
        '
        Me.lblAdvanceDate.AutoSize = True
        Me.lblAdvanceDate.Location = New System.Drawing.Point(12, 176)
        Me.lblAdvanceDate.Name = "lblAdvanceDate"
        Me.lblAdvanceDate.Size = New System.Drawing.Size(75, 13)
        Me.lblAdvanceDate.TabIndex = 3
        Me.lblAdvanceDate.Text = "Дата аванса:"
        '
        'dtpAdvance
        '
        Me.dtpAdvance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdvance.Location = New System.Drawing.Point(147, 174)
        Me.dtpAdvance.Name = "dtpAdvance"
        Me.dtpAdvance.Size = New System.Drawing.Size(88, 20)
        Me.dtpAdvance.TabIndex = 4
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Location = New System.Drawing.Point(12, 153)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(41, 13)
        Me.lblAdvance.TabIndex = 3
        Me.lblAdvance.Text = "Аванс:"
        '
        'txtAdvance
        '
        Me.txtAdvance.Location = New System.Drawing.Point(147, 148)
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(88, 20)
        Me.txtAdvance.TabIndex = 5
        Me.txtAdvance.Text = "0"
        Me.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Location = New System.Drawing.Point(12, 236)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(76, 13)
        Me.lblPaymentDate.TabIndex = 3
        Me.lblPaymentDate.Text = "Дата оплаты:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(12, 213)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(47, 13)
        Me.lblPayment.TabIndex = 3
        Me.lblPayment.Text = "Оплата:"
        '
        'dtpPayment
        '
        Me.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPayment.Location = New System.Drawing.Point(147, 234)
        Me.dtpPayment.Name = "dtpPayment"
        Me.dtpPayment.Size = New System.Drawing.Size(88, 20)
        Me.dtpPayment.TabIndex = 4
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(147, 208)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(88, 20)
        Me.txtPayment.TabIndex = 5
        Me.txtPayment.Text = "0"
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Location = New System.Drawing.Point(12, 30)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(83, 13)
        Me.lblOrderNumber.TabIndex = 3
        Me.lblOrderNumber.Text = "Номер заказа:"
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOrderNumber.Location = New System.Drawing.Point(202, 25)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.ReadOnly = True
        Me.txtOrderNumber.Size = New System.Drawing.Size(33, 20)
        Me.txtOrderNumber.TabIndex = 5
        Me.txtOrderNumber.Text = "0"
        Me.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNewPart
        '
        Me.btnNewPart.Location = New System.Drawing.Point(306, 186)
        Me.btnNewPart.Name = "btnNewPart"
        Me.btnNewPart.Size = New System.Drawing.Size(99, 22)
        Me.btnNewPart.TabIndex = 7
        Me.btnNewPart.Text = "Новая запчасть"
        Me.btnNewPart.UseVisualStyleBackColor = True
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(667, 36)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(152, 20)
        Me.txtPartName.TabIndex = 9
        '
        'lblPartName
        '
        Me.lblPartName.AutoSize = True
        Me.lblPartName.Location = New System.Drawing.Point(578, 39)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(83, 13)
        Me.lblPartName.TabIndex = 10
        Me.lblPartName.Text = "Наименование"
        '
        'lblPartCount
        '
        Me.lblPartCount.AutoSize = True
        Me.lblPartCount.Location = New System.Drawing.Point(577, 70)
        Me.lblPartCount.Name = "lblPartCount"
        Me.lblPartCount.Size = New System.Drawing.Size(66, 13)
        Me.lblPartCount.TabIndex = 10
        Me.lblPartCount.Text = "Количество"
        '
        'nudPartCount
        '
        Me.nudPartCount.Enabled = False
        Me.nudPartCount.Location = New System.Drawing.Point(773, 67)
        Me.nudPartCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPartCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPartCount.Name = "nudPartCount"
        Me.nudPartCount.Size = New System.Drawing.Size(45, 20)
        Me.nudPartCount.TabIndex = 11
        Me.nudPartCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPartPrice
        '
        Me.nudPartPrice.DecimalPlaces = 2
        Me.nudPartPrice.Enabled = False
        Me.nudPartPrice.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPartPrice.Location = New System.Drawing.Point(737, 99)
        Me.nudPartPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPartPrice.Name = "nudPartPrice"
        Me.nudPartPrice.Size = New System.Drawing.Size(82, 20)
        Me.nudPartPrice.TabIndex = 12
        '
        'lblPartPrice
        '
        Me.lblPartPrice.AutoSize = True
        Me.lblPartPrice.Location = New System.Drawing.Point(578, 102)
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(841, 305)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 580
        Me.LineShape2.X2 = 820
        Me.LineShape2.Y1 = 170
        Me.LineShape2.Y2 = 170
        '
        'LineShape1
        '
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 233
        Me.LineShape1.Y1 = 263
        Me.LineShape1.Y2 = 263
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Enabled = False
        Me.RectangleShape2.Location = New System.Drawing.Point(571, 25)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(259, 192)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Enabled = False
        Me.RectangleShape1.Location = New System.Drawing.Point(250, 177)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(321, 40)
        '
        'lblMargin
        '
        Me.lblMargin.AutoSize = True
        Me.lblMargin.Location = New System.Drawing.Point(577, 136)
        Me.lblMargin.Name = "lblMargin"
        Me.lblMargin.Size = New System.Drawing.Size(42, 13)
        Me.lblMargin.TabIndex = 10
        Me.lblMargin.Text = "Маржа"
        '
        'nudMargin
        '
        Me.nudMargin.DecimalPlaces = 2
        Me.nudMargin.Enabled = False
        Me.nudMargin.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMargin.Location = New System.Drawing.Point(736, 133)
        Me.nudMargin.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudMargin.Name = "nudMargin"
        Me.nudMargin.Size = New System.Drawing.Size(65, 20)
        Me.nudMargin.TabIndex = 12
        '
        'nudMarginPc
        '
        Me.nudMarginPc.Enabled = False
        Me.nudMarginPc.Location = New System.Drawing.Point(625, 133)
        Me.nudMarginPc.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMarginPc.Name = "nudMarginPc"
        Me.nudMarginPc.Size = New System.Drawing.Size(65, 20)
        Me.nudMarginPc.TabIndex = 12
        '
        'lblMarginPc
        '
        Me.lblMarginPc.AutoSize = True
        Me.lblMarginPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMarginPc.Location = New System.Drawing.Point(691, 137)
        Me.lblMarginPc.Name = "lblMarginPc"
        Me.lblMarginPc.Size = New System.Drawing.Size(15, 13)
        Me.lblMarginPc.TabIndex = 14
        Me.lblMarginPc.Text = "%"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(292, 241)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(44, 13)
        Me.lblDiscount.TabIndex = 10
        Me.lblDiscount.Text = "Скидка"
        '
        'nudDiscount
        '
        Me.nudDiscount.DecimalPlaces = 2
        Me.nudDiscount.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudDiscount.Location = New System.Drawing.Point(451, 239)
        Me.nudDiscount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudDiscount.Name = "nudDiscount"
        Me.nudDiscount.Size = New System.Drawing.Size(65, 20)
        Me.nudDiscount.TabIndex = 12
        '
        'nudDiscountPc
        '
        Me.nudDiscountPc.Location = New System.Drawing.Point(338, 238)
        Me.nudDiscountPc.Name = "nudDiscountPc"
        Me.nudDiscountPc.Size = New System.Drawing.Size(65, 20)
        Me.nudDiscountPc.TabIndex = 12
        '
        'lblDiscountPc
        '
        Me.lblDiscountPc.AutoSize = True
        Me.lblDiscountPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDiscountPc.Location = New System.Drawing.Point(406, 242)
        Me.lblDiscountPc.Name = "lblDiscountPc"
        Me.lblDiscountPc.Size = New System.Drawing.Size(15, 13)
        Me.lblDiscountPc.TabIndex = 14
        Me.lblDiscountPc.Text = "%"
        '
        'lblSellPrice
        '
        Me.lblSellPrice.AutoSize = True
        Me.lblSellPrice.Location = New System.Drawing.Point(581, 191)
        Me.lblSellPrice.Name = "lblSellPrice"
        Me.lblSellPrice.Size = New System.Drawing.Size(80, 13)
        Me.lblSellPrice.TabIndex = 15
        Me.lblSellPrice.Text = "Цена продажи"
        '
        'txtSellPrice
        '
        Me.txtSellPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSellPrice.Location = New System.Drawing.Point(722, 188)
        Me.txtSellPrice.Name = "txtSellPrice"
        Me.txtSellPrice.ReadOnly = True
        Me.txtSellPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtSellPrice.TabIndex = 16
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(607, 275)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(114, 13)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "Общая стоимость"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotal.Location = New System.Drawing.Point(731, 272)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 16
        '
        'lblDiscountRbl
        '
        Me.lblDiscountRbl.AutoSize = True
        Me.lblDiscountRbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDiscountRbl.Location = New System.Drawing.Point(518, 242)
        Me.lblDiscountRbl.Name = "lblDiscountRbl"
        Me.lblDiscountRbl.Size = New System.Drawing.Size(16, 13)
        Me.lblDiscountRbl.TabIndex = 14
        Me.lblDiscountRbl.Text = "р."
        '
        'lblMarginRbl
        '
        Me.lblMarginRbl.AutoSize = True
        Me.lblMarginRbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMarginRbl.Location = New System.Drawing.Point(802, 136)
        Me.lblMarginRbl.Name = "lblMarginRbl"
        Me.lblMarginRbl.Size = New System.Drawing.Size(16, 13)
        Me.lblMarginRbl.TabIndex = 14
        Me.lblMarginRbl.Text = "р."
        '
        'lblTotalReceived
        '
        Me.lblTotalReceived.AutoSize = True
        Me.lblTotalReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTotalReceived.Location = New System.Drawing.Point(12, 275)
        Me.lblTotalReceived.Name = "lblTotalReceived"
        Me.lblTotalReceived.Size = New System.Drawing.Size(100, 13)
        Me.lblTotalReceived.TabIndex = 17
        Me.lblTotalReceived.Text = "Итого получено"
        '
        'txtTotalReceived
        '
        Me.txtTotalReceived.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotalReceived.Location = New System.Drawing.Point(146, 272)
        Me.txtTotalReceived.Name = "txtTotalReceived"
        Me.txtTotalReceived.ReadOnly = True
        Me.txtTotalReceived.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalReceived.TabIndex = 5
        Me.txtTotalReceived.Text = "0"
        Me.txtTotalReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDeletePart
        '
        Me.btnDeletePart.Location = New System.Drawing.Point(411, 186)
        Me.btnDeletePart.Name = "btnDeletePart"
        Me.btnDeletePart.Size = New System.Drawing.Size(99, 22)
        Me.btnDeletePart.TabIndex = 7
        Me.btnDeletePart.Text = "Удалить"
        Me.btnDeletePart.UseVisualStyleBackColor = True
        '
        'boxCompleted
        '
        Me.boxCompleted.AutoSize = True
        Me.boxCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.boxCompleted.Location = New System.Drawing.Point(816, 246)
        Me.boxCompleted.Name = "boxCompleted"
        Me.boxCompleted.Size = New System.Drawing.Size(15, 14)
        Me.boxCompleted.TabIndex = 18
        Me.boxCompleted.UseVisualStyleBackColor = True
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(250, 272)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(320, 20)
        Me.txtComment.TabIndex = 20
        Me.txtComment.Text = "txtComment"
        '
        'txtOrderDate
        '
        Me.txtOrderDate.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOrderDate.Location = New System.Drawing.Point(139, 25)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.ReadOnly = True
        Me.txtOrderDate.Size = New System.Drawing.Size(50, 20)
        Me.txtOrderDate.TabIndex = 5
        Me.txtOrderDate.Text = "0"
        Me.txtOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Location = New System.Drawing.Point(191, 27)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(10, 13)
        Me.lblDash.TabIndex = 22
        Me.lblDash.Text = "-"
        '
        'comboExecutor
        '
        Me.comboExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboExecutor.FormattingEnabled = True
        Me.comboExecutor.Location = New System.Drawing.Point(95, 79)
        Me.comboExecutor.Name = "comboExecutor"
        Me.comboExecutor.Size = New System.Drawing.Size(140, 21)
        Me.comboExecutor.Sorted = True
        Me.comboExecutor.TabIndex = 1
        '
        'lblExecutor
        '
        Me.lblExecutor.AutoSize = True
        Me.lblExecutor.Location = New System.Drawing.Point(12, 82)
        Me.lblExecutor.Name = "lblExecutor"
        Me.lblExecutor.Size = New System.Drawing.Size(77, 13)
        Me.lblExecutor.TabIndex = 2
        Me.lblExecutor.Text = "Исполнитель:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗаказToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(841, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ЗаказToolStripMenuItem
        '
        Me.ЗаказToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПечатьToolStripMenuItem, Me.УдалитьЗаказToolStripMenuItem})
        Me.ЗаказToolStripMenuItem.Name = "ЗаказToolStripMenuItem"
        Me.ЗаказToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ЗаказToolStripMenuItem.Text = "Заказ"
        '
        'ПечатьToolStripMenuItem
        '
        Me.ПечатьToolStripMenuItem.Name = "ПечатьToolStripMenuItem"
        Me.ПечатьToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ПечатьToolStripMenuItem.Text = "Печать..."
        '
        'УдалитьЗаказToolStripMenuItem
        '
        Me.УдалитьЗаказToolStripMenuItem.Name = "УдалитьЗаказToolStripMenuItem"
        Me.УдалитьЗаказToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.УдалитьЗаказToolStripMenuItem.Text = "Удалить заказ"
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCompleted.Location = New System.Drawing.Point(705, 245)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(109, 13)
        Me.lblCompleted.TabIndex = 15
        Me.lblCompleted.Text = "Заказ выполнен:"
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 305)
        Me.Controls.Add(Me.lblCompleted)
        Me.Controls.Add(Me.lblExecutor)
        Me.Controls.Add(Me.comboExecutor)
        Me.Controls.Add(Me.lblDash)
        Me.Controls.Add(Me.txtOrderDate)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.boxCompleted)
        Me.Controls.Add(Me.btnDeletePart)
        Me.Controls.Add(Me.txtTotalReceived)
        Me.Controls.Add(Me.lblTotalReceived)
        Me.Controls.Add(Me.lblMarginRbl)
        Me.Controls.Add(Me.lblDiscountRbl)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtSellPrice)
        Me.Controls.Add(Me.lblSellPrice)
        Me.Controls.Add(Me.lblDiscountPc)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.nudDiscountPc)
        Me.Controls.Add(Me.nudDiscount)
        Me.Controls.Add(Me.lblMarginPc)
        Me.Controls.Add(Me.nudMarginPc)
        Me.Controls.Add(Me.nudMargin)
        Me.Controls.Add(Me.lblMargin)
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
        Me.Controls.Add(Me.lblOrderNumber)
        Me.Controls.Add(Me.lblPaymentDate)
        Me.Controls.Add(Me.lblAdvance)
        Me.Controls.Add(Me.lblAdvanceDate)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.comboCustomers)
        Me.Controls.Add(Me.lwParts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Заказ"
        CType(Me.nudPartCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMargin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMarginPc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiscountPc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
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
    Friend WithEvents lblMargin As System.Windows.Forms.Label
    Friend WithEvents nudMargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMarginPc As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMarginPc As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents nudDiscount As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDiscountPc As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDiscountPc As System.Windows.Forms.Label
    Friend WithEvents lblSellPrice As System.Windows.Forms.Label
    Friend WithEvents txtSellPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountRbl As System.Windows.Forms.Label
    Friend WithEvents lblMarginRbl As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblTotalReceived As System.Windows.Forms.Label
    Friend WithEvents txtTotalReceived As System.Windows.Forms.TextBox
    Friend WithEvents btnDeletePart As System.Windows.Forms.Button
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmnNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents boxCompleted As System.Windows.Forms.CheckBox
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents comboExecutor As System.Windows.Forms.ComboBox
    Friend WithEvents lblExecutor As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ЗаказToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПечатьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents УдалитьЗаказToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCompleted As System.Windows.Forms.Label
End Class