Public Class ABMListasprecios
    Private Sub ListaspreciosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ListaspreciosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ListaspreciosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMListasprecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listasprecios' Puede moverla o quitarla según sea necesario.
        Me.ListaspreciosTableAdapter.Fill(Me.ComercialDataSet.listasprecios)

    End Sub
End Class