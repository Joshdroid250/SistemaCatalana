Public Class FrmDetFactura
    Private Sub FrmDetFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet1.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.CatalanaDataSet1.Factura)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet1.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet1.producto)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.CatalanaDataSet.Factura)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.CatalanaDataSet.producto)
        Me.DetFactuTableAdapter.Fill(Me.CatalanaDataSet.DetFactu)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtID.Clear()
        txtCantidad.Clear()
        txtDescuento.Clear()
        txtPrecio.Clear()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim A As New Detfact
        Try
            A.IDFactura = CInt(lbdFactu.Text)
            A.IDproducto = CInt(lbIdProduc.Text)
            A.Precio = CInt(txtPrecio.Text)
            A.Cantidad = CInt(txtCantidad.Text)
            A.Descuento = CInt(txtDescuento.Text)
            Me.DetFactuTableAdapter.agregarDetFactura(CatalanaDataSet.DetFactu, A.IDproducto, A.IDFactura, A.Cantidad, A.Precio, A.Descuento)
            MsgBox("Se agrego correctamente")
            Me.DetFactuTableAdapter.Fill(Me.CatalanaDataSet.DetFactu)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al agregar")
        End Try
        Me.DetFactuTableAdapter.Fill(Me.CatalanaDataSet.DetFactu)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim bo As New Detfact
        Try
            bo.IDDetFact = CInt(txtID.Text)
            Me.DetFactuTableAdapter.borrarDetFatu(CatalanaDataSet.DetFactu, bo.IDDetFact)
            MsgBox("Se borro correctamente")
            Me.DetFactuTableAdapter.Fill(Me.CatalanaDataSet.DetFactu)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al borrar")
        End Try
        Me.DetFactuTableAdapter.Fill(Me.CatalanaDataSet.DetFactu)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim up As New Detfact
        Try
            up.IDDetFact = CInt(txtID.Text)
            up.IDFactura = CInt(lbdFactu.Text)
            up.IDproducto = CInt(lbIdProduc.Text)
            up.Precio = CInt(txtPrecio.Text)
            up.Cantidad = CInt(txtCantidad.Text)
            up.Descuento = CInt(txtDescuento.Text)
            MsgBox("Se actualizo correctamente")
            Me.DetFactuTableAdapter.actualizarDetFatu(CatalanaDataSet.DetFactu, up.IDDetFact, up.IDproducto, up.IDFactura, up.Cantidad, up.Precio, up.Descuento)
            Me.DetFactuTableAdapter.Fill(Me.CatalanaDataSet.DetFactu)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al actualizar")
        End Try
        Me.DetFactuTableAdapter.Fill(Me.CatalanaDataSet.DetFactu)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim bus As New Detfact
        Try
            bus.IDDetFact = CInt(txtID.Text)
            Me.DetFactuTableAdapter.buscarActualizarDetFat(CatalanaDataSet.DetFactu, bus.IDDetFact)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de busqueda")
        End Try
    End Sub

    Private Sub btnMenuPrin_Click(sender As Object, e As EventArgs) Handles btnMenuPrin.Click
        FrmMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class