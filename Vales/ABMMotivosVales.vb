Public Class ABMMotivosVales
    Private Sub TipomotivosvalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TipomotivosvalesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TipomotivosvalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMMotivosVales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipomotivosvales' Puede moverla o quitarla según sea necesario.
        Me.TipomotivosvalesTableAdapter.Fill(Me.ComercialDataSet.tipomotivosvales)
        If Not gusername = "lucasmartinbs" Then
            BindingNavigatorDeleteItem.Enabled = False
        End If
    End Sub
End Class