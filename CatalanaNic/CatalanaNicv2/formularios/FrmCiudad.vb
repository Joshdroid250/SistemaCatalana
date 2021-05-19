Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

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

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Try
            Dim tSql As String = "SELECT idCiudad as 'ID', nombreCiudad as 'Ciudad', estadoCiudad as 'Estado'
            FROM  ciudad"
            Dim conex As New SqlConnection(My.Settings.CatalanaConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            verReporte(t, "dataCiudad", "C:\Users\campo\Documents\SistemaCatalanaBD\SistemaCatalana\CatalanaNic\CatalanaNicv2\Reportes\RptCiudad.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub
    Sub verReporte(ByVal t As DataTable, ByVal ds As String, ByVal nompreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            FrmVista.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVista.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVista.ReportViewer1.LocalReport.ReportPath = nompreRpt
            FrmVista.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de reporte")
        End Try
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        FrmMenuPrincipal.Show()
    End Sub

    Private Sub FrmCiudad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMenuPrincipal.Show()
    End Sub
End Class