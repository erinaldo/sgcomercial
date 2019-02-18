Public Class ABMTiposIVA
    Private Sub TipoivaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TipoivaBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TipoivaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enablebuttons(False)
            enabledit(False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ABMTiposIVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipoestados' Puede moverla o quitarla según sea necesario.
        Me.TipoestadosTableAdapter.Fill(Me.ComercialDataSet.tipoestados)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipoiva' Puede moverla o quitarla según sea necesario.
        Me.TipoivaTableAdapter.Fill(Me.ComercialDataSet.tipoiva)
        enablebuttons(False)
        enabledit(False)
    End Sub
    Private Sub enabledit(ByRef status As Boolean)
        If status = True Then
            BindingNavigatorAddNewItem.Visible = False
            TipoivaBindingNavigatorSaveItem.Visible = True
            ToolStripButton1.Visible = False
        Else
            BindingNavigatorAddNewItem.Visible = True
            TipoivaBindingNavigatorSaveItem.Visible = False
            ToolStripButton1.Visible = True
        End If

    End Sub

    Private Sub enablebuttons(ByRef status As Boolean)
        AlicuotaTextBox.Enabled = status
        DescripcionTextBox.Enabled = status
        EstadoComboBox.Enabled = status
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enabledit(True)
        enablebuttons(True)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Len(AlicuotaTextBox.Text) > 0 Then
            enablebuttons(True)
            enabledit(True)
        End If
    End Sub

    Private Sub ABMTiposIVA_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F12 Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class