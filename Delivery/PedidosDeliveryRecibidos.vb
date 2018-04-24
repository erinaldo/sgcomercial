Public Class PedidosDeliveryRecibidos
    Private Sub PedidosdeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PedidosRecibidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidosdelivery' Puede moverla o quitarla según sea necesario.
        Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)




    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellContentClick

    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellClick
        Select Case e.ColumnIndex
            Case 10
                Dim p As ViewerComanda
                p = New ViewerComanda
                gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(0).Value
                p.ShowDialog()
        End Select
    End Sub
End Class