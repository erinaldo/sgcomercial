Public Class EstadisticasVentas
    Private Sub EstadisticasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBoxEstadistica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstadistica.SelectedIndexChanged
        Select Case ComboBoxEstadistica.Text
            Case "Principio de Pareto"
                'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.EstABCResumen' Puede moverla o quitarla según sea necesario.
                Me.EstABCResumenTableAdapter.Fill(Me.comercialDataSet.EstABCResumen)
                'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.EstClasificacionPareto' Puede moverla o quitarla según sea necesario.
                Me.EstClasificacionParetoTableAdapter.Fill(Me.comercialDataSet.EstClasificacionPareto)
                'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.EstParetoParticipacion' Puede moverla o quitarla según sea necesario.
                Me.EstParetoParticipacionTableAdapter.Fill(Me.comercialDataSet.EstParetoParticipacion)

                Me.ReportViewer1.RefreshReport()
            Case Else
                Me.ReportViewer1.Clear()

        End Select
    End Sub
End Class