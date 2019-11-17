Public Class ABMServicios
    Dim autoclose As Boolean
    Private Sub ServiciosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ServiciosBindingNavigatorSaveItem.Click
        If DescripcionTextBox.Text = "" Or Len(Trim(DescripcionTextBox.Text)) = 0 Then
            MessageBox.Show("Ingrese la descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DescripcionTextBox.Select()
            Return
        End If
        If PrecioventaTextBox.Text = "" Or Len(Trim(PrecioventaTextBox.Text)) = 0 Then
            MessageBox.Show("Ingrese el precio de venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            PrecioventaTextBox.Select()
            Return
        End If
        If MsgBox("Seguro desea guardar los cambios realizados?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Try
                Me.Validate()
                Me.ServiciosBindingSource.EndEdit()
                If Not Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet) = 1 Then
                    MessageBox.Show("Ocurrió un error Verifíque los datos ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                enablefields(False)
                enabledit(False)
                If gservicioseleccionado = -1 Then
                    gservicioseleccionado = Val(IdservicioTextBox.Text)
                    Me.Close()
                End If
                If autoclose = True Then Me.Close()
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If

        Try
            Me.Validate()
            Me.ServiciosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enablefields(False)
            enabledit(False)
        Catch ex As Exception
            MsgBox("Ocurrió un error: " + ex.Message)
        End Try


    End Sub

    Private Sub ABMServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.ComercialDataSet.servicios)
        enablefields(False)
        enabledit(False)
        '--/**********************************************/
        If gservicioseleccionado = -1 Then
            BindingNavigatorAddNewItem.PerformClick()
        End If
        If gservicioseleccionado > 1 Then
            autoclose = True
            ServiciosTableAdapter.FillByIDServicio(Me.ComercialDataSet.servicios, gservicioseleccionado)
            ToolStripButtonEditar.PerformClick()
        End If
    End Sub
    Private Sub enablefields(ByRef status As Boolean)
        DescripcionTextBox.Enabled = status
        PrecioventaTextBox.Enabled = status
        DiasvigenciaTextBox.Enabled = status
    End Sub
    Private Sub enabledit(ByRef status As Boolean)
        If status = True Then
            BindingNavigatorAddNewItem.Enabled = False
            ServiciosBindingNavigatorSaveItem.Enabled = True
            ToolStripButtonEditar.Enabled = False
            ToolStripButtonCancelar.Enabled = True
        Else
            BindingNavigatorAddNewItem.Enabled = True
            ServiciosBindingNavigatorSaveItem.Enabled = False
            ToolStripButtonEditar.Enabled = True
            ToolStripButtonCancelar.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButtonEditar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEditar.Click
        enablefields(True)
        enabledit(True)
    End Sub

    Private Sub ToolStripButtonCancelar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCancelar.Click
        enablefields(False)
        enabledit(False)
        ServiciosBindingSource.ResetBindings(True)
        Me.ServiciosTableAdapter.Fill(Me.ComercialDataSet.servicios)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
        enabledit(True)
    End Sub
End Class