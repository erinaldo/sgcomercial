Imports System.Reflection
Imports Microsoft.ReportingServices
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Data
Public Class ExportarProductos
    Private Sub ExportarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listaprodexport' Puede moverla o quitarla según sea necesario.
        Me.listaprodexportTableAdapter.Fill(Me.comercialDataSet.listaprodexport)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Este proceso demorará vários minutos. Desea continuar?", MsgBoxStyle.Question, "Pregunta") = MsgBoxResult.No Then
            Return
        Else
            Cursor.Current = Cursors.WaitCursor
        End If
        Dim SAVE As New SaveFileDialog
        Dim ruta As String
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim pth As String = ""
        'crearemos una nueva hoja de calculo
        Dim xlwb As Object = xlApp.WorkBooks.add
        Dim xlws As Object = xlwb.WorkSheets(1)
        Try
            'exportaremos los caracteres de las columnas

            For c As Integer = 0 To ProductosDataGridView.Columns.Count - 1
                xlws.cells(1, c + 1).value = ProductosDataGridView.Columns(c).HeaderText
            Next
            'exportaremos las cabeceras de las calumnas
            For r As Integer = 0 To ProductosDataGridView.RowCount - 1
                For c As Integer = 0 To ProductosDataGridView.Columns.Count - 1
                    xlws.cells(r + 2, c + 1).value = Convert.ToString(ProductosDataGridView.Item(c, r).Value)
                Next
                If r = 1000 Then
                    Exit For
                End If
            Next
            'guardamos la hoja de excel en la ruta especifica
            Cursor.Current = Cursors.Default
            Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog
            SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog1.Filter = "Archivo Excel| *.xlsx"
            SaveFileDialog1.FilterIndex = 2
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                ruta = SaveFileDialog1.FileName
                xlwb.saveas(ruta)
                xlws = Nothing
                xlwb = Nothing
                xlApp.quit()
                MsgBox("Exportado Correctamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim extensions As RenderingExtension() = ReportViewer1.LocalReport.ListRenderingExtensions()
        For Each extension As RenderingExtension In extensions
            If extension.Name = "EXCELOPENXML" Then
                If MsgBox("Este proceso puede tardar unos minutos. Desea continuar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                    Dim rtn As Integer
                    If ReportViewer1.ExportDialog(extension) Then
                        MsgBox("Proceso finalizado correctamente!", MsgBoxStyle.Information, "Mensaje")
                        Me.Close()

                    End If

                End If
            End If
        Next
    End Sub
End Class