<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.dataDay = New System.Windows.Forms.DataGridView()
        Me.cmnDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnSum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dataDay1 = New System.Windows.Forms.DataGridView()
        Me.ComboPages = New System.Windows.Forms.ComboBox()
        Me.PrintTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dataNight = New System.Windows.Forms.DataGridView()
        Me.nDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nSum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataCash = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataDay1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataNight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "day summary"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = "test"
        '
        'dataDay
        '
        Me.dataDay.AllowUserToDeleteRows = False
        Me.dataDay.AllowUserToResizeColumns = False
        Me.dataDay.AllowUserToResizeRows = False
        Me.dataDay.BackgroundColor = System.Drawing.Color.White
        Me.dataDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataDay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dataDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmnDay, Me.cmnCount, Me.cmnSum})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDay.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataDay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataDay.EnableHeadersVisualStyles = False
        Me.dataDay.GridColor = System.Drawing.Color.Black
        Me.dataDay.Location = New System.Drawing.Point(18, 38)
        Me.dataDay.Margin = New System.Windows.Forms.Padding(0)
        Me.dataDay.Name = "dataDay"
        Me.dataDay.RowHeadersVisible = False
        Me.dataDay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataDay.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataDay.Size = New System.Drawing.Size(256, 60)
        Me.dataDay.StandardTab = True
        Me.dataDay.TabIndex = 7
        Me.dataDay.Visible = False
        '
        'cmnDay
        '
        Me.cmnDay.Frozen = True
        Me.cmnDay.HeaderText = "День"
        Me.cmnDay.Name = "cmnDay"
        Me.cmnDay.ReadOnly = True
        Me.cmnDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cmnDay.Width = 50
        '
        'cmnCount
        '
        Me.cmnCount.HeaderText = "Кол-во"
        Me.cmnCount.Name = "cmnCount"
        Me.cmnCount.ReadOnly = True
        '
        'cmnSum
        '
        Me.cmnSum.HeaderText = "Сумма"
        Me.cmnSum.Name = "cmnSum"
        Me.cmnSum.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Месячный отчёт"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(352, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dataDay1
        '
        Me.dataDay1.AllowUserToDeleteRows = False
        Me.dataDay1.AllowUserToResizeColumns = False
        Me.dataDay1.AllowUserToResizeRows = False
        Me.dataDay1.BackgroundColor = System.Drawing.Color.White
        Me.dataDay1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataDay1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataDay1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dataDay1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDay1.GridColor = System.Drawing.Color.Black
        Me.dataDay1.Location = New System.Drawing.Point(4, 42)
        Me.dataDay1.Name = "dataDay1"
        Me.dataDay1.RowHeadersVisible = False
        Me.dataDay1.Size = New System.Drawing.Size(600, 200)
        Me.dataDay1.TabIndex = 15
        Me.dataDay1.Visible = False
        '
        'ComboPages
        '
        Me.ComboPages.FormattingEnabled = True
        Me.ComboPages.Location = New System.Drawing.Point(392, 2)
        Me.ComboPages.Name = "ComboPages"
        Me.ComboPages.Size = New System.Drawing.Size(114, 21)
        Me.ComboPages.TabIndex = 16
        Me.ComboPages.Text = "Страница 1 из 1"
        '
        'PrintTimer
        '
        Me.PrintTimer.Interval = 1000
        '
        'dataNight
        '
        Me.dataNight.AllowUserToDeleteRows = False
        Me.dataNight.AllowUserToResizeColumns = False
        Me.dataNight.AllowUserToResizeRows = False
        Me.dataNight.BackgroundColor = System.Drawing.Color.White
        Me.dataNight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataNight.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dataNight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataNight.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nDay, Me.nCount, Me.nSum})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataNight.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataNight.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataNight.EnableHeadersVisualStyles = False
        Me.dataNight.GridColor = System.Drawing.Color.Black
        Me.dataNight.Location = New System.Drawing.Point(274, 38)
        Me.dataNight.Margin = New System.Windows.Forms.Padding(0)
        Me.dataNight.Name = "dataNight"
        Me.dataNight.RowHeadersVisible = False
        Me.dataNight.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataNight.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataNight.Size = New System.Drawing.Size(256, 60)
        Me.dataNight.StandardTab = True
        Me.dataNight.TabIndex = 17
        Me.dataNight.Visible = False
        '
        'nDay
        '
        Me.nDay.Frozen = True
        Me.nDay.HeaderText = "Ночь"
        Me.nDay.Name = "nDay"
        Me.nDay.ReadOnly = True
        Me.nDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nDay.Width = 50
        '
        'nCount
        '
        Me.nCount.HeaderText = "Кол-во"
        Me.nCount.Name = "nCount"
        Me.nCount.ReadOnly = True
        '
        'nSum
        '
        Me.nSum.HeaderText = "Сумма"
        Me.nSum.Name = "nSum"
        Me.nSum.ReadOnly = True
        '
        'dataCash
        '
        Me.dataCash.AllowUserToDeleteRows = False
        Me.dataCash.AllowUserToResizeColumns = False
        Me.dataCash.AllowUserToResizeRows = False
        Me.dataCash.BackgroundColor = System.Drawing.Color.White
        Me.dataCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataCash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dataCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataCash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataCash.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataCash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataCash.EnableHeadersVisualStyles = False
        Me.dataCash.GridColor = System.Drawing.Color.Black
        Me.dataCash.Location = New System.Drawing.Point(4, 35)
        Me.dataCash.Margin = New System.Windows.Forms.Padding(0)
        Me.dataCash.Name = "dataCash"
        Me.dataCash.RowHeadersVisible = False
        Me.dataCash.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataCash.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dataCash.Size = New System.Drawing.Size(604, 46)
        Me.dataCash.StandardTab = True
        Me.dataCash.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "Операция"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Дата"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Время"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "Приход"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Расход"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Комментарий"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 170
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(620, 503)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dataDay)
        Me.Controls.Add(Me.dataNight)
        Me.Controls.Add(Me.ComboPages)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataCash)
        Me.Controls.Add(Me.dataDay1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Отчёт"
        CType(Me.dataDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataDay1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataNight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents dataDay As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmnDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmnSum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dataDay1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboPages As System.Windows.Forms.ComboBox
    Friend WithEvents PrintTimer As System.Windows.Forms.Timer
    Friend WithEvents dataNight As System.Windows.Forms.DataGridView
    Friend WithEvents nDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nSum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataCash As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
