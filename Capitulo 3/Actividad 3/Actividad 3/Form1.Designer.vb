<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad3
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
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.inputHoras = New System.Windows.Forms.TextBox()
        Me.lblDinero = New System.Windows.Forms.Label()
        Me.inputDinero = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblSueldoTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoras.Location = New System.Drawing.Point(30, 42)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(247, 18)
        Me.lblHoras.TabIndex = 0
        Me.lblHoras.Text = "Ingrese la cantidad de horas:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(306, 42)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(162, 50)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'inputHoras
        '
        Me.inputHoras.Location = New System.Drawing.Point(34, 78)
        Me.inputHoras.Name = "inputHoras"
        Me.inputHoras.Size = New System.Drawing.Size(243, 28)
        Me.inputHoras.TabIndex = 2
        '
        'lblDinero
        '
        Me.lblDinero.AutoSize = True
        Me.lblDinero.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinero.Location = New System.Drawing.Point(30, 129)
        Me.lblDinero.Name = "lblDinero"
        Me.lblDinero.Size = New System.Drawing.Size(217, 18)
        Me.lblDinero.TabIndex = 3
        Me.lblDinero.Text = "Ingrese el valor por hora:"
        '
        'inputDinero
        '
        Me.inputDinero.Location = New System.Drawing.Point(33, 168)
        Me.inputDinero.Name = "inputDinero"
        Me.inputDinero.Size = New System.Drawing.Size(243, 28)
        Me.inputDinero.TabIndex = 4
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(303, 129)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(112, 18)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "El Sueldo es:"
        '
        'lblSueldoTotal
        '
        Me.lblSueldoTotal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSueldoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSueldoTotal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoTotal.Location = New System.Drawing.Point(303, 168)
        Me.lblSueldoTotal.Name = "lblSueldoTotal"
        Me.lblSueldoTotal.Padding = New System.Windows.Forms.Padding(10, 10, 20, 20)
        Me.lblSueldoTotal.Size = New System.Drawing.Size(165, 49)
        Me.lblSueldoTotal.TabIndex = 6
        '
        'Actividad3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(502, 245)
        Me.Controls.Add(Me.lblSueldoTotal)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.inputDinero)
        Me.Controls.Add(Me.lblDinero)
        Me.Controls.Add(Me.inputHoras)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblHoras)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Actividad3"
        Me.Text = "Actividad 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHoras As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents inputHoras As System.Windows.Forms.TextBox
    Friend WithEvents lblDinero As System.Windows.Forms.Label
    Friend WithEvents inputDinero As System.Windows.Forms.TextBox
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents lblSueldoTotal As System.Windows.Forms.Label

End Class
