Public Class AltaInscripcion
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub AltaInscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        gclienteseleccionado = 0
        Dim p As SeleccionarAlumno
        p = New SeleccionarAlumno
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
        PictureEditarAlumno.Visible = True
        gclienteseleccionado = 0
    End Sub
End Class