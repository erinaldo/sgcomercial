Public Class SCAltaDispositivo
    Private Sub SCAltaDispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SiscomDataSet.clientessucursales' Puede moverla o quitarla según sea necesario.

        Try
            Me.ClientesTableAdapter.Fill(Me.SiscomDataSet.clientes)
            LabelMachineName.Text = MachineName
        Catch ex As Exception
            MsgBox("Servicio no dispobible, intente nuevamente más tarde")
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ComboSucursal.SelectedValue > 0 Then
            MsgBox("Debe ingresar un numero de sucursal a este dispositivo")
            Return
        End If

        MachineKey = "LLAuth" + gmacadress
        '****Licencia local********
        Dim parametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
        parametrosgeneralesTableAdapter = New comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        '****   ----    ********
        Dim NextTime As DateTime = Now
        NextTime = NextTime.AddDays(7)
        Try
            If TerminalesTableAdapter.terminales_existe(gmacadress) = 0 Then
                Dim cliente As Int64 = ComboCliente.SelectedValue
                ' values                                (@idcliente, @mac, @nombre, @tvid,sysdate(),DATE_ADD(sysdate(), INTERVAL 10 DAY))   
                TerminalesTableAdapter.terminales_alta(cliente, gmacadress, MachineName, TextBoxTvID.Text, Now, NextTime, Val(ComboSucursal.SelectedValue))
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
                MsgBox("Éste dispositivo ya se encuentra registrado en la nube")
                '**************** REGISTRO LICENCIA LOCAL *********************************
                'Try
                '    If parametrosgeneralesTableAdapter.parametrosgenerales_existeclave(MachineKey) = 0 Then
                '        parametrosgeneralesTableAdapter.parametrosgenerales_insertar(MachineKey, Nothing, NextTime, Nothing, Nothing)
                '    Else
                '        parametrosgeneralesTableAdapter.parametrosgenerales_updateprgstring1(MachineKey, NextTime)
                '    End If
                'Catch ex As Exception
                '    MsgBox("Ocurrio un problema al tratar de generar la licencia local: " + ex.Message)
                'End Try
                '**************** REGISTRO LICENCIA LOCAL *********************************
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un problema al tratar de dar de alta el equipo: " + ex.Message)
        End Try

    End Sub

    Private Sub ComboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCliente.SelectedIndexChanged
        Me.ClientessucursalesTableAdapter.FillByIDcliente(Me.SiscomDataSet.clientessucursales, ComboCliente.SelectedValue)
    End Sub

    Private Sub ComboSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSucursal.SelectedIndexChanged

    End Sub
End Class