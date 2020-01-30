Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class NuevoCriterioVenta
    Dim inserted As Long
    Private Sub CriteriosventaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CriteriosventaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub NuevoCriterioVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If gidCriterioSeleccionado = 0 Then
                ButtonConfirmar.Enabled = True
                ButtonFinalizar.Enabled = False
                enableGroups(False)
                CriteriosventaTableAdapter.FillByIDCriterioventa(Me.ComercialDataSet.criteriosventa, 0)
                CriteriosventaproductosTableAdapter.FillByIDCriteriosVenta(Me.ComercialDataSet.criteriosventaproductos, 0)
                CriteriosventarangosTableAdapter.FillByidcriterioventa(Me.ComercialDataSet.criteriosventarangos, 0)
                CriteriosventaregalorangoTableAdapter.FillByidrangocriterioventa(Me.ComercialDataSet.criteriosventaregalorango, 0)
            Else
                ButtonConfirmar.Enabled = False
                ButtonFinalizar.Enabled = True

                CriteriosventaTableAdapter.FillByIDCriterioventa(Me.ComercialDataSet.criteriosventa, gidCriterioSeleccionado)
                CriteriosventaproductosTableAdapter.FillByIDCriteriosVenta(Me.ComercialDataSet.criteriosventaproductos, gidCriterioSeleccionado)
                CriteriosventarangosTableAdapter.FillByidcriterioventa(Me.ComercialDataSet.criteriosventarangos, gidCriterioSeleccionado)
                enableGroups(True)
            End If
        Catch ex As Exception
            MsgEx("No se pudo completar la operación: " + ex.Message)
        End Try



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
            Try
                cantidadtotal = Convert.ToDecimal(CantidaddisponibletotalTextBox.Text)
            Catch ex As Exception
                cantidadtotal = 9999999999
            End Try
            Try
                cantidadmaxima = Convert.ToDecimal(CantidadmaximaporclienteTextBox.Text)
            Catch ex As Exception
                cantidadmaxima = 9999999999
            End Try
            inserted = CriteriosventaTableAdapter.criteriosventa_insertar(descripcion, fechadesde, fechahasta, cantidadtotal, cantidadmaxima)
            gidCriterioSeleccionado = inserted
            CriteriosventaTableAdapter.FillByIDCriterioventa(Me.ComercialDataSet.criteriosventa, gidCriterioSeleccionado)
            'MsgInfo("Operación Exitosa!")
            ButtonConfirmar.Enabled = False
            ButtonFinalizar.Enabled = True
            enableGroups(True)
        Catch ex As Exception
            MsgEx("No se pudo completar la operación: " + ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim kl As SeleccionarProductoCantidadGenerico
        kl = New SeleccionarProductoCantidadGenerico()
        gcodigoproducto = Nothing
        gcantidad = Nothing
        kl.ShowDialog()
        If gcodigoproducto <> Nothing And gcantidad <> Nothing Then
            CriteriosventaproductosTableAdapter.criteriosventaproductos_insertar(gcodigoproducto, gcantidad, gidCriterioSeleccionado)
            CriteriosventaproductosTableAdapter.FillByIDCriteriosVenta(Me.ComercialDataSet.criteriosventaproductos, gidCriterioSeleccionado)
        End If
    End Sub

    Private Sub CriteriosventaproductosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CriteriosventaproductosDataGridView.CellContentClick

    End Sub

    Private Sub CriteriosventaproductosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CriteriosventaproductosDataGridView.CellClick
        Try
            Select Case CriteriosventaproductosDataGridView.Columns(e.ColumnIndex).Name
                Case "QuitarProducto"
                    'MsgInfo(CriteriosventaproductosDataGridView.Rows(e.RowIndex).Cells("idcriteriosventaproductos").Value)
                    If CriteriosventaproductosDataGridView.Rows(e.RowIndex).Cells("idcriteriosventaproductos").Value > 0 Then
                        CriteriosventaproductosTableAdapter.criteriosventaproductos_eliminar(CriteriosventaproductosDataGridView.Rows(e.RowIndex).Cells("idcriteriosventaproductos").Value)
                        CriteriosventaproductosTableAdapter.FillByIDCriteriosVenta(Me.ComercialDataSet.criteriosventaproductos, gidCriterioSeleccionado)
                    End If
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CantidaddisponibletotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles CantidaddisponibletotalTextBox.TextChanged

    End Sub

    Private Sub CantidaddisponibletotalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidaddisponibletotalTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CantidadmaximaporclienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles CantidadmaximaporclienteTextBox.TextChanged

    End Sub

    Private Sub CantidadmaximaporclienteTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidadmaximaporclienteTextBox.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "." Then
            e.KeyChar = ","
            Return
        End If
        If e.KeyChar = "," Then
            Return
        End If
        If (Regex.IsMatch(e.KeyChar, "[^0-9]")) Then
            'MessageBox.Show("Solo se permiten numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim kl As DefinirCriterioVentaRango
        kl = New DefinirCriterioVentaRango()

        gCantidadDesde = Nothing
        gCantidadHasta = Nothing
        gPorcentaje = Nothing
        kl.ShowDialog()
        If gCantidadDesde <> Nothing And gCantidadHasta <> Nothing Then
            CriteriosventarangosTableAdapter.criteriosventarangos_insertar(gidCriterioSeleccionado, gCantidadDesde, gCantidadHasta, gPorcentaje, Nothing)
            CriteriosventarangosTableAdapter.FillByidcriterioventa(Me.ComercialDataSet.criteriosventarangos, gidCriterioSeleccionado)
            'CriteriosventaproductosTableAdapter.criteriosventaproductos_insertar(gcodigoproducto, gcantidad, gidCriterioSeleccionado)
            'CriteriosventaproductosTableAdapter.FillByIDCriteriosVenta(Me.ComercialDataSet.criteriosventaproductos, gidCriterioSeleccionado)
        End If
    End Sub

    Private Sub NuevoCriterioVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F5 Then
        '    Me.CriteriosventaTableAdapter.Fill(Me.ComercialDataSet.criteriosventa)
        'End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub ButtonFinalizar_Click(sender As Object, e As EventArgs) Handles ButtonFinalizar.Click
        Dim descripcion As String
        Dim fechadesde As Date
        Dim fechahasta As Date
        Dim cantidadtotal As Decimal
        Dim cantidadmaxima As Decimal
        Try
            descripcion = DescripcionTextBox.Text
            fechadesde = FechadesdeDateTimePicker.Value
            fechahasta = FechahastaDateTimePicker.Value
            Try
                cantidadtotal = Convert.ToDecimal(CantidaddisponibletotalTextBox.Text)
            Catch ex As Exception
                cantidadtotal = 9999999999
            End Try
            Try
                cantidadmaxima = Convert.ToDecimal(CantidadmaximaporclienteTextBox.Text)
            Catch ex As Exception
                cantidadmaxima = 9999999999
            End Try
            CriteriosventaTableAdapter.criteriosventa_update(descripcion, fechadesde, fechahasta, cantidadtotal, cantidadmaxima, gidCriterioSeleccionado)
            Me.Close()
        Catch ex As Exception
            MsgEx("No se pudo completar la operación: " + ex.Message)
        End Try

    End Sub

    Private Sub CriteriosventarangosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CriteriosventarangosDataGridView.CellContentClick

    End Sub

    Private Sub CriteriosventarangosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CriteriosventarangosDataGridView.CellClick
        Try
            Select Case CriteriosventarangosDataGridView.Columns(e.ColumnIndex).Name
                Case "AgregarRegalo"
                    Dim kl As SeleccionarProductoCantidadGenerico
                    kl = New SeleccionarProductoCantidadGenerico()
                    Dim idrango As Long = CriteriosventarangosDataGridView.Rows(e.RowIndex).Cells("idcriterioventarango").Value
                    gcodigoproducto = Nothing
                    gcantidad = Nothing
                    kl.ShowDialog()
                    If gcodigoproducto <> Nothing And gcantidad <> Nothing Then
                        'MsgInfo("cargaregalo")
                        CriteriosventaregalorangoTableAdapter.criteriosventaregalorango_insertar(gidCriterioSeleccionado, idrango, gcodigoproducto, gcantidad)
                        CriteriosventaregalorangoTableAdapter.FillByidrangocriterioventa(Me.ComercialDataSet.criteriosventaregalorango, idrango)
                        'CriteriosventaproductosTableAdapter.criteriosventaproductos_insertar(gcodigoproducto, gcantidad, gidCriterioSeleccionado)
                        'CriteriosventaproductosTableAdapter.FillByIDCriteriosVenta(Me.ComercialDataSet.criteriosventaproductos, gidCriterioSeleccionado)
                    End If
                Case "EliminarRango"
                    Dim idrango As Long = CriteriosventarangosDataGridView.Rows(e.RowIndex).Cells("idcriterioventarango").Value
                    Dim CriteriosVentaRangos As New comercialDataSetTableAdapters.criteriosventarangosTableAdapter()
                    CriteriosVentaRangos.criteriosventarangos_eliminar(idrango)
                    CriteriosventarangosTableAdapter.FillByidcriterioventa(Me.ComercialDataSet.criteriosventarangos, gidCriterioSeleccionado)
                    CriteriosventaregalorangoTableAdapter.FillByidrangocriterioventa(Me.ComercialDataSet.criteriosventaregalorango, idrango)
                Case Else
                    Try
                        Dim idrango As Long = CriteriosventarangosDataGridView.Rows(e.RowIndex).Cells("idcriterioventarango").Value
                        CriteriosventaregalorangoTableAdapter.FillByidrangocriterioventa(Me.ComercialDataSet.criteriosventaregalorango, idrango)
                    Catch ex As Exception

                    End Try
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CriteriosventaregalorangoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CriteriosventaregalorangoDataGridView.CellContentClick

    End Sub

    Private Sub CriteriosventaregalorangoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CriteriosventaregalorangoDataGridView.CellClick
        Try
            Select Case CriteriosventaregalorangoDataGridView.Columns(e.ColumnIndex).Name
                Case "QuitarRegalo"
                    Dim idregalo As Long = CriteriosventaregalorangoDataGridView.Rows(e.RowIndex).Cells("idcriteriosventaregalorango").Value
                    Dim idrango As Long = CriteriosventaregalorangoDataGridView.Rows(e.RowIndex).Cells("idrangocriterioventa").Value

                    CriteriosventaregalorangoTableAdapter.criteriosventaregalorango_eliminar(idregalo)
                    CriteriosventaregalorangoTableAdapter.FillByidrangocriterioventa(Me.ComercialDataSet.criteriosventaregalorango, idrango)

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NuevoCriterioVenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        gidCriterioSeleccionado = Nothing
    End Sub
End Class