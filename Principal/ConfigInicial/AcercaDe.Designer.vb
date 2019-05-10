<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcercaDe
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
        Me.OKButton = New System.Windows.Forms.Button()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.IDTerminal = New System.Windows.Forms.Label()
        Me.Terminal = New System.Windows.Forms.Label()
        Me.IDCliente = New System.Windows.Forms.Label()
        Me.NombreCliente = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelTipoLicencia = New System.Windows.Forms.Label()
        Me.LabelVencimiento = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(276, 47)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(4)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(87, 37)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&Aceptar"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(11, 91)
        Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(158, 17)
        Me.LabelCompanyName.TabIndex = 0
        Me.LabelCompanyName.Text = "Nombre de la compañía"
        Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Location = New System.Drawing.Point(11, 70)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(68, 17)
        Me.LabelCopyright.TabIndex = 0
        Me.LabelCopyright.Text = "Copyright"
        Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(11, 49)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(56, 17)
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Versión"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(11, 28)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(138, 17)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Nombre de producto"
        Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoPictureBox.Image = Global.sgcomercial.My.Resources.Resources.appicon
        Me.LogoPictureBox.Location = New System.Drawing.Point(4, 4)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(276, 260)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'IDTerminal
        '
        Me.IDTerminal.AutoSize = True
        Me.IDTerminal.Location = New System.Drawing.Point(11, 103)
        Me.IDTerminal.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.IDTerminal.MaximumSize = New System.Drawing.Size(0, 21)
        Me.IDTerminal.Name = "IDTerminal"
        Me.IDTerminal.Size = New System.Drawing.Size(76, 17)
        Me.IDTerminal.TabIndex = 11
        Me.IDTerminal.Text = "IDTerminal"
        Me.IDTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Terminal
        '
        Me.Terminal.AutoSize = True
        Me.Terminal.Location = New System.Drawing.Point(11, 80)
        Me.Terminal.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.Terminal.MaximumSize = New System.Drawing.Size(0, 21)
        Me.Terminal.Name = "Terminal"
        Me.Terminal.Size = New System.Drawing.Size(63, 17)
        Me.Terminal.TabIndex = 7
        Me.Terminal.Text = "Terminal"
        Me.Terminal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IDCliente
        '
        Me.IDCliente.AutoSize = True
        Me.IDCliente.Location = New System.Drawing.Point(11, 57)
        Me.IDCliente.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.IDCliente.MaximumSize = New System.Drawing.Size(0, 21)
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.Size = New System.Drawing.Size(64, 17)
        Me.IDCliente.TabIndex = 6
        Me.IDCliente.Text = "IDCliente"
        Me.IDCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreCliente
        '
        Me.NombreCliente.AutoSize = True
        Me.NombreCliente.Location = New System.Drawing.Point(11, 34)
        Me.NombreCliente.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.NombreCliente.MaximumSize = New System.Drawing.Size(0, 21)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(101, 17)
        Me.NombreCliente.TabIndex = 2
        Me.NombreCliente.Text = "NombreCliente"
        Me.NombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.LabelProductName)
        Me.GroupBox1.Controls.Add(Me.LabelVersion)
        Me.GroupBox1.Controls.Add(Me.LabelCopyright)
        Me.GroupBox1.Controls.Add(Me.LabelCompanyName)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 130)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Software"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelTipoLicencia)
        Me.GroupBox3.Controls.Add(Me.LabelVencimiento)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(210, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(169, 125)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Licencia"
        '
        'LabelTipoLicencia
        '
        Me.LabelTipoLicencia.AutoSize = True
        Me.LabelTipoLicencia.Location = New System.Drawing.Point(4, 49)
        Me.LabelTipoLicencia.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.LabelTipoLicencia.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelTipoLicencia.Name = "LabelTipoLicencia"
        Me.LabelTipoLicencia.Size = New System.Drawing.Size(88, 17)
        Me.LabelTipoLicencia.TabIndex = 4
        Me.LabelTipoLicencia.Text = "TipoLicencia"
        Me.LabelTipoLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVencimiento
        '
        Me.LabelVencimiento.AutoSize = True
        Me.LabelVencimiento.Location = New System.Drawing.Point(4, 91)
        Me.LabelVencimiento.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.LabelVencimiento.MaximumSize = New System.Drawing.Size(0, 21)
        Me.LabelVencimiento.Name = "LabelVencimiento"
        Me.LabelVencimiento.Size = New System.Drawing.Size(66, 17)
        Me.LabelVencimiento.TabIndex = 3
        Me.LabelVencimiento.Text = "fechaven"
        Me.LabelVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.Label8.MaximumSize = New System.Drawing.Size(0, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Vencimiento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.Label7.MaximumSize = New System.Drawing.Size(0, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tipo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NombreCliente)
        Me.GroupBox2.Controls.Add(Me.OKButton)
        Me.GroupBox2.Controls.Add(Me.IDCliente)
        Me.GroupBox2.Controls.Add(Me.Terminal)
        Me.GroupBox2.Controls.Add(Me.IDTerminal)
        Me.GroupBox2.Location = New System.Drawing.Point(287, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 132)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'AcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(678, 272)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AcercaDe"
        Me.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AcercaDe"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OKButton As Button
    Friend WithEvents LabelCompanyName As Label
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelProductName As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreCliente As Label
    Friend WithEvents Terminal As Label
    Friend WithEvents IDCliente As Label
    Friend WithEvents IDTerminal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelTipoLicencia As Label
    Friend WithEvents LabelVencimiento As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
