Public Class FrmFactura
    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.CatalanaDataSet.Factura)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.CatalanaDataSet.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet.Cliente)

    End Sub

    Private Sub MostrarClientesTableToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ClienteTableAdapter.mostrarClientesTable(Me.CatalanaDataSet.Cliente)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtID.Clear()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim A As New Factura
        Try
            A.IdUsuario = CInt(lbIdUser.Text)
            A.IdCliente = CInt(lbIdCliente.Text)
            A.Fecha = CDate(Dtpfecha.Text)
            Me.FacturaTableAdapter.agregarFactura(CatalanaDataSet.Factura, A.IdUsuario, A.IdCliente, A.Fecha)
            MsgBox("Se agrego la factura")
            Me.FacturaTableAdapter.Fill(Me.CatalanaDataSet.Factura)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al ingresar factura")
        End Try
        Me.FacturaTableAdapter.Fill(Me.CatalanaDataSet.Factura)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim bo As New Factura
        Try
            bo.IdFactura = CInt(txtID.Text)
            Me.FacturaTableAdapter.borrarFactura(CatalanaDataSet.Factura, bo.IdFactura)
            MsgBox("Se borro correctamente")
            Me.FacturaTableAdapter.Fill(Me.CatalanaDataSet.Factura)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Se borro correctamente")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim up As New Factura
        Try
            up.IdFactura = CInt(txtID.Text)
            up.IdCliente = CInt(lbIdCliente.Text)
            up.IdUsuario = CInt(lbIdUser.Text)
            up.Fecha = CDate(Dtpfecha.Text)
            Me.FacturaTableAdapter.actualizarFactura(CatalanaDataSet.Factura, up.IdFactura, up.IdUsuario, up.IdCliente, up.Fecha)
            MsgBox("Se actulizo la factura")
            Me.FacturaTableAdapter.Fill(Me.CatalanaDataSet.Factura)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al actualizar")
        End Try
    End Sub

    Private Sub FrmFactura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMenuPrincipal.Show()
    End Sub
End Class