Public Class ABMMesas
    Private Sub MesasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ABMMesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.estadosai' Puede moverla o quitarla según sea necesario.
        Me.EstadosaiTableAdapter.Fill(Me.ComercialDataSet.estadosai)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.salones' Puede moverla o quitarla según sea necesario.
        Me.SalonesTableAdapter.FillByActivos(Me.ComercialDataSet.salones)
        Me.MesasTableAdapter.Fill(Me.ComercialDataSet.mesas)


        enablefields(False)
        enableedit(False)
    End Sub

    Private Sub MesasBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub MesasBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles MesasBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MesasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enablefields(False)
            enableedit(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub enablefields(ByVal status As Boolean)
        'IdmesaTextBox.Enabled = status
        IdsalonComboBox.Enabled = status
        CapacidadComboBox.Enabled = status
        EstadoComboBox.Enabled = status

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripEditar.Click
        enablefields(True)
        enableedit(True)
    End Sub
    Sub enableedit(ByVal status As Boolean)
        If status = True Then
            BindingNavigatorAddNewItem.Enabled = False
            MesasBindingNavigatorSaveItem.Enabled = True
            ToolStripEditar.Enabled = False
        Else
            BindingNavigatorAddNewItem.Enabled = True
            MesasBindingNavigatorSaveItem.Enabled = False
            ToolStripEditar.Enabled = True
        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
        enableedit(True)
    End Sub

    Private Sub ToolStripCancelar_Click(sender As Object, e As EventArgs) Handles ToolStripCancelar.Click
        Me.SalonesTableAdapter.FillByActivos(Me.ComercialDataSet.salones)
        Me.MesasTableAdapter.Fill(Me.ComercialDataSet.mesas)
        enablefields(False)
        enableedit(False)
    End Sub
End Class