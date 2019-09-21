Public Class EstadisticasCliente
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub EstadisticasCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ComboBoxEstadistica.SelectedIndex = 1
        ComboBoxEstadistica.Enabled = False
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        Try
            gclienteseleccionado = 0
            Dim p As SeleccionarCliente
            p = New SeleccionarCliente
            p.ShowDialog()
            IdclienteTextBox.Text = gclienteseleccionado.ToString
            If gclienteseleccionado > 1 Then
                Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, IdclienteTextBox.Text)
                If ClientesDataGridView.RowCount = 1 Then
                    'ComboBoxEstadistica.SelectedIndex = 1
                    ComboBoxEstadistica.Enabled = False
                Else
                    ComboBoxEstadistica.Enabled = False
                End If
            Else
                MsgBox("Seleccione un cliente válido!", MsgBoxStyle.Exclamation, "Advertencia!")
            End If
            ReportViewer1.Clear()
            ComboBoxEstadistica.SelectedIndex = -1
            gclienteseleccionado = Nothing
        Catch ex As Exception
            MsgBox("No se pudo completar la acción: " + ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstadistica.SelectedIndexChanged
        Try
            Select Case ComboBoxEstadistica.Text
                Case "Analisis de Consumo"
                    Dim fechadesde As Date
                    fechadesde = DateAdd("m", -6, Today)
                    Me.estcantconsumoclienteTableAdapter.FillByidcliente(Me.ComercialDataSet.estcantconsumocliente, IdclienteTextBox.Text, fechadesde)
                    Me.estClientefpagopreferidaTableAdapter.FillByidcliente(Me.ComercialDataSet.estClientefpagopreferida, IdclienteTextBox.Text)
                    Me.ReportViewer1.RefreshReport()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IdclienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdclienteTextBox.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Dim desde As DateTime = Nothing
            Dim hasta As DateTime = Nothing

            desde = DateTimePicker1.Value
            hasta = DateTimePicker2.Value

            If desde <> Nothing And hasta <> Nothing Then
                Me.estcantconsumoclienteTableAdapter.FillByRangoFechas(Me.ComercialDataSet.estcantconsumocliente, IdclienteTextBox.Text, desde, hasta)
                Me.estClientefpagopreferidaTableAdapter.FillByidcliente(Me.ComercialDataSet.estClientefpagopreferida, IdclienteTextBox.Text)
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
            Dim desde As DateTime = Nothing
            Dim hasta As DateTime = Nothing

            desde = DateTimePicker1.Value
            hasta = DateTimePicker2.Value

            If desde <> Nothing And hasta <> Nothing Then
                Me.estcantconsumoclienteTableAdapter.FillByRangoFechas(Me.ComercialDataSet.estcantconsumocliente, IdclienteTextBox.Text, desde, hasta)
                Me.estClientefpagopreferidaTableAdapter.FillByidcliente(Me.ComercialDataSet.estClientefpagopreferida, IdclienteTextBox.Text)
                Me.ReportViewer1.RefreshReport()
            Else
                MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim desde As DateTime = Nothing
            Dim hasta As DateTime = Nothing

            desde = DateTimePicker1.Value
            hasta = DateTimePicker2.Value

            If desde <> Nothing And hasta <> Nothing Then
                Me.estcantconsumoclienteTableAdapter.FillByRangoFechas(Me.ComercialDataSet.estcantconsumocliente, IdclienteTextBox.Text, desde, hasta)
                Me.estClientefpagopreferidaTableAdapter.FillByidcliente(Me.ComercialDataSet.estClientefpagopreferida, IdclienteTextBox.Text)
                Me.ReportViewer1.RefreshReport()
            Else
                MsgBox("Seleccione un rango de fechas!", "Advertencia", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class