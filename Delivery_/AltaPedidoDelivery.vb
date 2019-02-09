﻿
Public Class AltaPedidoDelivery
    Dim productodisponible As Decimal
    Dim productodisponibleenvasado As Decimal
    Dim v_precioventa As Decimal
    Dim rtn As Boolean

    Private Sub AltaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.unidadesmedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet.unidadesmedida)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listasprecios' Puede moverla o quitarla según sea necesario.
        Me.ListaspreciosTableAdapter.Fill(Me.ComercialDataSet.listasprecios)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
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
            ClientesBindingSource.Filter = "idcliente = 0 "
            ClientesdomiciliosBindingSource.Filter = "idcliente = 0 "
        Else
            IdclienteTextBox.Text = Nothing
            PictureSeleccionarCliente.Enabled = True
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
        glistaprecio = 1
        Dim idproducto As Long
        Dim descripcion As String
        Dim newrow As Long
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        Dim medida As Decimal
        Dim p As BuscaProductoManualPedidos
        p = New BuscaProductoManualPedidos
        p.ShowDialog()
        ''***********************
        If Val(gcantidad) = 0 Then Return
        productodisponible = StockTableAdapter.stock_consultardisponible(gcodigoproducto)
        productodisponibleenvasado = StockTableAdapter.stock_consultardisponibleenvasado(gcodigoproducto)
        'Labelproducto.Text = gproductodescripcion
        v_precioventa = gprecioventa
        idproducto = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
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
        If Len(Trim(TextBoxTelefono.Text)) = 0 Then
            MsgBox("Cargar Teléfono", MsgBoxStyle.Exclamation)
            TextBoxTelefono.Select()
            rtn = False
            Return
        End If
        If Len(Trim(TextBoxEmail.Text)) = 0 Then
            MsgBox("Cargar Email", MsgBoxStyle.Exclamation)
            TextBoxEmail.Select()
            rtn = False
            Return
        End If
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
        validarcargadatos(rtn)
        If rtn = False Then
            Return
        Else
            MsgBox("Datos Correctos")
        End If
        If Not MsgBox("Seguro desea guardar el pedido?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            Return
        End If
        If CheckBoxNuevoCliente.Checked Then
            Dim nvocliente
            Try
                'nvocliente = ClientesTableAdapter.clientes_insertar(TextBoxNombreCliente.Text, TextBoxTelefono.Text, TextBoxEmail.Text, TextBoxDireccion.Text, TextBoxCuit.Text)
                'ClientesdomiciliosTableAdapter.clientesdomicilios_insertar(nvocliente, TextBoxDireccion.Text, TextBoxReferencias.Text, ComboBoxTransporte.SelectedValue, ComboBoxProvincia.SelectedValue, ComboBoxLocalidad.SelectedValue, TextBoxCP.Text)

            Catch ex As Exception
                MsgBox("Ocurrio un error al tratar de guardar el pedido")
            End Try


        End If

    End Sub
End Class