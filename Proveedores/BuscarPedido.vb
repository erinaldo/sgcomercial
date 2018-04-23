Public Class BuscarPedido
    Private Sub BuscarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidos' Puede moverla o quitarla según sea necesario.
        Me.ListapedidosTableAdapter.FillByVigentes(Me.ComercialDataSet.listapedidos)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            ListapedidosBindingSource.Filter = "nombre like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            ListapedidosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ListapedidosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosDataGridView.CellContentClick

    End Sub

    Private Sub ListapedidosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosDataGridView.CellClick
        If ListapedidosDataGridView.Rows(e.RowIndex).Cells(0).Value > 0 Then
            gidpedido = ListapedidosDataGridView.Rows(e.RowIndex).Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class