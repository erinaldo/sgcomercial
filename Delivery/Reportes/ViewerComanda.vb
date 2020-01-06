Public Class ViewerComanda
    Private Sub ViewerComanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.listapedidosdeliveryTableAdapter.FillByIdpedidodelivery(Me.comercialDataSet.listapedidosdelivery, gidpedidodelivery)
        Me.listapedidosdeliverydetalleTableAdapter.FillByIdPedidodelivery(Me.comercialDataSet.listapedidosdeliverydetalle, gidpedidodelivery)


        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print
        Me.Close()
    End Sub

    Private Sub ViewerComanda_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripDobleA5.Click
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportComanda.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripComandera80.Click
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.ReportComanda80.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class