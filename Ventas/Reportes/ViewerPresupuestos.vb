Public Class ViewerPresupuestos
    Private Sub ViewerPresupuestos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            ReportViewer1.PrintDialog()
            Me.Close()
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub ViewerPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libropresupuestos' Puede moverla o quitarla según sea necesario.
        Me.libropresupuestosTableAdapter.FillByIDPresupuesto(Me.comercialDataSet.libropresupuestos, gidpresupuesto)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.libropresupuestosdetalle' Puede moverla o quitarla según sea necesario.
        Me.libropresupuestosdetalleTableAdapter.FillByIDPresupuesto(Me.comercialDataSet.libropresupuestosdetalle, gidpresupuesto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class