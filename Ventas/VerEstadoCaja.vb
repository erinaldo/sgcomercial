Public Class VerEstadoCaja
    Private Sub VerEstadoCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub VerEstadoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaresumen' Puede moverla o quitarla según sea necesario.
        Me.cajaresumenTableAdapter.Fill(Me.ComercialDataSet.cajaresumen)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaresumen' Puede moverla o quitarla según sea necesario.
        Me.cajaresumenTableAdapter.FillByidevento(Me.ComercialDataSet.cajaresumen, gideventoseleccionado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class