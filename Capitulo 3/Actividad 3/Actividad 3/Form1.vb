Public Class Actividad3

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        lblSueldoTotal.Text = Val(inputHoras.Text) * Val(inputDinero.Text) & " " & "Pesos"
    End Sub
End Class
