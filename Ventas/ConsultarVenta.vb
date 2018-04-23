Public Class ConsultarVenta

    Private Sub ConsultarVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.ComercialDataSet.pagos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ComercialDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventasdetalle' Puede moverla o quitarla según sea necesario.
        Me.LibroventasdetalleTableAdapter.Fill(Me.ComercialDataSet.libroventasdetalle)
        Me.LibroventasTableAdapter.Fill(Me.ComercialDataSet.libroventas)

        LibroventasBindingSource.Filter = "idventa = " + gidventa.ToString
        LibroventasdetalleBindingSource.Filter = "idventa = " + gidventa.ToString
        PagosBindingSource.Filter = "idventa = " + gidventa.ToString
        calcular()

    End Sub

    Private Sub calcular()
        'Dim cantidad As Decimal
        Dim total As Decimal = 0
        'Dim i As Integer

        'For i = 0 To LibroventasdetalleDataGridView.RowCount - 1
        '    cantidad = cantidad + LibroventasdetalleDataGridView.Rows(i).Cells(3).Value
        total = PagosDataGridView.Rows(0).Cells(3).Value
        'Next

        'cantidadtextbox.Text = LibroventasdetalleDataGridView.RowCount.ToString
        totaltextbox.Text = "$ " + total.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As ViewerFactura
        p = New ViewerFactura
        p.ShowDialog()
    End Sub
End Class