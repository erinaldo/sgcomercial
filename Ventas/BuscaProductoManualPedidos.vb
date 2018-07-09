Imports System.Text.RegularExpressions
Public Class BuscaProductoManualPedidos
    Dim ValidarSTK As String

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub BuscaProductoManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.parametrosgenerales' Puede moverla o quitarla según sea necesario.
        Me.ParametrosgeneralesTableAdapter.Fill(Me.ComercialDataSet.parametrosgenerales)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listasprecios' Puede moverla o quitarla según sea necesario.
        Me.ListaspreciosTableAdapter.Fill(Me.ComercialDataSet.listasprecios)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaproductos' Puede moverla o quitarla según sea necesario.
        Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
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


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Select Case ComboBox1.Text
            Case "Código"
                ListaproductosBindingSource.Filter = "codigoproducto like'%" + TextBox1.Text + "%'"
                'If ProductosDataGridView.RowCount = 0 Then
                '    ProductosDataGridView.Rows(0).Selected = False
                'End If

                If ProductosDataGridView.RowCount = 1 Then
                    gcodigoproducto = ProductosDataGridView.CurrentRow.Cells(0).Value
                    gprecioventa = ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
                    precioventatextbox.Text = gprecioventa
                    gproductodescripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
                    ProductosDataGridView.Rows(0).Selected = True
                    Dim idproducto As Long = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
                    textboxEnvasado.Text = StockTableAdapter.stock_consultardisponibleenvasado(idproducto)
                    textboxUnidades.Text = StockTableAdapter.stock_consultardisponible(idproducto)
                    'cantidadtextbox.Select()
                Else
                    gcodigoproducto = Nothing
                    gprecioventa = Nothing
                    precioventatextbox.Text = Nothing
                    gproductodescripcion = Nothing
                    'ProductosDataGridView.Rows(0).Selected = False
                End If
            Case "Descripción"
                ListaproductosBindingSource.Filter = "descripcion like'%" + TextBox1.Text + "%'"

                If ProductosDataGridView.RowCount = 1 Then
                    gcodigoproducto = ProductosDataGridView.CurrentRow.Cells(0).Value
                    gprecioventa = ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
                    precioventatextbox.Text = gprecioventa
                    gproductodescripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
                    ProductosDataGridView.Rows(0).Selected = True
                    'cantidadtextbox.Select()
                    Dim idproducto As Long = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
                    textboxEnvasado.Text = StockTableAdapter.stock_consultardisponibleenvasado(idproducto)
                    textboxUnidades.Text = StockTableAdapter.stock_consultardisponible(idproducto)
                Else
                    gcodigoproducto = Nothing
                    gprecioventa = Nothing
                    precioventatextbox.Text = Nothing
                    gproductodescripcion = Nothing
                    Try
                        ProductosDataGridView.Rows(0).Selected = False
                    Catch ex As Exception

                    End Try

                End If
        End Select

    End Sub

    Private Sub ProductosDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        gcodigoproducto = ProductosDataGridView.CurrentRow.Cells(0).Value
        gprecioventa = ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
        precioventatextbox.Text = gprecioventa
        gproductodescripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
        ComboBox1.SelectedIndex = 1
        cantidadtextbox.Text = Nothing
        montotextbox.Text = Nothing
        Dim idproducto As Long = ProductosTableAdapter.productos_existeproducto(gcodigoproducto)
        textboxEnvasado.Text = StockTableAdapter.stock_consultardisponibleenvasado(idproducto)
        textboxUnidades.Text = StockTableAdapter.stock_consultardisponible(idproducto)
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
        If e.KeyCode.ToString = "Escape" Then
            Me.Close()
        End If
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
            Dim cantidaddisponible As Decimal = textboxUnidades.Text
            Dim cantidaddisponibleenv As Decimal = textboxEnvasado.Text
            Try
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
        Select Case ComboListaPrecios.SelectedIndex
            Case 0
                glistaprecio = 1
                'precioventa = ProductosTableAdapter.productos_consultarprecioventa(codigoproducto)
                precioventatextbox.Text = ProductosTableAdapter.productos_consultarprecioventa(gcodigoproducto)
                gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventa.ToString)
            Case 1
                glistaprecio = 2
                precioventagranel = ProductosTableAdapter.productos_consultarpreciogranel(gcodigoproducto)
                Dim medida As Decimal
                medida = ProductosTableAdapter.productos_consultarmedida(gcodigoproducto)
                precioventatextbox.Text = precioventagranel / medida
                gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventagranel.ToString)
            Case 2
                glistaprecio = 3
                'precioventamayorista = ProductosTableAdapter.productos_consultarpreciomayorista(gcodigoproducto)
                precioventatextbox.Text = ProductosTableAdapter.productos_consultarpreciomayorista(gcodigoproducto)
                gprecioventa = precioventatextbox.Text
                'MsgBox("hola" + precioventamayorista.ToString)
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
        Try
            textboxEnvasado.Text = StockTableAdapter.stock_consultardisponibleenvasado(ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells(0).Value)
            textboxUnidades.Text = StockTableAdapter.stock_consultardisponible(ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells(0).Value)
        Catch ex As Exception

        End Try

    End Sub
End Class