Public Class ABMGrados
    Dim autoclose As Boolean
    Private Sub GradosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GradosBindingNavigatorSaveItem.Click
        '***************************************
        Try
            If GradoTextBox.Text = "" Or Len(Trim(GradoTextBox.Text)) = 0 Then
                MessageBox.Show("Ingrese Grado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                GradoTextBox.Select()
                Return
            End If
            If DivisionTextBox.Text = "" Or Len(Trim(DivisionTextBox.Text)) = 0 Then
                MessageBox.Show("Ingrese División", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                DivisionTextBox.Select()
                Return
            End If
            If TurnoComboBox.SelectedIndex < 0 Then
                MessageBox.Show("Ingrese el Turno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TurnoComboBox.Select()
                Return
            End If
        Catch ex As Exception
            'MsgBox("Ocurrió un error: " + ex.Message)
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        If MsgBox("Seguro desea guardar los cambios realizados?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Try
                Me.Validate()
                Me.GradosBindingSource.EndEdit()
                If Not Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet) = 1 Then
                    MessageBox.Show("Ocurrió un error Verifíque los datos ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                enablefields(False)
                enabledit(False)
                'ClientesDataGridView.Enabled = True
                'filtrotextbox.Enabled = True
                If ggradoseleccionado = -1 Then
                    ggradoseleccionado = Val(IdgradoTextBox.Text)
                    Me.Close()
                End If
                If autoclose = True Then Me.Close()
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub ABMGrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.grados' Puede moverla o quitarla según sea necesario.
        'Me.GradosTableAdapter.Fill(Me.ComercialDataSet.grados)
        enablefields(False)
        enabledit(False)

    End Sub
    Public Sub enablefields(ByRef status As Boolean)
        GradoTextBox.Enabled = status
        DivisionTextBox.Enabled = status
        TurnoComboBox.Enabled = status
    End Sub
    Public Sub enabledit(ByRef status As Boolean)
        If status = True Then
            GradosBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorAddNewItem.Enabled = False
            ToolStripButtonEditar.Enabled = False
            ToolStripButtonCancelar.Enabled = True
            'ToolStripButtonEliminar.Enabled = False
            'GroupBox2.Enabled = False
        Else
            GradosBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            ToolStripButtonEditar.Enabled = True
            ToolStripButtonCancelar.Enabled = False
            'ToolStripButtonEliminar.Enabled = True
            'GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
        enabledit(True)
    End Sub
End Class