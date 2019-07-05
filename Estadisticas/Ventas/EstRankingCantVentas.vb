Public Class EstRankingCantVentas
    Private Sub EstRankingCantVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libroventasdetalle' Puede moverla o quitarla según sea necesario.
        Me.libroventasdetalleTableAdapter.Fill(Me.comercialDataSet.libroventasdetalle)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Dim desde As Date = Nothing
            Dim hasta As Date = Nothing

            desde = DateTimePicker1.Value
            hasta = DateTimePicker2.Value
            'ComboBox1.SelectedIndex = -1
            'RadioButton1.Checked = False
            'RadioButton2.Checked = False
            'EstEnviosSucursalesBindingSource.Filter = ""
            If desde <> Nothing And hasta <> Nothing Then
                Me.libroventasdetalleTableAdapter.FillByRangoFechas(Me.comercialDataSet.libroventasdetalle, desde.ToString, hasta.ToString)

                Me.ReportViewer1.RefreshReport()

            Else
                MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            Dim desde As Date = Nothing
            Dim hasta As Date = Nothing

            desde = DateTimePicker1.Value
            hasta = DateTimePicker2.Value
            'ComboBox1.SelectedIndex = -1
            'RadioButton1.Checked = False
            'RadioButton2.Checked = False
            'EstEnviosSucursalesBindingSource.Filter = ""
            If desde <> Nothing And hasta <> Nothing Then
                Me.libroventasdetalleTableAdapter.FillByRangoFechas(Me.comercialDataSet.libroventasdetalle, desde.ToString, hasta.ToString)

                Me.ReportViewer1.RefreshReport()

            Else
                MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class