Public Class ImprimirPlantillas
    Private Sub ImprimirPlantillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBoxPlantilla.Text
            Case "Pedido"
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.PlantillaPedido.rdlc"
                Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
                Me.ReportViewer1.RefreshReport()
        End Select
    End Sub
End Class