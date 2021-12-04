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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.lblIngresarNum = New System.Windows.Forms.Label()
        Me.inputNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSumPositivos = New System.Windows.Forms.Label()
        Me.lblMultiNegativos = New System.Windows.Forms.Label()
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
        'lblIngresarNum
        '
        Me.lblIngresarNum.AutoSize = True
        Me.lblIngresarNum.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold)
        Me.lblIngresarNum.Location = New System.Drawing.Point(59, 55)
        Me.lblIngresarNum.Name = "lblIngresarNum"
        Me.lblIngresarNum.Size = New System.Drawing.Size(166, 17)
        Me.lblIngresarNum.TabIndex = 1
        Me.lblIngresarNum.Text = "Ingrese un Numero:"
        '
        'inputNum
        '
        Me.inputNum.Location = New System.Drawing.Point(62, 89)
        Me.inputNum.Name = "inputNum"
        Me.inputNum.Size = New System.Drawing.Size(163, 23)
        Me.inputNum.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1)Total de la sumatoria de los  positivos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(359, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2)Total de la multiplicacion de los  negativos:"
        '
        'lblSumPositivos
        '
        Me.lblSumPositivos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSumPositivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumPositivos.Location = New System.Drawing.Point(343, 209)
        Me.lblSumPositivos.Name = "lblSumPositivos"
        Me.lblSumPositivos.Size = New System.Drawing.Size(196, 34)
        Me.lblSumPositivos.TabIndex = 5
        Me.lblSumPositivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMultiNegativos
        '
        Me.lblMultiNegativos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblMultiNegativos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMultiNegativos.Location = New System.Drawing.Point(377, 291)
        Me.lblMultiNegativos.Name = "lblMultiNegativos"
        Me.lblMultiNegativos.Size = New System.Drawing.Size(196, 34)
        Me.lblMultiNegativos.TabIndex = 6
        Me.lblMultiNegativos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(574, 209)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(136, 51)
        Me.btnMostrar.TabIndex = 7
        Me.btnMostrar.Text = "&Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Actividad7
        '
        Me.AcceptButton = Me.btnCargar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(749, 395)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lblMultiNegativos)
        Me.Controls.Add(Me.lblSumPositivos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputNum)
        Me.Controls.Add(Me.lblIngresarNum)
        Me.Controls.Add(Me.btnCargar)
        Me.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Actividad7"
        Me.Text = "Actividad 7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents lblIngresarNum As System.Windows.Forms.Label
    Friend WithEvents inputNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSumPositivos As System.Windows.Forms.Label
    Friend WithEvents lblMultiNegativos As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button

End Class
