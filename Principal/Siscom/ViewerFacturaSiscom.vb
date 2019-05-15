Public Class ViewerFacturaSiscom
    Private Sub ViewerFacturaSiscom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'siscomDataSet.libroventas' Puede moverla o quitarla según sea necesario.
            Me.libroventasTableAdapter.FillByIDVenta(Me.siscomDataSet.libroventas, gidventaSC)
            'TODO: esta línea de código carga datos en la tabla 'siscomDataSet.libroventasdetalle' Puede moverla o quitarla según sea necesario.
            Me.libroventasdetalleTableAdapter.FillByIDVenta(Me.siscomDataSet.libroventasdetalle, gidventaSC)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Ocurrio una excepción al consultar los datos: " + ex.Message)
        End Try

    End Sub
End Class