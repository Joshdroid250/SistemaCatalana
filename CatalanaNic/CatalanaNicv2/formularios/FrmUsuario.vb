Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FrmUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.CatalanaDataSet.Usuario)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            txtID.Clear()
            txtNombre.Clear()
            txtPrimerApe.Clear()
            txtSegundoApe.Clear()
            txtUserName.Clear()
            txtPWD.Clear()
            txtCorreo.Clear()
            txtEstado.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error critico")
        End Try


    End Sub

    Private Sub FrmUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMenuPrincipal.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim UserA As New Usuario
        Try
            UserA.IdUsuario = CInt(txtID.Text)
            UserA.PrimerNombre = txtNombre.Text
            UserA.PrimerApellido = txtPrimerApe.Text
            UserA.SegundoApellido = txtSegundoApe.Text
            UserA.UserName = txtUserName.Text
            UserA.UserPwd = txtPWD.Text
            UserA.Email = txtCorreo.Text
            UserA.Estado = CInt(txtEstado.Text)
            MsgBox("Usuario Agregar correctamente")
            Me.UsuarioTableAdapter.AgregarUsuario(UserA.PrimerNombre, UserA.PrimerApellido, UserA.SegundoApellido, UserA.UserName, UserA.UserPwd, UserA.Email, UserA.Estado)
            Me.UsuarioTableAdapter.Fill(Me.CatalanaDataSet.Usuario)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al agregar Usuario")
        End Try
        Me.UsuarioTableAdapter.Fill(Me.CatalanaDataSet.Usuario)

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim bo As New Usuario
        Try
            bo.IdUsuario = CInt(txtID.Text)
            MsgBox("El Usuario se borro")
            Me.UsuarioTableAdapter.BorrarUsuario(bo.IdUsuario)
            Me.UsuarioTableAdapter.Fill(Me.CatalanaDataSet.Usuario)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al eliminar al Usuario")
        End Try
        Me.UsuarioTableAdapter.Fill(Me.CatalanaDataSet.Usuario)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim up As New Usuario
        Try
            up.IdUsuario = CInt(txtID.Text)
            up.PrimerNombre = txtNombre.Text
            up.PrimerApellido = txtPrimerApe.Text
            up.SegundoApellido = txtSegundoApe.Text
            up.UserName = txtUserName.Text
            up.UserPwd = txtPWD.Text
            up.Email = txtCorreo.Text
            up.Estado = CInt(txtEstado.Text)
            MsgBox("Actualizacion de usuario correcta")
            Me.UsuarioTableAdapter.ActualizarUsuario(
                up.PrimerNombre,
                up.PrimerApellido,
                up.SegundoApellido,
                up.UserName,
                up.UserPwd,
                up.Email,
                up.Estado, up.IdUsuario)
            Me.UsuarioTableAdapter.Fill(Me.CatalanaDataSet.Usuario)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de actualizacion de datos")
        End Try
        Me.UsuarioTableAdapter.Fill(Me.CatalanaDataSet.Usuario)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim bus As New Usuario
        Try
            bus.IdUsuario = CInt(txtID.Text)
            Me.UsuarioTableAdapter.BuscarUsuario(CatalanaDataSet.Usuario, bus.IdUsuario)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim ver As New VerReportes
        Try
            Dim tSql As String = "SELECT   idUsuario as 'ID', primerNombre as 'Nombre', primerApellido as 'Apellido', segundoApellido as 'SegundoApellido', userName 'UserName', email as 'Email', estado as 'Estado'
            FROM   Usuario"
            Dim conex As New SqlConnection(My.Settings.CatalanaConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            ver.verReporte(t, "dataUsuario", "Reportes\RptUsuario.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        FrmMenuPrincipal.Show()
    End Sub
End Class