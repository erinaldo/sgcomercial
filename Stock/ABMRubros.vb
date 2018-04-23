Public Class ABMRubros

    Private Sub RubrosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RubrosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RubrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.rubros' Puede moverla o quitarla según sea necesario.
        Me.RubrosTableAdapter.Fill(Me.ComercialDataSet.rubros)

    End Sub
End Class