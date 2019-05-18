Public Class ViewerPedido
    Private Sub ViewerPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.listapedidosreporteTableAdapter.FillByidpedido(Me.comercialDataSet.listapedidosreporte, gidpedido)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DetalladoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalladoToolStripMenuItem.Click

        ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportPedido.rdlc"
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.listapedidosreporteTableAdapter.FillByidpedido(Me.comercialDataSet.listapedidosreporte, gidpedido)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SoloCantidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoloCantidadesToolStripMenuItem.Click

        ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportPedidoCantidades.rdlc"

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.listapedidosreporteTableAdapter.FillByidpedido(Me.comercialDataSet.listapedidosreporte, gidpedido)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class