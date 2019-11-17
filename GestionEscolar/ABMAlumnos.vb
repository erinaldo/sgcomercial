Public Class ABMAlumnos
    Dim autoclose As Boolean
    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AlumnosBindingNavigatorSaveItem.Click
        '***************************************
        Try
            If NombreTextBox.Text = "" Or Len(Trim(NombreTextBox.Text)) = 0 Then
                MessageBox.Show("Ingrese el nombre del alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                NombreTextBox.Select()
                Return
            End If
            If FechanacimientoDateTimePicker.Value = Today Then
                MessageBox.Show("Ingrese Fecha de Nacimiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                FechanacimientoDateTimePicker.Select()
                Return
            End If
            If IdtipodocumentoComboBox.SelectedIndex < 0 Then
                MessageBox.Show("Ingrese el TIPO de documento del alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                IdtipodocumentoComboBox.Select()
                Return
            End If
            If DocumentoTextBox.Text = "" Or Len(Trim(DocumentoTextBox.Text)) = 0 Then
                MessageBox.Show("Ingrese el documento del alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                DocumentoTextBox.Select()
                Return
            End If
        Catch ex As Exception
            'MsgBox("Ocurrió un error: " + ex.Message)
            MessageBox.Show("Ocurrió un error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        If MsgBox("Seguro desea guardar los cambios realizados?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Try
                Me.Validate()
                Me.AlumnosBindingSource.EndEdit()
                If Not Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet) = 1 Then
                    MessageBox.Show("Ocurrió un error Verifíque los datos ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                enablefields(False)
                enabledit(False)
                'ClientesDataGridView.Enabled = True
                'filtrotextbox.Enabled = True
                If galumnoseleccionado = -1 Then
                    galumnoseleccionado = Val(IdalumnoTextBox.Text)
                    Me.Close()
                End If
                If autoclose = True Then Me.Close()
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub ABMAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipodocumentos' Puede moverla o quitarla según sea necesario.
        Me.TipodocumentosTableAdapter.Fill(Me.ComercialDataSet.tipodocumentos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.ComercialDataSet.alumnos)
        enablefields(False)
        enabledit(False)
        '--/**********************************************/
        If galumnoseleccionado = -1 Then
            BindingNavigatorAddNewItem.PerformClick()
        End If
        If galumnoseleccionado > 1 Then
            autoclose = True
            AlumnosTableAdapter.FillByIdalumno(Me.ComercialDataSet.alumnos, galumnoseleccionado)
            ToolStripButtonEditar.PerformClick()
        End If
        'ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub enabledit(ByRef status As Boolean)
        If status = True Then
            AlumnosBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorAddNewItem.Enabled = False
            ToolStripButtonEditar.Enabled = False
            ToolStripButtonCancelar.Enabled = True
            ToolStripButtonEliminar.Enabled = False
            GroupBox2.Enabled = False
        Else
            AlumnosBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            ToolStripButtonEditar.Enabled = True
            ToolStripButtonCancelar.Enabled = False
            ToolStripButtonEliminar.Enabled = True
            GroupBox2.Enabled = True
        End If

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
    Private Sub enablefields(ByRef status As Boolean)
        NombreTextBox.Enabled = status
        FechanacimientoDateTimePicker.Enabled = status
        IdtipodocumentoComboBox.Enabled = status
        DocumentoTextBox.Enabled = status
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
        enabledit(True)
        FechanacimientoDateTimePicker.Value = Today
    End Sub

    Private Sub ToolStripButtonEditar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEditar.Click
        enablefields(True)
        enabledit(True)
    End Sub

    Private Sub ToolStripButtonCancelar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCancelar.Click
        enablefields(False)
        enabledit(False)
        AlumnosBindingSource.ResetBindings(True)
        Me.AlumnosTableAdapter.Fill(Me.ComercialDataSet.alumnos)
    End Sub

    Private Sub ToolStripButtonEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEliminar.Click
        If MessageBox.Show("Seguro desea dar de baja el alumno?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                AlumnosTableAdapter.alumnos_baja(Today, gusername, Val(IdalumnoTextBox.Text))
                Me.AlumnosTableAdapter.Fill(Me.ComercialDataSet.alumnos)
            Catch ex As Exception
                MessageBox.Show("Ocurrió un problema al tratar de eliminar el alumno: " + ex.Message, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles filtrotextbox.TextChanged
        Try
            AlumnosBindingSource.Filter = "nombre like '%" + filtrotextbox.Text + "%'"
        Catch ex As Exception
            AlumnosBindingSource.Filter = ""
        End Try
    End Sub
End Class