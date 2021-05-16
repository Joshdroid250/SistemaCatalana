Public Class FrmUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaNicDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.CatalanaNicDataSet.Usuario)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIDUsuario.Clear()
        txtPrimerNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtUserName.Clear()
        txtContraseña.Clear()
        txtCorreo.Clear()
        txtEstado.Clear()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim UserA As New Usuario
        Try
            UserA.IdUsuario = CInt(txtIDUsuario.Text)
            UserA.PrimerNombre = txtPrimerNombre.Text
            UserA.PrimerApellido = txtPrimerApellido.Text
            UserA.SegundoApellido = txtSegundoApellido.Text
            UserA.UserName = txtUserName.Text
            UserA.UserPwd = txtContraseña.Text
            UserA.Email = txtCorreo.Text
            UserA.Estado = CInt(txtEstado.Text)
            Me.UsuarioTableAdapter.AgregarUsuario(UserA.PrimerNombre, UserA.PrimerApellido, UserA.SegundoApellido, UserA.UserName, UserA.UserPwd, UserA.Email, UserA.Estado)
            MsgBox("Datos de Usuario Actualizados correctamente")
            Me.UsuarioTableAdapter.Fill(Me.CatalanaNicDataSet.Usuario)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al agregar")
        End Try
        Me.UsuarioTableAdapter.Fill(Me.CatalanaNicDataSet.Usuario)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim UserB As New Usuario
        Try
            UserB.IdUsuario = CInt(txtIDUsuario.Text)
            UserB.PrimerNombre = txtPrimerNombre.Text
            UserB.PrimerApellido = txtPrimerApellido.Text
            UserB.SegundoApellido = txtSegundoApellido.Text
            UserB.UserName = txtUserName.Text
            UserB.UserPwd = txtContraseña.Text
            UserB.Email = txtCorreo.Text
            UserB.Estado = CInt(txtEstado.Text)
            Me.UsuarioTableAdapter.BorrarUsuario(UserB.IdUsuario)
            MsgBox("Datos de Usuario Borrados Correctamente")
            Me.UsuarioTableAdapter.Fill(Me.CatalanaNicDataSet.Usuario)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error al borrar Usuario")
        End Try
        Me.UsuarioTableAdapter.Fill(Me.CatalanaNicDataSet.Usuario)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim UserU As New Usuario
        Try
            UserU.IdUsuario = CInt(txtIDUsuario.Text)
            UserU.PrimerNombre = txtPrimerNombre.Text
            UserU.PrimerApellido = txtPrimerApellido.Text
            UserU.SegundoApellido = txtSegundoApellido.Text
            UserU.UserName = txtUserName.Text
            UserU.UserPwd = txtContraseña.Text
            UserU.Email = txtCorreo.Text
            UserU.Estado = CInt(txtEstado.Text)
            Me.UsuarioTableAdapter.ActualizarUsuario(UserU.PrimerNombre, UserU.PrimerApellido, UserU.SegundoApellido, UserU.UserName, UserU.UserPwd, UserU.Email, UserU.Estado, UserU.IdUsuario)
            MsgBox("Los datos se actualizaron correctamente")
            Me.UsuarioTableAdapter.Fill(Me.CatalanaNicDataSet.Usuario)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error al actualizar datos de usuario")

        End Try
        Me.UsuarioTableAdapter.Fill(Me.CatalanaNicDataSet.Usuario)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class