Public Class Actividad10
    'Inicializamos varibles publicas para poder usarlas en todo el programa
    Public mayoresDeEdad As Integer, menoresDeEdad As Integer, promedioDeEdad As Integer, contadorDePromedios As Integer
    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        'el contadorDePromedios nos indicara por cuanto hay que dividir la suma de edades para sacar el promedio
        contadorDePromedios = contadorDePromedios + 1
        'promedioDeEdad va a sumar todas las edades 
        promedioDeEdad = promedioDeEdad + Val(inputEdad.Text)

        If Val(inputEdad.Text) >= 18 Then
            mayoresDeEdad = mayoresDeEdad + 1
        Else
            menoresDeEdad = menoresDeEdad + 1
        End If
        inputEdad.Text = ""
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        'Mostramos el valor de los contadores y promedios en las etiquetas
        lblCantidadMayores.Text = mayoresDeEdad

        lblCantidadMenores.Text = menoresDeEdad

        lblPromedio.Text = promedioDeEdad / contadorDePromedios
    End Sub
End Class
