Public Class LotePedidosDeliveryRendir
    Dim idevento As Long = 0
    Dim rtn_mensaje As String
    Private Sub RendirLotePedidosDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.estadosentregadelivery' Puede moverla o quitarla según sea necesario.
        Me.EstadosentregadeliveryTableAdapter.Fill(Me.ComercialDataSet.estadosentregadelivery)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listalotesdetalle' Puede moverla o quitarla según sea necesario.
        'Me.ListalotesdetalleTableAdapter.Fill(Me.ComercialDataSet.listalotesdetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listalotes' Puede moverla o quitarla según sea necesario.
        Me.ListalotesTableAdapter.Fill(Me.ComercialDataSet.listalotes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listalotes' Puede moverla o quitarla según sea necesario.
        Me.ListalotesTableAdapter.Fill(Me.ComercialDataSet.listalotes)
        ListalotesBindingSource.Filter = "idloteenvio = 0 "
        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        BtnFinalizar.Enabled = False

    End Sub

    Private Sub FechaasignacionLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        '************************************************************************
        If Len(Trim(TextBox1.Text)) = 0 Then Return ' si el texto es vacio return
        '************************************************************************
        Try
            ListalotesBindingSource.Filter = "idloteenvio = " + TextBox1.Text
        Catch ex As Exception
            ListalotesBindingSource.Filter = "idloteenvio = 0 "
            MsgBox("El número ingresado no corresponde a un lote activo: " + ex.Message)
            TextBox1.Select()
            BtnFinalizar.Enabled = False
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            'MsgBox(LotesenviosTableAdapter.lotesenvios_consultarvigencia(Val(TextBox1.Text)).ToString)
            If ListalotesDataGridView.RowCount = 0 Then
                Throw New Exception("Lote inexistente!")
            End If
            If Not LotesenviosTableAdapter.lotesenvios_consultarvigencia(Val(TextBox1.Text)) > 0 Then
                Throw New Exception("Lote Inválido!")
            End If
        Catch ex As Exception
            MsgBox("Advertencia: " + ex.Message, MsgBoxStyle.Exclamation)
            Me.ListalotesdetalleTableAdapter.FillByIDloteenvio(Me.ComercialDataSet.listalotesdetalle, 0)
            TextBox1.Select()
            TextBox1.SelectAll()
            BtnFinalizar.Enabled = False
            Return
        End Try

        'MsgBox("Comencémos!")
        Me.ListalotesdetalleTableAdapter.FillByIDloteenvio(Me.ComercialDataSet.listalotesdetalle, Val(TextBox1.Text))
        BtnFinalizar.Enabled = True
        preconfiguracionpedidos()

    End Sub

    Private Sub ListalotesdetalleDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListalotesdetalleDataGridView.CellContentClick

    End Sub

    Private Sub ListalotesdetalleDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ListalotesdetalleDataGridView.CellValueChanged

    End Sub

    Private Sub ListalotesdetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ListalotesdetalleDataGridView.CellEndEdit
        If e.ColumnIndex = 8 Then
            Select Case ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("estadoentrega").Value
                Case "C"
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").Value = Nothing
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("nroguia").Value = Nothing
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").ReadOnly = True
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("nroguia").ReadOnly = True
                Case "E"
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").Value = Nothing
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("nroguia").Value = Nothing
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").ReadOnly = True
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("nroguia").ReadOnly = False
                Case "EP"
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").Value = ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("saldo").Value
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").ReadOnly = True
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("nroguia").ReadOnly = False
                Case "ESCC"
                    'ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells(10).Value = "0"
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").Value = Nothing
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").ReadOnly = False
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("nroguia").ReadOnly = False
                Case "NA"
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").Value = Nothing
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("nroguia").Value = Nothing
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("montoapagar").ReadOnly = True
                    ListalotesdetalleDataGridView.Rows(e.RowIndex).Cells("nroguia").ReadOnly = True
            End Select
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        Dim rtn As Boolean = True

        validarestadoentrega(rtn, rtn_mensaje)
        If rtn = False Then
            MsgBox(rtn_mensaje, MsgBoxStyle.Exclamation)
            Return
        End If
        'MsgBox("exito!")
        'Return ' removeonly
        '******************************************************************************
        '***********    RENDICION DE LOTE  *******************************************
        '******************************************************************************
        Dim idventa As Long = 0
        Dim idlote As Long = ListalotesdetalleDataGridView.Rows(0).Cells("idloteenvio").Value
        For i = 0 To ListalotesdetalleDataGridView.RowCount - 1
            Dim v_rtn As Long = 0
            Dim idpedidodelivery As Long = ListalotesdetalleDataGridView.Rows(i).Cells("idpedidodelivery").Value
            Dim idcliente As Long = ListalotesdetalleDataGridView.Rows(i).Cells("idcliente").Value
            Dim importetotal As Decimal = ListalotesdetalleDataGridView.Rows(i).Cells("montototal").Value
            Dim montopagado As Decimal
            If IsDBNull(ListalotesdetalleDataGridView.Rows(i).Cells("importepagado").Value) Then
                montopagado = 0
            Else
                montopagado = Convert.ToDecimal(ListalotesdetalleDataGridView.Rows(i).Cells("importepagado").Value)
            End If
            Dim montoapagar As Decimal
            If IsDBNull(ListalotesdetalleDataGridView.Rows(i).Cells("montoapagar").Value) Then
                montoapagar = 0
            Else
                montoapagar = Convert.ToDecimal(ListalotesdetalleDataGridView.Rows(i).Cells("montoapagar").Value)
            End If
            'Dim idpagos As Long
            Dim idformapago As Long = 1
            Dim Idtipocomprobante As Integer = 1
            Dim nrocomprobante As String = Nothing
            'Dim estadoentrega As String = ListalotesdetalleDataGridView.Rows(i).Cells(9).Value
            Dim estadoentrega As String = ListalotesdetalleDataGridView.Rows(i).Cells("estadoentrega").Value
            Dim nroguia As String = ListalotesdetalleDataGridView.Rows(i).Cells(11).Value
            Dim idoperacioncaja As Long = 0
            Dim idventasdetalle As Long = 0

            '******************************************************************************
            '*********  ACCION DE ACUERDO AL ESTADO ENTREGA    ***************
            '******************************************************************************
            Select Case estadoentrega
                Case "C" 'CANCELAR
                    idventa = PedidosdeliveryTableAdapter.pedidosdelivery_consultaexisteventa(idpedidodelivery)
                    VentasTableAdapter.ventas_bajaventa(idventa, gusername)
                    PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("CANCELADO", idpedidodelivery)
                Case "NA" 'CANCELAR
                    PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("ENPROCESO", idpedidodelivery)
                Case Else
                    Try
                        '******************************************************************************
                        '*********  VERIFICO SI EL PEDIDO YA TIENE LA VENTA GENERADA    ***************
                        '******************************************************************************
                        idventa = PedidosdeliveryTableAdapter.pedidosdelivery_consultaexisteventa(idpedidodelivery)
                        If Not idventa > 0 Then
                            Throw New Exception("No se ha generado una venta para el pedido: " + idpedidodelivery.ToString)
                        End If
                        'If idventa = 0 Then ' NO TIENE LA VENTA GENERADA
                        '    '******************************************************************************
                        '    '***********    REGISTRAR VENTA     *******************************************
                        '    '******************************************************************************
                        '    idventa = VentasTableAdapter.ventas_insertarventa(idcliente, Today, idformapago, Idtipocomprobante, gusername, nrocomprobante)
                        '    If idventa = 0 Then
                        '        Throw New Exception("Error al guardar la venta")
                        '    End If
                        '    '******************************************************************************
                        '    '***********     VENTA DETALLE     *******************************************
                        '    '******************************************************************************
                        '    Me.PedidosdeliverydetalleTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.pedidosdeliverydetalle, idpedidodelivery)
                        '    Dim f As Integer
                        '    For f = 0 To PedidosdeliverydetalleDataGridView.RowCount - 1
                        '        Dim idproducto As Long = PedidosdeliverydetalleDataGridView.Rows(f).Cells(2).Value
                        '        Dim cantidad As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(3).Value
                        '        Dim precioventa As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(4).Value
                        '        Dim idlistaprecio As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(6).Value
                        '        idventasdetalle = VentasdetalleTableAdapter.ventasdetalle_insertardetalle(idventa, idproducto, cantidad, precioventa, idlistaprecio, Nothing)
                        '        If idventasdetalle = 0 Then
                        '            Throw New Exception("Error al INSERTAR el detalle de la venta")
                        '        End If
                        '    Next
                        '    '******************************************************************************
                        '    '***********    ACTUALIZAR PEDIDOSDELIVERY CON EL IDVENTA    *******************************************
                        '    '******************************************************************************
                        '    v_rtn = PedidosdeliveryTableAdapter.pedidosdelivery_updateidventa(idventa, idpedidodelivery)
                        '    If v_rtn = 0 Then
                        '        Throw New Exception("Error al actualizar la tabla pedidos -update:idventa-")
                        '    End If
                        'End If
                        '******************************************************************************
                        '***********    ACTUALIZAR EL ESTADO DE ENTREGA Y EL NUMERO DE GUIA EN EL LOTE    *******************************************
                        '******************************************************************************
                        v_rtn = LotesenviosdetalleTableAdapter.lotesenviosdetalle_updateestadoentrega(estadoentrega, nroguia, idlote, idpedidodelivery)
                        If v_rtn = 0 Then
                            Throw New Exception("Error al actualizar estado de entrega y guia - update: estadoentrega, nroguia - PEDIDO: " + idpedidodelivery.ToString)
                        Else
                            LotesenviosdetalleTableAdapter.lotesenviosdetalle_updatemontorendido(montoapagar, idpedidodelivery)
                        End If
                        '******************************************************************************
                        '***********    GENERAR EL PAGO    *******************************************
                        '******************************************************************************
                        'If Not montopagado = importetotal And montoapagar > 0 Then
                        '    '******************************************************************************
                        '    '***********    GENERAR EL PAGO    *******************************************
                        '    '******************************************************************************
                        '    idpagos = PagosTableAdapter.pagos_insertarpago(idventa, idcliente, montoapagar, Today(), idformapago, nrocomprobante)
                        '    If idpagos = 0 Then
                        '        Throw New Exception("Error al INSERTAR  el pago")
                        '    End If
                        '    '******************************************************************************
                        '    '***********    INSERTAR OPERACION DE CAJA    *******************************************
                        '    '******************************************************************************
                        '    idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(idevento, idpagos, idformapago, montoapagar, gusername, Nothing)
                        '    If idoperacioncaja = 0 Then
                        '        Throw New Exception("Error al insertar operacion de caja -cajasoperaciones-")
                        '    End If
                        'End If
                        PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("ENTREGADO", idpedidodelivery)
                    Catch ex As Exception
                        MsgBox("Ocurrio un error, no se puede continuar: " + ex.Message)
                        Return
                    End Try
            End Select



        Next
        '******************************************************************************
        '***********    CERRAR LOTE    *******************************************
        '******************************************************************************
        LotesenviosTableAdapter.lotesenvios_cerrarlote(Today(), gusername, idlote)
        MsgBox("Operacion exitosa! Lote de envío cerrado correctanente", MsgBoxStyle.Information)
        Dim p As ViewerLoteRendido
        p = New ViewerLoteRendido
        gidlote = idlote
        p.ShowDialog()
        gidlote = Nothing
        Me.Close()

    End Sub
    Private Sub validarestadoentrega(ByRef rtn As Boolean, ByRef rtn_mensaje As String)
        '***********************************************************************************************
        '*** validar estado de entrega  ************************
        '***********************************************************************************************
        For i = 0 To ListalotesdetalleDataGridView.RowCount - 1
            Dim transporte As String = ListalotesdetalleDataGridView.Rows(i).Cells("nombretransporte").Value
            Dim estadoentrega As String = ListalotesdetalleDataGridView.Rows(i).Cells("estadoentrega").Value
            Dim importetotal As Decimal = ListalotesdetalleDataGridView.Rows(i).Cells("montototal").Value
            Dim montopagado As Decimal
            If IsDBNull(ListalotesdetalleDataGridView.Rows(i).Cells("importepagado").Value) Then
                montopagado = 0
            Else
                montopagado = Convert.ToDecimal(ListalotesdetalleDataGridView.Rows(i).Cells("importepagado").Value)
            End If
            '**************************************************************************************************
            Dim montoapagar As Decimal
            If IsDBNull(ListalotesdetalleDataGridView.Rows(i).Cells("montoapagar").Value) Then
                montoapagar = 0
            Else
                montoapagar = Convert.ToDecimal(ListalotesdetalleDataGridView.Rows(i).Cells("montoapagar").Value)
            End If
            '***********************************************************************************************
            '****************************   VALIDAR CARGA DE ESTADO
            If estadoentrega = Nothing Then
                ListalotesdetalleDataGridView.Rows(i).Cells("estadoentrega").Selected = True
                rtn_mensaje = "Debe seleccionar un estado de entrega"
                rtn = False
                Return
            End If
            '****************************   VALIDAR MONTO CARGADO
            If montoapagar > importetotal Then
                ListalotesdetalleDataGridView.Rows(i).Cells("montoapagar").Selected = True
                rtn_mensaje = "El monto pagado no puede superar el monto a pagar"
                rtn = False
                Return
            End If
            '****************************   VALIDAR si se entregó que el monto pagado no sea cero
            If estadoentrega = "EP" Or estadoentrega = "ESCC" Then
                If montoapagar = 0 And montopagado = 0 Then
                    rtn_mensaje = "No puede ingresar monto cero (0)"
                    rtn = False
                    Return
                End If
                If montoapagar < 0 Then
                    rtn_mensaje = "No puede ingresar monto MENOR a cero (0)"
                    rtn = False
                    Return
                End If
            End If
            '************************** validar que solo el estado ENVIADO sea para pedidos NO LOCALES  ***********
            If transporte = "Delivery Local" And estadoentrega = "E" Then
                rtn_mensaje = "Debe seleccionar un estado de entrega válido!"
                rtn = False
                ListalotesdetalleDataGridView.Rows(i).Cells("estadoentrega").Selected = True
                Return
            End If
            '************************** validar que Envios por encomienda esten en estado E, C, NA  ***********
            If transporte <> "Delivery Local" Then
                If estadoentrega = "EP" Or estadoentrega = "ESCC" Then
                    rtn_mensaje = "Debe seleccionar un estado de entrega válido para encomiendas!"
                    rtn = False
                    ListalotesdetalleDataGridView.Rows(i).Cells("estadoentrega").Selected = True
                    Return
                End If
            End If
        Next
        rtn = True
        ''***    ************************
    End Sub
    Private Sub preconfiguracionpedidos()
        For i = 0 To ListalotesdetalleDataGridView.RowCount - 1
            'Dim estadoentrega As String = ListalotesdetalleDataGridView.Rows(i).Cells("estadoentrega").Value
            Dim transporte As String = ListalotesdetalleDataGridView.Rows(i).Cells("nombretransporte").Value
            If transporte = "Delivery Local" Then
                ListalotesdetalleDataGridView.Rows(i).Cells("estadoentrega").Value = "EP"
                ListalotesdetalleDataGridView.Rows(i).Cells("montoapagar").Value = ListalotesdetalleDataGridView.Rows(i).Cells("montototal").Value - ListalotesdetalleDataGridView.Rows(i).Cells("importepagado").Value
            End If
        Next
    End Sub

    Private Sub LotePedidosDeliveryRendir_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class