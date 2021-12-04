Public Class Actividad13
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoria.SelectedIndexChanged
        Dim numCategoria As Integer
        numCategoria = Val(cboCategoria.SelectedIndex)
        Select Case numCategoria
            Case 0
                lblSueldoBasico.ForeColor = Color.Black
                lblSueldoBasico.Text = "70,000" & " Pesos"
            Case 1
                lblSueldoBasico.ForeColor = Color.Black
                lblSueldoBasico.Text = "120,000" & " Pesos"
            Case 2
                lblSueldoBasico.ForeColor = Color.Black
                lblSueldoBasico.Text = "150,000" & " Pesos"

        End Select
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
