Imports System.Data
Imports System.Data.SqlClient
Public Class FrmInicioSesion
    Dim cn As New SqlConnection("Server = DESKTOP-29CHVVG; database=Catalana; uid=sa;pwd=123")
    Private Sub Inicio()
        Dim sql As String
        sql = "Select *from Usuario where userName= '" & txtUserName.Text & "' and userPwd = '" & txtPassword.Text & "' "
        Dim cmd As New SqlCommand(sql, cn)
        Dim dr As SqlDataReader
        cn.Open()
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            FrmMenuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("Intente Nuevamente")
        End If
        cn.Close()

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Inicio()
        Names.name = txtUserName.Text
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub CapturarName(ByVal name As String)
        txtUserName.Text = name
    End Sub
End Class
