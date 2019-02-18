Public Class ABMUsuarios
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click

        UsuariosDataGridView.Rows(UsuariosDataGridView.CurrentRow.Index).Cells(3).Value = Today.ToShortTimeString
        UsuariosDataGridView.Rows(UsuariosDataGridView.CurrentRow.Index).Cells(10).Value = guserid
        UsuarioaltaTextBox.Text = guserid.ToString
        Try

            Me.Validate()
            Me.UsuariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            UsuariosDataGridView.Enabled = True

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar guardar el usuario: " + ex.Message, MsgBoxStyle.Exclamation, "Advertencia")
        End Try


    End Sub

    Private Sub ABMUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.perfiles' Puede moverla o quitarla según sea necesario.
        Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.FillByUsuarios(Me.ComercialDataSet.usuarios)
        enablebuttons(False)
    End Sub
    Private Sub enablebuttons(ByVal status As Boolean)
        UsernameTextBox.Enabled = status
        PasswordTextBox.Enabled = status
        IdperfilComboBox.Enabled = status
        UsernameTextBox.Select()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        UsuariosDataGridView.Enabled = False
        enablebuttons(True)

    End Sub

    Private Sub UsuariosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellContentClick

    End Sub

    Private Sub UsuariosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellClick
        Select Case e.ColumnIndex
            Case 8
                If MsgBox("Seguro desea dar de baja el usuario?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                    UsuariosTableAdapter.usuarios_bajausuario(guserid, UsuariosDataGridView.Rows(e.RowIndex).Cells(0).Value)
                    Me.UsuariosTableAdapter.FillByUsuarios(Me.ComercialDataSet.usuarios)
                End If
            Case 9
                If MsgBox("Seguro desea reactivar el usuario?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                    Dim rtn As String
                    rtn = UsuariosTableAdapter.usuarios_reactivar(guserid, UsuariosDataGridView.Rows(e.RowIndex).Cells(1).Value)
                    'MsgBox(rtn)
                    Me.UsuariosTableAdapter.FillByUsuarios(Me.ComercialDataSet.usuarios)
                End If
            Case 11
                'If MsgBox("Seguro desea reactivar el usuario?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                '    Dim rtn As String
                '    rtn = UsuariosTableAdapter.usuarios_reactivar(guserid, UsuariosDataGridView.Rows(e.RowIndex).Cells(1).Value)
                '    'MsgBox(rtn)
                '    Me.UsuariosTableAdapter.FillByUsuarios(Me.ComercialDataSet.usuarios)
                'End If
                Dim p As EditarUsuario
                p = New EditarUsuario
                gUsuarioSeleccionado = UsuariosDataGridView.Rows(e.RowIndex).Cells(0).Value
                p.ShowDialog()

                Me.UsuariosTableAdapter.FillByUsuarios(Me.ComercialDataSet.usuarios)
                gUsuarioSeleccionado = Nothing
        End Select
    End Sub

    Private Sub ABMUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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