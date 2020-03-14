Public Class ViewerReporteControlStockGeneral
    Private Sub ViewerReporteControlStockGeneral_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub ViewerReporteControlStockGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.listarubros' Puede moverla o quitarla según sea necesario.
        Me.ListarubrosTableAdapter.Fill(Me.comercialDataSet.listarubros)
        ComboBox1.SelectedValue = -1
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.MiComercio' Puede moverla o quitarla según sea necesario.
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        'TODO: esta línea de código carga datos en la tabla 'comercialDataSet.stockgeneral' Puede moverla o quitarla según sea necesario.
        Me.stockgeneralTableAdapter.Fill(Me.comercialDataSet.stockgeneral)
        stockgeneralBindingSource.Filter = ""
        Me.ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ComboBox1.SelectedValue = -1
            Me.stockgeneralTableAdapter.Fill(Me.comercialDataSet.stockgeneral)
            stockgeneralBindingSource.Filter = ""
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Excepción")
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            stockgeneralBindingSource.Filter = "rubro = '" + ComboBox1.Text + "'"
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            stockgeneralBindingSource.Filter = ""
        End Try
    End Sub
End Class