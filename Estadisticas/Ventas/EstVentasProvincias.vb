Public Class EstVentasProvincias
    Private Sub EstVentasProvincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            gFechaDesde = DateTimePicker1.Value
            gFechaHasta = DateTimePicker2.Value

            Me.libroventasTableAdapter.FillByRangoFechas(Me.comercialDataSet.libroventas, gFechaDesde, gFechaHasta)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
        End Try
    End Sub
End Class