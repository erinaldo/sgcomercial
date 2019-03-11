Public Class AlertaCuentasCorrientes
    Private Sub AlertaCuentasCorrientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub AlertaCuentasCorrientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.alertacuentascorrientes' Puede moverla o quitarla según sea necesario.
        Me.AlertacuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.alertacuentascorrientes)

    End Sub
End Class