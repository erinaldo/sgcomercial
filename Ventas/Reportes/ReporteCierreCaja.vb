Public Class ReporteCierreCaja
    Private Sub ReporteCierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.CajaseventosTableAdapter.FillByIdevento(Me.comercialDataSet.cajaseventos, gidevento)
        Me.librodiarioTableAdapter.FillByIdevento(Me.comercialDataSet.librodiario, gidevento)
        Me.cajaresumenTableAdapter.FillByidevento(Me.comercialDataSet.cajaresumen, gidevento)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.librodiarioTableAdapter.FillByIdevento(Me.comercialDataSet.librodiario, gidevento)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.librodiario' Puede moverla o quitarla según sea necesario.


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class