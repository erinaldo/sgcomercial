Public Class LibroVencimientosProductos
    Private Sub LibroVencimientosProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.librovencimientos' Puede moverla o quitarla según sea necesario.
        'Me.LibrovencimientosTableAdapter.Fill(Me.ComercialDataSet.librovencimientos)
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Select Case ComboBox1.Text
                Case "TODOS"
                    Me.LibrovencimientosTableAdapter.Fill(Me.ComercialDataSet.librovencimientos)
                Case "BUEN ESTADO"
                    Me.LibrovencimientosTableAdapter.FillByEstadoNumerico(Me.ComercialDataSet.librovencimientos, 0)
                Case "PRÓXIMO A VENCER"
                    Me.LibrovencimientosTableAdapter.FillByEstadoNumerico(Me.ComercialDataSet.librovencimientos, 1)
                Case "VENCIDOS"
                    Me.LibrovencimientosTableAdapter.FillByEstadoNumerico(Me.ComercialDataSet.librovencimientos, 2)
            End Select
            colorear()

        Catch ex As Exception
            MsgBox("No se pudo terminar la operación: " + ex.Message)
        End Try
    End Sub
    Public Sub colorear()
        Dim i As Integer
        For i = 0 To LibrovencimientosDataGridView.RowCount - 1
            Select Case LibrovencimientosDataGridView.Rows(i).Cells("estadonumerico").Value.ToString
                Case 0
                    LibrovencimientosDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                Case 1
                    LibrovencimientosDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                Case 2
                    LibrovencimientosDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightCoral
            End Select
        Next
        LibrovencimientosDataGridView.Refresh()
    End Sub
End Class