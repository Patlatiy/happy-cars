﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewPart))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMarginRbl = New System.Windows.Forms.Label()
        Me.lblMarginPc = New System.Windows.Forms.Label()
        Me.nudMarginPc = New System.Windows.Forms.NumericUpDown()
        Me.nudMargin = New System.Windows.Forms.NumericUpDown()
        Me.lblMargin = New System.Windows.Forms.Label()
        Me.nudPartPrice = New System.Windows.Forms.NumericUpDown()
        Me.nudPartCount = New System.Windows.Forms.NumericUpDown()
        Me.lblPartPrice = New System.Windows.Forms.Label()
        Me.lblPartCount = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.comboUnits = New System.Windows.Forms.ComboBox()
        Me.comboProvider = New System.Windows.Forms.ComboBox()
        Me.lblProvider = New System.Windows.Forms.Label()
        Me.lblRawPrice = New System.Windows.Forms.Label()
        Me.txtRawPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudSellPrice = New System.Windows.Forms.NumericUpDown()
        Me.comboName = New System.Windows.Forms.ComboBox()
        CType(Me.nudMarginPc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPartCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSellPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Наименование"
        '
        'lblMarginRbl
        '
        Me.lblMarginRbl.AutoSize = True
        Me.lblMarginRbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMarginRbl.Location = New System.Drawing.Point(332, 140)
        Me.lblMarginRbl.Name = "lblMarginRbl"
        Me.lblMarginRbl.Size = New System.Drawing.Size(16, 13)
        Me.lblMarginRbl.TabIndex = 24
        Me.lblMarginRbl.Text = "р."
        '
        'lblMarginPc
        '
        Me.lblMarginPc.AutoSize = True
        Me.lblMarginPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMarginPc.Location = New System.Drawing.Point(221, 141)
        Me.lblMarginPc.Name = "lblMarginPc"
        Me.lblMarginPc.Size = New System.Drawing.Size(15, 13)
        Me.lblMarginPc.TabIndex = 25
        Me.lblMarginPc.Text = "%"
        '
        'nudMarginPc
        '
        Me.nudMarginPc.Location = New System.Drawing.Point(155, 137)
        Me.nudMarginPc.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMarginPc.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMarginPc.Name = "nudMarginPc"
        Me.nudMarginPc.Size = New System.Drawing.Size(65, 20)
        Me.nudMarginPc.TabIndex = 21
        '
        'nudMargin
        '
        Me.nudMargin.DecimalPlaces = 2
        Me.nudMargin.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMargin.Location = New System.Drawing.Point(266, 137)
        Me.nudMargin.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudMargin.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.nudMargin.Name = "nudMargin"
        Me.nudMargin.Size = New System.Drawing.Size(65, 20)
        Me.nudMargin.TabIndex = 22
        '
        'lblMargin
        '
        Me.lblMargin.AutoSize = True
        Me.lblMargin.Location = New System.Drawing.Point(9, 139)
        Me.lblMargin.Name = "lblMargin"
        Me.lblMargin.Size = New System.Drawing.Size(42, 13)
        Me.lblMargin.TabIndex = 17
        Me.lblMargin.Text = "Маржа"
        '
        'nudPartPrice
        '
        Me.nudPartPrice.DecimalPlaces = 2
        Me.nudPartPrice.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPartPrice.Location = New System.Drawing.Point(266, 85)
        Me.nudPartPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPartPrice.Name = "nudPartPrice"
        Me.nudPartPrice.Size = New System.Drawing.Size(82, 20)
        Me.nudPartPrice.TabIndex = 23
        '
        'nudPartCount
        '
        Me.nudPartCount.Location = New System.Drawing.Point(225, 32)
        Me.nudPartCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPartCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPartCount.Name = "nudPartCount"
        Me.nudPartCount.Size = New System.Drawing.Size(45, 20)
        Me.nudPartCount.TabIndex = 20
        Me.nudPartCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblPartPrice
        '
        Me.lblPartPrice.AutoSize = True
        Me.lblPartPrice.Location = New System.Drawing.Point(9, 87)
        Me.lblPartPrice.Name = "lblPartPrice"
        Me.lblPartPrice.Size = New System.Drawing.Size(142, 13)
        Me.lblPartPrice.TabIndex = 18
        Me.lblPartPrice.Text = "Цена закупки (за единицу)"
        '
        'lblPartCount
        '
        Me.lblPartCount.AutoSize = True
        Me.lblPartCount.Location = New System.Drawing.Point(10, 35)
        Me.lblPartCount.Name = "lblPartCount"
        Me.lblPartCount.Size = New System.Drawing.Size(66, 13)
        Me.lblPartCount.TabIndex = 19
        Me.lblPartCount.Text = "Количество"
        '
        'LineShape2
        '
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 15
        Me.LineShape2.X2 = 346
        Me.LineShape2.Y1 = 168
        Me.LineShape2.Y2 = 168
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(360, 209)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(311, 182)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(46, 23)
        Me.btnOK.TabIndex = 29
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'comboUnits
        '
        Me.comboUnits.FormattingEnabled = True
        Me.comboUnits.Location = New System.Drawing.Point(276, 32)
        Me.comboUnits.Name = "comboUnits"
        Me.comboUnits.Size = New System.Drawing.Size(72, 21)
        Me.comboUnits.TabIndex = 30
        Me.comboUnits.Text = "шт."
        '
        'comboProvider
        '
        Me.comboProvider.FormattingEnabled = True
        Me.comboProvider.Location = New System.Drawing.Point(172, 59)
        Me.comboProvider.Name = "comboProvider"
        Me.comboProvider.Size = New System.Drawing.Size(176, 21)
        Me.comboProvider.TabIndex = 31
        '
        'lblProvider
        '
        Me.lblProvider.AutoSize = True
        Me.lblProvider.Location = New System.Drawing.Point(10, 62)
        Me.lblProvider.Name = "lblProvider"
        Me.lblProvider.Size = New System.Drawing.Size(65, 13)
        Me.lblProvider.TabIndex = 19
        Me.lblProvider.Text = "Поставщик"
        '
        'lblRawPrice
        '
        Me.lblRawPrice.AutoSize = True
        Me.lblRawPrice.Location = New System.Drawing.Point(10, 185)
        Me.lblRawPrice.Name = "lblRawPrice"
        Me.lblRawPrice.Size = New System.Drawing.Size(77, 13)
        Me.lblRawPrice.TabIndex = 26
        Me.lblRawPrice.Text = "Цена закупки"
        '
        'txtRawPrice
        '
        Me.txtRawPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtRawPrice.Location = New System.Drawing.Point(145, 182)
        Me.txtRawPrice.Name = "txtRawPrice"
        Me.txtRawPrice.ReadOnly = True
        Me.txtRawPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtRawPrice.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Цена продажи (за все)"
        '
        'nudSellPrice
        '
        Me.nudSellPrice.DecimalPlaces = 2
        Me.nudSellPrice.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSellPrice.Location = New System.Drawing.Point(266, 111)
        Me.nudSellPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSellPrice.Name = "nudSellPrice"
        Me.nudSellPrice.Size = New System.Drawing.Size(82, 20)
        Me.nudSellPrice.TabIndex = 23
        '
        'comboName
        '
        Me.comboName.FormattingEnabled = True
        Me.comboName.Location = New System.Drawing.Point(145, 6)
        Me.comboName.Name = "comboName"
        Me.comboName.Size = New System.Drawing.Size(203, 21)
        Me.comboName.Sorted = True
        Me.comboName.TabIndex = 32
        '
        'frmNewPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 209)
        Me.Controls.Add(Me.comboName)
        Me.Controls.Add(Me.nudSellPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRawPrice)
        Me.Controls.Add(Me.lblRawPrice)
        Me.Controls.Add(Me.lblProvider)
        Me.Controls.Add(Me.comboProvider)
        Me.Controls.Add(Me.comboUnits)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblMarginRbl)
        Me.Controls.Add(Me.lblMarginPc)
        Me.Controls.Add(Me.nudMarginPc)
        Me.Controls.Add(Me.nudMargin)
        Me.Controls.Add(Me.lblMargin)
        Me.Controls.Add(Me.nudPartPrice)
        Me.Controls.Add(Me.nudPartCount)
        Me.Controls.Add(Me.lblPartPrice)
        Me.Controls.Add(Me.lblPartCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewPart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Новая запчасть"
        CType(Me.nudMarginPc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMargin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPartPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPartCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSellPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMarginRbl As System.Windows.Forms.Label
    Friend WithEvents lblMarginPc As System.Windows.Forms.Label
    Friend WithEvents nudMarginPc As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMargin As System.Windows.Forms.Label
    Friend WithEvents nudPartPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPartCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPartPrice As System.Windows.Forms.Label
    Friend WithEvents lblPartCount As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents comboUnits As System.Windows.Forms.ComboBox
    Friend WithEvents comboProvider As System.Windows.Forms.ComboBox
    Friend WithEvents lblProvider As System.Windows.Forms.Label
    Friend WithEvents lblRawPrice As System.Windows.Forms.Label
    Friend WithEvents txtRawPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudSellPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents comboName As System.Windows.Forms.ComboBox
End Class
