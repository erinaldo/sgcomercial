<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MailServerConf
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TSmtpClient = New System.Windows.Forms.TextBox()
        Me.TEmailFrom = New System.Windows.Forms.TextBox()
        Me.TEmailFromPwd = New System.Windows.Forms.TextBox()
        Me.TEmailPort = New System.Windows.Forms.TextBox()
        Me.ParametrosgeneralesTableAdapter = New sgcomercial.comercialDataSetTableAdapters.parametrosgeneralesTableAdapter()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EmailFrom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EmailFromPwd"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "EmailPort"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SmtpClient"
        '
        'TSmtpClient
        '
        Me.TSmtpClient.Location = New System.Drawing.Point(118, 25)
        Me.TSmtpClient.Name = "TSmtpClient"
        Me.TSmtpClient.Size = New System.Drawing.Size(348, 22)
        Me.TSmtpClient.TabIndex = 2
        '
        'TEmailFrom
        '
        Me.TEmailFrom.Location = New System.Drawing.Point(118, 55)
        Me.TEmailFrom.Name = "TEmailFrom"
        Me.TEmailFrom.Size = New System.Drawing.Size(348, 22)
        Me.TEmailFrom.TabIndex = 3
        '
        'TEmailFromPwd
        '
        Me.TEmailFromPwd.Location = New System.Drawing.Point(118, 85)
        Me.TEmailFromPwd.Name = "TEmailFromPwd"
        Me.TEmailFromPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TEmailFromPwd.Size = New System.Drawing.Size(152, 22)
        Me.TEmailFromPwd.TabIndex = 4
        '
        'TEmailPort
        '
        Me.TEmailPort.Location = New System.Drawing.Point(118, 115)
        Me.TEmailPort.Name = "TEmailPort"
        Me.TEmailPort.Size = New System.Drawing.Size(67, 22)
        Me.TEmailPort.TabIndex = 5
        '
        'ParametrosgeneralesTableAdapter
        '
        Me.ParametrosgeneralesTableAdapter.ClearBeforeFill = True
        '
        'MailServerConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 166)
        Me.Controls.Add(Me.TEmailPort)
        Me.Controls.Add(Me.TEmailFromPwd)
        Me.Controls.Add(Me.TEmailFrom)
        Me.Controls.Add(Me.TSmtpClient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "MailServerConf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "MailServerConf"
        Me.Text = "Configuración Mail Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TSmtpClient As TextBox
    Friend WithEvents TEmailFrom As TextBox
    Friend WithEvents TEmailFromPwd As TextBox
    Friend WithEvents TEmailPort As TextBox
    Friend WithEvents ParametrosgeneralesTableAdapter As comercialDataSetTableAdapters.parametrosgeneralesTableAdapter
End Class
