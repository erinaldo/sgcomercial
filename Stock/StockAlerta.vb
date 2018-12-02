
Public Class StockAlerta
    Public filtro As String
    Private Sub StockAlerta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxFiltro.SelectedIndex = 1
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.ComercialDataSet.productos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.productoscomponentes' Puede moverla o quitarla según sea necesario.
        'Me.ProductoscomponentesTableAdapter.Fill(Me.ComercialDataSet.productoscomponentes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stockalerta' Puede moverla o quitarla según sea necesario.
        Me.StockalertaTableAdapter.Fill(Me.ComercialDataSet.stockalerta)
        'filtro = "producto"

    End Sub
    Public Sub reloadstock()
        Me.StockalertaTableAdapter.Fill(Me.ComercialDataSet.stockalerta)
    End Sub

    Private Sub StockalertaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockalertaDataGridView.CellClick
        filtro = StockalertaDataGridView.Columns(StockalertaDataGridView.CurrentCell.ColumnIndex).DataPropertyName
        LabelFiltro.Text = "Filtrar por " + " " + StockalertaDataGridView.Columns(StockalertaDataGridView.CurrentCell.ColumnIndex).HeaderText + ": "
        'MsgBox(StockalertaDataGridView.Columns(StockalertaDataGridView.CurrentCell.ColumnIndex).DataPropertyName, MsgBoxStyle.Information, "hola")

        Select Case StockalertaDataGridView.Columns(StockalertaDataGridView.CurrentCell.ColumnIndex).DataPropertyName
            Case "codigoproducto"
                Try
                    If ProductoscomponentesTableAdapter.productoscomponentes_esproductocompuesto(ProductosTableAdapter.productos_existeproducto(StockalertaDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value())) > 0 Then
                        MsgBox("No se puede cargar stock de productos compuestos! debe cargar stock de sus componentes", MsgBoxStyle.Exclamation, "Advertencia")
                        Return
                    End If

                    Dim p As ingresoegresoproductos
                    p = New ingresoegresoproductos
                    p.codigoproductoTextBox.Text = StockalertaDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value().ToString
                    p.Labeldescripcion.Text = p.ProductosTableAdapter.productos_consultardescripcion(p.codigoproductoTextBox.Text)
                    p.CantidadTextBox.Select()
                    'gcodigoproducto = StockalertaDataGridView.Rows(e.RowIndex).Cells(0).Value()
                    'p.setcodigoproducto()
                    p.ShowDialog()
                Catch ex As Exception

                End Try

        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(Trim(TextBox1.Text)) = 0 Then
            StockalertaBindingSource.Filter = ""
            Return
        End If
        Select Case ComboBoxFiltro.Text
            Case "Código"
                Try
                    StockalertaBindingSource.Filter = "codigoproducto" + " like '%" + TextBox1.Text + "%'"
                Catch ex As Exception

                End Try
            Case "Producto"
                Try
                    StockalertaBindingSource.Filter = "producto" + " like '%" + TextBox1.Text + "%'"
                Catch ex As Exception

                End Try
            Case Else
                StockalertaBindingSource.Filter = ""
        End Select

    End Sub

    Private Sub StockAlerta_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadstock()
    End Sub

    Private Sub ComboBoxFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFiltro.SelectedIndexChanged
        TextBox1.Select()

    End Sub
End Class