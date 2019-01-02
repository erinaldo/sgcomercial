Public Class DetalleEgresos
    Private Sub V_gastosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            'Dim i As Integer = 0
            'If V_gastosDataGridView.CurrentCell.ColumnIndex >= 0 Then
            '    Select Case V_gastosDataGridView.CurrentCell.ColumnIndex
            '        Case 4 '*****************ANULAR GASTO*****************************
            '            If MsgBox("Seguro desea anular la operación (Anular gasto)?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            '                CajasoperacionesTableAdapter.cajasoperaciones_bajaopgasto(V_gastosDataGridView.CurrentRow.Cells(1).Value, gusername)
            '                ''***************************** cargar datos
            '                Me.CajasmovimientosTableAdapter.Fill(Me.ComercialDataSet.cajasmovimientos)
            '                Me.V_gastosTableAdapter.Fill(Me.ComercialDataSet.v_gastos)
            '                ''***************************** filtrar ingresos y gastos
            '                CajasmovimientosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
            '                VgastosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
            '                calculartotales(CajaseventosDataGridView.CurrentRow.Cells(0).Value())
            '            End If
            '    End Select
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub V_gastosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DetalleEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.v_gastos' Puede moverla o quitarla según sea necesario.
        Me.V_gastosTableAdapter.Fill(Me.ComercialDataSet.v_gastos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.v_gastos' Puede moverla o quitarla según sea necesario.

        Me.V_gastosTableAdapter.FillByidevento(Me.ComercialDataSet.v_gastos, gideventoseleccionado)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class