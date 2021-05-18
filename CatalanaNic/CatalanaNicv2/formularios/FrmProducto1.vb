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
End Class