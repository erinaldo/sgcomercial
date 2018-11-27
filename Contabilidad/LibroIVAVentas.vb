Public Class LibroIVAVentas
    Private Sub LibroIVAVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        'Me.LibroventasTableAdapter.Fill(Me.ComercialDataSet.libroventas)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.LibroventasTableAdapter.FillByRangoFechas(Me.ComercialDataSet.libroventas, DateTimePickerDesde.Value, DateTimePickerHasta.Value)
    End Sub

    Private Sub LibroventasDataGri1dView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellContentClick
        Try
            Select Case LibroventasDataGridView.Columns(e.ColumnIndex).Name
                Case "ver"
                    gidventa = LibroventasDataGridView.Rows(e.RowIndex).Cells("idventa").Value
                    Dim p As ViewerFactura
                    p = New ViewerFactura
                    p.ShowDialog()
            End Select
        Catch ex As Exception
            MsgBox("Ocurrio un problema al intentar recuperar la factura: " + ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
        End Try

    End Sub
End Class