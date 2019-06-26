Public Class ConsultaStockRemotoProducto
    Private Sub StockgeneralBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConsultaStockRemotoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.ComercialDataSet.sucursales)
        'TODO: esta línea de código carga datos en la tabla 'MySQLDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
        Me.StockgeneralTableAdapter.FillBycodigoproducto(Me.MySQLDataSet.stockgeneral, gcodigoproducto)
        Dim ProductosTableAdapter As New comercialDataSetTableAdapters.productosTableAdapter

        Dim nombre As String
        Dim unidadmedida As String
        For i = 0 To StockgeneralDataGridView.RowCount - 1
            nombre = SucursalesTableAdapter.sucursales_consultanombre(StockgeneralDataGridView.Rows(i).Cells(0).Value)
            unidadmedida = ProductosTableAdapter.productos_consultarunidadmedidadescripcion(StockgeneralDataGridView.Rows(i).Cells("codigoproducto").Value)
            StockgeneralDataGridView.Rows(i).Cells("NombreSucursal").Value = nombre
            StockgeneralDataGridView.Rows(i).Cells("medida").Value = unidadmedida
        Next

    End Sub
End Class