Public Class ViewerReportesRemitos
    Private Sub ViewerReportesRemitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today
        Dim SucursalesTableAdapter As comercialDataSetTableAdapters.sucursalesTableAdapter
        SucursalesTableAdapter = New comercialDataSetTableAdapters.sucursalesTableAdapter()
        Dim sucursalesdatatable As comercialDataSet.sucursalesDataTable
        sucursalesdatatable = SucursalesTableAdapter.GetData()
        For i = 0 To sucursalesdatatable.Count - 1
            ComboBox2.Items.Add(sucursalesdatatable.Rows(i).Item(1))
        Next
        ComboBox2.SelectedIndex = 0
        '*************************************************************************
        Select Case gReporteSeleccionado
            Case "RepEnviosRangoFechas"
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnviosRangoFechas.rdlc"
                'parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Ventas", False))
                'Me.ReportViewer1.LocalReport.SetParameters(parametros)
                Me.libromayorremitosTableAdapter.FillByFechaDH(Me.comercialDataSet.libromayorremitos, DateTimePicker1.Text, DateTimePicker2.Text)
        End Select
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.libromayorremitosTableAdapter.FillByFechaDH(Me.comercialDataSet.libromayorremitos, DateTimePicker1.Text, DateTimePicker2.Text)
        Dim filtro As String = ""
        If ComboBox2.Text <> "TODAS" Then
            filtro = "nombre like'%" + ComboBox2.Text + "%'"
        End If
        Select Case ComboBox1.Text
            Case "Envío(S)"
                If Len(filtro) > 0 Then
                    filtro += " and  tiporemito like'S'"
                Else
                    filtro += "   tiporemito like'S'"
                End If

            Case "Recepción(E)"
                If Len(filtro) > 0 Then
                    filtro += " and  tiporemito like'E'"
                Else
                    filtro += "   tiporemito like'E'"
                End If
            Case Else
        End Select


        libromayorremitosBindingSource.Filter = filtro
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class