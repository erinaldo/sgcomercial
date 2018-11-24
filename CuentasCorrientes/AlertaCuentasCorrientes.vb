Public Class AlertaCuentasCorrientes
    Private Sub AlertaCuentasCorrientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.alertacuentascorrientes' Puede moverla o quitarla según sea necesario.
        Me.AlertacuentascorrientesTableAdapter.Fill(Me.ComercialDataSet.alertacuentascorrientes)

    End Sub
End Class