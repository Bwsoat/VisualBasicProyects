<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnVioleta = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnFucsia = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.Red
        Me.btnRojo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRojo.Location = New System.Drawing.Point(102, 28)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(169, 65)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'btnAmarillo
        '
        Me.btnAmarillo.BackColor = System.Drawing.Color.Yellow
        Me.btnAmarillo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAmarillo.Location = New System.Drawing.Point(443, 119)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(169, 65)
        Me.btnAmarillo.TabIndex = 1
        Me.btnAmarillo.Text = "Amarillo"
        Me.btnAmarillo.UseVisualStyleBackColor = False
        '
        'btnVerde
        '
        Me.btnVerde.BackColor = System.Drawing.Color.Green
        Me.btnVerde.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerde.Location = New System.Drawing.Point(102, 119)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(169, 65)
        Me.btnVerde.TabIndex = 2
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = False
        '
        'btnVioleta
        '
        Me.btnVioleta.BackColor = System.Drawing.Color.Purple
        Me.btnVioleta.Location = New System.Drawing.Point(443, 211)
        Me.btnVioleta.Name = "btnVioleta"
        Me.btnVioleta.Size = New System.Drawing.Size(169, 65)
        Me.btnVioleta.TabIndex = 3
        Me.btnVioleta.Text = "Violeta"
        Me.btnVioleta.UseVisualStyleBackColor = False
        '
        'btnAzul
        '
        Me.btnAzul.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAzul.Location = New System.Drawing.Point(102, 211)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(169, 65)
        Me.btnAzul.TabIndex = 4
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = False
        '
        'btnFucsia
        '
        Me.btnFucsia.BackColor = System.Drawing.Color.Fuchsia
        Me.btnFucsia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFucsia.Location = New System.Drawing.Point(443, 28)
        Me.btnFucsia.Name = "btnFucsia"
        Me.btnFucsia.Size = New System.Drawing.Size(169, 65)
        Me.btnFucsia.TabIndex = 5
        Me.btnFucsia.Text = "Fucsia"
        Me.btnFucsia.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(287, 335)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(128, 42)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(724, 389)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnFucsia)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnVioleta)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnAmarillo)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "Form1"
        Me.Text = "TrabajoPracticoN2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRojo As System.Windows.Forms.Button
    Friend WithEvents btnAmarillo As System.Windows.Forms.Button
    Friend WithEvents btnVerde As System.Windows.Forms.Button
    Friend WithEvents btnVioleta As System.Windows.Forms.Button
    Friend WithEvents btnAzul As System.Windows.Forms.Button
    Friend WithEvents btnFucsia As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button

End Class
