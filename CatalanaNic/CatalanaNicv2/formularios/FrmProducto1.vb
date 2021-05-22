Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class FrmProducto1
    Private Sub FrmProducto1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet1.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet1.producto)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim A As New Producto
        Dim im As New MemoryStream
        Try
            Me.PicBFoto.Image.Save(im, Me.PicBFoto.Image.RawFormat)
            A.NombreP = txtNombre.Text()
            A.PrecioProducto = CInt(txtPrecio.Text)
            A.DescripPro = txtDescripcionPro.Text
            A.Iva = CInt(txtIva.Text)
            A.EstadoP = CInt(txtEstado.Text)
            A.FotoProd = im.GetBuffer

            Me.ProductoTableAdapter.agregarProd(CatalanaDataSet.producto, A.NombreP, A.PrecioProducto, A.Iva, A.DescripPro, A.FotoProd, A.EstadoP)
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
            Me.ProductoTableAdapter.borrarProd(CatalanaDataSet.producto, B.IdPro)
            Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al borrar el producto")
        End Try
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim up As New Producto
        Dim im As New MemoryStream
        Try
            Me.PicBFoto.Image.Save(im, Me.PicBFoto.Image.RawFormat)
            up.IdPro = CInt(txtID.Text)
            up.NombreP = txtNombre.Text
            up.PrecioProducto = CInt(txtPrecio.Text)
            up.DescripPro = txtDescripcionPro.Text()
            up.EstadoP = txtEstado.Text
            up.FotoProd = im.GetBuffer
            Me.ProductoTableAdapter.actualizarProd(CatalanaDataSet.producto, up.IdPro, up.NombreP, up.PrecioProducto, up.Iva, up.DescripPro, up.FotoProd, up.EstadoP)
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
            Me.ProductoTableAdapter.buscarProdID(CatalanaDataSet.producto, bus.IdPro)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar")
        End Try

    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Dim ver As New VerReportes
        Try
            Dim tSql As String = "SELECT  idProducto as 'ID',  nombreProd as 'Nombre', PrecioProd as 'Precio', descripPro as 'Descripcion'
            FROM  producto"
            Dim conex As New SqlConnection(My.Settings.CatalanaConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            ver.verReporte(t, "dsProducto2", "Reportes\RptProducto.rdlc")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub btnAgregarFoto_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
        OpenFileDialog1.Filter = "Tipo JPG|*.jpg| Tipo GIF|*.gif|Tipo bitmaps|*.bmp|Tipo PNG|*.png"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.PicBFoto.Image = Image.FromFile(Me.OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub btnBorPIC_Click(sender As Object, e As EventArgs) Handles btnBorPIC.Click
        PicBFoto.Image = Nothing
    End Sub
End Class