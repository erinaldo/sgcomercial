Imports System.Text.RegularExpressions
Public Class ActualizacionPrecios
    Dim marcaseleccionada As String
    Dim rubroseleccionado As String
    Private Sub ActualizacionPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.rubros' Puede moverla o quitarla según sea necesario.
        Me.RubrosTableAdapter.Fill(Me.ComercialDataSet.rubros)

        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        ListamarcasDataGridView.AutoGenerateColumns = True
        'this.dataGridView1.Columns.Clear();
        Me.ListarubrosTableAdapter.Fill(Me.ComercialDataSet.listarubros)
        Me.ListamarcasTableAdapter.Fill(Me.ComercialDataSet.listamarcas)
        '***************************
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ListamarcasDataGridView.Rows(0).Selected = False
        '***************************
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "marca"
                ListamarcasDataGridView.DataSource = ListamarcasBindingSource
            Case "Rubro"
                ListamarcasDataGridView.DataSource = ListarubrosBindingSource
                ListamarcasDataGridView.Refresh()
        End Select
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
        '************* validar seleccion de marca o rubro
        If Len(Trim(marcaseleccionada)) = 0 Then
            MsgBox("Debe seleccionar una marca o rubro", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        '************* validar carga monto valor
        If Len(Trim(TextBox1.Text)) = 0 Then
            MsgBox("Debe ingresar un valor", MsgBoxStyle.Exclamation, "Advertencia")
            TextBox1.Select()
            Return
        End If
        '*************** verifico operacion SUMA o RESTA
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
        '************* confirmar accion
        If MsgBox("Seguro desea aplicar a " + ComboBox2.Text + ": " + marcaseleccionada + " un " + operacion + " de precio en " + TextBox1.Text + " (" + ComboBox1.Text + ")" + "?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
            Return
        End If
        '************* ejecutar acción
        Select Case ComboBox2.Text
            Case "marca"
                Select Case ComboBox1.Text
                    Case "Monto fijo"
                        If Convert.ToDecimal(TextBox1.Text) > 0 Then
                            ProductosTableAdapter.productos_act_precioventa_marca_montofijo(valor, marcaseleccionada)
                        Else
                            MsgBox("valor incorrecto")
                        End If
                    Case "Porcentaje"
                        If Convert.ToDecimal(TextBox1.Text) > 0 Then
                            ProductosTableAdapter.productos_act_precioventa_marca_porcentaje(porcentaje, marcaseleccionada)
                        Else
                            MsgBox("valor incorrecto")
                        End If
                End Select
            Case "Rubro"
                Select Case ComboBox1.Text
                    Case "Monto fijo"
                        If Convert.ToDecimal(TextBox1.Text) > 0 Then
                            ProductosTableAdapter.productos_act_precioventa_rubro_montofijo(valor, RubrosTableAdapter.rubros_getidrubro(marcaseleccionada))
                        Else
                            MsgBox("valor incorrecto")
                        End If
                    Case "Porcentaje"
                        If Convert.ToDecimal(TextBox1.Text) > 0 Then
                            ProductosTableAdapter.productos_act_precioventa_rubro_porcentaje(porcentaje, RubrosTableAdapter.rubros_getidrubro(marcaseleccionada))
                        Else
                            MsgBox("valor incorrecto")
                        End If
                End Select
        End Select

        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)

    End Sub

    Private Sub ListamarcasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListamarcasDataGridView.CellContentClick

    End Sub

    Private Sub ListamarcasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListamarcasDataGridView.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            marcaseleccionada = Trim(ListamarcasDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value())

        Else
            ProductosBindingSource.Filter = ""
            Return
        End If

        Select Case ListamarcasDataGridView.Columns(0).DataPropertyName
            Case "Marca"
                Try
                    ProductosBindingSource.Filter = "trim(marca) like '%" + marcaseleccionada + "%'"
                    'MsgBox("marca like '%" + marcaseleccionada + "%'")
                Catch ex As Exception
                    ProductosBindingSource.Filter = ""
                End Try
            Case "Descripción"
                RubrosTableAdapter.rubros_getidrubro(marcaseleccionada)
                'MsgBox(marcaseleccionada)
                Try
                    ProductosBindingSource.Filter = "idrubro = " + RubrosTableAdapter.rubros_getidrubro(marcaseleccionada).ToString
                Catch ex As Exception
                    ProductosBindingSource.Filter = ""
                End Try
        End Select

    End Sub


End Class