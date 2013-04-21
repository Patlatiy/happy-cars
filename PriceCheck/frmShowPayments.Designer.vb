<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowPayments))
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.cmnNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnSum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPayments
        '
        Me.dgvPayments.AllowUserToAddRows = False
        Me.dgvPayments.AllowUserToDeleteRows = False
        Me.dgvPayments.AllowUserToResizeColumns = False
        Me.dgvPayments.AllowUserToResizeRows = False
        Me.dgvPayments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmnNumber, Me.cmnDate, Me.cmnType, Me.cmnSum})
        Me.dgvPayments.Location = New System.Drawing.Point(14, 34)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.RowHeadersVisible = False
        Me.dgvPayments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPayments.Size = New System.Drawing.Size(423, 474)
        Me.dgvPayments.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(156, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(21, 13)
        Me.Label24.TabIndex = 110
        Me.Label24.Text = "По"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(18, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 13)
        Me.Label23.TabIndex = 111
        Me.Label23.Text = "С"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(183, 8)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(109, 20)
        Me.dtpTo.TabIndex = 109
        Me.dtpTo.Value = New Date(2012, 9, 3, 14, 6, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(40, 8)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(109, 20)
        Me.dtpFrom.TabIndex = 108
        Me.dtpFrom.Value = New Date(2012, 9, 3, 14, 6, 0, 0)
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(305, 7)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 112
        Me.btnShow.Text = "Показать"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'cmnNumber
        '
        Me.cmnNumber.HeaderText = "Номер"
        Me.cmnNumber.Name = "cmnNumber"
        Me.cmnNumber.ReadOnly = True
        Me.cmnNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cmnNumber.Width = 95
        '
        'cmnDate
        '
        Me.cmnDate.HeaderText = "Дата оплаты"
        Me.cmnDate.Name = "cmnDate"
        Me.cmnDate.ReadOnly = True
        Me.cmnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cmnDate.Width = 80
        '
        'cmnType
        '
        Me.cmnType.HeaderText = "Тип оплаты"
        Me.cmnType.Name = "cmnType"
        Me.cmnType.ReadOnly = True
        Me.cmnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cmnType.Width = 125
        '
        'cmnSum
        '
        Me.cmnSum.HeaderText = "Сумма"
        Me.cmnSum.Name = "cmnSum"
        Me.cmnSum.ReadOnly = True
        Me.cmnSum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmShowPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 524)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.dgvPayments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShowPayments"
        Me.Text = "Оплата по заказам"
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPayments As System.Windows.Forms.DataGridView
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents cmnNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnSum As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
