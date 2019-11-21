Public Class DetalleIngresos
    Dim graficoampliado As Boolean
    Private Sub MovimientoscajasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DetalleIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstIngUltimoscierresTableAdapter.Fill(Me.ComercialDataSet.EstIngUltimoscierres)
        ReportViewer1.Refresh()
        ReportViewer1.RefreshReport()
        CajasmovimientosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajasmovimientos, gideventoseleccionado)
        Try
            Me.ingresosGraphTableAdapter.FillByidevento(Me.ComercialDataSet.ingresosGraph, gideventoseleccionado)
            'Me.ReportViewer1.RefreshReport()
            recuento()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CajasmovimientosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CajasmovimientosDataGridView.CellContentClick

    End Sub
    Private Sub recuento()
        Try
            Dim sum As Decimal
            For i = 0 To CajasmovimientosDataGridView.RowCount - 1
                sum = sum + CajasmovimientosDataGridView.Rows(i).Cells("monto").Value
            Next
            LabelTotal.Text = "TOTAL: " + sum.ToString
        Catch ex As Exception
            LabelTotal.Text = ""
        End Try

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
                        recuento()
                    End If
                Case "editar"
                    Dim p As New EditarVenta()
                    gidventa = CajasmovimientosDataGridView.CurrentRow.Cells("idventa").Value
                    p.ShowDialog()
                    CajasmovimientosTableAdapter.FillByIdevento(Me.ComercialDataSet.cajasmovimientos, gideventoseleccionado)
                    recuento()
            End Select
        End If
    End Sub

    Private Sub DetalleIngresos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If graficoampliado = False Then
            Dim si As New Drawing.Size
            si = New Size(1035, 406)
            ReportViewer1.Size = si
            ReportViewer1.Location = New Point(6, 28)
            graficoampliado = True
        Else
            Dim si As New Drawing.Size
            si = New Size(439, 406)
            ReportViewer1.Size = si
            ReportViewer1.Location = New Point(602, 28)
            graficoampliado = False
        End If
    End Sub
End Class