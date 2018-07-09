Public Class ViewerComanda
    Private Sub ViewerComanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listapedidosdelivery' Puede moverla o quitarla según sea necesario.
        Me.listapedidosdeliveryTableAdapter.Fill(Me.comercialDataSet.listapedidosdelivery)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listapedidosdeliverydetalle' Puede moverla o quitarla según sea necesario.
        Me.listapedidosdeliverydetalleTableAdapter.Fill(Me.comercialDataSet.listapedidosdeliverydetalle)

        Me.ReportViewer1.RefreshReport()


        listapedidosdeliveryBindingSource.Filter = "idpedidodelivery =" + gidpedidodelivery.ToString
        listapedidosdeliverydetalleBindingSource.Filter = "idpedidodelivery =" + gidpedidodelivery.ToString
        Me.ReportViewer1.RefreshReport()



    End Sub
End Class