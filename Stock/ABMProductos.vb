Imports System.Text.RegularExpressions
Public Class ABMProductos

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IdproductoTextBox.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.rubros' Puede moverla o quitarla según sea necesario.
        Me.RubrosTableAdapter.Fill(Me.ComercialDataSet.rubros)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet1.unidadesmedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet1.unidadesmedida)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)

        enableedit(False)
        enablefilter(True)
        ComboBox2.SelectedIndex = 1
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        '*************  VALIDAR DATOS CARGADOS ************
        '****************   primero valido el codigo
        Dim res As Boolean = True
        validacodigoproducto(res)
        If res = False Then
            Return
        End If
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
        If Len(ComboBox1.Text) = 0 Then
            MsgBox("Seleccione unidad de medida!", MsgBoxStyle.Exclamation, "Advertencia")
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
        If Len(ComboBox3.Text) = 0 Then
            MsgBox("Seleccione rubro del producto!", MsgBoxStyle.Exclamation, "Advertencia")
            ComboBox3.Select()
            Return
        End If


        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
        enableedit(False)
        enablefilter(True)
        FormPrincipal.reloadstock()

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
        Select Case ComboBox2.Text
            Case "Código"
                ProductosBindingSource.Filter = "codigoproducto like '%" + TextFiltro.Text + "%'"
            Case "Marca"
                ProductosBindingSource.Filter = "marca like '%" + TextFiltro.Text + "%'"
            Case Else
                TextFiltro.Text = ""
                MsgBox("Seleccione un criterio de filtrado!", MsgBoxStyle.Exclamation, "Advertencia")
                ComboBox2.Select()
        End Select
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

    End Sub
    Public Sub enablefilter(ByVal status As Boolean)

        ComboBox2.Enabled = status
        TextFiltro.Enabled = status
        ProductosDataGridView.Enabled = status
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editbtn.Click
        enableedit(True)
        enablefilter(False)
        ProductosBindingNavigatorSaveItem.Visible = True

    End Sub

    Private Sub cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelbtn.Click
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        enableedit(False)
        enablefilter(True)
        ProductosBindingNavigatorSaveItem.Visible = False
    End Sub

    Private Sub ProductosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub ProductosBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingSource.CurrentChanged

    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        enableedit(True)
        enablefilter(False)
        ProductosBindingNavigatorSaveItem.Visible = True
        codigoproductoTextBox.Select()
    End Sub

    Private Sub codigoproductoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub stockminimotextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PreciounitarioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreciocostoTextBox.TextChanged

    End Sub

    Private Sub PrecioventaTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrecioventaTextBox.LostFocus
        If IsNumeric(PrecioventaTextBox.Text) = False Then
            PrecioventaTextBox.Select()
        End If
    End Sub

    Private Sub PrecioventaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecioventaTextBox.TextChanged

    End Sub

    Private Sub stockminimotextbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles stockminimotextbox.LostFocus
        If IsNumeric(stockminimotextbox.Text) = False Then
            stockminimotextbox.Select()
        End If
    End Sub

    Private Sub stockminimotextbox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stockminimotextbox.TextChanged

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

    End Sub

    Private Sub codigoproductoTextBox_LostFocus(sender As Object, e As EventArgs) Handles codigoproductoTextBox.LostFocus

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

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxCalidacodigo.Click
        Dim res As Boolean
        validacodigoproducto(res)
        If res = False Then
            Return
        End If
    End Sub
    Public Sub validacodigoproducto(ByRef res As Boolean)

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
        '**********************************************
    End Sub

    Private Sub PrecioventagranelTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrecioventagranelTextBox.TextChanged

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
End Class