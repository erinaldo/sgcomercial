Public Class ABMEmpleados
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Me.Validate()
            Me.EmpleadosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enabledit(False)
            enablefields(False)
            NavStatus(True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ABMEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.convenioempleo' Puede moverla o quitarla según sea necesario.
        Me.ConvenioempleoTableAdapter.Fill(Me.ComercialDataSet.convenioempleo)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.condicionempleo' Puede moverla o quitarla según sea necesario.
        Me.CondicionempleoTableAdapter.Fill(Me.ComercialDataSet.condicionempleo)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.incapacidades' Puede moverla o quitarla según sea necesario.
        Me.IncapacidadesTableAdapter.Fill(Me.ComercialDataSet.incapacidades)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.gruposjerarquicos' Puede moverla o quitarla según sea necesario.
        Me.GruposjerarquicosTableAdapter.Fill(Me.ComercialDataSet.gruposjerarquicos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.centroscosto' Puede moverla o quitarla según sea necesario.
        Me.CentroscostoTableAdapter.Fill(Me.ComercialDataSet.centroscosto)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.categoriasempleados' Puede moverla o quitarla según sea necesario.
        Me.CategoriasempleadosTableAdapter.Fill(Me.ComercialDataSet.categoriasempleados)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.sindicatos' Puede moverla o quitarla según sea necesario.
        Me.SindicatosTableAdapter.Fill(Me.ComercialDataSet.sindicatos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.obrassociales' Puede moverla o quitarla según sea necesario.
        Me.ObrassocialesTableAdapter.Fill(Me.ComercialDataSet.obrassociales)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipodocumentos' Puede moverla o quitarla según sea necesario.
        Me.TipodocumentosTableAdapter.Fill(Me.ComercialDataSet.tipodocumentos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ComercialDataSet.empleados)
        enabledit(False)
        enablefields(False)
        NavStatus(True)
    End Sub
    Private Sub enabledit(Status As Boolean)
        If Status = False Then
            BtnNuevo.Enabled = True
            BtnCancelar.Enabled = False
            BtnGuardar.Enabled = False
            BtnEditar.Enabled = True
        Else
            BtnNuevo.Enabled = False
            BtnCancelar.Enabled = True
            BtnGuardar.Enabled = True
            BtnEditar.Enabled = False
            GroupABM.Visible = True
            GroupListado.Visible = False
        End If
    End Sub
    Private Sub enablefields(Status As Boolean)
        NombreTextBox.Enabled = Status
        NombreTextBox.Select()
        NombreTextBox.Enabled = Status
        ApellidoTextBox.Enabled = Status
        CodigopostalTextBox.Enabled = Status
        NombreTextBox.Enabled = Status
        DocumentoTextBox.Enabled = Status
        EstadocivilTextBox.Enabled = Status
        NacionalidadTextBox.Enabled = Status
        LocalidadTextBox.Enabled = Status
        TelefonoTextBox.Enabled = Status
        IdtipodocumentoComboBox.Enabled = Status
        IdincapacidadComboBox.Enabled = Status
        DomcalleTextBox.Enabled = Status
        DomnumeroTextBox.Enabled = Status
        DompisoTextBox.Enabled = Status
        DomdeptoTextBox.Enabled = Status
        ProvinciaTextBox.Enabled = Status
        EmailTextBox.Enabled = Status
        FechaaltaDateTimePicker.Enabled = Status
        FechabajaDateTimePicker.Enabled = Status
        NrojubilacionTextBox.Enabled = Status
        RegimenTextBox.Enabled = Status
        NroinscripcionTextBox.Enabled = Status
        IdcondicionempleoComboBox.Enabled = Status
        IdconvenioempleoComboBox.Enabled = Status
        SueldojornalTextBox.Enabled = Status
        AdicionalfijoTextBox.Enabled = Status
        TareaTextBox.Enabled = Status
        IdobrasocialComboBox.Enabled = Status
        IdsindicatoComboBox.Enabled = Status
        IdcategoriaempleadoComboBox.Enabled = Status
        IdcentrocostoComboBox.Enabled = Status
        IdgrupojerarquicoComboBox.Enabled = Status
        FechanacimientoDateTimePicker.Enabled = Status
    End Sub
    Private Sub NavStatus(status As Boolean)
        BindingNavigatorMoveFirstItem.Enabled = status
        BindingNavigatorMovePreviousItem.Enabled = status
        BindingNavigatorMoveNextItem.Enabled = status
        BindingNavigatorMoveLastItem.Enabled = status
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        NavStatus(False)
        enabledit(True)
        enablefields(True)
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If EmpleadosBindingSource.Count = 0 Then
            MsgExPopUp("No hay registros para editar")
            Return
        End If
        enabledit(True)
        enablefields(True)
        NavStatus(False)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        enabledit(False)
        enablefields(False)
        EmpleadosBindingSource.ResetBindings(True)
        'DescripcionTextBox.Text = Nothing
        Me.EmpleadosTableAdapter.Fill(Me.ComercialDataSet.empleados)
        NavStatus(True)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        listar(True)
    End Sub
    Private Sub listar(status As Boolean)
        If status = True Then
            enabledit(False)
            enablefields(False)
            SindicatosBindingSource.ResetBindings(True)
            'DescripcionTextBox.Text = Nothing
            Me.SindicatosTableAdapter.Fill(Me.ComercialDataSet.sindicatos)
            NavStatus(True)
            GroupABM.Visible = False
            GroupListado.Visible = True
        Else
            GroupABM.Visible = True
            GroupListado.Visible = False
        End If
    End Sub

    Private Sub ABMEmpleados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '''''''''''''''''''''''**************************''''''''''''''''''''''''''''''''''''
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class