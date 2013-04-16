<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewOrder))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.comboCustomer = New System.Windows.Forms.ComboBox()
        Me.lwParts = New System.Windows.Forms.ListView()
        Me.cmnNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnPartName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnPartCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblExecutor = New System.Windows.Forms.Label()
        Me.comboExecutor = New System.Windows.Forms.ComboBox()
        Me.btnAddPart = New System.Windows.Forms.Button()
        Me.btnDeletePart = New System.Windows.Forms.Button()
        Me.btnShowExecutor = New System.Windows.Forms.Button()
        Me.lblDiscountRbl = New System.Windows.Forms.Label()
        Me.lblDiscountPc = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.nudDiscountPc = New System.Windows.Forms.NumericUpDown()
        Me.nudDiscount = New System.Windows.Forms.NumericUpDown()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.lblDelivery = New System.Windows.Forms.Label()
        CType(Me.nudDiscountPc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(290, 383)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Location = New System.Drawing.Point(24, 20)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(55, 13)
        Me.lblCustomers.TabIndex = 1
        Me.lblCustomers.Text = "Заказчик"
        '
        'comboCustomer
        '
        Me.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCustomer.FormattingEnabled = True
        Me.comboCustomer.Location = New System.Drawing.Point(110, 17)
        Me.comboCustomer.Name = "comboCustomer"
        Me.comboCustomer.Size = New System.Drawing.Size(239, 21)
        Me.comboCustomer.Sorted = True
        Me.comboCustomer.TabIndex = 2
        '
        'lwParts
        '
        Me.lwParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lwParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cmnNumber, Me.cmnPartName, Me.cmnPartCount, Me.cmnPrice})
        Me.lwParts.FullRowSelect = True
        Me.lwParts.GridLines = True
        Me.lwParts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lwParts.Location = New System.Drawing.Point(27, 71)
        Me.lwParts.MultiSelect = False
        Me.lwParts.Name = "lwParts"
        Me.lwParts.Size = New System.Drawing.Size(322, 153)
        Me.lwParts.TabIndex = 3
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
        'lblExecutor
        '
        Me.lblExecutor.AutoSize = True
        Me.lblExecutor.Location = New System.Drawing.Point(24, 47)
        Me.lblExecutor.Name = "lblExecutor"
        Me.lblExecutor.Size = New System.Drawing.Size(74, 13)
        Me.lblExecutor.TabIndex = 1
        Me.lblExecutor.Text = "Исполнитель"
        '
        'comboExecutor
        '
        Me.comboExecutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboExecutor.FormattingEnabled = True
        Me.comboExecutor.Location = New System.Drawing.Point(110, 44)
        Me.comboExecutor.Name = "comboExecutor"
        Me.comboExecutor.Size = New System.Drawing.Size(206, 21)
        Me.comboExecutor.Sorted = True
        Me.comboExecutor.TabIndex = 2
        '
        'btnAddPart
        '
        Me.btnAddPart.Location = New System.Drawing.Point(110, 230)
        Me.btnAddPart.Name = "btnAddPart"
        Me.btnAddPart.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPart.TabIndex = 4
        Me.btnAddPart.Text = "Добавить..."
        Me.btnAddPart.UseVisualStyleBackColor = True
        '
        'btnDeletePart
        '
        Me.btnDeletePart.Location = New System.Drawing.Point(191, 230)
        Me.btnDeletePart.Name = "btnDeletePart"
        Me.btnDeletePart.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletePart.TabIndex = 4
        Me.btnDeletePart.Text = "Удалить"
        Me.btnDeletePart.UseVisualStyleBackColor = True
        '
        'btnShowExecutor
        '
        Me.btnShowExecutor.Location = New System.Drawing.Point(322, 43)
        Me.btnShowExecutor.Name = "btnShowExecutor"
        Me.btnShowExecutor.Size = New System.Drawing.Size(27, 23)
        Me.btnShowExecutor.TabIndex = 5
        Me.btnShowExecutor.Text = "..."
        Me.btnShowExecutor.UseVisualStyleBackColor = True
        '
        'lblDiscountRbl
        '
        Me.lblDiscountRbl.AutoSize = True
        Me.lblDiscountRbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDiscountRbl.Location = New System.Drawing.Point(283, 274)
        Me.lblDiscountRbl.Name = "lblDiscountRbl"
        Me.lblDiscountRbl.Size = New System.Drawing.Size(16, 13)
        Me.lblDiscountRbl.TabIndex = 18
        Me.lblDiscountRbl.Text = "р."
        '
        'lblDiscountPc
        '
        Me.lblDiscountPc.AutoSize = True
        Me.lblDiscountPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDiscountPc.Location = New System.Drawing.Point(190, 275)
        Me.lblDiscountPc.Name = "lblDiscountPc"
        Me.lblDiscountPc.Size = New System.Drawing.Size(15, 13)
        Me.lblDiscountPc.TabIndex = 19
        Me.lblDiscountPc.Text = "%"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(78, 274)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(44, 13)
        Me.lblDiscount.TabIndex = 15
        Me.lblDiscount.Text = "Скидка"
        '
        'nudDiscountPc
        '
        Me.nudDiscountPc.Location = New System.Drawing.Point(124, 271)
        Me.nudDiscountPc.Name = "nudDiscountPc"
        Me.nudDiscountPc.Size = New System.Drawing.Size(65, 20)
        Me.nudDiscountPc.TabIndex = 16
        '
        'nudDiscount
        '
        Me.nudDiscount.DecimalPlaces = 2
        Me.nudDiscount.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudDiscount.Location = New System.Drawing.Point(215, 272)
        Me.nudDiscount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudDiscount.Name = "nudDiscount"
        Me.nudDiscount.Size = New System.Drawing.Size(65, 20)
        Me.nudDiscount.TabIndex = 17
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotal.Location = New System.Drawing.Point(132, 386)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 21
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(8, 389)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(114, 13)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "Общая стоимость"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelivery.Location = New System.Drawing.Point(175, 307)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(88, 20)
        Me.dtpDelivery.TabIndex = 23
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Location = New System.Drawing.Point(113, 310)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(60, 13)
        Me.lblDelivery.TabIndex = 22
        Me.lblDelivery.Text = "Доставка:"
        '
        'frmNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 446)
        Me.Controls.Add(Me.dtpDelivery)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscountRbl)
        Me.Controls.Add(Me.lblDiscountPc)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.nudDiscountPc)
        Me.Controls.Add(Me.nudDiscount)
        Me.Controls.Add(Me.btnShowExecutor)
        Me.Controls.Add(Me.btnDeletePart)
        Me.Controls.Add(Me.btnAddPart)
        Me.Controls.Add(Me.lwParts)
        Me.Controls.Add(Me.comboExecutor)
        Me.Controls.Add(Me.comboCustomer)
        Me.Controls.Add(Me.lblExecutor)
        Me.Controls.Add(Me.lblCustomers)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Новый заказ"
        CType(Me.nudDiscountPc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblCustomers As System.Windows.Forms.Label
    Friend WithEvents comboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lwParts As System.Windows.Forms.ListView
    Friend WithEvents cmnNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnPartName As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnPartCount As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblExecutor As System.Windows.Forms.Label
    Friend WithEvents comboExecutor As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddPart As System.Windows.Forms.Button
    Friend WithEvents btnDeletePart As System.Windows.Forms.Button
    Friend WithEvents btnShowExecutor As System.Windows.Forms.Button
    Friend WithEvents lblDiscountRbl As System.Windows.Forms.Label
    Friend WithEvents lblDiscountPc As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents nudDiscountPc As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDiscount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents dtpDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
End Class
