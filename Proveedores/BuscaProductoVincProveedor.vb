Public Class BuscaProductoVincProveedor
    Private Sub BuscaProductoVincProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaproductos' Puede moverla o quitarla según sea necesario.
        Me.ListaproductosTableAdapter.FillByidproveedorvinculado(Me.ComercialDataSet.listaproductos, gidproveedor)
        'Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)

        ComboBox1.SelectedIndex = 1
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Select Case ComboBox1.Text
                Case "Código"
                    ListaproductosBindingSource.Filter = "codigoproducto like'%" + TextBox1.Text + "%'"
                    'If ProductosDataGridView.RowCount = 0 Then
                    '    ProductosDataGridView.Rows(0).Selected = False
                    'End If


                Case "Descripción"
                    ListaproductosBindingSource.Filter = "descripcion like'%" + TextBox1.Text + "%'"

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub ProductosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellDoubleClick
        Try
            gcodigoproducto = ProductosDataGridView.Rows(e.RowIndex).Cells("codigoproducto").Value
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class