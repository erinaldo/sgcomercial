Public Class ABMServicios
    Private Sub ServiciosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ServiciosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ServiciosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.ComercialDataSet.servicios)

    End Sub
End Class