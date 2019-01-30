Public Class ViewerReporteRelevamientoStock
    Private Sub ViewerReporteRelevamientoStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listarubros' Puede moverla o quitarla según sea necesario.
        Me.ListarubrosTableAdapter.Fill(Me.comercialDataSet.listarubros)

        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.comercialDataSet.proveedores)
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = -1 Then Return
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
            'ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("No se pudo completar la acción: " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.stockgeneralTableAdapter.Fill(Me.comercialDataSet.stockgeneral)
        stockgeneralBindingSource.Filter = ""
        Me.ReportViewer1.RefreshReport()
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub ViewerReporteRelevamientoStock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = -1 Then Return
        Try
            If ComboBox2.Text <> "" Then
                Me.stockgeneralTableAdapter.Fill(Me.comercialDataSet.stockgeneral)
                'MsgBox(ComboBox1.SelectedValue.ToString)
                stockgeneralBindingSource.Filter = "rubro like '%" + ComboBox2.Text + "%'"
                Me.ReportViewer1.RefreshReport()
            Else
                stockgeneralBindingSource.Filter = ""
                Me.ReportViewer1.RefreshReport()
            End If
            ComboBox1.SelectedIndex = -1
            'ComboBox2.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("No se pudo completar la acción: " + ex.Message)
        End Try
    End Sub
End Class