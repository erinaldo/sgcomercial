Public Class EstadisticasVentas
    Private Sub EstadisticasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.EstABCResumen' Puede moverla o quitarla según sea necesario.
        Me.EstABCResumenTableAdapter.Fill(Me.comercialDataSet.EstABCResumen)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.EstClasificacionPareto' Puede moverla o quitarla según sea necesario.
        Me.EstClasificacionParetoTableAdapter.Fill(Me.comercialDataSet.EstClasificacionPareto)

    End Sub

    Private Sub ComboBoxEstadistica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstadistica.SelectedIndexChanged

        Me.ReportViewer1.Clear()

        Select Case ComboBoxEstadistica.Text
            Case "Principio de Pareto"
                ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.GraphPareto.rdlc"
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Dim rptDs As Microsoft.Reporting.WinForms.ReportDataSource
                rptDs = New Microsoft.Reporting.WinForms.ReportDataSource("EstABCResumen", EstABCResumenBindingSource)
                Me.ReportViewer1.LocalReport.DataSources.Add(rptDs)
                rptDs = New Microsoft.Reporting.WinForms.ReportDataSource("EstClasificacionPareto", EstClasificacionParetoBindingSource)
                Me.ReportViewer1.LocalReport.DataSources.Add(rptDs)
                '/******************************/
                Me.EstClasificacionParetoTableAdapter.Fill(Me.comercialDataSet.EstClasificacionPareto)
                Me.EstParetoParticipacionTableAdapter.Fill(Me.comercialDataSet.EstParetoParticipacion)
                Me.EstABCResumenTableAdapter.Fill(Me.comercialDataSet.EstABCResumen)

                Me.ReportViewer1.RefreshReport()
            Case "Historico Ventas"
                ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.GraphHistoricoVentas.rdlc"
                Dim rptDs As Microsoft.Reporting.WinForms.ReportDataSource
                rptDs = New Microsoft.Reporting.WinForms.ReportDataSource("EstHistoricoVentas", EstHistoricoVentasBindingSource)

                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(rptDs)

                Dim fechadesde As Date
                fechadesde = DateAdd("m", -7, Today)
                Me.EstHistoricoVentasTableAdapter.FillByFechaDesde(Me.comercialDataSet.EstHistoricoVentas, fechadesde)

                Me.ReportViewer1.RefreshReport()
            Case Else
                Me.ReportViewer1.Clear()

        End Select
    End Sub
End Class