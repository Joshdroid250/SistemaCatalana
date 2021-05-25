Imports System.Data.SqlClient

Public Class FrmCliente
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet1.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.ciudad' Puede moverla o quitarla según sea necesario.
        Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)


    End Sub

    Private Sub MostrarClientesTableToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ClienteTableAdapter.mostrarClientesTable(Me.CatalanaDataSet1.Cliente)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtID.Clear()
        txtCedu.Clear()
        txtNombre.Clear()
        txtSegundoName.Clear()
        txtApellido.Clear()
        txtSegundoApellido.Clear()
        txtDomicilio.Clear()
        txtCorreo.Clear()
        txtcellTigo.Clear()
        txtcellClaro.Clear()
        txtcellCootel.Clear()
        txtEstado.Clear()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim A As New Cliente
        Try
            A.NumCedula = txtCedu.Text
            A.PrimerNombre = txtNombre.Text
            A.SegundoNombre = txtSegundoName.Text
            A.PrimerApellido = txtApellido.Text
            A.SegundoApellido = txtSegundoApellido.Text
            A.Domicilio = txtDomicilio.Text
            A.Correo = txtCorreo.Text
            A.IdCiudad = cbCiudad.SelectedValue
            A.CelTigo = CInt(txtcellTigo.Text)
            A.CelClaro = CInt(txtcellClaro.Text)
            A.CelCootel = CInt(txtcellCootel.Text)
            Me.ClienteTableAdapter.agregarCliente(CatalanaDataSet1.Cliente, A.NumCedula, A.PrimerNombre, A.SegundoNombre, A.PrimerApellido, A.SegundoApellido, A.Domicilio,
            A.Correo, A.IdCiudad, A.CelTigo, A.CelClaro, A.CelCootel, A.Estado)
            MsgBox("Se agrego el cliente")
            Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de agregar cliente")
        End Try
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim bo As New Cliente
        Try
            bo.IdCliente = CInt(txtID.Text)
            Me.ClienteTableAdapter.borrarCliente(CatalanaDataSet1.Cliente, bo.IdCliente)
            MsgBox("Se borraro el cliente satisfactoriamente")
            Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al borrar cliente")
        End Try
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim up As New Cliente
        Try
            up.IdCliente = CInt(txtID.Text)
            up.NumCedula = txtCedu.Text
            up.PrimerNombre = txtNombre.Text
            up.SegundoNombre = txtSegundoName.Text
            up.PrimerApellido = txtApellido.Text
            up.SegundoApellido = txtSegundoApellido.Text
            up.Domicilio = txtDomicilio.Text
            up.Correo = txtCorreo.Text
            up.IdCiudad = cbCiudad.SelectedValue
            up.CelTigo = CInt(txtcellTigo.Text)
            up.CelClaro = CInt(txtcellClaro.Text)
            up.CelCootel = CInt(txtcellCootel.Text)
            up.Estado = CInt(txtEstado.Text)
            Me.ClienteTableAdapter.actualizarCliente(CatalanaDataSet1.Cliente, up.IdCliente, up.NumCedula, up.PrimerNombre, up.SegundoNombre, up.PrimerApellido, up.SegundoApellido, up.Domicilio,
            up.Correo, up.IdCiudad, up.CelTigo, up.CelClaro, up.CelCootel, up.Estado)
            MsgBox("Se actualizo correctamente")
            Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al actualizar")
        End Try
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
    End Sub

    Private Sub btnBuscarID_Click(sender As Object, e As EventArgs) Handles btnBuscarID.Click
        Dim busID As New Cliente
        Try
            busID.IdCliente = CInt(txtID.Text)
            MsgBox("Se busco Correctamente")
            Me.ClienteTableAdapter.BuscarClientID(CatalanaDataSet1.Cliente, busID.IdCliente)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar por ID")
        End Try
    End Sub


    Private Sub btnMenuPrin_Click(sender As Object, e As EventArgs)
        Me.Close()
        FrmMenuPrincipal.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim ver As New VerReportes
        Try
            Dim tSql As String = "SELECT  idCliente as 'idcliente', numCedula as 'numCedula', primerNombre as 'primerNombre', segundoNombre as 'segundoNombre', primerApellido 'segundoApellido', domicilio as 'domicilio', email as 'email', idCiudad as 'idCiudad', celTigo 'celTigo', celClaro as 'celClaro', celCootel as 'celCootel'
            FROM   Cliente"
            Dim conex As New SqlConnection(My.Settings.CatalanaConnectionString)
            Dim da As New SqlDataAdapter(tSql, conex)
            Dim t As New DataTable
            da.Fill(t)
            ver.verReporte(t, "dsCliente", "Reportes\RptCliente.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub FrmCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMenuPrincipal.Show()
    End Sub

    Private Sub MostrarClientesTableToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.ClienteTableAdapter.mostrarClientesTable(Me.CatalanaDataSet1.Cliente)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MostrarClientesTableToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.ClienteTableAdapter.mostrarClientesTable(Me.CatalanaDataSet.Cliente)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MostrarClientesTableToolStripButton2_Click(sender As Object, e As EventArgs)
        Try
            Me.ClienteTableAdapter.mostrarClientesTable(Me.CatalanaDataSet.Cliente)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class