<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mensaje
        '
        Me.mensaje.Font = New System.Drawing.Font("Exo 2.0 Medium", 14.0!)
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(1, 3)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(610, 42)
        Me.mensaje.TabIndex = 0
        Me.mensaje.Text = "Encendiendo el Sistema"
        Me.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(604, 118)
        Me.ControlBox = False
        Me.Controls.Add(Me.mensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LoadingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "LoadingForm"
        Me.Text = "Iniciando Sistema..."
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mensaje As Label
End Class
