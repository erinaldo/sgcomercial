Public Class ABMSalones
    Private Sub SalonesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SalonesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalonesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMSalones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.estadosai' Puede moverla o quitarla según sea necesario.
        Me.EstadosaiTableAdapter.Fill(Me.ComercialDataSet.estadosai)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.salones' Puede moverla o quitarla según sea necesario.
        Me.SalonesTableAdapter.Fill(Me.ComercialDataSet.salones)

    End Sub
End Class