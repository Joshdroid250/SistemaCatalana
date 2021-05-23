Imports System.Data
Imports System.Data.SqlClient
Public Class InicioSesion
    Dim cn As New SqlConnection("Server = localhost; database=Catalana; uid=sa;pwd=123")
    Sub Inicio(ByVal name As String, ByVal pwd As String)
        Dim sql As String
        sql = "Select *from Usuario where userName= '" & name & "' and userPwd = '" & pwd & "' "
        Dim cmd As New SqlCommand(sql, cn)
        Dim dr As SqlDataReader
        cn.Open()
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            FrmMenuPrincipal.Show()
        Else
            MsgBox("Intente Nuevamente")
        End If
        cn.Close()

    End Sub

End Class
