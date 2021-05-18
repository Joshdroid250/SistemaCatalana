Public Class FrmMenuPrincipal
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        FrmInicioSesion.Show()

    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Me.Hide()
        FrmProducto1.Show()
    End Sub
End Class