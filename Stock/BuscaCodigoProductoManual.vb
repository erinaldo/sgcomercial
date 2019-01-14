Public Class BuscaCodigoProductoManual
    Private Sub BuscaCodigoProductoManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaproductos' Puede moverla o quitarla según sea necesario.
        Me.ListaproductosTableAdapter.Fill(Me.ComercialDataSet.listaproductos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        ComboBox1.SelectedIndex = 1
        TextBoxfiltro.Select()
    End Sub

    Private Sub TextBoxfiltro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfiltro.TextChanged
        Select Case ComboBox1.Text
            Case "Código"
                Try
                    ListaproductosBindingSource.Filter = "codigoproducto like '%" + TextBoxfiltro.Text + "%'"
                Catch ex As Exception
                    ListaproductosBindingSource.Filter = ""
                End Try
            Case "Descripción"
                Try
                    ListaproductosBindingSource.Filter = "descripcion like '%" + TextBoxfiltro.Text + "%'"
                Catch ex As Exception
                    ListaproductosBindingSource.Filter = ""
                End Try
        End Select


    End Sub

    Private Sub ProductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub ProductosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick

    End Sub

    Private Sub ProductosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellDoubleClick
        gcodigoproducto = ProductosDataGridView.Rows(e.RowIndex).Cells(0).Value
        gproductodescripcion = ProductosDataGridView.Rows(e.RowIndex).Cells(1).Value
        Me.Close()
    End Sub

    Private Sub TextBoxfiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxfiltro.KeyPress

    End Sub

    Private Sub TextBoxfiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxfiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ProductosDataGridView.RowCount = 1 Then
                gcodigoproducto = ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells(0).Value
                gproductodescripcion = ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells(1).Value
                Me.Close()
            Else
                ProductosDataGridView.Select()
            End If

        End If
    End Sub

    Private Sub ProductosDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductosDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            'CallClick()
            gcodigoproducto = ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells(0).Value
            gproductodescripcion = ProductosDataGridView.Rows(ProductosDataGridView.CurrentRow.Index).Cells(1).Value
            Me.Close()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BuscaCodigoProductoManual_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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