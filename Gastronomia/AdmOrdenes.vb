
Public Class AdmOrdenes

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
    End Sub

    Private Sub AdmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '**********************************************************************
        Me.MozosTableAdapter.Fill(Me.ComercialDataSet.mozos)
        Me.SalonesTableAdapter.FillByActivos(Me.ComercialDataSet.salones)
        Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
        '**********************************************************************
        ComboBoxSalon.SelectedIndex = -1
        ComboBoxMesa.SelectedIndex = -1
        NuevaÓrdenToolStripMenuItem.Enabled = False
        AnularOrdenToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ComboBoxSalon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSalon.SelectedIndexChanged
        Try
            Me.MesasTableAdapter.FillBySalon(Me.ComercialDataSet.mesas, ComboBoxSalon.SelectedValue)
            ComboBoxMesa.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Aviso!", "Seleccione primero un salón", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Try

            If Not validardatos() = True Then Return
            If MessageBox.Show("Seguro desea FINALIZAR la mesa?", "MESA: " + ComboBoxMesa.SelectedValue.ToString, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                FinalizarMesa(ComboBoxMesa.SelectedValue.ToString)
                LoadOrdenes()
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
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NuevaÓrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaÓrdenToolStripMenuItem.Click

        gidproducto = Nothing
        glistaprecio = Nothing
        glistapreferida = Nothing
        gprecioventa = Nothing
        gcantidad = Nothing
        gcodigoproducto = Nothing
        buscaproductomanual()
        LoadOrdenes()

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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '*************************
    End Sub

    Private Sub ComboBoxMesa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMesa.SelectedIndexChanged
        LoadOrdenes()
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
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FinalizarMesa(ByVal idmesa As Long)


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
    Private Function validardatos() As Boolean
        Dim valida As Boolean
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
    End Function
End Class