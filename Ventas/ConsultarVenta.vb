Public Class ConsultarVenta

    Private Sub ConsultarVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibroventasdetalleTableAdapter.FillByIdventa(Me.ComercialDataSet.libroventasdetalle, gidventa)
        Me.LibroventasTableAdapter.FillByIdventa(Me.ComercialDataSet.libroventas, gidventa)
        Me.PagosTableAdapter.FillByidventa(Me.ComercialDataSet.pagos, gidventa)

        calcular()

    End Sub

    Private Sub calcular()

        Dim total As Decimal = 0

        For i = 0 To LibroventasdetalleDataGridView.RowCount - 1
            total = total + LibroventasdetalleDataGridView.Rows(i).Cells("subtotal").Value
            'total = PagosDataGridView.Rows(0).Cells(3).Value7
        Next

        totaltextbox.Text = "$ " + total.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As ViewerFactura
        p = New ViewerFactura
        p.ShowDialog()
    End Sub

    Private Sub totaltextbox_TextChanged(sender As Object, e As EventArgs) Handles totaltextbox.TextChanged

    End Sub

    Private Sub totaltextbox_Click(sender As Object, e As EventArgs) Handles totaltextbox.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim p As VentaDetallePagosRealizados
        p = New VentaDetallePagosRealizados
        p.ShowDialog()
    End Sub
End Class