Public Class ViewerRecibo
    Private Sub ViewerRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listapagos' Puede moverla o quitarla según sea necesario.
            Me.listapagosTableAdapter.FillByIDPagos(Me.comercialDataSet.listapagos, gidpago)
            'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
            Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Excepción: " + ex.Message)
            Me.Close()
        End Try

    End Sub
End Class