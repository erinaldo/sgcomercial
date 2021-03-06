﻿Imports System.Text.RegularExpressions
Public Class RegistrarVentaCC
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

    Private Sub RegistrarVentaCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        IdclienteTextBox.Text = ""
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
    End Sub
    Private Sub enablefields(ByRef status As Boolean)
        'IdventaTextBox.Enabled = status

        IdclienteTextBox.Enabled = status
        FechaventaDateTimePicker.Enabled = False

        'Idtipocomprobantecombo.Enabled = status
        codigotextbox.Enabled = status
        PictureSeleccionarCliente.Enabled = status
        VentasdetalleDataGridView.Enabled = status
        pagotextbox.Enabled = status
        PictureBox1.Enabled = status
        BtnDescuento.Enabled = status
        VencimientoDateTimePicker.Enabled = status
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
        labeltotal.Text = ""


        CheckBoxVale.Checked = False
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

    End Sub
    Private Sub BtnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmar.Click
        Dim valida As Boolean
        Dim idproducto As Long

        '******************
        validardatos(valida)
        If valida = False Then Return
        '*******************
        Dim tot As Decimal = labeltotal.Text
        If tot = 0 Then
            MsgBox("Debe ingresar al menos un (1) producto!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''' DATOS CARGADOS CORRECTAMENTE! GUARDAMOS LA VENTA  '''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If MsgBox("Seguro desea guardar la venta?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Dim idvale As Integer = Nothing
            '====================================================
            '********* insertar VENTAS cabecera
            '====================================================
            idventas = VentasTableAdapter.ventas_insertarventa(Val(IdclienteTextBox.Text), FechaventaDateTimePicker.Value, Nothing, 1, gusername, Nothing, VencimientoDateTimePicker.Value, 1)
            'MsgBox(idventas.ToString)
            '====================================================
            '********* insertar ventas detalle
            '====================================================
            Dim i As Integer = 0
            '******** fin recargo
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                If ProductosTableAdapter.productos_existeproducto(VentasdetalleDataGridView.Rows(i).Cells(0).Value) > 0 Then
                    idproducto = ProductosTableAdapter.productos_existeproducto(VentasdetalleDataGridView.Rows(i).Cells(0).Value)
                Else
                    idproducto = 0
                End If
                'insertar ventas detalle
                Try
                    Dim recargolocal As Decimal
                    recargolocal = (VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value * grecargoCC) / 100
                    idventasdetalle = VentasdetalleTableAdapter.ventasdetalle_insertardetalle(idventas, idproducto, Convert.ToDecimal(VentasdetalleDataGridView.Rows(i).Cells(2).Value), Convert.ToDecimal(VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value), VentasdetalleDataGridView.Rows(i).Cells(6).Value, recargolocal, Nothing) 'descuento
                Catch ex As Exception
                    MsgBox("error al grabar el detalle: " + ex.Message)
                End Try

                If idventasdetalle > 0 Then
                Else
                    MsgBox("Ocurrio un error al intentar insetar detalle de la venta", MsgBoxStyle.Exclamation, "Advertencia")
                    Return
                End If
            Next
            '====================================================
            '**************************************************************
            'MsgBox("Venta registrada exitosamente", MsgBoxStyle.Information, "Infomración")
            '********************************************************************************************
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

            VentasdetalleDataGridView.Rows.Clear()
            recuento()
            enablefields(False)
            '******************* 
            '****** impresion ticket
            '******************* 
            gidventa = idventas
            Dim impresion As String
            impresion = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ImpresionTicket")
            Select Case impresion
                Case "Nunca"
                    'Radionunca.Checked = True
                Case "Siempre"
                    Dim p As ViewerFactura
                    p = New ViewerFactura
                    p.ShowDialog()
                Case "Preguntar"
                    If MsgBox("Desea Imprimir el comprobante?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                        Dim p As ViewerFactura
                        p = New ViewerFactura
                        p.ShowDialog()
                    End If
            End Select
            gidventa = Nothing
            If Not FormPrincipal.BGWAlertas.IsBusy Then
                FormPrincipal.BGWAlertas.RunWorkerAsync()
            End If
            labeltotal.Text = ""
            LabelTotalVisible.Text = "$"
            '**********
        Else
            Return
        End If
    End Sub
    Private Sub validardatos(ByRef valida As Boolean)
        '******************* valida cargade datos   *********************
        If VentasdetalleDataGridView.RowCount = 0 Then
            MsgBox("Debe ingresar al menos un (1) producto!", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return
        End If

        If Val(IdclienteTextBox.Text) > 1 Then
        Else
            MsgBox("Seleccione un cliente válido", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return
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
                            Return
                        End If
                    End If
                    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
                    gprecioventa = v_precioventa
                    VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = glistaprecio
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
                                    Return
                                End If
                            Case Else
                                If productodisponibleenvasado < gcantidad Then
                                    MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto envasado insuficiente")
                                    VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
                                    Return
                                End If
                        End Select
                    End If
                    '************************************************ comprobacion stock disponible
                    VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                End If
                VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = gprecioventa
                VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = gprecioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
                VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = glistaprecio
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
                                    'VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
                                    Return
                                Else
                                    VentasdetalleDataGridView.Rows(i).Cells(2).Value = VentasdetalleDataGridView.Rows(i).Cells(2).Value + 1 '*******  cantidad
                                End If
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
                                            Return
                                        End If
                                    Case Else
                                        If productodisponibleenvasado < gcantidad Then
                                            MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto envasado insuficiente")
                                            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(i))
                                            Return
                                        End If
                                End Select
                            End If
                            '************************************************ comprobacion stock disponible
                        End If
                        VentasdetalleDataGridView.Rows(i).Cells(3).Value = gprecioventa
                        VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value = gprecioventa * VentasdetalleDataGridView.Rows(i).Cells(2).Value 'subtotal
                        VentasdetalleDataGridView.Rows(i).Cells(6).Value = glistaprecio
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
                    VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = glistaprecio
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
            VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = v_precioventa * VentasdetalleDataGridView.Rows(newrow).Cells("cantidad").Value
            VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = glistaprecio
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
                    VentasdetalleDataGridView.Rows(i).Cells(6).Value = glistaprecio
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
                VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = glistaprecio
                codigotextbox.SelectAll()
                codigotextbox.Select()
                recuento()
                Return
            End If
        End If

        '*************************
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codigotextbox.TextChanged
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
        Dim i As Integer = 0
        If VentasdetalleDataGridView.CurrentCell.ColumnIndex >= 0 Then
            Select Case VentasdetalleDataGridView.CurrentCell.ColumnIndex
                Case 5
                    If VentasdetalleDataGridView.CurrentRow.Cells(2).Value > 1 Then
                        VentasdetalleDataGridView.CurrentRow.Cells(2).Value = VentasdetalleDataGridView.CurrentRow.Cells(2).Value - 1
                        VentasdetalleDataGridView.CurrentRow.Cells("subtotal").Value = VentasdetalleDataGridView.CurrentRow.Cells(2).Value * VentasdetalleDataGridView.CurrentRow.Cells(3).Value

                    Else
                        VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)

                    End If
            End Select
        End If
        recuento()
    End Sub


    Private Sub VentasdetalleDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles VentasdetalleDataGridView.UserAddedRow

    End Sub
    Private Sub recuento()

        '********** RecargoTC
        grecargoCC = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgdecimal1("RecargoCC")
        '**********

        Dim cantidad As Integer = 0
        Dim i As Integer
        total = 0
        Dim recargo As Decimal = 0

        If VentasdetalleDataGridView.RowCount > 0 Then
            'labelcantidad.Text = VentasdetalleDataGridView.RowCount.ToString
            precio = 0
            total = 0
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                cantidad = cantidad + VentasdetalleDataGridView.Rows(i).Cells(2).Value
                precio = VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value
                total = total + precio
            Next
            total = Decimal.Round(total, 2)
            '*********  calcular total con recargo  ¡¡¡¡¡¡¡¡¡¡¡¡¡
            If grecargoCC > 0 Then ' aplicar recargo en todos los items
                For i = 0 To VentasdetalleDataGridView.RowCount - 1
                    precio = VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value + (VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value * grecargoCC) / 100
                    VentasdetalleDataGridView.Rows(i).Cells("subtotal").Value = precio
                Next
                recargo = total + (total * grecargoCC) / 100
                recargo = Math.Round(recargo, 2)
            End If

            '*********  calcular total con recargo  ¡¡¡¡¡¡¡¡¡¡¡¡¡
            '*****************************************************
            'labelcantidad.Text = cantidad.ToString
            labeltotal.Text = total.ToString
            LabelTotalVisible.Text = "$ " + total.ToString
            TextboxRecargoCC.Text = recargo
        Else
                total = 0
            'labelcantidad.Text = cantidad.ToString
            labeltotal.Text = total.ToString
            LabelTotalVisible.Text = "$ " + total.ToString
            TextboxRecargoCC.Text = recargo
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
            gclienteseleccionado = 0
        End If
        gclienteseleccionado = 0
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

    Private Sub Idtipocomprobantecombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        Dim p As AplicarDescuento
        p = New AplicarDescuento
        gdescuentopc = 0
        p.ShowDialog()
        If gdescuentopc > 0 Then
            recuento()
            'MsgBox(gdescuentopc.ToString, MsgBoxStyle.Information, "hola")
            newrow = VentasdetalleDataGridView.Rows.Add()
            VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = 0   'codigoproducto
            VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = "Descuento" 'descripcion
            VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1   'cantidad
            VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = 0 'precioventa
            VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = -1 * (total * gdescuentopc / 100) 'subtotal
            VentasdetalleDataGridView.Rows(newrow).Cells("descuento").Value = -1 * (total * gdescuentopc / 100) 'descuento
            codigotextbox.SelectAll()
            codigotextbox.Select()
            gdescuentopc = 0
            recuento()
        End If
        If gdescuentoef > 0 Then
            recuento()
            'MsgBox(gdescuentopc.ToString, MsgBoxStyle.Information, "hola")
            newrow = VentasdetalleDataGridView.Rows.Add()
            VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = 0   'codigoproducto
            VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = "Descuento" 'descripcion
            VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1   'cantidad
            VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = 0 'precioventa
            VentasdetalleDataGridView.Rows(newrow).Cells("subtotal").Value = -1 * gdescuentoef 'subtotal
            VentasdetalleDataGridView.Rows(newrow).Cells("descuento").Value = -1 * gdescuentoef 'descuento
            codigotextbox.SelectAll()
            codigotextbox.Select()
            gdescuentoef = 0
            recuento()
        End If

    End Sub

    Private Sub codigotextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles codigotextbox.KeyDown
        If e.KeyCode.ToString = "F4" Then
            buscaproductomanual()
        End If
        If e.KeyCode = Keys.Space Then
            pagotextbox.Select()
        End If
        If e.KeyCode = Keys.Enter Then
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

        If e.KeyCode.ToString = "Escape" Then
            If MsgBox("Seguro desea salir de Registrar Venta?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub RegistrarVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub BtnNueva_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnNueva.KeyDown
        If e.KeyCode.ToString = "Escape" Then
            If MsgBox("Seguro desea salir de Registrar Venta?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
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

    Private Sub idformapagocombo_SelectedIndexChanged(sender As Object, e As EventArgs)
        recuento()
    End Sub
End Class