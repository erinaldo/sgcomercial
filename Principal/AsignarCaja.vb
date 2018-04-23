Public Class AsignarCaja
    Dim idcaja As Integer = 0
    Dim descripcion As String = ""


    Private Sub AsignarCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ComercialDataSet.cajas' Puede moverla o quitarla según sea necesario.
        Me.CajasTableAdapter.Fill(Me.ComercialDataSet.cajas)
        Labelmac.Text = gmacadress
        CajasBindingSource.Filter = "estado = 'ACTIVA'"

        gidcaja = 0
        gidcaja = ParametrosgeneralesTableAdapter1.parametrosgenerales_getprgvalor1byprgstring1(gmacadress)

        If gidcaja = 0 Then
            Labelcajanumero.Text = "-"
        Else
            Labelcajanumero.Text = gidcaja.ToString
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '****************** asignacion de caja  *****************************************
        Dim rtn As Integer = 0
        Dim caja1 As String
        Dim caja2 As String

        If idcaja = 0 Or descripcion = "" Then
            MsgBox("Primero seleccione una caja", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If

        caja1 = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("Caja1")
        caja2 = ParametrosgeneralesTableAdapter.parametrosgenerales_GetPrgstring1("Caja2")

        If gmacadress = caja1 Then
            If MsgBox("Este ordenador ya se encuentra asignada a la CAJA 1. Desea reasignar?", MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("Caja1", 1, "SinConfigurar", Nothing)
            Else
                Return
            End If
        End If

        If gmacadress = caja2 Then
            If MsgBox("Este ordenador ya se encuentra asignada a la CAJA 2. Desea reasignar?", MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then
                ParametrosgeneralesTableAdapter.parametrosgenerales_updatebyprgclave("Caja2", 2, "SinConfigurar", Nothing)
            Else
                Return
            End If
        End If


        '******************************
        Select Case idcaja
            Case 1
                rtn = ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("Caja1", gmacadress)
                If Not rtn = 0 Then
                    MsgBox("Asignacion CAJA 1 correcta!", MsgBoxStyle.Information, "Mensaje")
                    '/*******************   refrescar labelcaja     *********************************/
                    Me.Close()
                    Return
                End If
            Case 2
                rtn = ParametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1("Caja2", gmacadress)
                If Not rtn = 0 Then
                    MsgBox("Asignacion CAJA 2 correcta!", MsgBoxStyle.Information, "Mensaje")
                    Me.Close()
                    Return
                End If
        End Select
        '*********************************

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString, MsgBoxStyle.Exclamation, DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
        Try
            descripcion = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            idcaja = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub AsignarCaja_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus




        Dim i As Integer = 0
        For i = 0 To DataGridView1.RowCount - 1
            DataGridView1.Rows(i).Selected = False
        Next


    End Sub
End Class