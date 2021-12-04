<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad7
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
        Me.inputPeso = New System.Windows.Forms.TextBox()
        Me.lblInputPeso = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputAltura = New System.Windows.Forms.TextBox()
        Me.lblResultadoIMC = New System.Windows.Forms.Label()
        Me.lblIMC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(345, 42)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(119, 56)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'inputPeso
        '
        Me.inputPeso.Location = New System.Drawing.Point(28, 58)
        Me.inputPeso.Name = "inputPeso"
        Me.inputPeso.Size = New System.Drawing.Size(139, 26)
        Me.inputPeso.TabIndex = 1
        '
        'lblInputPeso
        '
        Me.lblInputPeso.AutoSize = True
        Me.lblInputPeso.Location = New System.Drawing.Point(25, 32)
        Me.lblInputPeso.Name = "lblInputPeso"
        Me.lblInputPeso.Size = New System.Drawing.Size(147, 18)
        Me.lblInputPeso.TabIndex = 2
        Me.lblInputPeso.Text = "Ingrese su Peso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese su Altura:"
        '
        'inputAltura
        '
        Me.inputAltura.Location = New System.Drawing.Point(28, 133)
        Me.inputAltura.Name = "inputAltura"
        Me.inputAltura.Size = New System.Drawing.Size(139, 26)
        Me.inputAltura.TabIndex = 4
        '
        'lblResultadoIMC
        '
        Me.lblResultadoIMC.AutoSize = True
        Me.lblResultadoIMC.Location = New System.Drawing.Point(254, 191)
        Me.lblResultadoIMC.Name = "lblResultadoIMC"
        Me.lblResultadoIMC.Size = New System.Drawing.Size(157, 18)
        Me.lblResultadoIMC.TabIndex = 5
        Me.lblResultadoIMC.Text = "Ingrese su Altura:"
        '
        'lblIMC
        '
        Me.lblIMC.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIMC.Location = New System.Drawing.Point(257, 226)
        Me.lblIMC.Name = "lblIMC"
        Me.lblIMC.Size = New System.Drawing.Size(184, 54)
        Me.lblIMC.TabIndex = 6
        Me.lblIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Menor a 18.49 Infrapeso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "18.50 - 24.99 Peso Normal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "25.00 - 29.99 Sobrepeso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mayor 30.00 Obeso"
        '
        'Actividad7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(476, 306)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblIMC)
        Me.Controls.Add(Me.lblResultadoIMC)
        Me.Controls.Add(Me.inputAltura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInputPeso)
        Me.Controls.Add(Me.inputPeso)
        Me.Controls.Add(Me.btnCalcular)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Actividad7"
        Me.Text = "Actividad 7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents inputPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblInputPeso As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inputAltura As System.Windows.Forms.TextBox
    Friend WithEvents lblResultadoIMC As System.Windows.Forms.Label
    Friend WithEvents lblIMC As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
