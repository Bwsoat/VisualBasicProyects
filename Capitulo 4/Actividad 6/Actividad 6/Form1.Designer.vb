<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad6
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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.lblIngresarPeso = New System.Windows.Forms.Label()
        Me.inputPeso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMenos80 = New System.Windows.Forms.Label()
        Me.lblMas80 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(574, 61)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(136, 51)
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "&Calcular"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'lblIngresarPeso
        '
        Me.lblIngresarPeso.AutoSize = True
        Me.lblIngresarPeso.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold)
        Me.lblIngresarPeso.Location = New System.Drawing.Point(59, 55)
        Me.lblIngresarPeso.Name = "lblIngresarPeso"
        Me.lblIngresarPeso.Size = New System.Drawing.Size(135, 17)
        Me.lblIngresarPeso.TabIndex = 1
        Me.lblIngresarPeso.Text = "Ingrese el peso:"
        '
        'inputPeso
        '
        Me.inputPeso.Location = New System.Drawing.Point(62, 89)
        Me.inputPeso.Name = "inputPeso"
        Me.inputPeso.Size = New System.Drawing.Size(132, 23)
        Me.inputPeso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1)Cuantos pesan hasta 80kg ?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2)Cuantos pesan mas de 80  kg ?"
        '
        'lblMenos80
        '
        Me.lblMenos80.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblMenos80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMenos80.Location = New System.Drawing.Point(324, 208)
        Me.lblMenos80.Name = "lblMenos80"
        Me.lblMenos80.Size = New System.Drawing.Size(196, 34)
        Me.lblMenos80.TabIndex = 5
        Me.lblMenos80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMas80
        '
        Me.lblMas80.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblMas80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMas80.Location = New System.Drawing.Point(324, 291)
        Me.lblMas80.Name = "lblMas80"
        Me.lblMas80.Size = New System.Drawing.Size(196, 34)
        Me.lblMas80.TabIndex = 6
        Me.lblMas80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(574, 208)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(136, 51)
        Me.btnMostrar.TabIndex = 7
        Me.btnMostrar.Text = "&Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Actividad6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(736, 395)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lblMas80)
        Me.Controls.Add(Me.lblMenos80)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputPeso)
        Me.Controls.Add(Me.lblIngresarPeso)
        Me.Controls.Add(Me.btnCargar)
        Me.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Actividad6"
        Me.Text = "Actividad 6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents lblIngresarPeso As System.Windows.Forms.Label
    Friend WithEvents inputPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMenos80 As System.Windows.Forms.Label
    Friend WithEvents lblMas80 As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button

End Class
