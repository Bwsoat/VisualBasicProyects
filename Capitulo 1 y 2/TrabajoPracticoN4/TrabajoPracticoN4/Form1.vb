Public Class TrabajoPracticoN4

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        'Cerramos la app
        End
    End Sub

    Private Sub btnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumar.Click
        'Sumas los dos valores
        btnTotal.Text = Val(inputNum1.Text) + Val(inputNum2.Text)

    End Sub

    Private Sub btnRestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestar.Click
        'Restamos los dos valores
        btnTotal.Text = Val(inputNum1.Text) - Val(inputNum2.Text)
    End Sub

    Private Sub btnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplicar.Click
        'Multiplicamos los dos valores
        btnTotal.Text = Val(inputNum1.Text) * Val(inputNum2.Text)
    End Sub

    Private Sub btnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDividir.Click
        'Dividimos los dos valores
        btnTotal.Text = Val(inputNum1.Text) / Val(inputNum2.Text)
    End Sub

    Private Sub btnPotencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPotencia.Click
        'Potencia de los dos valores
        btnTotal.Text = Val(inputNum1.Text) ^ Val(inputNum2.Text)
    End Sub
End Class
