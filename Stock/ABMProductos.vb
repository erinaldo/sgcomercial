Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class ABMProductos
    Dim codigolimpio As String
    Dim codigoORIGINAL As String
    Dim codigoNUEVO As String
    '------------------------------------------------------------------------------------
    Dim ErrorLog As comercialDataSetTableAdapters.errorlogTableAdapter

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)
        Try
            ReparaProductosEstados()
            Me.TipoivaTableAdapter.Fill(Me.ComercialDataSet.tipoiva)
            Me.StockTableAdapter1.Fill(Me.ComercialDataSet.stock)
            IdproductoTextBox.Visible = False
            Me.RubrosTableAdapter.Fill(Me.ComercialDataSet.rubros)
            Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet1.unidadesmedida)
            Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
            ErrorLog = New comercialDataSetTableAdapters.errorlogTableAdapter()
            ActualizaCantidad()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''''''''''''''''''''''''''''--CLOWD--''''''''''''''''''''''''''''''''''''''''''''''
        Dim ModulosTableAdapter As comercialDataSetTableAdapters.modulosTableAdapter
        ModulosTableAdapter = New comercialDataSetTableAdapters.modulosTableAdapter()
        gModuloClowd = ModulosTableAdapter.modulos_consultarestado("ModuloClowd")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        enableedit(False)
        enablefilter(True)
        stockinicialtextbox.Enabled = False
        ComboBox2.SelectedIndex = 1
        TextFiltro.Select()

    End Sub
    Sub ActualizaCantidad()
        ToolStripTextBoxCantidad.Text = "Productos: " + ProductosDataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible).ToString
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Dim idproveedor As Long = 0
        If ComboProveedores.SelectedIndex >= 0 Then
            idproveedor = ComboProveedores.SelectedValue
        End If
        Me.Validate()
        '*************  VALIDAR DATOS CARGADOS ************
        '****************   primero valido el codigo
        Dim res As Boolean = True
        validacodigoproducto(res)
        If res = False Then
            Return
        End If
        codigoNUEVO = codigoproductoTextBox.Text
        '**********************************************
        If Len(Trim(MarcaTextBox.Text)) = 0 Then
            MsgBox("Ingrese la marca del producto", MsgBoxStyle.Exclamation, "Advertencia")
            MarcaTextBox.Select()
            Return
        End If
        If Len(Trim(ModeloTextBox.Text)) = 0 Then
            MsgBox("Ingrese modelo del producto", MsgBoxStyle.Exclamation, "Advertencia")
            ModeloTextBox.Select()
            Return
        End If
        If Len(Trim(PresentacionTextBox.Text)) = 0 Then
            MsgBox("Ingrese presentacion del producto", MsgBoxStyle.Exclamation, "Advertencia")
            PresentacionTextBox.Select()
            Return
        End If
        If Not Len(ComboBox1.Text) > 0 Then
            MsgBox("Seleccione unidad de medida!", MsgBoxStyle.Exclamation, "Advertencia")
            ComboBox1.Select()
            Return
        End If
        If MedidaTextBox.Text = Nothing Or Not Val(MedidaTextBox.Text) > 0 Then
            MsgBox("Indique valor de medida válido!", MsgBoxStyle.Exclamation, "Advertencia")
            ComboBox1.Select()
            Return
        End If
        If Len(Trim(PreciocostoTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Costo Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PreciocostoTextBox.Select()
            Return
        End If
        If CDec(PreciocostoTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio Costo Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PreciocostoTextBox.Select()
            Return
        End If
        If Len(Trim(PrecioventaTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Venta Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventaTextBox.Select()
            Return
        End If
        If CDec(PrecioventaTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio de Venta Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventaTextBox.Select()
            Return
        End If
        If Len(Trim(PrecioventagranelTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Venta a granel Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventagranelTextBox.Select()
            Return
        End If
        If CDec(PrecioventagranelTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio de Venta a granel  Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventagranelTextBox.Select()
            Return
        End If
        If Len(Trim(PrecioventamayoristaTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Venta mayorista Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventamayoristaTextBox.Select()
            Return
        End If
        If CDec(PrecioventamayoristaTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio de Venta mayorista Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventamayoristaTextBox.Select()
            Return
        End If
        If Len(Trim(PrecioventadistribuidorTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Venta distribuidor Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventamayoristaTextBox.Select()
            Return
        End If
        If CDec(PrecioventadistribuidorTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio de Venta distribuidor Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventamayoristaTextBox.Select()
            Return
        End If
        If Len(ComboBox3.Text) = 0 Then
            MsgBox("Seleccione rubro del producto!", MsgBoxStyle.Exclamation, "Advertencia")
            ComboBox3.Select()
            Return
        End If
        '**********************************************
        If Not IvaComboBox.SelectedIndex >= 0 Then
            MsgBox("Ingrese un valor de IVA", MsgBoxStyle.Exclamation, "Advertencia")
            IvaComboBox.Select()
            res = False
            Return
        End If
        '**********************************************
        Dim CODERROR As Long = 0
        Dim MSGERROR As String = ""
        Try
            Me.ProductosBindingSource.EndEdit()
            If Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet) Then
                ComercialDataSet.AcceptChanges()
                '/*******************************************************************/
                '/*******************   insertar PROVEEDOR ***************************/
                '/*******************************************************************/
                If idproveedor > 0 Then
                    Try
                        AsignarProveedor(idproveedor)
                        SetProveedor()
                    Catch ex As Exception
                        MsgBox("Ocurrió un error al insertar el stock inicial: " + ex.Message)
                    End Try
                End If
                '/*******************************************************************/
                If gModuloClowd = 1 Then
                    PushProducto(codigoNUEVO, CODERROR, MSGERROR)
                    If CODERROR = 0 Then
                        Dim ProductosWEBTableAdapter As MySQLDataSetTableAdapters.productosTableAdapter
                        ProductosWEBTableAdapter = New MySQLDataSetTableAdapters.productosTableAdapter()
                        If codigoORIGINAL <> codigoNUEVO Then
                            ProductosWEBTableAdapter.productos_updateestado("N", codigoORIGINAL)
                        End If
                        MsgBox("Actualización correcta!", MsgBoxStyle.Information)
                    Else
                        MsgBox("No se pudo actualizar el producto en la nube -" + MSGERROR + "-", vbExclamation, "Advertencia")
                        ErrorLog.errorlog_insertar("ABMProductos", "Aplicacion", "PushProducto", MSGERROR)
                        If codigoORIGINAL <> codigoNUEVO Then
                            ErrorLog.errorlog_insertar("ABMProductos", "Aplicacion", "PushProducto", codigoORIGINAL + " / " + codigoNUEVO)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo actualizar el producto en la nube -" + MSGERROR + "-", vbExclamation, "Advertencia")
        End Try


        enableedit(False)
        stockinicialtextbox.Enabled = False
        enablefilter(True)
        FormPrincipal.reloadstock()
        '*************************
        editbtn.Visible = True
        BindingNavigatorAddNewItem.Visible = True
        ActualizaCantidad()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "C:\Users"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ImagenPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.UnidadesmedidaTableAdapter.FillBy(Me.ComercialDataSet.unidadesmedida)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.UnidadesmedidaTableAdapter.FillBy1(Me.ComercialDataSet.unidadesmedida)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextFiltro.TextChanged
        codigolimpio = TextFiltro.Text
        Try
            Select Case ComboBox2.Text
                Case "Código"
                    LimpiarCodigo(codigolimpio)
                    ProductosBindingSource.Filter = "codigoproducto like '%" + codigolimpio + "%'"
                Case "Marca"
                    LimpiarCodigo(codigolimpio)
                    ProductosBindingSource.Filter = "marca like '%" + codigolimpio + "%'"
                Case "Producto"
                    LimpiarCodigo(codigolimpio)
                    ProductosBindingSource.Filter = "modelo like '%" + codigolimpio + "%'"
                Case Else
                    TextFiltro.Text = ""
                    MsgBox("Seleccione un criterio de filtrado!", MsgBoxStyle.Exclamation, "Advertencia")
                    'ComboBox2.Select()
            End Select
            ActualizaCantidad()
        Catch ex As Exception
            MsgBox("Ocurrió un problema al leer el código de barras: " + ex.Message)
        End Try

        'TextFiltro.Select()
    End Sub



    Public Sub enableedit(ByVal status As Boolean)
        IdproductoTextBox.Enabled = True
        MarcaTextBox.Enabled = status
        ModeloTextBox.Enabled = status
        PresentacionTextBox.Enabled = status
        ComboBox1.Enabled = status
        MedidaTextBox.Enabled = status
        DescripcionTextBox.Enabled = status
        PreciocostoTextBox.Enabled = status
        cancelbtn.Visible = status
        ComboBox3.Enabled = status
        codigoproductoTextBox.Enabled = status
        stockminimotextbox.Enabled = status
        PrecioventaTextBox.Enabled = status
        ProductosBindingNavigatorSaveItem.Visible = status
        Button1.Enabled = status
        PictureBoxCalidacodigo.Enabled = status
        PrecioventagranelTextBox.Enabled = status
        PrecioventamayoristaTextBox.Enabled = status
        PrecioventadistribuidorTextBox.Enabled = status
        BPC1.Enabled = status
        BPC2.Enabled = status
        BPC3.Enabled = status
        BPC4.Enabled = status
        IvaComboBox.Enabled = status
        FabricanteTextBox.Enabled = status
        ComboProveedores.Enabled = status

    End Sub
    Public Sub enablefilter(ByVal status As Boolean)

        ComboBox2.Enabled = status
        TextFiltro.Enabled = status
        ProductosDataGridView.Enabled = status
        stockinicialtextbox.Text = Nothing
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editbtn.Click
        enableedit(True)
        enablefilter(False)
        ProductosBindingNavigatorSaveItem.Visible = True
        stockinicialtextbox.Text = Nothing
        '******************************************
        BindingNavigatorAddNewItem.Visible = False
        editbtn.Visible = False
        codigoORIGINAL = codigoproductoTextBox.Text

    End Sub

    Private Sub cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelbtn.Click
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        enableedit(False)
        stockinicialtextbox.Enabled = False
        enablefilter(True)
        ProductosBindingNavigatorSaveItem.Visible = False
        '************************************************
        editbtn.Visible = True
        BindingNavigatorAddNewItem.Visible = True
        GuardarNuevo.Visible = False
    End Sub

    Private Sub ProductosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub ProductosBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingSource.CurrentChanged

    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        enableedit(True)
        enablefilter(False)
        ProductosBindingNavigatorSaveItem.Visible = False
        GuardarNuevo.Visible = True
        stockinicialtextbox.Enabled = True
        codigoproductoTextBox.Select()
        '******************************************
        BindingNavigatorAddNewItem.Visible = False
        editbtn.Visible = False
        codigoproductoTextBox.Select()
        Return
    End Sub

    Private Sub codigoproductoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Return
    End Sub

    Private Sub stockminimotextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Return
    End Sub

    Private Sub PreciounitarioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreciocostoTextBox.TextChanged
        Return
    End Sub

    Private Sub PrecioventaTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrecioventaTextBox.LostFocus
        If IsNumeric(PrecioventaTextBox.Text) = False Then
            PrecioventaTextBox.Select()
        End If
    End Sub

    Private Sub PrecioventaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecioventaTextBox.TextChanged
        Return
    End Sub

    Private Sub stockminimotextbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles stockminimotextbox.LostFocus
        If IsNumeric(stockminimotextbox.Text) = False Then
            stockminimotextbox.Select()
        End If
    End Sub

    Private Sub stockminimotextbox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stockminimotextbox.TextChanged
        Return
    End Sub

    Private Sub PreciounitarioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PreciocostoTextBox.KeyPress
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

    Private Sub PrecioventaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioventaTextBox.KeyPress
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

    Private Sub stockminimotextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stockminimotextbox.KeyPress
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

    Private Sub codigoproductoTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles codigoproductoTextBox.TextChanged
        Return
    End Sub

    Private Sub codigoproductoTextBox_LostFocus(sender As Object, e As EventArgs) Handles codigoproductoTextBox.LostFocus
        Return
    End Sub

    Private Sub codigoproductoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles codigoproductoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim res As Boolean
            validacodigoproducto(res)
            If res = False Then
                Return
            End If
        End If
    End Sub

    Private Sub codigoproductoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codigoproductoTextBox.KeyPress
        Return
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxCalidacodigo.Click
        Dim res As Boolean
        validacodigoproducto(res)
        If res = False Then
            Return
        End If
    End Sub
    Public Sub validacodigoproducto(ByRef res As Boolean)
        codigoproductoTextBox.Text = LimpiarCodigo(codigoproductoTextBox.Text)
        '        MsgBox(codigoproductoTextBox.Text)
        '****************   primero valido el codigo
        If Len(Trim(codigoproductoTextBox.Text)) = 0 Then
            MsgBox("Ingrese un código de producto válido", MsgBoxStyle.Exclamation, "Advertencia")
            codigoproductoTextBox.Select()
            res = False
            Return
        End If
        '*********************************
        If Trim(codigoproductoTextBox.Text) = "0" Then
            MsgBox("Ingrese un código de producto válido", MsgBoxStyle.Exclamation, "Advertencia")
            codigoproductoTextBox.Select()
            res = False
            Return
        End If
        '*********************************
        If Val(IdproductoTextBox.Text) < 0 Then 'si el ID es menor a cero es un producto nuevo
            If ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text) > 0 Then
                MsgBox("El código de producto ya esta registrado!", MsgBoxStyle.Exclamation, "Advertencia nuevo producto")
                codigoproductoTextBox.Select()
                res = False
                Return
            Else
                codigoproductoTextBox.Enabled = False
            End If
        Else 'si el ID es MAYOR a cero esta editando un producto
            If ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text) > 0 Then
                If ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text) <> Val(IdproductoTextBox.Text) Then
                    MsgBox("El código de producto ya esta registrado!", MsgBoxStyle.Exclamation, "Advertencia modificación de producto")
                    codigoproductoTextBox.Select()
                    res = False
                    Return
                End If
            Else
                codigoproductoTextBox.Enabled = False
            End If
        End If

    End Sub

    Private Sub PrecioventagranelTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrecioventagranelTextBox.TextChanged
        Return
    End Sub

    Private Sub PrecioventagranelTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioventagranelTextBox.KeyPress
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

    Private Sub PrecioventamayoristaTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrecioventamayoristaTextBox.TextChanged
        Return
    End Sub

    Private Sub PrecioventamayoristaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioventamayoristaTextBox.KeyPress
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

    Private Sub MedidaTextBox_TextChanged(sender As Object, e As EventArgs) Handles MedidaTextBox.TextChanged

    End Sub

    Private Sub MedidaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MedidaTextBox.KeyPress
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BPC1.Click
        Dim preciocalculado As String = PrecioventaTextBox.Text
        calcularPrecioPC(preciocalculado)
        PrecioventaTextBox.Text = Convert.ToDecimal(preciocalculado)
    End Sub
    Private Sub calcularPrecioPC(ByRef preciocalculado As String)
        Dim original As String = preciocalculado
        Try
            gpreciocosto = PreciocostoTextBox.Text
            gpreciocalculado = Nothing
            If Not Convert.ToDecimal(gpreciocosto) > 0 Then
                MsgBox("Ingrese un precio de costo", MsgBoxStyle.Exclamation, "Advertencia")
                Return
            End If
            Dim p As CalculaMontoPC
            p = New CalculaMontoPC
            p.ShowDialog()
            'MsgBox(gpreciocalculado)
            If Convert.ToDecimal(gpreciocalculado) > 0 Then
                preciocalculado = gpreciocalculado
            Else
                preciocalculado = preciocalculado
            End If
            gpreciocalculado = Nothing
            gpreciocosto = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrecioventadistribuidorTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrecioventadistribuidorTextBox.TextChanged
        Return
    End Sub

    Private Sub PrecioventadistribuidorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioventadistribuidorTextBox.KeyPress
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

    Private Sub BPC2_Click(sender As Object, e As EventArgs) Handles BPC2.Click
        Try
            Dim preciocalculado As String = PrecioventagranelTextBox.Text
            calcularPrecioPC(preciocalculado)
            PrecioventagranelTextBox.Text = Convert.ToDecimal(preciocalculado)
        Catch ex As Exception
            MsgBox("Debe ingresar un monto válido")
        End Try

    End Sub

    Private Sub BPC3_Click(sender As Object, e As EventArgs) Handles BPC3.Click
        Try
            Dim preciocalculado As String = PrecioventamayoristaTextBox.Text
            calcularPrecioPC(preciocalculado)
            PrecioventamayoristaTextBox.Text = Convert.ToDecimal(preciocalculado)
        Catch ex As Exception
            MsgBox("Debe ingresar un monto válido")
        End Try

    End Sub

    Private Sub BPC4_Click(sender As Object, e As EventArgs) Handles BPC4.Click
        Try
            Dim preciocalculado As String = PrecioventadistribuidorTextBox.Text
            calcularPrecioPC(preciocalculado)
            PrecioventadistribuidorTextBox.Text = Convert.ToDecimal(preciocalculado)
        Catch ex As Exception
            MsgBox("Debe ingresar un monto válido")
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextFiltro.Select()
        TextFiltro.SelectAll()
    End Sub

    Private Sub stockinicialtextbox_TextChanged(sender As Object, e As EventArgs) Handles stockinicialtextbox.TextChanged

    End Sub

    Private Sub stockinicialtextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stockinicialtextbox.KeyPress
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
        Select Case ComboBox1.Text
            Case "Unidad Cerrada"
                MedidaTextBox.Text = "1"
                MedidaTextBox.Enabled = False
            Case Else
                If MarcaTextBox.Enabled = True Then
                    MedidaTextBox.Enabled = True
                End If
        End Select
    End Sub

    Private Sub GuardarNuevo_Click(sender As Object, e As EventArgs) Handles GuardarNuevo.Click
        Dim idproveedor As Long = 0
        If ComboProveedores.SelectedIndex >= 0 Then
            idproveedor = ComboProveedores.SelectedValue
        End If
        Me.Validate()
        '*************  VALIDAR DATOS CARGADOS ************
        '****************   primero valido el codigo
        Dim res As Boolean = True
        validacodigoproducto(res)
        If res = False Then
            Return
        End If
        codigoNUEVO = codigoproductoTextBox.Text
        '**********************************************
        If Len(Trim(MarcaTextBox.Text)) = 0 Then
            MsgBox("Ingrese la marca del producto", MsgBoxStyle.Exclamation, "Advertencia")
            MarcaTextBox.Select()
            Return
        End If
        If Len(Trim(ModeloTextBox.Text)) = 0 Then
            MsgBox("Ingrese modelo del producto", MsgBoxStyle.Exclamation, "Advertencia")
            ModeloTextBox.Select()
            Return
        End If
        If Len(Trim(PresentacionTextBox.Text)) = 0 Then
            MsgBox("Ingrese presentacion del producto", MsgBoxStyle.Exclamation, "Advertencia")
            PresentacionTextBox.Select()
            Return
        End If
        If Not Len(ComboBox1.Text) > 0 Then
            MsgBox("Seleccione unidad de medida!", MsgBoxStyle.Exclamation, "Advertencia")
            ComboBox1.Select()
            Return
        End If
        If MedidaTextBox.Text = Nothing Or Not Val(MedidaTextBox.Text) > 0 Then
            MsgBox("Indique valor de medida válido!", MsgBoxStyle.Exclamation, "Advertencia")
            ComboBox1.Select()
            Return
        End If
        If Len(Trim(PreciocostoTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Costo Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PreciocostoTextBox.Select()
            Return
        End If
        If CDec(PreciocostoTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio Costo Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PreciocostoTextBox.Select()
            Return
        End If
        If Len(Trim(PrecioventaTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Venta Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventaTextBox.Select()
            Return
        End If
        If CDec(PrecioventaTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio de Venta Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventaTextBox.Select()
            Return
        End If
        If Len(Trim(PrecioventagranelTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Venta a granel Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventagranelTextBox.Select()
            Return
        End If
        If CDec(PrecioventagranelTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio de Venta a granel  Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventagranelTextBox.Select()
            Return
        End If
        If Len(Trim(PrecioventamayoristaTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Venta mayorista Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventamayoristaTextBox.Select()
            Return
        End If
        If CDec(PrecioventamayoristaTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio de Venta mayorista Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventamayoristaTextBox.Select()
            Return
        End If
        If Len(Trim(PrecioventadistribuidorTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Precio Venta distribuidor Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventamayoristaTextBox.Select()
            Return
        End If
        If CDec(PrecioventadistribuidorTextBox.Text) <= 0 Then
            MsgBox("Ingrese un Precio de Venta distribuidor Válido!", MsgBoxStyle.Exclamation, "Advertencia")
            PrecioventamayoristaTextBox.Select()
            Return
        End If
        If Len(ComboBox3.Text) = 0 Then
            MsgBox("Seleccione rubro del producto!", MsgBoxStyle.Exclamation, "Advertencia")
            ComboBox3.Select()
            Return
        End If

        Try
            Me.ProductosBindingSource.EndEdit()
            If Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet) Then
                If gModuloClowd = 1 Then
                    Dim CODERROR As Long
                    Dim MSGERROR As String = ""
                    PushProducto(codigoNUEVO, CODERROR, MSGERROR)
                    If CODERROR > 0 Then
                        Throw New Exception("No se pudo actualizar el producto en la nube -" + MSGERROR + "-")
                    End If
                End If
                MsgBox("Actualización correcta!", MsgBoxStyle.Information, "Mensaje")
                Me.ComercialDataSet.AcceptChanges()
                ProductosTableAdapter.productos_estadoproducto("A", ProductosTableAdapter.productos_existeproducto(codigoNUEVO))
            End If
        Catch ex As Exception
            MsgBox("No se pudo completar la operación: " + ex.Message, vbExclamation)
            Return
        End Try

        '/*******************************************************************/
        '/*******************   insertar stock inicial ***************************/
        '/*******************************************************************/
        Try
            If Val(stockinicialtextbox.Text) > 0 Then
                Try
                    If Convert.ToDecimal(stockinicialtextbox.Text) > 0 Then
                        Dim idprod
                        idprod = ProductosTableAdapter.productos_existeproducto(codigoNUEVO)
                        If Not StockTableAdapter1.stock_insertarmovimiento(idprod, Convert.ToDecimal(stockinicialtextbox.Text), Today, guserid, "E", "Nvo. Producto Stock Inicial", 1) >= 0 Then
                            MsgBox("Ocurrioun error al insertar el stock inicial", MsgBoxStyle.Exclamation, "Advertencia")
                        End If
                        stockinicialtextbox.Text = Nothing
                        MsgBox("Producto agregado correctamente!", MsgBoxStyle.Information, "Mensaje")
                    End If
                Catch ex As Exception
                    MsgBox("Ocurrió un error al insertar el stock inicial: " + ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
        '/*******************************************************************/
        '/*******************   insertar PROVEEDOR ***************************/
        '/*******************************************************************/
        Try
            If idproveedor >= 0 Then
                Try
                    AsignarProveedor(idproveedor)
                Catch ex As Exception
                    MsgBox("Ocurrió un error al insertar el stock inicial: " + ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
        '/*******************************************************************/
        '/*******************************************************************/
        'enableedit(False)
        'stockinicialtextbox.Enabled = False
        'enablefilter(True)
        'FormPrincipal.reloadstock()
        ''*************************
        'editbtn.Visible = True
        'BindingNavigatorAddNewItem.Visible = True

        enableedit(False)
        stockinicialtextbox.Enabled = False
        enablefilter(True)
        FormPrincipal.reloadstock()
        '*************************
        editbtn.Visible = True
        BindingNavigatorAddNewItem.Visible = True
        GuardarNuevo.Visible = False
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        ActualizaCantidad()
    End Sub

    Private Sub TextFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles TextFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim res As Boolean
            TextFiltro.Text = LimpiarCodigo(TextFiltro.Text)

            If res = False Then
                Return
            End If
        End If
    End Sub

    Private Sub ABMProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub PrecioventagranelLabel_Click(sender As Object, e As EventArgs)
        If PrecioventagranelTextBox.Enabled = True Then
            PrecioventagranelTextBox.Text = PrecioventaTextBox.Text
            PrecioventagranelTextBox.Select()
        End If
    End Sub

    Private Sub PrecioventamayoristaLabel_Click(sender As Object, e As EventArgs)
        If PrecioventamayoristaTextBox.Enabled = True Then
            PrecioventamayoristaTextBox.Text = PrecioventaTextBox.Text
            PrecioventamayoristaTextBox.Select()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        If PrecioventadistribuidorTextBox.Enabled = True Then
            PrecioventadistribuidorTextBox.Text = PrecioventaTextBox.Text
            PrecioventadistribuidorTextBox.Select()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        ComboBox1.SelectedValue = 6
    End Sub

    Private Sub ProductosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            Try
                Dim idproducto As Long
                Dim fdsp As Long
                fdsp = ProductosDataGridView.FirstDisplayedScrollingRowIndex
                idproducto = ProductosTableAdapter.productos_existeproducto(ProductosDataGridView.Rows(e.RowIndex).Cells("codigoproducto").Value)
                Select Case ProductosDataGridView.Columns(e.ColumnIndex).Name
                    Case "estado"
                        If MessageBox.Show("Seguro desea cambiar la visibilidad del producto?", "Activar / Desactivar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            If IsDBNull(ProductosDataGridView.Rows(e.RowIndex).Cells("estado").Value) Then
                                ProductosTableAdapter.productos_estadoproducto("A", idproducto)
                                Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
                                ProductosDataGridView.FirstDisplayedScrollingRowIndex = fdsp
                                ProductosDataGridView.Rows(e.RowIndex).Selected = True
                                Return
                            End If
                            If ProductosDataGridView.Rows(e.RowIndex).Cells("estado").Value = "A" Then
                                ProductosTableAdapter.productos_estadoproducto("I", idproducto)
                            Else
                                ProductosTableAdapter.productos_estadoproducto("A", idproducto)
                            End If
                            Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
                            ProductosDataGridView.FirstDisplayedScrollingRowIndex = fdsp
                            ProductosDataGridView.Rows(e.RowIndex).Selected = True
                        End If
                    Case Else
                        'MsgBox("es cualquier otra")
                End Select
            Catch ex As Exception
                MessageBox.Show("No se pudo completar la operación: " + ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub ActivarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivarTodosToolStripMenuItem.Click
        Try
            Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString) 'gActiveSQLConnectionString
            myConn2.Open()

            'MsgBox(gActiveSQLConnectionString)
            Dim mycommand As New SqlCommand
            mycommand = New SqlCommand("Update productos set estado = 'A'", myConn2)
            mycommand.ExecuteNonQuery()
            myConn2.Dispose()

            Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        Catch ex As Exception
            MessageBox.Show("No se pudo completar la operación: " + ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub DesactivarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesactivarTodosToolStripMenuItem.Click
        Try
            Dim myConn2 As SqlConnection = New SqlConnection(gActiveSQLConnectionString) 'gActiveSQLConnectionString
            myConn2.Open()
            'MsgBox(gActiveSQLConnectionString)
            Dim mycommand As New SqlCommand
            mycommand = New SqlCommand("Update productos set estado = 'I'", myConn2)
            mycommand.ExecuteNonQuery()
            myConn2.Dispose()
            Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        Catch ex As Exception
            MessageBox.Show("No se pudo completar la operación: " + ex.Message, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ProductosDataGridView_BindingContextChanged(sender As Object, e As EventArgs) Handles ProductosDataGridView.BindingContextChanged

    End Sub

    Private Sub ProductosDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ProductosDataGridView.SelectionChanged
        SetProveedor()

    End Sub
    Private Sub SetProveedor()
        Try
            Dim idproveedor As Long
            idproveedor = ProductosTableAdapter.productos_getidproveedor(ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells("idproducto").Value)
            If idproveedor > 0 Then
                ComboProveedores.SelectedValue = idproveedor
            Else
                ComboProveedores.SelectedIndex = -1
            End If
        Catch ex As Exception
            ComboProveedores.SelectedIndex = -1
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AsignarProveedor(ByRef idproveedor As Long)
        Try
            gidproveedor = idproveedor
            Dim ProductosproveedoresTableAdapter As New comercialDataSetTableAdapters.productosproveedoresTableAdapter()
            Dim existe As Long
            existe = ProductosproveedoresTableAdapter.productosproveedores_existe(IdproductoTextBox.Text)
            If Not existe = 0 Then
                If MsgBox("Seguro desea actualizar este producto?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                    Try
                        If ProductosproveedoresTableAdapter.productosproveedores_update(gidproveedor, PreciocostoTextBox.Text, Nothing, Nothing, Nothing, Nothing, IdproductoTextBox.Text) Then
                            'MsgBox("Operación exitosa", MsgBoxStyle.Information, "Aviso")
                            'Me.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("No se pudo completar la acción: AsignarProveedor " + ex.Message)
                        Return
                    End Try
                End If
            Else
                'If MsgBox("Seguro desea vincular este producto?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                Try
                    If ProductosproveedoresTableAdapter.productosproveedores_insertar(IdproductoTextBox.Text, gidproveedor, PreciocostoTextBox.Text, Nothing, Nothing, Nothing, Nothing) Then
                        'MsgBox("Operación exitosa", MsgBoxStyle.Information, "Aviso")
                        'Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("No se pudo completar la acción: AsignarProveedor " + ex.Message)
                End Try
                'End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class