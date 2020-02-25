Imports System.Text.RegularExpressions
Public Class RecepcionSinPedido
    Dim existeproducto As Integer
    Dim unidadmedida As Integer
    Dim v_preciocosto As Decimal
    Dim newrow As Integer
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub RecepcionSinPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.ComercialDataSet.stock)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidosdetalle' Puede moverla o quitarla según sea necesario.
        Me.PedidosdetalleTableAdapter.Fill(Me.ComercialDataSet.pedidosdetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        'Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidosreporte' Puede moverla o quitarla según sea necesario.
        Me.ListapedidosreporteTableAdapter.Fill(Me.ComercialDataSet.listapedidosreporte)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.ComercialDataSet.pedidos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidosreporte' Puede moverla o quitarla según sea necesario.
        Me.ListapedidosreporteTableAdapter.Fill(Me.ComercialDataSet.listapedidosreporte)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapedidos' Puede moverla o quitarla según sea necesario.
        'Me.listapedidosTableAdapter.Fill(Me.ComercialDataSet.listapedidos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidosdetalle' Puede moverla o quitarla según sea necesario.
        Me.PedidosdetalleTableAdapter.Fill(Me.ComercialDataSet.pedidosdetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.ComercialDataSet.pedidos)

        PedidosBindingSource.Filter = "idpedido = 0"

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub codigotextbox_TextChanged(sender As Object, e As EventArgs) Handles codigotextbox.TextChanged

    End Sub
    Private Sub buscaproductoauto()
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer

        existeproducto = ProductosTableAdapter.productos_existeproducto(codigotextbox.Text)
        'productodisponible = StockTableAdapter.stock_consultardisponible(existeproducto)
        unidadmedida = ProductosTableAdapter.productos_consultarunidadmedida(codigotextbox.Text)
        If existeproducto > 0 Then ' existeproducto es el codigo de producto
            '    stockdisp.Text = "Stock: " + productodisponible.ToString
            Labelproducto.Text = ProductosTableAdapter.productos_consultardescripcion(codigotextbox.Text)
            v_preciocosto = ProductosTableAdapter.productos_consultarpreciocosto(codigotextbox.Text)
            gcodigoproducto = codigotextbox.Text
            If PedidoDetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
                newrow = PedidoDetalleDataGridView.Rows.Add()
                PedidoDetalleDataGridView.Rows(newrow).Cells(0).Value = existeproducto
                PedidoDetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
                If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                    PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
                Else
                    Dim p As IngresaCantidad
                    p = New IngresaCantidad
                    gcantidad = 0
                    gmontototal = 0
                    p.codigoproducto = codigotextbox.Text
                    p.unidadmedida = unidadmedida
                    p.precioventa = v_preciocosto
                    p.ComboBoxListaPrecios.Enabled = False '*** deshabilitar lista de precios
                    p.ShowDialog()
                    If gcantidad = 0 Or gmontototal = 0 Then
                        PedidoDetalleDataGridView.Rows.Remove(PedidoDetalleDataGridView.CurrentRow)
                        Return
                    End If
                    PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                End If
                PedidoDetalleDataGridView.Rows(newrow).Cells(3).Value = v_preciocosto
                PedidoDetalleDataGridView.Rows(newrow).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value
                PedidoDetalleDataGridView.Rows(newrow).Cells(5).Value = unidadmedida
                PedidoDetalleDataGridView.Rows(newrow).Cells(6).Value = gcodigoproducto
                codigotextbox.SelectAll()
                codigotextbox.Select()
                montopedido()
                Return
            Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
                Dim i As Integer
                For i = 0 To PedidoDetalleDataGridView.RowCount - 1
                    If existeproducto = PedidoDetalleDataGridView.Rows(i).Cells(0).Value Then '** ARTICULO ENCONTRADO
                        If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                            PedidoDetalleDataGridView.Rows(i).Cells(2).Value = PedidoDetalleDataGridView.Rows(i).Cells(2).Value + 1 '*******  cantidad
                        Else
                            Dim p As IngresaCantidad
                            p = New IngresaCantidad
                            gcantidad = 0
                            p.codigoproducto = codigotextbox.Text
                            p.unidadmedida = unidadmedida
                            p.precioventa = v_preciocosto
                            p.ComboBoxListaPrecios.Enabled = False '*** deshabilitar lista de precios
                            p.ShowDialog()
                            PedidoDetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                        End If
                        PedidoDetalleDataGridView.Rows(i).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(i).Cells(2).Value
                        PedidoDetalleDataGridView.Rows(i).Cells(5).Value = unidadmedida
                        codigotextbox.SelectAll()
                        codigotextbox.Select()
                        montopedido()
                        Return
                    Else
                        addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                    End If
                Next
                If addnewrow = True Then
                    newrow = PedidoDetalleDataGridView.Rows.Add()
                    PedidoDetalleDataGridView.Rows(newrow).Cells(0).Value = existeproducto
                    PedidoDetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
                    If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                        PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
                    Else
                        Dim p As IngresaCantidad
                        p = New IngresaCantidad
                        gcantidad = 0
                        p.codigoproducto = codigotextbox.Text
                        p.unidadmedida = unidadmedida
                        p.precioventa = v_preciocosto
                        p.ComboBoxListaPrecios.Enabled = False '*** deshabilitar lista de precios
                        p.ShowDialog()
                        PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                    End If
                    PedidoDetalleDataGridView.Rows(newrow).Cells(3).Value = v_preciocosto
                    PedidoDetalleDataGridView.Rows(newrow).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value
                    PedidoDetalleDataGridView.Rows(newrow).Cells(5).Value = unidadmedida
                    PedidoDetalleDataGridView.Rows(newrow).Cells(6).Value = gcodigoproducto
                    codigotextbox.SelectAll()
                    codigotextbox.Select()
                    montopedido()
                    Return
                End If
            End If
        Else
            '    Labelproducto.Text = ""
            '    'MsgBox("Producto no encontrado", MsgBoxStyle.Exclamation, "Advertencia")
            '    'TextBox1.Text = ""
            '    'TextBox1.Select()
        End If

    End Sub




    Private Sub codigotextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles codigotextbox.KeyDown
        If e.KeyCode.ToString = "F4" Then
            buscaproductomanual()
        End If
        If e.KeyCode.ToString = "Escape" Then
            If MsgBox("Seguro desea salir de Registrar Venta?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            If Len(Trim(codigotextbox.Text)) = 0 Then
                Labelproducto.Text = ""
                Return
            End If
            If PictureBox1.BackColor = Color.Transparent Then
                buscaproductoauto()
            End If
            montopedido()
        End If

    End Sub

    Public Sub buscaproductomanual()
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer = -1
        gcantidad = 0
        gcodigoproducto = Nothing
        Dim p As BuscaProductoPedidos
        p = New BuscaProductoPedidos
        p.ShowDialog()
        '***********************
        If Val(gcantidad) = 0 Then Return
        If gcodigoproducto = Nothing Then Return
        Labelproducto.Text = gproductodescripcion
        v_preciocosto = ProductosTableAdapter.productos_consultarpreciocosto(gcodigoproducto)
        existeproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
        unidadmedida = ProductosTableAdapter.productos_consultarunidadmedida(gcodigoproducto)
        'codigotextbox.Text = gcodigoproducto
        If PedidoDetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
            newrow = PedidoDetalleDataGridView.Rows.Add()
            PedidoDetalleDataGridView.Rows(newrow).Cells(0).Value = existeproducto
            PedidoDetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
            If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
            Else
                PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
            End If
            PedidoDetalleDataGridView.Rows(newrow).Cells(3).Value = v_preciocosto
            PedidoDetalleDataGridView.Rows(newrow).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value
            PedidoDetalleDataGridView.Rows(newrow).Cells(5).Value = unidadmedida
            PedidoDetalleDataGridView.Rows(newrow).Cells(6).Value = gcodigoproducto
            codigotextbox.SelectAll()
            codigotextbox.Select()
            montopedido()
            Return
        Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
            Dim i As Integer
            For i = 0 To PedidoDetalleDataGridView.RowCount - 1
                If existeproducto = PedidoDetalleDataGridView.Rows(i).Cells(0).Value Then '** ARTICULO ENCONTRADO
                    If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                        'PedidoDetalleDataGridView.Rows(i).Cells(2).Value = PedidoDetalleDataGridView.Rows(i).Cells(2).Value + 1 '*******  cantidad
                        PedidoDetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                    Else
                        PedidoDetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                    End If
                    PedidoDetalleDataGridView.Rows(i).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(i).Cells(2).Value
                    PedidoDetalleDataGridView.Rows(i).Cells(5).Value = unidadmedida
                    PedidoDetalleDataGridView.Rows(newrow).Cells(6).Value = gcodigoproducto
                    codigotextbox.SelectAll()
                    codigotextbox.Select()
                    montopedido()
                    Return
                Else
                    addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                End If
            Next
            If addnewrow = True Then
                newrow = PedidoDetalleDataGridView.Rows.Add()
                PedidoDetalleDataGridView.Rows(newrow).Cells(0).Value = existeproducto
                PedidoDetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
                If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                    PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                Else
                    PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                End If
                PedidoDetalleDataGridView.Rows(newrow).Cells(3).Value = v_preciocosto
                PedidoDetalleDataGridView.Rows(newrow).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value
                PedidoDetalleDataGridView.Rows(newrow).Cells(5).Value = unidadmedida
                PedidoDetalleDataGridView.Rows(newrow).Cells(6).Value = gcodigoproducto
                codigotextbox.SelectAll()
                codigotextbox.Select()
                montopedido()
                Return
            End If
        End If
        montopedido()
        '*************************
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PictureBox1.BackColor = Color.Red Then
            PictureBox1.BackColor = Color.Transparent
        Else
            PictureBox1.BackColor = Color.Red
            buscaproductomanual()
            PictureBox1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub IdproveedorTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdproveedorTextBox.TextChanged
        Try
            'ProveedoresBindingSource.Filter = "idproveedor = " + IdproveedorTextBox.Text
            ProveedoresTableAdapter.FillByIdproveedor(Me.ComercialDataSet.proveedores, Val(IdproveedorTextBox.Text))
        Catch ex As Exception
            Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)
            LabelProveedor.Text = Nothing
        End Try
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gidproveedor = 0
        BuscaProveedor.ShowDialog()
        If Not gidproveedor = 0 Then
            IdproveedorTextBox.Text = gidproveedor.ToString
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rtn As Integer = 0
        Dim rtn2 As Integer = 0
        Dim umedida As Integer = 0
        Dim cantidad As Decimal
        Dim medida As Decimal
        Dim precio As Decimal
        Dim codigoproducto As String
        Dim idproducto As Integer
        Dim i As Integer

        '***********    validar *********************
        If Len(Trim(IdproveedorTextBox.Text)) = 0 Or Len(Trim(LabelProveedor.Text)) = 0 Then
            MsgBox("Seleccione un proveedor válido!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        If PedidoDetalleDataGridView.RowCount = 0 Then
            MsgBox("Debe agregar productos al pedido!", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        '***********    validar *********************

        If MsgBox("Seguro desea registrar el ingreso de mercaderia?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            rtn = PedidosTableAdapter.pedidos_insertar(Val(IdproveedorTextBox.Text), Today, Nothing)
            If rtn = 0 Then
                MsgBox("Ocurrio un error al intentar grabar la cabecera del pedido", MsgBoxStyle.Exclamation, "Advertencia")
                Return
            End If

            For i = 0 To PedidoDetalleDataGridView.RowCount - 1
                cantidad = PedidoDetalleDataGridView.Rows(i).Cells(2).Value
                precio = PedidoDetalleDataGridView.Rows(i).Cells(4).Value
                idproducto = PedidoDetalleDataGridView.Rows(i).Cells(0).Value
                rtn2 = PedidosdetalleTableAdapter.pedidosdetalle_insertar(rtn, idproducto, cantidad, precio)
                If rtn2 = 0 Then
                    MsgBox("Ocurrio un error al intentar grabar detalle del pedido", MsgBoxStyle.Exclamation, "Advertencia")
                    PedidosTableAdapter.pedidos_eliminar(rtn)
                    Return
                End If
            Next

            '**********************************************
            '**************** Confirmar ingreso de mercaderías  ****************
            '**********************************************
            For i = 0 To PedidoDetalleDataGridView.RowCount - 1
                idproducto = PedidoDetalleDataGridView.Rows(i).Cells(0).Value '''''''''''''''''''''''''''''''''''''
                cantidad = PedidoDetalleDataGridView.Rows(i).Cells(2).Value '''''''''''''''''''''''''''''''''''''
                umedida = PedidoDetalleDataGridView.Rows(i).Cells(5).Value '''''''''''''''''''''''''''''''''''''
                codigoproducto = PedidoDetalleDataGridView.Rows(i).Cells(6).Value
                medida = ProductosTableAdapter.productos_consultarmedida(codigoproducto)
                'Select Case umedida
                '    Case 1  'kilos
                '        cantidad = cantidad * medida
                '    Case 2  'metros
                '        cantidad = cantidad * medida
                '    Case 3  'litros
                '        cantidad = cantidad * medida
                'End Select
                StockTableAdapter.stock_insertarmovimientorecepcion(idproducto, cantidad, Today, gusername, "E", rtn)
                PedidosdetalleTableAdapter.pedidosdetalle_confirmarecepcion(1, rtn, idproducto)
            Next
            '**************************************************************
            '*******    FINALIZAR  automaticamente!!!!!
            '*************************************************************
            PedidosTableAdapter.pedidos_finalizarpedido(Today, rtn)
            '*************** deshabilitarbotonoes¡***************
            '****************************************************************************************
            MsgBox("Operacion exitosa!", MsgBoxStyle.Information, "Información")
            PedidoDetalleDataGridView.Rows.Clear()
            IdproveedorTextBox.Text = Nothing
        End If

    End Sub

    Private Sub PedidoDetalleDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PedidoDetalleDataGridView.CellContentClick

    End Sub

    Private Sub PedidoDetalleDataGridView_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles PedidoDetalleDataGridView.RowStateChanged
        montopedido()
    End Sub
    Private Sub montopedido()
        Dim precio As Decimal
        Dim total As Decimal
        Dim cantidad As Integer = 0
        Dim i As Integer

        precio = 0
        total = 0

        For i = 0 To PedidoDetalleDataGridView.RowCount - 1
            precio = PedidoDetalleDataGridView.Rows(i).Cells(4).Value
            total += precio
        Next
        total = Decimal.Round(total, 2)

        labeltotalvisible.Text = "$ " + total.ToString

    End Sub

    Private Sub PedidoDetalleDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles PedidoDetalleDataGridView.UserDeletedRow
        montopedido()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        montopedido()
    End Sub

    Private Sub PedidoDetalleDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles PedidoDetalleDataGridView.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                PedidoDetalleDataGridView.Rows.Remove(PedidoDetalleDataGridView.CurrentRow)
            End If
            If e.KeyCode = Keys.Subtract Then
                PedidoDetalleDataGridView.Rows.Remove(PedidoDetalleDataGridView.CurrentRow)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PedidosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub RecepcionSinPedido_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Add Then
            buscaproductomanual()
            e.SuppressKeyPress = True
            codigotextbox.Text = Nothing
        End If
        If e.KeyCode = Keys.F4 Then
            buscaproductomanual()
            e.SuppressKeyPress = True
            codigotextbox.Text = Nothing
        End If
        If e.KeyCode = Keys.Delete Then
            PedidoDetalleDataGridView.Rows.Remove(PedidoDetalleDataGridView.CurrentRow)
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Subtract Then
            PedidoDetalleDataGridView.Rows.Remove(PedidoDetalleDataGridView.CurrentRow)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PedidoDetalleDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PedidoDetalleDataGridView.CellClick

    End Sub

    Private Sub IdproveedorTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IdproveedorTextBox.KeyDown
        If e.KeyCode = Keys.Add Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.F4 Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub IdproveedorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdproveedorTextBox.KeyPress
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub
End Class