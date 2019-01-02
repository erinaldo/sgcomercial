Imports System.ComponentModel

Public Class Cajasmovimientos
    Private Sub Cajasmovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.v_gastos' Puede moverla o quitarla según sea necesario.

        'Me.CajasoperacionesTableAdapter.Fill(Me.ComercialDataSet.cajasoperaciones)
        Me.PerfilesTableAdapter.Fill(Me.ComercialDataSet.perfiles)
        Me.CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        CajaseventosDataGridView.Sort(CajaseventosDataGridView.Columns(0), ListSortDirection.Descending)
        ''*****************************

        Me.ingresosGraphTableAdapter.FillByidevento(Me.ComercialDataSet.ingresosGraph, CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString)
        Me.ReportViewer2.RefreshReport()
        Me.V_gastosTableAdapter.FillByidevento(Me.ComercialDataSet.v_gastos, CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString)
        Me.ReportViewer3.RefreshReport()

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

        Me.ingresosGraphTableAdapter.FillByidevento(Me.ComercialDataSet.ingresosGraph, CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString)
        Me.ReportViewer2.RefreshReport()

        Me.V_gastosTableAdapter.FillByidevento(Me.ComercialDataSet.v_gastos, CajaseventosDataGridView.CurrentRow.Cells(0).Value().ToString)
        Me.ReportViewer3.RefreshReport()

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


    Private Sub CajaseventosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CajaseventosDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CajaseventosTableAdapter.Fill(Me.ComercialDataSet.cajaseventos)
        CajasmovimientosBindingSource.Filter = "idevento = 0"
        VgastosBindingSource.Filter = "idevento = 0"
        CajaseventosDataGridView.Rows(CajaseventosDataGridView.CurrentRow.Index).Selected = False
    End Sub



    Private Sub MovimientoscajasDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        gideventoseleccionado = CajaseventosDataGridView.Rows(CajaseventosDataGridView.CurrentRow.Index).Cells("IdeventoDataGridViewTextBoxColumn").Value

        If gideventoseleccionado > 0 Then
            '************ abro pantalla arqueo FINAL para ver estado ******************
            Dim p As VerEstadoCaja
            p = New VerEstadoCaja
            'p.Button1.Enabled = False
            p.Text = "Estado de Caja"
            p.ShowDialog()
            gideventoseleccionado = Nothing
        Else
            MsgBox("No se puede cargar el resumen de caja", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub V_gastosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ReportViewer2_Load(sender As Object, e As EventArgs) Handles ReportViewer2.Load

    End Sub

    Private Sub ReportViewer2_Click(sender As Object, e As EventArgs) Handles ReportViewer2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim z As DetalleEgresos
        z = New DetalleEgresos
        gideventoseleccionado = CajaseventosDataGridView.CurrentRow.Cells("IdeventoDataGridViewTextBoxColumn").Value
        'MsgBox(gideventoseleccionado.ToString)
        z.ShowDialog()
    End Sub

    Private Sub ReportViewer2_CausesValidationChanged(sender As Object, e As EventArgs) Handles ReportViewer2.CausesValidationChanged

    End Sub

    Private Sub ReportViewer2_DoubleClick(sender As Object, e As EventArgs) Handles ReportViewer2.DoubleClick

    End Sub

    Private Sub ReportViewer2_MouseClick(sender As Object, e As MouseEventArgs) Handles ReportViewer2.MouseClick

    End Sub

    Private Sub ReportViewer2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ReportViewer2.MouseDoubleClick

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim z As DetalleIngresos
        z = New DetalleIngresos
        gideventoseleccionado = CajaseventosDataGridView.CurrentRow.Cells("IdeventoDataGridViewTextBoxColumn").Value
        'MsgBox(gideventoseleccionado.ToString)
        z.ShowDialog()
    End Sub
End Class