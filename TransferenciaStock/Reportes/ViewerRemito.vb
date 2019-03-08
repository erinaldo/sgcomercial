Public Class ViewerRemito
    Private Sub ViewerRemito_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ViewerRemito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listaremitos' Puede moverla o quitarla según sea necesario.
        Me.listaremitosTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitos, gidremito)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listaremitosdetalle' Puede moverla o quitarla según sea necesario.
        Me.listaremitosdetalleTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitosdetalle, gidremito)

        Me.ReportViewer1.RefreshReport()

        'listaremitosBindingSource.Filter = "idremito = " + gidremito.ToString
        'listaremitosdetalleBindingSource.Filter = "idremito = " + gidremito.ToString

    End Sub
End Class