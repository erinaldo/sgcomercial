Public Class EstHistoricoVentas
    Private Sub EstHistoricoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.GraphHistoricoVentas.rdlc"
        Dim rptDs As Microsoft.Reporting.WinForms.ReportDataSource
        rptDs = New Microsoft.Reporting.WinForms.ReportDataSource("EstHistoricoVentas", EstHistoricoVentasBindingSource)

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rptDs)

        Dim fechadesde As Date
        fechadesde = DateAdd("m", -7, Today)
        Me.EstHistoricoVentasTableAdapter.FillByFechaDesde(Me.comercialDataSet.EstHistoricoVentas, fechadesde)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Dim fechadesde As Date
            Dim fechahasta As Date
            fechadesde = DateTimePicker1.Value
            fechahasta = DateTimePicker2.Value
            'Me.EstHistoricoVentasTableAdapter.FillByFechaDesde(Me.comercialDataSet.EstHistoricoVentas, fechadesde)
            Me.EstHistoricoVentasTableAdapter.FillByFechaDesdeHasta(Me.comercialDataSet.EstHistoricoVentas, fechadesde, fechahasta)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
        End Try

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            Dim fechadesde As Date
            Dim fechahasta As Date
            fechadesde = DateTimePicker1.Value
            fechahasta = DateTimePicker2.Value
            'Me.EstHistoricoVentasTableAdapter.FillByFechaDesde(Me.comercialDataSet.EstHistoricoVentas, fechadesde)
            Me.EstHistoricoVentasTableAdapter.FillByFechaDesdeHasta(Me.comercialDataSet.EstHistoricoVentas, fechadesde, fechahasta)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
        End Try
    End Sub
End Class