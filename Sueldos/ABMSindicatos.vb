Imports System.Text.RegularExpressions

Public Class ABMSindicatos
    Private Sub SindicatosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Try
            Me.Validate()
            Me.SindicatosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enabledit(False)
            enablefields(False)
            NavStatus(True)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ABMSindicatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.sindicatos' Puede moverla o quitarla según sea necesario.
        Me.SindicatosTableAdapter.Fill(Me.ComercialDataSet.sindicatos)
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
        NombreTextBox.Enabled = Status
        NombreTextBox.Select()
        NombreTextBox.Enabled = Status
        DireccionTextBox.Enabled = Status
        CodigopostalTextBox.Enabled = Status
        AporteporcentajeTextBox.Enabled = Status
        RetencionporcentajeTextBox.Enabled = Status
        AportemontofijoTextBox.Enabled = Status
        RetencionmontofijoTextBox.Enabled = Status
        LocalidadTextBox.Enabled = Status
        TelefonoTextBox.Enabled = Status
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

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If SindicatosBindingSource.Count = 0 Then
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
        SindicatosBindingSource.ResetBindings(True)
        'DescripcionTextBox.Text = Nothing
        Me.SindicatosTableAdapter.Fill(Me.ComercialDataSet.sindicatos)
        NavStatus(True)
    End Sub

    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        listar(True)
    End Sub
    Private Sub listar(status As Boolean)
        If status = True Then
            enabledit(False)
            enablefields(False)
            SindicatosBindingSource.ResetBindings(True)
            'DescripcionTextBox.Text = Nothing
            Me.SindicatosTableAdapter.Fill(Me.ComercialDataSet.sindicatos)
            NavStatus(True)
            GroupABM.Visible = False
            GroupListado.Visible = True
        Else
            GroupABM.Visible = True
            GroupListado.Visible = False
        End If
    End Sub

    Private Sub AporteporcentajeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AporteporcentajeTextBox.TextChanged

    End Sub

    Private Sub AporteporcentajeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AporteporcentajeTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub RetencionporcentajeTextBox_TextChanged(sender As Object, e As EventArgs) Handles RetencionporcentajeTextBox.TextChanged

    End Sub

    Private Sub RetencionporcentajeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RetencionporcentajeTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub AportemontofijoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AportemontofijoTextBox.TextChanged

    End Sub

    Private Sub AportemontofijoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AportemontofijoTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub RetencionmontofijoTextBox_TextChanged(sender As Object, e As EventArgs) Handles RetencionmontofijoTextBox.TextChanged

    End Sub

    Private Sub RetencionmontofijoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RetencionmontofijoTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ABMSindicatos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class