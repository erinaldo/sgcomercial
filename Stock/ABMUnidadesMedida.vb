Public Class ABMUnidadesMedida

    Private Sub UnidadesmedidaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesmedidaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UnidadesmedidaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMUnidadesMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.unidadesmedida' Puede moverla o quitarla según sea necesario.
        Me.UnidadesmedidaTableAdapter.Fill(Me.ComercialDataSet.unidadesmedida)

    End Sub
End Class