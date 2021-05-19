﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FrmProducto1
    Private Sub FrmProducto1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim A As New Producto
        Try
            A.NombreP = txtNombre.Text()
            A.PrecioProducto = CInt(txtPrecio.Text)
            A.DescripPro = txtDescripcionPro.Text
            A.EstadoP = CInt(txtEstado.Text)
            Me.ProductoTableAdapter.AgregarProductos(A.NombreP, A.PrecioProducto, A.DescripPro, A.EstadoP)
            MsgBox("Producto Guardado Correctamente")
            Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al agregar productos")
        End Try
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtID.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtDescripcionPro.Clear()
        txtEstado.Clear()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim B As New Producto
        Try
            B.IdPro = CInt(txtID.Text)
            Me.ProductoTableAdapter.BorrarProducto(B.IdPro)
            Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al borrar el producto")
        End Try
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim up As New Producto
        Try
            up.IdPro = CInt(txtID.Text)
            up.NombreP = txtNombre.Text
            up.PrecioProducto = CInt(txtPrecio.Text)
            up.DescripPro = txtDescripcionPro.Text()
            up.EstadoP = txtEstado.Text
            Me.ProductoTableAdapter.ActualizarProducto(up.NombreP, up.PrecioProducto, up.DescripPro, up.EstadoP, up.IdPro)
            MsgBox("Tu producto fue actualizado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al actualizar")
        End Try
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)
    End Sub

    Private Sub btnMenuPrin_Click(sender As Object, e As EventArgs) Handles btnMenuPrin.Click
        Me.Close()
        FrmMenuPrincipal.Show()
    End Sub

    Private Sub FrmProducto1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMenuPrincipal.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim bus As New Producto
        Try
            bus.IdPro = CInt(txtID.Text)
            Me.ProductoTableAdapter.BuscarProducto(CatalanaDataSet.producto, bus.IdPro)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar")
        End Try

    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            Dim tSql As String = "SELECT  idProducto as 'ID',  nombreProd as 'Nombre', PrecioProd as 'Precio', descripPro as 'Descripcion', estado as 'Estado'
            FROM  producto"
            Dim conex As New SqlConnection(My.Settings.CatalanaConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            verReporte(t, "Producto", "C:\Users\campo\Documents\SistemaCatalanaBD\SistemaCatalana\CatalanaNic\CatalanaNicv2\Reportes\RptProducto.rdlc")

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
End Class