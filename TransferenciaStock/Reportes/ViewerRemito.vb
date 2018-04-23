Public Class ViewerRemito
    Private Sub ViewerRemito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listaremitos' Puede moverla o quitarla según sea necesario.
        Me.listaremitosTableAdapter.Fill(Me.comercialDataSet.listaremitos)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listaremitosdetalle' Puede moverla o quitarla según sea necesario.
        Me.listaremitosdetalleTableAdapter.Fill(Me.comercialDataSet.listaremitosdetalle)

        Me.ReportViewer1.RefreshReport()

        listaremitosBindingSource.Filter = "idremito = " + gidremito.ToString
        listaremitosdetalleBindingSource.Filter = "idremito = " + gidremito.ToString

    End Sub
End Class