<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxAzeitona = New System.Windows.Forms.CheckBox()
        Me.cbxQueijo = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.rdbNao = New System.Windows.Forms.RadioButton()
        Me.rdbSim = New System.Windows.Forms.RadioButton()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.cbxPimento = New System.Windows.Forms.CheckBox()
        Me.cmbPizza = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbxAzeitona
        '
        Me.cbxAzeitona.AutoSize = True
        Me.cbxAzeitona.Location = New System.Drawing.Point(211, 27)
        Me.cbxAzeitona.Name = "cbxAzeitona"
        Me.cbxAzeitona.Size = New System.Drawing.Size(87, 19)
        Me.cbxAzeitona.TabIndex = 0
        Me.cbxAzeitona.Text = "AZEITONAS"
        Me.cbxAzeitona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbxAzeitona.UseVisualStyleBackColor = True
        '
        'cbxQueijo
        '
        Me.cbxQueijo.AutoSize = True
        Me.cbxQueijo.Location = New System.Drawing.Point(211, 52)
        Me.cbxQueijo.Name = "cbxQueijo"
        Me.cbxQueijo.Size = New System.Drawing.Size(102, 19)
        Me.cbxQueijo.TabIndex = 1
        Me.cbxQueijo.Text = "QUEIJO EXTRA"
        Me.cbxQueijo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quantidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TEM DESCONTO?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PREÇÁRIO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(375, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MARGARITA: 6 EUROS; NAPOLITANA: 7 EUROS; ANCHOVAS: 8 EUROS."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CADA EXTRA: 1 EURO, PIMENTOS: 2 EUROS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "DESCONTO: 10%"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(25, 259)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'rdbNao
        '
        Me.rdbNao.AutoSize = True
        Me.rdbNao.Location = New System.Drawing.Point(128, 210)
        Me.rdbNao.Name = "rdbNao"
        Me.rdbNao.Size = New System.Drawing.Size(51, 19)
        Me.rdbNao.TabIndex = 9
        Me.rdbNao.TabStop = True
        Me.rdbNao.Text = "NÃO"
        Me.rdbNao.UseVisualStyleBackColor = True
        '
        'rdbSim
        '
        Me.rdbSim.AutoSize = True
        Me.rdbSim.Location = New System.Drawing.Point(25, 210)
        Me.rdbSim.Name = "rdbSim"
        Me.rdbSim.Size = New System.Drawing.Size(45, 19)
        Me.rdbSim.TabIndex = 10
        Me.rdbSim.TabStop = True
        Me.rdbSim.Text = "SIM"
        Me.rdbSim.UseVisualStyleBackColor = True
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(125, 127)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 23)
        Me.txtQuantidade.TabIndex = 11
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(128, 260)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(100, 23)
        Me.txtPreco.TabIndex = 12
        '
        'cbxPimento
        '
        Me.cbxPimento.AutoSize = True
        Me.cbxPimento.Location = New System.Drawing.Point(211, 77)
        Me.cbxPimento.Name = "cbxPimento"
        Me.cbxPimento.Size = New System.Drawing.Size(82, 19)
        Me.cbxPimento.TabIndex = 13
        Me.cbxPimento.Text = "PIMENTOS"
        Me.cbxPimento.UseVisualStyleBackColor = True
        '
        'cmbPizza
        '
        Me.cmbPizza.FormattingEnabled = True
        Me.cmbPizza.Items.AddRange(New Object() {"Margarita", "Napolitana", "Anchovas"})
        Me.cmbPizza.Location = New System.Drawing.Point(25, 27)
        Me.cmbPizza.Name = "cmbPizza"
        Me.cmbPizza.Size = New System.Drawing.Size(121, 23)
        Me.cmbPizza.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbPizza)
        Me.Controls.Add(Me.cbxPimento)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.rdbSim)
        Me.Controls.Add(Me.rdbNao)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxQueijo)
        Me.Controls.Add(Me.cbxAzeitona)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxAzeitona As CheckBox
    Friend WithEvents cbxQueijo As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents rdbNao As RadioButton
    Friend WithEvents rdbSim As RadioButton
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents cbxPimento As CheckBox
    Friend WithEvents cmbPizza As ComboBox
End Class
