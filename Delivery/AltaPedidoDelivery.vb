Imports System.Text.RegularExpressions
Public Class AltaPedidoDelivery
    Dim productodisponible As Decimal
    Dim productodisponibleenvasado As Decimal
    Dim v_precioventa As Decimal
    Dim rtn As Boolean
    Dim v_valdatosnuevosclientes As String
    Dim StrError As New StrError
    Dim StrDatosFacturacion As New StrDatosFacturacion
    Dim idevento As Long
    Dim CajaseventosTableAdapter As New comercialDataSetTableAdapters.cajaseventosTableAdapter()
    Dim EstadoCaja As String

    Private Sub AltaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------------------------------------------------------
        Me.KeyPreview = True
        Me.Icon = SCFORMICON
        '---------------------------------------------------------------
        Me.TipocondicionivaTableAdapter.Fill(Me.ComercialDataSet.tipocondicioniva)
        Me.TipodocumentosTableAdapter.Fill(Me.ComercialDataSet.tipodocumentos)
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet.unidadesmedida)
        Me.ListaspreciosTableAdapter.FillByEstado(Me.ComercialDataSet.listasprecios, 1)
        Me.TransportesTableAdapter.Fill(Me.ComercialDataSet.transportes)
        Me.LocalidadesTableAdapter.Fill(Me.ComercialDataSet.localidades)
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)



        ClientesBindingSource.Filter = "idcliente = 0"
        ClientesdomiciliosBindingSource.Filter = "idcliente = 0"
        LabelTotal.Text = Nothing
        CheckBoxNuevoCliente.Checked = False
        enableedit(False)
        '/**************        defaluts    ****************/
        ComboBoxLocalidad.Enabled = False
        ComboBoxProvincia.SelectedIndex = 0
        ComboBoxLocalidad.SelectedIndex = 0
        ComboBoxProvincia.Enabled = False
        ComboBox1.SelectedIndex = 0
        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        '***************    consultar el estado de caja *************
        ConsultarEstadoCaja()
        '***************    FIN consultar el estado de caja *************
    End Sub
    Private Sub ConsultarEstadoCaja()
        If GetEstadoCaja() = 0 Then
            CheckBoxFacturar.Enabled = True
        Else
            CheckBoxFacturar.Enabled = False
        End If
    End Sub
    Private Sub enableedit(ByVal status As String)
        TextBoxNombreCliente.Enabled = status
        TextBoxTelefono.Enabled = status
        TextBoxEmail.Enabled = status
        TextBoxCuit.Enabled = status
        TextBoxDireccion.Enabled = status
        TextBoxReferencias.Enabled = status
        TextBoxCP.Enabled = status
        ComboDocTipo.Enabled = status
        ComboCondicionIVA.Enabled = status
        'ComboBoxTransporte.Enabled = status
    End Sub

    Private Sub IdclienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdclienteTextBox.TextChanged

    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        SeleccionarCliente()
    End Sub
    Public Sub SeleccionarCliente()
        gclienteseleccionado = 0
        Dim p As SeleccionarCliente
        p = New SeleccionarCliente
        p.ShowDialog()
        IdclienteTextBox.Text = gclienteseleccionado.ToString
        If gclienteseleccionado > 0 Then
            Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
            ClientesBindingSource.Filter = "idcliente = " + IdclienteTextBox.Text
            Me.ClientesdomiciliosTableAdapter.FillByidcliente(Me.ComercialDataSet.clientesdomicilios, gclienteseleccionado)
            ClientesdomiciliosBindingSource.Filter = "idcliente = " + IdclienteTextBox.Text
        End If
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProvincia.SelectedIndexChanged
        Try
            'MsgBox("idprovincia = " + ComboBox2.SelectedValue.ToString)
            LocalidadesBindingSource.Filter = "idprovincia = " + ComboBoxProvincia.SelectedValue.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNuevoCliente.CheckedChanged
        NuevoCliente()
    End Sub
    Public Sub NuevoCliente()
        If CheckBoxNuevoCliente.Checked Then
            IdclienteTextBox.Text = Nothing
            PictureSeleccionarCliente.Enabled = False
            PictureBoxEditarDomicilios.Enabled = False
            ClientesBindingSource.Filter = "idcliente = 0 "
            ClientesdomiciliosBindingSource.Filter = "idcliente = 0 "
            ComboBoxProvincia.SelectedIndex = 0
            ComboBoxLocalidad.SelectedIndex = 0
            enableedit(True)
            TextBoxNombreCliente.Select()
            ComboBoxTransporte.SelectedIndex = 0
            PictureBoxEditarCliente.Enabled = False

        Else
            IdclienteTextBox.Text = Nothing
            PictureBoxEditarDomicilios.Enabled = True
            PictureSeleccionarCliente.Enabled = True
            enableedit(False)
            ComboBoxTransporte.SelectedIndex = 0
            PictureBoxEditarCliente.Enabled = True
        End If
    End Sub

    Private Sub DataGridViewDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VentasdetalleDataGridView.CellContentClick

    End Sub

    Private Sub DataGridViewDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles VentasdetalleDataGridView.KeyDown
        'MsgBox(e.KeyCode.ToString)
        If e.KeyCode = Keys.Add Then
            buscaproductomanual()
            recuento()
        End If
        If e.KeyCode = Keys.Subtract Then
            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            recuento()
        End If
        If e.KeyCode = Keys.Multiply Then
            Dim p As SeleccionarCantidad
            p = New SeleccionarCantidad
            gcodigoproducto = 0
            p.ShowDialog()
            'p.TextBox1.Text = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow).Cells(3).Value
            VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("cantidad").Value = gcantidad
            gprecioventa = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("gprecioventa").Value
            VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("SubTotal").Value = Convert.ToDecimal(gcantidad * gprecioventa) '*--- subtotal
            recuento()
        End If
    End Sub
    Public Sub buscaproductomanual()
        gcantidad = 0
        Dim idproducto As Long
        Dim descripcion As String
        Dim newrow As Long
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        Dim medida As Decimal
        glistaprecio = 0
        glistapreferida = ComboBox1.SelectedValue
        Dim p As BuscaProductoManualPedidos
        p = New BuscaProductoManualPedidos
        p.ShowDialog()
        ''***********************
        If Val(gcantidad) = 0 Then Return
        If gcodigoproducto = Nothing Then Return
        v_precioventa = gprecioventa
        idproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
        '-------------------------------------------------------------------------
        Dim StockGeneralTableAdapter As New comercialDataSetTableAdapters.stockgeneralTableAdapter()
        Dim StockGralDataTable As New comercialDataSet.stockgeneralDataTable()
        StockGralDataTable = StockGeneralTableAdapter.GetDataByProductSheet(gcodigoproducto)
        '!!-------------------------------------------
        If StockGralDataTable.Count > 0 Then
            productodisponible = StockGralDataTable.Rows(0)("disponible")
            productodisponibleenvasado = StockGralDataTable.Rows(0)("unidades")
            descripcion = StockGralDataTable.Rows(0)("producto")
            unidadmedida = StockGralDataTable.Rows(0)("unidadmedida")
            medida = StockGralDataTable.Rows(0)("medidavalor")
        End If
        '-------------------------------************************************-------------------------------------------
        If VentasdetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
            newrow = VentasdetalleDataGridView.Rows.Add()
            VentasdetalleDataGridView.Rows(newrow).Cells("idproducto").Value = idproducto
            VentasdetalleDataGridView.Rows(newrow).Cells("codigoproducto").Value = gcodigoproducto
            VentasdetalleDataGridView.Rows(newrow).Cells("descripcion").Value = descripcion
            VentasdetalleDataGridView.Rows(newrow).Cells("cantidad").Value = gcantidad '*******  cantidad
            VentasdetalleDataGridView.Rows(newrow).Cells("unidadmedida").Value = unidadmedida
            VentasdetalleDataGridView.Rows(newrow).Cells("medida").Value = medida
            VentasdetalleDataGridView.Rows(newrow).Cells("precioventa").Value = gprecioventa
            VentasdetalleDataGridView.Rows(newrow).Cells("SubTotal").Value = gmontototal '*--- subtotal
            VentasdetalleDataGridView.Rows(newrow).Cells("idlistaprecio").Value = glistaprecio '*--- glistaprecio
            VentasdetalleDataGridView.Select()
            recuento()
            Return
        Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
            Dim i As Integer
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                If gcodigoproducto = VentasdetalleDataGridView.Rows(i).Cells(1).Value Then '** ARTICULO ENCONTRADO
                    VentasdetalleDataGridView.Rows(newrow).Cells("idproducto").Value = idproducto
                    VentasdetalleDataGridView.Rows(i).Cells("codigoproducto").Value = gcodigoproducto
                    VentasdetalleDataGridView.Rows(i).Cells("descripcion").Value = descripcion
                    VentasdetalleDataGridView.Rows(i).Cells("cantidad").Value = gcantidad '*******  cantidad
                    VentasdetalleDataGridView.Rows(i).Cells("unidadmedida").Value = unidadmedida
                    VentasdetalleDataGridView.Rows(i).Cells("medida").Value = medida
                    VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value = gprecioventa
                    VentasdetalleDataGridView.Rows(i).Cells("SubTotal").Value = gmontototal '*--- subtotal
                    VentasdetalleDataGridView.Rows(i).Cells("idlistaprecio").Value = glistaprecio '*--- glistaprecio
                    VentasdetalleDataGridView.Select()
                    recuento()
                    Return
                Else
                    addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                End If
            Next
            If addnewrow = True Then
                newrow = VentasdetalleDataGridView.Rows.Add()
                VentasdetalleDataGridView.Rows(newrow).Cells("idproducto").Value = idproducto
                VentasdetalleDataGridView.Rows(newrow).Cells("codigoproducto").Value = gcodigoproducto
                VentasdetalleDataGridView.Rows(newrow).Cells("descripcion").Value = descripcion
                VentasdetalleDataGridView.Rows(newrow).Cells("cantidad").Value = gcantidad '*******  cantidad
                VentasdetalleDataGridView.Rows(newrow).Cells("unidadmedida").Value = unidadmedida
                VentasdetalleDataGridView.Rows(newrow).Cells("medida").Value = medida
                VentasdetalleDataGridView.Rows(newrow).Cells("precioventa").Value = gprecioventa
                VentasdetalleDataGridView.Rows(newrow).Cells("SubTotal").Value = gmontototal '*--- subtotal
                VentasdetalleDataGridView.Rows(newrow).Cells("idlistaprecio").Value = glistaprecio '*--- glistaprecio
                VentasdetalleDataGridView.Select()
                recuento()
                Return
            End If
        End If
        '*************************
    End Sub
    Private Sub recuento()
        Dim i As Integer
        Dim total As Decimal = 0
        For i = 0 To VentasdetalleDataGridView.RowCount - 1
            total += VentasdetalleDataGridView.Rows(i).Cells(7).Value
        Next
        LabelTotal.Text = total
    End Sub
    Private Sub validarcargadatos(ByRef rtn As Boolean)
        If Len(Trim(TextBoxPagaCon.Text)) = 0 Then
            TextBoxPagaCon.Text = "0"
        End If

        If Not CheckBoxNuevoCliente.Checked Then
            If IdclienteTextBox.Text = "" Or IdclienteTextBox.Text = "0" Then
                MsgBox("Seleccione un cliente válido", MsgBoxStyle.Exclamation)
                CheckBoxNuevoCliente.Select()
                rtn = False
                Return
            Else
                If CheckBoxFacturar.Enabled = True And CheckBoxFacturar.Checked = True Then
                    Dim idcliente As Long
                    idcliente = Val(IdclienteTextBox.Text)
                    StrError = ValidarDatosClienteAFIP(idcliente)
                    If StrError.CodError > 1 Then
                        MessageBox.Show(StrError.MsgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        rtn = False
                        Return
                    End If
                End If
            End If
        End If
        If Len(Trim(TextBoxNombreCliente.Text)) = 0 Then
            MsgBox("Cargar Nombre", MsgBoxStyle.Exclamation)
            TextBoxNombreCliente.Select()
            rtn = False
            Return
        End If
        If Not ComboDocTipo.SelectedValue > 0 Then
            MsgBox("Cargar Tipo Documento", MsgBoxStyle.Exclamation)
            ComboDocTipo.Select()
            rtn = False
            Return
        End If
        If Len(Trim(TextBoxCuit.Text)) = 0 Then
            MsgBox("Cargar DNI/CUIL/CUIT", MsgBoxStyle.Exclamation)
            TextBoxCuit.Select()
            rtn = False
            Return
        End If
        If Not ComboCondicionIVA.SelectedValue > 0 Then
            MsgBox("Cargar Condición IVA", MsgBoxStyle.Exclamation)
            ComboCondicionIVA.Select()
            rtn = False
            Return
        End If
        'If Len(Trim(TextBoxTelefono.Text)) = 0 Then
        '    MsgBox("Cargar Teléfono", MsgBoxStyle.Exclamation)
        '    TextBoxTelefono.Select()
        '    rtn = False
        '    Return
        'End If
        'If Len(Trim(TextBoxEmail.Text)) = 0 Then
        '    MsgBox("Cargar Email", MsgBoxStyle.Exclamation)
        '    TextBoxEmail.Select()
        '    rtn = False
        '    Return
        'End If
        If Len(Trim(TextBoxDireccion.Text)) = 0 Then
            MsgBox("Cargar Dirección", MsgBoxStyle.Exclamation)
            TextBoxDireccion.Select()
            rtn = False
            Return
        End If
        If Len(Trim(TextBoxReferencias.Text)) = 0 Then
            MsgBox("Cargar Referencia", MsgBoxStyle.Exclamation)
            TextBoxReferencias.Select()
            rtn = False
            Return
        End If
        If Len(Trim(TextBoxCP.Text)) = 0 Then
            MsgBox("Cargar Código Postal", MsgBoxStyle.Exclamation)
            TextBoxCP.Select()
            rtn = False
            Return
        End If
        If Not ComboBoxTransporte.SelectedValue > 0 Then
            MsgBox("Cargar Transporte", MsgBoxStyle.Exclamation)
            ComboBoxTransporte.Select()
            rtn = False
            Return
        End If
        If Not ComboBoxProvincia.SelectedValue > 0 Then
            MsgBox("Cargar Provincia", MsgBoxStyle.Exclamation)
            ComboBoxProvincia.Select()
            rtn = False
            Return
        End If
        If Not ComboBoxLocalidad.SelectedValue > 0 Then
            MsgBox("Cargar Localidad", MsgBoxStyle.Exclamation)
            ComboBoxLocalidad.Select()
            rtn = False
            Return
        End If
        '/**************************************/
        rtn = True '****** todo OK
        Return
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If VentasdetalleDataGridView.RowCount = 0 Then
            MsgBox("Debe cargar un producto!", MsgBoxStyle.Exclamation)
            Return
        End If
        validarcargadatos(rtn)
        If rtn = False Then
            Return
        End If
        If CheckBoxFacturar.Checked Then
            Dim StrError As New StrError
            GetDatosFacturacion(StrError)
            If StrError.CodError = -1 Then
                Return
            End If
        End If
        If Not MessageBox.Show("Seguro desea Guardar el pedido?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Return
        End If
        '*******************************************************************************************************
        Dim nvocliente As Long
        Dim nvodomicilio As Long
        Dim nvopedido As Long
        Dim idtipodocumento As Long
        Dim condicioniva As Long
        If CheckBoxNuevoCliente.Checked Then '***** es NUEVO CLIENTE
            Try
                idtipodocumento = ComboDocTipo.SelectedValue
                condicioniva = ComboCondicionIVA.SelectedValue
                nvocliente = ClientesTableAdapter.clientes_insertar(Nothing, TextBoxNombreCliente.Text, TextBoxTelefono.Text, TextBoxEmail.Text, TextBoxCuit.Text, idtipodocumento, condicioniva, "SYS")
                nvodomicilio = ClientesdomiciliosTableAdapter.clientesdomicilios_insertar(nvocliente, TextBoxDireccion.Text, TextBoxReferencias.Text, Val(ComboBoxProvincia.SelectedValue), Val(ComboBoxLocalidad.SelectedValue), TextBoxCP.Text, Nothing, Nothing, Nothing)
                '*************************
            Catch ex As Exception
                MsgBox("Ocurrio un error al tratar de guardar los datos del nuevo cliente: " + ex.Message)
                Return
            End Try
        Else '***** es VIEJO CLIENTE
            nvocliente = Val(IdclienteTextBox.Text)
            nvodomicilio = ClientesdomiciliosDataGridView.Rows(0).Cells(0).Value
        End If
        '*****************************************
        '********** ValidarDatosClientesNuevos
        Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        v_valdatosnuevosclientes = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ValDatosNuevosClientes")
        If v_valdatosnuevosclientes = "SI" Then
            Dim strerror As New StrError()
            strerror = ValidarDatosClienteAFIP(nvocliente)
            If strerror.CodError > 1 Then
                MessageBox.Show(strerror.MsgError, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CheckBoxNuevoCliente.Checked = False
                IdclienteTextBox.Text = nvocliente.ToString
                Return
            End If
        End If
        '********** END ValidarDatosClientesNuevos END
        '*****************************************  INSERTAR PEDIDODELIVERY ***************************************************************
        Try
            nvopedido = PedidosdeliveryTableAdapter.pedidosdelivery_insertar(nvocliente, Nothing, ComboBoxTransporte.SelectedValue, nvodomicilio, Convert.ToDecimal(TextBoxPagaCon.Text), Today, gusername, Nothing, Nothing, TextBoxObs.Text, DateTimePickerFechaaEntregar.Value)
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                Dim idproducto As Long = VentasdetalleDataGridView.Rows(i).Cells("idproducto").Value
                Dim cantidad As Decimal = VentasdetalleDataGridView.Rows(i).Cells("cantidad").Value
                Dim precioventa As Decimal = VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value
                Dim idlistaprecio As Long = VentasdetalleDataGridView.Rows(i).Cells("idlistaprecio").Value
                '****** INSERTAR PEDIDODELIVERY    DETALLE **********
                PedidosdeliverydetalleTableAdapter.pedidosdeliverydetalle_insertar(nvopedido, idproducto, cantidad, precioventa, Nothing, idlistaprecio)
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un problema al tratar de guardar el pedido: " + ex.Message, MsgBoxStyle.Exclamation)
            Return
        End Try
        PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("RECIBIDO", nvopedido)
        '****** REGISTRAR VENTA **********
        Try
            Dim nvavta As Long
            Dim fechavencimiento As Date
            If StrDatosFacturacion.fechavencimiento < Today() Then
                fechavencimiento = Today()
            Else
                fechavencimiento = StrDatosFacturacion.fechavencimiento
            End If
            nvavta = VentasTableAdapter.ventas_insertarventa(nvocliente, Now(), StrDatosFacturacion.idformapago, 1, gusername, StrDatosFacturacion.nrocbtexterno, fechavencimiento, 1)
            gidventa = nvavta
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                Dim idproducto As Long = VentasdetalleDataGridView.Rows(i).Cells("idproducto").Value
                Dim cantidad As Decimal = VentasdetalleDataGridView.Rows(i).Cells("cantidad").Value
                Dim precioventa As Decimal = VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value
                Dim idlistaprecio As Long = VentasdetalleDataGridView.Rows(i).Cells("idlistaprecio").Value
                '****** REGISTRAR VENTA     DETALLE **********
                VentasdetalleTableAdapter.ventasdetalle_insertardetalle(nvavta, idproducto, cantidad, precioventa, idlistaprecio, Nothing, Nothing) ' descuento
                PedidosdeliveryTableAdapter.pedidosdelivery_updateidventa(nvavta, nvopedido)
            Next
        Catch ex As Exception
            MsgEx("No se pudo registrar la venta: " + ex.Message)
        End Try
        '****** FIN REGISTRAR VENTA **********
        '=================== FUNCIONES CLOWD NUBE  ================================
        If gModuloCloud = 1 Then
            BGWStockClowd.RunWorkerAsync()
            If Not (BackgroundSyncLibroventasClowd.IsBusy) Then
                BackgroundSyncLibroventasClowd.RunWorkerAsync()
            End If
        End If
        '===================  FIN FUNCIONES CLOWD NUBE  ================================
        RegistrarFactura(nvocliente, gidventa)
        MsgSuccessPopUp("Pedido cargado exitosanente!")
        'Me.Close()
        CheckBoxNuevoCliente.Checked = False
        CheckBoxNuevoCliente.Checked = True
        IdclienteTextBox.Text = Nothing
        PictureSeleccionarCliente.Enabled = False
        PictureBoxEditarDomicilios.Enabled = False
        ClientesBindingSource.Filter = "idcliente = 0 "
        ClientesdomiciliosBindingSource.Filter = "idcliente = 0 "
        ComboBoxProvincia.SelectedIndex = 0
        ComboBoxLocalidad.SelectedIndex = 0
        enableedit(True)
        TextBoxNombreCliente.Select()
        ComboBoxTransporte.SelectedIndex = 0
        limpiar()

    End Sub
    Private Sub limpiar()
        TextBoxNombreCliente.Text = Nothing
        TextBoxTelefono.Text = Nothing
        TextBoxCuit.Text = Nothing
        TextBoxEmail.Text = Nothing
        TextBoxDireccion.Text = Nothing
        TextBoxReferencias.Text = Nothing
        TextBoxCP.Text = Nothing
        VentasdetalleDataGridView.Rows.Clear()
        TextBoxObs.Text = Nothing
        CheckBoxFacturar.Checked = False
        StrDatosFacturacion.Idtipocomprobante = Nothing
        StrDatosFacturacion.idformapago = Nothing
        StrDatosFacturacion.idconcepto = Nothing
        StrDatosFacturacion.fechaventa = Nothing
        StrDatosFacturacion.fechavencimiento = Nothing
        StrDatosFacturacion.montofacturado = Nothing
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBoxEditarDomicilios.Click
        If Val(IdclienteTextBox.Text) = 0 Then Return
        Dim P As ClientesNuevoDomicilio
        P = New ClientesNuevoDomicilio
        gdomicilioseleccionado = 0
        gclienteseleccionado = Val(IdclienteTextBox.Text)
        P.ShowDialog()
        If gdomicilioseleccionado = 0 Then Return
        ' MsgBox("paso")
        Me.ClientesdomiciliosTableAdapter.FillByiddomicilio(Me.ComercialDataSet.clientesdomicilios, gdomicilioseleccionado)
        ClientesdomiciliosBindingSource.Filter = "iddomicilio = " + gdomicilioseleccionado.ToString
    End Sub

    Private Sub TextBoxCuit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCuit.TextChanged

    End Sub

    Private Sub TextBoxCuit_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCuit.KeyDown
        If e.KeyCode = Keys.Tab Then
            TextBoxDireccion.Select()
        End If
    End Sub

    Private Sub ComboBoxLocalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLocalidad.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxLocalidad_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxLocalidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            VentasdetalleDataGridView.Select()
        End If
    End Sub

    Private Sub ComboBoxTransporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTransporte.SelectedIndexChanged
        If ComboBoxTransporte.SelectedIndex = 0 Then
            ComboBoxLocalidad.SelectedIndex = 0
            ComboBoxLocalidad.Enabled = False
            ComboBoxProvincia.SelectedIndex = 0
            ComboBoxProvincia.Enabled = False
        Else
            ComboBoxLocalidad.SelectedIndex = 0
            ComboBoxLocalidad.Enabled = True
            ComboBoxProvincia.SelectedIndex = 0
            ComboBoxProvincia.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxTransporte_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxTransporte.KeyDown
        If e.KeyCode = Keys.Enter Then
            VentasdetalleDataGridView.Select()
        End If
    End Sub

    Private Sub TextBoxTelefono_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTelefono.TextChanged

    End Sub

    Private Sub TextBoxTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelefono.KeyPress
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

    Private Sub TextBoxCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCuit.KeyPress
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

    Private Sub TextBoxPagaCon_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPagaCon.TextChanged

    End Sub

    Private Sub TextBoxPagaCon_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPagaCon.KeyDown

    End Sub

    Private Sub TextBoxPagaCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPagaCon.KeyPress
        ' Check for the flag being set in the KeyDown event.
        'If nonNumberEntered = True Then
        '    ' Stop the character from being entered into the control since it is non-numerical.
        '    e.Handled = True
        'End If
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        glistapreferida = ComboBox1.SelectedValue
        'MsgBox(glistapreferida.ToString)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click, Label24.Click

    End Sub

    Private Sub AltaPedidoDelivery_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        '***********************************************
        If e.KeyCode = Keys.Add Then
            e.SuppressKeyPress = True
            buscaproductomanual()
            recuento()
        End If
        If e.KeyCode = Keys.Subtract Then
            e.SuppressKeyPress = True
            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            recuento()
        End If
        If e.KeyCode = Keys.Multiply Then
            e.SuppressKeyPress = True
            Dim p As SeleccionarCantidad
            p = New SeleccionarCantidad
            gcodigoproducto = 0
            p.ShowDialog()
            'p.TextBox1.Text = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow).Cells(3).Value
            VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("cantidad").Value = gcantidad
            gprecioventa = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("precioventa").Value
            VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("SubTotal").Value = Convert.ToDecimal(gcantidad * gprecioventa) '*--- subtotal
            recuento()
        End If
        If e.KeyCode = Keys.F3 Then
            BtnConfirmar.PerformClick()
        End If

        If e.KeyCode = Keys.F2 Then
            ConsultarEstadoCaja()
            '------------------------------------------------------
            If CheckBoxFacturar.Enabled = False Then Return
            '------------------------------------------------------
            If CheckBoxFacturar.Checked Then
                CheckBoxFacturar.Checked = False
            Else
                CheckBoxFacturar.Checked = True
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            If CheckBoxNuevoCliente.Checked Then
                CheckBoxNuevoCliente.Checked = False
                SeleccionarCliente()
            Else
                CheckBoxNuevoCliente.Checked = True
                NuevoCliente()
            End If
        End If
    End Sub

    Private Sub BGWStockClowd_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWStockClowd.DoWork
        Dim coderror As Long
        Dim msgerror As String = Nothing
        SynStockClowd(gidventa, "V", coderror, msgerror)
    End Sub

    Private Sub BackgroundSyncLibroventasClowd_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundSyncLibroventasClowd.DoWork
        Dim coderror As Integer
        Dim msgerror As String = ""
        'gMiSucursal = 1
        SynLibroVentas(coderror, msgerror)
    End Sub

    Private Sub ComboDocTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDocTipo.SelectedIndexChanged
        If ComboDocTipo.SelectedValue = Nothing Then Return
        Try
            If TextBoxNombreCliente.Enabled = True Then
                Select Case ComboDocTipo.SelectedValue
                    Case 3
                        TextBoxCuit.Text = "0"
                        TextBoxCuit.Enabled = False
                    Case Else
                        TextBoxCuit.Text = ""
                        TextBoxCuit.Enabled = True
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBoxEditarCliente_Click(sender As Object, e As EventArgs) Handles PictureBoxEditarCliente.Click
        Dim p As ABMClientes
        p = New ABMClientes
        gclienteseleccionado = Val(IdclienteTextBox.Text)
        p.ShowDialog()
        If gclienteseleccionado > 0 Then
            Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
            ClientesBindingSource.Filter = "idcliente = " + IdclienteTextBox.Text
            Me.ClientesdomiciliosTableAdapter.FillByidcliente(Me.ComercialDataSet.clientesdomicilios, gclienteseleccionado)
            ClientesdomiciliosBindingSource.Filter = "idcliente = " + IdclienteTextBox.Text
        End If
    End Sub

    Private Sub VentasdetalleDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles VentasdetalleDataGridView.CellClick
        Try
            Select Case VentasdetalleDataGridView.Columns(e.ColumnIndex).Name
                Case "cantidad"
                    Dim p As SeleccionarCantidad
                    p = New SeleccionarCantidad
                    gcodigoproducto = 0
                    p.ShowDialog()
                    VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("cantidad").Value = gcantidad
                    gprecioventa = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("precioventa").Value
                    VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("SubTotal").Value = Convert.ToDecimal(gcantidad * gprecioventa) '*--- subtotal
                    recuento()
            End Select
        Catch ex As Exception
            MsgErrPopUp("Ocurrió un problema al intentar calcular precio y cantidad")
            VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("cantidad").Value = 0
            VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells("SubTotal").Value = 0
        End Try
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim porcentaje As Decimal
        Try
            gclienteseleccionado = Val(IdclienteTextBox.Text)

            If gclienteseleccionado > 0 Then
                porcentaje = ClientesTableAdapter.clientes_consultardescuento(gclienteseleccionado)
                descuentogeneral(porcentaje)
            End If
        Catch ex As Exception
            MsgEx("Ocurrio una excepción: " + ex.Message)
        End Try
    End Sub
    Private Sub descuentogeneral(ByRef porcentaje As Decimal)
        For i = 0 To VentasdetalleDataGridView.RowCount - 1
            Dim precioventa As Decimal
            Dim montodescuento As Decimal
            Dim cantidad As Decimal
            precioventa = VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value
            cantidad = VentasdetalleDataGridView.Rows(i).Cells("cantidad").Value
            precioventa = precioventa * cantidad
            montodescuento = precioventa * porcentaje / 100
            montodescuento = String.Format("{0:n}", montodescuento)
            VentasdetalleDataGridView.Rows(i).Cells("descuento").Value = montodescuento
        Next
        recuento()

    End Sub

    Private Sub CheckBoxFacturar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFacturar.CheckedChanged

    End Sub
    Private Sub RegistrarFactura(ByVal idcliente As Long, ByVal idventa As Long)
        '-------------------------------------------------------------------
        If CheckBoxFacturar.Checked = False Then Return
        If StrDatosFacturacion.Idtipocomprobante = 1 Then Return
        '-------------------------------------------------------------------
        StrError = ValidarDatosClienteAFIP(idcliente)
        If StrError.CodError > 1 Then
            MessageBox.Show(StrError.MsgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        '-----------------------------------------------
        RegistrarPago(idcliente, idventa, StrError)
        If StrError.CodError > 1 Then
            MessageBox.Show(StrError.MsgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        '-----------------------------------------------
        Try
            Dim VentasTableAdapter As New comercialDataSetTableAdapters.ventasTableAdapter()
            VentasTableAdapter.ventas_updateidtipocomprobante(StrDatosFacturacion.Idtipocomprobante, idventa)
        Catch ex As Exception
            MessageBox.Show("No se pudo completar la actualización del tipo de comprobante", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try
        '-----------------------------------------------
        'If MessageBox.Show("Seguro desea Registrar el Comprobante en AFIP?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Return
        '-----------------  REGISTRAR FACTURA ELECTRÓNICA   ----------------------------------------
        '********************************************************************************************
        '================================================================================================================================
        If GFEAFIPENTORNO = "HOMOLOGACION" Or GFEAFIPENTORNO = "PRODUCCION" Then
            Dim FECAERequest As New WSFEV1.FECAERequest()
            Dim TRA As String = Nothing
            '========================================================================================
            '       generacion TRA
            '========================================================================================
            StrError = GenTRA(TRA)
            If StrError.CodError > 1 Then
                MessageBox.Show(StrError.MsgError, "No se pudo completar la operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                '========================================================================================
                '       Generación Factura Electrónica
                '========================================================================================
                StrError = FECAELoadRequest(gidventa, FECAERequest)
                If StrError.CodError > 0 Then
                    MessageBox.Show(StrError.MsgError, "No se pudo completar la operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                '-----------    SALIO TODO OK IMPRIMO FACTURA -----------
                ImprimirFactura(idventa)
                '----------------------------------------------------- saliendo del if
            End If
        Else
            '-----------    SALIO TODO OK IMPRIMO TICKET NO FACTURA -----------
            ImprimirFactura(idventa)
        End If
    End Sub
    Private Sub GetDatosFacturacion(ByRef StrError As StrError)
        StrDatosFacturacion.Idtipocomprobante = Nothing
        StrDatosFacturacion.idformapago = Nothing
        StrDatosFacturacion.idconcepto = Nothing
        StrDatosFacturacion.fechaventa = Nothing
        StrDatosFacturacion.fechavencimiento = Nothing
        StrDatosFacturacion.montofacturado = Nothing
        Try
            With PopUpGetDatosFacturacion
                gTipoCbtSeleccionado = Nothing
                .FechaventaDateTimePicker.Value = Today
                .FechaventaDateTimePicker.Enabled = False
                .FechavencimientoDateTimePicker.Value = Today
                .TextBoxImporte.Text = LabelTotal.Text
                .ShowDialog()
                If gTipoCbtSeleccionado = 1 Then 'si es uno aceptó
                    StrDatosFacturacion.Idtipocomprobante = .Idtipocomprobantecombo.SelectedValue
                    StrDatosFacturacion.idformapago = .idformapagocombo.SelectedValue
                    StrDatosFacturacion.idconcepto = .ComboConcepto.SelectedValue
                    StrDatosFacturacion.fechaventa = .FechaventaDateTimePicker.Value
                    StrDatosFacturacion.fechavencimiento = .FechavencimientoDateTimePicker.Value
                    StrDatosFacturacion.montofacturado = Convert.ToDecimal(.TextBoxImporte.Text)
                    gTipoCbtSeleccionado = Nothing
                    StrError.CodError = 1
                Else 'si es distinto canceló
                    StrDatosFacturacion.Idtipocomprobante = Nothing
                    StrDatosFacturacion.idformapago = Nothing
                    StrDatosFacturacion.idconcepto = Nothing
                    StrDatosFacturacion.fechaventa = Nothing
                    StrDatosFacturacion.fechavencimiento = Nothing
                    StrDatosFacturacion.montofacturado = Nothing
                    CheckBoxFacturar.Checked = False
                    gTipoCbtSeleccionado = Nothing
                    StrError.CodError = -1
                    Return
                End If
            End With
        Catch ex As Exception
            StrDatosFacturacion.Idtipocomprobante = Nothing
            StrDatosFacturacion.idformapago = Nothing
            StrDatosFacturacion.idconcepto = Nothing
            StrDatosFacturacion.fechaventa = Nothing
            StrDatosFacturacion.fechavencimiento = Nothing
            StrDatosFacturacion.montofacturado = Nothing
        End Try
    End Sub
    Private Sub RegistrarPago(ByVal idcliente As Long, ByVal idventas As Long, ByVal StrError As StrError)
        Dim CajasoperacionesTableAdapter As New comercialDataSetTableAdapters.cajasoperacionesTableAdapter()
        Dim idoperacioncaja As Long
        '*******************************
        If StrDatosFacturacion.idformapago = 7 And (StrDatosFacturacion.Idtipocomprobante <> 3 And StrDatosFacturacion.Idtipocomprobante <> 4 And StrDatosFacturacion.Idtipocomprobante <> 6 And StrDatosFacturacion.Idtipocomprobante <> 7 And StrDatosFacturacion.Idtipocomprobante <> 9 And StrDatosFacturacion.Idtipocomprobante <> 10 And StrDatosFacturacion.Idtipocomprobante <> 12 And StrDatosFacturacion.Idtipocomprobante <> 13) Then 'ES CUENTA CORRIENTE
            ''**************************************************************
            ''***** CUENTA CORRIENTE MOVIMIENTO DE CAJA
            ''************************************************************** que sea CC y que no sea ningun tipo de Nota de C/D

            idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarvtactacte(idevento, Nothing, StrDatosFacturacion.idformapago, StrDatosFacturacion.montofacturado, gusername, Nothing, idventas)
            If Not idoperacioncaja > 0 Then
                StrError.CodError = 2
                StrError.MsgError = "Ocurrio un error al registrar el movimiento de caja"
                Return
            End If
        Else
            '**************************************************************
            '***** INSERTAR PAGO COMÚN
            '**************************************************************
            Dim idpagos As Long
            Dim PagosTableAdapter As New comercialDataSetTableAdapters.pagosTableAdapter()
            Dim PagosImputacionesTableAdapter As New comercialDataSetTableAdapters.pagosimputacionesTableAdapter()

            idpagos = PagosTableAdapter.pagos_insertarpago(idventas, idcliente, StrDatosFacturacion.montofacturado, StrDatosFacturacion.fechaventa, StrDatosFacturacion.idformapago, StrDatosFacturacion.nrocbtexterno)
            If idpagos > 0 Then
                PagosImputacionesTableAdapter.pagosimputaciones_insertar(idpagos, idventas, StrDatosFacturacion.montofacturado)
            Else
                StrError.CodError = 2
                StrError.MsgError = "Ocurrio un error al registrar el pago"
                Return
            End If
            '**************************************************************
            '***** insertar movimiento de caja
            '**************************************************************
            idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(idevento, idpagos, StrDatosFacturacion.idformapago, StrDatosFacturacion.montofacturado, gusername, Nothing)
            If Not idoperacioncaja > 0 Then
                StrError.CodError = 2
                StrError.MsgError = "Ocurrio un error al registrar el movimiento de caja"
                Return
            End If
        End If
    End Sub
End Class