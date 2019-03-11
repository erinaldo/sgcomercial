Public Class ViewerLoteRendido
    Private Sub ViewerLoteRendido_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ViewerLoteRendido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.listalotesTableAdapter.FillByIDLote(Me.comercialDataSet.listalotes, gidlote)
        Me.listalotesdetalleTableAdapter.FillByIDloteenvio(Me.comercialDataSet.listalotesdetalle, gidlote)
        Me.ReportViewer1.RefreshReport()





    End Sub
End Class