Public Class LibroVentasCanceladas
    Private Sub LibroVentasCanceladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroventascanceladas' Puede moverla o quitarla según sea necesario.
        Me.LibroventascanceladasTableAdapter.Fill(Me.ComercialDataSet.libroventascanceladas)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.auventascanceladas' Puede moverla o quitarla según sea necesario.
        'Me.AuventascanceladasTableAdapter.Fill(Me.ComercialDataSet.auventascanceladas)

    End Sub

    Private Sub AuventascanceladasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.AuventascanceladasBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fechadesde As Date
        Dim fechahasta As Date

        Try
            fechadesde = Convert.ToDateTime(DateTimeDesde.Value)
            fechahasta = Convert.ToDateTime(DateTimeHasta.Value)
            Me.LibroventascanceladasTableAdapter.FillByRangoFechas(Me.ComercialDataSet.libroventascanceladas, fechadesde, fechahasta)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class