Public Class ValorizacionStock
    Private Sub ViewerReporteValorizacionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.stockgeneralvaluacion' Puede moverla o quitarla según sea necesario.
        Me.stockgeneralvaluacionTableAdapter.Fill(Me.comercialDataSet.stockgeneralvaluacion)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            stockgeneralvaluacionBindingSource.Filter = $"producto like'%{TextBox1.Text}%'"
        Catch ex As Exception
            stockgeneralvaluacionBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ViewerReporteValorizacionStock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
        If e.KeyCode = Keys.F5 And Me.MaximizeBox = True Then
            Try
                Me.stockgeneralvaluacionTableAdapter.Fill(Me.comercialDataSet.stockgeneralvaluacion)
            Catch ex As Exception

            End Try
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class