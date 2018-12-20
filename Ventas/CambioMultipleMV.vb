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
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.pagos' Puede moverla o quitarla según sea necesario.
        Me.PagosTableAdapter.Fill(Me.ComercialDataSet.pagos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.formaspago' Puede moverla o quitarla según sea necesario.
        Me.FormaspagoTableAdapter.Fill(Me.ComercialDataSet.formaspago)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cambiodevolucion' Puede moverla o quitarla según sea necesario.
        Me.CambiodevolucionTableAdapter.Fill(Me.ComercialDataSet.cambiodevolucion)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cambiodevoluciondetalle' Puede moverla o quitarla según sea necesario.
        Me.CambiodevoluciondetalleTableAdapter.Fill(Me.ComercialDataSet.cambiodevoluciondetalle)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.ComercialDataSet.stock)
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
            If diferencia > 0 Then
                GroupBox5.Enabled = True
            Else
                GroupBox5.Enabled = False
            End If
            MontoDiferencia.Text = diferencia
            btnConfirmar.Enabled = True
        Catch ex As Exception
            MsgBox("Ocurrio un problema en el cálculo de la diferencia", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End Try
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        '/////////////////
        Button1.PerformClick()
        '/////////////////

        If MsgBox("Seguro desea realizar el cambio?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            '*************  REGISTRAR CAMBIO DEVOLUCION ************************************
            Dim IDCAMBIODEVOLUCION As Long
            IDCAMBIODEVOLUCION = CambiodevolucionTableAdapter.cambiodevolucion_insertar(0, 0, montoentrante, 0, 0, 0, montosaliente, 0, Today, gusername)
            If Not IDCAMBIODEVOLUCION > 0 Then
                MsgBox("Ocurrio un error al intentar escribir en cambiodevolución")
                Return
            End If
            '****************************************************************************
            '1_'************ ingresar producto a stock   *******************************
            '****************************************************************************
            Dim i As Integer
            Dim medida As Integer
            For i = 0 To DataGridView1.RowCount - 1
                medida = ProductosTableAdapter.productos_consultarmedida(DataGridView1.Rows(i).Cells("codigoproducto").Value)
                Try
                    If StockTableAdapter.stock_insertarmovimiento(ProductosTableAdapter.productos_existeproducto(DataGridView1.Rows(i).Cells("codigoproducto").Value), DataGridView1.Rows(i).Cells("cantidad").Value, Today, guserid, "E", "Cambio Mercaderías Varias") >= 0 Then
                        Dim idproducto As Long = ProductosTableAdapter.productos_existeproducto(DataGridView1.Rows(i).Cells("codigoproducto").Value)
                        Dim cant As Decimal = DataGridView1.Rows(i).Cells("cantidad").Value
                        Dim subt As Decimal = DataGridView1.Rows(i).Cells("subtotal").Value
                        CambiodevoluciondetalleTableAdapter.cambiodevoluciondetalle_insertar(IDCAMBIODEVOLUCION, idproducto, "E", cant, subt)
                        'MsgBox("Movimiento cargado exitosamente!", MsgBoxStyle.Information, "Información")
                        'FormPrincipal.reloadstock()
                        'ParentForm.reloadstock()
                    Else
                        MsgBox("No se pudo insertar el movimiento de entrada", MsgBoxStyle.Information, "Advertencia")
                        Return
                    End If
                    'FormPrincipal.reloadstock()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next

            '        Dim medidaentrante As Decimal = medida
            '        If ComboBox1.SelectedIndex() = 1 Then
            '            cantidadentrante = cantidadentrante * medida
            '        End If
            '        
            '2_'************ QUITAR PRODUCTO NUEVO DEL stock   *******************************
            For i = 0 To DataGridView2.RowCount - 1
                medida = ProductosTableAdapter.productos_consultarmedida(DataGridView2.Rows(i).Cells("codigoproducto2").Value)
                Try
                    If StockTableAdapter.stock_insertarmovimiento(ProductosTableAdapter.productos_existeproducto(DataGridView2.Rows(i).Cells("codigoproducto2").Value), DataGridView2.Rows(i).Cells("cantidad2").Value, Today, guserid, "S", "Cambio Mercaderías Varias") >= 0 Then
                        Dim idproducto As Long = ProductosTableAdapter.productos_existeproducto(DataGridView2.Rows(i).Cells("codigoproducto2").Value)
                        Dim cant As Decimal = DataGridView2.Rows(i).Cells("cantidad2").Value
                        Dim subt As Decimal = DataGridView2.Rows(i).Cells("subtotal2").Value
                        CambiodevoluciondetalleTableAdapter.cambiodevoluciondetalle_insertar(IDCAMBIODEVOLUCION, idproducto, "S", cant, subt)
                    Else
                        MsgBox("No se pudo insertar el movimiento de salida", MsgBoxStyle.Information, "Advertencia")
                        Return
                    End If
                    'FormPrincipal.reloadstock()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next

            Dim idpagos As Long
            Dim MONTO As Decimal = MontoDiferencia.Text
            If MONTO > 0 Then
                '**************************************************************
                '***** insertar EL PAGO
                '**************************************************************
                idpagos = PagosTableAdapter.pagos_insertarpagocambio(IDCAMBIODEVOLUCION, 1, MONTO, Val(idformapagocombo.SelectedValue), NrocomprobanteTextBox.text) '"NrocomprobanteTextBox"
                If idpagos > 0 Then
                Else
                    MsgBox("Ocurrio un error al registrar el pago", MsgBoxStyle.Information, "Advertencia")
                    Return
                End If
            End If
            '**************************************************************
            '***** insertar movimiento de caja
            '**************************************************************
            CajasoperacionesTableAdapter.cajasoperaciones_insertarcambiodevolucion(gidevento, IDCAMBIODEVOLUCION, idformapagocombo.SelectedValue, MONTO, gusername)
            '********************** todo OK cierro la pantalla! **************************************
            Me.Close()
        Else
            MsgBox("Operacion cancelada")
        End If
    End Sub
End Class