<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actividad10
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
        Me.inputEdad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCantidadMayores = New System.Windows.Forms.Label()
        Me.lblCantidadMenores = New System.Windows.Forms.Label()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(504, 45)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(146, 59)
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "&Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'inputEdad
        '
        Me.inputEdad.Location = New System.Drawing.Point(15, 62)
        Me.inputEdad.Name = "inputEdad"
        Me.inputEdad.Size = New System.Drawing.Size(169, 26)
        Me.inputEdad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingresar Edad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "1)Cuantos Mayores hay ?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "2)Cuantos Menores hay ?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "3)Cual es el Promedio ?"
        '
        'lblCantidadMayores
        '
        Me.lblCantidadMayores.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblCantidadMayores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCantidadMayores.Location = New System.Drawing.Point(281, 198)
        Me.lblCantidadMayores.Name = "lblCantidadMayores"
        Me.lblCantidadMayores.Size = New System.Drawing.Size(177, 33)
        Me.lblCantidadMayores.TabIndex = 6
        Me.lblCantidadMayores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCantidadMenores
        '
        Me.lblCantidadMenores.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblCantidadMenores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCantidadMenores.Location = New System.Drawing.Point(281, 243)
        Me.lblCantidadMenores.Name = "lblCantidadMenores"
        Me.lblCantidadMenores.Size = New System.Drawing.Size(177, 33)
        Me.lblCantidadMenores.TabIndex = 7
        Me.lblCantidadMenores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPromedio
        '
        Me.lblPromedio.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPromedio.Location = New System.Drawing.Point(281, 286)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(177, 33)
        Me.lblPromedio.TabIndex = 8
        Me.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(504, 198)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(146, 59)
        Me.btnMostrar.TabIndex = 9
        Me.btnMostrar.Text = "&Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Actividad10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(730, 347)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lblPromedio)
        Me.Controls.Add(Me.lblCantidadMenores)
        Me.Controls.Add(Me.lblCantidadMayores)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputEdad)
        Me.Controls.Add(Me.btnCargar)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Actividad10"
        Me.Text = "Actividad 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents inputEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCantidadMayores As System.Windows.Forms.Label
    Friend WithEvents lblCantidadMenores As System.Windows.Forms.Label
    Friend WithEvents lblPromedio As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button

End Class
