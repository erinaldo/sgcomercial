Public Class ViewerReporteRelevamientoStock
    Private Sub ViewerReporteRelevamientoStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.comercialDataSet.proveedores)
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If ComboBox1.Text <> "" Then
                Me.stockgeneralTableAdapter.Fill(Me.comercialDataSet.stockgeneral)
                'MsgBox(ComboBox1.SelectedValue.ToString)
                stockgeneralBindingSource.Filter = "idproveedor = " + ComboBox1.SelectedValue.ToString
                Me.ReportViewer1.RefreshReport()
            Else
                stockgeneralBindingSource.Filter = ""
                Me.ReportViewer1.RefreshReport()
            End If

        Catch ex As Exception
            MsgBox("No se pudo completar la acción: " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stockgeneralBindingSource.Filter = ""
        Me.ReportViewer1.RefreshReport()
        ComboBox1.SelectedIndex = -1
    End Sub
End Class