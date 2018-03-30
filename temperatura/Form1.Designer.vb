<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.buscar_puerto = New System.Windows.Forms.Button()
        Me.puerto = New System.Windows.Forms.ComboBox()
        Me.conectar = New System.Windows.Forms.Button()
        Me.serial = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.temperatura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buscar_puerto
        '
        Me.buscar_puerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar_puerto.Location = New System.Drawing.Point(45, 112)
        Me.buscar_puerto.Name = "buscar_puerto"
        Me.buscar_puerto.Size = New System.Drawing.Size(128, 33)
        Me.buscar_puerto.TabIndex = 0
        Me.buscar_puerto.Text = "BUSCAR PUERTO"
        Me.buscar_puerto.UseVisualStyleBackColor = True
        '
        'puerto
        '
        Me.puerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puerto.FormattingEnabled = True
        Me.puerto.Location = New System.Drawing.Point(193, 114)
        Me.puerto.Name = "puerto"
        Me.puerto.Size = New System.Drawing.Size(141, 32)
        Me.puerto.TabIndex = 1
        '
        'conectar
        '
        Me.conectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conectar.Location = New System.Drawing.Point(372, 113)
        Me.conectar.Name = "conectar"
        Me.conectar.Size = New System.Drawing.Size(168, 32)
        Me.conectar.TabIndex = 2
        Me.conectar.Text = "CONECTAR"
        Me.conectar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'temperatura
        '
        Me.temperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temperatura.Location = New System.Drawing.Point(372, 192)
        Me.temperatura.Name = "temperatura"
        Me.temperatura.Size = New System.Drawing.Size(168, 29)
        Me.temperatura.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "La Temperatura es :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(533, 55)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sensor de Temperatura"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(604, 273)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.temperatura)
        Me.Controls.Add(Me.conectar)
        Me.Controls.Add(Me.puerto)
        Me.Controls.Add(Me.buscar_puerto)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(400, 400)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UTP-Sensor Temperatura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buscar_puerto As Button
    Friend WithEvents puerto As ComboBox
    Friend WithEvents conectar As Button
    Friend WithEvents serial As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents temperatura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
