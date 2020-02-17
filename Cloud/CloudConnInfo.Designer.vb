<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloudConnInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CloudConnInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelCloudServer = New System.Windows.Forms.Label()
        Me.LabelDBUser = New System.Windows.Forms.Label()
        Me.LabelDBName = New System.Windows.Forms.Label()
        Me.LabelSCAuthServer = New System.Windows.Forms.Label()
        Me.LabelSCAuthUser = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelSCAuthUser)
        Me.GroupBox1.Controls.Add(Me.LabelSCAuthServer)
        Me.GroupBox1.Controls.Add(Me.LabelDBName)
        Me.GroupBox1.Controls.Add(Me.LabelDBUser)
        Me.GroupBox1.Controls.Add(Me.LabelCloudServer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelCloudServer
        '
        Me.LabelCloudServer.AutoSize = True
        Me.LabelCloudServer.Location = New System.Drawing.Point(84, 42)
        Me.LabelCloudServer.Name = "LabelCloudServer"
        Me.LabelCloudServer.Size = New System.Drawing.Size(90, 17)
        Me.LabelCloudServer.TabIndex = 0
        Me.LabelCloudServer.Text = "CloudServer:"
        '
        'LabelDBUser
        '
        Me.LabelDBUser.AutoSize = True
        Me.LabelDBUser.Location = New System.Drawing.Point(84, 73)
        Me.LabelDBUser.Name = "LabelDBUser"
        Me.LabelDBUser.Size = New System.Drawing.Size(61, 17)
        Me.LabelDBUser.TabIndex = 0
        Me.LabelDBUser.Text = "DBUser:"
        '
        'LabelDBName
        '
        Me.LabelDBName.AutoSize = True
        Me.LabelDBName.Location = New System.Drawing.Point(84, 106)
        Me.LabelDBName.Name = "LabelDBName"
        Me.LabelDBName.Size = New System.Drawing.Size(68, 17)
        Me.LabelDBName.TabIndex = 0
        Me.LabelDBName.Text = "DBName:"
        '
        'LabelSCAuthServer
        '
        Me.LabelSCAuthServer.AutoSize = True
        Me.LabelSCAuthServer.Location = New System.Drawing.Point(84, 142)
        Me.LabelSCAuthServer.Name = "LabelSCAuthServer"
        Me.LabelSCAuthServer.Size = New System.Drawing.Size(101, 17)
        Me.LabelSCAuthServer.TabIndex = 0
        Me.LabelSCAuthServer.Text = "SCAuthServer:"
        '
        'LabelSCAuthUser
        '
        Me.LabelSCAuthUser.AutoSize = True
        Me.LabelSCAuthUser.Location = New System.Drawing.Point(84, 173)
        Me.LabelSCAuthUser.Name = "LabelSCAuthUser"
        Me.LabelSCAuthUser.Size = New System.Drawing.Size(89, 17)
        Me.LabelSCAuthUser.TabIndex = 0
        Me.LabelSCAuthUser.Text = "SCAuthUser:"
        '
        'ClowdConnInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClowdConnInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cloud Connection Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelSCAuthUser As Label
    Friend WithEvents LabelSCAuthServer As Label
    Friend WithEvents LabelDBName As Label
    Friend WithEvents LabelDBUser As Label
    Friend WithEvents LabelCloudServer As Label
End Class
