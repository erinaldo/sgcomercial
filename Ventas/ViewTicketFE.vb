Public Class ViewTicketFE
    Private Sub ViewTicketFE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ErrorLogTableAdapter As New comercialDataSetTableAdapters.errorlogTableAdapter()
        Try
            Dim p As ViewerFactura
            p = New ViewerFactura
            'p.MdiParent = Me.ParentForm
            p.ShowInTaskbar = True
            'p.TopMost = True
            p.ShowDialog()
        Catch ex As Exception
            ErrorLogTableAdapter.errorlog_insertar("Registrar Venta", "Aplicacion", "Confirmar", ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As New GetMailCliente
        p.ShowDialog()
        If IsValidEmailFormat(EmailTo) Then
            MsgBox("se envia mail")
        Else
            MessageBox.Show("E-mail Inválido!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ViewTicketFE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ''''''''''***************************   POR DEFECTO **************************************
        If e.KeyCode = Keys.Escape Then
            'If MsgBox("Seguro desea salir de " + Me.Text, MsgBoxStyle.YesNo, "Pregunta") = vbYes Then
            Me.Close()
            'End If
        End If

        ''''''''''''''''''''*******************************************'''''''''''''''''''''
    End Sub
End Class