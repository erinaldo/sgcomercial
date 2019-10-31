Public Class ReporteVentasFranquicia
    Private Sub ReporteVentasFranquicia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
            '/******************************************************************/
            '********** ValidarDatosClientesNuevos
            Dim v_ListaRefFranquicia As Integer
            v_ListaRefFranquicia = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("ListaRefFranquicia")
            ''**********
            If v_ListaRefFranquicia = 3 Then
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepVentasFranquiciaLista3.rdlc"
                Dim msg As String = ""
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Dim desde As Date '= Nothing
                    Dim hasta As Date '= Nothing
                    msg = " Point A"

                    desde = Convert.ToDateTime(DateTimePickerDesde.Value)
                    hasta = Convert.ToDateTime(DateTimePickerHasta.Value)
                    msg = " Point B "
                    If desde <> Nothing And hasta <> Nothing Then
                        Me.libroventasTableAdapter.FillByRangoFechas(Me.comercialDataSet.libroventas, desde.ToString, hasta.ToString)
                        msg = " Point LV "
                        Me.libroventasdetalleTableAdapter.FillByRangoFechas(Me.comercialDataSet.libroventasdetalle, desde.ToString, hasta.ToString)
                        msg = " Point LVD "
                        Me.ReportViewer1.RefreshReport()
                        Me.Cursor = Cursors.Default
                    Else
                        Me.Cursor = Cursors.Default
                        MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MsgBox("Ocurrió una excepción al consultar los datos: ", msg + ex.Message)
                End Try
            End If
            If v_ListaRefFranquicia = 4 Then
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepVentasFranquiciaLista4.rdlc"
                'Me.ReportViewer1.RefreshReport()
                Dim msg As String = ""
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Dim desde As Date '= Nothing
                    Dim hasta As Date '= Nothing
                    msg = " Point A"

                    desde = Convert.ToDateTime(DateTimePickerDesde.Value)
                    hasta = Convert.ToDateTime(DateTimePickerHasta.Value)
                    msg = " Point B "
                    If desde <> Nothing And hasta <> Nothing Then
                        Me.libroventasTableAdapter.FillByRangoFechas(Me.comercialDataSet.libroventas, desde.ToString, hasta.ToString)
                        msg = " Point LV "
                        Me.libroventasdetalleTableAdapter.FillByRangoFechas(Me.comercialDataSet.libroventasdetalle, desde.ToString, hasta.ToString)
                        msg = " Point LVD "
                        Me.ReportViewer1.RefreshReport()
                        Me.Cursor = Cursors.Default
                    Else
                        Me.Cursor = Cursors.Default
                        MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MsgBox("Ocurrió una excepción al consultar los datos: ", msg + ex.Message)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió una excepción: el reporte no esta disponible -> " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
End Class