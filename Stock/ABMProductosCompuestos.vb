Imports System.Text.RegularExpressions
Public Class ABMProductosCompuestos
    Private Sub ABMProductosCompuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listacomponentes' Puede moverla o quitarla según sea necesario.
        Me.ListacomponentesTableAdapter.Fill(Me.ComercialDataSet.listacomponentes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productoscomponentes' Puede moverla o quitarla según sea necesario.
        Me.ProductoscomponentesTableAdapter.Fill(Me.ComercialDataSet.productoscomponentes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaproductos' Puede moverla o quitarla según sea necesario.
        Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
        codigoproductoTextBox.Select()
        ListaproductosBindingSource.Filter = "codigoproducto = '0'"
        ListacomponentesBindingSource.Filter = "idproducto = '0'"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        buscaproductomanual()
        If gcodigoproducto = 0 Then Return
        codigoproductoTextBox.Text = gcodigoproducto
    End Sub
    Private Sub buscaproductomanual()
        gcodigoproducto = 0
        Dim p As BuscaCodigoProductoManual
        p = New BuscaCodigoProductoManual
        p.ShowDialog()
    End Sub

    Private Sub codigoproductoTextBox_TextChanged(sender As Object, e As EventArgs) Handles codigoproductoTextBox.TextChanged
        If Len(Trim(codigoproductoTextBox.Text)) = 0 Then
            ListaproductosBindingSource.Filter = "codigoproducto = '0'"
            ListacomponentesBindingSource.Filter = "idproducto = '0'"
            Return
        End If

        Try
            ListaproductosBindingSource.Filter = "codigoproducto = '" + codigoproductoTextBox.Text + "'"
            ListacomponentesBindingSource.Filter = "idproducto =  " + ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text).ToString
        Catch ex As Exception
            ListaproductosBindingSource.Filter = "codigoproducto = '0'"
        End Try

    End Sub

    Private Sub ListaproductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        gcodigoproducto = Nothing
        gproductodescripcion = Nothing
        buscaproductomanual()
        If gcodigoproducto = 0 Then Return
        CodigocomponenteTextBox.Text = gcodigoproducto
        LabelDescripcion.Text = "Descripcion: " + gproductodescripcion
    End Sub

    Private Sub CodigocomponenteTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodigocomponenteTextBox.TextChanged
        If Len(Trim(CodigocomponenteTextBox.Text)) = 0 Then
            'ListaproductosBindingSource.Filter = "codigoproducto = '0'"
            ListacomponentesBindingSource.Filter = "idproducto = '0'"
            Return
        End If

        Try
            LabelDescripcion.Text = "Descripcion: " + ProductosTableAdapter.productos_consultardescripcion(CodigocomponenteTextBox.Text)
        Catch ex As Exception
            LabelDescripcion.Text = ""
        End Try
    End Sub

    Private Sub AgregarComponenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarComponenteToolStripMenuItem.Click

        Dim idproducto As Integer = 0
        Dim idcomponente As Integer = 0

        ' validar producto compuesto
        idproducto = ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text)
        If idproducto = 0 Then
            MsgBox("Producto incorrecto", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        ' validar producto componente
        idcomponente = ProductosTableAdapter.productos_existeproducto(CodigocomponenteTextBox.Text)
        If idcomponente = 0 Or Trim(CodigocomponenteTextBox.Text) = Trim(codigoproductoTextBox.Text) Then
            MsgBox("Componente incorrecto", MsgBoxStyle.Exclamation, "Advertencia")
            CodigocomponenteTextBox.Select()
            Return
        End If
        ' validar cantidad
        If IsNumeric(CantidadTextBox.Text) = False Or Convert.ToDecimal(CantidadTextBox.Text) = 0 Then
            MsgBox("Ingrese cantidad", MsgBoxStyle.Exclamation, "Advertencia")
            CantidadTextBox.Select()
            Return
        End If
        ''''************************ pregunta
        If MsgBox("Seguro desea agregar este componente?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then Return
        If ProductoscomponentesTableAdapter.productoscomponentes_insertarcomponente(idproducto, idcomponente, Convert.ToDecimal(CantidadTextBox.Text)) > 0 Then
            'MsgBox("Componente agregado exitosamente!", MsgBoxStyle.Information, "Aviso")
            Me.ListacomponentesTableAdapter.Fill(Me.ComercialDataSet.listacomponentes)
            Try
                LabelDescripcion.Text = ProductosTableAdapter.productos_consultardescripcion(CodigocomponenteTextBox.Text)
            Catch ex As Exception
                LabelDescripcion.Text = ""
            End Try
        Else
            MsgBox("Error al agregar componente!", MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub CantidadTextBox_TextChanged(sender As Object, e As EventArgs) Handles CantidadTextBox.TextChanged

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

    Private Sub ListacomponentesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListacomponentesDataGridView.CellContentClick

    End Sub

    Private Sub ListacomponentesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListacomponentesDataGridView.CellClick
        Select Case e.ColumnIndex
            Case 4
                If MsgBox("Seguro desea eliminar el componente?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                    ProductoscomponentesTableAdapter.productoscomponentes_eliminarcomponente(ListacomponentesDataGridView.Rows(e.RowIndex).Cells(0).Value, ListacomponentesDataGridView.Rows(e.RowIndex).Cells(1).Value)
                    Me.ListacomponentesTableAdapter.Fill(Me.ComercialDataSet.listacomponentes)

                    CodigocomponenteTextBox.Text = ""
                    CantidadTextBox.Text = ""
                    LabelDescripcion.Text = ""

                    ListacomponentesBindingSource.Filter = "idproducto = " + ProductosTableAdapter.productos_existeproducto(codigoproductoTextBox.Text).ToString
                End If
            Case Else
                'MsgBox("ninguna columna")
                CodigocomponenteTextBox.Text = ListacomponentesDataGridView.Rows(e.RowIndex).Cells(1).Value
                CantidadTextBox.Text = ListacomponentesDataGridView.Rows(e.RowIndex).Cells(3).Value
        End Select




    End Sub
End Class