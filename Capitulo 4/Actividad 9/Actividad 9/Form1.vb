Public Class Actividad9
    Public promedioNotas As Integer, contadorDeNotas As Integer
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        promedioNotas = promedioNotas + Val(inputNotas.Text)
        inputNotas.Text = ""
        contadorDeNotas = contadorDeNotas + 1
        lblNotas.Text = "Ingrese las Notas(" & contadorDeNotas & "/5):"
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        promedioNotas = promedioNotas / 5
        If promedioNotas >= 1 And promedioNotas <= 2 Then
            lblResultadoNotas.Text = "Examen a febrero con: " & promedioNotas

        ElseIf promedioNotas >= 3 And promedioNotas <= 6 Then
            lblResultadoNotas.Text = "Examen a diciembre con: " & promedioNotas

        ElseIf promedioNotas >= 7 And promedioNotas <= 11 Then
            lblResultadoNotas.Text = "Aprueba con: " & promedioNotas

        ElseIf promedioNotas >= 12 Then
            lblResultadoNotas.Text = "Aprueba con Honores con: " & promedioNotas

        End If
    End Sub
End Class
