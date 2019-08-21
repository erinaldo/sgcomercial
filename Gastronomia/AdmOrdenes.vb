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
        MsgBox("Hola")
    End Sub

    Private Sub AnularMesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularMesaToolStripMenuItem.Click
        MsgBox("Holamundo")
    End Sub

    Private Sub NuevaÓrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaÓrdenToolStripMenuItem.Click

        gidproducto = Nothing
        glistaprecio = Nothing
        glistapreferida = Nothing
        gprecioventa = Nothing
        gcantidad = Nothing
        gcodigoproducto = Nothing
        buscaproductomanual()

    End Sub


    Public Sub buscaproductomanual()
        gcantidad = 0
        Dim idmesa As Integer = ComboBoxMesa.SelectedValue
        Dim idproducto As Long
        Dim descripcion As String
        Dim newrow As Long
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
        If ComboBoxMesa.SelectedValue > 0 Then
            NuevaÓrdenToolStripMenuItem.Enabled = True
            ListaordenesmesaTableAdapter.FillByEstadoMesa(Me.ComercialDataSet.listaordenesmesa, "P", ComboBoxMesa.SelectedValue)
            LabelMESA.Text = ComboBoxMesa.SelectedValue.ToString
        Else
            NuevaÓrdenToolStripMenuItem.Enabled = False
        End If
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
End Class