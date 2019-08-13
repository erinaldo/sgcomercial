Public Class ComprobantesEmitidos
    Private Sub ComprobantesEmitidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Catch ex2 As Exception
                MsgBox("Exception: " + ex2.Message + " " + ex2.StackTrace)
            End Try
            ''MsgBox("Exception: " + ex.Message + " " + ex.StackTrace)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeDesde.ValueChanged
        refreshgrid()
    End Sub
    Sub refreshgrid()
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
            Catch ex2 As Exception
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
                    gidventa = LibroventasDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn5").Value
                    Dim x As New ViewerFactura()
                    x.ShowDialog()
                Case "SolicitarCAE"
                    If LibroventasDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn41").Value = "X" Then
                        MessageBox.Show("No se puede registrar este tipo de comprobante", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If
                    If IsDBNull(LibroventasDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn30").Value) Then
                        If MessageBox.Show("Seguro desea Registrar el Comprobante en AFIP?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Return
                        '-----------------  REGISTRAR FACTURA ELECTRÓNICA   ----------------------------------------
                        '********************************************************************************************
                        '================================================================================================================================
                        If GFEAFIPENTORNO = "HOMOLOGACION" Or GFEAFIPENTORNO = "PRODUCCION" Then
                            Dim FECAERequest As New WSFEV1.FECAERequest()
                            Dim TRA As String = Nothing
                            gidventa = LibroventasDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn5").Value
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
        Try
            LibroventasBindingSource.Filter = "nombre like '%" + TextClienteNombre.Text + "%'"
        Catch ex As Exception
            refreshgrid()
        End Try
    End Sub

    Private Sub DateTimeHasta_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeHasta.ValueChanged
        refreshgrid()
    End Sub
End Class