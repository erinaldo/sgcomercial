Public Class ABMTransportes
    Private Sub TransportesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TransportesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransportesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMTransportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.transportes' Puede moverla o quitarla según sea necesario.
        Me.TransportesTableAdapter.Fill(Me.ComercialDataSet.transportes)

    End Sub
End Class