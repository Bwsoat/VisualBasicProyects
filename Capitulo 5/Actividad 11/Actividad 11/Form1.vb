Public Class Actividad11
    'Inicializamos varibles publicas para poder usarlas en todo el programa
    Public contadorMujeres As Integer, contadorHombres As Integer, totalDeEmpleados As Integer, comboBoxSexo As Integer
    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        comboBoxSexo = cboSexo.SelectedIndex

        If comboBoxSexo = 0 Then
            contadorHombres = contadorHombres + 1
            totalDeEmpleados = totalDeEmpleados + 1
        ElseIf comboBoxSexo = 1 Then
            contadorMujeres = contadorMujeres + 1
            totalDeEmpleados = totalDeEmpleados + 1
        End If
        inputNombre.Text = ""

    End Sub

    Private Sub btnMostrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        'Mostramos los contadores y el promedio dentro de las etiquetas
        lblMujeres.Text = contadorMujeres
        lblHombres.Text = contadorHombres
        lblEmpleados.Text = totalDeEmpleados
    End Sub
End Class
