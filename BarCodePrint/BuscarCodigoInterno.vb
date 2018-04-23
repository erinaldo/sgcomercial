Public Class BuscarCodigoInterno
    Private Sub BuscarCodigoInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaproductos' Puede moverla o quitarla según sea necesario.
        Me.ListaproductosTableAdapter.FillByProductosNoCompuestos(Me.ComercialDataSet.listaproductos)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            ListaproductosBindingSource.Filter = "descripcion like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            ListaproductosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ListaproductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaproductosDataGridView.CellContentClick

    End Sub

    Private Sub ListaproductosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaproductosDataGridView.CellDoubleClick
        Try
            gcodigoproducto = ListaproductosDataGridView.Rows(ListaproductosDataGridView.CurrentRow.Index).Cells(0).Value
            gproductodescripcion = ListaproductosDataGridView.Rows(ListaproductosDataGridView.CurrentRow.Index).Cells(1).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class