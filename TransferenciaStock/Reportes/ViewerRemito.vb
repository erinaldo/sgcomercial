Public Class ViewerRemito
    Private Sub ViewerRemito_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ViewerRemito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '********** lista de referencia franquicia
        Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Dim v_ListaRefFranquicia As Integer
        v_ListaRefFranquicia = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("ListaRefFranquicia")
        'ComboListasRefFranquicia.SelectedValue = v_ListaRefFranquicia
        '**********
        ''''''''''''''''''''''''''''--CLOWD--''''''''''''''''''''''''''''''''''''''''''''''
        Dim ModulosTableAdapter As comercialDataSetTableAdapters.modulosTableAdapter
        ModulosTableAdapter = New comercialDataSetTableAdapters.modulosTableAdapter()
        Try
            gMiFranquicia = ModulosTableAdapter.modulos_consultarestado("ModuloFranquicia")
        Catch ex As Exception
            gMiFranquicia = 0
            Return
        End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If gMiFranquicia = 1 Or v_ListaRefFranquicia = 3 Or v_ListaRefFranquicia = 4 Then
            MostrarCostosToolStripMenuItem.Visible = False
        Else
            MostrarCostosToolStripMenuItem.Visible = True
        End If
        '*************************

        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.listaremitosTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitos, gidremito)
        Me.listaremitosdetalleTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitosdetalle, gidremito)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursalSinCostos.rdlc"


        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub OcultarCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcultarCostosToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.listaremitosTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitos, gidremito)
        Me.listaremitosdetalleTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitosdetalle, gidremito)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursalSinCostos.rdlc"
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub MostrarCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarCostosToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.listaremitosTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitos, gidremito)
        Me.listaremitosdetalleTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitosdetalle, gidremito)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursal.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub MostrarTotalEnvasadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarTotalEnvasadoToolStripMenuItem.Click
        Me.MiComercioTableAdapter.Fill(Me.comercialDataSet.MiComercio)
        Me.listaremitosTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitos, gidremito)
        Me.listaremitosdetalleTableAdapter.FillByIDRemito(Me.comercialDataSet.listaremitosdetalle, gidremito)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sgcomercial.RepEnvioSucursalTotEnvasado.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class