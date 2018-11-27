Public Class AsignacionIVAMasivo
    Dim idrubroseleccionado As Long
    Private Sub AsignacionIVAMasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipoiva' Puede moverla o quitarla según sea necesario.
        Me.TipoivaTableAdapter.Fill(Me.ComercialDataSet.tipoiva)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listarubros' Puede moverla o quitarla según sea necesario.
        Me.ListarubrosTableAdapter.Fill(Me.ComercialDataSet.listarubros)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFiltro.TextChanged
        Try
            ListarubrosBindingSource.Filter = "Descripción like '%" + TextBoxFiltro.Text + "%'"
        Catch ex As Exception
            ListarubrosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ListarubrosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListarubrosDataGridView.CellContentClick

    End Sub

    Private Sub ListarubrosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListarubrosDataGridView.CellClick
        Try
            'ProductosBindingSource.Filter = "idrubro = " + ListarubrosDataGridView.Rows(e.RowIndex).Cells("idrubro").Value.ToString
            Me.ProductosTableAdapter.FillByidrubro(Me.ComercialDataSet.productos, ListarubrosDataGridView.Rows(e.RowIndex).Cells("idrubro").Value)
            idrubroseleccionado = ListarubrosDataGridView.Rows(e.RowIndex).Cells("idrubro").Value
        Catch ex As Exception
            ProductosBindingSource.Filter = ""
            idrubroseleccionado = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Seguro desea aplicar el IVA seleccionado a la lista de productos?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            Try
                For i = 0 To ProductosDataGridView.RowCount - 1
                    ProductosTableAdapter.productos_updateIVA(CDec(ComboBoxIVA.Text), ProductosDataGridView.Rows(i).Cells("idproducto").Value)
                Next
                Me.ProductosTableAdapter.FillByidrubro(Me.ComercialDataSet.productos, idrubroseleccionado)
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class