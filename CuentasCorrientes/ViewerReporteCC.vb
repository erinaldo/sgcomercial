Public Class ViewerReporteCC
    Private Sub ViewerReporteCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.librocuentascorrientes' Puede moverla o quitarla según sea necesario.
        Me.librocuentascorrientesTableAdapter.Fill(Me.comercialDataSet.librocuentascorrientes)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class