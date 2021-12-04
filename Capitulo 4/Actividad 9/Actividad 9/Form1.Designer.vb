<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad9
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
        Me.inputNotas = New System.Windows.Forms.TextBox()
        Me.lblNotas = New System.Windows.Forms.Label()
        Me.lblResultadoNotas = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(389, 45)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(153, 61)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'inputNotas
        '
        Me.inputNotas.Location = New System.Drawing.Point(41, 80)
        Me.inputNotas.Name = "inputNotas"
        Me.inputNotas.Size = New System.Drawing.Size(264, 26)
        Me.inputNotas.TabIndex = 1
        '
        'lblNotas
        '
        Me.lblNotas.AutoSize = True
        Me.lblNotas.Location = New System.Drawing.Point(38, 43)
        Me.lblNotas.Name = "lblNotas"
        Me.lblNotas.Size = New System.Drawing.Size(207, 18)
        Me.lblNotas.TabIndex = 2
        Me.lblNotas.Text = "Ingrese las Notas(0/5):"
        '
        'lblResultadoNotas
        '
        Me.lblResultadoNotas.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblResultadoNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResultadoNotas.Location = New System.Drawing.Point(38, 175)
        Me.lblResultadoNotas.Name = "lblResultadoNotas"
        Me.lblResultadoNotas.Size = New System.Drawing.Size(267, 69)
        Me.lblResultadoNotas.TabIndex = 3
        Me.lblResultadoNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(389, 175)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(153, 61)
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "&Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Resultado de las Notas:"
        '
        'Actividad9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(575, 276)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lblResultadoNotas)
        Me.Controls.Add(Me.lblNotas)
        Me.Controls.Add(Me.inputNotas)
        Me.Controls.Add(Me.btnCalcular)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Actividad9"
        Me.Text = "Actividad 9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents inputNotas As System.Windows.Forms.TextBox
    Friend WithEvents lblNotas As System.Windows.Forms.Label
    Friend WithEvents lblResultadoNotas As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
