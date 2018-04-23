Public Class ReporteCierreCaja
    Private Sub ReporteCierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.comercialDataSet.cajaseventos)
        Me.librodiarioTableAdapter.FillByActivos(Me.comercialDataSet.librodiario)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.librodiario' Puede moverla o quitarla según sea necesario.

        CajaseventosBindingSource.Filter = "idevento = " + gidevento.ToString
        librodiarioBindingSource.Filter = "idevento = " + gidevento.ToString

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.librodiarioTableAdapter.Fill(Me.comercialDataSet.librodiario)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.librodiario' Puede moverla o quitarla según sea necesario.


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class