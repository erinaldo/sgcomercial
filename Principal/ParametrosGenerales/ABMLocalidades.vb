Public Class ABMLocalidades
    Private Sub LocalidadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ABMLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.ComercialDataSet.localidades)


    End Sub

    Private Sub IdprovinciaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Try
        '    LocalidadesBindingSource.Filter = "idprovincia = " + IdprovinciaComboBox.SelectedValue.ToString
        'Catch ex As Exception
        '    LocalidadesBindingSource.Filter = ""
        'End Try


    End Sub

    Private Sub LocalidadesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LocalidadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LocalidadesTableAdapter.Update(ComercialDataSet)
    End Sub
End Class