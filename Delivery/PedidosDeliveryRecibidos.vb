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
        Me.ListapedidosdeliveryBindingSource.Filter = "estado <> 'ENTREGADO'"
    End Sub
    Public Sub colorear()
        Dim i As Integer
        For i = 0 To ListapedidosdeliveryDataGridView.RowCount - 1
            Select Case ListapedidosdeliveryDataGridView.Rows(i).Cells("estado").Value.ToString
                Case "ENTREGADO"
                    ListapedidosdeliveryDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
                Case "ENPROCESO"
                    ListapedidosdeliveryDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightCyan
                Case "RECIBIDO"
                    ListapedidosdeliveryDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            End Select
        Next
        ListapedidosdeliveryDataGridView.Refresh()
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
        Try
            Dim estadopedido As String = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("estado").Value
            Select Case ListapedidosdeliveryDataGridView.Columns(e.ColumnIndex).Name
                Case "imprimircomanda" ' imprimir orden de produccion
                    Dim p As ViewerComanda
                    p = New ViewerComanda
                    gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                    Dim idpedidoweb As Long
                    idpedidoweb = PedidosdeliveryTableAdapter.pedidosdelivery_consultarIDPedidoWeb(gidpedidodelivery)
                    p.ShowDialog()
                    If estadopedido = "RECIBIDO" Then
                        Try
                            PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("ENPROCESO", gidpedidodelivery)
                            If idpedidoweb > 0 Then
                                UpdEstadoPedidoWeb("ENPROCESO", idpedidoweb)
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        reloadpedidos()
                        colorear()
                    End If
                Case "Pagar" ' cargar pago
                    If estadopedido = "CANCELADO" Then
                        MsgBox("Opción no disponible", MsgBoxStyle.Exclamation, "Advertencia")
                        Return
                    End If
                    If ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("saldo").Value > 0 Then
                        Dim p As PedidosDeliveryPagar
                        p = New PedidosDeliveryPagar
                        gidpago = 0
                        gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                        gidventa = PedidosdeliveryTableAdapter.pedidosdelivery_consultaexisteventa(gidpedidodelivery)
                        gidcliente = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idcliente").Value
                        p.ShowDialog()
                        gidcliente = Nothing
                        gidventa = Nothing
                        gidpedidodelivery = Nothing
                        reloadpedidos()
                        colorear()
                    Else
                        MsgBox("El pedido ya se encuentra pagado!", MsgBoxStyle.Information)
                    End If
                Case "Baja"
                    If estadopedido = "CANCELADO" Then
                        MsgBox("Opción no disponible", MsgBoxStyle.Exclamation, "Advertencia")
                        Return
                    End If
                    If Not estadopedido = "DESPACHADO" And Not estadopedido = "ENTREGADO" Then
                        If MsgBox("Seguro desea dar de baja el pedido seleccionado?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                            PedidosdeliveryTableAdapter.pedidosdelivery_baja(ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value)
                            reloadpedidos()
                        End If
                    Else
                        MsgBox("No puede cancelar un pedido DESPACHADO/ENTREGADO")
                    End If
                Case "modificar"
                    If estadopedido = "CANCELADO" Then
                        MsgBox("Opción no disponible", MsgBoxStyle.Exclamation, "Advertencia")
                        Return
                    End If
                    Dim j As PedidosDeliveryModificar
                    j = New PedidosDeliveryModificar
                    gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value
                    j.ShowDialog()
                    gidpedidodelivery = Nothing
                    reloadpedidos()
                    colorear()
                    'MsgBox("vamos a modificar: " + ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value.ToString)
            End Select

        Catch ex As Exception
            MsgBox("No se pudo completar la operación: " + ex.Message)
        End Try
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ListapedidosdeliveryDataGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
            colorear()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PedidosDeliveryRecibidos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        colorear()
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles ListapedidosdeliveryDataGridView.RowsAdded

    End Sub
End Class