Public Class PedidosDeliveryRecibidos
    Private Sub PedidosdeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PedidosRecibidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.pedidosdelivery)
        Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
        '***************    ordenamiento por estado del pedido  **********************
        Try
            Dim newColumn As DataGridViewColumn = ListapedidosdeliveryDataGridView.Columns(1)
            ListapedidosdeliveryDataGridView.Rows(0).Cells(1).Selected = True
            ListapedidosdeliveryDataGridView.Sort(newColumn, System.ComponentModel.ListSortDirection.Descending)
        Catch ex As Exception

        End Try
        '*****************************************************************************

    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellContentClick

    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellClick
        Select Case e.ColumnIndex
            Case 10
                Dim p As ViewerComanda
                p = New ViewerComanda
                gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(0).Value
                Dim idpedidoweb As Long
                idpedidoweb = PedidosdeliveryTableAdapter.pedidosdelivery_consultarIDPedidoWeb(gidpedidodelivery)
                Dim estadopedido As String = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value
                p.ShowDialog()
                If Not estadopedido = "DESPACHADO" Then


                    Try
                        PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("ENPROCESO", gidpedidodelivery)
                        If idpedidoweb > 0 Then
                            UpdEstadoPedidoWeb("ENPROCESO", idpedidoweb)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
                End If

        End Select
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ListapedidosdeliveryDataGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'boton de ordenamiento
        '        ListapedidosdeliveryDataGridView.Columns(1).DisplayIndex = 0



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Sincronizando
        p = New Sincronizando
        p.Visible = True
        SynClientes()
        p.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        SynPedidos()
    End Sub
End Class