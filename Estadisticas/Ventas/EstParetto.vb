Public Class EstParetto
    Private Sub EstParetto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EstABCResumenTableAdapter.Fill(Me.comercialDataSet.EstABCResumen)
        Me.EstClasificacionParetoTableAdapter.Fill(Me.comercialDataSet.EstClasificacionPareto)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class