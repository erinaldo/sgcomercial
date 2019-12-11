Public Class ReporteGastos
    Private Sub ReporteGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.v_gastos' Puede moverla o quitarla según sea necesario.
        Me.V_gastosTableAdapter.Fill(Me.ComercialDataSet.v_gastos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.v_gastos' Puede moverla o quitarla según sea necesario.
        'Me.V_gastosTableAdapter.Fill(Me.ComercialDataSet.v_gastos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim desde As Date '= Nothing
            Dim hasta As Date '= Nothing
            'msg = " Point A"

            desde = Convert.ToDateTime(DateTimePickerdesde.Value)
            hasta = Convert.ToDateTime(DateTimePickerhasta.Value)
            'msg = " Point B "
            If desde <> Nothing And hasta <> Nothing Then
                Me.V_gastosTableAdapter.FillByRangoFechas(Me.ComercialDataSet.v_gastos, desde.ToString, hasta.ToString)
                'msg = " Point LV "
                Me.V_gastosTableAdapter.FillByRangoFechas(Me.ComercialDataSet.v_gastos, desde.ToString, hasta.ToString)
                'msg = " Point LVD "
                'Me.ReportViewer1.RefreshReport()
                ReportViewer1.RefreshReport()
                Me.Cursor = Cursors.Default

            Else
                Me.Cursor = Cursors.Default
                MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Ocurrió una excepción al consultar los datos: ", ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ReportViewer1.PrintDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ExExcel()
    End Sub
    Private Sub ExExcel()
        Try
            Dim extensions As RenderingExtension() = ReportViewer1.LocalReport.ListRenderingExtensions()
            For Each extension As RenderingExtension In extensions
                If extension.Name = "EXCELOPENXML" Then
                    If MessageBox.Show("El proceso puede tardar unos minutos. Desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        'Dim rtn As Integer
                        If ReportViewer1.ExportDialog(extension) Then
                            'MsgBox("Proceso finalizado correctamente!", MsgBoxStyle.Information, "Mensaje")
                            MessageBox.Show("Proceso finalizado correctamente!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Me.Close()
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido una excepción: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try
    End Sub
End Class