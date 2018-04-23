Public Class ABMSucursales
    Private Sub SucursalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub SucursalesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles SucursalesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.ComercialDataSet.sucursales)

    End Sub
End Class