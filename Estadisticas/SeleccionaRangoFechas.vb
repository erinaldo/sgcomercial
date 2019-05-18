Public Class SeleccionaRangoFechas
    Private Sub SeleccionaRangoFechas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                gFechaDesde = Nothing
                gFechaHasta = Nothing
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            gFechaDesde = DateTimePicker1.Value
            gFechaHasta = DateTimePicker2.Value
            Me.Close()
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub SeleccionaRangoFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class