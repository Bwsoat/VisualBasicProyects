Public Class Actividad6
    'Inicializamos dos varibles publicas para poder usarlas en todo el programa
    Public pesoMayor80 As Integer, pesoMenor80 As Integer
    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        'usamos un if para verificar cuales son los pesos menores a 80, y sumamos 1 al contador pesoMenor80 
        'de lo contrario sumanos uno al contador de pesoMayor80
        If Val(inputPeso.Text) <= 80 Then
            pesoMenor80 = pesoMenor80 + 1
        Else
            pesoMayor80 = pesoMayor80 + 1
        End If

    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        'Mostramos el valor de los contadores en las etiquetas
        lblMenos80.Text = pesoMenor80

        lblMas80.Text = pesoMayor80
    End Sub
End Class
