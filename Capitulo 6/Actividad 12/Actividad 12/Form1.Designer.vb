<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad12
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputImporte = New System.Windows.Forms.TextBox()
        Me.cboDescuentos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inputImporteNeto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(353, 348)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(145, 57)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ventas Global"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Importe:"
        '
        'inputImporte
        '
        Me.inputImporte.Location = New System.Drawing.Point(353, 154)
        Me.inputImporte.Name = "inputImporte"
        Me.inputImporte.Size = New System.Drawing.Size(121, 26)
        Me.inputImporte.TabIndex = 3
        '
        'cboDescuentos
        '
        Me.cboDescuentos.FormattingEnabled = True
        Me.cboDescuentos.Items.AddRange(New Object() {"10", "15", "20"})
        Me.cboDescuentos.Location = New System.Drawing.Point(353, 213)
        Me.cboDescuentos.Name = "cboDescuentos"
        Me.cboDescuentos.Size = New System.Drawing.Size(121, 26)
        Me.cboDescuentos.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descuento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Importe Neto:"
        '
        'inputImporteNeto
        '
        Me.inputImporteNeto.Location = New System.Drawing.Point(353, 271)
        Me.inputImporteNeto.Name = "inputImporteNeto"
        Me.inputImporteNeto.ReadOnly = True
        Me.inputImporteNeto.Size = New System.Drawing.Size(121, 26)
        Me.inputImporteNeto.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(69, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gracias por su consulta"
        '
        'Actividad12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(606, 417)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inputImporteNeto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDescuentos)
        Me.Controls.Add(Me.inputImporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Actividad12"
        Me.Text = "Actividad 12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents inputImporte As System.Windows.Forms.TextBox
    Friend WithEvents cboDescuentos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents inputImporteNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
