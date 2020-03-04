Imports System.Text.RegularExpressions
Public Class CambioMercaderiaVendida
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
    Dim medida As Decimal
    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSPD.Click
        buscaproductomanual()
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub CambioMercaderiaVendida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        Me.Enabled = False
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cambiodevolucion' Puede moverla o quitarla según sea necesario.
        'Me.CambiodevolucionTableAdapter.Fill(Me.ComercialDataSet.cambiodevolucion)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        'Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.unidadesmedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet.unidadesmedida)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stock' Puede moverla o quitarla según sea necesario.
        'Me.StockTableAdapter.Fill(Me.ComercialDataSet.stock)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub TextBoxCodigoEntrante_TextChanged(sender As Object, e As EventArgs) Handles codigotextbox.TextChanged

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
            LabelProducto.Text = ProductosTableAdapter.productos_consultardescripcion(codigotextbox.Text)
            LabelProducto.Text = LabelProducto.Text.ToUpper
            v_precioventa = ProductosTableAdapter.productos_consultarprecioventa(codigotextbox.Text)
            TextBoxMontoEntrante.Text = v_precioventa
            TextBoxCantidadEntrante.Text = 1
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'If VentasdetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
            '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '    newrow = VentasdetalleDataGridView.Rows.Add()
            '    VentasdetalleDataGridView.Rows(newrow).Selected = True
            '    VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = codigotextbox.Text
            '    VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = LabelProducto.Text
            '    If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
            '        If ValidarSTK = "Enable" Then
            '            If Not productodisponible >= 1 Then ''''''' validar stock disponible
            '                MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente")
            '                VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            '                Return
            '            End If
            '        End If
            '        VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
            '        gprecioventa = v_precioventa
            '        VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = glistaprecio
            '    Else    '****************** la unidad de medida es kilo litro o metros
            '        Dim p As IngresaCantidad
            '        p = New IngresaCantidad
            '        gcantidad = 0
            '        gmontototal = 0
            '        glistaprecio = 0
            '        p.codigoproducto = codigotextbox.Text
            '        p.unidadmedida = unidadmedida
            '        p.precioventa = v_precioventa
            '        p.ShowDialog()
            '        If gcantidad = 0 Or gmontototal = 0 Then
            '            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            '            Return
            '        End If
            '        '************************************************ comprobacion stock disponible
            '        If ValidarSTK = "Enable" Then
            '            Select Case glistaprecio
            '                Case 2 'es venta a granel! POR KILO
            '                    If productodisponible < gcantidad Then
            '                        MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto suelto insuficiente")
            '                        VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            '                        Return
            '                    End If
            '                Case Else
            '                    If productodisponibleenvasado < gcantidad Then
            '                        MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto envasado insuficiente")
            '                        VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            '                        Return
            '                    End If
            '            End Select
            '        End If
            '        '************************************************ comprobacion stock disponible
            '        VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
            '    End If
            '    VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = gprecioventa
            '    VentasdetalleDataGridView.Rows(newrow).Cells(4).Value = gprecioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
            '    VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = glistaprecio
            '    codigotextbox.SelectAll()
            '    codigotextbox.Select()
            '    recuento()
            '    Return
            'Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
            '    Dim i As Integer
            '    gprecioventa = v_precioventa
            '    For i = 0 To VentasdetalleDataGridView.RowCount - 1
            '        If codigotextbox.Text = VentasdetalleDataGridView.Rows(i).Cells(0).Value Then '** ARTICULO ENCONTRADO
            '            If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
            '                gcantidad = VentasdetalleDataGridView.Rows(i).Cells(2).Value + 1   'incremento la cantidad existente en 1 para luego comparar si hay disponible
            '                gprecioventa = v_precioventa
            '                If ValidarSTK = "Enable" Then
            '                    If Not productodisponible >= gcantidad Then ''''''' validar stock disponible
            '                        MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente")
            '                        VentasdetalleDataGridView.Rows(i).Selected = True
            '                        'VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            '                        Return
            '                    Else
            '                        VentasdetalleDataGridView.Rows(i).Cells(2).Value = VentasdetalleDataGridView.Rows(i).Cells(2).Value + 1 '*******  cantidad
            '                    End If
            '                End If
            '            Else '****************** la unidad de medida es kilo litro o metros
            '                Dim p As IngresaCantidad
            '                p = New IngresaCantidad
            '                gcantidad = 0
            '                glistaprecio = 0
            '                p.codigoproducto = codigotextbox.Text
            '                p.unidadmedida = unidadmedida
            '                p.precioventa = v_precioventa
            '                p.ShowDialog()
            '                VentasdetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
            '                VentasdetalleDataGridView.Rows(i).Selected = True
            '                '************************************************ comprobacion stock disponible
            '                If ValidarSTK = "Enable" Then
            '                    Select Case glistaprecio
            '                        Case 2 'es venta a granel! POR KILO
            '                            If productodisponible < gcantidad Then
            '                                MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto suelto insuficiente")
            '                                VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(i))
            '                                Return
            '                            End If
            '                        Case Else
            '                            If productodisponibleenvasado < gcantidad Then
            '                                MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto envasado insuficiente")
            '                                VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(i))
            '                                Return
            '                            End If
            '                    End Select
            '                End If
            '                '************************************************ comprobacion stock disponible
            '            End If
            '            VentasdetalleDataGridView.Rows(i).Cells(3).Value = gprecioventa
            '            VentasdetalleDataGridView.Rows(i).Cells(4).Value = gprecioventa * VentasdetalleDataGridView.Rows(i).Cells(2).Value 'subtotal
            '            VentasdetalleDataGridView.Rows(i).Cells(6).Value = glistaprecio
            '            codigotextbox.SelectAll()
            '            codigotextbox.Select()
            '            recuento()
            '            Return
            '        Else
            '            addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
            '        End If
            '    Next
            '    If addnewrow = True Then
            '        newrow = VentasdetalleDataGridView.Rows.Add()
            '        VentasdetalleDataGridView.Rows(newrow).Selected = True
            '        VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = codigotextbox.Text
            '        VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = LabelProducto.Text
            '        If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
            '            VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
            '            If ValidarSTK = "Enable" Then
            '                If Not productodisponible >= gcantidad Then ''''''' validar stock disponible
            '                    MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente")
            '                    VentasdetalleDataGridView.Rows(i).Selected = True
            '                    VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.CurrentRow)
            '                    Return
            '                End If
            '            End If
            '        Else '************ la unidad de medida es kilo litro o metro
            '            Dim p As IngresaCantidad
            '            p = New IngresaCantidad
            '            gcantidad = 0
            '            glistaprecio = 0
            '            p.codigoproducto = codigotextbox.Text
            '            p.unidadmedida = unidadmedida
            '            p.precioventa = v_precioventa
            '            p.ShowDialog()
            '            VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
            '            '************************************************ comprobacion stock disponible
            '            If ValidarSTK = "Enable" Then
            '                Select Case glistaprecio
            '                    Case 2 'es venta a granel! POR KILO
            '                        If productodisponible < gcantidad Then
            '                            MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto suelto insuficiente")
            '                            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(newrow))
            '                            Return
            '                        End If
            '                    Case Else
            '                        If productodisponibleenvasado < gcantidad Then
            '                            MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto envasado insuficiente")
            '                            VentasdetalleDataGridView.Rows.Remove(VentasdetalleDataGridView.Rows(newrow))
            '                            Return
            '                        End If
            '                End Select
            '            End If
            '            '************************************************ comprobacion stock disponible
            '        End If
            '        VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = gprecioventa
            '        VentasdetalleDataGridView.Rows(newrow).Cells(4).Value = gprecioventa * VentasdetalleDataGridView.Rows(newrow).Cells(2).Value
            '        VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = glistaprecio
            '        codigotextbox.SelectAll()
            '        codigotextbox.Select()
            '        recuento()
            '        Return
            '    End If
            'End If
        Else
            'LabelProducto.Text = ""
            MsgBox("Producto no encontrado", MsgBoxStyle.Exclamation, "Advertencia")
            codigotextbox.Text = ""
            LabelProducto.Text = Nothing
            TextBoxMontoEntrante.Text = Nothing
            TextBoxCantidadEntrante.Text = Nothing
            codigotextbox.SelectAll()
        End If
    End Sub
    Private Sub buscaproductoauto2()
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        glistaprecio = 1
        existeproducto = ProductosTableAdapter.productos_existeproducto(TextBoxCodigoSaliente.Text)
        productodisponible = StockTableAdapter.stock_consultardisponible(existeproducto)
        productodisponibleenvasado = StockTableAdapter.stock_consultardisponibleenvasado(existeproducto)
        unidadmedida = ProductosTableAdapter.productos_consultarunidadmedida(TextBoxCodigoSaliente.Text)
        If existeproducto > 0 Then ' existeproducto ------------- es el codigo de producto
            Label2.Text = ProductosTableAdapter.productos_consultardescripcion(TextBoxCodigoSaliente.Text)
            Label2.Text = Label2.Text.ToUpper
            v_precioventa = ProductosTableAdapter.productos_consultarprecioventa(TextBoxCodigoSaliente.Text)

            TextBoxMontoSaliente.Text = v_precioventa

            TextBoxCantidadSaliente.Text = "1"
        Else
            'LabelProducto.Text = ""
            MsgBox("Producto no encontrado", MsgBoxStyle.Exclamation, "Advertencia")
            TextBoxCodigoSaliente.Text = ""
            Label2.Text = Nothing
            TextBoxMontoSaliente.Text = Nothing
            TextBoxCantidadSaliente.Text = Nothing
            TextBoxMontoEntrante.SelectAll()
        End If
    End Sub

    Private Sub TextBoxCodigoEntrante_KeyDown(sender As Object, e As KeyEventArgs) Handles codigotextbox.KeyDown
        If e.KeyCode.ToString = "F4" Then
            buscaproductomanual()
        End If

        If e.KeyCode = Keys.Enter Then
            If Len(Trim(codigotextbox.Text)) = 0 Then
                LabelProducto.Text = ""
                TextBoxCantidadEntrante.Text = Nothing
                TextBoxMontoEntrante.Text = Nothing
                Return
            End If
            buscaproductoauto()
        End If

        If e.KeyCode.ToString = "Escape" Then
            If MsgBox("Seguro desea salir de Registrar Venta?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TextBoxCantidadEntrante_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantidadEntrante.TextChanged

    End Sub

    Private Sub TextBoxCantidadEntrante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCantidadEntrante.KeyPress
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

    Private Sub TextBoxMontoEntrante_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMontoEntrante.TextChanged

    End Sub

    Private Sub TextBoxMontoEntrante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMontoEntrante.KeyPress
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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantidadSaliente.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCantidadSaliente.KeyPress
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMontoSaliente.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMontoSaliente.KeyPress
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
    Public Sub buscaproductomanual()
        gcantidad = 0
        glistaprecio = 1
        productodisponible = StockTableAdapter.stock_consultardisponible(existeproducto)
        productodisponibleenvasado = StockTableAdapter.stock_consultardisponibleenvasado(existeproducto)
        Dim addnewrow As Boolean = False
        'Dim unidadmedida As Integer
        Dim p As BuscaProductoManualPedidos
        p = New BuscaProductoManualPedidos
        gValidarSTK = "Disable"
        p.ShowDialog()
        '***********************
        If Val(gcantidad) = 0 Then Return
        LabelProducto.Text = gproductodescripcion
        LabelProducto.Text = LabelProducto.Text.ToUpper
        'v_precioventa = gprecioventa
        codigotextbox.Text = gcodigoproducto
        TextBoxMontoEntrante.Text = gmontototal
        TextBoxCantidadEntrante.Text = gcantidad
        '*************************
    End Sub
    Public Sub buscaproductomanual2()
        gcantidad = 0
        glistaprecio = 1
        productodisponible = StockTableAdapter.stock_consultardisponible(existeproducto)
        productodisponibleenvasado = StockTableAdapter.stock_consultardisponibleenvasado(existeproducto)
        Dim addnewrow As Boolean = False
        'Dim unidadmedida As Integer
        Dim p As BuscaProductoManualPedidos
        p = New BuscaProductoManualPedidos
        'gValidarSTK = "Disable"
        p.ShowDialog()
        '***********************
        If Val(gcantidad) = 0 Then Return
        Label2.Text = gproductodescripcion
        Label2.Text = Label2.Text.ToUpper
        'v_precioventa = gprecioventa
        TextBoxCodigoSaliente.Text = gcodigoproducto
        TextBoxMontoSaliente.Text = gmontototal

        TextBoxCantidadSaliente.Text = gcantidad

    End Sub


    Private Sub TextBoxCodigoSaliente_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCodigoSaliente.TextChanged

    End Sub

    Private Sub TextBoxCodigoSaliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCodigoSaliente.KeyDown
        If e.KeyCode.ToString = "F4" Then
            buscaproductomanual2()
        End If

        If e.KeyCode = Keys.Enter Then
            If Len(Trim(TextBoxCodigoSaliente.Text)) = 0 Then
                Label2.Text = ""
                TextBoxCantidadSaliente.Text = Nothing
                TextBoxMontoSaliente.Text = Nothing
                Return
            End If
            buscaproductoauto2()
        End If

        If e.KeyCode.ToString = "Escape" Then
            If MsgBox("Seguro desea salir de Registrar Venta?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub PictureSPN_Click(sender As Object, e As EventArgs) Handles PictureSPN.Click
        buscaproductomanual2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '/////////////////
        Calcular.PerformClick()
        '/////////////////
        Dim cantidadentrante As Decimal
        Dim cantidadsaliente As Decimal
        Dim montosaliente As Decimal
        Dim montoentrante As Decimal
        Dim idproductodevuelto As Long
        Dim idproductonuevo As Long
        '****************   validar datos cargados
        '************************** producto entrante **************************
        idproductodevuelto = ProductosTableAdapter.productos_existeproducto(codigotextbox.Text)
        'MsgBox(existeproducto.ToString)
        If Not idproductodevuelto > 0 Then
            MsgBox("Producto devuelto incorrecto!")
            codigotextbox.SelectAll()
            Return
        End If
        '************************** producto saliente **************************
        idproductonuevo = ProductosTableAdapter.productos_existeproducto(TextBoxCodigoSaliente.Text)
        If Not idproductonuevo > 0 Then
            MsgBox("Producto nuevo incorrecto!")
            codigotextbox.SelectAll()
            Return
        End If
        '************************** CANTIDAD producto Entrante **************************
        Try
            cantidadentrante = TextBoxCantidadEntrante.Text
            If Not cantidadentrante > 0 Then
                MsgBox("Cantidad devuelto incorrecta")
                Return
            End If
        Catch ex As Exception
            MsgBox("Cantidad devuelto incorrecta")
            Return
        End Try
        '************************** MONTO producto Entrante **************************
        Try
            montoentrante = TextBoxMontoEntrante.Text
            If Not montoentrante > 0 Then
                MsgBox("Monto de producto devuelto incorrecto!")
                Return
            End If
        Catch ex As Exception
            MsgBox("Monto de producto devuelto incorrecto!")
            Return
        End Try
        '************************** CANTIDAD producto saliente **************************
        Try
            cantidadsaliente = TextBoxCantidadSaliente.Text
            If Not cantidadsaliente > 0 Then
                MsgBox("Cantidad producto nuevo incorrecta")
                Return
            End If
        Catch ex As Exception
            MsgBox("Cantidad producto nuevo incorrecta")
            Return
        End Try
        '************************** MONTO producto nuevo saliente **************************
        Try
            montosaliente = TextBoxMontoSaliente.Text
            If Not montosaliente > 0 Then
                MsgBox("Monto de producto nuevo incorrecto!")
                Return
            End If
        Catch ex As Exception
            MsgBox("Monto de producto nuevo incorrecto!")
            Return
        End Try
        '*******************************
        If Not ComboBox1.SelectedIndex >= 0 Then
            MsgBox("Seleccione la medida del producto devuelto")
            Return
        End If
        If Not ComboBox2.SelectedIndex >= 0 Then
            MsgBox("Seleccione la medida del producto nuevo")
            Return
        End If
        '*************************************************FIN VALIDACIONES************************************************
        If MsgBox("Seguro desea realizar el cambio?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            '1_'************ ingresar producto a stock   *******************************
            medida = ProductosTableAdapter.productos_consultarmedida(codigotextbox.Text)
            Dim medidaentrante As Decimal = medida
            If ComboBox1.SelectedIndex() = 1 Then
                cantidadentrante = cantidadentrante * medida
            End If
            Try
                If StockTableAdapter.stock_insertarmovimiento(ProductosTableAdapter.productos_existeproducto(codigotextbox.Text), cantidadentrante, Today, guserid, "E", "Cambio Mercadería", 1) >= 0 Then
                    'MsgBox("Movimiento cargado exitosamente!", MsgBoxStyle.Information, "Información")
                    '=======================================================
                    If Not FormPrincipal.BGWAlertas.IsBusy Then
                        FormPrincipal.BGWAlertas.RunWorkerAsync()
                    End If
                    '=======================================================
                Else
                    MsgBox("No se pudo insertar el movimiento de entrada", MsgBoxStyle.Information, "Advertencia")
                    End If
                '=======================================================
                If Not FormPrincipal.BGWAlertas.IsBusy Then
                    FormPrincipal.BGWAlertas.RunWorkerAsync()
                End If
                '=======================================================
            Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            '2_'************ QUITAR PRODUCTO NUEVO DEL stock   *******************************
            medida = ProductosTableAdapter.productos_consultarmedida(TextBoxCodigoSaliente.Text)
            Dim medidasaliente As Decimal = medida
            If ComboBox2.SelectedIndex() = 1 Then
                cantidadsaliente = cantidadsaliente * medida
            End If
            Try
                If StockTableAdapter.stock_insertarmovimiento(ProductosTableAdapter.productos_existeproducto(TextBoxCodigoSaliente.Text), cantidadsaliente, Today, guserid, "S", "Cambio Mercadería", 1) >= 0 Then
                    'MsgBox("Movimiento cargado exitosamente!", MsgBoxStyle.Information, "Información")
                    '=======================================================
                    If Not FormPrincipal.BGWAlertas.IsBusy Then
                        FormPrincipal.BGWAlertas.RunWorkerAsync()
                    End If
                    '=======================================================
                Else
                    MsgBox("No se pudo insertar el movimiento de salida", MsgBoxStyle.Information, "Advertencia")
                End If
                '=======================================================
                If Not FormPrincipal.BGWAlertas.IsBusy Then
                    FormPrincipal.BGWAlertas.RunWorkerAsync()
                End If
                '=======================================================
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '*************  REGISTRAR CAMBIO DEVOLUCION ************************************
            Dim IDCAMBIODEVOLUCION As Long
            IDCAMBIODEVOLUCION = CambiodevolucionTableAdapter.cambiodevolucion_insertar(idproductodevuelto, cantidadentrante, montoentrante, medidaentrante, idproductonuevo, cantidadsaliente, montosaliente, medidasaliente, Today, gusername)
            If Not IDCAMBIODEVOLUCION > 0 Then
                MsgBox("Ocurrio un error al intentar escribir en cambiodevolución")
                Return
            End If
            '*********************  ingreso o egreso de dinero segun corresponda **************************
            Dim MONTO As Decimal = MontoDiferencia.Text
            CajasoperacionesTableAdapter.cajasoperaciones_insertarcambiodevolucion(gidevento, IDCAMBIODEVOLUCION, 1, MONTO, gusername)
            '********************** todo OK cierro la pantalla! **************************************
            MsgSuccessPopUp("Cambio registrado!")
            Me.Close()
        Else
            MsgBox("Operacion cancelada")
        End If
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim cantidadentrante As Decimal
        Dim cantidadsaliente As Decimal
        Dim montosaliente As Decimal
        Dim montoentrante As Decimal
        '****************   validar datos cargados
        '************************** producto entrante **************************
        existeproducto = ProductosTableAdapter.productos_existeproducto(codigotextbox.Text)
        'MsgBox(existeproducto.ToString)
        If Not existeproducto > 0 Then
            MsgBox("Producto devuelto incorrecto!")
            codigotextbox.SelectAll()
            Return
        End If
        '************************** producto saliente **************************
        existeproducto = ProductosTableAdapter.productos_existeproducto(TextBoxCodigoSaliente.Text)
        If Not existeproducto > 0 Then
            MsgBox("Producto nuevo incorrecto!")
            codigotextbox.SelectAll()
            Return
        End If
        '************************** CANTIDAD producto Entrante **************************
        Try
            cantidadentrante = TextBoxCantidadEntrante.Text
            If Not cantidadentrante > 0 Then
                MsgBox("Cantidad devuelto incorrecta")
                Return
            End If
        Catch ex As Exception
            MsgBox("Cantidad devuelto incorrecta: " + ex.Message)
            Return
        End Try
        '************************** MONTO producto Entrante **************************
        Try
            montoentrante = TextBoxMontoEntrante.Text
            If Not montoentrante > 0 Then
                MsgBox("Monto de producto devuelto incorrecto!")
                Return
            End If
        Catch ex As Exception
            MsgBox("Monto de producto devuelto incorrecto: " + ex.Message)
            Return
        End Try
        '************************** CANTIDAD producto saliente **************************
        Try
            cantidadsaliente = TextBoxCantidadSaliente.Text
            If Not cantidadsaliente > 0 Then
                MsgBox("Cantidad producto nuevo incorrecta")
                Return
            End If
        Catch ex As Exception
            MsgBox("Cantidad producto nuevo incorrecta")
            Return
        End Try
        '************************** MONTO producto nuevo saliente **************************
        Try
            montosaliente = TextBoxMontoSaliente.Text
            If Not montosaliente > 0 Then
                MsgBox("Monto de producto nuevo incorrecto!")
                Return
            End If
        Catch ex As Exception
            MsgBox("Monto de producto nuevo incorrecto!")
            Return
        End Try
        '*******************************
        If Not ComboBox1.SelectedIndex >= 0 Then
            MsgBox("Seleccione la medida del producto devuelto")
            Return
        End If
        If Not ComboBox2.SelectedIndex >= 0 Then
            MsgBox("Seleccione la medida del producto nuevo")
            Return
        End If
        '*************************************************FIN VALIDACIONES************************************************
        '********************************************************************************************
        Dim calculo As Decimal
        calculo = montosaliente - montoentrante
        MontoDiferencia.Text = calculo
    End Sub

    Private Sub CambioMercaderiaVendida_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class