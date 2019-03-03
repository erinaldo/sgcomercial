Public Class ViewerLibroVentasDetalladas
    Private Sub ViewerLibroVentasDetalladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libroventasdetalladas' Puede moverla o quitarla según sea necesario.
        'Me.libroventasdetalladasTableAdapter.Fill(Me.comercialDataSet.libroventasdetalladas)
        libroventasdetalladasBindingSource.Filter = ""
        Dim fecha As Date = gFechaSeleccionada
        Try
            Me.libroventasdetalladasTableAdapter.FillByFecha(Me.comercialDataSet.libroventasdetalladas, fecha.ToString)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se encontró el origen de datos: " + ex.Message)
        End Try


    End Sub

    Private Sub LibroDeHoyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroDeHoyToolStripMenuItem.Click
        libroventasdetalladasBindingSource.Filter = ""
        Try
            Dim fecha As Date = gFechaSeleccionada
            Me.libroventasdetalladasTableAdapter.FillByFecha(Me.comercialDataSet.libroventasdetalladas, fecha.ToString)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("No se encontró el origen de datos: " + ex.Message)
        End Try
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub PorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorUsuarioToolStripMenuItem.Click
        If Len(Trim(ToolStripTextBox1.Text)) > 0 Then
            Try
                libroventasdetalladasBindingSource.Filter = "usuariocarga like '%" + ToolStripTextBox1.Text.ToLower + "%'"
                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception
                libroventasdetalladasBindingSource.Filter = ""
                Me.ReportViewer1.RefreshReport()
            End Try
        Else
            libroventasdetalladasBindingSource.Filter = ""
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class