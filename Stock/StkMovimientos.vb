Public Class StkMovimientos
    Private Sub StkMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stkmovimientos' Puede moverla o quitarla según sea necesario.
        StkmovimientosTableAdapter.FillByFecha(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DPDesde.ValueChanged
        Try
            StkmovimientosTableAdapter.FillByFecha(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            StkmovimientosBindingSource.Filter = "codigoproducto Like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            StkmovimientosBindingSource.Filter = "tipomovimiento Like ''"
        End Try
    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gcodigoproducto = 0
        'LabelDescripcion.Text = Nothing
        'gproductodescripcion = Nothing
        BuscarCodigoInterno.ShowDialog()
        If Len(Trim(gcodigoproducto)) > 0 And gcodigoproducto <> "0" Then
            TextBox1.Text = gcodigoproducto.ToString
            'LabelDescripcion.Text = gproductodescripcion
            'BtnImprimir.PerformClick()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            DPDesde.Enabled = False
            Try
                'StkmovimientosTableAdapter.FillByFecha(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString)
                StkmovimientosTableAdapter.Fill(Me.ComercialDataSet.stkmovimientos)
            Catch ex As Exception
                MsgBox("Ocurrió una excepción durante la consulta:" + ex.Message)
            End Try
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            DPDesde.Enabled = True
            Try
                StkmovimientosTableAdapter.FillByFecha(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString)
            Catch ex As Exception
                MsgBox("Ocurrió una excepción durante la consulta:" + ex.Message)
            End Try
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        StkmovimientosTableAdapter.FillByFecha(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString)
        RadioButton2.Checked = True
    End Sub

    Private Sub StkmovimientosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StkmovimientosDataGridView.CellContentClick

    End Sub

    Private Sub StkmovimientosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StkmovimientosDataGridView.CellClick
        Try
            If e.RowIndex = -1 And e.ColumnIndex = -1 Then
                StkmovimientosTableAdapter.FillByFecha(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StkMovimientos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
End Class