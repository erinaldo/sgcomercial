Public Class ABMPedidos
    Dim existeproducto As Integer
    Dim unidadmedida As Integer
    Dim v_preciocosto As Decimal
    Dim newrow As Integer
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub codigotextbox_TextChanged(sender As Object, e As EventArgs) Handles codigotextbox.TextChanged
        If Len(Trim(codigotextbox.Text)) = 0 Then
            Labelproducto.Text = ""
            Return
        End If
        If PictureBox1.BackColor = Color.Transparent Then
            buscaproductoauto()
        End If
        montopedido()
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
                    p.ShowDialog()
                    If gcantidad = 0 Or gmontototal = 0 Then
                        PedidoDetalleDataGridView.Rows.Remove(PedidoDetalleDataGridView.CurrentRow)
                        Return
                    End If
                    PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                End If
                PedidoDetalleDataGridView.Rows(newrow).Cells(3).Value = v_preciocosto
                PedidoDetalleDataGridView.Rows(newrow).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value
                codigotextbox.SelectAll()
                codigotextbox.Select()
                montopedido() '
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
                            p.ShowDialog()
                            PedidoDetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                        End If
                        PedidoDetalleDataGridView.Rows(i).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(i).Cells(2).Value
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
                        p.ShowDialog()
                        PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                    End If
                    PedidoDetalleDataGridView.Rows(newrow).Cells(3).Value = v_preciocosto
                    PedidoDetalleDataGridView.Rows(newrow).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value
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
        montopedido()
    End Sub

    Private Sub codigotextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles codigotextbox.KeyDown
        If e.KeyCode.ToString = "F4" Then
            buscaproductomanual()
        End If
        If e.KeyCode.ToString = "Escape" Then
            If MsgBox("Seguro desea salir de " + Me.Text + " ?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = e.KeyCode.Space Then
            Button1.PerformClick()
        End If
    End Sub

    Public Sub buscaproductomanual()
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        Dim p As BuscaProductoPedidos
        p = New BuscaProductoPedidos
        p.ShowDialog()
        '***********************
        If Val(gcantidad) = 0 Then Return
        Labelproducto.Text = gproductodescripcion
        v_preciocosto = ProductosTableAdapter.productos_consultarpreciocosto(gcodigoproducto)
        existeproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
        'codigotextbox.Text = gcodigoproducto
        If PedidoDetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
            newrow = PedidoDetalleDataGridView.Rows.Add()
            PedidoDetalleDataGridView.Rows(newrow).Cells(0).Value = existeproducto
            PedidoDetalleDataGridView.Rows(newrow).Cells(1).Value = Labelproducto.Text
            If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = 1 '*******  cantidad
            Else
                PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
            End If
            PedidoDetalleDataGridView.Rows(newrow).Cells(3).Value = v_preciocosto
            PedidoDetalleDataGridView.Rows(newrow).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value
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
                        PedidoDetalleDataGridView.Rows(i).Cells(2).Value = gcantidad '*******  cantidad
                    End If
                    PedidoDetalleDataGridView.Rows(i).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(i).Cells(2).Value
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
                    PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value = gcantidad '*******  cantidad
                End If
                PedidoDetalleDataGridView.Rows(newrow).Cells(3).Value = v_preciocosto
                PedidoDetalleDataGridView.Rows(newrow).Cells(4).Value = v_preciocosto * PedidoDetalleDataGridView.Rows(newrow).Cells(2).Value
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

            Me.ProveedoresTableAdapter.FillByIdproveedor(Me.ComercialDataSet.proveedores, Val(IdproveedorTextBox.Text))
        Catch ex As Exception
            Me.ProveedoresTableAdapter.FillByIdproveedor(Me.ComercialDataSet.proveedores, 0)
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

        Dim rtn As Integer = 0
        Dim rtn2 As Integer = 0
        Dim cantidad As Decimal
        Dim precio As Decimal
        Dim codigoproducto As Integer
        Dim i As Integer
        If MsgBox("Seguro desea generar el pedido?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            rtn = PedidosTableAdapter.pedidos_insertar(Val(IdproveedorTextBox.Text), Today, Nothing)
            If rtn = 0 Then
                MsgBox("Ocurrio un error al intentar grabar la cabecera del pedido", MsgBoxStyle.Exclamation, "Advertencia")
                Return
            End If

            For i = 0 To PedidoDetalleDataGridView.RowCount - 1
                cantidad = PedidoDetalleDataGridView.Rows(i).Cells(2).Value
                precio = PedidoDetalleDataGridView.Rows(i).Cells(4).Value
                codigoproducto = PedidoDetalleDataGridView.Rows(i).Cells(0).Value
                rtn2 = PedidosdetalleTableAdapter.pedidosdetalle_insertar(rtn, codigoproducto, cantidad, precio)
                If rtn2 = 0 Then
                    MsgBox("Ocurrio un error al intentar grabar detalle del pedido", MsgBoxStyle.Exclamation, "Advertencia")
                    PedidosTableAdapter.pedidos_eliminar(rtn)
                    Return
                End If
            Next
            Me.listapedidosreporteTableAdapter.FillByidpedido(Me.ComercialDataSet.listapedidosreporte, rtn)
            Me.ReportViewer1.RefreshReport()
            MsgBox("Generado exitosamente!", MsgBoxStyle.Information, "Mensaje")
            If MsgBox("Desea imprimir el pedido?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then

                ReportViewer1.PrintDialog()
            End If
            Me.Close()
        End If

    End Sub

    Private Sub PedidoDetalleDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PedidoDetalleDataGridView.CellContentClick

    End Sub

    Private Sub PedidoDetalleDataGridView_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles PedidoDetalleDataGridView.RowStateChanged
        montopedido()
    End Sub


    Private Sub PedidoDetalleDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles PedidoDetalleDataGridView.UserDeletedRow

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

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PedidoDetalleDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles PedidoDetalleDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            PedidoDetalleDataGridView.Rows.Remove(PedidoDetalleDataGridView.CurrentRow)
        End If
    End Sub




End Class

