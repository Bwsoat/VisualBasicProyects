<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.inputNum1 = New System.Windows.Forms.TextBox()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.inputNum2 = New System.Windows.Forms.TextBox()
        Me.inputNum3 = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(404, 53)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(185, 73)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(51, 32)
        Me.lblNum1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(180, 20)
        Me.lblNum1.TabIndex = 1
        Me.lblNum1.Text = "Ingrese el 1° Nro:"
        '
        'inputNum1
        '
        Me.inputNum1.Location = New System.Drawing.Point(55, 76)
        Me.inputNum1.Margin = New System.Windows.Forms.Padding(4)
        Me.inputNum1.Name = "inputNum1"
        Me.inputNum1.Size = New System.Drawing.Size(176, 28)
        Me.inputNum1.TabIndex = 2
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(51, 119)
        Me.lblNum2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(180, 20)
        Me.lblNum2.TabIndex = 3
        Me.lblNum2.Text = "Ingrese el 2° Nro:"
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.Location = New System.Drawing.Point(51, 206)
        Me.lblNum3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(180, 20)
        Me.lblNum3.TabIndex = 4
        Me.lblNum3.Text = "Ingrese el 3° Nro:"
        '
        'inputNum2
        '
        Me.inputNum2.Location = New System.Drawing.Point(55, 160)
        Me.inputNum2.Margin = New System.Windows.Forms.Padding(4)
        Me.inputNum2.Name = "inputNum2"
        Me.inputNum2.Size = New System.Drawing.Size(176, 28)
        Me.inputNum2.TabIndex = 5
        '
        'inputNum3
        '
        Me.inputNum3.Location = New System.Drawing.Point(55, 248)
        Me.inputNum3.Margin = New System.Windows.Forms.Padding(4)
        Me.inputNum3.Name = "inputNum3"
        Me.inputNum3.Size = New System.Drawing.Size(176, 28)
        Me.inputNum3.TabIndex = 6
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(400, 160)
        Me.lblResultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(157, 20)
        Me.lblResultado.TabIndex = 7
        Me.lblResultado.Text = "el Promedio es:"
        '
        'lblPromedio
        '
        Me.lblPromedio.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPromedio.Location = New System.Drawing.Point(400, 223)
        Me.lblPromedio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(189, 63)
        Me.lblPromedio.TabIndex = 8
        '
        'Actividad1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(704, 316)
        Me.Controls.Add(Me.lblPromedio)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.inputNum3)
        Me.Controls.Add(Me.inputNum2)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.inputNum1)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Actividad1"
        Me.Text = "Actividad 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents inputNum1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblNum3 As System.Windows.Forms.Label
    Friend WithEvents inputNum2 As System.Windows.Forms.TextBox
    Friend WithEvents inputNum3 As System.Windows.Forms.TextBox
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents lblPromedio As System.Windows.Forms.Label

End Class
