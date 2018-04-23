Imports System.ComponentModel

Public Class Cajasmovimientos
    Private Sub Cajasmovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        CajaseventosDataGridView.Sort(CajaseventosDataGridView.Columns(0), ListSortDirection.Descending)
        ''*****************************
        Me.CajasmovimientosTableAdapter.Fill(Me.ComercialDataSet.cajasmovimientos)
        Me.V_gastosTableAdapter.Fill(Me.ComercialDataSet.v_gastos)
        ''*****************************
        If CajaseventosDataGridView.RowCount > 0 Then
            CajasmovimientosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
        End If
        If CajaseventosDataGridView.RowCount > 0 Then
            VgastosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
            ''******** calcular totales
            calculartotales(CajaseventosDataGridView.CurrentRow.Cells(0).Value())
        End If


    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        'MsgBox("fechaapertura = '" + DateTimePicker1.Text + "'")
        'CajaseventosBindingSource.Filter = "fechaapertura > " + DateTimePicker1.Value.ToString + ""
        CajaseventosTableAdapter.FillByfecha(Me.ComercialDataSet.cajaseventos, DateTimePicker1.Text)


        CajasmovimientosBindingSource.Filter = "idevento = 0"

        VgastosBindingSource.Filter = "idevento = 0"
    End Sub

    Private Sub CajaseventosDataGridView_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CajaseventosDataGridView.BindingContextChanged

    End Sub

    Private Sub CajaseventosDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CajaseventosDataGridView.CellClick
       
        '***************************** cargar datos
        Me.CajasmovimientosTableAdapter.Fill(Me.ComercialDataSet.cajasmovimientos)
        Me.V_gastosTableAdapter.Fill(Me.ComercialDataSet.v_gastos)
        '***************************** filtrar ingresos y gastos
        CajasmovimientosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
        VgastosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
        calculartotales(CajaseventosDataGridView.CurrentRow.Cells(0).Value())


        'MsgBox(CajaseventosDataGridView.CurrentCell.ColumnIndex)

        Select Case CajaseventosDataGridView.CurrentCell.ColumnIndex
            Case 6
                If IsDBNull(CajaseventosDataGridView.CurrentRow.Cells(5).Value()) Then
                    MsgBox("La caja seleccionada se encuentra abierta!")
                    Return
                End If
                gidevento = CajaseventosDataGridView.CurrentRow.Cells(0).Value()
                Dim C As ReporteCierreCaja
                C = New ReporteCierreCaja
                C.ShowDialog()
                gidevento = 0
        End Select

    End Sub
    Public Sub calculartotales(ByVal idevento As Long)
        Dim monto As Decimal = 0
        Dim total As Decimal = 0
        '***************************** calcular total ingresos
        total = CajasoperacionesTableAdapter.cajasoperaciones_totalpagos(CajaseventosDataGridView.CurrentRow.Cells(0).Value())
        lbltotal.Text = "$ " + total.ToString
        '***************************** calcular total gastos
        total = 0
        total = CajasoperacionesTableAdapter.cajasoperaciones_totalgastos(CajaseventosDataGridView.CurrentRow.Cells(0).Value())
        lblgastos.Text = "$ " + total.ToString
        '*******************************************************************************
    End Sub

    Private Sub CajaseventosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CajaseventosDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        CajasmovimientosBindingSource.Filter = "idevento = 0"
        VgastosBindingSource.Filter = "idevento = 0"
        CajaseventosDataGridView.Rows(CajaseventosDataGridView.CurrentRow.Index).Selected = False
    End Sub

    Private Sub MovimientoscajasDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MovimientoscajasDataGridView.CellClick
        If MovimientoscajasDataGridView.CurrentRow.Cells(3).Value = "Cambio Dif. (+)" Then Return
        Dim i As Integer = 0
        If MovimientoscajasDataGridView.CurrentCell.ColumnIndex >= 0 Then
            Select Case MovimientoscajasDataGridView.CurrentCell.ColumnIndex
                Case 3
                    Dim p As ConsultarVenta
                    p = New ConsultarVenta
                    gidoperacion = MovimientoscajasDataGridView.CurrentRow.Cells(6).Value
                    gidventa = CajasoperacionesTableAdapter.cajasoperaciones_consultaridventa(gidoperacion)
                    p.ShowDialog()
                Case 4
                    Dim p As ConsultarVenta
                    p = New ConsultarVenta
                    gidoperacion = MovimientoscajasDataGridView.CurrentRow.Cells(6).Value
                    gidventa = CajasoperacionesTableAdapter.cajasoperaciones_consultaridventa(gidoperacion)
                    p.ShowDialog()
                Case 5
                    If MsgBox("Seguro desea anular la operación?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                        CajasoperacionesTableAdapter.cajasoperaciones_bajaoperacionventa(MovimientoscajasDataGridView.CurrentRow.Cells(6).Value, gusername)
                        '***************************** cargar datos
                        Me.CajasmovimientosTableAdapter.Fill(Me.ComercialDataSet.cajasmovimientos)
                        Me.V_gastosTableAdapter.Fill(Me.ComercialDataSet.v_gastos)
                        '***************************** filtrar ingresos y gastos
                        CajasmovimientosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
                        VgastosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
                        calculartotales(CajaseventosDataGridView.CurrentRow.Cells(0).Value())

                    End If
            End Select
        End If
    End Sub

    Private Sub MovimientoscajasDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MovimientoscajasDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        gideventoseleccionado = CajaseventosTableAdapter.cajaseventos_isopen(CajaseventosDataGridView.Rows(CajaseventosDataGridView.CurrentRow.Index).Cells(1).Value)

        If gideventoseleccionado > 0 Then
            '************ abro pantalla arqueo FINAL para ver estado ******************
            Dim p As VerEstadoCaja
            p = New VerEstadoCaja
            p.Button1.Enabled = False
            p.Text = "Estado de Caja"
            p.ShowDialog()
            gideventoseleccionado = Nothing
        Else
            MsgBox("Caja cerrada!", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub V_gastosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles V_gastosDataGridView.CellContentClick

    End Sub

    Private Sub V_gastosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles V_gastosDataGridView.CellClick
        Dim i As Integer = 0
        If V_gastosDataGridView.CurrentCell.ColumnIndex >= 0 Then
            Select Case V_gastosDataGridView.CurrentCell.ColumnIndex
                Case 4 '*****************ANULAR GASTO*****************************
                    If MsgBox("Seguro desea anular la operación (Anular gasto)?", MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                        CajasoperacionesTableAdapter.cajasoperaciones_bajaopgasto(V_gastosDataGridView.CurrentRow.Cells(1).Value, gusername)
                        ''***************************** cargar datos
                        Me.CajasmovimientosTableAdapter.Fill(Me.ComercialDataSet.cajasmovimientos)
                        Me.V_gastosTableAdapter.Fill(Me.ComercialDataSet.v_gastos)
                        ''***************************** filtrar ingresos y gastos
                        CajasmovimientosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
                        VgastosBindingSource.Filter = " idevento = " + CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString
                        calculartotales(CajaseventosDataGridView.CurrentRow.Cells(0).Value())
                    End If
            End Select
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class