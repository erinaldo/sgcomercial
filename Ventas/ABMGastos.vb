Imports System.Text.RegularExpressions

Public Class ABMGastos
    Dim idevento As Long = 0
    Public Sub enablebuttons(ByVal status As Boolean)
        If status = True Then
            BtnNuevo.Enabled = False
        Else
            BtnNuevo.Enabled = True
        End If
        Button1.Enabled = status
        DescripcionTextBox.Enabled = status
        MontoTextBox.Enabled = status
        ComboTipoGasto.Enabled = status
        ComboTipoComprobante.Enabled = status
        'FechagastoDateTimePicker.Enabled = status
    End Sub

    Private Sub CajaseventosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajaseventosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipocomprobantes' Puede moverla o quitarla según sea necesario.
        Me.TipocomprobantesTableAdapter.FillByTIpoComprobantesGastos(Me.ComercialDataSet.tipocomprobantes)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipogastos' Puede moverla o quitarla según sea necesario.
        Me.TipogastosTableAdapter.Fill(Me.ComercialDataSet.tipogastos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.gastos' Puede moverla o quitarla según sea necesario.
        'Me.GastosTableAdapter.Fill(Me.ComercialDataSet.gastos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        enablebuttons(False)
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

        idevento = CajaseventosTableAdapter.cajaseventos_isopen(gidcaja)
        If idevento = 0 Then
            MsgBox("La Caja se encuentra CERRADA", MsgBoxStyle.Information, "Aviso")
            enablebuttons(False)
            Return
        Else

            enablebuttons(True)
            DescripcionTextBox.Text = ""
            MontoTextBox.Text = ""
            FechagastoDateTimePicker.Value = Today

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DescripcionTextBox.Text.Length = 0 Then
            MsgBox("Debe cargar una Descripción", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        If MontoTextBox.Text.Length = 0 Then
            MsgBox("Debe cargar una Monto", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        If Not ComboTipoGasto.SelectedValue > 0 Then
            MsgBox("Indique tipo de gasto", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        If Not ComboTipoComprobante.SelectedValue > 0 Then
            MsgBox("Indique tipo de gasto", MsgBoxStyle.Information, "Aviso")
            Return
        End If

        Dim idgasto As Long

        If MsgBox("Seguro desea Guardar " + DescripcionTextBox.Text + " por un monto de: " + MontoTextBox.Text + " ?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Try
                Dim monto As Decimal = MontoTextBox.Text 'CDbl(MontoTextBox.Text)
                Dim tipogasto As Int16 = ComboTipoGasto.SelectedValue
                Dim tipocomprobante As Int16 = ComboTipoComprobante.SelectedValue
                idgasto = GastosTableAdapter.gastos_insertar(DescripcionTextBox.Text, monto, Now(), tipogasto, tipocomprobante, 1)
                'MsgBox(gusername)
                CajasoperacionesTableAdapter.cajasoperaciones_insertargasto(idevento, 1, monto, idgasto, gusername)
                ''*******************************************************
                MsgBox("Gasto cargado exitosamente!", MsgBoxStyle.Information)
                enablebuttons(False)
                DescripcionTextBox.Text = ""
                MontoTextBox.Text = ""
                FechagastoDateTimePicker.Value = Today
                ComboTipoGasto.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("Ha ocurrido una excepción: " + ex.Message, MsgBoxStyle.Information, "Aviso")
            End Try
            ''*******************************************************
        Else
            MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub MontoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub MontoTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles MontoTextBox.TextChanged

    End Sub

    Private Sub MontoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MontoTextBox.KeyPress
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

    Private Sub ABMGastos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub
End Class