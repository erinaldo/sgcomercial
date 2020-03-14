Imports System.ComponentModel
Imports System.Threading

Public Class ComprobantesEmitidos
    Private Sub ComprobantesEmitidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipocomprobantes' Puede moverla o quitarla según sea necesario.
        Me.TipocomprobantesTableAdapter.FillByEstado(Me.ComercialDataSet.tipocomprobantes, "A")
        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        Try
            Dim fechadesde As Date
            Dim fechahasta As Date
            fechadesde = Convert.ToDateTime(DateTimeDesde.Value)
            fechahasta = Convert.ToDateTime(DateTimeHasta.Value)
            'Me.LibroventasTableAdapter.FillByFechaDate(Me.ComercialDataSet.libroventas, fechadesde.ToString)
            LibroventasTableAdapter.FillByRangoFechas(Me.ComercialDataSet.libroventas, fechadesde, fechahasta)
            '**************************************************************************************************
            Dim newColumn As DataGridViewColumn = LibroventasDataGridView.Columns("DataGridViewTextBoxColumn1")
            LibroventasDataGridView.Sort(newColumn, System.ComponentModel.ListSortDirection.Descending)
        Catch ex As Exception
            Try
                'Dim fechadesde As Date
                'Dim fechahasta As Date
                'fechadesde = Convert.ToDateTime(DateTimeDesde.Value)
                'fechahasta = Convert.ToDateTime(DateTimeHasta.Value)
                'Me.LibroventasTableAdapter.FillByFechaDate(Me.ComercialDataSet.libroventas, fechadesde.ToString)
                LibroventasTableAdapter.FillByRangoFechas2(Me.ComercialDataSet.libroventas, DateTimeDesde.Value, DateTimeHasta.Value)
                ''**************************************************************************************************
                Dim newColumn As DataGridViewColumn = LibroventasDataGridView.Columns("DataGridViewTextBoxColumn1")
                LibroventasDataGridView.Sort(newColumn, System.ComponentModel.ListSortDirection.Descending)
                ComboBox1.SelectedIndex = -1
            Catch ex2 As Exception
                MsgBox("Exception: " + ex2.Message + " " + ex2.StackTrace)
            End Try
            ''MsgBox("Exception: " + ex.Message + " " + ex.StackTrace)
        End Try

    End Sub
    Private Sub cleanfilters()
        ComboBox1.SelectedIndex = -1
        TextClienteNombre.Text = Nothing
        LibroventasBindingSource.Filter = ""
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeDesde.ValueChanged

    End Sub
    Sub refreshgrid()
        If MessageBox.Show("La busqueda tardará unos segundos, Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbNo Then
            Return
        End If
        Try ' pra un formato de fechas segun windows
            Me.Cursor = Cursors.WaitCursor
            Dim fechadesde As Date
            Dim fechahasta As Date
            fechadesde = Convert.ToDateTime(DateTimeDesde.Value)
            fechahasta = Convert.ToDateTime(DateTimeHasta.Value)
            'Me.LibroventasTableAdapter.FillByFechaDate(Me.ComercialDataSet.libroventas, fechadesde.ToString)
            LibroventasTableAdapter.FillByRangoFechas(Me.ComercialDataSet.libroventas, fechadesde, fechahasta)
            '**************************************************************************************************
            Dim newColumn As DataGridViewColumn = LibroventasDataGridView.Columns("DataGridViewTextBoxColumn1")
            LibroventasDataGridView.Sort(newColumn, System.ComponentModel.ListSortDirection.Descending)
            Me.ReportViewer1.RefreshReport()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Try ' pra OTRO formato de fechas segun windows
                'Dim fechadesde As Date
                'Dim fechahasta As Date
                'fechadesde = Convert.ToDateTime(DateTimeDesde.Value)
                'fechahasta = Convert.ToDateTime(DateTimeHasta.Value)
                'Me.LibroventasTableAdapter.FillByFechaDate(Me.ComercialDataSet.libroventas, fechadesde.ToString)
                LibroventasTableAdapter.FillByRangoFechas2(Me.ComercialDataSet.libroventas, DateTimeDesde.Value, DateTimeHasta.Value)
                ''**************************************************************************************************
                Dim newColumn As DataGridViewColumn = LibroventasDataGridView.Columns("DataGridViewTextBoxColumn1")
                LibroventasDataGridView.Sort(newColumn, System.ComponentModel.ListSortDirection.Descending)
                Me.ReportViewer1.RefreshReport()
                Me.Cursor = Cursors.Default
            Catch ex2 As Exception
                Me.Cursor = Cursors.Default
                MsgBox("Exception: " + ex2.Message + " " + ex2.StackTrace)
            End Try
            ''MsgBox("Exception: " + ex.Message + " " + ex.StackTrace)
        End Try
    End Sub

    Private Sub LibroventasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellClick
        Dim strerror As New StrError()
        Try
            If Not e.RowIndex >= 0 Or Not e.ColumnIndex >= 0 Then Return
            Select Case LibroventasDataGridView.Columns(e.ColumnIndex).Name
                Case "VistaPrevia"
                    gidventa = LibroventasDataGridView.Rows(e.RowIndex).Cells("idventa").Value
                    Dim x As New ViewerFactura()
                    x.ShowDialog()
                Case "SolicitarCAE"
                    'Dim StrError As New StrError
                    Dim idcliente As Long
                    idcliente = LibroventasDataGridView.Rows(e.RowIndex).Cells("idcliente").Value
                    strerror = ValidarDatosClienteAFIP(idcliente)
                    If strerror.CodError > 1 Then
                        MessageBox.Show(strerror.MsgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If
                    If LibroventasDataGridView.Rows(e.RowIndex).Cells("tipocomprobanteletra").Value = "X" Then
                        'MessageBox.Show("No se puede registrar este tipo de comprobante", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Dim GetTipoCbt As New PopUpGetTipoCbt()
                        gTipoCbtSeleccionado = Nothing
                        GetTipoCbt.ShowDialog()
                        If gTipoCbtSeleccionado = Nothing Then
                            MessageBox.Show("Primero seleccione un tipo de comprobante", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return
                        End If
                        Try
                            gidventa = LibroventasDataGridView.Rows(e.RowIndex).Cells("idventa").Value
                            Dim VentasTableAdapter As New comercialDataSetTableAdapters.ventasTableAdapter()
                            VentasTableAdapter.ventas_updateidtipocomprobante(gTipoCbtSeleccionado, gidventa)
                        Catch ex As Exception
                            MessageBox.Show("No se pudo completar la selección del tipo de comprobante", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return
                        End Try
                    End If

                    If IsDBNull(LibroventasDataGridView.Rows(e.RowIndex).Cells("cae").Value) Then
                        If MessageBox.Show("Seguro desea Registrar el Comprobante en AFIP?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Return
                        '-----------------  REGISTRAR FACTURA ELECTRÓNICA   ----------------------------------------
                        '********************************************************************************************
                        '================================================================================================================================
                        If GFEAFIPENTORNO = "HOMOLOGACION" Or GFEAFIPENTORNO = "PRODUCCION" Then
                            Dim FECAERequest As New WSFEV1.FECAERequest()
                            Dim TRA As String = Nothing
                            gidventa = LibroventasDataGridView.Rows(e.RowIndex).Cells("idventa").Value
                            '========================================================================================
                            '       generacion TRA
                            '========================================================================================
                            strerror = GenTRA(TRA)
                            If strerror.CodError > 1 Then
                                MessageBox.Show(strerror.MsgError, "No se pudo completar la operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Else
                                '========================================================================================
                                '       Generación Factura Electrónica
                                '========================================================================================
                                strerror = FECAELoadRequest(gidventa, FECAERequest)
                                If strerror.CodError > 0 Then
                                    MessageBox.Show(strerror.MsgError, "No se pudo completar la operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Else
                                    refreshgrid()
                                End If
                            End If
                        End If
                        '================================================================================================================================
                    Else
                        MessageBox.Show("Comprobante YA REGISTRADO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Ha ocurrido una excepción: " + ex.Message)
        End Try

    End Sub

    Private Sub LibroventasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibroventasDataGridView.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextClienteNombre.TextChanged

    End Sub

    Private Sub DateTimeHasta_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeHasta.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cleanfilters()
        refreshgrid()
    End Sub

    Private Sub ButtonExportar_Click(sender As Object, e As EventArgs) Handles ButtonExportar.Click
        Dim xlApp As New Microsoft.Office.Interop.Excel.Application()
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        'xlApp as New Microsoft.Office.Interop.Excel.ApplicationClass()
        Try
            Dim savefiledialog As New SaveFileDialog()
            'savefiledialog.Filter = "TXT Files (*.txt*)|*.txt"
            If savefiledialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim filepath As String = savefiledialog.FileName + ".xlsx"
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                Me.Cursor = Cursors.WaitCursor
                For i = 0 To LibroventasDataGridView.RowCount - 2
                    For j = 0 To LibroventasDataGridView.ColumnCount - 1
                        For k As Integer = 1 To LibroventasDataGridView.Columns.Count
                            xlWorkSheet.Cells(1, k) = LibroventasDataGridView.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = LibroventasDataGridView(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(filepath)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)
            End If
            Me.Cursor = Cursors.Default
            MsgBox("Operación exitosa: " + savefiledialog.FileName)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Ocurrió una excepción: " + ex.Message, "Aviso!")
        End Try

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            If ComboBox1.SelectedIndex >= 0 And Len(Trim(TextClienteNombre.Text)) > 0 Then
                LibroventasBindingSource.Filter = "nombre like '%" + TextClienteNombre.Text + "%' and idtipocomprobanteafip =" + ComboBox1.SelectedValue.ToString
            Else
                If Len(Trim(TextClienteNombre.Text)) > 0 Then
                    LibroventasBindingSource.Filter = "nombre like '%" + TextClienteNombre.Text + "%'"
                End If
                If ComboBox1.SelectedIndex >= 0 Then
                    LibroventasBindingSource.Filter = "idtipocomprobanteafip =" + ComboBox1.SelectedValue.ToString
                End If
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            LibroventasBindingSource.Filter = ""
            refreshgrid()
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cleanfilters()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            'If MessageBox.Show("Seguro desea imprimir el reporte?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Dim rtn As Integer
            If ReportViewer1.PrintDialog() Then
                'MsgBox("Proceso finalizado correctamente!", MsgBoxStyle.Information, "Mensaje")
                MsgSuccessPopUp("Proceso finalizado correctamente!")
                'Me.Close()
            End If
            'End If
        Catch ex As Exception
            MsgExPopUp("Aguarde un momento, se estan procesando los datos del reporte")
            Return
        End Try
    End Sub

    Private Sub ComprobantesEmitidos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_RenderingComplete(sender As Object, e As RenderingCompleteEventArgs) Handles ReportViewer1.RenderingComplete

        Button2.Enabled = True
        Button5.Enabled = True
    End Sub

    Private Sub ReportViewer1_RenderingBegin(sender As Object, e As CancelEventArgs) Handles ReportViewer1.RenderingBegin
        Button2.Enabled = False
        Button5.Enabled = False
    End Sub
End Class