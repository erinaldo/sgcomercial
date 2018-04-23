Imports System.Text.RegularExpressions

Public Class ABMVales
    Private Sub ABMVales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.vales' Puede moverla o quitarla según sea necesario.
        Me.ValesTableAdapter.Fill(Me.ComercialDataSet.vales)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.tipomotivosvales' Puede moverla o quitarla según sea necesario.
        Me.TipomotivosvalesTableAdapter.Fill(Me.ComercialDataSet.tipomotivosvales)

    End Sub

    Private Sub montoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles montoTextBox.KeyPress
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles montoTextBox.TextChanged

        'If Not Convert.ToDecimal(montoTextBox.Text) > 0 Then
        '    MsgBox("Ingrese un monto válido", MsgBoxStyle.Exclamation)
        '    montoTextBox.Select()
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''''''''''''''''''' validar carga de datos  ''''''''''''''''''''''''''''''''''
        If MotivosComboBox.Text = "" Then
            MsgBox("Debe seleccionar un motivo", MsgBoxStyle.Exclamation)
            MotivosComboBox.Select()
            Return
        End If
        '''''''''''''''''''''''''''''''''
        If Not Len(Trim(montoTextBox.Text)) > 0 Then
            MsgBox("Ingrese un monto válido", MsgBoxStyle.Exclamation)
            montoTextBox.Select()
            Return
        End If
        ''''''''''''''''''''''''''''''''''''
        If Not Convert.ToDecimal(montoTextBox.Text) > 0 Then
            MsgBox("Ingrese un monto válido", MsgBoxStyle.Exclamation)
            montoTextBox.Select()
            Return
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''
        montoTextBox.Text = Decimal.Round(Convert.ToDecimal(montoTextBox.Text), 2).ToString
        Dim RTN As Integer = 0
        If MsgBox("Seguro desea guardar el vale?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            RTN = ValesTableAdapter.vales_insertar(MotivosComboBox.Text, Decimal.Round(Convert.ToDecimal(montoTextBox.Text), 2), gusername)
            If Not RTN = 0 Then
                MsgBox("Vale N°: " + vbTab + RTN.ToString + vbTab + " generado exitosamente!")
                Me.Close()
            Else
                MsgBox("Ocurrio un error al intentar insertar el vale")
            End If
        End If
    End Sub
End Class