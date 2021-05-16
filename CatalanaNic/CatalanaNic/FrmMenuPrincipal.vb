Public Class FrmMenuPrincipal
    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GbMenu.Enter

    End Sub

    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click
        FrmProducto.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmCiudad.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmUsuario.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbHora.Text = DateTime.Now()
    End Sub

    Private Sub lbHora_Click(sender As Object, e As EventArgs) Handles lbHora.Click

    End Sub
End Class