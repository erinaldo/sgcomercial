Public Class DetalleIngresos
    Private Sub MovimientoscajasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DetalleIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CajasmovimientosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajasmovimientos, gideventoseleccionado)
        Try
            Me.ingresosGraphTableAdapter.FillByidevento(Me.ComercialDataSet.ingresosGraph, gideventoseleccionado)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CajasmovimientosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CajasmovimientosDataGridView.CellContentClick

    End Sub

    Private Sub CajasmovimientosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CajasmovimientosDataGridView.CellClick

        If CajasmovimientosDataGridView.CurrentRow.Cells("nombre").Value = "Cambio Dif. (+)" Then Return
        Dim i As Integer = 0
        If CajasmovimientosDataGridView.CurrentCell.ColumnIndex >= 0 Then
            Select Case CajasmovimientosDataGridView.Columns(e.ColumnIndex).Name
                Case "idventa"
                    Dim p As ConsultarVenta
                    p = New ConsultarVenta
                    gidoperacion = CajasmovimientosDataGridView.CurrentRow.Cells("idoperacion").Value
                    gidventa = CajasoperacionesTableAdapter.cajasoperaciones_consultaridventa(gidoperacion)
                    p.ShowDialog()
                Case "nombre"
                    Dim p As ConsultarVenta
                    p = New ConsultarVenta
                    gidoperacion = CajasmovimientosDataGridView.CurrentRow.Cells("idoperacion").Value
                    gidventa = CajasoperacionesTableAdapter.cajasoperaciones_consultaridventa(gidoperacion)
                    p.ShowDialog()
                Case "anular"
                    If MsgBox("Seguro desea anular la operación?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                        If MsgBox("Esta operacion anulará la venta y todos sus comprobantes de pago asociados. Desea continuar?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                            CajasoperacionesTableAdapter.cajasoperaciones_bajaoperacionventa(CajasmovimientosDataGridView.CurrentRow.Cells("idoperacion").Value, gusername)
                            CajasmovimientosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajasmovimientos, gideventoseleccionado)
                        Else
                            MsgBox("Operacion cancelada")
                        End If
                    End If
            End Select
        End If
    End Sub
End Class