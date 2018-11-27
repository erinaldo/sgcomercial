Public Class LibroIVACompras
    Private Sub LibroIVACompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.librocompras' Puede moverla o quitarla según sea necesario.
        'Me.LibrocomprasTableAdapter.Fill(Me.ComercialDataSet.librocompras)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.LibrocomprasTableAdapter.FillByRangoFechas(Me.ComercialDataSet.librocompras, DateTimePickerDesde.Value, DateTimePickerHasta.Value)
    End Sub
End Class