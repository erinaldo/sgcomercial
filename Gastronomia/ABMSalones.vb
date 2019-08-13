Public Class ABMSalones
    Private Sub SalonesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SalonesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SalonesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            MsgBox("Operación exitosa!", MsgBoxStyle.Information)
            enablefields(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ABMSalones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.estadosai' Puede moverla o quitarla según sea necesario.
        Me.EstadosaiTableAdapter.Fill(Me.ComercialDataSet.estadosai)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.salones' Puede moverla o quitarla según sea necesario.
        Me.SalonesTableAdapter.Fill(Me.ComercialDataSet.salones)
        enablefields(False)
    End Sub
    Private Sub enablefields(ByVal status As Boolean)
        DescripcionTextBox.Enabled = status
        EstadoComboBox.Enabled = status
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
    End Sub
End Class