Public Class AltaInscripcion
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub AltaInscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If galumnoseleccionado > 1 Then
                PictureEditarAlumno.Visible = True
                'calculafechavencimiento()
                'ButtonDescuentoDefecto.Visible = True
            Else
                PictureEditarAlumno.Visible = False
                'ButtonDescuentoDefecto.Visible = False
                TextBoxIDAlumno.Text = Nothing
            End If
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
        Dim p As ABMServicios
        p = New ABMServicios
        p.ShowDialog()
        TextBoxIDAlumno.Text = gservicioseleccionado.ToString
        If gservicioseleccionado > 0 Then
            'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, galumnoseleccionado)
            Me.LibroalumnosTableAdapter.FillByIDAlumno(Me.ComercialDataSet.libroalumnos, gservicioseleccionado)
            If gservicioseleccionado > 1 Then
                PictureEditarAlumno.Visible = True
                'calculafechavencimiento()
                'ButtonDescuentoDefecto.Visible = True
            Else
                PictureEditarAlumno.Visible = False
                'ButtonDescuentoDefecto.Visible = False
                TextBoxIDAlumno.Text = Nothing
            End If
        Else
            'Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, 0)
            Me.LibroalumnosTableAdapter.FillByIDAlumno(Me.ComercialDataSet.libroalumnos, gservicioseleccionado)
            PictureEditarAlumno.Visible = False
            TextBoxIDAlumno.Text = Nothing
        End If
        gservicioseleccionado = Nothing
    End Sub
End Class