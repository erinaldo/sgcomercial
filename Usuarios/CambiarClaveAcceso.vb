Public Class CambiarClaveAcceso
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub CambiarClaveAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ComercialDataSet.usuarios)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rtn As Integer
        rtn = UsuariosTableAdapter.usuarios_validar(gusername, actual.Text)
        If rtn > 0 Then
            If nueva1.Text = nueva2.Text Then
                UsuariosTableAdapter.usuarios_changepwd(nueva1.Text, gusername)
                MsgBox("Cambio realizado exitosamente!")
                Close()
            Else
                MsgBox("La contraseña nueva no coincide!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("La contraseña actual no es correcta!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub CambiarClaveAcceso_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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