Public Class frmAlert
    Enum alertTypeEnum
        Success
        Warning
        Err
        Info
    End Enum
    Dim x, y As Integer
    Public Sub setAlert(msg As String, codalerta As String, type As alertTypeEnum)
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        Dim fname As String
        For i As Integer = 1 To 10
            fname = "alert" & i.ToString
            Dim f As frmAlert = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Me.Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case alertTypeEnum.Err
                PictureBox1.Image = sgcomercial.My.Resources.Resources.Alert_error
                Me.BackColor = Color.FromArgb(255, 121, 70)
            Case alertTypeEnum.Info
                PictureBox1.Image = sgcomercial.My.Resources.Resources.Alert_information
                Me.BackColor = Color.FromArgb(71, 169, 248)
            Case alertTypeEnum.Success
                PictureBox1.Image = sgcomercial.My.Resources.Resources.Alert_check
                Me.BackColor = Color.FromArgb(42, 171, 160)
            Case alertTypeEnum.Warning
                PictureBox1.Image = sgcomercial.My.Resources.Resources.Alert_warning
                Me.BackColor = Color.FromArgb(230, 140, 60)
        End Select
        Me.LabelMsg.Text = msg
        Me.LabelMsg.Tag = codalerta
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub
    Enum actionEnum
        wait
        start
        close
        open
    End Enum
    Private action As actionEnum = action.start

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case actionEnum.start
                Me.Timer1.Interval = 1
                Me.Opacity += 0.1
                If x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1 Then
                        action = actionEnum.wait
                    End If
                End If
            Case actionEnum.wait
                Timer1.Interval = 4000
                action = actionEnum.close
            Case actionEnum.close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Me.Close()
                End If
            Case actionEnum.open
                '********************************************************/
                Try
                    Dim PermisosTableAdapter As New comercialDataSetTableAdapters.permisosTableAdapter()
                    Select Case LabelMsg.Tag
                        Case "STK"
                            If PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "StockAlerta") = 1 Then
                                StockAlerta.MdiParent = FormPrincipal
                                StockAlerta.Visible = True
                            End If
                        Case "PPD"
                            If PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "PedidosDeliveryDespacho") = 1 Then
                                PedidosDeliveryDespacho.MdiParent = FormPrincipal
                                PedidosDeliveryDespacho.Visible = True
                            End If
                        Case "PPV"
                            If PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "LibroVencimientosProductos") = 1 Then
                                LibroVencimientosProductos.MdiParent = FormPrincipal
                                LibroVencimientosProductos.Visible = True
                            End If
                        Case "CCV"
                            If PermisosTableAdapter.permisos_consultabymenuname(guserprofile, "LibroCuentasCorrientes") = 1 Then
                                LibroCuentasCorrientes.MdiParent = FormPrincipal
                                LibroCuentasCorrientes.Visible = True
                            End If
                    End Select
                Catch
                End Try
                '********************************************************/
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Timer1.Interval = 1
        action = actionEnum.close
    End Sub

    Private Sub LabelMsg_Click(sender As Object, e As EventArgs) Handles LabelMsg.Click
        Me.Timer1.Interval = 1
        action = actionEnum.open
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Timer1.Interval = 1
        action = actionEnum.open
    End Sub

    Private Sub frmAlert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class