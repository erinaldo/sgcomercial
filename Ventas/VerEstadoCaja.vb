Public Class VerEstadoCaja
    Private Sub VerEstadoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaresumen' Puede moverla o quitarla según sea necesario.
        Me.cajaresumenTableAdapter.FillByidevento(Me.ComercialDataSet.cajaresumen, gideventoseleccionado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class