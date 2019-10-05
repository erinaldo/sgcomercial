Public Class ClientesNuevoDomicilio
    Private Sub ClientesdomiciliosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesdomiciliosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ClientesNuevoDomicilio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.ComercialDataSet.localidades)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientesdomicilios' Puede moverla o quitarla según sea necesario.
        Me.ClientesdomiciliosTableAdapter.Fill(Me.ComercialDataSet.clientesdomicilios)


        ClientesdomiciliosBindingSource.Filter = "idcliente =" + gclienteseleccionado.ToString
        If ClientesdomiciliosBindingSource.Count = 0 Then
            DireccionTextBox.Enabled = False
            ReferenciasTextBox.Enabled = False
            CpTextBox.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
        Else
            DireccionTextBox.Enabled = True
            ReferenciasTextBox.Enabled = True
            CpTextBox.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        End If

    End Sub

    Private Sub ClientesdomiciliosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ClientesdomiciliosBindingNavigatorSaveItem.Click

        IdclienteTextBox.Text = gclienteseleccionado.ToString
        If MsgBox("Seguro desea guardar los cambios? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Me.Validate()
                Me.ClientesdomiciliosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
                'Me.Close()
            Catch ex As Exception

            End Try
        End If



    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        DireccionTextBox.Enabled = True
        ReferenciasTextBox.Enabled = True
        CpTextBox.Enabled = True

    End Sub

    Private Sub IdprovinciaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            'MsgBox("idprovincia = " + IdprovinciaComboBox.SelectedValue.ToString)
            LocalidadesBindingSource.Filter = "idprovincia = " + ComboBox1.SelectedValue.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            'MsgBox("idprovincia = " + ComboBox2.SelectedValue.ToString)
            LocalidadesBindingSource.Filter = "idprovincia = " + ComboBox1.SelectedValue.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        gdomicilioseleccionado = Val(IddomicilioTextBox.Text)
        Me.Close()
    End Sub

    Private Sub ClientesNuevoDomicilio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class