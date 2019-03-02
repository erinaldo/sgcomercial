Public Class ViewerCtaCte
    Private Sub ViewerCtaCte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.listacuentascorrientesTableAdapter.FillByidcliente(Me.comercialDataSet.listacuentascorrientes, gidcliente)
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub HistoricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricoToolStripMenuItem.Click

        Me.listacuentascorrientesTableAdapter.FillByidcliente(Me.comercialDataSet.listacuentascorrientes, gidcliente)
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SoloDeudasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoloDeudasToolStripMenuItem.Click

        Me.listacuentascorrientesTableAdapter.FillByDeuda(Me.comercialDataSet.listacuentascorrientes, gidcliente)
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class