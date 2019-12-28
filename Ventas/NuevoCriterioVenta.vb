Public Class NuevoCriterioVenta
    Private Sub CriteriosventaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CriteriosventaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub NuevoCriterioVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gidCriterioSeleccionado = 0 Then
            ButtonConfirmar.Enabled = True
            ButtonFinalizar.Enabled = False
            enableGroups(False)
        Else
            ButtonConfirmar.Enabled = False
            ButtonFinalizar.Enabled = True
            Me.CriteriosventaTableAdapter.Fill(Me.ComercialDataSet.criteriosventa)
            Me.CriteriosventaproductosTableAdapter.Fill(Me.ComercialDataSet.criteriosventaproductos)
        End If

    End Sub
    Private Sub enableGroups(ByRef status As Boolean)
        GroupBoxProductos.Enabled = status
        GroupBoxRangos.Enabled = status
        GroupBoxRegalos.Enabled = status
    End Sub

    Private Sub ButtonConfirmar_Click(sender As Object, e As EventArgs) Handles ButtonConfirmar.Click
        Dim descripcion As String
        Dim fechadesde As Date
        Dim fechahasta As Date
        Dim cantidadtotal As Decimal
        Dim cantidadmaxima As Decimal
        Try
            descripcion = DescripcionTextBox.Text
            fechadesde = FechadesdeDateTimePicker.Value
            fechahasta = FechahastaDateTimePicker.Value
            cantidadtotal = Convert.ToDecimal(CantidaddisponibletotalTextBox.Text)
            cantidadmaxima = Convert.ToDecimal(CantidadmaximaporclienteTextBox.Text)
            CriteriosventaTableAdapter.criteriosventa_insertar(descripcion, fechadesde, fechahasta, cantidadtotal, cantidadmaxima)
            MsgInfo("Operación Exitosa!")
            ButtonConfirmar.Enabled = False
            ButtonFinalizar.Enabled = True
            enableGroups(True)
        Catch ex As Exception
            MsgExcl("No se pudo completar la operación: " + ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim kl As New SeleccionarProductoCantidadGenerico()
        gcodigoproducto = Nothing
        gcantidad = Nothing
        kl.ShowDialog()
        If gcodigoproducto <> Nothing And gcantidad <> Nothing Then
            MsgInfo("iNSERTAR PROD")
        End If
    End Sub
End Class