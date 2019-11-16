Public Class ABMAlumnos
    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AlumnosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
        enablefields(False)
        enabledit(False)
    End Sub

    Private Sub ABMAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipodocumentos' Puede moverla o quitarla según sea necesario.
        Me.TipodocumentosTableAdapter.Fill(Me.ComercialDataSet.tipodocumentos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.ComercialDataSet.alumnos)
        enablefields(False)
        enabledit(False)
    End Sub
    Private Sub enabledit(ByRef status As Boolean)
        If status = True Then
            AlumnosBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorAddNewItem.Enabled = False
            ToolStripButtonEditar.Enabled = False
            ToolStripButtonCancelar.Enabled = True
        Else
            AlumnosBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            ToolStripButtonEditar.Enabled = True
            ToolStripButtonCancelar.Enabled = False
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
    End Sub

    Private Sub ToolStripButtonEditar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEditar.Click
        enablefields(True)
        enabledit(True)
    End Sub

    Private Sub ToolStripButtonCancelar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCancelar.Click
        enablefields(False)
        enabledit(False)
    End Sub
End Class