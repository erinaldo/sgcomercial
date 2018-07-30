Public Class PedidosDeliveryDespacho
    Private Sub PedidosDeliveryDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidosdeliverydetalle' Puede moverla o quitarla según sea necesario.
        'Me.PedidosdeliverydetalleTableAdapter.Fill(Me.ComercialDataSet.pedidosdeliverydetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listalotes' Puede moverla o quitarla según sea necesario.
        Me.listalotesTableAdapter.Fill(Me.ComercialDataSet.listalotes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listalotesdetalle' Puede moverla o quitarla según sea necesario.
        Me.listalotesdetalleTableAdapter.Fill(Me.ComercialDataSet.listalotesdetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidosdelivery' Puede moverla o quitarla según sea necesario.
        Me.PedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.pedidosdelivery)

        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.responsablesdelivery' Puede moverla o quitarla según sea necesario.
        Me.ResponsablesdeliveryTableAdapter.Fill(Me.ComercialDataSet.responsablesdelivery)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidosdelivery' Puede moverla o quitarla según sea necesario.
        Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
        ListapedidosdeliveryBindingSource.Filter = "estado = 'ENPROCESO'"
        ComboBoxResponsables.SelectedIndex = 0

    End Sub
    Private Sub RefreshGrid()
        Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
        ListapedidosdeliveryBindingSource.Filter = "estado = 'ENPROCESO'"
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListapedidosdeliveryDataGridView.CellContentClick
        gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value
        gidventa = 0
        gidventa = PedidosdeliveryTableAdapter.pedidosdelivery_consultaexisteventa(gidpedidodelivery)
        ' CONSULTAR SI EL PEDIDO EN CUESTION TIENE GENERADA LA VENTA
        '*****************************************************************
        'If gidventa > 0 Then
        '    Dim newrow As Long = LotesEnviosDetalleDataGridView.Rows.Add
        '    LotesEnviosDetalleDataGridView.Rows(newrow).Cells(1).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value
        '    LotesEnviosDetalleDataGridView.Rows(newrow).Cells(2).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(4).Value
        '    LotesEnviosDetalleDataGridView.Rows(newrow).Cells(3).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(6).Value
        '    LotesEnviosDetalleDataGridView.Rows(newrow).Cells(4).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(10).Value
        '    LotesEnviosDetalleDataGridView.Rows(newrow).Cells(5).Value = "si"
        'Else '*****************************************************************
        '    Dim pagado As String = "no"
        '    Select Case e.ColumnIndex
        '        Case 0 ' se agrega el pedido clickeado a la lista
        '            ' verifico que el pedido seleccionado NO exista en el lote
        '            '-------------------------------------------------
        '            For i = 0 To LotesEnviosDetalleDataGridView.RowCount() - 1
        '                If ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value = LotesEnviosDetalleDataGridView.Rows(i).Cells(1).Value Then
        '                    MsgBox("El pedido ya se incluyó en el lote actual!", MsgBoxStyle.Exclamation)
        '                    Return
        '                End If
        '            Next
        '            ' verifico si el delivery es en la rioja capital... si no es debe cargar el pago    
        '            '-------------------------------------------------
        '            If Trim(ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(8).Value) = "La Rioja" Then
        '                If Trim(ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(9).Value) = "La Rioja" Or Trim(ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(9).Value) = "Capital" Then
        '                    pagado = "si"
        '                Else
        '                    If IsDBNull(ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(11).Value) Then
        '                        MsgBox("Debe cargar el pago", MsgBoxStyle.Information)
        '                        Dim p As PedidosDeliveryPagar
        '                        p = New PedidosDeliveryPagar
        '                        gidpago = 0
        '                        gidventa = 0
        '                        'gmontoapagar = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(12).Value
        '                        gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value
        '                        gidcliente = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(10).Value
        '                        p.ShowDialog()
        '                        If gidpago = 0 Or gidventa = 0 Then
        '                            MsgBox("No se pudo procesar el pago!", MsgBoxStyle.Exclamation)
        '                            Return
        '                        End If
        '                        If gidpago = -1 And gidventa = -1 Then
        '                            pagado = "cc"
        '                        Else
        '                            pagado = "si"
        '                        End If

        '                    Else
        '                        pagado = "si"
        '                    End If
        '                End If
        '            Else
        '                If IsDBNull(ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(11).Value) Then
        '                    MsgBox("Debe cargar el pago", MsgBoxStyle.Information)
        '                    Dim p As PedidosDeliveryPagar
        '                    p = New PedidosDeliveryPagar
        '                    gidpago = 0
        '                    gidventa = 0
        '                    'gmontoapagar = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(12).Value
        '                    gidpedidodelivery = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value
        '                    gidcliente = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(10).Value
        '                    p.ShowDialog()
        '                    If gidpago = 0 Or gidventa = 0 Then
        '                        MsgBox("No se pudo procesar el pago!", MsgBoxStyle.Exclamation)
        '                        Return
        '                    End If
        '                    If gidpago = -1 And gidventa = -1 Then
        '                        pagado = "cc"
        '                    Else
        '                        pagado = "si"
        '                    End If

        '                Else
        '                    pagado = "si"
        '                End If
        '            End If

        '            '-------------------------------------------------
        '            '-------------------------------------------------
        '            Dim newrow As Long = LotesEnviosDetalleDataGridView.Rows.Add
        '            LotesEnviosDetalleDataGridView.Rows(newrow).Cells(1).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value
        '            LotesEnviosDetalleDataGridView.Rows(newrow).Cells(2).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(4).Value
        '            LotesEnviosDetalleDataGridView.Rows(newrow).Cells(3).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(6).Value
        '            LotesEnviosDetalleDataGridView.Rows(newrow).Cells(4).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(10).Value
        '            LotesEnviosDetalleDataGridView.Rows(newrow).Cells(5).Value = pagado
        '    End Select
        'End If
        '*****************************************************************
        Dim newrow As Long = LotesEnviosDetalleDataGridView.Rows.Add
        LotesEnviosDetalleDataGridView.Rows(newrow).Cells(1).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(1).Value
        LotesEnviosDetalleDataGridView.Rows(newrow).Cells(2).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(4).Value
        LotesEnviosDetalleDataGridView.Rows(newrow).Cells(3).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(6).Value
        LotesEnviosDetalleDataGridView.Rows(newrow).Cells(4).Value = ListapedidosdeliveryDataGridView.Rows(e.RowIndex).Cells(10).Value
        LotesEnviosDetalleDataGridView.Rows(newrow).Cells(5).Value = "si"
    End Sub

    Private Sub LotesEnviosDetalleDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LotesEnviosDetalleDataGridView.CellContentClick

    End Sub

    Private Sub LotesEnviosDetalleDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles LotesEnviosDetalleDataGridView.KeyDown
        If e.KeyCode = Keys.Subtract Then
            Try
                LotesEnviosDetalleDataGridView.Rows.Remove(LotesEnviosDetalleDataGridView.CurrentRow)
            Catch ex As Exception

            End Try
            'recuento()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            ListapedidosdeliveryBindingSource.Filter = "nombre like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            ListapedidosdeliveryBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ButtonAsignar_Click(sender As Object, e As EventArgs) Handles ButtonAsignar.Click
        If ComboBoxResponsables.SelectedValue <= 0 Then
            MsgBox("Seleccione un responsable", MsgBoxStyle.Exclamation)
            ComboBoxResponsables.Select()
            Return
        End If
        If Not LotesEnviosDetalleDataGridView.RowCount > 0 Then
            MsgBox("Debe agregar pedidos al LOTE!", MsgBoxStyle.Exclamation)
            Return
        End If
        If MsgBox("Seguro desea generar el LOTE?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
            Return
        End If
        Dim idlote As Long
        'Dim idventasdetalle As Long
        Dim v_rtn As Long
        Try
            idlote = LotesenviosTableAdapter.lotesenvios_insertar(ComboBoxResponsables.SelectedValue, Today())
            If idlote = 0 Then
                Throw New Exception("Error al insertar un nuevo LOTE")
            End If
            Try
                For i = 0 To LotesEnviosDetalleDataGridView.RowCount - 1
                    ''******************************************************************************
                    ''***********    insertar pedido en el detalle del lote     *******************************************
                    ''******************************************************************************
                    v_rtn = LotesenviosdetalleTableAdapter.lotesenviosdetalle_insertar(idlote, LotesEnviosDetalleDataGridView.Rows(i).Cells(1).Value)
                    If v_rtn = 0 Then
                        Throw New Exception("Error al insertar el pedido en LotesDetalle")
                    End If

                    If LotesEnviosDetalleDataGridView.Rows(i).Cells(5).Value = "si" Then
                        Continue For
                    End If
                    ''******************************************************************************
                    ''***********    REGISTRAR VENTA     *******************************************
                    ''******************************************************************************
                    'Me.PedidosdeliverydetalleTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.pedidosdeliverydetalle, LotesEnviosDetalleDataGridView.Rows(i).Cells(1).Value)
                    'Me.ListapedidosdeliveryTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.listapedidosdelivery, LotesEnviosDetalleDataGridView.Rows(i).Cells(1).Value)
                    ''gidventa = VentasTableAdapter.ventas_insertarventa(gidcliente, Today, ComboFormapago.SelectedValue, ComboTipoComprobante.SelectedValue, gusername, nrocomprobante.Text)
                    'gidventa = VentasTableAdapter.ventas_insertarventa(LotesEnviosDetalleDataGridView.Rows(i).Cells(4).Value, Today, Nothing, Nothing, gusername, Nothing)
                    'If gidventa = 0 Then
                    '    Throw New Exception("Error al guardar la venta")
                    'End If
                    ''******************************************************************************
                    ''***********     VENTA DETALLE     *******************************************
                    ''******************************************************************************
                    'Me.PedidosdeliverydetalleTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.pedidosdeliverydetalle, LotesEnviosDetalleDataGridView.Rows(i).Cells(1).Value)
                    'Dim f As Integer
                    ''Dim idoperacioncaja As Long
                    'For f = 0 To PedidosdeliverydetalleDataGridView.RowCount - 1
                    '    Dim idproducto As Long = PedidosdeliverydetalleDataGridView.Rows(f).Cells(2).Value
                    '    Dim cantidad As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(3).Value
                    '    Dim precioventa As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(4).Value
                    '    Dim idlistaprecio As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(6).Value

                    '    idventasdetalle = VentasdetalleTableAdapter.ventasdetalle_insertardetalle(gidventa, idproducto, cantidad, precioventa, idlistaprecio, Nothing)
                    '    If idventasdetalle = 0 Then
                    '        Throw New Exception("Error al INSERTAR el detalle de la venta")
                    '    End If
                    'Next
                    ''******************************************************************************
                    ''***********    ACTUALIZAR PEDIDOSDELIVERY CON EL IDVENTA    *******************************************
                    ''******************************************************************************
                    'v_rtn = PedidosdeliveryTableAdapter.pedidosdelivery_updateidventa(gidventa, LotesEnviosDetalleDataGridView.Rows(i).Cells(1).Value)
                    'If v_rtn = 0 Then
                    '    Throw New Exception("Error al actualizar la tabla pedidos -update:idventa-")
                    'End If
                Next
                Try
                    For i = 0 To LotesEnviosDetalleDataGridView.RowCount - 1
                        PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("DESPACHADO", LotesEnviosDetalleDataGridView.Rows(i).Cells(1).Value)
                    Next
                    MsgBox("Lote N: " + idlote.ToString + " Generado!")
                    RefreshGrid()
                    LotesEnviosDetalleDataGridView.Rows.Clear()
                    ComboBoxResponsables.SelectedValue = -1
                Catch ex As Exception
                    MsgBox("Ocurrio un problema al intentar guardar el ESTADO del Pedido! " + ex.Message)
                    Return
                End Try
            Catch ex As Exception
                MsgBox("Ocurrio un problema al intentar guardar el DETALLE del lote! " + ex.Message)
                Return
            End Try
        Catch ex As Exception
            MsgBox("Ocurrio un problema al intentar guardar la CABECERA del lote! " + ex.Message)
            Return
        End Try
        Try
            imprimirreportelote(idlote)
        Catch ex As Exception
            MsgBox("Ocurrio un problema al intentar Imprimir el Lote " + ex.Message)
        End Try

    End Sub
    Private Sub imprimirreportelote(ByVal idlote As Long)

        LotesenviosBindingSource.Filter = "idloteenvio = " + idlote.ToString
        LotesenviosdetalleBindingSource.Filter = "idloteenvio = " + idlote.ToString
        If MsgBox("Desea imprimir el reporte?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            gidlote = idlote
            ViewerLoteEnvio.ShowDialog()
            gidlote = 0
        End If
    End Sub

    Private Sub ListapedidosdeliveryDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ListapedidosdeliveryDataGridView.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
            ListapedidosdeliveryBindingSource.Filter = "estado = 'ENPROCESO'"
        End If
    End Sub

    Private Sub PedidosDeliveryDespacho_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.ListapedidosdeliveryTableAdapter.Fill(Me.ComercialDataSet.listapedidosdelivery)
            ListapedidosdeliveryBindingSource.Filter = "estado = 'ENPROCESO'"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class