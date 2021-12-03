Public Class TrabajoPracticoN3

    Private Sub btnMostrarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarDatos.Click
        'Cambiamos el texto de lblApeNom por lo que el usuario ingreso en los inputs.
        lblApeNom.Text = inputNombre.Text & " " & inputApellido.Text
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        'Cerramos el programa, le dan click al boton cerrar
        End
    End Sub
End Class
