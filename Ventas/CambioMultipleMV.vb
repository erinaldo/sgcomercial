Public Class CambioMultipleMV
    Dim existeproducto As Integer
    Dim unidadmedida As Integer
    Dim montoentrante As Decimal
    Dim montosaliente As Decimal
    Dim newrow As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        buscaproductomanualentrada()
        Dim status As Boolean
        recalcularentrada(status)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        buscaproductomanualsalida()
        Dim status As Boolean
        recalcularsalida(status)
    End Sub
    Public Sub buscaproductomanualentrada()
        btnConfirmar.Enabled = False
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        Dim p As BuscaProductoManualPedidos
        p = New BuscaProductoManualPedidos
        p.ShowDialog()
        '***********************
        If Val(gcantidad) = 0 Then Return
        '*******************    informacion de producto ******************
        'Labelproducto.Text = gproductodescripcion

        existeproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
        'codigotextbox.Text = gcodigoproducto
        '*******************    informacion de producto ******************
        If DataGridView1.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
            newrow = DataGridView1.Rows.Add()
            DataGridView1.Rows(newrow).Cells("codigoproducto").Value = gcodigoproducto
            DataGridView1.Rows(newrow).Cells("descripcion").Value = gproductodescripcion
            If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                DataGridView1.Rows(newrow).Cells("cantidad").Value = 1 '*******  cantidad
            Else
                DataGridView1.Rows(newrow).Cells("cantidad").Value = gcantidad '*******  cantidad
            End If
            DataGridView1.Rows(newrow).Cells("monto").Value = gprecioventa
            DataGridView1.Rows(newrow).Cells("subtotal").Value = gprecioventa * DataGridView1.Rows(newrow).Cells("cantidad").Value
            'codigotextbox.SelectAll()
            'codigotextbox.Select()
            'montopedido()
            Return
        Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
            Dim i As Integer
            For i = 0 To DataGridView1.RowCount - 1
                If gcodigoproducto = DataGridView1.Rows(i).Cells(0).Value Then '** ARTICULO ENCONTRADO
                    If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                        DataGridView1.Rows(i).Cells("cantidad").Value = DataGridView1.Rows(i).Cells("cantidad").Value + 1 '*******  cantidad
                    Else
                        DataGridView1.Rows(i).Cells("cantidad").Value = gcantidad '*******  cantidad
                    End If
                    DataGridView1.Rows(i).Cells("subtotal").Value = gprecioventa * DataGridView1.Rows(i).Cells("cantidad").Value '****** SUB-TOTAL
                    'codigotextbox.SelectAll()
                    'codigotextbox.Select()
                    'montopedido()
                    Return
                Else
                    addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                End If
            Next
            If addnewrow = True Then
                newrow = DataGridView1.Rows.Add()
                DataGridView1.Rows(newrow).Cells("codigoproducto").Value = gcodigoproducto
                DataGridView1.Rows(newrow).Cells("descripcion").Value = gproductodescripcion
                If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                    DataGridView1.Rows(newrow).Cells("cantidad").Value = 1 '*******  cantidad
                Else
                    DataGridView1.Rows(newrow).Cells("cantidad").Value = gcantidad '*******  cantidad
                End If
                DataGridView1.Rows(newrow).Cells("monto").Value = gprecioventa
                DataGridView1.Rows(newrow).Cells("subtotal").Value = gprecioventa * DataGridView1.Rows(newrow).Cells("cantidad").Value
                'codigotextbox.SelectAll()
                'codigotextbox.Select()
                'montopedido()
                Return
            End If
        End If
        'montopedido()
        '*************************
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub CambioMultipleMV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)

    End Sub
    Public Sub buscaproductomanualsalida()
        btnConfirmar.Enabled = False
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        Dim p As BuscaProductoManualPedidos
        p = New BuscaProductoManualPedidos
        p.ShowDialog()
        '***********************
        If Val(gcantidad) = 0 Then Return
        '*******************    informacion de producto ******************
        'Labelproducto.Text = gproductodescripcion

        existeproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
        'codigotextbox.Text = gcodigoproducto
        '*******************    informacion de producto ******************
        If DataGridView2.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
            newrow = DataGridView2.Rows.Add()
            DataGridView2.Rows(newrow).Cells("codigoproducto2").Value = gcodigoproducto
            DataGridView2.Rows(newrow).Cells("descripcion2").Value = gproductodescripcion
            If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                DataGridView2.Rows(newrow).Cells("cantidad2").Value = 1 '*******  cantidad
            Else
                DataGridView2.Rows(newrow).Cells("cantidad2").Value = gcantidad '*******  cantidad
            End If
            DataGridView2.Rows(newrow).Cells("monto2").Value = gprecioventa
            DataGridView2.Rows(newrow).Cells("subtotal2").Value = gprecioventa * DataGridView2.Rows(newrow).Cells("cantidad2").Value
            'codigotextbox.SelectAll()
            'codigotextbox.Select()
            'montopedido()
            Return
        Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
            Dim i As Integer
            For i = 0 To DataGridView2.RowCount - 1
                If gcodigoproducto = DataGridView2.Rows(i).Cells(0).Value Then '** ARTICULO ENCONTRADO
                    If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                        DataGridView2.Rows(i).Cells("cantidad2").Value = DataGridView2.Rows(i).Cells("cantidad2").Value + 1 '*******  cantidad
                    Else
                        DataGridView2.Rows(i).Cells("cantidad2").Value = gcantidad '*******  cantidad
                    End If
                    DataGridView2.Rows(i).Cells("subtotal2").Value = gprecioventa * DataGridView2.Rows(i).Cells("cantidad2").Value '****** SUB-TOTAL
                    'codigotextbox.SelectAll()
                    'codigotextbox.Select()
                    'montopedido()
                    Return
                Else
                    addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                End If
            Next
            If addnewrow = True Then
                newrow = DataGridView2.Rows.Add()
                DataGridView2.Rows(newrow).Cells("codigoproducto2").Value = gcodigoproducto
                DataGridView2.Rows(newrow).Cells("descripcion2").Value = gproductodescripcion
                If unidadmedida = 6 Then '** LA UNIDAD DE MEDIDA ES ENTERA
                    DataGridView2.Rows(newrow).Cells("cantidad2").Value = 1 '*******  cantidad
                Else
                    DataGridView2.Rows(newrow).Cells("cantidad2").Value = gcantidad '*******  cantidad
                End If
                DataGridView2.Rows(newrow).Cells("monto2").Value = gprecioventa
                DataGridView2.Rows(newrow).Cells("subtotal2").Value = gprecioventa * DataGridView2.Rows(newrow).Cells("cantidad2").Value
                'codigotextbox.SelectAll()
                'codigotextbox.Select()
                'montopedido()
                Return
            End If
        End If
        'montopedido()
        '*************************
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Subtract Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            'recuento()
        End If
        If e.KeyCode = Keys.Delete Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            'recuento()
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView2.KeyDown
        If e.KeyCode = Keys.Subtract Then
            DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
            'recuento()
        End If
        If e.KeyCode = Keys.Delete Then
            DataGridView2.Rows.Remove(DataGridView2.CurrentRow)
            'recuento()
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim status As Boolean
        recalcularentrada(status)
    End Sub
    Sub recalcularentrada(ByRef status As Boolean)
        status = False
        btnConfirmar.Enabled = False
        montoentrante = 0
        MontoDiferencia.Text = "$ -------"
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            Try
                If DataGridView1.Rows(i).Cells("cantidad").Value = 0 Or DataGridView1.Rows(i).Cells("monto").Value = 0 Then
                    Throw New Exception("No se permiten cantidades o montos nulos!")
                End If
                DataGridView1.Rows(i).Cells("subtotal").Value = DataGridView1.Rows(i).Cells("cantidad").Value * DataGridView1.Rows(i).Cells("monto").Value
                montoentrante = montoentrante + DataGridView1.Rows(i).Cells("subtotal").Value
                status = True
            Catch ex As Exception
                MsgBox("No se permiten cantidades o montos nulos!", MsgBoxStyle.Exclamation, "Advertencia")
                status = False
                montoentrante = 0
                Return
            End Try
        Next
    End Sub
    Sub recalcularsalida(ByRef status As Boolean)
        Dim i As Integer
        MontoDiferencia.Text = "$ -------"
        btnConfirmar.Enabled = False
        montosaliente = 0
        status = False
        For i = 0 To DataGridView2.RowCount - 1
            Try
                If DataGridView2.Rows(i).Cells("cantidad2").Value = 0 Or DataGridView2.Rows(i).Cells("monto2").Value = 0 Then
                    Throw New Exception("No se permiten cantidades o montos nulos!")
                End If
                DataGridView2.Rows(i).Cells("subtotal2").Value = DataGridView2.Rows(i).Cells("cantidad2").Value * DataGridView2.Rows(i).Cells("monto2").Value
                montosaliente = montosaliente + DataGridView2.Rows(i).Cells("subtotal2").Value
                status = True
            Catch ex As Exception
                MsgBox("No se permiten cantidades o montos nulos!", MsgBoxStyle.Exclamation, "Advertencia")
                status = False
                montosaliente = 0
                Return
            End Try

        Next
    End Sub

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        Dim status As Boolean
        recalcularsalida(status)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim status As Boolean
        Dim status1 As Boolean
        recalcularentrada(status)
        recalcularsalida(status1)
        If status = False Or status1 = False Then
            Return
        End If
        '        if MsgBox("Seguro de")
        Dim diferencia As Decimal = 0
        Try
            diferencia = montosaliente - montoentrante
            MontoDiferencia.Text = diferencia
            btnConfirmar.Enabled = True
        Catch ex As Exception
            MsgBox("Ocurrio un problema en el cálculo de la diferencia", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End Try
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        '/////////////////
        'Calcular.PerformClick()
        '/////////////////
        '    Dim cantidadentrante As Decimal
        '    Dim cantidadsaliente As Decimal
        '    Dim idproductodevuelto As Long
        '    Dim idproductonuevo As Long
        '    '****************   validar datos cargados
        '    '************************** producto entrante **************************
        '    idproductodevuelto = ProductosTableAdapter.productos_existeproducto(codigotextbox.Text)
        '    'MsgBox(existeproducto.ToString)
        '    If Not idproductodevuelto > 0 Then
        '        MsgBox("Producto devuelto incorrecto!")
        '        codigotextbox.SelectAll()
        '        Return
        '    End If
        '    '************************** producto saliente **************************
        '    idproductonuevo = ProductosTableAdapter.productos_existeproducto(TextBoxCodigoSaliente.Text)
        '    If Not idproductonuevo > 0 Then
        '        MsgBox("Producto nuevo incorrecto!")
        '        codigotextbox.SelectAll()
        '        Return
        '    End If
        '    '************************** CANTIDAD producto Entrante **************************
        '    Try
        '        cantidadentrante = TextBoxCantidadEntrante.Text
        '        If Not cantidadentrante > 0 Then
        '            MsgBox("Cantidad devuelto incorrecta")
        '            Return
        '        End If
        '    Catch ex As Exception
        '        MsgBox("Cantidad devuelto incorrecta")
        '        Return
        '    End Try
        '    '************************** MONTO producto Entrante **************************
        '    Try
        '        montoentrante = TextBoxMontoEntrante.Text
        '        If Not montoentrante > 0 Then
        '            MsgBox("Monto de producto devuelto incorrecto!")
        '            Return
        '        End If
        '    Catch ex As Exception
        '        MsgBox("Monto de producto devuelto incorrecto!")
        '        Return
        '    End Try
        '    '************************** CANTIDAD producto saliente **************************
        '    Try
        '        cantidadsaliente = TextBoxCantidadSaliente.Text
        '        If Not cantidadsaliente > 0 Then
        '            MsgBox("Cantidad producto nuevo incorrecta")
        '            Return
        '        End If
        '    Catch ex As Exception
        '        MsgBox("Cantidad producto nuevo incorrecta")
        '        Return
        '    End Try
        '    '************************** MONTO producto nuevo saliente **************************
        '    Try
        '        montosaliente = TextBoxMontoSaliente.Text
        '        If Not montosaliente > 0 Then
        '            MsgBox("Monto de producto nuevo incorrecto!")
        '            Return
        '        End If
        '    Catch ex As Exception
        '        MsgBox("Monto de producto nuevo incorrecto!")
        '        Return
        '    End Try
        '    '*******************************
        '    If Not ComboBox1.SelectedIndex >= 0 Then
        '        MsgBox("Seleccione la medida del producto devuelto")
        '        Return
        '    End If
        '    If Not ComboBox2.SelectedIndex >= 0 Then
        '        MsgBox("Seleccione la medida del producto nuevo")
        '        Return
        '    End If
        '    '*************************************************FIN VALIDACIONES************************************************
        '    If MsgBox("Seguro desea realizar el cambio?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        '        '1_'************ ingresar producto a stock   *******************************
        '        medida = ProductosTableAdapter.productos_consultarmedida(codigotextbox.Text)
        '        Dim medidaentrante As Decimal = medida
        '        If ComboBox1.SelectedIndex() = 1 Then
        '            cantidadentrante = cantidadentrante * medida
        '        End If
        '        Try
        '            If StockTableAdapter.stock_insertarmovimiento(ProductosTableAdapter.productos_existeproducto(codigotextbox.Text), cantidadentrante, Today, guserid, "E", "Cambio Mercadería") >= 0 Then
        '                'MsgBox("Movimiento cargado exitosamente!", MsgBoxStyle.Information, "Información")
        '                FormPrincipal.reloadstock()
        '                'ParentForm.reloadstock()
        '            Else
        '                MsgBox("No se pudo insertar el movimiento de entrada", MsgBoxStyle.Information, "Advertencia")
        '            End If
        '            FormPrincipal.reloadstock()
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try
        '        '2_'************ QUITAR PRODUCTO NUEVO DEL stock   *******************************
        '        medida = ProductosTableAdapter.productos_consultarmedida(TextBoxCodigoSaliente.Text)
        '        Dim medidasaliente As Decimal = medida
        '        If ComboBox2.SelectedIndex() = 1 Then
        '            cantidadsaliente = cantidadsaliente * medida
        '        End If
        '        Try
        '            If StockTableAdapter.stock_insertarmovimiento(ProductosTableAdapter.productos_existeproducto(TextBoxCodigoSaliente.Text), cantidadsaliente, Today, guserid, "S", "Cambio Mercadería") >= 0 Then
        '                'MsgBox("Movimiento cargado exitosamente!", MsgBoxStyle.Information, "Información")
        '                FormPrincipal.reloadstock()
        '                'ParentForm.reloadstock()
        '            Else
        '                MsgBox("No se pudo insertar el movimiento de salida", MsgBoxStyle.Information, "Advertencia")
        '            End If
        '            FormPrincipal.reloadstock()
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try
        '        '*************  REGISTRAR CAMBIO DEVOLUCION ************************************
        '        Dim IDCAMBIODEVOLUCION As Long
        '        IDCAMBIODEVOLUCION = CambiodevolucionTableAdapter.cambiodevolucion_insertar(idproductodevuelto, cantidadentrante, montoentrante, medidaentrante, idproductonuevo, cantidadsaliente, montosaliente, medidasaliente, Today, gusername)
        '        If Not IDCAMBIODEVOLUCION > 0 Then
        '            MsgBox("Ocurrio un error al intentar escribir en cambiodevolución")
        '            Return
        '        End If
        '        '*********************  ingreso o egreso de dinero segun corresponda **************************
        '        Dim MONTO As Decimal = MontoDiferencia.Text
        '        CajasoperacionesTableAdapter.cajasoperaciones_insertarcambiodevolucion(gidevento, IDCAMBIODEVOLUCION, MONTO, gusername)
        '        '********************** todo OK cierro la pantalla! **************************************
        '        Me.Close()
        '    Else
        '        MsgBox("Operacion cancelada")
        '    End If
    End Sub
End Class