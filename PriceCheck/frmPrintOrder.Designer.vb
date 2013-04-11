<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintOrder))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape18 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape17 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape16 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape15 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPrintDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblExecutor = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblExecutorPhone = New System.Windows.Forms.Label()
        Me.lblRecipientLabel = New System.Windows.Forms.Label()
        Me.lblRecipient = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblRecipientPhone = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblRecipientAddress = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.RectangleShape18, Me.RectangleShape17, Me.RectangleShape16, Me.RectangleShape15, Me.RectangleShape14, Me.RectangleShape13, Me.RectangleShape12, Me.RectangleShape11, Me.RectangleShape10, Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(593, 940)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 428
        Me.LineShape5.X2 = 565
        Me.LineShape5.Y1 = 893
        Me.LineShape5.Y2 = 893
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 27
        Me.LineShape4.X2 = 153
        Me.LineShape4.Y1 = 893
        Me.LineShape4.Y2 = 893
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 10
        Me.LineShape3.X2 = 584
        Me.LineShape3.Y1 = 840
        Me.LineShape3.Y2 = 840
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 10
        Me.LineShape2.X2 = 584
        Me.LineShape2.Y1 = 811
        Me.LineShape2.Y2 = 811
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 576
        Me.LineShape1.Y1 = 626
        Me.LineShape1.Y2 = 626
        '
        'RectangleShape18
        '
        Me.RectangleShape18.BackColor = System.Drawing.Color.White
        Me.RectangleShape18.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape18.Location = New System.Drawing.Point(246, 451)
        Me.RectangleShape18.Name = "RectangleShape2"
        Me.RectangleShape18.Size = New System.Drawing.Size(339, 31)
        '
        'RectangleShape17
        '
        Me.RectangleShape17.BackColor = System.Drawing.Color.White
        Me.RectangleShape17.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape17.Location = New System.Drawing.Point(8, 451)
        Me.RectangleShape17.Name = "RectangleShape1"
        Me.RectangleShape17.Size = New System.Drawing.Size(238, 31)
        '
        'RectangleShape16
        '
        Me.RectangleShape16.BackColor = System.Drawing.Color.White
        Me.RectangleShape16.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape16.Location = New System.Drawing.Point(246, 420)
        Me.RectangleShape16.Name = "RectangleShape2"
        Me.RectangleShape16.Size = New System.Drawing.Size(339, 31)
        '
        'RectangleShape15
        '
        Me.RectangleShape15.BackColor = System.Drawing.Color.White
        Me.RectangleShape15.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape15.Location = New System.Drawing.Point(8, 420)
        Me.RectangleShape15.Name = "RectangleShape1"
        Me.RectangleShape15.Size = New System.Drawing.Size(238, 31)
        '
        'RectangleShape14
        '
        Me.RectangleShape14.BackColor = System.Drawing.Color.White
        Me.RectangleShape14.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape14.Location = New System.Drawing.Point(246, 389)
        Me.RectangleShape14.Name = "RectangleShape2"
        Me.RectangleShape14.Size = New System.Drawing.Size(339, 31)
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BackColor = System.Drawing.Color.White
        Me.RectangleShape13.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape13.Location = New System.Drawing.Point(8, 389)
        Me.RectangleShape13.Name = "RectangleShape1"
        Me.RectangleShape13.Size = New System.Drawing.Size(238, 31)
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BackColor = System.Drawing.Color.White
        Me.RectangleShape12.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape12.Location = New System.Drawing.Point(246, 358)
        Me.RectangleShape12.Name = "RectangleShape2"
        Me.RectangleShape12.Size = New System.Drawing.Size(339, 31)
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BackColor = System.Drawing.Color.White
        Me.RectangleShape11.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape11.Location = New System.Drawing.Point(8, 358)
        Me.RectangleShape11.Name = "RectangleShape1"
        Me.RectangleShape11.Size = New System.Drawing.Size(238, 31)
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BackColor = System.Drawing.Color.White
        Me.RectangleShape10.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape10.Location = New System.Drawing.Point(246, 327)
        Me.RectangleShape10.Name = "RectangleShape2"
        Me.RectangleShape10.Size = New System.Drawing.Size(339, 31)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BackColor = System.Drawing.Color.White
        Me.RectangleShape9.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape9.Location = New System.Drawing.Point(8, 327)
        Me.RectangleShape9.Name = "RectangleShape1"
        Me.RectangleShape9.Size = New System.Drawing.Size(238, 31)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BackColor = System.Drawing.Color.White
        Me.RectangleShape8.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape8.Location = New System.Drawing.Point(246, 296)
        Me.RectangleShape8.Name = "RectangleShape2"
        Me.RectangleShape8.Size = New System.Drawing.Size(339, 31)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BackColor = System.Drawing.Color.White
        Me.RectangleShape7.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape7.Location = New System.Drawing.Point(8, 296)
        Me.RectangleShape7.Name = "RectangleShape1"
        Me.RectangleShape7.Size = New System.Drawing.Size(238, 31)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackColor = System.Drawing.Color.White
        Me.RectangleShape6.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape6.Location = New System.Drawing.Point(246, 265)
        Me.RectangleShape6.Name = "RectangleShape2"
        Me.RectangleShape6.Size = New System.Drawing.Size(339, 31)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.Color.White
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape5.Location = New System.Drawing.Point(8, 265)
        Me.RectangleShape5.Name = "RectangleShape1"
        Me.RectangleShape5.Size = New System.Drawing.Size(238, 31)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.White
        Me.RectangleShape4.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape4.Location = New System.Drawing.Point(246, 234)
        Me.RectangleShape4.Name = "RectangleShape2"
        Me.RectangleShape4.Size = New System.Drawing.Size(339, 31)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.White
        Me.RectangleShape3.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape3.Location = New System.Drawing.Point(8, 234)
        Me.RectangleShape3.Name = "RectangleShape1"
        Me.RectangleShape3.Size = New System.Drawing.Size(238, 31)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(246, 141)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(339, 93)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 141)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(238, 93)
        '
        'lblLine1
        '
        Me.lblLine1.AutoSize = True
        Me.lblLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblLine1.Location = New System.Drawing.Point(497, 0)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(96, 16)
        Me.lblLine1.TabIndex = 12
        Me.lblLine1.Text = "ООО «Пилот»"
        Me.lblLine1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "150065, г. Ярославль,"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(479, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ул. Папанина 5а"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(229, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Заявка на поставку"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Дата размещения поручения "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrintDate
        '
        Me.lblPrintDate.AutoSize = True
        Me.lblPrintDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPrintDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPrintDate.Location = New System.Drawing.Point(350, 79)
        Me.lblPrintDate.Name = "lblPrintDate"
        Me.lblPrintDate.Size = New System.Drawing.Size(99, 16)
        Me.lblPrintDate.TabIndex = 12
        Me.lblPrintDate.Text = "_____________"
        Me.lblPrintDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Наименования запасных частей"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Заявленная цена"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(252, 242)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 16)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.Text = "(цена)"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Дата доставки"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDate.Location = New System.Drawing.Point(252, 273)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(47, 16)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "(дата)"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 304)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Дополнительные условия"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblComment.Location = New System.Drawing.Point(252, 304)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(70, 16)
        Me.lblComment.TabIndex = 12
        Me.lblComment.Text = "(условия)"
        Me.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 335)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(209, 16)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Контактное лицо-исполнитель"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExecutor
        '
        Me.lblExecutor.AutoSize = True
        Me.lblExecutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblExecutor.Location = New System.Drawing.Point(252, 335)
        Me.lblExecutor.Name = "lblExecutor"
        Me.lblExecutor.Size = New System.Drawing.Size(47, 16)
        Me.lblExecutor.TabIndex = 12
        Me.lblExecutor.Text = "(ФИО)"
        Me.lblExecutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 366)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(200, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Конт. телефоны исполнителя"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExecutorPhone
        '
        Me.lblExecutorPhone.AutoSize = True
        Me.lblExecutorPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblExecutorPhone.Location = New System.Drawing.Point(252, 366)
        Me.lblExecutorPhone.Name = "lblExecutorPhone"
        Me.lblExecutorPhone.Size = New System.Drawing.Size(83, 16)
        Me.lblExecutorPhone.TabIndex = 12
        Me.lblExecutorPhone.Text = "(телефоны)"
        Me.lblExecutorPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipientLabel
        '
        Me.lblRecipientLabel.AutoSize = True
        Me.lblRecipientLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRecipientLabel.Location = New System.Drawing.Point(12, 397)
        Me.lblRecipientLabel.Name = "lblRecipientLabel"
        Me.lblRecipientLabel.Size = New System.Drawing.Size(202, 16)
        Me.lblRecipientLabel.TabIndex = 12
        Me.lblRecipientLabel.Text = "Контактное лицо-получатель"
        Me.lblRecipientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipient
        '
        Me.lblRecipient.AutoSize = True
        Me.lblRecipient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRecipient.Location = New System.Drawing.Point(252, 397)
        Me.lblRecipient.Name = "lblRecipient"
        Me.lblRecipient.Size = New System.Drawing.Size(47, 16)
        Me.lblRecipient.TabIndex = 12
        Me.lblRecipient.Text = "(ФИО)"
        Me.lblRecipient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 428)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(193, 16)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Конт. телефоны получателя"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipientPhone
        '
        Me.lblRecipientPhone.AutoSize = True
        Me.lblRecipientPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRecipientPhone.Location = New System.Drawing.Point(252, 428)
        Me.lblRecipientPhone.Name = "lblRecipientPhone"
        Me.lblRecipientPhone.Size = New System.Drawing.Size(83, 16)
        Me.lblRecipientPhone.TabIndex = 12
        Me.lblRecipientPhone.Text = "(телефоны)"
        Me.lblRecipientPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 459)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 16)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Адрес получателя"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipientAddress
        '
        Me.lblRecipientAddress.AutoSize = True
        Me.lblRecipientAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRecipientAddress.Location = New System.Drawing.Point(252, 459)
        Me.lblRecipientAddress.Name = "lblRecipientAddress"
        Me.lblRecipientAddress.Size = New System.Drawing.Size(55, 16)
        Me.lblRecipientAddress.TabIndex = 12
        Me.lblRecipientAddress.Text = "(адрес)"
        Me.lblRecipientAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 491)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(420, 16)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Обращаем ваше внимание: все графы должны быть заполнены."
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 526)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(394, 16)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "С условиями Заявки на поставку ознакомлены и согласны."
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 551)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(198, 16)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Клиент ____________________"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label27.Location = New System.Drawing.Point(317, 551)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(211, 16)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "_____________________________"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.Location = New System.Drawing.Point(100, 567)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 16)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "(подпись)"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label29.Location = New System.Drawing.Point(395, 567)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 16)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "(Ф.И.О)"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.Location = New System.Drawing.Point(443, 671)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(143, 16)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "150065, г. Ярославль,"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label31.Location = New System.Drawing.Point(472, 687)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(114, 16)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "ул. Папанина 5а"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label32.Location = New System.Drawing.Point(490, 655)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 16)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "ООО «Пилот»"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label33.Location = New System.Drawing.Point(243, 736)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(109, 16)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "Квитанция ____"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label34.Location = New System.Drawing.Point(12, 767)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(578, 16)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "Получено от _____________________________________________________________________" & _
    ""
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label35.Location = New System.Drawing.Point(270, 783)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 16)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "(Ф.И.О)"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label36.Location = New System.Drawing.Point(234, 812)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(124, 16)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "(сумма прописью)"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label37.Location = New System.Drawing.Point(67, 894)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 16)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "(дата)"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label38.Location = New System.Drawing.Point(465, 894)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(70, 16)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "(подпись)"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblParts.Location = New System.Drawing.Point(252, 147)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(78, 16)
        Me.lblParts.TabIndex = 12
        Me.lblParts.Text = "(запчасти)"
        '
        'frmPrintOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(593, 940)
        Me.Controls.Add(Me.lblParts)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblRecipientAddress)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblRecipientPhone)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblRecipient)
        Me.Controls.Add(Me.lblRecipientLabel)
        Me.Controls.Add(Me.lblExecutorPhone)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblExecutor)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPrintDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLine1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmPrintOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lblPrintDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLine1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblRecipientAddress As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblRecipientPhone As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblRecipient As System.Windows.Forms.Label
    Friend WithEvents lblRecipientLabel As System.Windows.Forms.Label
    Friend WithEvents lblExecutorPhone As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblExecutor As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape18 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape17 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape16 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape15 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape14 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape13 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape12 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape11 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblParts As System.Windows.Forms.Label
End Class
