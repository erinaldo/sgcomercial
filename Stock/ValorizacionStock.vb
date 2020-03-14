Imports System.ComponentModel

Public Class ValorizacionStock
    Private Sub ViewerReporteValorizacionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.stockgeneralvaluacion' Puede moverla o quitarla según sea necesario.
        Me.stockgeneralvaluacionTableAdapter.Fill(Me.comercialDataSet.stockgeneralvaluacion)
        recuento()
        ComboBoxFiltro.SelectedIndex = 0
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Select Case ComboBoxFiltro.Text
                Case "Producto"
                    stockgeneralvaluacionBindingSource.Filter = $"producto like'%{TextBox1.Text}%'"
                    'recuento()
                Case "Rubro"
                    stockgeneralvaluacionBindingSource.Filter = $"rubro like'%{TextBox1.Text}%'"
                    'recuento()
                Case "Código"
                    stockgeneralvaluacionBindingSource.Filter = $"codigoproducto ='{TextBox1.Text}'"
                    'recuento()
            End Select
        Catch ex As Exception
            stockgeneralvaluacionBindingSource.Filter = ""
            'recuento()
        End Try
    End Sub

    Private Sub ViewerReporteValorizacionStock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
        If e.KeyCode = Keys.F5 And Me.MaximizeBox = True Then
            Try
                Me.stockgeneralvaluacionTableAdapter.Fill(Me.comercialDataSet.stockgeneralvaluacion)
            Catch ex As Exception

            End Try
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
    Private Sub recuento()
        Try
            Dim totalvalpc As Decimal = 0
            Dim totalvalpv As Decimal = 0


            For i = 0 To DataGridView1.RowCount - 1
                totalvalpc += DataGridView1.Rows(i).Cells("valpreciocosto").Value
                totalvalpv += DataGridView1.Rows(i).Cells("valprecioventa").Value
            Next
            LabelTotalPrecioCosto.Text = totalvalpc.ToString
            LabelTotalPrecioVenta.Text = totalvalpv.ToString
        Catch ex As Exception
            LabelTotalPrecioCosto.Text = "......."
            LabelTotalPrecioVenta.Text = "......."
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub stockgeneralvaluacionBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles stockgeneralvaluacionBindingSource.CurrentChanged

    End Sub

    Private Sub stockgeneralvaluacionBindingSource_ListChanged(sender As Object, e As ListChangedEventArgs) Handles stockgeneralvaluacionBindingSource.ListChanged
        recuento()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
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

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_RenderingBegin(sender As Object, e As CancelEventArgs) Handles ReportViewer1.RenderingBegin
        BtnExcel.Enabled = False
        BtnPdf.Enabled = False
        'Me.Cursor = Cursors.WaitCursor
    End Sub

    Private Sub ReportViewer1_RenderingComplete(sender As Object, e As RenderingCompleteEventArgs) Handles ReportViewer1.RenderingComplete
        BtnExcel.Enabled = True
        BtnPdf.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ComboBoxFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFiltro.SelectedIndexChanged
        TextBox1.Select()
    End Sub
End Class