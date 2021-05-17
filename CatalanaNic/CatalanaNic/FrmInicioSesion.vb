Public Class FrmInicioSesion
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Me.Hide()
        FrmMenuPrincipal.Show()
    End Sub
End Class