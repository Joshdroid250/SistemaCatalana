Public Class FrmProducto
    Private Sub Productos_Enter(sender As Object, e As EventArgs) Handles GbProductos.Enter

    End Sub

    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaNicDataSet.DetFactu' Puede moverla o quitarla según sea necesario.
        Me.DetFactuTableAdapter.Fill(Me.CatalanaNicDataSet.DetFactu)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaNicDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.CatalanaNicDataSet.Producto)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            Dim A As New Producto
            A.NombreP = txtNombre.Text()
            A.PrecioProducto = CInt(txtPrecio.Text)
            A.EstadoP = CInt(txtEstado.Text)
            A.DescripPro = txtDescripPro.Text
            Me.ProductoTableAdapter.AgregarProducto(A.NombreP, A.PrecioProducto, A.EstadoP, A.DescripPro)
            MsgBox("Producto Agregado Correctamente")
            Me.ProductoTableAdapter.Fill(Me.CatalanaNicDataSet.Producto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al guardar Productos")
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            Me.ProductoTableAdapter.Fill(Me.CatalanaNicDataSet.Producto)
            txtIdProducto.Clear()
            txtNombre.Clear()
            txtPrecio.Clear()
            txtEstado.Clear()
            txtDescripPro.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error fatal")
        End Try

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim D As New Producto
        Try

            D.NombreP = txtNombre.Text
            D.IdPro = CInt(txtIdProducto.Text)

            Me.ProductoTableAdapter.BorrarProductos(D.IdPro)
            MsgBox("Producto borrado Correctamente")
            Me.ProductoTableAdapter.Fill(Me.CatalanaNicDataSet.Producto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error al borrar")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim U As New Producto
        Try
            U.IdPro = CInt(txtIdProducto.Text)
            U.NombreP = txtNombre.Text
            U.PrecioProducto = CInt(txtPrecio.Text)
            U.DescripPro = txtDescripPro.Text()

            Me.ProductoTableAdapter.ActualizarProducto(U.NombreP, U.PrecioProducto, U.DescripPro, U.IdPro)
            Me.ProductoTableAdapter.Fill(Me.CatalanaNicDataSet.Producto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al actualizar datos")
        End Try
        Me.ProductoTableAdapter.Fill(Me.CatalanaNicDataSet.Producto)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim BP As New Producto
        Try
            BP.NombreP = txtBuscar.Text
            Me.ProductoTableAdapter.BuscarProductos(CatalanaNicDataSet.Producto, BP.NombreP)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de busqueda")
        End Try

    End Sub
End Class