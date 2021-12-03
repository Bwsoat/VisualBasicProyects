<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrabajoPracticoN3
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.btnMostrarDatos = New System.Windows.Forms.Button()
        Me.lblNombreApellido = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.inputApellido = New System.Windows.Forms.TextBox()
        Me.etiquetaConDatos = New System.Windows.Forms.Label()
        Me.lblApeNom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(46, 51)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(91, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(46, 106)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(94, 20)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido:"
        '
        'btnMostrarDatos
        '
        Me.btnMostrarDatos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnMostrarDatos.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnMostrarDatos.Location = New System.Drawing.Point(194, 198)
        Me.btnMostrarDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMostrarDatos.Name = "btnMostrarDatos"
        Me.btnMostrarDatos.Size = New System.Drawing.Size(232, 50)
        Me.btnMostrarDatos.TabIndex = 2
        Me.btnMostrarDatos.Text = "Mostrar Datos"
        Me.btnMostrarDatos.UseVisualStyleBackColor = False
        '
        'lblNombreApellido
        '
        Me.lblNombreApellido.AutoSize = True
        Me.lblNombreApellido.Location = New System.Drawing.Point(46, 291)
        Me.lblNombreApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreApellido.Name = "lblNombreApellido"
        Me.lblNombreApellido.Size = New System.Drawing.Size(192, 20)
        Me.lblNombreApellido.TabIndex = 3
        Me.lblNombreApellido.Text = "Nombre y Apellido:"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCerrar.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnCerrar.Location = New System.Drawing.Point(314, 374)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(134, 39)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'inputNombre
        '
        Me.inputNombre.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.inputNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombre.Location = New System.Drawing.Point(170, 51)
        Me.inputNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(254, 28)
        Me.inputNombre.TabIndex = 5
        '
        'inputApellido
        '
        Me.inputApellido.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.inputApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputApellido.Location = New System.Drawing.Point(170, 106)
        Me.inputApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inputApellido.Name = "inputApellido"
        Me.inputApellido.Size = New System.Drawing.Size(256, 28)
        Me.inputApellido.TabIndex = 6
        '
        'etiquetaConDatos
        '
        Me.etiquetaConDatos.AutoSize = True
        Me.etiquetaConDatos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.etiquetaConDatos.Location = New System.Drawing.Point(232, 291)
        Me.etiquetaConDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.etiquetaConDatos.Name = "etiquetaConDatos"
        Me.etiquetaConDatos.Size = New System.Drawing.Size(0, 20)
        Me.etiquetaConDatos.TabIndex = 7
        '
        'lblApeNom
        '
        Me.lblApeNom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblApeNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblApeNom.Location = New System.Drawing.Point(242, 291)
        Me.lblApeNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApeNom.Name = "lblApeNom"
        Me.lblApeNom.Size = New System.Drawing.Size(206, 21)
        Me.lblApeNom.TabIndex = 8
        '
        'TrabajoPracticoN3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(506, 426)
        Me.Controls.Add(Me.lblApeNom)
        Me.Controls.Add(Me.etiquetaConDatos)
        Me.Controls.Add(Me.inputApellido)
        Me.Controls.Add(Me.inputNombre)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblNombreApellido)
        Me.Controls.Add(Me.btnMostrarDatos)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TrabajoPracticoN3"
        Me.Text = "TrabajoPracticoN3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents btnMostrarDatos As System.Windows.Forms.Button
    Friend WithEvents lblNombreApellido As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents inputNombre As System.Windows.Forms.TextBox
    Friend WithEvents inputApellido As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaConDatos As System.Windows.Forms.Label
    Friend WithEvents lblApeNom As System.Windows.Forms.Label

End Class
