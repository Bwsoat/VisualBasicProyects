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
        Me.lblBase = New System.Windows.Forms.Label()
        Me.inputBase = New System.Windows.Forms.TextBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblSuperficie = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.inputAltura = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(305, 67)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(196, 76)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Location = New System.Drawing.Point(38, 32)
        Me.lblBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(171, 20)
        Me.lblBase.TabIndex = 1
        Me.lblBase.Text = "Ingresar la Base:"
        '
        'inputBase
        '
        Me.inputBase.Location = New System.Drawing.Point(42, 67)
        Me.inputBase.Margin = New System.Windows.Forms.Padding(4)
        Me.inputBase.Name = "inputBase"
        Me.inputBase.Size = New System.Drawing.Size(160, 28)
        Me.inputBase.TabIndex = 2
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(38, 123)
        Me.lblAltura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(182, 20)
        Me.lblAltura.TabIndex = 3
        Me.lblAltura.Text = "Ingresar la altura:"
        '
        'lblSuperficie
        '
        Me.lblSuperficie.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSuperficie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSuperficie.Location = New System.Drawing.Point(301, 230)
        Me.lblSuperficie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuperficie.Name = "lblSuperficie"
        Me.lblSuperficie.Padding = New System.Windows.Forms.Padding(10)
        Me.lblSuperficie.Size = New System.Drawing.Size(200, 60)
        Me.lblSuperficie.TabIndex = 4
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(301, 177)
        Me.lblResultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(166, 20)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "La Superficie es:"
        '
        'inputAltura
        '
        Me.inputAltura.Location = New System.Drawing.Point(42, 169)
        Me.inputAltura.Margin = New System.Windows.Forms.Padding(4)
        Me.inputAltura.Name = "inputAltura"
        Me.inputAltura.Size = New System.Drawing.Size(160, 28)
        Me.inputAltura.TabIndex = 6
        '
        'Actividad1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 316)
        Me.Controls.Add(Me.inputAltura)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblSuperficie)
        Me.Controls.Add(Me.lblAltura)
        Me.Controls.Add(Me.inputBase)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.btnCalcular)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Actividad1"
        Me.Text = "Actividad 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents inputBase As System.Windows.Forms.TextBox
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents lblSuperficie As System.Windows.Forms.Label
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents inputAltura As System.Windows.Forms.TextBox

End Class
