Public Class FrmCliente
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalanaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.CatalanaDataSet.Cliente)

    End Sub
End Class