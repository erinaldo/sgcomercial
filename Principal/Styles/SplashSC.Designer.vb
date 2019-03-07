<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashSC
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashSC))
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLayoutPanel.ColumnCount = 1
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.MainLayoutPanel.Controls.Add(Me.Version, 0, 3)
        Me.MainLayoutPanel.Controls.Add(Me.mensaje, 0, 1)
        Me.MainLayoutPanel.Controls.Add(Me.ProgressBar1, 0, 0)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 2
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(496, 303)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.White
        Me.Version.Location = New System.Drawing.Point(3, 270)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(490, 20)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Versión {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mensaje
        '
        Me.mensaje.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mensaje.BackColor = System.Drawing.Color.Transparent
        Me.mensaje.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.Color.White
        Me.mensaje.Location = New System.Drawing.Point(44, 218)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(407, 20)
        Me.mensaje.TabIndex = 2
        Me.mensaje.Text = "conectando a la base de datos"
        Me.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(490, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'SplashSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashSC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents Version As Label
    Friend WithEvents mensaje As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
