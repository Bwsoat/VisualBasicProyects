Public Class Actividad12

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub cboDescuentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDescuentos.SelectedIndexChanged
        Dim comboBoxDescuento As Integer, Descuento As Integer
        comboBoxDescuento = cboDescuentos.SelectedIndex
        Select Case comboBoxDescuento
            Case 0
                Descuento = (Val(inputImporte.Text) * 10) / 100
                inputImporteNeto.Text = Val(inputImporte.Text) - Descuento
            Case 1
                Descuento = (Val(inputImporte.Text) * 15) / 100
                inputImporteNeto.Text = Val(inputImporte.Text) - Descuento
            Case 2
                Descuento = (Val(inputImporte.Text) * 20) / 100
                inputImporteNeto.Text = Val(inputImporte.Text) - Descuento
        End Select
    End Sub
End Class
