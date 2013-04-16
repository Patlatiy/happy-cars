<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExecutor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExecutor))
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtPatron = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblPatron = New System.Windows.Forms.Label()
        Me.txt1stName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lbl1stName = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(91, 87)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(137, 20)
        Me.txtPhone.TabIndex = 11
        '
        'txtPatron
        '
        Me.txtPatron.Location = New System.Drawing.Point(91, 61)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.Size = New System.Drawing.Size(137, 20)
        Me.txtPatron.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(91, 9)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(137, 20)
        Me.txtLastName.TabIndex = 4
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(13, 90)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(52, 13)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Телефон"
        '
        'lblPatron
        '
        Me.lblPatron.AutoSize = True
        Me.lblPatron.Location = New System.Drawing.Point(13, 64)
        Me.lblPatron.Name = "lblPatron"
        Me.lblPatron.Size = New System.Drawing.Size(54, 13)
        Me.lblPatron.TabIndex = 6
        Me.lblPatron.Text = "Отчество"
        '
        'txt1stName
        '
        Me.txt1stName.Location = New System.Drawing.Point(91, 35)
        Me.txt1stName.Name = "txt1stName"
        Me.txt1stName.Size = New System.Drawing.Size(137, 20)
        Me.txt1stName.TabIndex = 9
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(13, 12)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(56, 13)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Фамилия"
        '
        'lbl1stName
        '
        Me.lbl1stName.AutoSize = True
        Me.lbl1stName.Location = New System.Drawing.Point(13, 38)
        Me.lbl1stName.Name = "lbl1stName"
        Me.lbl1stName.Size = New System.Drawing.Size(29, 13)
        Me.lbl1stName.TabIndex = 8
        Me.lbl1stName.Text = "Имя"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(173, 116)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(55, 23)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmExecutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 148)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtPatron)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblPatron)
        Me.Controls.Add(Me.txt1stName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lbl1stName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExecutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Исполнитель"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPatron As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblPatron As System.Windows.Forms.Label
    Friend WithEvents txt1stName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lbl1stName As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
