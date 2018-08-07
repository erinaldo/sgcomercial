Public Class VentaDetallePagosRealizados
    Private Sub VentaDetallePagosRealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapagos' Puede moverla o quitarla según sea necesario.
        Me.ListapagosTableAdapter.Fill(Me.ComercialDataSet.listapagos)
        Me.ListapagosTableAdapter.FillByIDVenta(Me.ComercialDataSet.listapagos, gidventa)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        Me.LibroventasTableAdapter.FillByIdventa(Me.ComercialDataSet.libroventas, gidventa)
    End Sub
End Class