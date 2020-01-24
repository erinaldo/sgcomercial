
Public Class AdmOrdenes
    Dim idventas As Long
    Dim idventasdetalle As Long
    Dim idpagos As Long
    Dim idoperacioncaja As Long

    Private Sub AdmOrdenes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        If e.KeyCode = Keys.Add Then
            NuevaÓrdenToolStripMenuItem.PerformClick()
        End If
        If e.KeyCode = Keys.Subtract Then
            AnularOrdenToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub AdmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listamesasestados' Puede moverla o quitarla según sea necesario.
        'Me.ListamesasestadosTableAdapter.Fill(Me.ComercialDataSet.listamesasestados)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.parametrosgenerales' Puede moverla o quitarla según sea necesario.
        Me.ParametrosgeneralesTableAdapter.Fill(Me.ComercialDataSet.parametrosgenerales)
        gidevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        'Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        'Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        'Me.PagosTableAdapter.Fill(Me.ComercialDataSet.pagos)
        'Me.VentasdetalleTableAdapter.Fill(Me.ComercialDataSet.ventasdetalle)
        'Me.VentasTableAdapter.Fill(Me.ComercialDataSet.ventas)
        '**********************************************************************
        Try
            Me.MozosTableAdapter.Fill(Me.ComercialDataSet.mozos)
            Me.SalonesTableAdapter.FillByActivos(Me.ComercialDataSet.salones)
            Me.MesasTableAdapter.FillBySalon(Me.ComercialDataSet.mesas, ComboBoxSalon.SelectedValue)
            ComboBoxSalon.SelectedIndex = 0
            ComboBoxMesa.SelectedIndex = -1
            '**********************************************************************
            Me.FormaspagoTableAdapter.Fill(Me.ComercialDataSet.formaspago)
            Me.TipocomprobantesTableAdapter.FillByEstado(Me.ComercialDataSet.tipocomprobantes, "A")
            Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
            '**********************************************************************
            NuevaÓrdenToolStripMenuItem.Enabled = False
            AnularOrdenToolStripMenuItem.Enabled = False
            Try
                Idtipocomprobantecombo.SelectedValue = 1
                idformapagocombo.SelectedValue = 1
                ColorearGridMesas()
            Catch ex As Exception
                'MessageBox.Show("Aviso!", "Seleccione primero un salón", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Catch ex As Exception
            MessageBox.Show("Primero debe cargar la configuración de mesas y mozos", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.Close()
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            NuevaÓrdenToolStripMenuItem.Enabled = False
            AnularOrdenToolStripMenuItem.Enabled = False
            Return
        End Try

    End Sub

    Private Sub ComboBoxSalon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSalon.SelectedIndexChanged
        Try
            Me.MesasTableAdapter.FillBySalon(Me.ComercialDataSet.mesas, ComboBoxSalon.SelectedValue)
            ComboBoxMesa.SelectedIndex = -1
            ColorearGridMesas()
        Catch ex As Exception
            MessageBox.Show("Aviso!", "Seleccione primero un salón", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub ColorearGridMesas()
        Try
            ConsultaEstadosMesas()
            For Each row In ListamesasestadosDataGridView.Rows
                If ListamesasestadosDataGridView.Rows(row.index).Cells("pendientes").Value > 0 Then
                    ListamesasestadosDataGridView.Rows(row.index).DefaultCellStyle.BackColor = Color.Red
                Else
                    ListamesasestadosDataGridView.Rows(row.index).DefaultCellStyle.BackColor = Color.LimeGreen
                End If
            Next
            'ListamesasestadosDataGridView.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Dim valida As Boolean
        Try
            validardatos(valida)
            If Not valida = True Then Return
            If MessageBox.Show("Seguro desea FINALIZAR la mesa?", "MESA: " + ComboBoxMesa.SelectedValue.ToString, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                FinalizarMesa(ComboBoxMesa.SelectedValue.ToString)
                LoadOrdenes()
                ColorearGridMesas()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AnularMesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularMesaToolStripMenuItem.Click
        If ListaordenesmesaDataGridView.Rows.Count = 0 Then Return
        Try
            Dim _idOrdenmesa As Long
            If MessageBox.Show("Seguro desea anular la mesa completamente?", "MESA: " + ComboBoxMesa.SelectedValue.ToString, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For Each row In ListaordenesmesaDataGridView.Rows
                    _idOrdenmesa = ListaordenesmesaDataGridView.Rows(row.index).Cells("idordenmesa").Value
                    OrdenesmesasTableAdapter.ordenesmesas_baja(_idOrdenmesa)
                Next
                LoadOrdenes()
                ColorearGridMesas()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NuevaÓrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaÓrdenToolStripMenuItem.Click
        Try
            gidproducto = Nothing
            glistaprecio = Nothing
            glistapreferida = Nothing
            gprecioventa = Nothing
            gcantidad = Nothing
            gcodigoproducto = Nothing
            buscaproductomanual()
            LoadOrdenes()
            ColorearGridMesas()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ConsultaEstadosMesas()
        Dim currentselrow As Integer
        Try
            currentselrow = ListamesasestadosDataGridView.CurrentRow.Index
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Try
            ListamesasestadosTableAdapter.FillBySalon(Me.ComercialDataSet.listamesasestados, ComboBoxSalon.SelectedValue)
            If currentselrow > 0 Then
                ListamesasestadosDataGridView.Rows(currentselrow).Selected = True
                If ListamesasestadosDataGridView.Rows.Count > 0 Then
                    ListamesasestadosDataGridView.Rows(0).Selected = False
                End If
            Else
                If ListamesasestadosDataGridView.Rows.Count > 0 Then
                    ListamesasestadosDataGridView.Rows(0).Selected = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Sub buscaproductomanual()
        gcantidad = 0
        Dim idmesa As Integer = ComboBoxMesa.SelectedValue
        Dim idproducto As Long
        Dim descripcion As String
        'Dim newrow As Long
        Dim addnewrow As Boolean = False
        Dim unidadmedida As Integer
        Dim medida As Decimal
        Dim v_precioventa As Decimal
        Dim productodisponible As Decimal
        Dim productodisponibleenvasado As Decimal
        glistaprecio = 0
        'glistapreferida = ComboBox1.SelectedValue
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
        Try
            insertarordenmesa(Nothing, idmesa, idproducto, gcantidad, "P", Now(), Nothing, 0, glistaprecio, Nothing, gprecioventa, 0)
            ListaordenesmesaTableAdapter.FillByEstadoMesa(Me.ComercialDataSet.listaordenesmesa, "P", ComboBoxMesa.SelectedValue)
            ColorearGridMesas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '*************************
    End Sub

    Private Sub ComboBoxMesa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMesa.SelectedIndexChanged
        ResetearOpciones()
        LoadOrdenes()
    End Sub
    Private Sub ResetearOpciones()
        Try
            IdclienteTextBox.Text = Nothing
            Idtipocomprobantecombo.SelectedValue = 1
            idformapagocombo.SelectedValue = 1
            TextBoxImporteTotal.Text = Nothing
        Catch ex As Exception

        End Try

    End Sub
    Public Sub insertarordenmesa(ByRef idventa As Long, ByRef idmesa As Long, ByRef idproducto As Long, ByRef cantidad As Decimal, ByRef estado As String, ByRef fechaalta As DateTime, ByRef observaciones As String, ByRef descuento As Decimal, ByRef idlistaprecio As Long, ByRef ivaventasdetalle As Long, ByRef precioventa As Decimal, ByRef recargo As Decimal)
        Try
            OrdenesmesasTableAdapter.ordenesmesas_insertar(idventa, idmesa, idproducto, cantidad, estado, fechaalta, observaciones, descuento, idlistaprecio, precioventa, recargo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ListaordenesmesaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaordenesmesaDataGridView.CellContentClick
    End Sub

    Private Sub ListaordenesmesaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaordenesmesaDataGridView.CellClick

    End Sub
    Public Sub LoadOrdenes()
        If ComboBoxMesa.SelectedValue > 0 Then
            NuevaÓrdenToolStripMenuItem.Enabled = True
            AnularOrdenToolStripMenuItem.Enabled = True
            ListaordenesmesaTableAdapter.FillByEstadoMesa(Me.ComercialDataSet.listaordenesmesa, "P", ComboBoxMesa.SelectedValue)
            LabelMESA.Text = ComboBoxMesa.SelectedValue.ToString
            recuento()
        Else
            NuevaÓrdenToolStripMenuItem.Enabled = False
            AnularOrdenToolStripMenuItem.Enabled = False
        End If
    End Sub
    Sub recuento()
        Try
            Dim importetotal As Decimal = 0
            Dim importe As Decimal = 0

            For Each row In ListaordenesmesaDataGridView.Rows
                importe = ListaordenesmesaDataGridView.Rows(row.index).Cells("subtotal").Value
                importetotal = importetotal + importe
            Next
            TextBoxImporteTotal.Text = importetotal.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AnularOrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularOrdenToolStripMenuItem.Click
        If Not ListaordenesmesaDataGridView.Rows.Count > 0 Then
            MessageBox.Show("Primero seleccione una orden", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return
        End If
        Try
            Dim _idOrdenmesa As Long = 0
            Dim producto As String = ListaordenesmesaDataGridView.Rows(ListaordenesmesaDataGridView.CurrentRow.Index).Cells("producto").Value
            _idOrdenmesa = ListaordenesmesaDataGridView.Rows(ListaordenesmesaDataGridView.CurrentRow.Index).Cells("idordenmesa").Value
            If MessageBox.Show("Seguro desea anular la orden: " & vbCr & producto, "MESA: " + ComboBoxMesa.SelectedValue.ToString, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                OrdenesmesasTableAdapter.ordenesmesas_baja(_idOrdenmesa)
                LoadOrdenes()
                ColorearGridMesas()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FinalizarMesa(ByVal idmesa As Long)
        Dim idproducto As Long
        Dim monto1 As Decimal
        Try
            monto1 = TextBoxImporteTotal.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        '********* insertar VENTA cabecera
        idventas = VentasTableAdapter.ventas_insertarventa(Val(IdclienteTextBox.Text), Now(), idformapagocombo.SelectedValue, Idtipocomprobantecombo.SelectedValue, gusername, NrocomprobanteTextBox.Text, Now(), 1)
        '********* insertar VENTA detalle
        Dim i As Integer = 0
        'Dim recalocal As Decimal
        ''********************   obtiene recargo si corresponde ******************
        'If idformapagocombo.Text = "Tarjeta de Crédito" And grecargoTC > 0 Then
        '    recalocal = grecargoTC
        'Else
        '    recalocal = 0
        'End If
        '******** fin recargo
        For i = 0 To ListaordenesmesaDataGridView.RowCount - 1
            If ProductosTableAdapter.productos_existeproducto(ListaordenesmesaDataGridView.Rows(i).Cells("codigoproducto").Value) > 0 Then
                idproducto = ListaordenesmesaDataGridView.Rows(i).Cells("idproducto").Value
            Else
                idproducto = 0
            End If
            '***************************************************
            'INSERTAR EN VENTASDETALLE
            '***************************************************
            Try
                Dim recargo As Decimal = 0
                If IsDBNull(ListaordenesmesaDataGridView.Rows(i).Cells("recargo").Value) = False Then
                    recargo = ListaordenesmesaDataGridView.Rows(i).Cells("recargo").Value
                End If

                idventasdetalle = VentasdetalleTableAdapter.ventasdetalle_insertardetalle(idventas, idproducto, Convert.ToDecimal(ListaordenesmesaDataGridView.Rows(i).Cells("cantidad").Value), Convert.ToDecimal(ListaordenesmesaDataGridView.Rows(i).Cells("precioventa").Value), ListaordenesmesaDataGridView.Rows(i).Cells("idlistaprecio").Value, recargo, Convert.ToDecimal(ListaordenesmesaDataGridView.Rows(i).Cells("descuento").Value)) '// descuento
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
                idpagos = PagosTableAdapter.pagos_insertarpago(idventas, Val(IdclienteTextBox.Text), monto1, Now(), idformapagocombo.SelectedValue, NrocomprobanteTextBox.Text)
                If idpagos > 0 Then
                    '**************************************************************
                    '***** insertar movimiento de caja PAGO 1
                    '**************************************************************
                    idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(gidevento, idpagos, idformapagocombo.SelectedValue, monto1, gusername, Nothing)
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
                'idpagos = PagosTableAdapter.pagos_insertarpago(idventas, Val(IdclienteTextBox.Text), monto2, Today(), idformapagocombo2.SelectedValue, NrocomprobanteTextBox2.Text)
                'If idpagos > 0 Then
                '    '**************************************************************
                '    '***** insertar movimiento de caja PAGO 2
                '    '**************************************************************
                '    idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(idevento, idpagos, idformapagocombo2.SelectedValue, monto2, gusername, idvale)
                '    If idoperacioncaja > 0 Then
                '    Else
                '        MsgBox("Ocurrio un error al registrar el movimiento de caja", MsgBoxStyle.Information, "Advertencia")
                '        Return
                '    End If
                'Else
                '    MsgBox("Ocurrio un error al registrar el pago 2", MsgBoxStyle.Information, "Advertencia")
                '    Return
                'End If
            Else
                idpagos = PagosTableAdapter.pagos_insertarpago(idventas, Val(IdclienteTextBox.Text), monto1, Now(), idformapagocombo.SelectedValue, NrocomprobanteTextBox.Text)
                If idpagos > 0 Then
                Else
                    MsgBox("Ocurrio un error al registrar el pago", MsgBoxStyle.Information, "Advertencia")
                    Return
                End If
                '**************************************************************
                '***** insertar movimiento de caja
                '**************************************************************
                idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarpago(gidevento, idpagos, idformapagocombo.SelectedValue, monto1, gusername, Nothing)
                If idoperacioncaja > 0 Then
                    Dim PagosImputaciones As New comercialDataSetTableAdapters.pagosimputacionesTableAdapter()
                    PagosImputaciones.pagosimputaciones_insertar(idpagos, idventas, monto1)
                Else
                    MsgBox("Ocurrio un error al registrar el movimiento de caja", MsgBoxStyle.Information, "Advertencia")
                    Return
                End If
            End If
        End If
        '**************************************************************
        '***** CUENTA CORRIENTE MOVIMIENTO DE CAJA
        '**************************************************************
        If idformapagocombo.Text = "Cuenta Corriente" Then
            idoperacioncaja = CajasoperacionesTableAdapter.cajasoperaciones_insertarvtactacte(gidevento, Nothing, idformapagocombo.SelectedValue, monto1, gusername, Nothing, idventas)
            If Not idoperacioncaja > 0 Then
                MsgBox("Ocurrio un error al registrar el movimiento de caja", MsgBoxStyle.Information, "Advertencia")
                Return
            End If
        End If

        '**************************************************************
        '================   VENTA REGISTRADA EXITOSAMENTE -- BASE DE DATOS LOCAL======================
        '********************************************************************************************
        '-----------------  REGISTRAR FACTURA ELECTRÓNICA   ----------------------------------------
        '********************************************************************************************
        '================================================================================================================================
        If GFEAFIPENTORNO = "HOMOLOGACION" Or GFEAFIPENTORNO = "PRODUCCION" Then
            If GFEAUTOCAEAFIP = "SI" And Idtipocomprobantecombo.SelectedValue > 1 Then
                Dim FECAERequest As New WSFEV1.FECAERequest()
                Dim TRA As String = Nothing
                Dim StrError As StrError
                '========================================================================================
                '       generacion TRA
                '========================================================================================
                StrError = GenTRA(TRA)
                If StrError.CodError > 1 Then
                    MessageBox.Show(StrError.MsgError, "No se pudo completar la operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    '========================================================================================
                    '       Generación Factura Electrónica
                    '========================================================================================
                    StrError = FECAELoadRequest(idventas, FECAERequest)
                    If StrError.CodError > 0 Then
                        MessageBox.Show(StrError.MsgError, "No se pudo completar la operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        End If
        '================================================================================================================================
        FinalizarPedidosOrden()
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
                    'Dim p As ViewTicketFE
                    Dim p As New ViewerFactura
                    'p.MdiParent = Me.ParentForm
                    p.ShowInTaskbar = True
                    'p.TopMost = True
                    p.ShowDialog()
                Catch ex As Exception
                    'ErrorLogTableAdapter.errorlog_insertar("Registrar Venta", "Aplicacion", "Confirmar", ex.Message)
                End Try
            Case "Preguntar"
                If MsgBox("Desea Imprimir el comprobante?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                    Try
                        Dim p As New ViewerFactura
                        'p.MdiParent = Me.ParentForm
                        p.ShowInTaskbar = True
                        'p.TopMost = True
                        p.ShowDialog()
                    Catch ex As Exception
                        'ErrorLogTableAdapter.errorlog_insertar("Registrar Venta", "Aplicacion", "Confirmar", ex.Message)
                    End Try
                End If
        End Select
    End Sub
    Private Sub FinalizarPedidosOrden()
        Dim i As Integer
        For i = 0 To ListaordenesmesaDataGridView.RowCount - 1
            OrdenesmesasTableAdapter.ordenesmesas_updateestado("F", idventas, ListaordenesmesaDataGridView.Rows(i).Cells("idordenmesa").Value)
        Next
    End Sub
    Private Sub EntregarPedidosOrden(ByRef idordenmesa As Long)
        Try
            OrdenesmesasTableAdapter.ordenesmesas_updateestado("E", 0, idordenmesa)
        Catch ex As Exception
            MsgBox("Ha Ocurrido una excepción", ex.Message)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Try
            Dim p As ABMClientes
            p = New ABMClientes
            gclienteseleccionado = Val(IdclienteTextBox.Text)
            p.ShowDialog()
            Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
            Me.ListaclientesTableAdapter.FillByIdCliente(Me.ComercialDataSet.listaclientes, gclienteseleccionado)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gclienteseleccionado = 0
        Dim p As SeleccionarCliente
        p = New SeleccionarCliente
        p.ShowDialog()
        IdclienteTextBox.Text = gclienteseleccionado.ToString

        If gclienteseleccionado > 0 Then
            Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
            Me.ListaclientesTableAdapter.FillByIdCliente(Me.ComercialDataSet.listaclientes, gclienteseleccionado)
            If gclienteseleccionado > 1 Then
                'PictureBoxEditarCliente.Visible = True
                'calculafechavencimiento()
                'ButtonDescuentoDefecto.Visible = True
            Else
                'PictureBoxEditarCliente.Visible = False
                'ButtonDescuentoDefecto.Visible = False
            End If
        Else
            Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, 0)
            Me.ListaclientesTableAdapter.FillByIdCliente(Me.ComercialDataSet.listaclientes, 0)
            'PictureBoxEditarCliente.Visible = False
        End If
        gclienteseleccionado = Nothing
    End Sub
    Private Function validardatos(ByRef valida As Boolean) As Boolean
        'Dim valida As Boolean
        '******************* valida carga de datos   *********************
        If idformapagocombo.Text = "Cuenta Corriente" And Val(IdclienteTextBox.Text) = 1 Then
            MsgBox("Seleccione un cliente válido!", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return valida
        End If
        If ListaordenesmesaDataGridView.RowCount = 0 Then
            MsgBox("Debe ingresar al menos un (1) producto!", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return valida
        End If
        If Val(Idtipocomprobantecombo.SelectedValue) > 0 Then
        Else
            MsgBox("Seleccione un tipo de comprobante", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return valida
        End If
        If Val(IdclienteTextBox.Text) > 0 Then
        Else
            MsgBox("Seleccione un cliente válido", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return valida
        End If
        If Val(idformapagocombo.SelectedValue) > 0 Then
        Else
            MsgBox("Seleccione una forma de pago", MsgBoxStyle.Exclamation, "Advertencia")
            valida = False
            Return valida
        End If

        'If Val(pagotextbox.Text) <= 0 Or Trim(pagotextbox.Text) = "" Then
        '    If idformapagocombo.Text = "Cuenta Corriente" Then
        '        pagotextbox.Text = total.ToString
        '        CheckBoxFP2.Checked = False
        '    Else
        '        MsgBox("Monto 1 Incorrecto", MsgBoxStyle.Exclamation, "Advertencia")
        '        pagotextbox.Select()
        '        Return
        '    End If
        'End If

        'If CheckBoxFP2.Checked = True Then '**** forma de pago 2
        '    If Val(idformapagocombo2.SelectedValue) > 0 Then
        '    Else
        '        MsgBox("Seleccione una forma de pago 2", MsgBoxStyle.Exclamation, "Advertencia")
        '        valida = False
        '        Return
        '    End If
        '    If Val(pagotextbox2.Text) <= 0 Then
        '        MsgBox("Monto 2 insuficiente", MsgBoxStyle.Exclamation, "Advertencia")
        '        pagotextbox.Select()
        '        Return
        '    End If
        'End If
        If GFEAFIPENTORNO = "HOMOLOGACION" Or GFEAFIPENTORNO = "PRODUCCION" Then
            If GFEAUTOCAEAFIP = "SI" And Idtipocomprobantecombo.SelectedValue > 1 Then
                Dim StrError As New StrError
                StrError = ValidarDatosClienteAFIP(Val(IdclienteTextBox.Text))
                If StrError.CodError > 1 Then
                    MessageBox.Show(StrError.MsgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    valida = False
                    Return valida
                End If
            End If
        End If
        valida = True
        Return valida
    End Function

    Private Sub ListamesasestadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub ListamesasestadosDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles ListamesasestadosDataGridView.CellContentClick

    End Sub

    Private Sub ListamesasestadosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListamesasestadosDataGridView.CellClick
        Try
            If ListamesasestadosDataGridView.Rows(e.RowIndex).Cells("idmesa").Value > 0 Then
                ComboBoxMesa.SelectedValue = ListamesasestadosDataGridView.Rows(e.RowIndex).Cells("idmesa").Value
                ListamesasestadosDataGridView.CurrentCell = ListamesasestadosDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ListamesasestadosBindingSource.Position = e.RowIndex
                ColorearGridMesas()
                'ListamesasestadosDataGridView.Rows(0).Selected = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class