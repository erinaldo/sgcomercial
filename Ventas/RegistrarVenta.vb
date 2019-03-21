Imports System.Text.RegularExpressions

Public Class RegistrarVenta
    Dim idevento As Long = 0
    Dim idoperacioncaja As Long = 0
    Dim existeproducto As Long = 0
    Dim productodisponible As Decimal = 0
    Dim productodisponibleenvasado As Decimal = 0
    Dim v_precioventa As Decimal
    Dim idventas As Long
    Dim idpagos As Long
    Dim idventasdetalle As Long
    Dim newrow As Long
    Dim precio As Decimal = 0
    Dim total As Decimal = 0
    Dim BCScanerCR As String
    Dim ValidarSTK As String
    Dim permisoGenVale As Integer = 0
    Dim diasvencimiento As Integer = 0

    Private nonNumberEntered As Boolean = False
    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub


    Private Sub VentasBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub RegistrarVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        'Me.WindowState = FormWindowState.Maximized
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listasprecios' Puede moverla o quitarla según sea necesario.
        Me.ListaspreciosTableAdapter.Fill(Me.ComercialDataSet.listasprecios)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.ComercialDataSet.stock)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.ComercialDataSet.pagos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        '/******************************************/
        IdclienteTextBox.Text = "1"
        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        '************************************************
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipocomprobantes' Puede moverla o quitarla según sea necesario.
        Me.TipocomprobantesTableAdapter.Fill(Me.ComercialDataSet.tipocomprobantes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.formaspago' Puede moverla o quitarla según sea necesario.
        Me.FormaspagoTableAdapter.Fill(Me.ComercialDataSet.formaspago)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.ventasdetalle' Puede moverla o quitarla según sea necesario.
        Me.VentasdetalleTableAdapter.Fill(Me.ComercialDataSet.ventasdetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.ventas' Puede moverla o quitarla según sea necesario.
        'Me.VentasTableAdapter.Fill(Me.ComercialDataSet.ventas)
        enablefields(False)
        BtnCancelar.Enabled = False
        BtnNueva.Enabled = True
        BtnConfirmar.Enabled = False
        Labelproducto.Text = ""
        stockdisp.Visible = False
        NrocomprobanteTextBox.Text = ""
        FechavencimientoDateTimePicker.Enabled = False

        '******************* 
        '****** BCScanerCR
        '******************* 
        Select Case gidcaja
            Case 1
                BCScanerCR = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("BCScanerCR1")
            Case 2
                BCScanerCR = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("BCScanerCR2")
        End Select
        '******************* 
        '****** GenVale
        '*******************
        Dim permiso As Integer = 0
        permisoGenVale = PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "GenerarVale")
        '********** ValidarSTK
        ValidarSTK = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ValidarSTK")
        '********************************************************************************************************
        '********** GBalPrefix
        gbalprefix = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("BalPrefix")
        '********************************************************************************************************
        ''''''''''''''''''''''''''''--CLOWD--''''''''''''''''''''''''''''''''''''''''''''''
        Dim ModulosTableAdapter As comercialDataSetTableAdapters.modulosTableAdapter
        ModulosTableAdapter = New comercialDataSetTableAdapters.modulosTableAdapter()
        gModuloClowd = ModulosTableAdapter.modulos_consultarestado("ModuloClowd")
        If gModuloClowd = 1 Then
            NeedSyncProductos()
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'idformapagocombo2.Items.Remove(idformapagocombo2.FindString("Cuenta Corriente"))
        'idformapagocombo2.Items.RemoveAt(idformapagocombo2.FindString("Cuenta Corriente"))
        'idformapagocombo2.Items.RemoveAt(idformapagocombo2.FindString("Otros"))
        'idformapagocombo2.Items.RemoveAt(idformapagocombo2.FindString("Cheque"))
        Cursor.Current = Cursors.Default
        BtnNueva.PerformClick()
    End Sub
    Private Sub enablefields(ByRef status As Boolean)
        'IdventaTextBox.Enabled = status
        NrocomprobanteTextBox.Enabled = status
        IdclienteTextBox.Enabled = status
        FechaventaDateTimePicker.Enabled = False
        idformapagocombo.Enabled = status
        Idtipocomprobantecombo.Enabled = status
        codigotextbox.Enabled = status
        PictureSeleccionarCliente.Enabled = status
        VentasdetalleDataGridView.Enabled = status
        pagotextbox.Enabled = status
        PictureBox1.Enabled = status
        'BtnDescuento.Enabled = status
        CheckBoxFP2.Enabled = status
        LabelMontoFP2.Enabled = status
        ButtonDescuentoDefecto.Visible = False
        '''''''''''''''''''''''''''' permiso GenVale
        If permisoGenVale = 0 Then
            CheckBoxVale.Enabled = False
        Else
            CheckBoxVale.Enabled = status
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub BtnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNueva.Click
        enablefields(True)
        BtnNueva.Enabled = False
        BtnCancelar.Enabled = True
        BtnConfirmar.Enabled = True
        codigotextbox.Select()
        IdclienteTextBox.Text = "1"
        labeltotal.Text = ""
        idformapagocombo.SelectedIndex = 0
        NrocomprobanteTextBox.Text = Nothing
        '''''''''''''''''''''''''''' permiso GenVale
        If permisoGenVale = 0 Then
            CheckBoxVale.Enabled = False
        Else
            CheckBoxVale.Enabled = True
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''
        CheckBoxFP2.Checked = False
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        BtnNueva.Enabled = True
        BtnConfirmar.Enabled = False
        BtnCancelar.Enabled = False
        Labelproducto.Text = ""
        labelcliente.Text = ""
        IdclienteTextBox.Text = ""
        vueltotextbox.Text = ""
        pagotextbox.Text = ""
        enablefields(False)
        VentasdetalleDataGridView.Rows.Clear()
        codigotextbox.Text = ""
        labeltotal.Text = ""
        NrocomprobanteTextBox.Text = ""
        gclienteseleccionado = Nothing
        CheckBoxFP2.Checked = False
        pagotextbox2.Text = ""
        NrocomprobanteTextBox2.Text = ""
        LabelMontoFP2.Enabled = False
        FechavencimientoDateTimePicker.Value = Today
        FechavencimientoDateTimePicker.Enabled = False
    End Sub
    Private Sub BtnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmar.Click
        Dim ErrorLogTableAdapter As comercialDataSetTableAdapters.errorlogTableAdapter
        ErrorLogTableAdapter = New comercialDataSetTableAdapters.errorlogTableAdapter()
        '=======================================
        Dim valida As Boolean
        validardatos(valida)
        If valida = False Then Return
        '================================
        Dim idproducto As Long
        'If pagotextbox.Text = "" And Not idformapagocombo.Text = "Cuenta Corriente" Then Return
        Dim pago As Decimal = pagotextbox.Text
        Dim tot As Decimal = labeltotal.Text
        Dim monto1 As Decimal
        Dim monto2 As Decimal
        '*******************
        '****************************   validar FORMAS DE PAGO  ****************************
        If CheckBoxFP2.Checked = True Then
            Try
                monto1 = pagotextbox.Text
                monto2 = pagotextbox2.Text
                If monto1 < 0 Or monto2 < 0 Then
                    MsgBox("Monto Incorrecto", MsgBoxStyle.Exclamation, "Advertencia")
                    Return
                End If
                pago = monto1 + monto2
                If Not pago = tot Then
                    MsgBox("Monto Incorrecto", MsgBoxStyle.Exclamation, "Advertencia")
                    pagotextbox.Select()
                    Return
                End If
            Catch ex2 As Exception
                MsgBox("Montos Incorrectos! " + ex2.Message, MsgBoxStyle.Exclamation, "Aviso!")
            End Try
        Else
            If VentasdetalleDataGridView.RowCount = 0 Then
                MsgBox("Debe ingresar al menos un (1) producto!", MsgBoxStyle.Exclamation, "Advertencia")
                Return
            End If
            If pago < tot Then
                MsgBox("Monto insuficiente", MsgBoxStyle.Exclamation, "Advertencia")
                pagotextbox.Select()
                Return
            End If
        End If
        FechaventaDateTimePicker.Value = Now
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''' DATOS CARGADOS CORRECTAMENTE! GUARDAMOS LA VENTA  '''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If MsgBox("Seguro desea guardar la venta?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Dim idvale As Integer = Nothing
            '***** PREGUNTO SI SE VA insertar VALE    ****************
            If CheckBoxVale.Checked = True Then
                Dim vuelto As Decimal = vueltotextbox.Text
                gmontovale = vuelto
                IngresaMontoVale.TextBox1.Text = gmontovale
                IngresaMontoVale.ShowDialog()
                If gmontovale > 0 Then
                    idvale = ValesTableAdapter.vales_insertar("Vuelto", gmontovale, gusername)
                    MsgBox("Vale N°:" + vbTab + idvale.ToString + vbTab + " Generado exitosamente!")
                    '***** calculo el monto total de la venta
                    total = total + gmontovale
                Else
                    MsgBox("No seleccionó el monto del vale! Operación cancelada!", MsgBoxStyle.Exclamation, "Advertencia!")
                    Return
                End If
            Else '***************       NO SE GENERA VALE
                total = labeltotal.Text
            End If
            'total = labeltotal.Text
            '********* insertar cabecera
            idventas = VentasTableAdapter.ventas_insertarventa(Val(IdclienteTextBox.Text), FechaventaDateTimePicker.Value, idformapagocombo.SelectedValue, Idtipocomprobantecombo.SelectedValue, gusername, NrocomprobanteTextBox.Text, FechavencimientoDateTimePicker.Value)
            'MsgBox(idventas.ToString)
            '********* insertar detalle
            Dim i As Integer = 0
            Dim recalocal As Decimal
            '********************   obtiene recargo si corresponde ******************
            If idformapagocombo.Text = "Tarjeta de Crédito" And grecargoTC > 0 Then
                recalocal = grecargoTC
            Else
                recalocal = 0
            End If
            '******** fin recargo
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                If ProductosTableAdapter.productos_existeproducto(VentasdetalleDataGridView.Rows(i).Cells(0).Value) > 0 Then
                    idproducto = ProductosTableAdapter.productos_existeproducto(VentasdetalleDataGridView.Rows(i).Cells(0).Value)
                Else
                    idproducto = 0
                End If
                '***************************************************
                'INSERTAR EN VENTASDETALLE
                '***************************************************
                Try
                    Dim recargo As Decimal = 0
                    If IsDBNull(VentasdetalleDataGridView.Rows(i).Cells("recargo").Value) = False Then
                        recargo = VentasdetalleDataGridView.Rows(i).Cells("recargo").Value
                    End If

                    idventasdetalle = VentasdetalleTableAdapter.ventasdetalle_insertardetalle(idventas, idproducto, Convert.ToDecimal(VentasdetalleDataGridView.Rows(i).Cells("cantidad").Value), Convert.ToDecimal(VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value), VentasdetalleDataGridView.Rows(i).Cells("listasprecios").Value, recargo, Convert.ToDecimal(VentasdetalleDataGridView.Rows(i).Cells("descuento").Value)) '// descuento
                Catch ex As Exception
                    MsgBox("Error al grabar el detalle: " + ex.Message)
                    VentasTableAdapter.ventas_bajaventa(idventas, gusername)
                End Try

                If idventasdetalle > 0 Then
                Else
                    MsgBox("Ocurrio un error al intentar insetar detalle de la venta", MsgBoxStyle.Exclamation, "Advertencia")
                    Return
                End If
            Next

            '**************************************************************
            '************   PREGUNTO SI =NO= ES UNA VENTA A CUENTA CORRIENTE
            '**************************************************************
            If Not idformapagocombo.Text = "Cuenta Corriente" Then
                '**************************************************************
                '**** INSERTAR EL PAGO *******************************************
                '**************************************************************
                If CheckBoxFP2.Checked = True Then
                    '*****************  EL PRIMER PAGO COMBINADO   **********************
                    idpagos = PagosTableAdapter.pagos_insertarpago(idventas, Val(IdclienteTextBox.Text), monto1, Today(), idformapagocombo.SelectedValue, NrocomprobanteTextBox.Text)
                    If idpagos > 0 Then
                        '**************************************************************
                        '***** insertar movimiento de caja PAGO 1
                        '**************************************************************
                        idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(idevento, idpagos, idformapagocombo.SelectedValue, monto1, gusername, idvale)
                        If idoperacioncaja > 0 Then
                        Else
                            MsgBox("Ocurrio un error al registrar el movimiento de caja", MsgBoxStyle.Information, "Advertencia")
                            Return
                        End If
                        idpagos = Nothing
                    Else
                        MsgBox("Ocurrio un error al registrar el pago 1", MsgBoxStyle.Information, "Advertencia")
                        Return
                    End If
                    '*****************  EL SEGUNDO PAGO COMBINADO   **********************
                    idpagos = PagosTableAdapter.pagos_insertarpago(idventas, Val(IdclienteTextBox.Text), monto2, Today(), idformapagocombo2.SelectedValue, NrocomprobanteTextBox2.Text)
                    If idpagos > 0 Then
                        '**************************************************************
                        '***** insertar movimiento de caja PAGO 2
                        '**************************************************************
                        idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(idevento, idpagos, idformapagocombo2.SelectedValue, monto2, gusername, idvale)
                        If idoperacioncaja > 0 Then
                        Else
                            MsgBox("Ocurrio un error al registrar el movimiento de caja", MsgBoxStyle.Information, "Advertencia")
                            Return
                        End If
                    Else
                        MsgBox("Ocurrio un error al registrar el pago 2", MsgBoxStyle.Information, "Advertencia")
                        Return
                    End If
                Else
                    idpagos = PagosTableAdapter.pagos_insertarpago(idventas, Val(IdclienteTextBox.Text), total, Today(), idformapagocombo.SelectedValue, NrocomprobanteTextBox.Text)
                    If idpagos > 0 Then
                    Else
                        MsgBox("Ocurrio un error al registrar el pago", MsgBoxStyle.Information, "Advertencia")
                        Return
                    End If
                    '**************************************************************
                    '***** insertar movimiento de caja
                    '**************************************************************
                    idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(idevento, idpagos, idformapagocombo.SelectedValue, total, gusername, idvale)
                    If idoperacioncaja > 0 Then
                    Else
                        MsgBox("Ocurrio un error al registrar el movimiento de caja", MsgBoxStyle.Information, "Advertencia")
                        Return
                    End If
                End If
            End If

            '**************************************************************
            '================   VENTA REGISTRADA EXITOSAMENTE ======================
            '********************************************************************************************
            '=================== RESETAR CONTROLES  ================================
            resetearcontroles()
            '=================== FUNCIONES CLOWD NUBE  ================================
            If gModuloClowd = 1 Then
                gidventa = idventas
                BGWStockClowd.RunWorkerAsync()
                If Not (BackgroundSyncLibroventasClowd.IsBusy) Then
                    BackgroundSyncLibroventasClowd.RunWorkerAsync()
                End If
            End If
            '******************************************************************************************** 
            '****** impresion ticket
            '*****************************************************************************
            gidventa = idventas
            Dim impresion As String
            impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ImpresionTicket")
            Select Case impresion
                Case "Nunca"
                    'Radionunca.Checked = True
                Case "Siempre"
                    Try
                        Dim p As ViewerFactura
                        p = New ViewerFactura
                        'p.MdiParent = Me.ParentForm
                        p.ShowInTaskbar = True
                        'p.TopMost = True
                        p.ShowDialog()
                    Catch ex As Exception
                        ErrorLogTableAdapter.errorlog_insertar("Registrar Venta", "Aplicacion", "Confirmar", ex.Message)
                    End Try
                Case "Preguntar"
                    If MsgBox("Desea Imprimir el comprobante?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                        Try
                            Dim p As ViewerFactura
                            p = New ViewerFactura
                            'p.MdiParent = Me.ParentForm
                            p.ShowInTaskbar = True
                            'p.TopMost = True
                            p.ShowDialog()
                        Catch ex As Exception
                            ErrorLogTableAdapter.errorlog_insertar("Registrar Venta", "Aplicacion", "Confirmar", ex.Message)
                        End Try
                    End If
            End Select
            gidventa = Nothing
            FormPrincipal.reloadstock()
            labeltotal.Text = ""
            LabelTotalVisible.Text = "$"
            idformapagocombo.Enabled = False
            '**********
        Else
            Return
        End If
    End Sub
    Private Sub resetearcontroles()
        codigotextbox.Text = ""
        BtnCancelar.Enabled = False
        BtnNueva.Enabled = True
        BtnConfirmar.Enabled = False
        Labelproducto.Text = ""
        labelcliente.Text = ""
        IdclienteTextBox.Text = ""
        vueltotextbox.Text = ""
        pagotextbox.Text = ""
        LabelTotalVisible.Text = "$"
        NrocomprobanteTextBox.Text = ""
        VentasdetalleDataGridView.Rows.Clear()
        recuento()
        enablefields(False)
        CheckBoxFP2.Checked = False
        pagotextbox2.Text = ""
        NrocomprobanteTextBox2.Text = ""
        FechavencimientoDateTimePicker.Value = Today
        FechavencimientoDateTimePicker.Enabled = False
    End Sub
    Private Sub validardatos(ByRef valida As Boolean)
        '******************* valida cargade datos   *********************
        If idformapagocombo.Text = "Cuenta Corriente" And Val(IdclienteTextBox.Text) = 1 Then
            MsgBox("Seleccione un cliente válido!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        If VentasdetalleDataGridView.RowCount = 0 Then
            MsgBox("Debe ingresar al menos un (1) producto!", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return
        End If
        If Val(Idtipocomprobantecombo.SelectedValue) > 0 Then
        Else
            MsgBox("Seleccione un tipo de comprobante", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return
        End If
        If Val(IdclienteTextBox.Text) > 0 Then
        Else
            MsgBox("Seleccione un cliente válido", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return
        End If
        If Val(idformapagocombo.SelectedValue) > 0 Then
        Else
            MsgBox("Seleccione una forma de pago", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return
        End If

        If Val(pagotextbox.Text) < 0 Then
            If idformapagocombo.Text = "Cuenta Corriente" Then
                pagotextbox.Text = total.ToString
                CheckBoxFP2.Checked = False
            Else
                MsgBox("Monto 1 Incorrecto", MsgBoxStyle.Exclamation, "Advertencia")
                pagotextbox.Select()
                Return
            End If
        End If

        If CheckBoxFP2.Checked = True Then '**** forma de pago 2
            If Val(idformapagocombo2.SelectedValue) > 0 Then
            Else
                MsgBox("Seleccione una forma de pago 2", MsgBoxStyle.Exclamation, "Advertencia")
                valida = False
                Return
            End If
            If Val(pagotextbox2.Text) <= 0 Then
                MsgBox("Monto 2 insuficiente", MsgBoxStyle.Exclamation, "Advertencia")
                pagotextbox.Select()
                Return
            End If
        End If


        valida = True
    End Sub
    Private Sub buscaproductobalanza()
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        Dim codigoproducto As String = Convert.ToString(Val(Mid(codigotextbox.Text, 2, 6)))
        Dim stringcantidad As String = Convert.ToString(Val(Mid(codigotextbox.Text, 8, 2))) + "," + Mid(codigotextbox.Text, 10, 3)
        gcantidad = Convert.ToDecimal(stringcantidad)
        '***********************************************************
        existeproducto = ProductosTableAdapter.productos_existeproducto(codigoproducto)
        productodisponible = StockTableAdapter.stock_consultardisponible(existeproducto)
        unidadmedida = ProductosTableAdapter.productos_consultarunidadmedida(codigoproducto)
        If existeproducto > 0 Then ' existeproducto es el codigo de producto
            stockdisp.Text = "Stock: " + productodisponible.ToString
            Labelproducto.Text = ProductosTableAdapter.productos_consultardescripcion(codigoproducto)
            v_precioventa = ProductosTableAdapter.productos_consultarprecioventa(codigoproducto)
            If VentasdetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
                newrow = VentasdetalleDataGridView.Rows.Add()
                VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = codigoproducto
                VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
                If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
                Else
                    'Dim p As IngresaCantidad
                    'p = New IngresaCantidad
                    'gcantidad = 0
                    'gmontototal = 0
                    'p.codigoproducto = codigoproducto
                    'p.unidadmedida = unidadmedida
                    'p.precioventa = v_precioventa
                    'p.ShowDialog()
                    If gcantidad = 0 Then 'Or gmontototal = 0 Then
                        VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
                        Return
                    End If
                    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                End If
                VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = v_precioventa
                VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = v_precioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
                codigotextbox.SelectAll()
                codigotextbox.Select()
                recuento()
                Return
            Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
                Dim i As Integer
                For i = 0 To VentasdetalleDataGridView.RowCount - 1
                    If codigoproducto = VentasdetalleDataGridView.Rows(i).Cells(0).Value Then '** ARTICULO ENCONTRADO
                        If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                            VentasdetalleDataGridView.Rows(i).Cells(2).Value = VentasdetalleDataGridView.Rows(i).Cells(2).Value + gcantidad '*******  cantidad
                        Else
                            'Dim p As IngresaCantidad
                            'p = New IngresaCantidad
                            'gcantidad = 0
                            'p.codigoproducto = codigoproducto
                            'p.unidadmedida = unidadmedida
                            'p.precioventa = v_precioventa
                            'p.ShowDialog()
                            VentasdetalleDataGridView.Rows(i).Cells(2).Value = VentasdetalleDataGridView.Rows(i).Cells(2).Value + gcantidad '*******  cantidad
                        End If
                        VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value = v_precioventa * VentasdetalleDataGridView.Rows(i).Cells(2).Value
                        codigotextbox.SelectAll()
                        codigotextbox.Select()
                        recuento()
                        Return
                    Else
                        addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                    End If
                Next
                If addnewrow = True Then
                    newrow = VentasdetalleDataGridView.Rows.Add()
                    VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = codigoproducto
                    VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
                    If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                        VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
                    Else
                        'Dim p As IngresaCantidad
                        'p = New IngresaCantidad
                        'gcantidad = 0
                        'p.codigoproducto = codigoproducto
                        'p.unidadmedida = unidadmedida
                        'p.precioventa = v_precioventa
                        'p.ShowDialog()
                        VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                    End If
                    VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = v_precioventa
                    VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = v_precioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
                    codigotextbox.SelectAll()
                    codigotextbox.Select()
                    recuento()
                    Return
                End If
            End If
        Else
            Labelproducto.Text = ""
            MsgBox("Producto no encontrado", MsgBoxStyle.Exclamation, "Advertencia")
            'TextBox1.Text = ""
            'TextBox1.Select()
        End If
    End Sub

    Private Sub buscaproductoauto()
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        glistaprecio = 1
        existeproducto = ProductosTableAdapter.productos_existeproducto(codigotextbox.Text)
        productodisponible = StockTableAdapter.stock_consultardisponible(existeproducto)
        productodisponibleenvasado = StockTableAdapter.stock_consultardisponibleenvasado(existeproducto)
        unidadmedida = ProductosTableAdapter.productos_consultarunidadmedida(codigotextbox.Text)
        If existeproducto > 0 Then ' existeproducto ------------- es el codigo de producto
            stockdisp.Text = "Stock: " + productodisponible.ToString
            Labelproducto.Text = ProductosTableAdapter.productos_consultardescripcion(codigotextbox.Text)
            v_precioventa = ProductosTableAdapter.productos_consultarprecioventa(codigotextbox.Text)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If VentasdetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                newrow = VentasdetalleDataGridView.Rows.Add()
                VentasdetalleDataGridView.Rows(newrow).Selected = True
                VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = codigotextbox.Text
                VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
                If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                    If ValidarSTK = "Enable" Then
                        If Not productodisponible >= 1 Then ''''''' validar stock disponible
                            MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente")
                            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
                            codigotextbox.Select()
                            codigotextbox.SelectAll()
                            Return
                        End If
                    End If
                    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
                    gprecioventa = v_precioventa
                    VentasdetalleDataGridView.Rows(newrow).Cells("listasprecios").Value = glistaprecio
                Else    '****************** la unidad de medida es kilo litro o metros
                    Dim p As IngresaCantidad
                    p = New IngresaCantidad
                    gcantidad = 0
                    gmontototal = 0
                    glistaprecio = 0
                    p.codigoproducto = codigotextbox.Text
                    p.unidadmedida = unidadmedida
                    p.precioventa = v_precioventa
                    p.ShowDialog()
                    If gcantidad = 0 Or gmontototal = 0 Then
                        VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
                        Return
                    End If
                    '************************************************ comprobacion stock disponible
                    If ValidarSTK = "Enable" Then
                        Select Case glistaprecio
                            Case 2 'es venta a granel! POR KILO
                                If productodisponible < gcantidad Then
                                    MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto suelto insuficiente")
                                    VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
                                    codigotextbox.Select()
                                    codigotextbox.SelectAll()
                                    Return
                                End If
                            Case Else
                                If productodisponibleenvasado < gcantidad Then
                                    MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto envasado insuficiente")
                                    VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
                                    codigotextbox.Select()
                                    codigotextbox.SelectAll()
                                    Return
                                End If
                        End Select
                    End If
                    '************************************************ comprobacion stock disponible
                    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                End If
                VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = gprecioventa
                VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = gprecioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
                VentasdetalleDataGridView.Rows(newrow).Cells("listasprecios").Value = glistaprecio
                codigotextbox.SelectAll()
                codigotextbox.Select()
                recuento()
                Return
            Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
                Dim i As Integer
                gprecioventa = v_precioventa
                For i = 0 To VentasdetalleDataGridView.RowCount - 1
                    If codigotextbox.Text = VentasdetalleDataGridView.Rows(i).Cells(0).Value Then '** ARTICULO ENCONTRADO
                        If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                            gcantidad = VentasdetalleDataGridView.Rows(i).Cells(2).Value + 1   'incremento la cantidad existente en 1 para luego comparar si hay disponible
                            gprecioventa = v_precioventa
                            If ValidarSTK = "Enable" Then
                                If Not productodisponible >= gcantidad Then ''''''' validar stock disponible
                                    MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente")
                                    VentasdetalleDataGridView.Rows(i).Selected = True
                                    codigotextbox.Select()
                                    codigotextbox.SelectAll()
                                    Return
                                Else
                                    VentasdetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                                End If
                            Else
                                VentasdetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                            End If
                        Else '****************** la unidad de medida es kilo litro o metros
                            Dim p As IngresaCantidad
                            p = New IngresaCantidad
                            gcantidad = 0
                            glistaprecio = 0
                            p.codigoproducto = codigotextbox.Text
                            p.unidadmedida = unidadmedida
                            p.precioventa = v_precioventa
                            p.ShowDialog()
                            VentasdetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                            VentasdetalleDataGridView.Rows(i).Selected = True
                            '************************************************ comprobacion stock disponible
                            If ValidarSTK = "Enable" Then
                                Select Case glistaprecio
                                    Case 2 'es venta a granel! POR KILO
                                        If productodisponible < gcantidad Then
                                            MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto suelto insuficiente")
                                            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(i))
                                            codigotextbox.Select()
                                            codigotextbox.SelectAll()
                                            Return
                                        End If
                                    Case Else
                                        If productodisponibleenvasado < gcantidad Then
                                            MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto envasado insuficiente")
                                            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(i))
                                            codigotextbox.Select()
                                            codigotextbox.SelectAll()
                                            Return
                                        End If
                                End Select
                            End If
                            '************************************************ comprobacion stock disponible
                        End If
                        VentasdetalleDataGridView.Rows(i).Cells(3).Value = gprecioventa
                        VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value = gprecioventa * VentasdetalleDataGridView.Rows(i).Cells(2).Value 'subtotal
                        VentasdetalleDataGridView.Rows(i).Cells("listasprecios").Value = glistaprecio
                        codigotextbox.SelectAll()
                        codigotextbox.Select()
                        recuento()
                        Return
                    Else
                        addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                    End If
                Next
                If addnewrow = True Then
                    newrow = VentasdetalleDataGridView.Rows.Add()
                    VentasdetalleDataGridView.Rows(newrow).Selected = True
                    VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = codigotextbox.Text
                    VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
                    If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                        VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
                        If ValidarSTK = "Enable" Then
                            If Not productodisponible >= gcantidad Then ''''''' validar stock disponible
                                MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente")
                                VentasdetalleDataGridView.Rows(i).Selected = True
                                VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
                                Return
                            End If
                        End If
                    Else '************ la unidad de medida es kilo litro o metro
                        Dim p As IngresaCantidad
                        p = New IngresaCantidad
                        gcantidad = 0
                        glistaprecio = 0
                        p.codigoproducto = codigotextbox.Text
                        p.unidadmedida = unidadmedida
                        p.precioventa = v_precioventa
                        p.ShowDialog()
                        VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                        '************************************************ comprobacion stock disponible
                        If ValidarSTK = "Enable" Then
                            Select Case glistaprecio
                                Case 2 'es venta a granel! POR KILO
                                    If productodisponible < gcantidad Then
                                        MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto suelto insuficiente")
                                        VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(newrow))
                                        Return
                                    End If
                                Case Else
                                    If productodisponibleenvasado < gcantidad Then
                                        MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto envasado insuficiente")
                                        VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(newrow))
                                        Return
                                    End If
                            End Select
                        End If
                        '************************************************ comprobacion stock disponible
                    End If
                    VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = gprecioventa
                    VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = gprecioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
                    VentasdetalleDataGridView.Rows(newrow).Cells("listasprecios").Value = glistaprecio
                    codigotextbox.SelectAll()
                    codigotextbox.Select()
                    recuento()
                    Return
                End If
            End If
        Else
            Labelproducto.Text = ""
            'MsgBox("Producto no encontrado", MsgBoxStyle.Exclamation, "Advertencia")
            'TextBox1.Text = ""
            'TextBox1.Select()
        End If
    End Sub
    Public Sub buscaproductomanual()
        gcantidad = 0
        glistaprecio = 1
        productodisponible = StockTableAdapter.stock_consultardisponible(existeproducto)
        productodisponibleenvasado = StockTableAdapter.stock_consultardisponibleenvasado(existeproducto)
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        Dim p As BuscaProductoManualPedidos
        p = New BuscaProductoManualPedidos
        p.ShowDialog()
        '***********************
        If Val(gcantidad) = 0 Then Return
        Labelproducto.Text = gproductodescripcion
        v_precioventa = gprecioventa
        'codigotextbox.Text = gcodigoproducto
        If VentasdetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
            newrow = VentasdetalleDataGridView.Rows.Add()
            VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = gcodigoproducto
            VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
            If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
            Else '************ la unidad de medida es kilo litro o metro
                VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
            End If
            VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = v_precioventa
            VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = v_precioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
            VentasdetalleDataGridView.Rows(newrow).Cells("listasprecios").Value = glistaprecio
            codigotextbox.SelectAll()
            codigotextbox.Select()
            recuento()
            Return
        Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
            Dim i As Integer
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                If gcodigoproducto = VentasdetalleDataGridView.Rows(i).Cells(0).Value Then '** ARTICULO ENCONTRADO
                    If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                        VentasdetalleDataGridView.Rows(i).Cells(2).Value = VentasdetalleDataGridView.Rows(i).Cells(2).Value + 1 '*******  cantidad
                    Else
                        VentasdetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                        VentasdetalleDataGridView.Rows(i).Selected = True
                    End If
                    VentasdetalleDataGridView.Rows(i).Cells(3).Value = v_precioventa
                    VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value = v_precioventa * VentasdetalleDataGridView.Rows(i).Cells(2).Value
                    VentasdetalleDataGridView.Rows(i).Cells("listasprecios").Value = glistaprecio
                    codigotextbox.SelectAll()
                    codigotextbox.Select()
                    recuento()
                    Return
                Else
                    addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                End If
            Next
            If addnewrow = True Then
                newrow = VentasdetalleDataGridView.Rows.Add()
                VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = gcodigoproducto
                VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
                If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
                Else
                    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                    VentasdetalleDataGridView.Rows(newrow).Selected = True
                End If
                VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = v_precioventa
                VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = v_precioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
                VentasdetalleDataGridView.Rows(newrow).Cells("listasprecios").Value = glistaprecio
                codigotextbox.SelectAll()
                codigotextbox.Select()
                recuento()
                Return
            End If
        End If

        '*************************
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codigotextbox.TextChanged
        'LimpiarCodigo(codigotextbox.Text)
        If BCScanerCR = "Disable" Then
            If Len(Trim(codigotextbox.Text)) = 0 Then
                Labelproducto.Text = ""
                Return
            End If

            If Len(Trim(codigotextbox.Text)) = 13 And Mid(codigotextbox.Text, 1, 1) = gbalprefix And Len(codigotextbox.Text) = 13 Then
                Labelproducto.Text = "es balanza"
                buscaproductobalanza()
                Return
            End If

            If PictureBox1.BackColor = Color.Transparent Then
                buscaproductoauto()
            End If
        End If
    End Sub

    Private Sub VentasdetalleDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VentasdetalleDataGridView.CellClick
        Try
            Dim i As Integer = 0
            If VentasdetalleDataGridView.CurrentCell.ColumnIndex >= 0 Then
                Select Case VentasdetalleDataGridView.Columns(e.ColumnIndex).Name
                    Case "descuento"
                        Dim monto As Decimal
                        monto = VentasdetalleDataGridView.Rows(e.RowIndex).Cells("cantidad").Value * VentasdetalleDataGridView.Rows(e.RowIndex).Cells("precioventa").Value
                        Dim p As AplicarDescuento
                        p = New AplicarDescuento
                        gdescuentopc = 0
                        gdescuentoef = 0
                        p.ShowDialog()
                        If gdescuentopc = 0 And gdescuentoef = 0 Then
                            VentasdetalleDataGridView.Rows(e.RowIndex).Cells("subtotal").Value = monto
                            VentasdetalleDataGridView.Rows(e.RowIndex).Cells("descuento").Value = Nothing
                            recuento()
                            Return
                        End If
                        If gdescuentopc > 0 Then
                            VentasdetalleDataGridView.Rows(e.RowIndex).Cells("descuento").Value = Math.Round(monto * gdescuentopc / 100, 2)
                            VentasdetalleDataGridView.Rows(e.RowIndex).Cells("subtotal").Value = monto - Math.Round(monto * gdescuentopc / 100, 2)
                            codigotextbox.SelectAll()
                            codigotextbox.Select()
                            gdescuentopc = 0
                            recuento()
                        End If
                        If gdescuentoef > 0 Then
                            VentasdetalleDataGridView.Rows(e.RowIndex).Cells("descuento").Value = String.Format("{0:n}", gdescuentoef)
                            VentasdetalleDataGridView.Rows(e.RowIndex).Cells("subtotal").Value = monto - gdescuentoef
                            codigotextbox.SelectAll()
                            codigotextbox.Select()
                            gdescuentoef = 0
                            recuento()
                        End If

                    Case "eliminar"
                        If VentasdetalleDataGridView.CurrentRow.Cells(2).Value > 1 Then
                            VentasdetalleDataGridView.CurrentRow.Cells(2).Value = VentasdetalleDataGridView.CurrentRow.Cells(2).Value - 1
                            VentasdetalleDataGridView.Rows(e.RowIndex).Cells("descuento").Value = 0
                            VentasdetalleDataGridView.CurrentRow.Cells("subtotal").Value = VentasdetalleDataGridView.CurrentRow.Cells(2).Value * VentasdetalleDataGridView.CurrentRow.Cells(3).Value

                        Else
                            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)

                        End If
                End Select
            End If
            recuento()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub VentasdetalleDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles VentasdetalleDataGridView.UserAddedRow

    End Sub
    Private Sub recuento()

        '********** RecargoTC
        grecargoTC = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgdecimal1("RecargoTC")
        grecargoCC = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgdecimal1("RecargoCC")
        '**********

        Dim cantidad As Decimal = 0
        Dim descuentolocal As Decimal
        Dim recargolocal As Decimal
        Dim subtotallocal As Decimal

        Dim i As Integer
        total = 0

        If VentasdetalleDataGridView.RowCount > 0 Then
            'labelcantidad.Text = VentasdetalleDataGridView.RowCount.ToString
            precio = 0
            total = 0
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                descuentolocal = 0
                recargolocal = 0
                cantidad = VentasdetalleDataGridView.Rows(i).Cells("cantidad").Value
                precio = VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value
                If VentasdetalleDataGridView.Rows(i).Cells("descuento").Value > 0 Then
                    descuentolocal = VentasdetalleDataGridView.Rows(i).Cells("descuento").Value
                End If
                VentasdetalleDataGridView.Rows(i).Cells("recargo").Value = String.Format("{0:n}", 0)
                subtotallocal = (cantidad * precio) - descuentolocal
                '*****************************************************
                '*********  calcular total con recargo  ¡¡¡¡¡¡¡¡¡¡¡¡¡
                If grecargoTC > 0 Then
                    If idformapagocombo.Text = "Tarjeta de Crédito" Or idformapagocombo2.Text = "Tarjeta de Crédito" Then ' aplicar recargo en todos los items
                        VentasdetalleDataGridView.Rows(i).Cells("recargo").Value = String.Format("{0:n}", (subtotallocal * grecargoTC) / 100)
                        subtotallocal = subtotallocal + (subtotallocal * grecargoTC) / 100
                        subtotallocal = Math.Round(subtotallocal, 2)
                    End If
                End If
                If grecargoCC > 0 Then
                    If idformapagocombo.Text = "Cuenta Corriente" Or idformapagocombo2.Text = "Cuenta Corriente" Then ' aplicar recargo en todos los items
                        VentasdetalleDataGridView.Rows(i).Cells("recargo").Value = String.Format("{0:n}", (subtotallocal * grecargoCC) / 100)
                        subtotallocal = subtotallocal + (subtotallocal * grecargoCC) / 100
                        subtotallocal = Math.Round(subtotallocal, 2)
                    End If
                End If
                '*********  FIN calcular total con recargo  ¡¡¡¡¡¡¡¡¡¡¡¡¡
                '*****************************************************                
                VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value = subtotallocal
                total = total + subtotallocal
                total = Decimal.Round(total, 2)
            Next

            labeltotal.Text = total.ToString
            LabelTotalVisible.Text = "$ " + total.ToString
            '************ monto automatico DEBITO/CREDITO   *************
            Select Case idformapagocombo.Text
                Case "Débito"
                    pagotextbox.Text = total
                Case "Tarjeta de Crédito"
                    pagotextbox.Text = total
                Case "Cuenta Corriente"
                    pagotextbox.Text = total
                Case Else
                    pagotextbox.Text = total
            End Select
            Try
                If CheckBoxFP2.Checked = True Then
                    Select Case idformapagocombo2.Text
                        Case "Débito"
                            If total - pagotextbox.Text > 0 Then
                                pagotextbox2.Text = total - pagotextbox.Text
                            Else
                                pagotextbox2.Text = Nothing
                            End If

                        Case "Tarjeta de Crédito"
                            If total - pagotextbox.Text > 0 Then
                                pagotextbox2.Text = total - pagotextbox.Text
                            Else
                                pagotextbox2.Text = Nothing
                            End If
                    End Select
                End If
            Catch ex As Exception

            End Try
            '****************************************************
        Else
            total = 0
            pagotextbox.Text = total
            'labelcantidad.Text = cantidad.ToString
            labeltotal.Text = total.ToString
            LabelTotalVisible.Text = "$ " + total.ToString
        End If

        If Val(pagotextbox.Text) > 0 Then
            Dim pago As Decimal = pagotextbox.Text
            Dim vuelto As Decimal = pago - total
            vueltotextbox.Text = +vuelto.ToString
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureSeleccionarCliente.Click
        gclienteseleccionado = 0
        Dim p As SeleccionarCliente
        p = New SeleccionarCliente
        p.ShowDialog()
        IdclienteTextBox.Text = gclienteseleccionado.ToString
        If gclienteseleccionado > 0 Then
            Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
            ClientesBindingSource.Filter = "idcliente = " + IdclienteTextBox.Text
            If gclienteseleccionado > 1 Then
                calculafechavencimiento()
                ButtonDescuentoDefecto.Visible = True
            Else
                ButtonDescuentoDefecto.Visible = False
            End If
        End If
        gclienteseleccionado = Nothing
    End Sub
    Private Sub calculafechavencimiento()
        Try
            diasvencimiento = ClientesTableAdapter.clientes_consultadiasvencimiento(gclienteseleccionado)
            Dim fechavenc As Date
            fechavenc = Today.AddDays(diasvencimiento)
            FechavencimientoDateTimePicker.Value = fechavenc
        Catch ex As Exception
            MsgBox("No se pudo calcular la fecha de vencimiento: " + ex.Message)
        End Try

    End Sub

    Private Sub IdclienteTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdclienteTextBox.TextChanged
        If Val(IdclienteTextBox.Text) > 0 Then
            Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
            ClientesBindingSource.Filter = "idcliente = " + IdclienteTextBox.Text
        Else
            ClientesBindingSource.Filter = "idcliente = 0"
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelcliente.Click

    End Sub

    Private Sub pagotextbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pagotextbox.KeyDown
        ' Initialize the flag to false.
        'nonNumberEntered = False
        'If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
        '    ' Determine whether the keystroke is a number from the keypad.
        '    If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
        '        ' Determine whether the keystroke is a backspace.
        '        If e.KeyCode <> Keys.Back Then
        '            ' A non-numerical keystroke was pressed. 
        '            ' Set the flag to true and evaluate in KeyPress event.
        '            If e.KeyValue = "," Then
        '                nonNumberEntered = True
        '            End If
        '        End If
        '    End If
        'End If
        If e.KeyCode = Keys.Enter Then
            BtnConfirmar.PerformClick()
        End If
    End Sub

    Private Sub pagotextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pagotextbox.KeyPress
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

    Private Sub pagotextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pagotextbox.TextChanged

        If Val(pagotextbox.Text) > 0 Then
            Dim pago As Decimal = Convert.ToDecimal(pagotextbox.Text)
            Dim vuelto As Decimal = pago - total
            vueltotextbox.Text = "$ " + vuelto.ToString
            recalcularFP2()
        End If

    End Sub

    Private Sub vueltotextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vueltotextbox.TextChanged
        If Len(Trim(vueltotextbox.Text)) = 0 Then
            Return
        End If
        '''''''''''''''''''''''''''' permiso GenVale
        If permisoGenVale = 0 Then
            CheckBoxVale.Enabled = False
        Else


            If Val(vueltotextbox.Text) > 0 Then
                Dim vuelto As Decimal = Convert.ToDecimal(vueltotextbox.Text)
                If vuelto > 0 Then
                    CheckBoxVale.Enabled = True
                Else
                    CheckBoxVale.Enabled = False
                End If
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub Idtipocomprobantecombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idtipocomprobantecombo.SelectedIndexChanged
        If Idtipocomprobantecombo.Text = "Consumidor Final" Then
            IdclienteTextBox.Text = "1"
        Else
            IdclienteTextBox.Text = ""
        End If
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If PictureBox1.BackColor = Color.Red Then
            PictureBox1.BackColor = Color.Transparent
        Else
            PictureBox1.BackColor = Color.Red
            buscaproductomanual()
            PictureBox1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub VentasdetalleDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VentasdetalleDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDescuento.Click
        'Dim p As AplicarDescuento
        'p = New AplicarDescuento
        'gdescuentopc = 0
        'p.ShowDialog()
        'If gdescuentopc > 0 Then
        '    recuento()
        '    'MsgBox(gdescuentopc.ToString, MsgBoxStyle.Information, "hola")
        '    newrow = VentasdetalleDataGridView.Rows.Add()
        '    VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = 0   'codigoproducto
        '    VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = "Descuento" 'descripcion
        '    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1   'cantidad
        '    VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = -1 * (total * gdescuentopc / 100) 'precioventa
        '    VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = -1 * (total * gdescuentopc / 100) 'subtotal
        '    codigotextbox.SelectAll()
        '    codigotextbox.Select()
        '    gdescuentopc = 0
        '    recuento()
        'End If
        'If gdescuentoef > 0 Then
        '    recuento()
        '    'MsgBox(gdescuentopc.ToString, MsgBoxStyle.Information, "hola")
        '    newrow = VentasdetalleDataGridView.Rows.Add()
        '    VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = 0   'codigoproducto
        '    VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = "Descuento" 'descripcion
        '    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1   'cantidad
        '    VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = -1 * gdescuentoef 'precioventa
        '    VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = -1 * gdescuentoef 'subtotal
        '    codigotextbox.SelectAll()
        '    codigotextbox.Select()
        '    gdescuentoef = 0
        '    recuento()
        'End If
    End Sub

    Private Sub codigotextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles codigotextbox.KeyDown
        'If e.KeyCode.ToString = "F4" Then
        '    buscaproductomanual()
        'End If
        If e.KeyCode = Keys.Space Then
            codigotextbox.Text = LimpiarCodigo(codigotextbox.Text)
            pagotextbox.Select()
        End If
        If e.KeyCode = Keys.Enter Then
            codigotextbox.Text = LimpiarCodigo(codigotextbox.Text)
            If Len(Trim(codigotextbox.Text)) = 0 Then
                Labelproducto.Text = ""
                Return
            End If

            If Len(Trim(codigotextbox.Text)) = 13 And Mid(codigotextbox.Text, 1, 1) = gbalprefix And Len(codigotextbox.Text) = 13 Then
                Labelproducto.Text = "es balanza"
                buscaproductobalanza()
                Return
            End If

            If PictureBox1.BackColor = Color.Transparent Then
                buscaproductoauto()
            End If
        End If

        'If e.KeyCode.ToString = "Escape" Then
        '    If MsgBox("Seguro desea salir de Registrar Venta?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
        '        Me.Close()
        '    End If
        'End If
    End Sub

    Private Sub RegistrarVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
        If e.KeyCode = Keys.F1 Then
            BtnNueva.PerformClick()
        End If
        If e.KeyCode = Keys.F2 Then
            BtnCancelar.PerformClick()
        End If
        If e.KeyCode = Keys.F3 Then
            BtnConfirmar.PerformClick()
        End If
        If e.KeyCode = Keys.F4 And codigotextbox.Enabled = True Then
            buscaproductomanual()
        End If

    End Sub

    Private Sub BtnNueva_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnNueva.KeyDown

    End Sub



    Private Sub IdclienteTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdclienteTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        'If e.KeyChar = "." Then
        '    e.KeyChar = ","
        '    Return
        'End If
        'If e.KeyChar = "," Then
        '    Return
        'End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If


    End Sub

    Private Sub VentasdetalleDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles VentasdetalleDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
        End If
        recuento()
    End Sub

    Private Sub VentasdetalleDataGridView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VentasdetalleDataGridView.KeyPress

    End Sub



    Private Sub CheckBoxVale_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxVale.CheckedChanged

    End Sub

    Private Sub CheckBoxVale_KeyDown(sender As Object, e As KeyEventArgs) Handles CheckBoxVale.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnConfirmar.PerformClick()
        End If
    End Sub
    Private Sub VtaCC()
        If idformapagocombo.Text = "Cuenta Corriente" Then
            If PermisoVtaCC = 0 Then
                MsgBox("No tiene permisos para utilizar esta función", MsgBoxStyle.Exclamation)
                Return
            Else
                FechavencimientoDateTimePicker.Enabled = True
                CheckBoxFP2.Checked = False
            End If
        End If
    End Sub
    Private Sub idformapagocombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idformapagocombo.SelectedIndexChanged
        recuento()
        VtaCC()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFP2.CheckedChanged
        '********************************************
        If CheckBoxFP2.Checked = True Then
            If Not idformapagocombo.Text = "Efectivo" And Not idformapagocombo.Text = "Débito" Then
                MsgBox("Primera forma de pago tiene que ser Efectivo o Débito para recibir una segunda forma de pago", MsgBoxStyle.Exclamation, "Advertencia")
                CheckBoxFP2.Checked = False
                Return
            Else
                Try
                    FormaspagoBindingSource1.Filter = "descripcion not in ('Cuenta Corriente','Efectivo','Cheque')"
                    'Me.FormaspagoTableAdapter.FillBySegundaFP(Me.ComercialDataSet.formaspago)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            End If
            idformapagocombo2.Enabled = CheckBoxFP2.Checked
            idformapagocombo.Enabled = False
            pagotextbox2.Enabled = CheckBoxFP2.Checked
            NrocomprobanteTextBox2.Enabled = CheckBoxFP2.Checked
            LabelVuelto.Visible = False
            vueltotextbox.Visible = False
            LabelMontoFP2.Enabled = True
            Try
                Dim monto1 As Decimal = pagotextbox.Text
                Dim monto2 As Decimal = labeltotal.Text
                Dim saldo As Decimal = monto2 - monto1
                If saldo > 0 Then
                    pagotextbox2.Text = saldo
                Else
                    pagotextbox2.Text = Nothing
                End If
            Catch ex As Exception

            End Try
        Else
            idformapagocombo2.Enabled = CheckBoxFP2.Checked
            idformapagocombo.Enabled = True
            pagotextbox2.Enabled = CheckBoxFP2.Checked
            NrocomprobanteTextBox2.Enabled = CheckBoxFP2.Checked
            LabelVuelto.Visible = True
            vueltotextbox.Visible = True
            idformapagocombo2.SelectedIndex = -1
            LabelMontoFP2.Enabled = False
            pagotextbox2.Text = Nothing
        End If
        '********************************************
    End Sub

    Private Sub pagotextbox2_TextChanged(sender As Object, e As EventArgs) Handles pagotextbox2.TextChanged

    End Sub

    Private Sub pagotextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pagotextbox2.KeyPress
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

    Private Sub idformapagocombo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idformapagocombo2.SelectedIndexChanged
        If idformapagocombo2.Text = "Cuenta Corriente" Or idformapagocombo2.Text = "Otros" Or idformapagocombo2.Text = "Cheque" Then
            MsgBox("Forma de pago no permitida en esta instancia", MsgBoxStyle.Exclamation, "Advertencia")
            idformapagocombo2.SelectedIndex = -1
            Return
        End If
        recuento()
        '*********  calcular total con recargo  ¡¡¡¡¡¡¡¡¡¡¡¡¡
        If grecargoTC > 0 Then
            If idformapagocombo.Text = "Tarjeta de Crédito" Or idformapagocombo2.Text = "Tarjeta de Crédito" Then ' aplicar recargo en todos los items
                total = 0
                For i = 0 To VentasdetalleDataGridView.RowCount - 1
                    precio = VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value
                    total = total + precio
                Next
                total = total + (total * grecargoTC) / 100
                total = Math.Round(total, 2)
            End If
        End If
        '*********  FIN calcular total con recargo  ¡¡¡¡¡¡¡¡¡¡¡¡¡
        '*****************************************************
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles LabelMontoFP2.Click
        recalcularFP2()
    End Sub
    Public Sub recalcularFP2()
        Try
            Dim recargolocal As Decimal
            If CheckBoxFP2.Checked = True Then
                total = labeltotal.Text
                If CheckBoxFP2.Checked = True Then
                    Select Case idformapagocombo2.Text
                        'Case "Débito"
                        '    pagotextbox2.Text = total - pagotextbox.Text
                        Case "Tarjeta de Crédito"
                            total = 0
                            If idformapagocombo.Text = "Efectivo" Or idformapagocombo.Text = "Débito" Then
                                Dim efectivo As Decimal
                                Dim descuento As Decimal
                                Dim items As Int16 = 0
                                efectivo = pagotextbox.Text
                                For i = 0 To VentasdetalleDataGridView.RowCount - 1
                                    precio = VentasdetalleDataGridView.Rows(i).Cells("cantidad").Value * VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value
                                    descuento = VentasdetalleDataGridView.Rows(i).Cells("descuento").Value
                                    precio = precio - descuento
                                    total = total + precio
                                    items = items + 1
                                Next
                                If total - efectivo < 0 Then
                                    total = total - efectivo
                                    Return
                                Else
                                    total = total - efectivo
                                End If
                                '-------------------------------------
                                recargolocal = (total * grecargoTC) / 100
                                If Not recargolocal > 0 Then Return
                                '*****************************************************
                                '*********  calcular total con recargo  ¡¡¡¡¡¡¡¡¡¡¡¡¡
                                recargolocal = recargolocal / items
                                If grecargoTC > 0 Then
                                    For i = 0 To VentasdetalleDataGridView.RowCount - 1
                                        VentasdetalleDataGridView.Rows(i).Cells("recargo").Value = String.Format("{0:n}", recargolocal)
                                        VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value = Math.Round(precio + recargolocal, 2)
                                    Next
                                End If
                                '*********  FIN calcular total con recargo  ¡¡¡¡¡¡¡¡¡¡¡¡¡
                                '***************************************************** 
                                '*********** recalcular total general****************
                                total = 0
                                For i = 0 To VentasdetalleDataGridView.RowCount - 1
                                    precio = VentasdetalleDataGridView.Rows(i).Cells("cantidad").Value * VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value
                                    descuento = VentasdetalleDataGridView.Rows(i).Cells("descuento").Value
                                    precio = precio - descuento + VentasdetalleDataGridView.Rows(i).Cells("recargo").Value
                                    total = total + precio
                                Next
                                labeltotal.Text = total
                                LabelTotalVisible.Text = "$ " + labeltotal.Text
                                '***************************************************** 
                                '***************************************************** 
                                If total - efectivo > 0 Then
                                    pagotextbox2.Text = total - efectivo
                                Else
                                    pagotextbox2.Text = Nothing
                                End If
                            Else
                                MsgBox("Forma de pago no permitida", MsgBoxStyle.Exclamation, "Advertencia")
                                idformapagocombo2.SelectedIndex = -1
                                Return
                            End If
                        Case Else
                            If total - pagotextbox.Text > 0 Then
                                pagotextbox2.Text = total - pagotextbox.Text
                            Else
                                pagotextbox2.Text = Nothing
                            End If
                    End Select
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VentasdetalleDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VentasdetalleDataGridView.CellDoubleClick

    End Sub

    Private Sub RegistrarVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub FillBySegundaFPToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FillByFormasFP2ToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub BACKGROUNDSYNCLIBROVENTASCLOWD_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundSyncLibroventasClowd.DoWork
        'Dim SynLibroVentasStatus As Boolean
        Dim coderror As Integer
        Dim msgerror As String = ""
        gMiSucursal = 1
        SynLibroVentas(coderror, msgerror)
    End Sub

    Private Sub ButtonDescuentoDefecto_Click(sender As Object, e As EventArgs) Handles ButtonDescuentoDefecto.Click
        Dim porcentaje As Decimal
        Try
            gclienteseleccionado = Val(IdclienteTextBox.Text)

            If gclienteseleccionado > 0 Then
                porcentaje = ClientesTableAdapter.clientes_consultardescuento(gclienteseleccionado)
                descuentogeneral(porcentaje)
            End If
        Catch ex As Exception
            MsgBox("Ocurrio una excepción: " + ex.Message)
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

    Private Sub BGWStockClowd_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWStockClowd.DoWork
        Dim coderror As Long
        Dim msgerror As String = Nothing
        SynStockClowd(gidventa, "V", coderror, msgerror)
    End Sub
End Class