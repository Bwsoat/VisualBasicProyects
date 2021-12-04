<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad4
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
        Me.lblkilometros = New System.Windows.Forms.Label()
        Me.inputKm = New System.Windows.Forms.TextBox()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputTiempo = New System.Windows.Forms.TextBox()
        Me.inputGasoil = New System.Windows.Forms.TextBox()
        Me.lblResultadoV = New System.Windows.Forms.Label()
        Me.lblResultadoKm = New System.Windows.Forms.Label()
        Me.lblVelocidadKm = New System.Windows.Forms.Label()
        Me.lblConsumo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(396, 41)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(189, 67)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblkilometros
        '
        Me.lblkilometros.AutoSize = True
        Me.lblkilometros.Location = New System.Drawing.Point(29, 28)
        Me.lblkilometros.Name = "lblkilometros"
        Me.lblkilometros.Size = New System.Drawing.Size(306, 18)
        Me.lblkilometros.TabIndex = 1
        Me.lblkilometros.Text = "Ingrese la Distancia(En Kilometros):"
        '
        'inputKm
        '
        Me.inputKm.Location = New System.Drawing.Point(32, 62)
        Me.inputKm.Name = "inputKm"
        Me.inputKm.Size = New System.Drawing.Size(203, 26)
        Me.inputKm.TabIndex = 2
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Location = New System.Drawing.Point(29, 111)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(251, 18)
        Me.lblHoras.TabIndex = 3
        Me.lblHoras.Text = "Ingrese el Tiempo(En Horas):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese la cantidad de Gasoil:"
        '
        'inputTiempo
        '
        Me.inputTiempo.Location = New System.Drawing.Point(32, 152)
        Me.inputTiempo.Name = "inputTiempo"
        Me.inputTiempo.Size = New System.Drawing.Size(203, 26)
        Me.inputTiempo.TabIndex = 5
        '
        'inputGasoil
        '
        Me.inputGasoil.Location = New System.Drawing.Point(32, 247)
        Me.inputGasoil.Name = "inputGasoil"
        Me.inputGasoil.Size = New System.Drawing.Size(203, 26)
        Me.inputGasoil.TabIndex = 6
        '
        'lblResultadoV
        '
        Me.lblResultadoV.AutoSize = True
        Me.lblResultadoV.Location = New System.Drawing.Point(29, 307)
        Me.lblResultadoV.Name = "lblResultadoV"
        Me.lblResultadoV.Size = New System.Drawing.Size(91, 18)
        Me.lblResultadoV.TabIndex = 7
        Me.lblResultadoV.Text = "Velocidad:"
        '
        'lblResultadoKm
        '
        Me.lblResultadoKm.AutoSize = True
        Me.lblResultadoKm.Location = New System.Drawing.Point(357, 307)
        Me.lblResultadoKm.Name = "lblResultadoKm"
        Me.lblResultadoKm.Size = New System.Drawing.Size(155, 18)
        Me.lblResultadoKm.TabIndex = 8
        Me.lblResultadoKm.Text = "Consumo por Km:"
        '
        'lblVelocidadKm
        '
        Me.lblVelocidadKm.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVelocidadKm.Location = New System.Drawing.Point(30, 339)
        Me.lblVelocidadKm.Name = "lblVelocidadKm"
        Me.lblVelocidadKm.Size = New System.Drawing.Size(113, 50)
        Me.lblVelocidadKm.TabIndex = 9
        '
        'lblConsumo
        '
        Me.lblConsumo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblConsumo.Location = New System.Drawing.Point(357, 339)
        Me.lblConsumo.Name = "lblConsumo"
        Me.lblConsumo.Size = New System.Drawing.Size(113, 50)
        Me.lblConsumo.TabIndex = 10
        '
        'Actividad4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(661, 414)
        Me.Controls.Add(Me.lblConsumo)
        Me.Controls.Add(Me.lblVelocidadKm)
        Me.Controls.Add(Me.lblResultadoKm)
        Me.Controls.Add(Me.lblResultadoV)
        Me.Controls.Add(Me.inputGasoil)
        Me.Controls.Add(Me.inputTiempo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHoras)
        Me.Controls.Add(Me.inputKm)
        Me.Controls.Add(Me.lblkilometros)
        Me.Controls.Add(Me.btnCalcular)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Actividad4"
        Me.Text = "Actividad 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents lblkilometros As System.Windows.Forms.Label
    Friend WithEvents inputKm As System.Windows.Forms.TextBox
    Friend WithEvents lblHoras As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inputTiempo As System.Windows.Forms.TextBox
    Friend WithEvents inputGasoil As System.Windows.Forms.TextBox
    Friend WithEvents lblResultadoV As System.Windows.Forms.Label
    Friend WithEvents lblResultadoKm As System.Windows.Forms.Label
    Friend WithEvents lblVelocidadKm As System.Windows.Forms.Label
    Friend WithEvents lblConsumo As System.Windows.Forms.Label

End Class
