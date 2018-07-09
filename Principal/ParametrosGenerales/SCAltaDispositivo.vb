Public Class SCAltaDispositivo
    Private Sub SCAltaDispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ClientesTableAdapter.Fill(Me.SiscomDataSet.clientes)
            LabelMachineName.Text = MachineName
        Catch ex As Exception
            MsgBox("Servicio no dispobible, intente nuevamente más tarde")
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MachineKey = "LLAuth" + gmacadress
        '****Licencia local********
        Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
        parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        '****   ----    ********
        Try
            If TerminalesTableAdapter.terminales_existe(gmacadress) = 0 Then
                Dim cliente As Int64 = ComboCliente.SelectedValue
                ' values                                (@idcliente, @mac, @nombre, @tvid,sysdate(),DATE_ADD(sysdate(), INTERVAL 10 DAY))   
                Dim NextTime As DateTime = Now
                NextTime = NextTime.AddDays(7)
                TerminalesTableAdapter.terminales_alta(cliente, gmacadress, MachineName, TextBoxTvID.Text, Now, NextTime)
                Try
                    If parametrosgeneralesTableAdapter.parametrosgenerales_existeclave(MachineKey) = 0 Then
                        parametrosgeneralesTableAdapter.parametrosgenerales_insertar(MachineKey, Nothing, NextTime, Nothing, Nothing)
                    Else
                        parametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1(MachineKey, NextTime)
                    End If
                Catch ex As Exception
                    MsgBox("Ocurrio un problema al tratar de generar la licencia local: " + ex.Message)
                End Try
                MsgBox("Operacion exitosa!", MsgBoxStyle.Information)
                Me.Close()
            Else
                MsgBox("Éste dispositivo ya se encuentra registrado")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un problema al tratar de dar de alta el equipo: " + ex.Message)
        End Try

    End Sub
End Class