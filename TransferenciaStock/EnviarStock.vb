Public Class EnviarStock
    Private Sub EnviarStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.remitosdetalle' Puede moverla o quitarla según sea necesario.
        Me.RemitosdetalleTableAdapter.Fill(Me.ComercialDataSet.remitosdetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.remitos' Puede moverla o quitarla según sea necesario.
        Me.RemitosTableAdapter.Fill(Me.ComercialDataSet.remitos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.unidadesmedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet.unidadesmedida)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.ComercialDataSet.sucursales)
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As SeleccionarProductoEnvio
        p = New SeleccionarProductoEnvio
        gcodigoproducto = 0
        p.ShowDialog()

        Try
            If gcantidad = 0 Or Len(gcodigoproducto) = 0 Or gcodigoproducto = "0" Then Return
            Dim addedrow As Long = DataGridViewProductos.Rows.Add()
            Dim umedida As Integer = ProductosTableAdapter.productos_consultarunidadmedida(gcodigoproducto)
            Dim medida As Decimal = ProductosTableAdapter.productos_consultarmedida(gcodigoproducto)
            Dim descripcion As String = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
            Dim preciocosto As Decimal = ProductosTableAdapter.productos_consultarpreciocosto(gcodigoproducto)
            Dim precioventa As Decimal = ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
            Dim precioventamayorista As Decimal = ProductosTableAdapter.productos_consultarpreciomayorista(gcodigoproducto)
            Dim precioventagranel As Decimal = ProductosTableAdapter.productos_consultarpreciogranel(gcodigoproducto)
            ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
            DataGridViewProductos.Rows(addedrow).Cells(0).Value = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
            DataGridViewProductos.Rows(addedrow).Cells(1).Value = gcodigoproducto
            DataGridViewProductos.Rows(addedrow).Cells(2).Value = descripcion
            DataGridViewProductos.Rows(addedrow).Cells(3).Value = gcantidad
            DataGridViewProductos.Rows(addedrow).Cells(4).Value = umedida
            DataGridViewProductos.Rows(addedrow).Cells(5).Value = medida
            DataGridViewProductos.Rows(addedrow).Cells(6).Value = preciocosto
            DataGridViewProductos.Rows(addedrow).Cells(7).Value = precioventa
            DataGridViewProductos.Rows(addedrow).Cells(8).Value = precioventamayorista
            DataGridViewProductos.Rows(addedrow).Cells(9).Value = precioventagranel
        Catch ex As Exception
            MsgBox("Ocurrio un error al tratar de insertar un producto en la lista: " + ex.Message)
        End Try

    End Sub

    Private Sub DataGridViewProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductos.CellContentClick

    End Sub

    Private Sub DataGridViewProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductos.CellDoubleClick
        Dim p As SeleccionarCantidad
        p = New SeleccionarCantidad
        gcodigoproducto = 0
        p.ShowDialog()
        p.TextBox1.Text = DataGridViewProductos.Rows(e.RowIndex).Cells(3).Value
        DataGridViewProductos.Rows(e.RowIndex).Cells(3).Value = gcantidad

    End Sub

    Private Sub DataGridViewProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewProductos.KeyDown
        If e.KeyCode = Keys.Delete Then
            DataGridViewProductos.Rows.Remove(DataGridViewProductos.CurrentRow)
        End If
        If e.KeyCode = Keys.Subtract Then
            DataGridViewProductos.Rows.Remove(DataGridViewProductos.CurrentRow)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '**************** validar carga de datos ************************
        If ComboBox1.SelectedIndex < 0 Then
            MsgBox("Seleccione una sucursal válida!", MsgBoxStyle.Exclamation)
            Return
        End If
        If DataGridViewProductos.RowCount = 0 Then
            MsgBox("Cargue al menos un producto para enviar!", MsgBoxStyle.Exclamation)
            Return
        End If
        '*******************************************************************
        '************** validar existencia en stock **********************
        '*******************************************************************
        For i = 0 To DataGridViewProductos.RowCount - 1
            Dim cantidad As Decimal = DataGridViewProductos.Rows(i).Cells(3).Value
            Dim medida As Decimal = DataGridViewProductos.Rows(i).Cells(5).Value
            Dim productodisponible As Decimal = StockTableAdapter.stock_consultardisponible(DataGridViewProductos.Rows(i).Cells(0).Value)
            cantidad = cantidad * medida
            If productodisponible < cantidad Then
                MsgBox("Producto insuficiente!", MsgBoxStyle.Exclamation, DataGridViewProductos.Rows(i).Cells(2).Value.toupper)
                Return
            End If
        Next
        '******************************         FIN VALIDACIONES        *************************************
        '*******************************************************************

        '************   confirmar acción    ***************
        If Not MsgBox("Seguro desea confirmar el envío?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Operación cancelada!")
            Return
        Else

            '*********  descontar mercaderia    *********************
            Try
                '************   generar remito de salida de mercaderia ****************
                Dim idremito As Long = RemitosTableAdapter.remitos_insertar("S", ComboBox1.SelectedValue, gusername)
                '   RECORRO LA LISTA DE PRODUCTOS A TRANSFERIR
                For i = 0 To DataGridViewProductos.RowCount - 1
                    Dim cantidad As Decimal = DataGridViewProductos.Rows(i).Cells(3).Value
                    Dim medida As Decimal = DataGridViewProductos.Rows(i).Cells(5).Value
                    Dim unidadmedida As Integer = DataGridViewProductos.Rows(i).Cells(4).Value
                    cantidad = cantidad * medida
                    Dim preciocosto As Decimal = ProductosTableAdapter.productos_consultarpreciocosto(DataGridViewProductos.Rows(i).Cells(1).Value)
                    Dim precioventa As Decimal = ProductosTableAdapter.productos_consultarprecioventa(DataGridViewProductos.Rows(i).Cells(1).Value)
                    Dim precioventamayorista As Decimal = ProductosTableAdapter.productos_consultarpreciomayorista(DataGridViewProductos.Rows(i).Cells(1).Value)
                    Dim precioventagranel As Decimal = ProductosTableAdapter.productos_consultarpreciogranel(DataGridViewProductos.Rows(i).Cells(1).Value)
                    If StockTableAdapter.stock_insertarmovimientoremito(DataGridViewProductos.Rows(i).Cells(0).Value, cantidad, Today, gusername, "S", idremito) > 0 Then
                        'MsgBox("Movimiento cargado exitosamente!", MsgBoxStyle.Information, "Información")
                        FormPrincipal.reloadstock()
                    Else
                        MsgBox("No se pudo insertar el movimiento", MsgBoxStyle.Information, "Advertencia")
                    End If
                    If Not RemitosdetalleTableAdapter.remitosdetalle_insertar(idremito, DataGridViewProductos.Rows(i).Cells(0).Value, DataGridViewProductos.Rows(i).Cells(1).Value, DataGridViewProductos.Rows(i).Cells(2).Value, cantidad, unidadmedida, medida, preciocosto, precioventa, precioventagranel, precioventamayorista) > 0 Then
                        MsgBox("Hubo un problema al cargar un item al detalle del remito")
                    End If
                Next 'FINALIZA EL RECORRIDO POR LA LISTA DE PRODUCTOS
                If MsgBox("Desea imprimir el reporte?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                    'imprimir--------------------
                    Dim p As ViewerRemito
                    p = New ViewerRemito
                    gidremito = idremito
                    p.ShowDialog()
                End If
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try

        End If
        '*******************************************************

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If gMiSucursal = ComboBox1.SelectedValue Then
            MsgBox("No puede seleccionar sucursal de destino igual a la de origen!", MsgBoxStyle.Exclamation, "Advertencia")
            ComboBox1.SelectedIndex = -1
            Return
        End If
    End Sub

    Private Sub EnviarStock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Add Then
            Button1.PerformClick()
        End If
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class