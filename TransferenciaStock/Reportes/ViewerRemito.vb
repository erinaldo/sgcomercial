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

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.listaremitosTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitos, gidremito)
        Me.listaremitosdetalleTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitosdetalle, gidremito)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursalSinCostos.rdlc"


        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub OcultarCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcultarCostosToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.listaremitosTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitos, gidremito)
        Me.listaremitosdetalleTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitosdetalle, gidremito)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursalSinCostos.rdlc"
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub MostrarCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarCostosToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.listaremitosTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitos, gidremito)
        Me.listaremitosdetalleTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitosdetalle, gidremito)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursal.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class