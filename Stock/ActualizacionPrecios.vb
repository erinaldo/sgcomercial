Imports System.Text.RegularExpressions
Public Class ActualizacionPrecios
    Dim marcaseleccionada As String
    Dim rubroseleccionado As String
    Private Sub ActualizacionPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listasprecios' Puede moverla o quitarla según sea necesario.
        Me.ListaspreciosTableAdapter.FillByEstado(Me.ComercialDataSet.listasprecios, 1)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.rubros' Puede moverla o quitarla según sea necesario.
        Me.RubrosTableAdapter.Fill(Me.ComercialDataSet.rubros)
        ''***************************
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Me.ListacriteriosactualizacionTableAdapter.Fill(Me.ComercialDataSet.listacriteriosactualizacion)
            Select Case ComboBox2.Text
                Case "Fabricante"
                    ListacriteriosactualizacionBindingSource.Filter = "criterio like'fabricante'"
                Case "Marca"
                    ListacriteriosactualizacionBindingSource.Filter = "criterio like'marca'"
                Case "Rubro"
                    ListacriteriosactualizacionBindingSource.Filter = "criterio like'rubro'"
                Case Else

            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''************* validar seleccion de marca o rubro
        If Len(Trim(marcaseleccionada)) = 0 Then
            MsgBox("Debe seleccionar una fabricante, marca o rubro", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Debe seleccionar un criterio de calculo", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        ''************* validar carga monto valor
        If Len(Trim(TextBox1.Text)) = 0 Then
            MsgBox("Debe ingresar un valor", MsgBoxStyle.Exclamation, "Advertencia")
            TextBox1.Select()
            Return
        End If
        ''*************** verifico operacion SUMA o RESTA
        Dim valor As Decimal
        Dim porcentaje As Decimal
        Dim operacion As String
        valor = Convert.ToDecimal(TextBox1.Text)
        porcentaje = Convert.ToDecimal(TextBox1.Text)
        If CheckBox1.Checked Then
            valor = valor * -1
            porcentaje = 1 - porcentaje / 100
            operacion = "descuento"
        Else
            operacion = "aumento"
            porcentaje = porcentaje / 100 + 1
        End If
        ''************* confirmar accion
        If MsgBox("Seguro desea aplicar a " + ComboBox2.Text + ": " + marcaseleccionada + " un " + operacion + " de precio en " + TextBox1.Text + " (" + ComboBox1.Text + ")" + "?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
            Return
        End If
        'MsgBox(ComboListaPrecios.SelectedValue.ToString)
        ''************* ejecutar acción
        Try
            Dim idlistaprecio = Val(ComboListaPrecios.SelectedValue)
            Select Case ComboBox2.Text
                Case "Marca"
                    Select Case ComboBox1.Text
                        Case "Monto fijo"
                            If Convert.ToDecimal(TextBox1.Text) > 0 Then
                                ProductosTableAdapter.productos_act_precios_marca_montofijo(valor, marcaseleccionada, idlistaprecio)
                            Else
                                MsgBox("valor incorrecto")
                            End If
                        Case "Porcentaje"
                            If Convert.ToDecimal(TextBox1.Text) > 0 Then
                                ProductosTableAdapter.productos_act_precios_marca_porcentaje(porcentaje, marcaseleccionada, idlistaprecio)
                            Else
                                MsgBox("valor incorrecto")
                            End If
                    End Select
                Case "Rubro"
                    Select Case ComboBox1.Text
                        Case "Monto fijo"
                            If Convert.ToDecimal(TextBox1.Text) > 0 Then
                                ProductosTableAdapter.productos_act_precios_rubro_montofijo(valor, RubrosTableAdapter.rubros_getidrubro(marcaseleccionada), idlistaprecio)
                            Else
                                MsgBox("valor incorrecto")
                            End If
                        Case "Porcentaje"
                            If Convert.ToDecimal(TextBox1.Text) > 0 Then
                                ProductosTableAdapter.productos_act_precios_rubro_porcentaje(porcentaje, RubrosTableAdapter.rubros_getidrubro(marcaseleccionada), idlistaprecio)
                            Else
                                MsgBox("valor incorrecto")
                            End If
                    End Select
                Case "Fabricante"
                    Select Case ComboBox1.Text
                        Case "Monto fijo"
                            If Convert.ToDecimal(TextBox1.Text) > 0 Then
                                ProductosTableAdapter.productos_act_precios_fabricante_montofijo(valor, marcaseleccionada, idlistaprecio)
                            Else
                                MsgBox("valor incorrecto")
                            End If
                        Case "Porcentaje"
                            If Convert.ToDecimal(TextBox1.Text) > 0 Then
                                ProductosTableAdapter.productos_act_precios_fabricante_porcentaje(porcentaje, marcaseleccionada, idlistaprecio)
                            Else
                                MsgBox("valor incorrecto")
                            End If
                    End Select
            End Select

            'Me.ListacriteriosactualizacionTableAdapter.Fill(Me.ComercialDataSet.listacriteriosactualizacion)
            Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
            '/********************************** VOLVER A FILTRAR LA OPCION QUE ESTABA ********************/
            'Select Case ComboBox2.Text
            '    Case "Fabricante"
            '        ListaproductosBindingSource.Filter = "fabricante like '%" + marcaseleccionada + "%'"
            '    Case "Marca"
            '        ListaproductosBindingSource.Filter = "marca like '%" + marcaseleccionada + "%'"
            '    Case "Rubro"
            '        ListaproductosBindingSource.Filter = "rubro like '%" + marcaseleccionada + "%'"
            'End Select
        Catch ex As Exception
            MsgBox("No se pudo completar la actualización: " + ex.Message)
        End Try


    End Sub

    Private Sub ListamarcasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Select Case ComboBox2.Text
                Case "Fabricante"
                    ListacriteriosactualizacionBindingSource.Filter = "criterio = 'fabricante' " + " and valor Like '%" + TextBox2.Text + "%'"
                Case "Marca"
                    ListacriteriosactualizacionBindingSource.Filter = "criterio = 'marca' " + " and valor Like '%" + TextBox2.Text + "%'"
                Case "Rubro"
                    ListacriteriosactualizacionBindingSource.Filter = "criterio = 'rubro' " + " and valor like '%" + TextBox2.Text + "%'"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListacriteriosactualizacionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListacriteriosactualizacionDataGridView.CellContentClick

    End Sub

    Private Sub ListacriteriosactualizacionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListacriteriosactualizacionDataGridView.CellClick
        Try
            Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
            Select Case ComboBox2.Text
                Case "Fabricante"
                    ListaproductosBindingSource.Filter = "fabricante like '%" + ListacriteriosactualizacionDataGridView.Rows(e.RowIndex).Cells("valor").Value + "%'"
                Case "Marca"
                    ListaproductosBindingSource.Filter = "marca like '%" + ListacriteriosactualizacionDataGridView.Rows(e.RowIndex).Cells("valor").Value + "%'"
                Case "Rubro"
                    ListaproductosBindingSource.Filter = "rubro like '%" + ListacriteriosactualizacionDataGridView.Rows(e.RowIndex).Cells("valor").Value + "%'"
            End Select
            marcaseleccionada = ListacriteriosactualizacionDataGridView.Rows(e.RowIndex).Cells("valor").Value
        Catch ex As Exception
            'MsgBox(ex.Message)
            ListaproductosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ActualizacionPrecios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
End Class