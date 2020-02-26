Public Class DetalleEgresos




    Private Sub DetalleEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        Try
            Me.V_gastosTableAdapter.FillByidevento(Me.ComercialDataSet.v_gastos, gideventoseleccionado)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub V_gastosDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles V_gastosDataGridView.CellContentClick

    End Sub

    Private Sub V_gastosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles V_gastosDataGridView.CellClick
        Try
            Dim i As Integer = 0
            If V_gastosDataGridView.CurrentCell.ColumnIndex >= 0 Then
                Select Case V_gastosDataGridView.CurrentCell.ColumnIndex
                    Case 4 '*****************ANULAR GASTO*****************************
                        If MsgBox("Seguro desea anular la operación (Anular gasto)?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                            CajasoperacionesTableAdapter.cajasoperaciones_bajaopgasto(V_gastosDataGridView.CurrentRow.Cells("idoperacion").Value, gusername)
                            Me.V_gastosTableAdapter.FillByidevento(Me.ComercialDataSet.v_gastos, gideventoseleccionado)

                            Me.ReportViewer1.RefreshReport()
                        End If
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DetalleEgresos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
End Class