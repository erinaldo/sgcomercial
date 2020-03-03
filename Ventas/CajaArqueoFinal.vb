Public Class CajaArqueoFinal

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gmontofinal = -1
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gmontofinal = Enteros.Value
        Me.Close()
    End Sub

    Private Sub CajaArqueoFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = SCFORMICON
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        'Me.CajaseventosTableAdapter.Fill(Me.BioaccesoDataSet.cajaseventos)
        'TODO: esta línea de código carga datos en la tabla 'BioaccesoDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        'Me.CajasoperacionesTableAdapter.Fill(Me.BioaccesoDataSet.cajasoperaciones)
        '---------------------------
        numIngresos.Value = CajasoperacionesTableAdapter.cajasoperaciones_totalpagos(gidevento)
        numEgresos.Value = CajasoperacionesTableAdapter.cajasoperaciones_totalgastos(gidevento)
        '--------------------------
        gmontofinal = 0 'CajasoperacionesTableAdapter.cajasoperaciones_montoneto(gidevento)
        'Enteros.Value = gmontofinal
        Enteros.Select()
        NumericUpDown1.Value = CajaseventosTableAdapter.cajaseventos_saldoinicial(gidcaja)
    End Sub

    Private Sub CajasoperacionesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajasoperacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BioaccesoDataSet)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        gmontofinal = Enteros.Value
        gtotaldebitos = Numericdebitos.Value
        gtotalcreditos = Numericcreditos.Value
        gtotaltransferencias = Numerictransferencias.Value
        gtotalcheques = Numericcheques.Value
        gtotaldepositos = Numericdepositos.Value
        gtotaldepositosef = NumericdepositosEF.Value
        gtotalgastos = NumericGastos.Value
        gtotalextracciones = Numericextracciones.Value
        gtotaldevolucionefectivo = NumericDevolucionef.Value
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        gmontofinal = -1
        Me.Close()
    End Sub

    Private Sub CajaArqueoFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class