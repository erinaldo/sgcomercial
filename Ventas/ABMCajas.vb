Public Class ABMCajas

    Private Sub CajasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub

    Private Sub ABMCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajasestados' Puede moverla o quitarla según sea necesario.
        Me.CajasestadosTableAdapter.Fill(Me.BioaccesoDataSet.cajasestados)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.BioaccesoDataSet.cajas)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.BioaccesoDataSet.cajas)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.BioaccesoDataSet.cajas)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.BioaccesoDataSet.cajas)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.BioaccesoDataSet.cajas)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.BioaccesoDataSet.cajas)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.BioaccesoDataSet.cajas)

    End Sub

    Private Sub DescripcionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CajasBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub

    Private Sub CajasBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub

    Private Sub CajasBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub

    Private Sub CajasBindingNavigatorSaveItem_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub

    Private Sub EstadoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CajasBindingNavigatorSaveItem_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub

    Private Sub CajasBindingNavigatorSaveItem_Click_6(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CajasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub
End Class