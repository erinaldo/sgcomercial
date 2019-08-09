Public Class ViewerPresupuestos
    Private Sub ViewerPresupuestos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            ReportViewer1.PrintDialog()
            Me.Close()
        End If
        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub

    Private Sub ViewerPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libropresupuestosTableAdapter.FillByIDPresupuesto(Me.comercialDataSet.libropresupuestos, gidpresupuesto)
        Me.libropresupuestosdetalleTableAdapter.FillByIDPresupuesto(Me.comercialDataSet.libropresupuestosdetalle, gidpresupuesto)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Comanda80mmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Comanda80mmToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libropresupuestosTableAdapter.FillByIDPresupuesto(Me.comercialDataSet.libropresupuestos, gidpresupuesto)
        Me.libropresupuestosdetalleTableAdapter.FillByIDPresupuesto(Me.comercialDataSet.libropresupuestosdetalle, gidpresupuesto)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepPresupuesto80.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub A4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles A4ToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.libropresupuestosTableAdapter.FillByIDPresupuesto(Me.comercialDataSet.libropresupuestos, gidpresupuesto)
        Me.libropresupuestosdetalleTableAdapter.FillByIDPresupuesto(Me.comercialDataSet.libropresupuestosdetalle, gidpresupuesto)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepPresupuesto.rdlc"
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class