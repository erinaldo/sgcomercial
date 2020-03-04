Public Class DetalleExtracciones
    Private Sub DetalleExtracciones_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub DetalleExtracciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroextracciones' Puede moverla o quitarla según sea necesario.
        Try
            Me.LibroextraccionesTableAdapter.FillByIDEvento(Me.ComercialDataSet.libroextracciones, gideventoseleccionado)
            NumericTotal.Value = Me.LibroextraccionesTableAdapter.libroextracciones_montototalbyidevento(gideventoseleccionado)
        Catch ex As Exception
            MsgExPopUp("No se pudo cargar el listado de extracciones")
        End Try

    End Sub
End Class