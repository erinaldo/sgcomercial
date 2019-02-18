Public Class ABMPerfiles
    Private Sub ABMPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.perfiles' Puede moverla o quitarla según sea necesario.
        Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)

    End Sub

    Private Sub PerfilesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PerfilesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PerfilesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PerfilesDataGridView.CellContentClick

    End Sub

    Private Sub PerfilesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PerfilesDataGridView.CellClick

        Try
            Select Case PerfilesDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                Case "Eliminar"
                    If Not PerfilesDataGridView.Rows(e.RowIndex).Cells(0).Value = "ADMINISTRADOR" Then
                        Try
                            PerfilesTableAdapter.perfiles_deleteperfil(PerfilesDataGridView.Rows(e.RowIndex).Cells(0).Value)
                            PermisosTableAdapter.permisos_deleteperfil(PerfilesDataGridView.Rows(e.RowIndex).Cells(0).Value)
                            Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
                        Catch ex As Exception

                        End Try
                    End If
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Me.PerfilesTableAdapter.Insert(TextBox1.Text)
            Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
        Catch ex As Exception
            MsgBox("No Se pudo registrar el perfil: " + ex.Message)
        End Try

        Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PerfilesTableAdapter.Insert(TextBox1.Text)
            Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
            MsgBox("Operación exitosa!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub ABMPerfiles_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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