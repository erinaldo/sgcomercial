Imports System.Text.RegularExpressions
Public Class PedidosDeliveryPagar
    Dim idevento As Long
    Private Sub PedidosDeliveryPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipocomprobantes' Puede moverla o quitarla según sea necesario.
        Me.TipocomprobantesTableAdapter.Fill(Me.ComercialDataSet.tipocomprobantes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.formaspago' Puede moverla o quitarla según sea necesario.
        Me.FormaspagoTableAdapter.Fill(Me.ComercialDataSet.formaspago)
        Try
            'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidosdeliverydetalle' Puede moverla o quitarla según sea necesario.
            Me.PedidosdeliverydetalleTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.pedidosdeliverydetalle, gidpedidodelivery)
            'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidosdelivery' Puede moverla o quitarla según sea necesario.
            Me.ListapedidosdeliveryTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.listapedidosdelivery, gidpedidodelivery)
            TextBoxMontoaPagar.Text = ListapedidosdeliveryDataGridView.Rows(0).Cells(14).Value.ToString
            idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        Catch ex As Exception
            MsgBox("No se pudo cargar el pedido!", MsgBoxStyle.Exclamation)
            Return
        End Try
    End Sub
    Private Sub consultarestadocaja(ByRef estado As Boolean)
        '***************    consultar el estado de caja *************
        gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)
        If gidcaja = 0 Then
            MsgBox("Este ordenador no esta Registrado para operar como CAJA!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If

        Dim idevento As Integer
        'idcaja = CajasDataGridView.Rows(CajasDataGridView.CurrentRow.Index).Cells(0).Value
        'lblCaja.Text = "Caja Nº: " + idcaja.ToString
        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)

        If idevento = 0 Then
            MsgBox("Caja Cerrada. Abra la caja antes de registrar una venta o pago", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            estado = True
        End If
        '***************    FIN consultar el estado de caja *************
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        '********************** antes de cargar el pago consulto estado de la caja *****************************************
        Dim estado As Boolean = False
        consultarestadocaja(estado)
        If estado = False Then
            Return
        End If
        '***************************************************************
        If Not ComboTipoComprobante.SelectedIndex >= 0 Then
            MsgBox("Ingrese un tipo de comprobante válido!", MsgBoxStyle.Exclamation)
            ComboTipoComprobante.Select()
            Return
        End If
        If Not ComboFormapago.SelectedIndex >= 0 Then
            MsgBox("Ingrese una forma de pago válida!", MsgBoxStyle.Exclamation)
            ComboFormapago.Select()
            Return
        End If
        If Len(Trim(pagotextbox.Text)) = 0 Then
            MsgBox("Ingrese un monto válido!", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim pago As Decimal = pagotextbox.Text
        Dim idventasdetalle As Long
        Dim v_rtn As Long
        If pago <= 0 Then
            MsgBox("Monto inválido", MsgBoxStyle.Exclamation, "Advertencia")
            pagotextbox.Select()
            Return
        End If
        Try
            ''******************************************************************************
            ''***********    REGISTRAR VENTA     *******************************************
            ''******************************************************************************
            gidventa = VentasTableAdapter.ventas_insertarventa(gidcliente, Today, ComboFormapago.SelectedValue, ComboTipoComprobante.SelectedValue, gusername, nrocomprobante.Text)
            If gidventa = 0 Then
                Throw New Exception("Error al guardar la venta")
            End If
            ''******************************************************************************
            ''***********     VENTA DETALLE     *******************************************
            ''******************************************************************************
            Me.PedidosdeliverydetalleTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.pedidosdeliverydetalle, gidpedidodelivery)
            Dim f As Integer
            Dim idoperacioncaja As Long
            For f = 0 To PedidosdeliverydetalleDataGridView.RowCount - 1
                Dim idproducto As Long = PedidosdeliverydetalleDataGridView.Rows(f).Cells(2).Value
                Dim cantidad As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(3).Value
                Dim precioventa As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(4).Value
                Dim idlistaprecio As Decimal = PedidosdeliverydetalleDataGridView.Rows(f).Cells(6).Value

                idventasdetalle = VentasdetalleTableAdapter.ventasdetalle_insertardetalle(gidventa, idproducto, cantidad, precioventa, idlistaprecio, Nothing)
                If idventasdetalle = 0 Then
                    Throw New Exception("Error al INSERTAR el detalle de la venta")
                End If
            Next
            ''******************************************************************************
            ''***********    ACTUALIZAR PEDIDOSDELIVERY CON EL IDVENTA    *******************************************
            ''******************************************************************************
            v_rtn = PedidosdeliveryTableAdapter.pedidosdelivery_updateidventa(gidventa, gidpedidodelivery)
            If v_rtn = 0 Then
                Throw New Exception("Error al actualizar la tabla pedidos -update:idventa-")
            End If
            ''******************************************************************************
            ''***********    GENERAR EL PAGO    *******************************************
            ''******************************************************************************
            gidpago = PagosTableAdapter.pagos_insertarpago(gidventa, gidcliente, pago, Today(), ComboFormapago.SelectedValue, nrocomprobante.Text)
            If gidpago = 0 Then
                Throw New Exception("Error al INSERTAR  el pago")
            End If
            '******************************************************************************
            '***********    INSERTAR OPERACION DE CAJA    *******************************************
            '******************************************************************************
            idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(idevento, gidpago, ComboFormapago.SelectedValue, pago, gusername, Nothing)
            If idoperacioncaja = 0 Then
                Throw New Exception("Error al insertar operacion de caja -cajasoperaciones-")
            End If
            MsgBox("Pago cargado exitosamente!", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox("No se puede continuar: " + ex.Message)
        End Try

        'End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles pagotextbox.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pagotextbox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        gidpago = -1
        gidventa = -1
        Me.Close()
    End Sub
End Class