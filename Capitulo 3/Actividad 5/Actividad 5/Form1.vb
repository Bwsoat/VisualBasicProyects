Public Class Actividad5

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        'Declaramos una variable para almacenar el porcentaje de aumento y lo sumamos al sueldo
        Dim porcentaje As Integer
        porcentaje = (Val(inputSueldo.Text) * Val(inputPorcentaje.Text)) / 100
        lblAumentoSueldo.Text = Val(inputSueldo.Text) + porcentaje & " " & "Pesos"
    End Sub
End Class
