Public Class Actividad7

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        lblIMC.Text = Val(inputPeso.Text) / Val(inputAltura.Text) ^ 2
    End Sub
End Class
