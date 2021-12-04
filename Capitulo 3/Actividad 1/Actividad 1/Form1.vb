Public Class Actividad1

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        lblPromedio.Text = (Val(inputNum1.Text) + Val(inputNum2.Text) + Val(inputNum3.Text)) / 3
    End Sub
End Class
