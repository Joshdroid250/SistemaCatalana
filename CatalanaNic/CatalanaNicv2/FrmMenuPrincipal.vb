Public Class FrmMenuPrincipal
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        FrmInicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        Me.Hide()
        FrmProducto1.Show()
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

    Private Sub lbHora_Click(sender As Object, e As EventArgs) Handles lbHora.Click
        lbHora.Text = DateTime.Now()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbHora.Text = DateTime.Now()
    End Sub

    Private Sub lbNombre_Click(sender As Object, e As EventArgs) Handles lbNombre.Click
        lbNombre.Text = Names.name
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        FrmCliente.Show()
    End Sub

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class