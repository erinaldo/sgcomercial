Public Class PresupuestosGenerados
    Private Sub PresupuestosGenerados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libropresupuestos' Puede moverla o quitarla según sea necesario.
        Me.LibropresupuestosTableAdapter.Fill(Me.ComercialDataSet.libropresupuestos)

    End Sub

    Private Sub LibropresupuestosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibropresupuestosDataGridView.CellContentClick

    End Sub

    Private Sub LibropresupuestosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibropresupuestosDataGridView.CellClick
        Select Case LibropresupuestosDataGridView.Columns(e.ColumnIndex).Name
            Case "ver"
                Dim p As ViewerPresupuestos
                p = New ViewerPresupuestos
                gidpresupuesto = LibropresupuestosDataGridView.Rows(e.RowIndex).Cells("idpresupuesto").Value
                p.ShowDialog()
                'Dim idpedidoweb As Long
                'idpedidoweb = LibropresupuestosDataGridView.pedidosdelivery_consultarIDPedidoWeb(gidpresupuesto)
        End Select
    End Sub
End Class