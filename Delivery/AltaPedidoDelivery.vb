Imports System.Text.RegularExpressions
Public Class AltaPedidoDelivery
    Dim productodisponible As Decimal
    Dim productodisponibleenvasado As Decimal
    Dim v_precioventa As Decimal
    Dim rtn As Boolean

    Private Sub AltaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.unidadesmedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet.unidadesmedida)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listasprecios' Puede moverla o quitarla según sea necesario.
        'Me.ListaspreciosTableAdapter.Fill(Me.ComercialDataSet.listasprecios)
        Me.ListaspreciosTableAdapter.FillByEstado(Me.ComercialDataSet.listasprecios, 1)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.ComercialDataSet.stock)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.transportes' Puede moverla o quitarla según sea necesario.
        Me.TransportesTableAdapter.Fill(Me.ComercialDataSet.transportes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.ComercialDataSet.localidades)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientesdomicilios' Puede moverla o quitarla según sea necesario.
        Me.ClientesdomiciliosTableAdapter.Fill(Me.ComercialDataSet.clientesdomicilios)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
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
    End Sub
    Private Sub enableedit(ByVal status As String)
        TextBoxNombreCliente.Enabled = status
        TextBoxTelefono.Enabled = status
        TextBoxEmail.Enabled = status
        TextBoxCuit.Enabled = status
        TextBoxDireccion.Enabled = status
        TextBoxReferencias.Enabled = status
        TextBoxCP.Enabled = status
        'ComboBoxTransporte.Enabled = status
    End Sub

    Private Sub IdclienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdclienteTextBox.TextChanged

    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gclienteseleccionado = 0
        Dim p As SeleccionarCliente
        p = New SeleccionarCliente
        p.ShowDialog()
        IdclienteTextBox.Text = gclienteseleccionado.ToString
        If gclienteseleccionado > 0 Then
            Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
            ClientesBindingSource.Filter = "idcliente = " + IdclienteTextBox.Text
            Me.ClientesdomiciliosTableAdapter.Fill(Me.ComercialDataSet.clientesdomicilios)
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
        Else
            IdclienteTextBox.Text = Nothing
            PictureBoxEditarDomicilios.Enabled = True
            PictureSeleccionarCliente.Enabled = True
            enableedit(False)
            ComboBoxTransporte.SelectedIndex = 0
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
            VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(3).Value = gcantidad
            gprecioventa = VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(6).Value
            VentasdetalleDataGridView.Rows(VentasdetalleDataGridView.CurrentRow.Index).Cells(7).Value = Convert.ToDecimal(gcantidad * gprecioventa) '*--- subtotal
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
        v_precioventa = gprecioventa
        idproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
        '--------------------------------------------------------------------------
        productodisponible = StockTableAdapter.stock_consultardisponible(idproducto)
        productodisponibleenvasado = StockTableAdapter.stock_consultardisponibleenvasado(idproducto)
        descripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
        unidadmedida = ProductosTableAdapter.productos_consultarunidadmedida(gcodigoproducto)
        medida = ProductosTableAdapter.productos_consultarmedida(gcodigoproducto)
        ''codigotextbox.Text = gcodigoproducto
        If VentasdetalleDataGridView.RowCount = 0 Then  '** ES EL PRIMER ARTICULO DE LA LISTA
            newrow = VentasdetalleDataGridView.Rows.Add()
            VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = idproducto
            VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = gcodigoproducto
            VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = descripcion
            VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = gcantidad '*******  cantidad
            VentasdetalleDataGridView.Rows(newrow).Cells(4).Value = unidadmedida
            VentasdetalleDataGridView.Rows(newrow).Cells(5).Value = medida
            VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = gprecioventa
            VentasdetalleDataGridView.Rows(newrow).Cells(7).Value = gmontototal '*--- subtotal
            VentasdetalleDataGridView.Rows(newrow).Cells(8).Value = glistaprecio '*--- glistaprecio
            VentasdetalleDataGridView.Select()
            recuento()
            Return
        Else '**  NO ES EL PRIMER ARTICULO DE LA LISTA -- DEBO RECORRERLA PARA SABER SI YA ESTA CARGADO
            Dim i As Integer
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                If gcodigoproducto = VentasdetalleDataGridView.Rows(i).Cells(1).Value Then '** ARTICULO ENCONTRADO
                    VentasdetalleDataGridView.Rows(i).Cells(0).Value = idproducto
                    VentasdetalleDataGridView.Rows(i).Cells(1).Value = gcodigoproducto
                    VentasdetalleDataGridView.Rows(i).Cells(2).Value = descripcion
                    VentasdetalleDataGridView.Rows(i).Cells(3).Value = gcantidad '*******  cantidad
                    VentasdetalleDataGridView.Rows(i).Cells(4).Value = unidadmedida
                    VentasdetalleDataGridView.Rows(i).Cells(5).Value = medida
                    VentasdetalleDataGridView.Rows(i).Cells(6).Value = gprecioventa
                    VentasdetalleDataGridView.Rows(i).Cells(7).Value = gmontototal '*--- subtotal
                    VentasdetalleDataGridView.Rows(i).Cells(8).Value = glistaprecio '*--- glistaprecio
                    VentasdetalleDataGridView.Select()
                    recuento()
                    Return
                Else
                    addnewrow = True '** EL ARTICULO NO ESTA EN LA LISTA SE AGREGA UN NUEVO REGISTRO
                End If
            Next
            If addnewrow = True Then
                newrow = VentasdetalleDataGridView.Rows.Add()
                VentasdetalleDataGridView.Rows(newrow).Cells(0).Value = idproducto
                VentasdetalleDataGridView.Rows(newrow).Cells(1).Value = gcodigoproducto
                VentasdetalleDataGridView.Rows(newrow).Cells(2).Value = descripcion
                VentasdetalleDataGridView.Rows(newrow).Cells(3).Value = gcantidad '*******  cantidad
                VentasdetalleDataGridView.Rows(newrow).Cells(4).Value = unidadmedida
                VentasdetalleDataGridView.Rows(newrow).Cells(5).Value = medida
                VentasdetalleDataGridView.Rows(newrow).Cells(6).Value = gprecioventa
                VentasdetalleDataGridView.Rows(newrow).Cells(7).Value = gmontototal '*--- subtotal
                VentasdetalleDataGridView.Rows(newrow).Cells(8).Value = glistaprecio '*--- glistaprecio
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
            End If
        End If
        If Len(Trim(TextBoxNombreCliente.Text)) = 0 Then
            MsgBox("Cargar Nombre", MsgBoxStyle.Exclamation)
            TextBoxNombreCliente.Select()
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
        Else
            'MsgBox("Datos Correctos")
        End If
        If Not MsgBox("Seguro desea guardar el pedido?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            Return
        End If
        '*******************************************************************************************************
        Dim nvocliente As Long
        Dim nvodomicilio As Long
        Dim nvopedido As Long
        If CheckBoxNuevoCliente.Checked Then
            Try
                nvocliente = ClientesTableAdapter.clientes_insertar(Nothing, TextBoxNombreCliente.Text, TextBoxTelefono.Text, TextBoxEmail.Text, TextBoxCuit.Text)
                nvodomicilio = ClientesdomiciliosTableAdapter.clientesdomicilios_insertar(nvocliente, TextBoxDireccion.Text, TextBoxReferencias.Text, Val(ComboBoxProvincia.SelectedValue), Val(ComboBoxLocalidad.SelectedValue), TextBoxCP.Text, Nothing)
            Catch ex As Exception
                MsgBox("Ocurrio un error al tratar de guardar los datos del nuevo cliente: " + ex.Message)
                Return
            End Try
        Else
            nvocliente = Val(IdclienteTextBox.Text)
            nvodomicilio = ClientesdomiciliosDataGridView.Rows(0).Cells(0).Value
        End If
        '*****************************************  INSERTAR PEDIDODELIVERY ***************************************************************
        Try
            nvopedido = PedidosdeliveryTableAdapter.pedidosdelivery_insertar(nvocliente, Nothing, ComboBoxTransporte.SelectedValue, nvodomicilio, Convert.ToDecimal(TextBoxPagaCon.Text), Today, gusername, Nothing, Nothing)
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                Dim codigo As Long = VentasdetalleDataGridView.Rows(i).Cells(0).Value
                Dim cantidad As Decimal = VentasdetalleDataGridView.Rows(i).Cells(3).Value
                Dim precioventa As Decimal = VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value
                Dim idlistaprecio As Long = VentasdetalleDataGridView.Rows(i).Cells(8).Value
                '****** INSERTAR PEDIDODELIVERY    DETALLE **********
                PedidosdeliverydetalleTableAdapter.pedidosdeliverydetalle_insertar(nvopedido, codigo, cantidad, precioventa, Nothing, idlistaprecio)
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un problema al tratar de guardar el pedido: " + ex.Message, MsgBoxStyle.Exclamation)
            Return
        End Try
        PedidosdeliveryTableAdapter.pedidosdelivery_updateestado("RECIBIDO", nvopedido)
        '****** REGISTRAR VENTA **********
        Try
            Dim nvavta As Long
            nvavta = VentasTableAdapter.ventas_insertarventa(nvocliente, Now(), Nothing, 1, gusername, Nothing, Nothing)
            For i = 0 To VentasdetalleDataGridView.RowCount - 1
                Dim codigo As Long = VentasdetalleDataGridView.Rows(i).Cells(0).Value
                Dim cantidad As Decimal = VentasdetalleDataGridView.Rows(i).Cells(3).Value
                Dim precioventa As Decimal = VentasdetalleDataGridView.Rows(i).Cells("precioventa").Value
                Dim idlistaprecio As Long = VentasdetalleDataGridView.Rows(i).Cells(8).Value
                '****** REGISTRAR VENTA     DETALLE **********
                VentasdetalleTableAdapter.ventasdetalle_insertardetalle(nvavta, codigo, cantidad, precioventa, idlistaprecio, Nothing, Nothing) ' descuento
                PedidosdeliveryTableAdapter.pedidosdelivery_updateidventa(nvavta, nvopedido)
            Next
        Catch ex As Exception
            MsgBox("No se pudo registrar la venta: " + ex.Message)
        End Try
        '****** FIN REGISTRAR VENTA **********
        MsgBox("Pedido cargado exitosanente!", MsgBoxStyle.Information)
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
        Me.ClientesdomiciliosTableAdapter.Fill(Me.ComercialDataSet.clientesdomicilios)
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

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class