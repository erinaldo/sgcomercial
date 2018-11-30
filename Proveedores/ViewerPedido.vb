Public Class ViewerPedido
    Private Sub ViewerPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.listapedidosreporteTableAdapter.FillByidpedido(Me.comercialDataSet.listapedidosreporte, gidpedido)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class