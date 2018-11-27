Public Class ViewerFactura
    Private Sub ViewerFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        'Me.libroventasTableAdapter.Fill(Me.comercialDataSet.libroventas)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libroventasdetalle' Puede moverla o quitarla según sea necesario.
        'Me.libroventasdetalleTableAdapter.Fill(Me.comercialDataSet.libroventasdetalle)

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        If libroventasTableAdapter.libroventas_consultar_tipocomprobante(gidventa) = "Factura A" Then
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFacturaIVA.rdlc"
            Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Else
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFactura.rdlc"
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class