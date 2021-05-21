Imports Microsoft.Reporting.WinForms

Public Class VerReportes
    Sub verReporte(ByVal t As DataTable, ByVal ds As String, ByVal nompreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            FrmVista.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVista.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVista.ReportViewer1.LocalReport.ReportPath = nompreRpt
            FrmVista.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de reporte")
        End Try
    End Sub
End Class
