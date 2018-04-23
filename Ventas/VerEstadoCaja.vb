Public Class VerEstadoCaja
    Private Sub VerEstadoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajaseventos' Puede moverla o quitarla según sea necesario.
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajasoperaciones' Puede moverla o quitarla según sea necesario.
        Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        '---------------------------
        numIngresos.Value = CajasoperacionesTableAdapter.cajasoperaciones_totalpagos(gideventoseleccionado)
        numEgresos.Value = CajasoperacionesTableAdapter.cajasoperaciones_totalgastos(gideventoseleccionado)
        '--------------------------
        gmontofinal = CajasoperacionesTableAdapter.cajasoperaciones_montoneto(gideventoseleccionado)
        Enteros.Value = gmontofinal
        Enteros.Select()
        NumericUpDown1.Value = CajaseventosTableAdapter.cajaseventos_saldoinicial(gideventoseleccionado)
    End Sub
End Class