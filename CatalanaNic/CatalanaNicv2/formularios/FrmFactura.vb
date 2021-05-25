Imports System.Data.SqlClient

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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        txtID.Clear()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim A As New Factura
        Try
            A.IdUsuario = cbUsuario.SelectedValue
            A.IdCliente = cbCliente.SelectedValue
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
            up.IdCliente = cbCliente.SelectedValue
            up.IdUsuario = cbUsuario.SelectedValue
            up.Fecha = CDate(Dtpfecha.Text)
            Me.FacturaTableAdapter.actualizarFactura(CatalanaDataSet.Factura, up.IdFactura, up.IdUsuario, up.IdCliente, up.Fecha)
            MsgBox("Se actulizo la factura")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al actualizar")
        End Try
    End Sub

    Private Sub FrmFactura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMenuPrincipal.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sec As New Factura
        Try
            sec.IdFactura = CInt(txtID.Text)
            Me.FacturaTableAdapter.buscarFactura(CatalanaDataSet.Factura, sec.IdFactura)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar")
        End Try
    End Sub

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim ver As New VerReportes
        Try
            Dim tSql As String = "SELECT  idFactura as 'IdFactura', idUsuario as 'IdUsuario', idCliente as 'idCliente', fecha as 'fecha'
            FROM   Factura"
            Dim conex As New SqlConnection(My.Settings.CatalanaConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            ver.verReporte(t, "dsFactura", "Reportes\RptFactura.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub
End Class