
Public Class FrmInicioSesion

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim Inicio As New InicioSesion
        Inicio.Inicio(txtUserName.Text, txtPassword.Text)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
