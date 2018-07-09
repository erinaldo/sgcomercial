Public Class ABMProvincias
    Private Sub ProvinciasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProvinciasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ProvinciasBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ProvinciasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProvinciasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMProvincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)

    End Sub
End Class