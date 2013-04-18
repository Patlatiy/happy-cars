<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtPartName = New System.Windows.Forms.TextBox()
        Me.lblMarginRbl = New System.Windows.Forms.Label()
        Me.txtSellPrice = New System.Windows.Forms.TextBox()
        Me.lblSellPrice = New System.Windows.Forms.Label()
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
        CType(Me.nudMarginPc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPartPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPartCount, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtPartName
        '
        Me.txtPartName.Location = New System.Drawing.Point(99, 6)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(250, 20)
        Me.txtPartName.TabIndex = 1
        '
        'lblMarginRbl
        '
        Me.lblMarginRbl.AutoSize = True
        Me.lblMarginRbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMarginRbl.Location = New System.Drawing.Point(332, 114)
        Me.lblMarginRbl.Name = "lblMarginRbl"
        Me.lblMarginRbl.Size = New System.Drawing.Size(16, 13)
        Me.lblMarginRbl.TabIndex = 24
        Me.lblMarginRbl.Text = "р."
        '
        'txtSellPrice
        '
        Me.txtSellPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSellPrice.Location = New System.Drawing.Point(147, 167)
        Me.txtSellPrice.Name = "txtSellPrice"
        Me.txtSellPrice.ReadOnly = True
        Me.txtSellPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtSellPrice.TabIndex = 27
        '
        'lblSellPrice
        '
        Me.lblSellPrice.AutoSize = True
        Me.lblSellPrice.Location = New System.Drawing.Point(12, 170)
        Me.lblSellPrice.Name = "lblSellPrice"
        Me.lblSellPrice.Size = New System.Drawing.Size(80, 13)
        Me.lblSellPrice.TabIndex = 26
        Me.lblSellPrice.Text = "Цена продажи"
        '
        'lblMarginPc
        '
        Me.lblMarginPc.AutoSize = True
        Me.lblMarginPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMarginPc.Location = New System.Drawing.Point(221, 115)
        Me.lblMarginPc.Name = "lblMarginPc"
        Me.lblMarginPc.Size = New System.Drawing.Size(15, 13)
        Me.lblMarginPc.TabIndex = 25
        Me.lblMarginPc.Text = "%"
        '
        'nudMarginPc
        '
        Me.nudMarginPc.Location = New System.Drawing.Point(155, 111)
        Me.nudMarginPc.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMarginPc.Name = "nudMarginPc"
        Me.nudMarginPc.Size = New System.Drawing.Size(65, 20)
        Me.nudMarginPc.TabIndex = 21
        '
        'nudMargin
        '
        Me.nudMargin.DecimalPlaces = 2
        Me.nudMargin.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMargin.Location = New System.Drawing.Point(266, 111)
        Me.nudMargin.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudMargin.Name = "nudMargin"
        Me.nudMargin.Size = New System.Drawing.Size(65, 20)
        Me.nudMargin.TabIndex = 22
        '
        'lblMargin
        '
        Me.lblMargin.AutoSize = True
        Me.lblMargin.Location = New System.Drawing.Point(9, 113)
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
        Me.lblPartPrice.Size = New System.Drawing.Size(77, 13)
        Me.lblPartPrice.TabIndex = 18
        Me.lblPartPrice.Text = "Цена закупки"
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
        Me.LineShape2.X1 = 16
        Me.LineShape2.X2 = 347
        Me.LineShape2.Y1 = 155
        Me.LineShape2.Y2 = 155
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(360, 200)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(303, 165)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(46, 23)
        Me.btnOK.TabIndex = 29
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'comboUnits
        '
        Me.comboUnits.FormattingEnabled = True
        Me.comboUnits.Location = New System.Drawing.Point(277, 32)
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
        'frmNewPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 200)
        Me.Controls.Add(Me.lblProvider)
        Me.Controls.Add(Me.comboProvider)
        Me.Controls.Add(Me.comboUnits)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblMarginRbl)
        Me.Controls.Add(Me.txtSellPrice)
        Me.Controls.Add(Me.lblSellPrice)
        Me.Controls.Add(Me.lblMarginPc)
        Me.Controls.Add(Me.nudMarginPc)
        Me.Controls.Add(Me.nudMargin)
        Me.Controls.Add(Me.lblMargin)
        Me.Controls.Add(Me.nudPartPrice)
        Me.Controls.Add(Me.nudPartCount)
        Me.Controls.Add(Me.lblPartPrice)
        Me.Controls.Add(Me.lblPartCount)
        Me.Controls.Add(Me.txtPartName)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPartName As System.Windows.Forms.TextBox
    Friend WithEvents lblMarginRbl As System.Windows.Forms.Label
    Friend WithEvents txtSellPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblSellPrice As System.Windows.Forms.Label
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
End Class
