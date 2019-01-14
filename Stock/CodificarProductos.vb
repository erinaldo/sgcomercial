Public Class CodificarProductos
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub CodificarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        RadioButton1.Checked = True
    End Sub

    Private Sub ProductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub ProductosDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellEndEdit
        If Len(Trim(ProductosDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString)) = 0 Then
            'MsgBox("No se permite codigo vacío!", MsgBoxStyle.Exclamation, "Advertencia!")
            'RadioButton1.Checked = True
            Return
        End If

        Try
            Dim existe As Integer
            Dim rtn As Integer
            existe = ProductosTableAdapter.productos_existeproducto(ProductosDataGridView.Rows(e.RowIndex).Cells(4).Value)
            If existe = 0 Then
                rtn = ProductosTableAdapter.productos_act_codigoproducto(ProductosDataGridView.Rows(e.RowIndex).Cells(4).Value, ProductosDataGridView.Rows(e.RowIndex).Cells(0).Value)
                If rtn > 0 Then
                    'MsgBox("Actualizado exitosamente")
                    'RadioButton1.Checked = True
                Else
                    MsgBox("No se pudo actualizar!")
                End If
            Else
                MsgBox("El codigo ya esta registrado!")
                ProductosDataGridView.Rows(e.RowIndex).Cells(4).Value = Nothing
            End If
            ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells(4).Selected = True
        Catch ex As Exception
            MsgBox(ex.Message)
            RadioButton1.Checked = True
        End Try


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.ProductosTableAdapter.FillBySinCodificar(Me.ComercialDataSet.productos)
        TextBox1.Text = Nothing
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.ProductosTableAdapter.FillByCodificados(Me.ComercialDataSet.productos)
        TextBox1.Text = Nothing
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        TextBox1.Text = Nothing
    End Sub

    Private Sub ProductosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells(4).Selected = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            ProductosBindingSource.Filter = " marca + modelo + presentacion like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            MsgBox("No se pudo realizar el filtrado")
            ProductosBindingSource.Filter = ""
        End Try

    End Sub

    Private Sub CodificarProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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