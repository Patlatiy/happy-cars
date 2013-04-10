<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomer))
        Me.lbl1stName = New System.Windows.Forms.Label()
        Me.txt1stName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblPatron = New System.Windows.Forms.Label()
        Me.txtPatron = New System.Windows.Forms.TextBox()
        Me.dgvCustomerOrders = New System.Windows.Forms.DataGridView()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.cmnCustomerOrderNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnCustomerOrderSum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnCustomerDone = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmnCustomerEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1stName
        '
        Me.lbl1stName.AutoSize = True
        Me.lbl1stName.Location = New System.Drawing.Point(12, 41)
        Me.lbl1stName.Name = "lbl1stName"
        Me.lbl1stName.Size = New System.Drawing.Size(29, 13)
        Me.lbl1stName.TabIndex = 0
        Me.lbl1stName.Text = "Имя"
        '
        'txt1stName
        '
        Me.txt1stName.Location = New System.Drawing.Point(90, 38)
        Me.txt1stName.Name = "txt1stName"
        Me.txt1stName.Size = New System.Drawing.Size(137, 20)
        Me.txt1stName.TabIndex = 1
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 15)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(56, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Фамилия"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(90, 12)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(137, 20)
        Me.txtLastName.TabIndex = 0
        '
        'lblPatron
        '
        Me.lblPatron.AutoSize = True
        Me.lblPatron.Location = New System.Drawing.Point(12, 67)
        Me.lblPatron.Name = "lblPatron"
        Me.lblPatron.Size = New System.Drawing.Size(54, 13)
        Me.lblPatron.TabIndex = 0
        Me.lblPatron.Text = "Отчество"
        '
        'txtPatron
        '
        Me.txtPatron.Location = New System.Drawing.Point(90, 64)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.Size = New System.Drawing.Size(137, 20)
        Me.txtPatron.TabIndex = 2
        '
        'dgvCustomerOrders
        '
        Me.dgvCustomerOrders.AllowUserToAddRows = False
        Me.dgvCustomerOrders.AllowUserToDeleteRows = False
        Me.dgvCustomerOrders.AllowUserToResizeRows = False
        Me.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmnCustomerOrderNumber, Me.cmnCustomerOrderSum, Me.cmnCustomerDone, Me.cmnCustomerEdit})
        Me.dgvCustomerOrders.Location = New System.Drawing.Point(255, 12)
        Me.dgvCustomerOrders.Name = "dgvCustomerOrders"
        Me.dgvCustomerOrders.RowHeadersVisible = False
        Me.dgvCustomerOrders.RowTemplate.Height = 21
        Me.dgvCustomerOrders.Size = New System.Drawing.Size(352, 429)
        Me.dgvCustomerOrders.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(90, 90)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(137, 20)
        Me.txtPhone.TabIndex = 3
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 93)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(52, 13)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Телефон"
        '
        'cmnCustomerOrderNumber
        '
        Me.cmnCustomerOrderNumber.HeaderText = "Номер"
        Me.cmnCustomerOrderNumber.Name = "cmnCustomerOrderNumber"
        Me.cmnCustomerOrderNumber.ReadOnly = True
        Me.cmnCustomerOrderNumber.Width = 75
        '
        'cmnCustomerOrderSum
        '
        Me.cmnCustomerOrderSum.HeaderText = "Сумма"
        Me.cmnCustomerOrderSum.Name = "cmnCustomerOrderSum"
        Me.cmnCustomerOrderSum.ReadOnly = True
        '
        'cmnCustomerDone
        '
        Me.cmnCustomerDone.HeaderText = "Исполнен?"
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
        'FormCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 453)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.dgvCustomerOrders)
        Me.Controls.Add(Me.txtPatron)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblPatron)
        Me.Controls.Add(Me.txt1stName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lbl1stName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCustomer"
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
    Friend WithEvents cmnCustomerOrderNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnCustomerOrderSum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnCustomerDone As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmnCustomerEdit As System.Windows.Forms.DataGridViewButtonColumn
End Class
