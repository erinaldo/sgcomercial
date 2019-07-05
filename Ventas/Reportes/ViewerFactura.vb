Public Class ViewerFactura
    Private Sub ViewerFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim V_ComandaDefault As String
        V_ComandaDefault = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ComandaDefault")
        '**********
        Select Case V_ComandaDefault
            Case "80MM"
                Comanda80mmToolStripMenuItem.PerformClick()
            Case "58MM"
                Comanda58mmToolStripMenuItem.PerformClick()
            Case "A4"
                HojaA4ToolStripMenuItem.PerformClick()
        End Select
        Me.Select()

        'Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        'Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera80.rdlc"
        'Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        'Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub HojaA4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HojaA4ToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        If libroventasTableAdapter.libroventas_consultar_tipocomprobante(gidventa) = "Factura A" Then
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFacturaIVA.rdlc"
            Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Else
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepFactura.rdlc"
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Comanda80mmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Comanda80mmToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera80.rdlc"
        'Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Comanda58mmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Comanda58mmToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libroventasTableAdapter.FillByIdventa(Me.comercialDataSet.libroventas, gidventa)
        Me.libroventasdetalleTableAdapter.FillByIdventa(Me.comercialDataSet.libroventasdetalle, gidventa)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepComandera58.rdlc"
        'Me.ivaresumenTableAdapter.FillByIdventa(Me.comercialDataSet.ivaresumen, gidventa)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub ViewerFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            ''''''''''***************************   POR DEFECTO **************************************
            If e.KeyCode = Keys.Escape Then
                If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                    Me.Close()
                End If
            End If
            If e.KeyCode = Keys.Enter Then
                ReportViewer1.PrintDialog()
                Me.Close()
            End If
            ''''''''''''''''''''*******************************************'''''''''''''''''''''
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_KeyDown(sender As Object, e As KeyEventArgs) Handles ReportViewer1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ReportViewer1.PrintDialog()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub ViewerFactura_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print

    End Sub

    Private Sub ReportViewer1_PrintingBegin(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.PrintingBegin

    End Sub
End Class