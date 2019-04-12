Public Class LibroDiario

    Private Sub LibroDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.librodiario' Puede moverla o quitarla según sea necesario.
        'Me.librodiarioTableAdapter.Fill(Me.comercialDataSet.librodiario)

        'Me.librodiarioTableAdapter.Fill(Me.comercialDataSet.librodiario)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)

        'Me.cajasoperacionesTableAdapter.Fill(Me.comercialDataSet.cajasoperaciones)
        ComboBoxReporte.SelectedIndex = 0


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '******************
        'Dim value As String
        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        '*****************
        Try
            Select Case ComboBoxReporte.Text
                Case "Ventas"
                    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepLibroDiario.rdlc"
                    'parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Ventas", False))
                    'Me.ReportViewer1.LocalReport.SetParameters(parametros)
                    'Me.ReportViewer1.RefreshReport()
                    'MsgBox("entra por ventas")
                    Me.ReportViewer1.RefreshReport()
                    parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Ventas", False))
                    Me.ReportViewer1.LocalReport.SetParameters(parametros)

                    Me.librodiarioTableAdapter.FillByDiarioTipo(Me.comercialDataSet.librodiario, DateTimePicker1.Text, "Ventas")
                    Me.ReportViewer1.RefreshReport()

                    Return
                Case "Gastos"
                    'MsgBox("entra por gastos")
                    parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Gastos", False))
                    Me.ReportViewer1.LocalReport.SetParameters(parametros)

                    Me.librodiarioTableAdapter.FillByDiarioTipo(Me.comercialDataSet.librodiario, DateTimePicker1.Text, "Gastos")
                    Me.ReportViewer1.RefreshReport()

                    Return
                Case "Extracciones"
                    'MsgBox("entra por Extracciones")
                    parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("tipo", "Extracciones", False))
                    Me.ReportViewer1.LocalReport.SetParameters(parametros)

                    Me.librodiarioTableAdapter.FillByDiarioTipo(Me.comercialDataSet.librodiario, DateTimePicker1.Text, "Extracciones")
                    Me.ReportViewer1.RefreshReport()

                    Return
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class