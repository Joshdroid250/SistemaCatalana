Public Class FrmCliente
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet1.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet1.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet1.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.ciudad' Puede moverla o quitarla según sea necesario.
        Me.CiudadTableAdapter.Fill(Me.CatalanaDataSet.ciudad)
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet.Cliente)

    End Sub

    Private Sub MostrarClientesTableToolStripButton_Click(sender As Object, e As EventArgs) Handles MostrarClientesTableToolStripButton.Click
        Try
            Me.ClienteTableAdapter.mostrarClientesTable(Me.CatalanaDataSet1.Cliente)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class