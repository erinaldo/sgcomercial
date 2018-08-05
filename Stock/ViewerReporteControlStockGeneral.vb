Public Class ViewerReporteControlStockGeneral
    Private Sub ViewerReporteControlStockGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
        Me.stockgeneralTableAdapter.Fill(Me.comercialDataSet.stockgeneral)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class