Public Class ABMGrados
    Private Sub GradosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GradosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GradosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMGrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.grados' Puede moverla o quitarla según sea necesario.
        Me.GradosTableAdapter.Fill(Me.ComercialDataSet.grados)

    End Sub
End Class