Public Class PopUpGetDatosFacturacion


    Private Sub PopUpGetDatosFacturacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                gTipoCbtSeleccionado = Nothing
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            gTipoCbtSeleccionado = 1
            Me.Close()
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub PopUpGetDatosFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.formaspago' Puede moverla o quitarla según sea necesario.
        Me.FormaspagoTableAdapter.Fill(Me.ComercialDataSet.formaspago)
        Me.TipocomprobantesTableAdapter.FillByEstado(Me.ComercialDataSet.tipocomprobantes, "A")
        Me.TipoconceptosTableAdapter.Fill(Me.ComercialDataSet.tipoconceptos)
        '-----------------------------------------------------
        ComboConcepto.Enabled = False
        '-----------------------------------------------------
        Me.KeyPreview = True
        Me.Icon = SCFORMICON
        '-----------------------------------------------------

    End Sub
End Class