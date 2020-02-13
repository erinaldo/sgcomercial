Public Class ABMGruposJerarquicos
    Private Sub GruposjerarquicosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Me.Validate()
            Me.GruposjerarquicosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enabledit(False)
            enablefields(False)
            NavStatus(True)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ABMGruposJerarquicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.gruposjerarquicos' Puede moverla o quitarla según sea necesario.
        Me.GruposjerarquicosTableAdapter.Fill(Me.ComercialDataSet.gruposjerarquicos)
        enabledit(False)
        enablefields(False)
    End Sub
    Private Sub enabledit(status As Boolean)
        If status = False Then
            BtnNuevo.Enabled = True
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False
            BtnEditar.Enabled = True
        Else
            BtnNuevo.Enabled = False
            BtnCancelar.Enabled = True
            BtnGuardar.Enabled = True
            BtnEditar.Enabled = False
            GroupABM.Visible = True
            GroupListado.Visible = False
        End If

    End Sub
    Private Sub enablefields(status As Boolean)

        DescripcionTextBox.Enabled = status
        DescripcionTextBox.Select()
    End Sub
    Private Sub NavStatus(ByRef status As Boolean)
        NavFirst.Enabled = status
        NavLast.Enabled = status
        NavPrev.Enabled = status
        NavNext.Enabled = status
    End Sub



    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        enabledit(True)
        enablefields(True)
        NavStatus(False)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        enabledit(False)
        enablefields(False)
        GruposjerarquicosBindingSource.ResetBindings(True)
        DescripcionTextBox.Text = Nothing
        Me.GruposjerarquicosTableAdapter.Fill(Me.ComercialDataSet.gruposjerarquicos)
        NavStatus(True)
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If GruposjerarquicosBindingSource.Count = 0 Then
            MsgExPopUp("No hay registros para editar")
            Return
        End If

        enabledit(True)
        enablefields(True)
        NavStatus(False)
    End Sub

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        listar(True)
    End Sub

    Private Sub listar(status As Boolean)
        If status = True Then
            enabledit(False)
            enablefields(False)
            GruposjerarquicosBindingSource.ResetBindings(True)
            DescripcionTextBox.Text = Nothing
            Me.GruposjerarquicosTableAdapter.Fill(Me.ComercialDataSet.gruposjerarquicos)
            NavStatus(True)
            GroupABM.Visible = False
            GroupListado.Visible = True
        Else
            GroupABM.Visible = True
            GroupListado.Visible = False
        End If
    End Sub

    Private Sub ABMGruposJerarquicos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class