Public Class PedidosDeliveryLibro
    Private Sub PedidosdeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosdeliveryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub PedidosDeliveryLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidosdelivery' Puede moverla o quitarla según sea necesario.
        Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidosdelivery' Puede moverla o quitarla según sea necesario.
        Me.PedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.pedidosdelivery)

        ComboBox1.SelectedIndex = 0
        TextBox1.Select()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Select Case ComboBox1.Text
                Case "Cliente"
                    ListapedidosdeliveryBindingSource.Filter = "nombre like '%" + TextBox1.Text.ToUpper + "%'"
                Case "Pedido"
                    ListapedidosdeliveryBindingSource.Filter = "idpedidodelivery =" + TextBox1.Text
            End Select
        Catch ex As Exception
            ListapedidosdeliveryBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Select()
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellContentClick

    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellClick
        Select Case ListapedidosdeliveryDataGridView.Columns(e.ColumnIndex).Name
            Case "Ver"
                Dim p As ViewerComanda
                p = New ViewerComanda
                gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                Dim idpedidoweb As Long
                idpedidoweb = PedidosdeliveryTableAdapter.pedidosdelivery_consultarIDPedidoWeb(gidpedidodelivery)
                p.ShowDialog()
        End Select
    End Sub
End Class