<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCash))
        Me.lblDash = New System.Windows.Forms.Label()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.txtOrderNumber = New System.Windows.Forms.TextBox()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.dtpPayment = New System.Windows.Forms.DateTimePicker()
        Me.dtpAdvance = New System.Windows.Forms.DateTimePicker()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        Me.lblAdvance = New System.Windows.Forms.Label()
        Me.lblAdvanceDate = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.nudAdvance = New System.Windows.Forms.NumericUpDown()
        Me.nudPayment = New System.Windows.Forms.NumericUpDown()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.txtSellPrice = New System.Windows.Forms.TextBox()
        Me.lblSellPrice = New System.Windows.Forms.Label()
        CType(Me.nudAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Location = New System.Drawing.Point(209, 19)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(10, 13)
        Me.lblDash.TabIndex = 26
        Me.lblDash.Text = "-"
        '
        'txtOrderDate
        '
        Me.txtOrderDate.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOrderDate.Location = New System.Drawing.Point(137, 17)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.ReadOnly = True
        Me.txtOrderDate.Size = New System.Drawing.Size(70, 20)
        Me.txtOrderDate.TabIndex = 24
        Me.txtOrderDate.Text = "0"
        Me.txtOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOrderNumber.Location = New System.Drawing.Point(220, 17)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.ReadOnly = True
        Me.txtOrderNumber.Size = New System.Drawing.Size(33, 20)
        Me.txtOrderNumber.TabIndex = 25
        Me.txtOrderNumber.Text = "0"
        Me.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Location = New System.Drawing.Point(30, 22)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(83, 13)
        Me.lblOrderNumber.TabIndex = 23
        Me.lblOrderNumber.Text = "Номер заказа:"
        '
        'dtpPayment
        '
        Me.dtpPayment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPayment.Location = New System.Drawing.Point(157, 138)
        Me.dtpPayment.Name = "dtpPayment"
        Me.dtpPayment.Size = New System.Drawing.Size(96, 20)
        Me.dtpPayment.TabIndex = 31
        '
        'dtpAdvance
        '
        Me.dtpAdvance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdvance.Location = New System.Drawing.Point(157, 78)
        Me.dtpAdvance.Name = "dtpAdvance"
        Me.dtpAdvance.Size = New System.Drawing.Size(96, 20)
        Me.dtpAdvance.TabIndex = 32
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(30, 117)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(47, 13)
        Me.lblPayment.TabIndex = 27
        Me.lblPayment.Text = "Оплата:"
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Location = New System.Drawing.Point(30, 140)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(76, 13)
        Me.lblPaymentDate.TabIndex = 28
        Me.lblPaymentDate.Text = "Дата оплаты:"
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Location = New System.Drawing.Point(30, 57)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(41, 13)
        Me.lblAdvance.TabIndex = 29
        Me.lblAdvance.Text = "Аванс:"
        '
        'lblAdvanceDate
        '
        Me.lblAdvanceDate.AutoSize = True
        Me.lblAdvanceDate.Location = New System.Drawing.Point(30, 80)
        Me.lblAdvanceDate.Name = "lblAdvanceDate"
        Me.lblAdvanceDate.Size = New System.Drawing.Size(75, 13)
        Me.lblAdvanceDate.TabIndex = 30
        Me.lblAdvanceDate.Text = "Дата аванса:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(232, 224)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(49, 23)
        Me.btnOK.TabIndex = 35
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'nudAdvance
        '
        Me.nudAdvance.DecimalPlaces = 2
        Me.nudAdvance.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudAdvance.Location = New System.Drawing.Point(157, 50)
        Me.nudAdvance.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudAdvance.Name = "nudAdvance"
        Me.nudAdvance.Size = New System.Drawing.Size(96, 20)
        Me.nudAdvance.TabIndex = 36
        '
        'nudPayment
        '
        Me.nudPayment.DecimalPlaces = 2
        Me.nudPayment.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPayment.Location = New System.Drawing.Point(157, 110)
        Me.nudPayment.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPayment.Name = "nudPayment"
        Me.nudPayment.Size = New System.Drawing.Size(96, 20)
        Me.nudPayment.TabIndex = 36
        '
        'txtPaid
        '
        Me.txtPaid.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPaid.Location = New System.Drawing.Point(157, 170)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.ReadOnly = True
        Me.txtPaid.Size = New System.Drawing.Size(96, 20)
        Me.txtPaid.TabIndex = 39
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Location = New System.Drawing.Point(30, 173)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(56, 13)
        Me.lblPaid.TabIndex = 37
        Me.lblPaid.Text = "Оплачено"
        '
        'txtSellPrice
        '
        Me.txtSellPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSellPrice.Location = New System.Drawing.Point(157, 196)
        Me.txtSellPrice.Name = "txtSellPrice"
        Me.txtSellPrice.ReadOnly = True
        Me.txtSellPrice.Size = New System.Drawing.Size(96, 20)
        Me.txtSellPrice.TabIndex = 40
        '
        'lblSellPrice
        '
        Me.lblSellPrice.AutoSize = True
        Me.lblSellPrice.Location = New System.Drawing.Point(30, 199)
        Me.lblSellPrice.Name = "lblSellPrice"
        Me.lblSellPrice.Size = New System.Drawing.Size(101, 13)
        Me.lblSellPrice.TabIndex = 38
        Me.lblSellPrice.Text = "Стоимость заказа"
        '
        'frmAddCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 249)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.txtSellPrice)
        Me.Controls.Add(Me.lblSellPrice)
        Me.Controls.Add(Me.nudPayment)
        Me.Controls.Add(Me.nudAdvance)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.dtpPayment)
        Me.Controls.Add(Me.dtpAdvance)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblPaymentDate)
        Me.Controls.Add(Me.lblAdvance)
        Me.Controls.Add(Me.lblAdvanceDate)
        Me.Controls.Add(Me.lblDash)
        Me.Controls.Add(Me.txtOrderDate)
        Me.Controls.Add(Me.txtOrderNumber)
        Me.Controls.Add(Me.lblOrderNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddCash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddCash"
        CType(Me.nudAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDash As System.Windows.Forms.Label
    Friend WithEvents txtOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents dtpPayment As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAdvance As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblPaymentDate As System.Windows.Forms.Label
    Friend WithEvents lblAdvance As System.Windows.Forms.Label
    Friend WithEvents lblAdvanceDate As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents nudAdvance As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPayment As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents txtSellPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblSellPrice As System.Windows.Forms.Label
End Class
