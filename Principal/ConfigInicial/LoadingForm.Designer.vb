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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'mensaje
        '
        Me.mensaje.BackColor = System.Drawing.Color.Transparent
        Me.mensaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.mensaje.Font = New System.Drawing.Font("Exo 2.0 Medium", 14.0!)
        Me.mensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mensaje.Location = New System.Drawing.Point(0, 0)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(596, 31)
        Me.mensaje.TabIndex = 0
        Me.mensaje.Text = "Encendiendo el Sistema"
        Me.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar.Location = New System.Drawing.Point(0, 47)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(596, 30)
        Me.ProgressBar.Step = 2
        Me.ProgressBar.TabIndex = 1
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(596, 77)
        Me.ControlBox = False
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LoadingForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "LoadingForm"
        Me.Text = "Iniciando Sistema..."
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mensaje As Label
    Friend WithEvents ProgressBar As ProgressBar
End Class
