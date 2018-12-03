Public Class EstadisticasProveedor
    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub EstadisticaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        Try
            gidproveedor = 0
            Dim p As BuscaProveedor
            p = New BuscaProveedor
            p.ShowDialog()
            IdproveedorTextBox.Text = gidproveedor.ToString
            If gidproveedor > 0 Then
                Me.ProveedoresTableAdapter.FillByIdproveedor(Me.ComercialDataSet.proveedores, IdproveedorTextBox.Text)
                If ProveedoresDataGridView.RowCount = 1 Then
                    ComboBoxEstadistica.Enabled = True
                Else
                    ComboBoxEstadistica.Enabled = False
                End If
            Else
                MsgBox("Seleccione un proveedor válido!", MsgBoxStyle.Exclamation, "Advertencia!")
            End If
            ReportViewer1.Clear()
            ComboBoxEstadistica.SelectedIndex = -1
            gidproveedor = Nothing
        Catch ex As Exception
            MsgBox("No se pudo completar la acción: " + ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxEstadistica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstadistica.SelectedIndexChanged
        Try
            Select Case ComboBoxEstadistica.Text
                Case "Analisis de Ventas"
                    Dim fechadesde As Date
                    fechadesde = DateAdd("m", -6, Today)
                    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.GraphCantConsumoProveedor.rdlc"
                    Me.estcantconsumoproveedorTableAdapter.FillByidproveedor(Me.ComercialDataSet.estcantconsumoproveedor, IdproveedorTextBox.Text, fechadesde)
                    Me.estcantkilosvendidosproveedorTableAdapter.FillByidproveedor(Me.ComercialDataSet.estcantkilosvendidosproveedor, IdproveedorTextBox.Text, fechadesde)
                    Me.ReportViewer1.RefreshReport()
            End Select
        Catch ex As Exception
            MsgBox("No se pudo completar la acción: " + ex.Message)
        End Try
    End Sub
End Class