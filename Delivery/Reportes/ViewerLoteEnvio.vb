Public Class ViewerLoteEnvio
    Private Sub ViewerLoteEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listalotes' Puede moverla o quitarla según sea necesario.
        Me.listalotesTableAdapter.Fill(Me.comercialDataSet.listalotes)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listalotesdetalle' Puede moverla o quitarla según sea necesario.
        Me.listalotesdetalleTableAdapter.Fill(Me.comercialDataSet.listalotesdetalle)

        Me.ReportViewer1.RefreshReport()

        listalotesBindingSource.Filter = "idloteenvio = " + gidlote.ToString
        listalotesdetalleBindingSource.Filter = "idloteenvio = " + gidlote.ToString

    End Sub
End Class