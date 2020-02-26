Public Class StkMovimientos
    Private Sub StkMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.stkmovimientos' Puede moverla o quitarla según sea necesario.
        StkmovimientosTableAdapter.FillByRangoFechas(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString, DPHasta.Value.ToString)
        ComboBoxFiltro.SelectedIndex = 0
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DPDesde.ValueChanged


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Or Len(Trim(TextBox1.Text)) = 0 Then
            StkmovimientosBindingSource.Filter = ""
        Else
            Filtrar()
        End If
    End Sub
    Private Sub Filtrar()
        Try
            Select Case ComboBoxFiltro.SelectedIndex
                Case 0
                    StkmovimientosBindingSource.Filter = "codigoproducto Like '" + TextBox1.Text + "'"
                Case 1
                    StkmovimientosBindingSource.Filter = "producto Like '%" + TextBox1.Text + "%'"
            End Select
        Catch ex As Exception
            StkmovimientosBindingSource.Filter = ""
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
            DPHasta.Enabled = False
            BtnConsultar.Enabled = False
            Try
                StkmovimientosTableAdapter.Fill(Me.ComercialDataSet.stkmovimientos)
            Catch ex As Exception
                MsgBox("Ocurrió una excepción durante la consulta:" + ex.Message)
            End Try
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            DPDesde.Enabled = True
            DPHasta.Enabled = True
            BtnConsultar.Enabled = True
            Try
                StkmovimientosTableAdapter.FillByRangoFechas(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString, DPHasta.Value.ToString)
            Catch ex As Exception
                MsgBox("Ocurrió una excepción durante la consulta:" + ex.Message)
            End Try
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StkmovimientosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StkmovimientosDataGridView.CellContentClick

    End Sub

    Private Sub StkmovimientosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StkmovimientosDataGridView.CellClick
        Try
            If e.RowIndex = -1 And e.ColumnIndex = -1 Then
                StkmovimientosTableAdapter.FillByRangoFechas(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString, DPHasta.Value.ToString)
            End If
            Select Case StkmovimientosDataGridView.Columns(e.ColumnIndex).Name
                Case "codigoproducto"
                    ComboBoxFiltro.SelectedIndex = 0
                    TextBox1.Text = StkmovimientosDataGridView.Rows(e.RowIndex).Cells("codigoproducto").Value
                    Filtrar()
            End Select
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

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContextMenuStripGrilla_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripGrilla.Opening

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        TextBox1.Text = Nothing
        StkmovimientosTableAdapter.FillByRangoFechas(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString, DPHasta.Value.ToString)
        RadioButton2.Checked = True

        MsgBox("Grilla Actualizada!", MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs)


    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DPHasta_ValueChanged(sender As Object, e As EventArgs) Handles DPHasta.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            StkmovimientosTableAdapter.FillByRangoFechas(Me.ComercialDataSet.stkmovimientos, DPDesde.Value.ToString, DPHasta.Value.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class