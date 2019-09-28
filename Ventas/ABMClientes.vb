Imports System.Text.RegularExpressions
Public Class ABMClientes
    Dim autoclose As Boolean = False
    Public Sub enablefields(ByVal status As Boolean)
        NombreTextBox.Enabled = status
        CUITTextBox.Enabled = status
        TelefonoTextBox.Enabled = status
        EmailTextBox.Enabled = status
        ComboCondicionIVA.Enabled = status
        DiasvencimientoTextBox.Enabled = status
        porcentajedescuentoTextbox.Enabled = status
        ComboBox2.Enabled = status
        ComboDocTipo.Enabled = status
        'DireccionTextBox.Enabled = status
    End Sub


    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        If ComboDocTipo.SelectedValue = Nothing Then
            MessageBox.Show("Seleccione un tipo de documento válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MsgBox("Seguro desea guardar los cambios realizados?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Try
                Me.Validate()
                Me.ClientesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
                ClientesDataGridView.Enabled = True
                enabledit(False)
                enablefields(False)
                ClientesDataGridView.Enabled = True
                filtrotextbox.Enabled = True
                If gclienteseleccionado = -1 Then
                    gclienteseleccionado = Val(IdclienteTextBox.Text)
                    Me.Close()
                End If
                If autoclose = True Then Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ABMClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipodocumentos' Puede moverla o quitarla según sea necesario.
        Me.TipodocumentosTableAdapter.Fill(Me.ComercialDataSet.tipodocumentos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipocondicioniva' Puede moverla o quitarla según sea necesario.
        Me.TipocondicionivaTableAdapter.Fill(Me.ComercialDataSet.tipocondicioniva)


        Me.ClientesTableAdapter.FillByClientesTodos(Me.ComercialDataSet.clientes)
        enablefields(False)
        If gclienteseleccionado = -1 Then
            BindingNavigatorAddNewItem.PerformClick()
        End If
        If gclienteseleccionado > 1 Then
            autoclose = True
            Me.ClientesTableAdapter.FillByIdcliente(Me.ComercialDataSet.clientes, gclienteseleccionado)
            ToolStripButtonEditar.PerformClick()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonEditar.Click
        If IdclienteTextBox.Text = "1" Then Return
        enablefields(True)
        enabledit(True)
        ClientesDataGridView.Enabled = False
        filtrotextbox.Enabled = False
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        enablefields(False)
        enabledit(False)
        ClientesBindingSource.ResetBindings(True)
        Me.ClientesTableAdapter.FillByClientesTodos(Me.ComercialDataSet.clientes)
        ClientesDataGridView.Enabled = True
        ClientesDataGridView.Enabled = True
        filtrotextbox.Enabled = True
    End Sub
    Private Sub enabledit(ByVal status As Boolean)
        'ToolStripButton1.Visible = status
        ToolStripButton2.Visible = status
        DiasvencimientoTextBox.Enabled = status
        porcentajedescuentoTextbox.Enabled = status
        ComboDocTipo.Enabled = status
        CUITTextBox.Enabled = status
        If status = False Then
            ToolStripButtonEditar.Visible = True
            BindingNavigatorAddNewItem.Enabled = True
        Else
            ToolStripButtonEditar.Visible = False
            BindingNavigatorAddNewItem.Enabled = False
        End If
        ClientesBindingNavigatorSaveItem.Visible = status
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
        enabledit(True)
        ClientesDataGridView.Enabled = False
        filtrotextbox.Enabled = False
        NombreTextBox.Select()
        '--ComboDocTipo.SelectedIndex = 2
    End Sub

    Private Sub filtrotextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrotextbox.TextChanged
        Select Case ComboBox1.Text
            Case "Nombre"
                ClientesBindingSource.Filter = "nombre like '%" + filtrotextbox.Text + "%'"
            Case "Cuit"
                ClientesBindingSource.Filter = "cuit like '%" + filtrotextbox.Text + "%'"
        End Select
    End Sub

    Private Sub ABMClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub DiasvencimientoTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiasvencimientoTextBox.TextChanged

    End Sub

    Private Sub porcentajedescuentoTextbox_TextChanged(sender As Object, e As EventArgs) Handles porcentajedescuentoTextbox.TextChanged

    End Sub

    Private Sub porcentajedescuentoTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles porcentajedescuentoTextbox.KeyPress
        ' Check for the flag being set in the KeyDown event.
        'If nonNumberEntered = True Then
        '    ' Stop the character from being entered into the control since it is non-numerical.
        '    e.Handled = True
        'End If
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

    Private Sub ComboDocTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDocTipo.SelectedIndexChanged
        If ComboDocTipo.SelectedValue = Nothing Then Return
        Try
            If NombreTextBox.Enabled = True Then
                Select Case ComboDocTipo.SelectedValue
                    Case 3
                        CUITTextBox.Text = "0"
                        CUITTextBox.Enabled = False
                    Case Else
                        CUITTextBox.Text = ""
                        CUITTextBox.Enabled = True
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBoxEditarDomicilios_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClientesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

    End Sub

    Private Sub ClientesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellClick
        Try
            Select Case ClientesDataGridView.Columns(e.ColumnIndex).Name
                Case "EditarDomicilio"
                    'If Val(IdclienteTextBox.Text) = 0 Then Return
                    Dim P As ClientesNuevoDomicilio
                    P = New ClientesNuevoDomicilio
                    gdomicilioseleccionado = 0
                    gclienteseleccionado = ClientesDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn1").Value
                    P.ToolStripButton1.Visible = False
                    P.ShowDialog()

                    gclienteseleccionado = Nothing
                    gdomicilioseleccionado = Nothing

                    'If gdomicilioseleccionado = 0 Then
                    '    Return
                    'Else
                    '    '**************** todo bien! actualizo! *******************
                    '    'PedidosdeliveryTableAdapter.pedidosdelivery_updateiddomicilio(gdomicilioseleccionado, gidpedidodelivery)
                    '    gclienteseleccionado = Nothing
                    '    gdomicilioseleccionado = Nothing
                    '    'Me.ListapedidosdeliveryTableAdapter.FillByIdpedidodelivery(Me.ComercialDataSet.listapedidosdelivery, gidpedidodelivery)
                    'End If
            End Select

        Catch ex As Exception

        End Try
    End Sub
End Class