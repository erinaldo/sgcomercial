<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFGMembreteFirmante
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCargarCabecera = New System.Windows.Forms.Button()
        Me.PictureBoxCabecera = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonCargarFirmante = New System.Windows.Forms.Button()
        Me.PictureBoxFirmante = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxFirmante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCargarCabecera)
        Me.GroupBox1.Controls.Add(Me.PictureBoxCabecera)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cabecera / Membrete"
        '
        'ButtonCargarCabecera
        '
        Me.ButtonCargarCabecera.Location = New System.Drawing.Point(366, 203)
        Me.ButtonCargarCabecera.Name = "ButtonCargarCabecera"
        Me.ButtonCargarCabecera.Size = New System.Drawing.Size(182, 35)
        Me.ButtonCargarCabecera.TabIndex = 5
        Me.ButtonCargarCabecera.Text = "Cargar"
        Me.ButtonCargarCabecera.UseVisualStyleBackColor = True
        '
        'PictureBoxCabecera
        '
        Me.PictureBoxCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxCabecera.InitialImage = Global.sgcomercial.My.Resources.Resources.Alerta
        Me.PictureBoxCabecera.Location = New System.Drawing.Point(20, 31)
        Me.PictureBoxCabecera.Name = "PictureBoxCabecera"
        Me.PictureBoxCabecera.Size = New System.Drawing.Size(872, 158)
        Me.PictureBoxCabecera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCabecera.TabIndex = 4
        Me.PictureBoxCabecera.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonCargarFirmante)
        Me.GroupBox2.Controls.Add(Me.PictureBoxFirmante)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 210)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Firmante"
        '
        'ButtonCargarFirmante
        '
        Me.ButtonCargarFirmante.Location = New System.Drawing.Point(616, 84)
        Me.ButtonCargarFirmante.Name = "ButtonCargarFirmante"
        Me.ButtonCargarFirmante.Size = New System.Drawing.Size(182, 35)
        Me.ButtonCargarFirmante.TabIndex = 6
        Me.ButtonCargarFirmante.Text = "Cargar"
        Me.ButtonCargarFirmante.UseVisualStyleBackColor = True
        '
        'PictureBoxFirmante
        '
        Me.PictureBoxFirmante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxFirmante.InitialImage = Global.sgcomercial.My.Resources.Resources.Alerta
        Me.PictureBoxFirmante.Location = New System.Drawing.Point(21, 26)
        Me.PictureBoxFirmante.Name = "PictureBoxFirmante"
        Me.PictureBoxFirmante.Size = New System.Drawing.Size(496, 158)
        Me.PictureBoxFirmante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFirmante.TabIndex = 5
        Me.PictureBoxFirmante.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CFGMembreteFirmante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 484)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CFGMembreteFirmante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ConfigurarMembreteFirmante"
        Me.Text = "Configurar Membrete y Firmante"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBoxCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBoxFirmante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonCargarCabecera As Button
    Friend WithEvents PictureBoxCabecera As PictureBox
    Friend WithEvents ButtonCargarFirmante As Button
    Friend WithEvents PictureBoxFirmante As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
