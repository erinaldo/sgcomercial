Public Class ViewerLibroVentasDetalladas
    Private Sub ViewerLibroVentasDetalladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libroventasdetalladas' Puede moverla o quitarla según sea necesario.
        'Me.libroventasdetalladasTableAdapter.Fill(Me.comercialDataSet.libroventasdetalladas)

        Dim fecha As Date = gFechaSeleccionada
        Try
            Me.libroventasdetalladasTableAdapter.FillByFecha(Me.comercialDataSet.libroventasdetalladas, fecha.ToString)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se encontró el origen de datos: " + ex.Message)
        End Try


    End Sub
End Class