Public Class DetalleDepositosCaja
    Private Sub DetalleDepositosCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub DetalleDepositosCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        Try
            Me.LibrodepositosTableAdapter.FillByIDEvento(Me.ComercialDataSet.librodepositos, gideventoseleccionado)
            NumericTotal.Value = Me.LibrodepositosTableAdapter.librodepositos_montototalbyidevento(gideventoseleccionado)
        Catch ex As Exception

        End Try
    End Sub
End Class