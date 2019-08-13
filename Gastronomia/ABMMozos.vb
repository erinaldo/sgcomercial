Public Class ABMMozos
    Private Sub MozosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MozosBindingNavigatorSaveItem.Click
        If Len(Trim(NombreTextBox.Text)) = 0 Then
            MsgBox("Ingrese un Nombre Válido!")
            Return
        End If
        Try
            Me.Validate()
            Me.MozosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enablefields(False)
            enableedit(False)
            MsgBox("Operación exitosa!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ABMMozos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.estadosai' Puede moverla o quitarla según sea necesario.
        Me.EstadosaiTableAdapter.Fill(Me.ComercialDataSet.estadosai)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.mozos' Puede moverla o quitarla según sea necesario.
        Me.MozosTableAdapter.Fill(Me.ComercialDataSet.mozos)
        enablefields(False)
        enableedit(False)
    End Sub
    Sub enablefields(ByVal status As Boolean)
        'IdmozoTextBox.Enabled = status
        NombreTextBox.Enabled = status
        EstadoComboBox.Enabled = status
    End Sub
    Sub enableedit(ByRef status As Boolean)
        If status = True Then
            BindingNavigatorAddNewItem.Enabled = False
            MozosBindingNavigatorSaveItem.Enabled = True
            ToolStripEditar.Enabled = False
            BindingNavigatorMovePreviousItem.Visible = False
            BindingNavigatorMoveNextItem.Visible = False
        Else
            BindingNavigatorAddNewItem.Enabled = True
            MozosBindingNavigatorSaveItem.Enabled = False
            ToolStripEditar.Enabled = True
            BindingNavigatorMovePreviousItem.Visible = True
            BindingNavigatorMoveNextItem.Visible = True
        End If

    End Sub

    Private Sub ToolStripEditar_Click(sender As Object, e As EventArgs) Handles ToolStripEditar.Click
        enablefields(True)
        enableedit(True)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        enablefields(False)
        enableedit(False)
        Me.MozosTableAdapter.Fill(Me.ComercialDataSet.mozos)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
        enableedit(True)
    End Sub
End Class