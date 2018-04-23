Public Class LibroMayor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        '******************
        Dim value As String
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        value = DateTimePicker1.Text
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("desde", value, False))
        value = DateTimePicker2.Text
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("hasta", value, False))
        '*****************
        Select Case ComboBoxReporte.Text
            Case "Ventas"
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepLibroMayorVentasCompras.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Ventas", False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
                Me.ReportViewer1.RefreshReport()

                Me.librodiarioTableAdapter.FillByMayor(Me.comercialDataSet.librodiario, DateTimePicker1.Text, DateTimePicker2.Text, "Ventas")
            Case "Gastos"
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepLibroMayorVentasCompras.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Gastos", False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
                Me.ReportViewer1.RefreshReport()

                Me.librodiarioTableAdapter.FillByMayor(Me.comercialDataSet.librodiario, DateTimePicker1.Text, DateTimePicker2.Text, "Gastos")
            Case "Extracciones"
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepLibroMayorVentasCompras.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Extracciones", False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
                Me.ReportViewer1.RefreshReport()

                Me.librodiarioTableAdapter.FillByMayor(Me.comercialDataSet.librodiario, DateTimePicker1.Text, DateTimePicker2.Text, "Extracciones")
            Case "Sumas y Saldos"
                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepLibroMayor.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Sumas y Saldos", False))
                Me.ReportViewer1.LocalReport.SetParameters(parametros)
                Me.ReportViewer1.RefreshReport()

                Me.librodiarioTableAdapter.FillBySumasSaldos(Me.comercialDataSet.librodiario, DateTimePicker1.Text, DateTimePicker2.Text)

        End Select
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub LibroMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        'Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'Me.ReportViewer2.RefreshReport
        ComboBoxReporte.SelectedIndex = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class