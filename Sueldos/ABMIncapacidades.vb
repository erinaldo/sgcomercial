Public Class ABMIncapacidades
    Private Sub IncapacidadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Try
            Me.Validate()
            Me.IncapacidadesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enabledit(False)
            enablefields(False)
            NavStatus(True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ABMIncapacidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.incapacidades' Puede moverla o quitarla según sea necesario.
        Me.IncapacidadesTableAdapter.Fill(Me.ComercialDataSet.incapacidades)
        enabledit(False)
        enablefields(False)
        NavStatus(True)
    End Sub
    Private Sub enabledit(Status As Boolean)
        If Status = False Then
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
    Private Sub enablefields(Status As Boolean)
        DescripcionTextBox.Enabled = Status
        DescripcionTextBox.Select()
    End Sub
    Private Sub NavStatus(status As Boolean)
        BindingNavigatorMoveFirstItem.Enabled = status
        BindingNavigatorMovePreviousItem.Enabled = status
        BindingNavigatorMoveNextItem.Enabled = status
        BindingNavigatorMoveLastItem.Enabled = status
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        NavStatus(False)
        enabledit(True)
        enablefields(True)
    End Sub

    Private Sub BtnNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        NavStatus(False)
        enabledit(True)
        enablefields(True)
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If IncapacidadesBindingSource.Count = 0 Then
            MsgExPopUp("No hay registros para editar")
            Return
        End If
        enabledit(True)
        enablefields(True)
        NavStatus(False)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        enabledit(False)
        enablefields(False)
        IncapacidadesBindingSource.ResetBindings(True)
        'DescripcionTextBox.Text = Nothing
        Me.IncapacidadesTableAdapter.Fill(Me.ComercialDataSet.incapacidades)
        NavStatus(True)
    End Sub

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        listar(True)
    End Sub
    Private Sub listar(status As Boolean)
        If status = True Then
            enabledit(False)
            enablefields(False)
            IncapacidadesBindingSource.ResetBindings(True)
            'DescripcionTextBox.Text = Nothing
            Me.IncapacidadesTableAdapter.Fill(Me.ComercialDataSet.incapacidades)
            NavStatus(True)
            GroupABM.Visible = False
            GroupListado.Visible = True
        Else
            GroupABM.Visible = True
            GroupListado.Visible = False
        End If
    End Sub

    Private Sub ABMIncapacidades_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class