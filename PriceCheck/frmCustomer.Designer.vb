<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.lbl1stName = New System.Windows.Forms.Label()
        Me.txt1stName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblPatron = New System.Windows.Forms.Label()
        Me.txtPatron = New System.Windows.Forms.TextBox()
        Me.dgvCustomerOrders = New System.Windows.Forms.DataGridView()
        Me.cmnCustomerOrderNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnCustomerOrderSum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnCustomerDone = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmnCustomerEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneCode = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1stName
        '
        Me.lbl1stName.AutoSize = True
        Me.lbl1stName.Location = New System.Drawing.Point(12, 43)
        Me.lbl1stName.Name = "lbl1stName"
        Me.lbl1stName.Size = New System.Drawing.Size(29, 13)
        Me.lbl1stName.TabIndex = 0
        Me.lbl1stName.Text = "Имя"
        '
        'txt1stName
        '
        Me.txt1stName.Location = New System.Drawing.Point(90, 40)
        Me.txt1stName.Name = "txt1stName"
        Me.txt1stName.Size = New System.Drawing.Size(137, 20)
        Me.txt1stName.TabIndex = 1
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 17)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(56, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Фамилия"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(90, 14)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(137, 20)
        Me.txtLastName.TabIndex = 0
        '
        'lblPatron
        '
        Me.lblPatron.AutoSize = True
        Me.lblPatron.Location = New System.Drawing.Point(12, 69)
        Me.lblPatron.Name = "lblPatron"
        Me.lblPatron.Size = New System.Drawing.Size(54, 13)
        Me.lblPatron.TabIndex = 0
        Me.lblPatron.Text = "Отчество"
        '
        'txtPatron
        '
        Me.txtPatron.Location = New System.Drawing.Point(90, 66)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.Size = New System.Drawing.Size(137, 20)
        Me.txtPatron.TabIndex = 2
        '
        'dgvCustomerOrders
        '
        Me.dgvCustomerOrders.AllowUserToAddRows = False
        Me.dgvCustomerOrders.AllowUserToDeleteRows = False
        Me.dgvCustomerOrders.AllowUserToResizeRows = False
        Me.dgvCustomerOrders.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvCustomerOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmnCustomerOrderNumber, Me.cmnCustomerOrderSum, Me.cmnCustomerDone, Me.cmnCustomerEdit})
        Me.dgvCustomerOrders.Location = New System.Drawing.Point(260, 12)
        Me.dgvCustomerOrders.Name = "dgvCustomerOrders"
        Me.dgvCustomerOrders.RowHeadersVisible = False
        Me.dgvCustomerOrders.RowTemplate.Height = 21
        Me.dgvCustomerOrders.Size = New System.Drawing.Size(375, 287)
        Me.dgvCustomerOrders.TabIndex = 8
        '
        'cmnCustomerOrderNumber
        '
        Me.cmnCustomerOrderNumber.HeaderText = "Номер"
        Me.cmnCustomerOrderNumber.Name = "cmnCustomerOrderNumber"
        Me.cmnCustomerOrderNumber.ReadOnly = True
        Me.cmnCustomerOrderNumber.Width = 105
        '
        'cmnCustomerOrderSum
        '
        Me.cmnCustomerOrderSum.HeaderText = "Сумма"
        Me.cmnCustomerOrderSum.Name = "cmnCustomerOrderSum"
        Me.cmnCustomerOrderSum.ReadOnly = True
        '
        'cmnCustomerDone
        '
        Me.cmnCustomerDone.HeaderText = "Выполнен"
        Me.cmnCustomerDone.Name = "cmnCustomerDone"
        Me.cmnCustomerDone.ReadOnly = True
        Me.cmnCustomerDone.Width = 70
        '
        'cmnCustomerEdit
        '
        Me.cmnCustomerEdit.HeaderText = "Подробно"
        Me.cmnCustomerEdit.Name = "cmnCustomerEdit"
        Me.cmnCustomerEdit.ReadOnly = True
        Me.cmnCustomerEdit.Width = 75
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(137, 92)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(90, 20)
        Me.txtPhone.TabIndex = 4
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 95)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(79, 13)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Телефон     +7"
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(260, 306)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(97, 23)
        Me.btnNewOrder.TabIndex = 6
        Me.btnNewOrder.Text = "Новый заказ"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDeleteCustomer.ForeColor = System.Drawing.Color.Red
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(59, 303)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(132, 26)
        Me.btnDeleteCustomer.TabIndex = 10
        Me.btnDeleteCustomer.Text = "Удалить клиента"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(12, 121)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(38, 13)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Адрес"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(90, 118)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(137, 20)
        Me.txtAddress.TabIndex = 5
        '
        'txtPhoneCode
        '
        Me.txtPhoneCode.Location = New System.Drawing.Point(91, 92)
        Me.txtPhoneCode.Name = "txtPhoneCode"
        Me.txtPhoneCode.Size = New System.Drawing.Size(40, 20)
        Me.txtPhoneCode.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(560, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "OK"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 336)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPhoneCode)
        Me.Controls.Add(Me.btnDeleteCustomer)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.dgvCustomerOrders)
        Me.Controls.Add(Me.txtPatron)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblPatron)
        Me.Controls.Add(Me.txt1stName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lbl1stName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Клиент"
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1stName As System.Windows.Forms.Label
    Friend WithEvents txt1stName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblPatron As System.Windows.Forms.Label
    Friend WithEvents txtPatron As System.Windows.Forms.TextBox
    Friend WithEvents dgvCustomerOrders As System.Windows.Forms.DataGridView
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents btnNewOrder As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCustomer As System.Windows.Forms.Button
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cmnCustomerOrderNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnCustomerOrderSum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnCustomerDone As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmnCustomerEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents txtPhoneCode As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
