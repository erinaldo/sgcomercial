Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class ABMClientes
    Dim autoclose As Boolean = False
    Dim v_valdatosnuevosclientes As String
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
    Private Function ValidarCargaDatosCliente() As Boolean
        Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        '********** ValidarDatosClientesNuevos
        v_valdatosnuevosclientes = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("ValDatosNuevosClientes")
        '********** 
        If Len(Trim(NombreTextBox.Text)) = 0 Then ' 
            MessageBox.Show("Ingrese Nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        '*****************************************************
        If ComboDocTipo.SelectedValue = Nothing Then
            MessageBox.Show("Seleccione un tipo de documento válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        '*****************************************************
        If Len(Trim(CUITTextBox.Text)) = 0 And v_valdatosnuevosclientes = "SI" Then ' If ComboDocTipo.SelectedValue = Nothing Then
            MessageBox.Show("Ingrese CUIT", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        '*****************************************************
        If ComboCondicionIVA.SelectedValue = Nothing And v_valdatosnuevosclientes = "SI" Then
            MessageBox.Show("Seleccione un tipo de Condición Frente al IVA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        '************************************
        Return True
    End Function

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        If ValidarCargaDatosCliente() = False Then Return
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
                If gModuloCloud = 1 Then
                    Me.Cursor = Cursors.WaitCursor
                    PushCliente(Val(IdclienteTextBox.Text))
                    Me.Cursor = Cursors.Default
                End If
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
        CheckModulesAuth()
        '********** 
        Me.TipodocumentosTableAdapter.Fill(Me.ComercialDataSet.tipodocumentos)
        Me.ProvinciasTableAdapter.Fill(Me.ComercialDataSet.provincias)
        Me.TipocondicionivaTableAdapter.Fill(Me.ComercialDataSet.tipocondicioniva)
        '********** 
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
        ComboBox1.SelectedIndex = 0
        BGWLCD.RunWorkerAsync()
        'Me.ReportViewer1.RefreshReport()
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
        Try
            Select Case ComboBox1.Text
                Case "Nombre"
                    ClientesBindingSource.Filter = "nombre like '%" + filtrotextbox.Text + "%'"
                Case "Cuit"
                    ClientesBindingSource.Filter = "cuit like '%" + filtrotextbox.Text + "%'"
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ABMClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F12 And Me.MaximizeBox = True Then
        '    If Me.WindowState = FormWindowState.Normal Then
        '        Me.WindowState = FormWindowState.Maximized
        '    Else
        '        Me.WindowState = FormWindowState.Normal
        '    End If
        'End If
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
                    gclienteseleccionado = ClientesDataGridView.Rows(e.RowIndex).Cells("idcliente").Value
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
                Case "eliminar"
                    If MessageBox.Show("Seguro desea eliminar el cliente?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        ClientesTableAdapter.clientes_baja(ClientesDataGridView.Rows(e.RowIndex).Cells("idcliente").Value)
                        Me.ClientesTableAdapter.FillByClientesTodos(Me.ComercialDataSet.clientes)
                        MessageBox.Show("Operación exitosa!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    End If

            End Select

        Catch ex As Exception
            'MessageBox.Show("Operación exitosa!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        If BGWLCD.IsBusy Then
            MsgExPopUp("Se estan cargando los datos del informe, intente nuevamente en unos segundos")
            Return
        End If
        Try
            Dim extensions As RenderingExtension() = ReportViewer1.LocalReport.ListRenderingExtensions()
            For Each extension As RenderingExtension In extensions
                If extension.Name = "EXCELOPENXML" Then
                    'If MessageBox.Show("El proceso puede tardar unos minutos. Desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    'Dim rtn As Integer
                    If ReportViewer1.ExportDialog(extension) Then
                        'MsgBox("Proceso finalizado correctamente!", MsgBoxStyle.Information, "Mensaje")
                        MsgSuccessPopUp("Proceso finalizado correctamente!")
                        'Me.Close()
                    End If
                    'End If
                End If
            Next
        Catch ex As Exception
            MsgExPopUp("Aguarde un momento, se estan procesando los datos del reporte")
            Return
        End Try
    End Sub

    Private Sub PDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDFToolStripMenuItem.Click
        If BGWLCD.IsBusy Then
            MsgExPopUp("Se estan cargando los datos del informe, intente nuevamente en unos segundos")
            Return
        End If
        Try
            Dim extensions As RenderingExtension() = ReportViewer1.LocalReport.ListRenderingExtensions()
            For Each extension As RenderingExtension In extensions
                If extension.Name = "PDF" Then
                    'If MessageBox.Show("El proceso puede tardar unos minutos. Desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    'Dim rtn As Integer
                    If ReportViewer1.ExportDialog(extension) Then
                        'MsgBox("Proceso finalizado correctamente!", MsgBoxStyle.Information, "Mensaje")
                        MsgSuccessPopUp("Proceso finalizado correctamente!")
                        'Me.Close()
                    End If
                    'End If
                End If
            Next
        Catch ex As Exception
            MsgExPopUp("Aguarde un momento, se estan procesando los datos del reporte")
            Return
        End Try
    End Sub

    Private Sub BGWLCD_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWLCD.DoWork
        Me.MiComercioTableAdapter.Fill(Me.ComercialDataSet.MiComercio)
        Me.listaclientesdomiciliosTableAdapter.Fill(Me.ComercialDataSet.listaclientesdomicilios)

        'ExportarBtn.Enabled = False
    End Sub

    Private Sub BGWLCD_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGWLCD.RunWorkerCompleted
        'ExportarBtn.Enabled = False
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class