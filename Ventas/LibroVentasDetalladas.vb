Public Class LibroVentasDetalladas
    Private Sub LibroVentasDetalladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventasdetalle' Puede moverla o quitarla según sea necesario.
        'Me.LibroventasdetalleTableAdapter.Fill(Me.ComercialDataSet.libroventasdetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        'Me.LibroventasTableAdapter.Fill(Me.ComercialDataSet.libroventas)
        Me.LibroventasTableAdapter.FillByFecha(Me.ComercialDataSet.libroventas, Today)


    End Sub

    Private Sub LibroventasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellContentClick

    End Sub

    Private Sub LibroventasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellClick
        Try
            gidventa = LibroventasDataGridView.Rows(e.RowIndex).Cells(0).Value
            LibroventasdetalleTableAdapter.FillByIdventa(Me.ComercialDataSet.libroventasdetalle, gidventa)

            Select Case LibroventasDataGridView.Columns(e.ColumnIndex).Name
                Case "Imprimir"
                    'Dim p As ConsultarVenta
                    'p = New ConsultarVenta
                    ''gidoperacion = MovimientoscajasDataGridView.CurrentRow.Cells(6).Value
                    ''gidventa = CajasoperacionesTableAdapter.cajasoperaciones_consultaridventa(gidoperacion)
                    'p.ShowDialog()
                    '**********************
                    Dim p As ViewerFactura
                    p = New ViewerFactura
                    p.ShowDialog()
                Case "formapago"
                    Dim p As VentaDetallePagosRealizados
                    p = New VentaDetallePagosRealizados
                    p.ShowDialog()
            End Select
            gidventa = Nothing
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.LibroventasTableAdapter.FillByFecha(Me.ComercialDataSet.libroventas, DateTimePicker1.Value)
    End Sub
End Class