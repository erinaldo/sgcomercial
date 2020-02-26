Public Class ConfiguracionesFranquicia
    Private Sub ConfiguracionesFranquicia_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            If MsgQues("Seguro desea salir de " + Me.Text) = True Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ConfiguracionesFranquicia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.Icon = SCFORMICON
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.listasprecios' Puede moverla o quitarla según sea necesario.
        Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.ListaspreciosTableAdapter.FillByListasRefFranquicia(Me.ComercialDataSet.listasprecios)
        '/******************************************************************/
        '********** lista de referencia franquicia
        Dim v_ListaRefFranquicia As Integer
        v_ListaRefFranquicia = ParametrosgeneralesTableAdapter.parametrosgenerales_getprgvalor1byclave("ListaRefFranquicia")
        ComboListasRefFranquicia.SelectedValue = v_ListaRefFranquicia
        '**********
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MessageBox.Show("Seguro desea guardar los cambios?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Return
        Try
            Dim ParametrosgeneralesTableAdapter As New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
            '***************    ValidarDatosNuevosClientes   ******************************************
            ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("ListaRefFranquicia", ComboListasRefFranquicia.SelectedValue, Nothing, Nothing)
            '***************    -----------     FIN  ------------   
            '-----------  ******************************************

            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrió una excepción: ", ex.Message)
        End Try

    End Sub
End Class