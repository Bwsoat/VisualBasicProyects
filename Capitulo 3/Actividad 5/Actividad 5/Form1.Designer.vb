<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad5
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
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.inputSueldo = New System.Windows.Forms.TextBox()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.lblAumentoSueldo = New System.Windows.Forms.Label()
        Me.lblRespuestaSueldo = New System.Windows.Forms.Label()
        Me.inputPorcentaje = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(353, 73)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(129, 69)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(14, 31)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(200, 17)
        Me.lblSueldo.TabIndex = 1
        Me.lblSueldo.Text = "Ingrese el sueldo actual:"
        '
        'inputSueldo
        '
        Me.inputSueldo.Location = New System.Drawing.Point(17, 73)
        Me.inputSueldo.Name = "inputSueldo"
        Me.inputSueldo.Size = New System.Drawing.Size(197, 23)
        Me.inputSueldo.TabIndex = 2
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(14, 112)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(277, 17)
        Me.lblPorcentaje.TabIndex = 3
        Me.lblPorcentaje.Text = "Ingrese el Porcentaje a Aumentar:"
        '
        'lblAumentoSueldo
        '
        Me.lblAumentoSueldo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblAumentoSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAumentoSueldo.Location = New System.Drawing.Point(271, 228)
        Me.lblAumentoSueldo.Name = "lblAumentoSueldo"
        Me.lblAumentoSueldo.Size = New System.Drawing.Size(200, 46)
        Me.lblAumentoSueldo.TabIndex = 4
        '
        'lblRespuestaSueldo
        '
        Me.lblRespuestaSueldo.AutoSize = True
        Me.lblRespuestaSueldo.Location = New System.Drawing.Point(271, 196)
        Me.lblRespuestaSueldo.Name = "lblRespuestaSueldo"
        Me.lblRespuestaSueldo.Size = New System.Drawing.Size(159, 17)
        Me.lblRespuestaSueldo.TabIndex = 5
        Me.lblRespuestaSueldo.Text = "El nuevo sueldo es:"
        '
        'inputPorcentaje
        '
        Me.inputPorcentaje.Location = New System.Drawing.Point(17, 152)
        Me.inputPorcentaje.Name = "inputPorcentaje"
        Me.inputPorcentaje.Size = New System.Drawing.Size(197, 23)
        Me.inputPorcentaje.TabIndex = 6
        '
        'Actividad5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(510, 292)
        Me.Controls.Add(Me.inputPorcentaje)
        Me.Controls.Add(Me.lblRespuestaSueldo)
        Me.Controls.Add(Me.lblAumentoSueldo)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.inputSueldo)
        Me.Controls.Add(Me.lblSueldo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Actividad5"
        Me.Text = "Actividad 5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents lblSueldo As System.Windows.Forms.Label
    Friend WithEvents inputSueldo As System.Windows.Forms.TextBox
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents lblAumentoSueldo As System.Windows.Forms.Label
    Friend WithEvents lblRespuestaSueldo As System.Windows.Forms.Label
    Friend WithEvents inputPorcentaje As System.Windows.Forms.TextBox

End Class
