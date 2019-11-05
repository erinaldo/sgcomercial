Public Class SCListaProductos
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiscomDataSet)

    End Sub

    Private Sub SCListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SiscomDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.SiscomDataSet.productos)

    End Sub

    Private Sub ProductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub ProductosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellDoubleClick
        Try
            SCIdproducto = ProductosDataGridView.Rows(e.RowIndex).Cells("idproductos").Value
            SCProductoDescripcion = ProductosDataGridView.Rows(e.RowIndex).Cells("descripcion").Value
            Me.Close()

        Catch ex As Exception
            SCIdproducto = Nothing
            SCProductoDescripcion = Nothing
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ProductosDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductosDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Try
                    SCIdproducto = ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells("idproductos").Value
                    SCProductoDescripcion = ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells("descripcion").Value
                    Me.Close()

                Catch ex As Exception
                    SCIdproducto = Nothing
                    SCProductoDescripcion = Nothing
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                SCIdproducto = Nothing
                SCProductoDescripcion = Nothing
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class