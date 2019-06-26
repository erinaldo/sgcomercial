Imports System.Text.RegularExpressions
Public Class ingresoegresoproductos
    Dim idproducto As Long
    'Public Sub setcodigoproducto()
    '    codigoproductoTextBox.Text = gcodigoproducto
    'End Sub

    Private Sub ingresoegresoproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.motivostock' Puede moverla o quitarla según sea necesario.
        Me.MotivostockTableAdapter.Fill(Me.ComercialDataSet.motivostock)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productoscomponentes' Puede moverla o quitarla según sea necesario.
        Me.ProductoscomponentesTableAdapter.Fill(Me.ComercialDataSet.productoscomponentes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.ComercialDataSet.stock)
        ProductosDataGridView.Visible = False
        StockDataGridView.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)

        Me.TipomovimientostockTableAdapter.Fill(Me.ComercialDataSet.tipomovimientostock)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stock' Puede moverla o quitarla según sea necesario.
        'Me.StockTableAdapter.Fill(Me.ComercialDataSet.stock)
        enableedit(True)
        LinkStockRemoto.Enabled = False
        'Labeldescripcion.Text = ""


    End Sub

    Public Sub enableedit(ByVal status As Boolean)
        codigoproductoTextBox.Enabled = status
        CantidadTextBox.Enabled = status
        TipomovimientostockComboBox.Enabled = status
        FechamovimientoDateTimePicker.Enabled = status
        FechacargaDateTimePicker.Enabled = False
        FechacargaDateTimePicker.Value = Today
        UsuariocargaTextBox.Enabled = False
        UsuariocargaTextBox.Text = gusername
        ComboMotivoStock.Enabled = status
    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        UsuariocargaTextBox.Text = gusername
        FechacargaDateTimePicker.Value = Today()
    End Sub

    Private Sub IdproductoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codigoproductoTextBox.TextChanged


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button4.Click
        consultardisponibles()
        '********************validaciones previas**********************
        idproducto = ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)
        If ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text) = 0 Then
            MsgBox("Seleccione un producto válido", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        If Len(Trim(ComboUnidad.Text)) = 0 Then
            MsgBox("Seleccione el tipo de cantidad a ingresar", MsgBoxStyle.Exclamation, "Advertencia")
            ComboUnidad.Select()
            Return
        End If
        If Len(Trim(CantidadTextBox.Text)) = 0 Then
            MsgBox("Ingrese una cantidad válida", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        If Convert.ToDecimal(CantidadTextBox.Text) <= 0 Or Len(Trim(CantidadTextBox.Text)) = 0 Then
            MsgBox("Ingrese una cantidad válida", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        If TipomovimientostockComboBox.SelectedValue = "S" And Not Convert.ToDecimal(textdisponible.Text) > 0 Then
            MsgBox("No se puede sacar productos sin stock disponible", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        If TipomovimientostockComboBox.SelectedValue = "S" And Val(textdisponible.Text) < Val(CantidadTextBox.Text) Then
            MsgBox("La cantidad ingresada supera al stock disponible", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        If Len(Trim(TextBoxMedida.Text)) = 0 Then
            MsgBox("Seleccione una unidad de medida válida", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        '********************registrar movimiento**********************
        Dim cantidad As Decimal = CantidadTextBox.Text
        Dim medida As Decimal = TextBoxMedida.Text
        If ComboUnidad.SelectedIndex = 1 Then ' son empaques de x cantidad de kilos se multiplica cantidad x medida
            cantidad = cantidad * medida
        Else
            cantidad = cantidad 'son kilogramos de producto
        End If
        Try
            If StockTableAdapter.stock_insertarmovimiento(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text), cantidad, FechamovimientoDateTimePicker.Value.ToShortDateString, guserid, TipomovimientostockComboBox.SelectedValue, "Manual", ComboMotivoStock.SelectedValue) >= 0 Then
                'MsgBox("Movimiento cargado exitosamente!", MsgBoxStyle.Information, "Información")
                textdisponible.Text = StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)).ToString
                FormPrincipal.reloadstock()
                '=======================================================
                '=================== FUNCIONES CLOWD NUBE  ================================
                If gModuloClowd = 1 Then
                    BGWStockClowd.RunWorkerAsync()
                End If
                '=================== --------------------------  ================================
                'ParentForm.reloadstock()
                Labeldescripcion.Text = ".............................................."
                textdisponible.Text = ""
                CantidadTextBox.Text = ""
                textstockminimo.Text = Nothing
                TextBoxEnvasado.Text = Nothing
                ComboUnidad.SelectedIndex = -1
                TextBoxMedida.Text = Nothing
                nuevo()
            Else
                MsgBox("No se pudo insertar el movimiento", MsgBoxStyle.Information, "Advertencia")
            End If
            FormPrincipal.reloadstock()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TipomovimientostockComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipomovimientostockComboBox.SelectedIndexChanged

    End Sub

    Private Sub CantidadTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CantidadTextBox.TextChanged

        If IsNumeric(CantidadTextBox.Text) = False Then
            CantidadTextBox.Select()
        End If
    End Sub

    Private Sub nuevo()
        CantidadTextBox.Text = ""
        textdisponible.Text = ""
        textstockminimo.Text = ""
        codigoproductoTextBox.Text = ""
        Labeldescripcion.Text = ""
        codigoproductoTextBox.Select()
    End Sub

    Private Sub Labeldescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labeldescripcion.Click

    End Sub

    Private Sub codigoproductoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codigoproductoTextBox.KeyPress
    End Sub

    Private Sub codigoproductoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles codigoproductoTextBox.KeyDown
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If e.KeyCode.ToString = "F4" Then
            BuscaProductoManual()
            enterkeydown()
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Enter Then
            If ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text) > 0 Then
                If ProductosTableAdapter.productos_consultarproductocompuesto(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)) = "S" Then
                    MsgBox("No se puede cargar stock de productos compuestos! debe cargar stock de sus componentes", MsgBoxStyle.Exclamation, "Advertencia")
                    CantidadTextBox.Select()
                    textdisponible.Text = ""
                    CantidadTextBox.Text = ""
                    codigoproductoTextBox.Text = ""
                    codigoproductoTextBox.Select()
                    Labeldescripcion.Text = ""
                    textstockminimo.Text = ""
                    ComboUnidad.SelectedIndex = -1
                    TextBoxMedida.Text = ""
                    Return
                End If
                textstockminimo.Text = ProductosTableAdapter.productos_stockminimo(codigoproductoTextBox.Text)
                Labeldescripcion.Text = ProductosTableAdapter.productos_consultardescripcion(codigoproductoTextBox.Text)

                If StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)) > 0 Then
                    textdisponible.Text = StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)).ToString
                    If textdisponible.Text = "" Then textdisponible.Text = "0"
                    CantidadTextBox.Text = ""
                Else
                    textdisponible.Text = StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)).ToString
                    CantidadTextBox.Select()
                    If textdisponible.Text = "" Then textdisponible.Text = "0"
                    CantidadTextBox.Text = ""
                End If

                ComboUnidad.SelectedIndex = -1
                TextBoxMedida.Text = "1"
            Else
                Labeldescripcion.Text = "No Registrado"
                textdisponible.Text = ""
                CantidadTextBox.Text = ""
                textstockminimo.Text = Nothing
                TextBoxEnvasado.Text = Nothing
                LinkStockRemoto.Enabled = False
                'MsgBox("El código ingresado no pertenece a ningun producto registrado", MsgBoxStyle.Information, "Advertencia")
            End If
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub
    Private Sub consultardisponibles()
        textstockminimo.Text = ProductosTableAdapter.productos_stockminimo(codigoproductoTextBox.Text)
        Labeldescripcion.Text = ProductosTableAdapter.productos_consultardescripcion(codigoproductoTextBox.Text)

        If StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)) > 0 Then
            textdisponible.Text = StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)).ToString
            If textdisponible.Text = "" Then textdisponible.Text = "0"
            'CantidadTextBox.Text = ""
        Else
            textdisponible.Text = StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)).ToString
            CantidadTextBox.Select()
            If textdisponible.Text = "" Then textdisponible.Text = "0"
            'CantidadTextBox.Text = ""
        End If
    End Sub
    Private Sub enterkeydown()
        If ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text) > 0 Then
            If ProductosTableAdapter.productos_consultarproductocompuesto(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)) = "S" Then
                MsgBox("No se puede cargar stock de productos compuestos! debe cargar stock de sus componentes", MsgBoxStyle.Exclamation, "Advertencia")
                CantidadTextBox.Select()
                textdisponible.Text = ""
                CantidadTextBox.Text = ""
                codigoproductoTextBox.Text = ""
                codigoproductoTextBox.Select()
                Labeldescripcion.Text = ""
                textstockminimo.Text = ""
                Return
            End If
            textstockminimo.Text = ProductosTableAdapter.productos_stockminimo(codigoproductoTextBox.Text)
            Labeldescripcion.Text = ProductosTableAdapter.productos_consultardescripcion(codigoproductoTextBox.Text)
            gcodigoproducto = codigoproductoTextBox.Text
            LinkStockRemoto.Enabled = True


            If StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)) > 0 Then
                textdisponible.Text = StockTableAdapter.stock_consultardisponible(ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)).ToString
                If textdisponible.Text = "" Then textdisponible.Text = "0"
                CantidadTextBox.Text = ""
            Else
                CantidadTextBox.Select()
                If textdisponible.Text = "" Then textdisponible.Text = "0"
                CantidadTextBox.Text = ""
            End If
            ComboUnidad.SelectedIndex = 1
            TextBoxMedida.Text = Nothing
            SetUnidadMedida()
        Else
            Labeldescripcion.Text = "No Registrado"
            textdisponible.Text = ""
            CantidadTextBox.Text = ""
            textstockminimo.Text = Nothing
            TextBoxEnvasado.Text = Nothing
            LinkStockRemoto.Enabled = False
            'MsgBox("El código ingresado no pertenece a ningun producto registrado", MsgBoxStyle.Information, "Advertencia")
        End If
    End Sub

    Private Sub BuscaProductoManual()
        gcodigoproducto = 0
        Dim p As BuscaCodigoProductoManual
        p = New BuscaCodigoProductoManual
        p.ShowDialog()
        If Len(Trim(gcodigoproducto)) = 0 Then Return
        codigoproductoTextBox.Text = gcodigoproducto
        consultardisponibles()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        BuscaProductoManual()
        enterkeydown()
    End Sub

    Private Sub CantidadTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidadTextBox.KeyPress
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

    Private Sub ComboUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboUnidad.SelectedIndexChanged
        SetUnidadMedida()
    End Sub
    Private Sub SetUnidadMedida()
        Select Case ComboUnidad.SelectedIndex
            Case 1
                Dim medida As Decimal
                medida = ProductosTableAdapter.productos_consultarmedida(codigoproductoTextBox.Text)
                TextBoxMedida.Text = medida
            Case 0
                TextBoxMedida.Text = "1"
        End Select
    End Sub

    Private Sub textdisponible_TextChanged(sender As Object, e As EventArgs) Handles textdisponible.TextChanged
        Try
            Dim medida As Decimal
            Dim disponible As Decimal = textdisponible.Text
            medida = ProductosTableAdapter.productos_consultarmedida(codigoproductoTextBox.Text)
            TextBoxEnvasado.Text = Math.Round(disponible / medida, 2)
        Catch ex As Exception
            'textdisponible.Text = "0"
            TextBoxEnvasado.Text = "0"
        End Try

    End Sub

    Private Sub ingresoegresoproductos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub BGWStockClowd_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWStockClowd.DoWork
        Dim coderror As Long
        Dim msgerror As String = Nothing
        SynStockClowd(idproducto, "A", coderror, msgerror)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkStockRemoto.LinkClicked
        Dim stkr As ConsultaStockRemotoProducto
        stkr = New ConsultaStockRemotoProducto
        stkr.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button5.Click
        Dim idproducto As Long = 0
        idproducto = ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)
        If Not idproducto > 0 Then Return

        If MsgBox("Seguro desea resetear el stock de este producto a CERO?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            StockTableAdapter.stock_resetproducto(idproducto, gusername)
            consultardisponibles()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text) > 0 Then Return
        Try
            'If MsgBox("Esta acción no se podrá volver atrás." & vbCr & "Esta seguro que desea dar de baja este producto?", MsgBoxStyle.Question, "Pregunta") Then
            If MessageBox.Show("Esta acción no se podrá volver atrás." & vbCr & "Esta seguro que desea dar de baja este producto?", "Pregunta", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    ProductosTableAdapter.productos_estadoproducto("I", ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text))
                    nuevo()
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class