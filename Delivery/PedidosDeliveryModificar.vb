Public Class PedidosDeliveryModificar
    Private Sub PedidosDeliveryModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidosdeliverydetalle' Puede moverla o quitarla según sea necesario.
        Me.ListapedidosdeliverydetalleTableAdapter.FillByIdPedidodelivery(Me.ComercialDataSet.listapedidosdeliverydetalle, gidpedidodelivery)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidosdeliverydetalle' Puede moverla o quitarla según sea necesario.
        Me.PedidosdeliverydetalleTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.pedidosdeliverydetalle, gidpedidodelivery)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidosdelivery' Puede moverla o quitarla según sea necesario.
        'Me.PedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.pedidosdelivery)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidosdelivery' Puede moverla o quitarla según sea necesario.
        'Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
        Me.ListapedidosdeliveryTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.listapedidosdelivery, gidpedidodelivery)


    End Sub

    Private Sub PictureBoxEditarDomicilios_Click(sender As Object, e As EventArgs) Handles PictureBoxEditarDomicilios.Click
        'If Val(IdclienteTextBox.Text) = 0 Then Return
        Dim P As ClientesNuevoDomicilio
        P = New ClientesNuevoDomicilio
        gdomicilioseleccionado = 0
        gclienteseleccionado = ListapedidosdeliveryBindingSource.Current("idcliente")

        P.ShowDialog()
        If gdomicilioseleccionado = 0 Then
            Return
        Else
            '**************** todo bien! actualizo! *******************
            PedidosdeliveryTableAdapter.pedidosdelivery_updateiddomicilio(gdomicilioseleccionado, gidpedidodelivery)
            Me.ListapedidosdeliveryTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.listapedidosdelivery, gidpedidodelivery)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim P As EditarCliente
        P = New EditarCliente
        gclienteseleccionado = 0
        gclienteseleccionado = ListapedidosdeliveryBindingSource.Current("idcliente")
        P.ShowDialog()
        Me.ListapedidosdeliveryTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.listapedidosdelivery, gidpedidodelivery)
    End Sub

    Private Sub ListapedidosdeliverydetalleDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliverydetalleDataGridView.CellContentClick

    End Sub

    Private Sub ListapedidosdeliverydetalleDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ListapedidosdeliverydetalleDataGridView.KeyDown
        'MsgBox(e.KeyCode.ToString)
        If e.KeyCode = Keys.Add Then
            'buscaproductomanual()
            'recuento()
            MsgBox("mas")
        End If
        If e.KeyCode = Keys.Subtract Then
            MsgBox("menos")
            'VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            'recuento()
        End If
        If e.KeyCode = Keys.Multiply Then
            MsgBox("modify")
            'Dim p As SeleccionarCantidad
            'p = New SeleccionarCantidad
            'gcodigoproducto = 0
            'p.ShowDialog()
            ''p.TextBox1.Text = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow).Cells(3).Value
            'VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(3).Value = gcantidad
            'gprecioventa = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(6).Value
            'VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(7).Value = Convert.ToDecimal(gcantidad * gprecioventa) '*--- subtotal
            'recuento()
        End If
    End Sub

    Private Sub ListapedidosdeliverydetalleDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliverydetalleDataGridView.CellClick
        Try
            Select Case ListapedidosdeliverydetalleDataGridView.Columns(e.ColumnIndex).Name
                Case "modificar"
                    'If e.KeyCode = Keys.Multiply Then
                    Dim p As SeleccionarCantidad
                        p = New SeleccionarCantidad
                        gcodigoproducto = 0
                    p.ShowDialog()
                    p.TextBox1.Text = ListapedidosdeliverydetalleDataGridView.Rows(e.RowIndex).Cells("cantidad").Value
                    If Not gcantidad > 0 Then
                        Return
                    End If
                    Dim cantidad As Decimal = gcantidad
                    Dim listaprecio As Long = ListapedidosdeliverydetalleDataGridView.Rows(e.RowIndex).Cells("idlistaprecio").Value
                    Dim idproducto As Long = ListapedidosdeliverydetalleDataGridView.Rows(e.RowIndex).Cells("idproducto").Value
                    Dim precio As Decimal
                    precio = ProductosTableAdapter.productos_calculaprecio(idproducto, listaprecio, cantidad)
                    If Not precio > 0 Then
                        Return
                    End If
                    PedidosdeliverydetalleTableAdapter.pedidosdeliverydetalle_modificapreciocantidad(cantidad, precio, gidpedidodelivery, idproducto)
                    Me.ListapedidosdeliverydetalleTableAdapter.FillByIdPedidodelivery(Me.ComercialDataSet.listapedidosdeliverydetalle, gidpedidodelivery)
                Case "eliminar"
                    If ListapedidosdeliverydetalleDataGridView.RowCount = 1 Then
                        If MsgBox("Si elimina el último artículo de la lista el pedido se cancela automaticamente. Desea continuar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                            PedidosdeliveryTableAdapter.pedidosdelivery_baja(gidpedidodelivery)
                            Me.Close()
                            Return
                        End If
                    End If
                    If MsgBox("Seguro desea eliminar el artículo del pedido?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                        PedidosdeliverydetalleTableAdapter.pedidodeliverydetalle_eliminar(ListapedidosdeliverydetalleDataGridView.Rows(e.RowIndex).Cells("idpedidodelivery").Value, ListapedidosdeliverydetalleDataGridView.Rows(e.RowIndex).Cells("idproducto").Value)
                        Me.ListapedidosdeliverydetalleTableAdapter.FillByIdPedidodelivery(Me.ComercialDataSet.listapedidosdeliverydetalle, gidpedidodelivery)
                    End If
            End Select
        Catch ex As Exception
            MsgBox("No se pudo realizar la operación: " + ex.Message)
        End Try

    End Sub
End Class