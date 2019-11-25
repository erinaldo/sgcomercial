Public Class CCReimputarSaldo
    Private Sub CCReimputarSaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.ccsaldodisponible' Puede moverla o quitarla según sea necesario.
        Try
            Me.CcsaldodisponibleTableAdapter.FillByidcliente(Me.ComercialDataSet.ccsaldodisponible, gidcliente)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub CcsaldodisponibleDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CcsaldodisponibleDataGridView.CellClick
        Try
            Select Case CcsaldodisponibleDataGridView.Columns(e.ColumnIndex).Name
                Case "Imputar"
                    Dim montodiponible As Decimal

                    gidpago = CcsaldodisponibleDataGridView.Rows(e.RowIndex).Cells("idpagos").Value
                    montodiponible = CcsaldodisponibleDataGridView.Rows(e.RowIndex).Cells("saldodisponible").Value
                    gidventa = 0
                    gmontoapagar = 0
                    Dim ki As New SeleccionarVenta()
                    ki.ShowDialog()
                    If gidventa = 0 Or gmontoapagar = 0 Then Return

                    If MessageBox.Show("Seguro desea reimputar el monto " + gmontoapagar.ToString, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim pagosimputaciones As New comercialDataSetTableAdapters.pagosimputacionesTableAdapter()
                        If gmontoapagar < montodiponible Then
                            pagosimputaciones.pagosimputaciones_insertar(gidpago, gidventa, gmontoapagar)
                        Else
                            pagosimputaciones.pagosimputaciones_insertar(gidpago, gidventa, montodiponible)
                        End If
                    End If
                    gidpago = 0
                    gidventa = 0
                    gmontoapagar = 0
                    Try
                        Me.CcsaldodisponibleTableAdapter.FillByidcliente(Me.ComercialDataSet.ccsaldodisponible, gidcliente)
                    Catch ex As Exception

                    End Try
            End Select
        Catch ex As Exception
            MsgBox("Ha ocurrido una excepción: " + ex.Message)
        End Try
    End Sub

    Private Sub CcsaldodisponibleDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CcsaldodisponibleDataGridView.CellContentClick

    End Sub
End Class