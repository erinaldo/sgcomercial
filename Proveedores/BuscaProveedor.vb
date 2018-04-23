Public Class BuscaProveedor
    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub BuscaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            ProveedoresBindingSource.Filter = "nombre like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)
        End Try
    End Sub

    Private Sub ProveedoresDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellContentClick

    End Sub

    Private Sub ProveedoresDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ProveedoresDataGridView.DoubleClick

    End Sub

    Private Sub ProveedoresDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellDoubleClick
        gidproveedor = ProveedoresDataGridView.Rows(e.RowIndex).Cells(0).Value
        Me.Close()
    End Sub
End Class