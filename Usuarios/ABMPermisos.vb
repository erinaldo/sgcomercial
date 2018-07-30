Public Class ABMPermisos
    Private Sub PermisosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PermisosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.perfiles' Puede moverla o quitarla según sea necesario.
        Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.funciones' Puede moverla o quitarla según sea necesario.
        Me.FuncionesTableAdapter.FillByActivas(Me.ComercialDataSet.funciones)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.permisos' Puede moverla o quitarla según sea necesario.
        Me.PermisosTableAdapter.Fill(Me.ComercialDataSet.permisos)
        LabelTotalFunciones.Text = FuncionesDataGridView.RowCount.ToString

        PermisosBindingSource.Filter = "idperfil= '" + ComboBox1.Text + "'"
    End Sub

    'Private Sub FuncionesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FuncionesDataGridView.CellContentClick

    'End Sub

    Private Sub FuncionesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FuncionesDataGridView.CellClick
        Try
            Select Case e.ColumnIndex
                Case 3
                    'MsgBox("agrega funcion")
                    Dim existe As Integer = 0
                    existe = PermisosTableAdapter.permisos_consultabyidfuncion(ComboBox1.Text, FuncionesDataGridView.Rows(e.RowIndex).Cells(0).Value)
                    If existe = 0 Then
                        PermisosTableAdapter.permisos_insert(FuncionesDataGridView.Rows(e.RowIndex).Cells(0).Value, ComboBox1.Text, Today, guserid, FuncionesDataGridView.Rows(e.RowIndex).Cells(2).Value)
                        Me.PermisosTableAdapter.Fill(Me.ComercialDataSet.permisos)
                        PermisosBindingSource.Filter = "idperfil= '" + ComboBox1.Text + "'"
                    Else
                        MsgBox("El perfil ya tiene habilitada la funcion seleccionada!", MsgBoxStyle.Exclamation, "Advertencia")
                    End If

                    'Me.PermisosTableAdapter.Fill(Me.ComercialDataSet.permisos)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub PermisosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PermisosDataGridView.CellContentClick

    End Sub

    Private Sub PermisosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PermisosDataGridView.CellClick
        Try
            Select Case e.ColumnIndex
                Case 5
                    'MsgBox("elimina funcion")
                    'MsgBox(PermisosDataGridView.Rows(e.RowIndex).Cells("idpermisos").Value.ToString)
                    PermisosTableAdapter.permisos_eliminar(PermisosDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn1").Value)
                    Me.PermisosTableAdapter.Fill(Me.ComercialDataSet.permisos)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PermisosDataGridView_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles PermisosDataGridView.RowStateChanged
        LabelTotalPermisos.Text = PermisosDataGridView.RowCount.ToString
    End Sub

    Private Sub PermisosDataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles PermisosDataGridView.RowsRemoved

    End Sub

    Private Sub FuncionesDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles FuncionesDataGridView.RowsAdded
        LabelTotalFunciones.Text = FuncionesDataGridView.RowCount.ToString
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        PermisosBindingSource.Filter = "idperfil= '" + ComboBox1.Text + "'"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex < 0 Then
            MsgBox("Seleccione un perfil", MsgBoxStyle.Exclamation)
            Return
        End If
        '******************************* ASIGNACION MASIVA *******************************
        For i = 0 To FuncionesDataGridView.RowCount - 1
            Dim existe As Integer = 0
            existe = PermisosTableAdapter.permisos_consultabyidfuncion(ComboBox1.Text, FuncionesDataGridView.Rows(i).Cells(0).Value)
            If existe = 0 Then
                PermisosTableAdapter.permisos_insert(FuncionesDataGridView.Rows(i).Cells(0).Value, ComboBox1.Text, Today, guserid, FuncionesDataGridView.Rows(i).Cells(2).Value)
            Else
                'MsgBox("El perfil ya tiene habilitada la funcion seleccionada!", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        Next
        Me.PermisosTableAdapter.Fill(Me.ComercialDataSet.permisos)
        '******************************* ASIGNACION MASIVA *******************************
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex < 0 Then
            MsgBox("Seleccione un perfil", MsgBoxStyle.Exclamation)
            Return
        End If
        '********************* ELIMINAR MASIVA
        For i = 0 To PermisosDataGridView.RowCount - 1
            PermisosTableAdapter.permisos_eliminar(PermisosDataGridView.Rows(i).Cells(0).Value)
        Next
        Me.PermisosTableAdapter.Fill(Me.ComercialDataSet.permisos)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            FuncionesBindingSource.Filter = "descripcion like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            FuncionesBindingSource.Filter = ""
        End Try

    End Sub
End Class