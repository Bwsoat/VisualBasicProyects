Public Class Actividad1

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        lblSuperficie.Text = Val(inputBase.Text) * Val(inputAltura.Text)
    End Sub
End Class
