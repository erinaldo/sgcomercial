Public Class ViewerListaProduccion
    Private Sub ViewerListaProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listaproduccion' Puede moverla o quitarla según sea necesario.
        Me.listaproduccionTableAdapter.Fill(Me.comercialDataSet.listaproduccion)




        Me.ReportViewer1.RefreshReport()
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "Todos"
                Me.listaproduccionTableAdapter.Fill(Me.comercialDataSet.listaproduccion)
                listaproduccionBindingSource.Filter = ""
            Case "Recibidos"
                Me.listaproduccionTableAdapter.Fill(Me.comercialDataSet.listaproduccion)
                listaproduccionBindingSource.Filter = "estado = 'RECIBIDO'"
            Case "En Proceso"
                listaproduccionBindingSource.Filter = "estado = 'ENPROCESO'"
        End Select
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class