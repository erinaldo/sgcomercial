Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class BuscaProductoManualPedidos
    Dim ValidarSTK As String
    Dim permisoStockParent As Integer

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
    End Sub
    Private Sub OcultarColumnas()
        Try
            If permisoStockParent = 0 Then
                ProductosDataGridView.Columns("ConsultarStock").Visible = False
            Else
                ProductosDataGridView.Columns("ConsultarStock").Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BuscaProductoManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim PermisosTableAdapter As New comercialDataSetTableAdapters.permisosTableAdapter()
            permisoStockParent = PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "StockParent")
            OcultarColumnas()
            Me.ListaspreciosTableAdapter.FillByEstado(Me.ComercialDataSet.listasprecios, 1)
            Me.ListaproductosTableAdapter.FillByComerciables(Me.ComercialDataSet.listaproductos)

            ProductosDataGridView.Rows(0).Selected = False

            ComboBox1.SelectedIndex = 1
            TextBox1.Select()
            glistaprecio = 1

            '********** ValidarSTK
            ValidarSTK = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ValidarSTK")
            If gValidarSTK = "Disable" Then
                ValidarSTK = gValidarSTK
                gValidarSTK = Nothing
            Else
                ValidarSTK = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ValidarSTK")
            End If
            '********************************************************************************************************
            If glistapreferida > 0 Then
                ComboListaPrecios.SelectedValue = glistapreferida
                TextBox1.Select()
            End If
        Catch ex As Exception
            MsgBox("NO hay productos en la lista!")
            Me.Close()
        End Try
        montotextbox.Enabled = True
        CargaUltimaBusqueda()
        'MsgBox(Environment.GetEnvironmentVariable("SystemDrive"))
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Select Case ComboBox1.Text
            Case "Código"
                ListaproductosBindingSource.Filter = "codigoproducto like'" + TextBox1.Text + "'"
                If ProductosDataGridView.RowCount = 1 Then
                    gcodigoproducto = ProductosDataGridView.CurrentRow.Cells("codigoproducto").Value
                    gprecioventa = ProductosDataGridView.CurrentRow.Cells("precioventa").Value 'ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
                    precioventatextbox.Text = gprecioventa
                    gproductodescripcion = ProductosDataGridView.CurrentRow.Cells("descripcion").Value  'ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
                    ProductosDataGridView.Rows(0).Selected = True
                    CallClick()
                Else
                    gcodigoproducto = Nothing
                    gprecioventa = Nothing
                    precioventatextbox.Text = Nothing
                    gproductodescripcion = Nothing
                    'ProductosDataGridView.Rows(0).Selected = False
                    'ProductosDataGridView.Rows(0).Selected = False
                End If
            Case "Descripción"
                ListaproductosBindingSource.Filter = "descripcion like'%" + TextBox1.Text + "%'"
                If ProductosDataGridView.RowCount = 1 Then
                    gcodigoproducto = ProductosDataGridView.CurrentRow.Cells("codigoproducto").Value
                    'gprecioventa = ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
                    'precioventatextbox.Text = gprecioventa
                    'gproductodescripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
                    ProductosDataGridView.Rows(0).Selected = True
                    CallClick()
                    cantidadtextbox.Select()
                Else
                    gcodigoproducto = Nothing
                    gprecioventa = Nothing
                    precioventatextbox.Text = Nothing
                    gproductodescripcion = Nothing
                    'ProductosDataGridView.Rows(0).Selected = False
                    Try
                        'ProductosDataGridView.Rows(0).Selected = False
                        'CallClick()
                    Catch ex As Exception

                    End Try

                End If
        End Select
        '*****************************************************
    End Sub

    Private Sub ProductosDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        Try
            Select Case ProductosDataGridView.Columns(e.ColumnIndex).Name
                Case "ConsultarStock"
                    Cursor.Current = Cursors.WaitCursor
                    Try
                        Dim idproducto As Long = 0
                        idproducto = ProductosTableAdapter.productos_existeproducto(ProductosDataGridView.CurrentRow.Cells("codigoproducto").Value)
                        If Not idproducto > 0 Then Return
                        Dim stkr As ConsultaStockRemotoProducto
                        stkr = New ConsultaStockRemotoProducto
                        gcodigoproducto = ProductosDataGridView.CurrentRow.Cells("codigoproducto").Value
                        Cursor.Current = Cursors.Default
                        stkr.ShowDialog()
                    Catch ex As Exception
                        Cursor.Current = Cursors.Default
                    End Try
                Case Else
                    CallClick()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Sub CallClick()
        Try
            gcodigoproducto = ProductosDataGridView.CurrentRow.Cells("codigoproducto").Value
            'gproductodescripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
            gproductodescripcion = ProductosDataGridView.CurrentRow.Cells("descripcion").Value
            cantidadtextbox.Text = Nothing
            montotextbox.Text = Nothing
            ConsultarStockDisponible()
            calculapreciolista()
        Catch ex As Exception
            ' MsgBox("LISTA VACIA" + ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
        End Try
    End Sub

    Private Sub ProductosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub cantidadtextbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cantidadtextbox.KeyDown

        If Len(Trim(cantidadtextbox.Text)) = 0 Then Return

        If IsNumeric(cantidadtextbox.Text) = False Then
            e.Handled = False
            Return
        End If
        If IsNumeric(precioventatextbox.Text) = False Then
            e.Handled = False
            Return
        End If
        If e.KeyCode = Keys.Enter Then
            ConsultarStockDisponible()
            '*************************************
            Dim cantidaddisponible As Decimal
            Dim cantidaddisponibleenv As Decimal
            '*************************************
            If textboxUnidades.Text = "" Or textboxUnidades.Text = "0" Then
                cantidaddisponible = 0
            Else
                cantidaddisponible = Convert.ToDecimal(textboxUnidades.Text)
            End If
            If textboxEnvasado.Text = "" Then
                cantidaddisponibleenv = 0
            Else
                cantidaddisponibleenv = textboxEnvasado.Text
            End If


            gcantidad = cantidadtextbox.Text
            gcantidad = Decimal.Round(gcantidad, 3)
            Select Case glistaprecio    '*********+++   validar stock disponible    ***************
                Case 2 'es a granel
                    If cantidaddisponible < gcantidad And ValidarSTK = "Enable" Then

                        gcantidad = 0
                        gmontototal = 0
                        Return
                        'Me.Close()
                    End If
                Case Else
                    If cantidaddisponibleenv < gcantidad And ValidarSTK = "Enable" Then
                        MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente ")
                        gcantidad = 0
                        gmontototal = 0
                        Return
                        'Me.Close()
                    End If
            End Select
            gmontototal = Decimal.Round(Convert.ToDecimal(montotextbox.Text), 3)
            Me.Close()
        End If


    End Sub

    Private Sub cantidadtextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cantidadtextbox.KeyPress
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

    Private Sub cantidadtextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cantidadtextbox.TextChanged
        If Len(Trim(cantidadtextbox.Text)) = 0 Then Return
        If IsNumeric(cantidadtextbox.Text) = False Then
            Return
        End If
        If cantidadtextbox.Focused Then
            gcantidad = Convert.ToDecimal(cantidadtextbox.Text)
            Dim montototal As Decimal
            Dim precioventa As Decimal = gprecioventa
            montototal = gcantidad * precioventa
            montototal = Decimal.Round(montototal, 2)
            montotextbox.Text = montototal.ToString
        End If
    End Sub

    Private Sub BuscaProductoManual_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub montotextbox_TextChanged(sender As Object, e As EventArgs) Handles montotextbox.TextChanged
        If Len(Trim(montotextbox.Text)) = 0 Then Return

        If montotextbox.Focused Then
            Try
                gmontototal = Convert.ToDecimal(montotextbox.Text)
                gprecioventa = precioventatextbox.Text
                gcantidad = gmontototal / gprecioventa
                gcantidad = Decimal.Round(gcantidad, 3)
                cantidadtextbox.Text = gcantidad
            Catch ex As Exception
                MsgBox("Ingrese un valor")
                montotextbox.Select()
            End Try
        End If
    End Sub

    Private Sub montotextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles montotextbox.KeyDown
        If Len(Trim(montotextbox.Text)) = 0 Then Return
        If e.KeyCode = Keys.Enter Then
            Dim cantidaddisponible As Decimal
            Dim cantidaddisponibleenv As Decimal
            Try
                cantidaddisponible = textboxUnidades.Text
                cantidaddisponibleenv = textboxEnvasado.Text
                gcantidad = cantidadtextbox.Text
            Catch ex As Exception
                MsgBox("Verifique la cantidad ingresada!", MsgBoxStyle.Exclamation, "Advertencia")
                cantidadtextbox.Select()
                Return
            End Try
            gcantidad = cantidadtextbox.Text
            gcantidad = Decimal.Round(gcantidad, 3)
            Select Case glistaprecio    '*********+++   validar stock disponible    ***************
                Case 2 'es a granel
                    If cantidaddisponible < gcantidad And ValidarSTK = "Enable" Then
                        MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente ")
                        gcantidad = 0
                        gmontototal = 0
                        Return
                        'Me.Close()
                    End If
                Case Else
                    If cantidaddisponibleenv < gcantidad And ValidarSTK = "Enable" Then
                        MsgBox("No hay stock disponible!", MsgBoxStyle.Exclamation, "Producto insuficiente ")
                        gcantidad = 0
                        gmontototal = 0
                        Return
                        'Me.Close()
                    End If
            End Select
            gmontototal = Decimal.Round(Convert.ToDecimal(montotextbox.Text), 3)
            Me.Close()
        End If
    End Sub

    Private Sub montotextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles montotextbox.KeyPress

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
            MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If


    End Sub

    Private Sub ComboListaPrecios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboListaPrecios.SelectedIndexChanged
        Dim precioventagranel As Decimal = 0
        Try
            Select Case ComboListaPrecios.SelectedValue
                Case 1
                    glistaprecio = 1
                    'precioventa = ProductosTableAdapter.productos_consultarprecioventa(codigoproducto)
                    precioventatextbox.Text = ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
                    gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventa.ToString)
                Case 2
                    glistaprecio = 2
                    precioventagranel = ProductosTableAdapter.productos_consultarpreciogranel(gcodigoproducto)
                    Dim medida As Decimal
                    medida = ProductosTableAdapter.productos_consultarmedida(gcodigoproducto)
                    precioventatextbox.Text = precioventagranel / medida
                    gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventagranel.ToString)
                Case 3
                    glistaprecio = 3
                    'precioventamayorista = ProductosTableAdapter.productos_consultarpreciomayorista(gcodigoproducto)
                    precioventatextbox.Text = ProductosTableAdapter.productos_consultarpreciomayorista(gcodigoproducto)
                    gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventamayorista.ToString)
                Case 4
                    glistaprecio = 4
                    'precioventacomercios / precioventadistribuidor
                    precioventatextbox.Text = ProductosTableAdapter.productos_precioventadistribuidor(gcodigoproducto)
                    gprecioventa = precioventatextbox.Text
                    'MsgBox("hola" + precioventamayorista.ToString)
                Case Else
                    MsgBox("Opcion no configurada", MsgBoxStyle.Exclamation)
            End Select
            calcular()
            cantidadtextbox.Select()
        Catch ex As Exception
            MsgBox("No se pudo completar la operación: " + ex.Message)
        End Try

    End Sub
    Public Sub calculapreciolista()
        Dim precioventagranel As Decimal = 0
        Select Case ComboListaPrecios.SelectedValue
            Case 1
                glistaprecio = 1
                'precioventa = ProductosTableAdapter.productos_consultarprecioventa(codigoproducto)
                precioventatextbox.Text = ProductosDataGridView.CurrentRow.Cells("precioventa").Value   'ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
                gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventa.ToString)
            Case 2
                glistaprecio = 2
                precioventagranel = ProductosDataGridView.CurrentRow.Cells("precioventagranel").Value 'ProductosTableAdapter.productos_consultarpreciogranel(gcodigoproducto)
                Dim medida As Decimal
                medida = ProductosTableAdapter.productos_consultarmedida(gcodigoproducto)
                precioventatextbox.Text = precioventagranel / medida
                gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventagranel.ToString)
            Case 3
                glistaprecio = 3
                'precioventamayorista = ProductosTableAdapter.productos_consultarpreciomayorista(gcodigoproducto)
                precioventatextbox.Text = ProductosDataGridView.CurrentRow.Cells("precioventamayorista").Value   ' ProductosTableAdapter.productos_consultarpreciomayorista(gcodigoproducto)
                gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventamayorista.ToString)
            Case 4
                glistaprecio = 4
                'precioventacomercios
                precioventatextbox.Text = ProductosDataGridView.CurrentRow.Cells("precioventadistribuidor").Value   'ProductosTableAdapter.productos_precioventadistribuidor(gcodigoproducto)
                gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventamayorista.ToString)
            Case Else
                MsgBox("Opcion no configurada", MsgBoxStyle.Exclamation)
        End Select
        calcular()
    End Sub

    Sub calcular()
        Dim total As Decimal
        '        cantidadtextbox.Text = "1"
        'preciotextbox.Text = "$ " + precioventa.ToString
        'precioventa = preciotextbox.Text
        Try
            total = gprecioventa * cantidadtextbox.Text
            montotextbox.Text = total.ToString
        Catch ex As Exception
            cantidadtextbox.Text = ""
            montotextbox.Text = ""
        End Try

    End Sub

    Private Sub ProductosDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ProductosDataGridView.SelectionChanged
        '********* comentado temporalmente
        Try
            gcodigoproducto = Nothing
            gprecioventa = Nothing
            precioventatextbox.Text = Nothing
            gproductodescripcion = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ConsultarStockDisponible()
        If ValidarSTK = "Enable" Then
            Dim StockgeneralTableAdapter As New comercialDataSetTableAdapters.stockgeneralTableAdapter()
            textboxEnvasado.Text = StockgeneralTableAdapter.stockgeneral_consultardisponible(ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells("idproducto").Value)
            textboxUnidades.Text = StockgeneralTableAdapter.stockgeneral_consultardisponible(ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells("idproducto").Value)
        Else
            textboxEnvasado.Text = "0"
            textboxUnidades.Text = "0"
        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProductosDataGridView.Select()
            Try
                If ProductosDataGridView.RowCount > 0 Then
                    ProductosDataGridView.Rows(0).Selected = True
                    ProductosDataGridView.CurrentCell = ProductosDataGridView.Rows(0).Cells("descripcion")
                    ProductosDataGridView.Focus()
                End If
                'ProductosDataGridView.Rows(0).Selected = True
                'ProductosDataGridView.FirstDisplayedScrollingRowIndex = ProductosDataGridView.Rows(0).Index
                'CallClick()
            Catch ex As Exception
                MsgBox("Debe seleccionar al menos un producto de la lista", MsgBoxStyle.Exclamation, "Advertencia!")
            End Try

        End If
    End Sub

    Private Sub ProductosDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductosDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            CallClick()
            cantidadtextbox.Select()
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Space Then
            CallClick()
            'cantidadtextbox.Select()
            e.SuppressKeyPress = True
        End If
    End Sub

    'Private Sub ProductosDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.RowEnter

    'End Sub

    Private Sub ProductosDataGridView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductosDataGridView.KeyPress

    End Sub

    'Private Sub ProductosDataGridView_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.RowLeave

    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Select()
    End Sub

    Private Sub ProductosDataGridView_Layout(sender As Object, e As LayoutEventArgs) Handles ProductosDataGridView.Layout

    End Sub

    Private Sub BuscaProductoManualPedidos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GuardaUltimaBusqueda()
    End Sub
    Public Sub GuardaUltimaBusqueda()
        Select Case ComboBox1.Text
            Case "Código"
                gUltimoProdBuscado = Nothing
                gUltimoCodBuscado = TextBox1.Text
            Case "Descripción"
                gUltimoProdBuscado = TextBox1.Text
                gUltimoCodBuscado = Nothing
        End Select
    End Sub
    Public Sub CargaUltimaBusqueda()
        If Len(gUltimoCodBuscado) > 0 Then
            ComboBox1.SelectedIndex = 0
            TextBox1.Text = gUltimoCodBuscado
            TextBox1.Select()
        End If
        If Len(gUltimoProdBuscado) > 0 Then
            ComboBox1.SelectedIndex = 1
            TextBox1.Text = gUltimoProdBuscado
            TextBox1.Select()
        End If
    End Sub

    Private Sub ProductosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellDoubleClick
        Try
            Select Case ProductosDataGridView.Columns(e.ColumnIndex).Name
                Case "ConsultarStock"
                    Cursor.Current = Cursors.WaitCursor
                    Try
                        Dim idproducto As Long = 0
                        idproducto = ProductosTableAdapter.productos_existeproducto(ProductosDataGridView.CurrentRow.Cells("codigoproducto").Value)
                        If Not idproducto > 0 Then Return
                        Dim stkr As ConsultaStockRemotoProducto
                        stkr = New ConsultaStockRemotoProducto
                        gcodigoproducto = ProductosDataGridView.CurrentRow.Cells("codigoproducto").Value
                        Cursor.Current = Cursors.Default
                        stkr.ShowDialog()
                    Catch ex As Exception
                        Cursor.Current = Cursors.Default
                    End Try
                Case Else
                    CallClick()
                    cantidadtextbox.Select()
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ProductosDataGridView_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContextMenuStripChanged

    End Sub
End Class