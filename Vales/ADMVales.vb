Public Class ADMVales
    Private Sub ValesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ValesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ADMVales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.vales' Puede moverla o quitarla según sea necesario.
        Me.ValesTableAdapter.Fill(Me.ComercialDataSet.vales)

    End Sub
End Class