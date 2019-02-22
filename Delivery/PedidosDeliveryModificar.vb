Public Class PedidosDeliveryModificar
    Private Sub PedidosDeliveryModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ListapedidosdeliverydetalleTableAdapter.FillByIdPedidodelivery(Me.ComercialDataSet.listapedidosdeliverydetalle, gidpedidodelivery)
        Me.PedidosdeliverydetalleTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.pedidosdeliverydetalle, gidpedidodelivery)
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
    Public Sub buscaproductomanual()
        gcantidad = 0
        glistaprecio = 1
        gidproducto = 0
        Dim v_precioventa As Decimal
        'Dim idproducto As Long
        'Dim descripcion As String
        'Dim newrow As Long
        'Dim addnewrow As Boolean = False
        'Dim unidadmedida As Integer
        'Dim medida As Decimal
        glistaprecio = 0
        Dim p As BuscaProductoManualPedidos
        p = New BuscaProductoManualPedidos
        p.ShowDialog()
        ''***********************
        If Val(gcantidad) = 0 Or gprecioventa = 0 Then Return
        v_precioventa = gprecioventa
        gidproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)

    End Sub

    Private Sub ListapedidosdeliverydetalleDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ListapedidosdeliverydetalleDataGridView.KeyDown
        'MsgBox(e.KeyCode.ToString)
        If e.KeyCode = Keys.Add Then
            agregaprod()
        End If
        'If e.KeyCode = Keys.Subtract Then
        '    MsgBox("menos")
        '    'VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
        '    'recuento()
        'End If
        'If e.KeyCode = Keys.Multiply Then
        '    MsgBox("modify")
        '    'Dim p As SeleccionarCantidad
        '    'p = New SeleccionarCantidad
        '    'gcodigoproducto = 0
        '    'p.ShowDialog()
        '    ''p.TextBox1.Text = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow).Cells(3).Value
        '    'VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(3).Value = gcantidad
        '    'gprecioventa = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(6).Value
        '    'VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(7).Value = Convert.ToDecimal(gcantidad * gprecioventa) '*--- subtotal
        '    'recuento()
        'End If
    End Sub

    Private Sub ListapedidosdeliverydetalleDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliverydetalleDataGridView.CellClick
        Try
            Select Case ListapedidosdeliverydetalleDataGridView.Columns(e.ColumnIndex).Name
                Case "modificar"
                    modificaprod(e.RowIndex)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        agregaprod()
    End Sub
    Public Sub agregaprod()
        buscaproductomanual()
        If Not gidproducto > 0 Or gcantidad <= 0 Then Return

        Dim idproducto As Long = gidproducto
        Dim cantidad As Decimal = gcantidad
        Dim precioventa As Decimal = gprecioventa
        Dim idlistaprecio As Long = glistaprecio
        Dim idventa As Long = PedidosdeliveryTableAdapter.pedidosdelivery_consultaexisteventa(gidpedidodelivery)
        '*******************************************
        'unidadmedida = ProductosTableAdapter.productos_consultarunidadmedida(gcodigoproducto)
        'If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
        '    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
        'Else '************ la unidad de medida es kilo litro o metro
        '    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
        'End If
        'VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = v_precioventa
        'VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = v_precioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
        'VentasdetalleDataGridView.Rows(newrow).Cells("listasprecios").Value = glistaprecio

        'recuento()
        'Return
        '*******************************************
        If MsgBox("Esta seguro que desea agregar este producto?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            Try
                '______________________________________________________________________________
                PedidosdeliverydetalleTableAdapter.pedidosdeliverydetalle_insertar(gidpedidodelivery, idproducto, cantidad, precioventa, Nothing, idlistaprecio)
                VentasdetalleTableAdapter.ventasdetalle_insertardetalle(idventa, idproducto, cantidad, precioventa, idlistaprecio, Nothing, Nothing) ' descuento
                Me.ListapedidosdeliverydetalleTableAdapter.FillByIdPedidodelivery(Me.ComercialDataSet.listapedidosdeliverydetalle, gidpedidodelivery)
            Catch ex As Exception
                MsgBox("No se pudo completar la operación: " + ex.Message)
            End Try
        End If
    End Sub
    Public Sub modificaprod(ByRef rowindex As Long)
        Dim p As SeleccionarCantidad
        p = New SeleccionarCantidad
        gcodigoproducto = 0
        p.ShowDialog()
        p.TextBox1.Text = ListapedidosdeliverydetalleDataGridView.Rows(rowindex).Cells("cantidad").Value
        If Not gcantidad > 0 Then
            Return
        End If
        Dim cantidad As Decimal = gcantidad
        Dim listaprecio As Long = ListapedidosdeliverydetalleDataGridView.Rows(rowindex).Cells("idlistaprecio").Value
        Dim idproducto As Long = ListapedidosdeliverydetalleDataGridView.Rows(rowindex).Cells("idproducto").Value
        Dim precio As Decimal = ListapedidosdeliverydetalleDataGridView.Rows(rowindex).Cells("precioventa").Value
        'precio = ProductosTableAdapter.productos_calculaprecio(idproducto, listaprecio, cantidad)
        If Not precio > 0 Then
            Return
        End If
        PedidosdeliverydetalleTableAdapter.pedidosdeliverydetalle_modificapreciocantidad(cantidad, precio, gidpedidodelivery, idproducto)
        Me.ListapedidosdeliverydetalleTableAdapter.FillByIdPedidodelivery(Me.ComercialDataSet.listapedidosdeliverydetalle, gidpedidodelivery)
    End Sub
End Class