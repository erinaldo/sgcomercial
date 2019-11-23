Imports System.Text.RegularExpressions

Public Class ABMExtracciones
    Dim idevento As Long = 0
    Public Sub enablebuttons(ByVal status As Boolean)
        If status = True Then
            BtnNuevo.Enabled = False
        Else
            BtnNuevo.Enabled = True
        End If
        RadioDeposito.Enabled = status
        RadioExtraccion.Enabled = status
        Button1.Enabled = status
        DescripcionTextBox.Enabled = status
        MontoTextBox.Enabled = status
        'FechagastoDateTimePicker.Enabled = status
    End Sub
    Private Sub ExtraccionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ExtraccionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComercialDataSet)

    End Sub

    Private Sub ABMExtracciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        'Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        'Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        ''TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.extracciones' Puede moverla o quitarla según sea necesario.
        'Me.ExtraccionesTableAdapter.Fill(Me.ComercialDataSet.extracciones)
        enablebuttons(False)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '*************** GUARDAR EXTRACCION/INGRESO ***************************
        If RadioExtraccion.Checked = False And RadioDeposito.Checked = False Then
            MsgBox("Debe seleccionar el tipo de operación a realizar", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        If DescripcionTextBox.Text.Length = 0 Then
            MsgBox("Debe cargar una Descripción", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        If MontoTextBox.Text.Length = 0 Then
            MsgBox("Debe cargar una Monto", MsgBoxStyle.Information, "Aviso")
            Return
        End If

        Dim idgasto As Long

        If MsgBox("Seguro desea Guardar " + DescripcionTextBox.Text + " por un monto de: " + MontoTextBox.Text + " ?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            If RadioExtraccion.Checked = True Then
                ''*******************************************************
                idgasto = ExtraccionesTableAdapter.extracciones_insertar(DescripcionTextBox.Text, CDbl(MontoTextBox.Text), Now())
                'MsgBox(gusername)
                CajasoperacionesTableAdapter.cajasoperaciones_insertarextraccion(idevento, 1, CDbl(MontoTextBox.Text), idgasto, gusername)
                ''*******************************************************
                MsgBox("Operación cargada exitosamente!", MsgBoxStyle.Information)
                enablebuttons(False)
                DescripcionTextBox.Text = ""
                MontoTextBox.Text = ""
                FechagastoDateTimePicker.Value = Today
            End If
            If RadioDeposito.Checked = True Then
                Dim DepositosTableAdapter As New comercialDataSetTableAdapters.depositosTableAdapter()
                idgasto = DepositosTableAdapter.depositos_insertar(DescripcionTextBox.Text, CDbl(MontoTextBox.Text), Now())
                CajasoperacionesTableAdapter.cajasoperaciones_insertardeposito(idevento, 1, CDbl(MontoTextBox.Text), idgasto, gusername)
                MsgBox("Operación cargada exitosamente!", MsgBoxStyle.Information)
                enablebuttons(False)
                DescripcionTextBox.Text = ""
                MontoTextBox.Text = ""
                FechagastoDateTimePicker.Value = Today
            End If
        Else
            MsgBox("Operacion Cancelada", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub MontoTextBox_TextChanged(sender As Object, e As EventArgs) Handles MontoTextBox.TextChanged

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

    Private Sub ABMExtracciones_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
End Class