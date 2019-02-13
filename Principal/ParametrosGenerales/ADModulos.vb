Public Class ADModulos
    Private Sub ModulosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ModulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ADModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.modulos' Puede moverla o quitarla según sea necesario.
        Me.ModulosTableAdapter.Fill(Me.ComercialDataSet.modulos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.modulos' Puede moverla o quitarla según sea necesario.
        Me.ModulosTableAdapter.Fill(Me.ComercialDataSet.modulos)

    End Sub

    Private Sub ModulosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ModulosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ModulosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class