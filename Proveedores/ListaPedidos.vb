Public Class ListaPedidos
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ListaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidos' Puede moverla o quitarla según sea necesario.
        Me.ListapedidosTableAdapter.Fill(Me.ComercialDataSet.listapedidos)

        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidos' Puede moverla o quitarla según sea necesario.
        'Me.PedidosTableAdapter.Fill(Me.ComercialDataSet.pedidos)

        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub PedidosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PedidosDataGridView.CellContentClick

    End Sub

    Private Sub PedidosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PedidosDataGridView.CellClick

        Try
            listapedidosreporteTableAdapter.FillByidpedido(Me.ComercialDataSet.listapedidosreporte, PedidosDataGridView.Rows(e.RowIndex).Cells(0).Value)
            ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 
        Try
            ProveedoresBindingSource.Filter = " idproveedor = 4 "
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class