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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgLampQuarto = New System.Windows.Forms.Label()
        Me.imgLampBanheiro = New System.Windows.Forms.Label()
        Me.imgLampSala = New System.Windows.Forms.Label()
        Me.imgLampCozinha = New System.Windows.Forms.Label()
        Me.imgLampLavanderia = New System.Windows.Forms.Label()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(161, 21)
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(492, 20)
        Me.txtMensagem.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(733, 494)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'imgLampQuarto
        '
        Me.imgLampQuarto.AutoSize = True
        Me.imgLampQuarto.Location = New System.Drawing.Point(158, 241)
        Me.imgLampQuarto.Name = "imgLampQuarto"
        Me.imgLampQuarto.Padding = New System.Windows.Forms.Padding(5, 5, 20, 5)
        Me.imgLampQuarto.Size = New System.Drawing.Size(25, 23)
        Me.imgLampQuarto.TabIndex = 4
        '
        'imgLampBanheiro
        '
        Me.imgLampBanheiro.AutoSize = True
        Me.imgLampBanheiro.Location = New System.Drawing.Point(337, 326)
        Me.imgLampBanheiro.Name = "imgLampBanheiro"
        Me.imgLampBanheiro.Padding = New System.Windows.Forms.Padding(5, 5, 20, 5)
        Me.imgLampBanheiro.Size = New System.Drawing.Size(25, 23)
        Me.imgLampBanheiro.TabIndex = 5
        '
        'imgLampSala
        '
        Me.imgLampSala.AutoSize = True
        Me.imgLampSala.Location = New System.Drawing.Point(451, 241)
        Me.imgLampSala.Name = "imgLampSala"
        Me.imgLampSala.Padding = New System.Windows.Forms.Padding(5, 5, 20, 5)
        Me.imgLampSala.Size = New System.Drawing.Size(25, 23)
        Me.imgLampSala.TabIndex = 6
        '
        'imgLampCozinha
        '
        Me.imgLampCozinha.AutoSize = True
        Me.imgLampCozinha.Location = New System.Drawing.Point(658, 241)
        Me.imgLampCozinha.Name = "imgLampCozinha"
        Me.imgLampCozinha.Padding = New System.Windows.Forms.Padding(5, 5, 20, 5)
        Me.imgLampCozinha.Size = New System.Drawing.Size(25, 23)
        Me.imgLampCozinha.TabIndex = 7
        '
        'imgLampLavanderia
        '
        Me.imgLampLavanderia.AutoSize = True
        Me.imgLampLavanderia.Location = New System.Drawing.Point(562, 497)
        Me.imgLampLavanderia.Name = "imgLampLavanderia"
        Me.imgLampLavanderia.Padding = New System.Windows.Forms.Padding(5, 5, 20, 5)
        Me.imgLampLavanderia.Size = New System.Drawing.Size(25, 23)
        Me.imgLampLavanderia.TabIndex = 8
        '
        'lblTemperatura
        '
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Location = New System.Drawing.Point(147, 323)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Padding = New System.Windows.Forms.Padding(5, 5, 30, 5)
        Me.lblTemperatura.Size = New System.Drawing.Size(35, 23)
        Me.lblTemperatura.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 591)
        Me.Controls.Add(Me.lblTemperatura)
        Me.Controls.Add(Me.imgLampLavanderia)
        Me.Controls.Add(Me.imgLampCozinha)
        Me.Controls.Add(Me.imgLampSala)
        Me.Controls.Add(Me.imgLampBanheiro)
        Me.Controls.Add(Me.imgLampQuarto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtMensagem)
        Me.Name = "Form1"
        Me.Text = "Comunicação Serial"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents imgLampQuarto As System.Windows.Forms.Label
    Friend WithEvents imgLampBanheiro As System.Windows.Forms.Label
    Friend WithEvents imgLampSala As System.Windows.Forms.Label
    Friend WithEvents imgLampCozinha As System.Windows.Forms.Label
    Friend WithEvents imgLampLavanderia As System.Windows.Forms.Label
    Friend WithEvents lblTemperatura As System.Windows.Forms.Label

End Class
