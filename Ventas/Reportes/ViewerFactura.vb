Public Class ViewerFactura
    Private Sub ViewerFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera80.rdlc"
        Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub HojaA4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HojaA4ToolStripMenuItem.Click
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

    Private Sub Comanda80mmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Comanda80mmToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera80.rdlc"
        Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Comanda58mmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Comanda58mmToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera58.rdlc"
        Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Me.ReportViewer1.RefreshReport()


    End Sub
End Class