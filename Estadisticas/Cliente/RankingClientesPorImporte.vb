﻿Public Class RankingClientesPorImporte
    Private Sub RankingClientesPorImporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '************************************************
            Dim desde As Date = DateTimePicker1.Value
            Dim hasta As Date = DateTimePicker2.Value
            Me.EstRankingclientesporimporteTableAdapter.FillByRangoFechas(Me.comercialDataSet.EstRankingclientesporimporte, desde, hasta)
            Me.ReportViewer1.RefreshReport()
            '************************************************
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            '************************************************
            Dim desde As Date = DateTimePicker1.Value
            Dim hasta As Date = DateTimePicker2.Value
            Me.EstRankingclientesporimporteTableAdapter.FillByRangoFechas(Me.comercialDataSet.EstRankingclientesporimporte, desde, hasta)
            Me.ReportViewer1.RefreshReport()
            '************************************************
        Catch ex As Exception

        End Try

    End Sub
End Class