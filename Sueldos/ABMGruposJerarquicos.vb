Public Class ABMGruposJerarquicos
    Private Sub GruposjerarquicosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GruposjerarquicosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GruposjerarquicosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMGruposJerarquicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.gruposjerarquicos' Puede moverla o quitarla según sea necesario.
        Me.GruposjerarquicosTableAdapter.Fill(Me.ComercialDataSet.gruposjerarquicos)

    End Sub
    Private Sub enabledit(status As Boolean)

    End Sub
    Private Sub enablefields(status As Boolean)

    End Sub
End Class