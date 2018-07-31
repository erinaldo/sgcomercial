Public Class PedidosDeliveryRecibidos
    Private Sub PedidosdeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub
    Sub reloadpedidos()
        Me.PedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.pedidosdelivery)
        If guserprofile = "ADMINISTRADOR" Then
            Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
        Else
            Me.ListapedidosdeliveryTableAdapter.FillByAptosPreparacion(Me.ComercialDataSet.listapedidosdelivery)
            ListapedidosdeliveryDataGridView.Columns("Pagar").Visible = False
        End If
    End Sub

    Private Sub PedidosRecibidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.pedidosdelivery)
        reloadpedidos()

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
            Case 10 ' imprimir orden de produccion
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
                    reloadpedidos()
                End If
            Case 11 ' cargar pago
                If ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("saldo").Value > 0 Then
                    Dim p As PedidosDeliveryPagar
                    p = New PedidosDeliveryPagar
                    gidpago = 0

                    'gmontoapagar = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(12).Value
                    gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                    gidventa = PedidosdeliveryTableAdapter.pedidosdelivery_consultaexisteventa(gidpedidodelivery)
                    gidcliente = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idcliente").Value
                    p.ShowDialog()
                Else
                    MsgBox("El pedido ya se encuentra pagado!", MsgBoxStyle.Information)
                End If
            Case 12
                Dim estadopedido As String = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value
                If Not estadopedido = "DESPACHADO" And Not estadopedido = "ENTREGADO" Then
                    If MsgBox("Seguro desea dar de baja el pedido seleccionado?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                        PedidosdeliveryTableAdapter.pedidosdelivery_baja(ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value)
                        reloadpedidos()
                    End If
                Else
                    MsgBox("No puede cancelar un pedido DESPACHADO/ENTREGADO")
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