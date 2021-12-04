Public Class Actividad4

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        'Calculamos los kilometros por hora para sacar la velocidad
        lblVelocidadKm.Text = Val(inputKm.Text) / Val(inputTiempo.Text) & " " & "Km/h"

        'Calculamos el consumo por kilometro multiplicando la velocidad por la cantidad de Gasoil
        lblConsumo.Text = Val(inputGasoil.Text) / Val(lblVelocidadKm.Text) & " " & "Litros por Km"
    End Sub
End Class
