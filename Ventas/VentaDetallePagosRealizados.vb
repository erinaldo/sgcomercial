Public Class VentaDetallePagosRealizados
    Private Sub VentaDetallePagosRealizados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub VentaDetallePagosRealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listapagos' Puede moverla o quitarla según sea necesario.
        'Me.ListapagosTableAdapter.Fill(Me.ComercialDataSet.listapagos)
        Me.ListapagosTableAdapter.FillByIDVenta(Me.ComercialDataSet.listapagos, gidventa)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventas' Puede moverla o quitarla según sea necesario.
        Me.LibroventasTableAdapter.FillByIdventa(Me.ComercialDataSet.libroventas, gidventa)
    End Sub
End Class