Public Class ABMClientes

    Public Sub enablefields(ByVal status As Boolean)
        NombreTextBox.Enabled = status
        RazonsocialTextBox.Enabled = status
        TelefonoTextBox.Enabled = status
        EmailTextBox.Enabled = status
        'DireccionTextBox.Enabled = status
    End Sub


    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        If MsgBox("Seguro desea guardar los cambios realizados?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            ClientesDataGridView.Enabled = True
            enabledit(False)
            enablefields(False)
            ClientesDataGridView.Enabled = True
            filtrotextbox.Enabled = True
        End If

        
    End Sub

    Private Sub ABMClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.clientes' Puede moverla o quitarla según sea necesario.


        Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
        enablefields(False)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
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
        Me.ClientesTableAdapter.Fill(Me.ComercialDataSet.clientes)
        ClientesDataGridView.Enabled = True
        ClientesDataGridView.Enabled = True
        filtrotextbox.Enabled = True
    End Sub
    Private Sub enabledit(ByVal status As Boolean)
        'ToolStripButton1.Visible = status
        ToolStripButton2.Visible = status
        If status = False Then
            ToolStripButton1.Visible = True
        Else
            ToolStripButton1.Visible = False
        End If
        ClientesBindingNavigatorSaveItem.Visible = status
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablefields(True)
        enabledit(True)
        ClientesDataGridView.Enabled = False
        filtrotextbox.Enabled = False
        NombreTextBox.Select()
    End Sub

    Private Sub filtrotextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtrotextbox.TextChanged
        Select Case ComboBox1.Text
            Case "Nombre"
                ClientesBindingSource.Filter = "nombre like '%" + filtrotextbox.Text + "%'"
            Case "Cuit"
                ClientesBindingSource.Filter = "cuit like '%" + filtrotextbox.Text + "%'"
        End Select
    End Sub
End Class