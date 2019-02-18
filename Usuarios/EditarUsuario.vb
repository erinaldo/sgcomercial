Public Class EditarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Len(Trim(username.Text)) > 0 And Len(Trim(password.Text)) > 0 Then
            Try
                If UsuariosTableAdapter.usuarios_existe(username.Text, gUsuarioSeleccionado) > 0 Then
                    MsgBox("El nombre de usuario ya existe!", MsgBoxStyle.Exclamation, "Advertencia")
                    Return
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
            Try

                UsuariosTableAdapter.usuarios_update(username.Text, password.Text, ComboBox1.Text, gUsuarioSeleccionado)
                Me.Close()
            Catch ex As Exception
                MsgBox("No se pudo completar la actualización: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub EditarUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub EditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.perfiles' Puede moverla o quitarla según sea necesario.
        Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Try
            Me.UsuariosTableAdapter.FillByidusuario(Me.ComercialDataSet.usuarios, gUsuarioSeleccionado)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub
End Class