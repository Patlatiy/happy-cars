<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagePasswords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManagePasswords))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblMasterPassword = New System.Windows.Forms.Label()
        Me.txtMasterPassword = New System.Windows.Forms.TextBox()
        Me.lblGirlPassword = New System.Windows.Forms.Label()
        Me.txtGirlPassword = New System.Windows.Forms.TextBox()
        Me.lblBKPassword = New System.Windows.Forms.Label()
        Me.txtBKPassword = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(139, 84)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblMasterPassword
        '
        Me.lblMasterPassword.AutoSize = True
        Me.lblMasterPassword.Location = New System.Drawing.Point(12, 9)
        Me.lblMasterPassword.Name = "lblMasterPassword"
        Me.lblMasterPassword.Size = New System.Drawing.Size(91, 13)
        Me.lblMasterPassword.TabIndex = 1
        Me.lblMasterPassword.Text = "Пароль мастера"
        '
        'txtMasterPassword
        '
        Me.txtMasterPassword.Location = New System.Drawing.Point(126, 6)
        Me.txtMasterPassword.Name = "txtMasterPassword"
        Me.txtMasterPassword.Size = New System.Drawing.Size(169, 20)
        Me.txtMasterPassword.TabIndex = 1
        '
        'lblGirlPassword
        '
        Me.lblGirlPassword.AutoSize = True
        Me.lblGirlPassword.Location = New System.Drawing.Point(12, 35)
        Me.lblGirlPassword.Name = "lblGirlPassword"
        Me.lblGirlPassword.Size = New System.Drawing.Size(90, 13)
        Me.lblGirlPassword.TabIndex = 1
        Me.lblGirlPassword.Text = "Пароль кассира"
        '
        'txtGirlPassword
        '
        Me.txtGirlPassword.Location = New System.Drawing.Point(126, 32)
        Me.txtGirlPassword.Name = "txtGirlPassword"
        Me.txtGirlPassword.Size = New System.Drawing.Size(169, 20)
        Me.txtGirlPassword.TabIndex = 2
        '
        'lblBKPassword
        '
        Me.lblBKPassword.AutoSize = True
        Me.lblBKPassword.Location = New System.Drawing.Point(12, 61)
        Me.lblBKPassword.Name = "lblBKPassword"
        Me.lblBKPassword.Size = New System.Drawing.Size(104, 13)
        Me.lblBKPassword.TabIndex = 1
        Me.lblBKPassword.Text = "Пароль бухгалтера"
        '
        'txtBKPassword
        '
        Me.txtBKPassword.Location = New System.Drawing.Point(126, 58)
        Me.txtBKPassword.Name = "txtBKPassword"
        Me.txtBKPassword.Size = New System.Drawing.Size(169, 20)
        Me.txtBKPassword.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(220, 84)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmManagePasswords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 116)
        Me.Controls.Add(Me.txtBKPassword)
        Me.Controls.Add(Me.lblBKPassword)
        Me.Controls.Add(Me.txtGirlPassword)
        Me.Controls.Add(Me.lblGirlPassword)
        Me.Controls.Add(Me.txtMasterPassword)
        Me.Controls.Add(Me.lblMasterPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManagePasswords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Имена, явки, пароли"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblMasterPassword As System.Windows.Forms.Label
    Friend WithEvents txtMasterPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblGirlPassword As System.Windows.Forms.Label
    Friend WithEvents txtGirlPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblBKPassword As System.Windows.Forms.Label
    Friend WithEvents txtBKPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
