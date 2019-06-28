Public Class ABMTipoComprobantes
    Private Sub TipocomprobantesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TipocomprobantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TipocomprobantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMTipoComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipocomprobantes' Puede moverla o quitarla según sea necesario.
        Me.TipocomprobantesTableAdapter.Fill(Me.ComercialDataSet.tipocomprobantes)

    End Sub
End Class