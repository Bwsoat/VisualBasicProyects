Public Class Actividad7
    'Inicializamos dos varibles publicas para poder usarlas en todo el programa
    Public sumaDePositivos As Integer = 0, multiDeNegativos As Integer = 1
    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        'Usamos un if para verificar cuales son los Numeros positivos, y los sumamos entre si 
        'de lo contrario multiplicamos los negativos
        If Val(inputNum.Text) >= 0 Then
            sumaDePositivos = sumaDePositivos + Val(inputNum.Text)
        Else
            multiDeNegativos = multiDeNegativos * Val(inputNum.Text)
        End If
        inputNum.Text = ""
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        'Mostramos el valor de las operaciones en las etiquetas
        lblSumPositivos.Text = sumaDePositivos

        lblMultiNegativos.Text = multiDeNegativos
    End Sub
End Class
