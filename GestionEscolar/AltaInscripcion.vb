Public Class AltaInscripcion
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub AltaInscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.grados' Puede moverla o quitarla según sea necesario.
        'Me.GradosTableAdapter.Fill(Me.ComercialDataSet.grados)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.servicios' Puede moverla o quitarla según sea necesario.
        'Me.ServiciosTableAdapter.Fill(Me.ComercialDataSet.servicios)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientesdomicilios' Puede moverla o quitarla según sea necesario.
        'Me.ClientesdomiciliosTableAdapter.Fill(Me.ComercialDataSet.clientesdomicilios)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.libroalumnos' Puede moverla o quitarla según sea necesario.
        'Me.LibroalumnosTableAdapter.Fill(Me.ComercialDataSet.libroalumnos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listaclientes' Puede moverla o quitarla según sea necesario.
        'Me.ListaclientesTableAdapter.Fill(Me.ComercialDataSet.listaclientes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)

    End Sub

    Private Sub PictureSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarCliente.Click
        gclienteseleccionado = 0
        Dim p As SeleccionarCliente
        p = New SeleccionarCliente
        p.ShowDialog()
        IdclienteTextBox.Text = gclienteseleccionado.ToString
        If gclienteseleccionado > 0 Then
            Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
            Me.ListaclientesTableAdapter.FillByIdCliente(Me.ComercialDataSet.listaclientes, gclienteseleccionado)
            If gclienteseleccionado > 1 Then
                PictureBoxEditarCliente.Visible = True
                'calculafechavencimiento()
                'ButtonDescuentoDefecto.Visible = True
            Else
                PictureBoxEditarCliente.Visible = False
                'ButtonDescuentoDefecto.Visible = False
            End If
        Else
            Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, 0)
            Me.ListaclientesTableAdapter.FillByIdCliente(Me.ComercialDataSet.listaclientes, 0)
            PictureBoxEditarCliente.Visible = False
        End If
        gclienteseleccionado = Nothing
    End Sub

    Private Sub PictureBoxEditarCliente_Click(sender As Object, e As EventArgs) Handles PictureBoxEditarCliente.Click
        Dim p As ABMClientes
        p = New ABMClientes
        gclienteseleccionado = Val(IdclienteTextBox.Text)
        p.ShowDialog()
        Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
        Me.ListaclientesTableAdapter.FillByIdCliente(Me.ComercialDataSet.listaclientes, gclienteseleccionado)
    End Sub

    Private Sub PictureSeleccionarAlumno_Click(sender As Object, e As EventArgs) Handles PictureSeleccionarAlumno.Click
        galumnoseleccionado = 0
        Dim p As SeleccionarAlumno
        p = New SeleccionarAlumno
        p.ShowDialog()
        TextBoxIDAlumno.Text = galumnoseleccionado.ToString
        If galumnoseleccionado > 0 Then
            'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, galumnoseleccionado)
            Me.LibroalumnosTableAdapter.FillByIDAlumno(Me.ComercialDataSet.libroalumnos, galumnoseleccionado)
            PictureEditarAlumno.Visible = False
            TextBoxIDAlumno.Text = galumnoseleccionado.ToString
        Else
            'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, 0)
            Me.LibroalumnosTableAdapter.FillByIDAlumno(Me.ComercialDataSet.libroalumnos, galumnoseleccionado)
            PictureEditarAlumno.Visible = False
            TextBoxIDAlumno.Text = Nothing
        End If
        galumnoseleccionado = Nothing
        'PictureEditarAlumno.Visible = True
        'galumnoseleccionado = 0
    End Sub

    Private Sub PictureEditarAlumno_Click(sender As Object, e As EventArgs) Handles PictureEditarAlumno.Click
        Dim p As ABMAlumnos
        p = New ABMAlumnos
        galumnoseleccionado = Val(TextBoxIDAlumno.Text)
        p.ShowDialog()
        'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
        Me.LibroalumnosTableAdapter.FillByIDAlumno(Me.ComercialDataSet.libroalumnos, galumnoseleccionado)
    End Sub

    Private Sub PictureBoxEditarDomicilios_Click(sender As Object, e As EventArgs) Handles PictureBoxEditarDomicilios.Click
        If Val(IdclienteTextBox.Text) = 0 Then Return
        Dim P As ClientesNuevoDomicilio
        P = New ClientesNuevoDomicilio
        gdomicilioseleccionado = 0
        gclienteseleccionado = Val(IdclienteTextBox.Text)
        P.ShowDialog()
        If gdomicilioseleccionado = 0 Then Return
        ' MsgBox("paso")
        Me.ClientesdomiciliosTableAdapter.Fill(Me.ComercialDataSet.clientesdomicilios)
        ClientesdomiciliosBindingSource.Filter = "iddomicilio = " + gdomicilioseleccionado.ToString
    End Sub

    Private Sub PictureServicio_Click(sender As Object, e As EventArgs) Handles PictureServicio.Click
        gservicioseleccionado = 0
        Dim p As SeleccionarServicio
        p = New SeleccionarServicio
        p.ShowDialog()
        TextBoxIdServicio.Text = gservicioseleccionado.ToString
        If gservicioseleccionado > 0 Then
            'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, galumnoseleccionado)
            Me.ServiciosTableAdapter.FillByIDservicio(Me.ComercialDataSet.servicios, gservicioseleccionado)
            If gservicioseleccionado > 1 Then
                PictureEditarAlumno.Visible = True
                'calculafechavencimiento()
                'ButtonDescuentoDefecto.Visible = True
            Else
                PictureEditarAlumno.Visible = False
                'ButtonDescuentoDefecto.Visible = False
                TextBoxIdServicio.Text = Nothing
            End If
        Else
            'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, 0)
            Me.ServiciosTableAdapter.FillByIDservicio(Me.ComercialDataSet.servicios, gservicioseleccionado)
            PictureEditarAlumno.Visible = False
            TextBoxIdServicio.Text = Nothing
        End If
        gservicioseleccionado = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Not Val(IdclienteTextBox.Text) > 0 Then
                MessageBox.Show("Seleccione un Tutor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If Not Val(TextBoxIDAlumno.Text) > 0 Then
                MessageBox.Show("Seleccione un Alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If Not gdomicilioseleccionado > 0 Then
                MessageBox.Show("Seleccione un Domicilio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If Not Val(TextBoxIdServicio.Text) > 0 Then
                MessageBox.Show("Seleccione una Tarifa/servicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If Not Val(ComboBoxCicloLectivo.Text) > 0 Then
                MessageBox.Show("Seleccione un Ciclo Lectivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If Not ComboBoxCuatrimestre.SelectedIndex >= 0 Then
                MessageBox.Show("Seleccione un Cuatrimestre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Verifíque los datos ingresados: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try

        Try
            If MsgBox("Seguro desea Confirmar la Inscripción?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Dim ClientesserviciosTableAdapter As New comercialDataSetTableAdapters.clientesserviciosTableAdapter
                Dim idcliente As Long = Val(IdclienteTextBox.Text)
                Dim idclientedomicilio As Long = gdomicilioseleccionado
                Dim idalumno As Long = Val(TextBoxIDAlumno.Text)
                Dim idservicio As Long = Val(TextBoxIdServicio.Text)
                Dim idgrado As Long = Val(TextBoxGrado.Text)
                Dim fechadesde As Date
                Dim fechahasta As Date
                Select Case ComboBoxCuatrimestre.Text
                    Case "Primero"

                        fechadesde = DateTime.Parse("01/01/" + ComboBoxCicloLectivo.Text)
                        fechahasta = DateTime.Parse("30/04/" + ComboBoxCicloLectivo.Text)
                    Case "Segundo"
                        fechadesde = DateTime.Parse("01/05/" + ComboBoxCicloLectivo.Text)
                        fechahasta = DateTime.Parse("31/08/" + ComboBoxCicloLectivo.Text)
                    Case "Tercero"
                        fechadesde = DateTime.Parse("01/09/" + ComboBoxCicloLectivo.Text)
                        fechahasta = DateTime.Parse("31/12/" + ComboBoxCicloLectivo.Text)
                End Select
                gclientesserviciosseleccionado = ClientesserviciosTableAdapter.clientesservicios_insertar(idcliente, idclientedomicilio, idalumno, idservicio, idgrado, fechadesde, fechahasta, gusername)
                MessageBox.Show("Operación Exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim x As New VistaPreviaInscripcion()
                x.ShowDialog()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió una excepción: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Dim x As New VistaPreviaInscripcion()
    '    x.ShowDialog()
    '    Me.Close()
    'End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim x As New VistaPreviaInscripcion()
        x.ShowDialog()
        Me.Close()
    End Sub

    Private Sub PictureBoxCursado_Click(sender As Object, e As EventArgs) Handles PictureBoxCursado.Click
        ggradoseleccionado = 0
        Dim p As SeleccionarGrado
        p = New SeleccionarGrado
        p.ShowDialog()
        If ggradoseleccionado > 0 Then
            'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, galumnoseleccionado)
            Me.GradosTableAdapter.FillByidgrado(Me.ComercialDataSet.grados, ggradoseleccionado)
            If ggradoseleccionado > 0 Then
                TextBoxGrado.Text = ggradoseleccionado.ToString
                'PictureEditarAlumno.Visible = True
                'calculafechavencimiento()
                'ButtonDescuentoDefecto.Visible = True
            Else
                'PictureEditarAlumno.Visible = False
                'ButtonDescuentoDefecto.Visible = False
                TextBoxGrado.Text = Nothing
            End If
        Else
            'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, 0)
            Me.GradosTableAdapter.FillByidgrado(Me.ComercialDataSet.grados, ggradoseleccionado)
            'PictureEditarAlumno.Visible = False
            TextBoxGrado.Text = Nothing
        End If
        ggradoseleccionado = Nothing
    End Sub
End Class