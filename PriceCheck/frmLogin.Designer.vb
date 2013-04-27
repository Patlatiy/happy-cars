<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnterReadOnly = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(113, 70)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Войти"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 32)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Вас приветствуют ""Весёлые Машинки""! Пожалуйста, введите ваш пароль, либо войдите " & _
    "в режиме чтения."
        '
        'btnEnterReadOnly
        '
        Me.btnEnterReadOnly.Location = New System.Drawing.Point(194, 70)
        Me.btnEnterReadOnly.Name = "btnEnterReadOnly"
        Me.btnEnterReadOnly.Size = New System.Drawing.Size(149, 23)
        Me.btnEnterReadOnly.TabIndex = 2
        Me.btnEnterReadOnly.Text = "Войти в режиме чтения"
        Me.btnEnterReadOnly.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(12, 44)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(328, 20)
        Me.txtPass.TabIndex = 0
        Me.txtPass.UseSystemPasswordChar = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 102)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.btnEnterReadOnly)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Весёлые Машинки"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnterReadOnly As System.Windows.Forms.Button
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
End Class
