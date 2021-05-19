Public Class FrmMenuPrincipal
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        FrmInicioSesion.Show()

    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Me.Close()
        FrmProducto1.Show()
    End Sub

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        FrmInicioSesion.Show()
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        Me.Hide()
        FrmUsuario.Show()
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        Me.Hide()
        FrmCiudad.Show()
    End Sub
End Class