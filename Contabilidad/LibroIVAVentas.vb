Public Class LibroIVAVentas
    Private Sub LibroIVAVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        'Me.LibroventasTableAdapter.Fill(Me.ComercialDataSet.libroventas)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.LibroventasTableAdapter.FillByRangoFechas(Me.ComercialDataSet.libroventas, DateTimePickerDesde.Value, DateTimePickerHasta.Value)
    End Sub
End Class