Public Class FrmInicioSesion
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        FrmMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
