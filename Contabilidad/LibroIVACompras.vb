Public Class LibroIVACompras
    Private Sub LibroIVACompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.librocompras' Puede moverla o quitarla según sea necesario.
        'Me.LibrocomprasTableAdapter.Fill(Me.ComercialDataSet.librocompras)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.LibrocomprasTableAdapter.FillByRangoFechas(Me.ComercialDataSet.librocompras, DateTimePickerDesde.Value, DateTimePickerHasta.Value)
        calcular()
    End Sub
    Private Sub calcular()
        Dim monto As Decimal
        Dim total As Decimal
        For i = 0 To LibrocomprasDataGridView.RowCount - 1
            monto = LibrocomprasDataGridView.Rows(i).Cells("ivacompras").Value
            total = total + monto
        Next
        TextBoxTotal.Text = total.ToString
    End Sub

    Private Sub LibroIVACompras_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Close()

    End Sub

    Private Sub LibrocomprasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibrocomprasDataGridView.CellContentClick

    End Sub

    Private Sub LibrocomprasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibrocomprasDataGridView.CellClick
        Try
            Select Case LibrocomprasDataGridView.Columns(e.ColumnIndex).Name
                Case "ver"
                    Dim p As ViewerPedido
                    p = New ViewerPedido
                    gidpedido = LibrocomprasDataGridView.Rows(e.RowIndex).Cells("idpedido").Value
                    p.ShowDialog()
                    gidpedido = 0

            End Select
        Catch ex As Exception
            MsgBox("No se pudo cargar el pedido: " + ex.Message)
        End Try
    End Sub
End Class