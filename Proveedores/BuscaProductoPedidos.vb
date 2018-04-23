Imports System.Text.RegularExpressions
Public Class BuscaProductoPedidos
    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub BuscaProductoManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaproductos' Puede moverla o quitarla según sea necesario.
        Me.ListaproductosTableAdapter.FillByProductosNoCompuestos(Me.ComercialDataSet.listaproductos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'ProductosDataGridView.Rows(0).Selected = False

        ComboBox1.SelectedIndex = 1
        TextBox1.Select()


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
                    gpreciocosto = ProductosTableAdapter.productos_consultarpreciocosto(gcodigoproducto)
                    precioventatextbox.Text = gpreciocosto
                    gproductodescripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
                    ProductosDataGridView.Rows(0).Selected = True
                    'cantidadtextbox.Select()
                Else
                    gcodigoproducto = Nothing
                    gpreciocosto = Nothing
                    precioventatextbox.Text = Nothing
                    gproductodescripcion = Nothing
                    'ProductosDataGridView.Rows(0).Selected = False
                End If
            Case "Descripción"
                ListaproductosBindingSource.Filter = "descripcion like'%" + TextBox1.Text + "%'"
                'If ProductosDataGridView.RowCount = 0 Then
                '    ProductosDataGridView.Rows(0).Selected = False
                'End If

                If ProductosDataGridView.RowCount = 1 Then
                    gcodigoproducto = ProductosDataGridView.CurrentRow.Cells(0).Value
                    gpreciocosto = ProductosTableAdapter.productos_consultarpreciocosto(gcodigoproducto)
                    precioventatextbox.Text = gpreciocosto
                    gproductodescripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
                    ProductosDataGridView.Rows(0).Selected = True
                    'cantidadtextbox.Select()
                Else
                    gcodigoproducto = Nothing
                    gpreciocosto = Nothing
                    precioventatextbox.Text = Nothing
                    gproductodescripcion = Nothing
                    'ProductosDataGridView.Rows(0).Selected = False
                End If
        End Select

    End Sub

    Private Sub ProductosDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        gcodigoproducto = ProductosDataGridView.CurrentRow.Cells(0).Value
        gpreciocosto = ProductosTableAdapter.productos_consultarpreciocosto(gcodigoproducto)
        precioventatextbox.Text = gpreciocosto
        gproductodescripcion = ProductosTableAdapter.productos_consultardescripcion(gcodigoproducto)
        recalcular()
        cantidadtextbox.Select()
        cantidadtextbox.SelectionStart = 0
        cantidadtextbox.SelectionLength = cantidadtextbox.Text.Length


    End Sub

    Private Sub ProductosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub cantidadtextbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cantidadtextbox.KeyDown
        If Len(Trim(cantidadtextbox.Text)) = 0 Then Return

        If IsNumeric(cantidadtextbox.Text) = False Then
            e.Handled = False
            Return
        End If
        If e.KeyCode = Keys.Enter Then
            gcantidad = cantidadtextbox.Text
            gcantidad = Decimal.Round(gcantidad, 3)
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
            Dim precioventa As Decimal = gpreciocosto
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
            gmontototal = Convert.ToDecimal(montotextbox.Text)
            gcantidad = gmontototal / gpreciocosto
            gcantidad = Decimal.Round(gcantidad, 3)
            cantidadtextbox.Text = gcantidad
        End If
    End Sub

    Private Sub montotextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles montotextbox.KeyDown
        If Len(Trim(montotextbox.Text)) = 0 Then Return
        If e.KeyCode = Keys.Enter Then
            gcantidad = cantidadtextbox.Text
            gcantidad = Decimal.Round(gcantidad, 3)
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

    Private Sub ProductosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub precioventatextbox_TextChanged(sender As Object, e As EventArgs) Handles precioventatextbox.TextChanged


    End Sub
    Private Sub recalcular()
        'MsgBox("Recalculando")
        If Len(Trim(cantidadtextbox.Text)) = 0 Then
            montotextbox.Text = Nothing
            cantidadtextbox.Text = Nothing
            Return
        End If
        If IsNumeric(cantidadtextbox.Text) = False Then
            montotextbox.Text = Nothing
            cantidadtextbox.Text = Nothing
            Return
        End If
        'If cantidadtextbox.Focused Then
        gcantidad = Convert.ToDecimal(cantidadtextbox.Text)
        Dim montototal As Decimal
        Dim precioventa As Decimal = gpreciocosto
        montototal = gcantidad * precioventa
        montototal = Decimal.Round(montototal, 2)
        montotextbox.Text = montototal.ToString
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ABMProductos.ShowDialog()
        Me.ListaproductosTableAdapter.FillByProductosNoCompuestos(Me.ComercialDataSet.listaproductos)
    End Sub
End Class