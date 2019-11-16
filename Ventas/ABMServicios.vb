Public Class ABMServicios
    Private Sub ServiciosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ServiciosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ServiciosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enablefields(False)
            enabledit(False)
        Catch ex As Exception
            MsgBox("Ocurrió un error: " + ex.Message)
        End Try


    End Sub

    Private Sub ABMServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.ComercialDataSet.servicios)
        enablefields(False)
        enabledit(False)
    End Sub
    Private Sub enablefields(ByRef status As Boolean)
        DescripcionTextBox.Enabled = status
        PrecioventaTextBox.Enabled = status
        DiasvigenciaTextBox.Enabled = status
    End Sub
    Private Sub enabledit(ByRef status As Boolean)
        If status = True Then
            BindingNavigatorAddNewItem.Enabled = False
            ServiciosBindingNavigatorSaveItem.Enabled = True
            ToolStripButtonEditar.Enabled = False
            ToolStripButtonCancelar.Enabled = True
        Else
            BindingNavigatorAddNewItem.Enabled = True
            ServiciosBindingNavigatorSaveItem.Enabled = False
            ToolStripButtonEditar.Enabled = True
            ToolStripButtonCancelar.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButtonEditar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEditar.Click
        enablefields(True)
        enabledit(True)
    End Sub

    Private Sub ToolStripButtonCancelar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCancelar.Click
        enablefields(False)
        enabledit(False)
        ServiciosBindingSource.ResetBindings(True)
        Me.ServiciosTableAdapter.Fill(Me.ComercialDataSet.servicios)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
        enabledit(True)
    End Sub
End Class