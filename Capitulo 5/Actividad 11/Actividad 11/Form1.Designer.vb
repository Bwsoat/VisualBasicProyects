<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad11
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
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMujeres = New System.Windows.Forms.Label()
        Me.lblHombres = New System.Windows.Forms.Label()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(499, 52)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(125, 69)
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "&Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'inputNombre
        '
        Me.inputNombre.Location = New System.Drawing.Point(39, 52)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(152, 26)
        Me.inputNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(36, 20)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(155, 18)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Ingresar Nombre:"
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.cboSexo.Location = New System.Drawing.Point(221, 52)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(121, 26)
        Me.cboSexo.TabIndex = 3
        Me.cboSexo.Text = "Sexo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingresar Sexo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "3)Total de Empleados ?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "2)Cuantos Hombres hay?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "1)Cuantas Mujeres hay ?"
        '
        'lblMujeres
        '
        Me.lblMujeres.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMujeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMujeres.Location = New System.Drawing.Point(298, 173)
        Me.lblMujeres.Name = "lblMujeres"
        Me.lblMujeres.Size = New System.Drawing.Size(155, 36)
        Me.lblMujeres.TabIndex = 8
        Me.lblMujeres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHombres
        '
        Me.lblHombres.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblHombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHombres.Location = New System.Drawing.Point(298, 225)
        Me.lblHombres.Name = "lblHombres"
        Me.lblHombres.Size = New System.Drawing.Size(155, 36)
        Me.lblHombres.TabIndex = 9
        Me.lblHombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmpleados
        '
        Me.lblEmpleados.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpleados.Location = New System.Drawing.Point(298, 278)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(155, 36)
        Me.lblEmpleados.TabIndex = 10
        Me.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(499, 192)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(125, 69)
        Me.btnMostrar.TabIndex = 11
        Me.btnMostrar.Text = "&Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Actividad11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(654, 332)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lblEmpleados)
        Me.Controls.Add(Me.lblHombres)
        Me.Controls.Add(Me.lblMujeres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSexo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.inputNombre)
        Me.Controls.Add(Me.btnCargar)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Actividad11"
        Me.Text = "Actividad 11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents inputNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMujeres As System.Windows.Forms.Label
    Friend WithEvents lblHombres As System.Windows.Forms.Label
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button

End Class
