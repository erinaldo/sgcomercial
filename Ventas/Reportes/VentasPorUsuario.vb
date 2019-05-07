Public Class VentasPorUsuario
    Private Sub VentasPorUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        'Me.libroventasTableAdapter.Fill(Me.comercialDataSet.libroventas)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1 As Date
        Dim date2 As Date
        Try
            date1 = Mid(DateTimePicker1.Value.ToString("dd/MM/yyyy"), 1, 10)
            date2 = Mid(DateTimePicker2.Value.ToString("dd/MM/yyyy"), 1, 10)
            libroventasTableAdapter.FillByRangoFechas(Me.comercialDataSet.libroventas, date1, date2)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Excepción: " + ex.Message)
        End Try

    End Sub
End Class