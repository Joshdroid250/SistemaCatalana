Public Class FrmCiudad
    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaNicDataSet.Ciudad' Puede moverla o quitarla según sea necesario.
        Me.CiudadTableAdapter.Fill(Me.CatalanaNicDataSet.Ciudad)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdciudad.Clear()
        txtNombreCiu.Clear()
        txtEstadoCiu.Clear()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Ciu As New Ciudad
        Try
            Ciu.IdCiudad = CInt(txtIdciudad.Text)
            Ciu.NombreC = txtNombreCiu.Text
            Ciu.EstadoC = CInt(txtEstadoCiu.Text)
            Me.CiudadTableAdapter.AgregarRegistroCiudad(Ciu.NombreC, Ciu.EstadoC)
            Me.CiudadTableAdapter.Fill(Me.CatalanaNicDataSet.Ciudad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al agregar datos")
        End Try
        Me.CiudadTableAdapter.Fill(Me.CatalanaNicDataSet.Ciudad)
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim CiuB As New Ciudad
        Try
            CiuB.IdCiudad = CInt(txtIdciudad.Text)
            CiuB.NombreC = txtNombreCiu.Text
            CiuB.EstadoC = CInt(txtEstadoCiu.Text)
            Me.CiudadTableAdapter.BorrarRegistroCiudad(CiuB.IdCiudad)
            MsgBox("Borrado Correctamente")
            Me.CiudadTableAdapter.Fill(Me.CatalanaNicDataSet.Ciudad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al borrar Ciudades")
        End Try
        Me.CiudadTableAdapter.Fill(Me.CatalanaNicDataSet.Ciudad)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim CiuE As New Ciudad
        Try
            CiuE.IdCiudad = CInt(txtIdciudad.Text)
            CiuE.NombreC = txtNombreCiu.Text
            CiuE.EstadoC = CInt(txtEstadoCiu.Text)
            Me.CiudadTableAdapter.ActualizarRegistroCiudad(CiuE.NombreC, CiuE.EstadoC, CiuE.IdCiudad)
            Me.CiudadTableAdapter.Fill(Me.CatalanaNicDataSet.Ciudad)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Actualizar Ciudades")
        End Try
        Me.CiudadTableAdapter.Fill(Me.CatalanaNicDataSet.Ciudad)
    End Sub
End Class