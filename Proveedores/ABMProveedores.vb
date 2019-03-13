Public Class ABMProveedores
    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click
        If Len(Trim(NombreTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar el nombre del proveedor", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If
        Try
            Me.Validate()
            Me.ProveedoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)
            enablebuttons(False)
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = False
            ProveedoresBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
        Catch ex As Exception
            MsgBox("No fue posible grabar los datos del proveedor", MsgBoxStyle.Exclamation, "Advertencia")
        End Try


    End Sub

    Private Sub ABMProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet1.tipocondicioniva' Puede moverla o quitarla según sea necesario.
        Me.TipocondicionivaTableAdapter.Fill(Me.ComercialDataSet1.tipocondicioniva)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)
        enablebuttons(False)
        ToolStripButton2.Enabled = False
    End Sub

    Private Sub enablebuttons(ByVal status As Boolean)
        IdproveedorTextBox.Enabled = status
        NombreTextBox.Enabled = status
        CuitcuilTextBox.Enabled = status
        TelefonoTextBox.Enabled = status
        EmailTextBox.Enabled = status
        'CondicionivaComboBox.Enabled = status
        PersonacontactoTextBox.Enabled = status
        ComboCondicionIVA.Enabled = status
        If status = True Then
            ProveedoresDataGridView.Enabled = False
        Else
            ProveedoresDataGridView.Enabled = True
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        enablebuttons(True)
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        ProveedoresBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Not ProveedoresDataGridView.RowCount = 0 Then
            enablebuttons(True)
            ToolStripButton2.Enabled = True
            ProveedoresBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorAddNewItem.Enabled = False
            ToolStripButton1.Enabled = False
        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ProveedoresBindingNavigatorSaveItem.Enabled = False
        ToolStripButton2.Enabled = False
        ToolStripButton1.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
        enablebuttons(False)
        Me.ProveedoresTableAdapter.Fill(Me.ComercialDataSet.proveedores)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
End Class