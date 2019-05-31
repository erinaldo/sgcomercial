Public Class EstEnviosRecepcionesSucursales
    Private Sub EstEnviosRecepcionesSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.comercialDataSet.sucursales)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.EstEnviosSucursales' Puede moverla o quitarla según sea necesario.
        'Me.EstEnviosSucursalesTableAdapter.Fill(Me.comercialDataSet.EstEnviosSucursales)
        ComboBox1.SelectedIndex = -1
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        gFechaDesde = DateTimePicker1.Value
        gFechaHasta = DateTimePicker2.Value
        ComboBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        EstEnviosSucursalesBindingSource.Filter = ""
        If gFechaDesde <> Nothing And gFechaHasta <> Nothing Then
            EstEnviosSucursalesTableAdapter.FillByRangoFechas(Me.comercialDataSet.EstEnviosSucursales, gFechaDesde, gFechaHasta)
            ComboBox1.SelectedIndex = -1
            Me.ReportViewer1.RefreshReport()
        Else
            MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        gFechaDesde = DateTimePicker1.Value
        gFechaHasta = DateTimePicker2.Value
        ComboBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        EstEnviosSucursalesBindingSource.Filter = ""
        If gFechaDesde <> Nothing And gFechaHasta <> Nothing Then
            EstEnviosSucursalesTableAdapter.FillByRangoFechas(Me.comercialDataSet.EstEnviosSucursales, gFechaDesde, gFechaHasta)
            Me.ReportViewer1.RefreshReport()

        Else
            MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        filtrar()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        filtrar()

    End Sub
    Private Sub filtrar()
        If ComboBox1.SelectedValue = Nothing Then Return
        Dim tiporemito As String = Nothing
        If RadioButton1.Checked Then
            tiporemito = "'Entrada'"
        End If
        If RadioButton2.Checked Then
            tiporemito = "'Salida'"
        End If
        If ComboBox1.SelectedValue >= 0 Then
            Try
                If tiporemito = Nothing Then
                    EstEnviosSucursalesBindingSource.Filter = "idsucursal = " + ComboBox1.SelectedValue.ToString
                Else
                    EstEnviosSucursalesBindingSource.Filter = "idsucursal = " + ComboBox1.SelectedValue.ToString + " and tiporemito = " + tiporemito
                End If

                Me.ReportViewer1.RefreshReport()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
            End Try
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        filtrar()

    End Sub
End Class