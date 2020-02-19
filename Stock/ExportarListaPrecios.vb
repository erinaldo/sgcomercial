Imports System.ComponentModel

Public Class ExportarListaPrecios
    Private Sub ExportarListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        Me.ListaspreciosTableAdapter.Fill(Me.ComercialDataSet.listasprecios)
        Me.listaproductosTableAdapter.FillByComerciables(Me.ComercialDataSet.listaproductos)
        Me.ReportViewer1.RefreshReport()
        ExcelBtn.Enabled = False
        PDFBtn.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Select Case ComboBox1.Text
                Case "Vta. Publico (empaque cerrado)"
                    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEXListaPrecioVenta.rdlc"
                    Me.ReportViewer1.RefreshReport()
                    Return
                Case "Vta. Granel"
                    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEXListaPrecioVentaGranel.rdlc"
                    Me.ReportViewer1.RefreshReport()
                    Return
                Case "Vta. Com./Mayorista"
                    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEXListaPrecioVentaMayorista.rdlc"
                    Me.ReportViewer1.RefreshReport()
                    Return
                Case "Vta. Distribuidor"
                    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEXListaPrecioVentaDistribuidor.rdlc"
                    Me.ReportViewer1.RefreshReport()
                    Return
            End Select
        Catch ex As Exception
            MsgEx(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ExcelBtn.Click
        Try
            Dim extensions As RenderingExtension() = ReportViewer1.LocalReport.ListRenderingExtensions()
            For Each extension As RenderingExtension In extensions
                If extension.Name = "EXCELOPENXML" Then
                    'If MessageBox.Show("El proceso puede tardar unos minutos. Desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    'Dim rtn As Integer
                    If ReportViewer1.ExportDialog(extension) Then
                        'MsgBox("Proceso finalizado correctamente!", MsgBoxStyle.Information, "Mensaje")
                        MsgSuccessPopUp("Proceso finalizado correctamente!")
                        'Me.Close()
                    End If
                    'End If
                End If
            Next
        Catch ex As Exception
            MsgExPopUp("Aguarde un momento, se estan procesando los datos del reporte")
            Return
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles PDFBtn.Click
        Try
            Dim extensions As RenderingExtension() = ReportViewer1.LocalReport.ListRenderingExtensions()
            For Each extension As RenderingExtension In extensions
                If extension.Name = "PDF" Then
                    'If MessageBox.Show("El proceso puede tardar unos minutos. Desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    'Dim rtn As Integer
                    If ReportViewer1.ExportDialog(extension) Then
                        'MsgBox("Proceso finalizado correctamente!", MsgBoxStyle.Information, "Mensaje")
                        MsgSuccessPopUp("Proceso finalizado correctamente!")
                        'Me.Close()
                    End If
                    'End If
                End If
            Next
        Catch ex As Exception
            MsgExPopUp("Aguarde un momento, se estan procesando los datos del reporte")
            Return
        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_RenderingComplete(sender As Object, e As RenderingCompleteEventArgs) Handles ReportViewer1.RenderingComplete
        ExcelBtn.Enabled = True
        PDFBtn.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ReportViewer1_RenderingBegin(sender As Object, e As CancelEventArgs) Handles ReportViewer1.RenderingBegin
        ExcelBtn.Enabled = False
        PDFBtn.Enabled = False
        Me.Cursor = Cursors.WaitCursor
    End Sub

    Private Sub ExportarListaPrecios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class