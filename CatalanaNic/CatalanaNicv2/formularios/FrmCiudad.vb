Public Class FrmCiudad
    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.ciudad' Puede moverla o quitarla según sea necesario.
        Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtID.Clear()
        txtNombre.Clear()
        txtEstado.Clear()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim A As New Ciudad
        Try
            A.IdCiudad = CInt(txtID.Text)
            A.NombreC = txtNombre.Text +
            A.EstadoC = CInt(txtEstado.Text)
            MsgBox("Ciudad Agregada")
            Me.CiudadTableAdapter.AgregarCiudad(A.NombreC, A.EstadoC)
            Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al agregar")
        End Try
        Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim bo As New Ciudad
        Try
            bo.IdCiudad = CInt(txtID.Text)
            bo.NombreC = txtNombre.Text
            bo.EstadoC = CInt(txtEstado.Text)
            MsgBox("Se borro la ciudad")
            Me.CiudadTableAdapter.BorrarCiudad(bo.IdCiudad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al borrar ciudad")
        End Try
        Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim up As New Ciudad
        Try
            up.IdCiudad = CInt(txtID.Text)
            up.NombreC = txtNombre.Text
            up.EstadoC = CInt(txtEstado.Text)
            MsgBox("Ciudad Actualizada")
            Me.CiudadTableAdapter.ActualizarCiudad(up.NombreC, up.EstadoC, up.IdCiudad)
            Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Actualizar")
        End Try
        Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim bus As New Ciudad
        Try
            bus.IdCiudad = CInt(txtID.Text)
            Me.CiudadTableAdapter.BuscarCiudad(CatalanaDataSet.ciudad, bus.IdCiudad)
            Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de  busqueda")
        End Try
        Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)
    End Sub

End Class