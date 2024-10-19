<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearCuenta))
        Me.PnlBarraBaja = New System.Windows.Forms.Panel()
        Me.LblDerechos = New System.Windows.Forms.Label()
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.LblBienvenida = New System.Windows.Forms.Label()
        Me.PnlUser = New System.Windows.Forms.Panel()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.PnlPass = New System.Windows.Forms.Panel()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRecuperar = New System.Windows.Forms.Button()
        Me.PcbPass = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PcbCandados = New System.Windows.Forms.PictureBox()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PcbConfPass = New System.Windows.Forms.PictureBox()
        Me.BtnVolver = New Biblioteca.ButtonRadio()
        Me.PnlBarraBaja.SuspendLayout()
        Me.PnlBarra.SuspendLayout()
        Me.PnlUser.SuspendLayout()
        Me.PnlPass.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PcbPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbCandados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbConfPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBarraBaja
        '
        Me.PnlBarraBaja.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlBarraBaja.Controls.Add(Me.LblDerechos)
        Me.PnlBarraBaja.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBarraBaja.Location = New System.Drawing.Point(0, 421)
        Me.PnlBarraBaja.Name = "PnlBarraBaja"
        Me.PnlBarraBaja.Size = New System.Drawing.Size(623, 40)
        Me.PnlBarraBaja.TabIndex = 27
        '
        'LblDerechos
        '
        Me.LblDerechos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LblDerechos.AutoSize = True
        Me.LblDerechos.BackColor = System.Drawing.Color.Transparent
        Me.LblDerechos.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDerechos.ForeColor = System.Drawing.Color.Black
        Me.LblDerechos.Location = New System.Drawing.Point(340, 13)
        Me.LblDerechos.Name = "LblDerechos"
        Me.LblDerechos.Size = New System.Drawing.Size(261, 18)
        Me.LblDerechos.TabIndex = 12
        Me.LblDerechos.Text = "© 2024 - Todos los derechos reservados."
        '
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlBarra.Controls.Add(Me.LblBienvenida)
        Me.PnlBarra.Controls.Add(Me.BtnMin)
        Me.PnlBarra.Controls.Add(Me.BtnCerrar)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.Size = New System.Drawing.Size(623, 40)
        Me.PnlBarra.TabIndex = 26
        '
        'LblBienvenida
        '
        Me.LblBienvenida.AutoSize = True
        Me.LblBienvenida.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBienvenida.ForeColor = System.Drawing.Color.Black
        Me.LblBienvenida.Location = New System.Drawing.Point(12, 9)
        Me.LblBienvenida.Name = "LblBienvenida"
        Me.LblBienvenida.Size = New System.Drawing.Size(418, 22)
        Me.LblBienvenida.TabIndex = 11
        Me.LblBienvenida.Text = "Biblioteca Municipal ""Maria E. Walsh"" - Crear cuenta"
        '
        'PnlUser
        '
        Me.PnlUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlUser.Controls.Add(Me.PictureBox2)
        Me.PnlUser.Controls.Add(Me.TxtUser)
        Me.PnlUser.Location = New System.Drawing.Point(76, 171)
        Me.PnlUser.Name = "PnlUser"
        Me.PnlUser.Size = New System.Drawing.Size(408, 42)
        Me.PnlUser.TabIndex = 28
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.Silver
        Me.TxtUser.Location = New System.Drawing.Point(41, 11)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(360, 20)
        Me.TxtUser.TabIndex = 1
        Me.TxtUser.Text = "Usuario"
        '
        'PnlPass
        '
        Me.PnlPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlPass.Controls.Add(Me.TxtPass)
        Me.PnlPass.Controls.Add(Me.PcbCandados)
        Me.PnlPass.Location = New System.Drawing.Point(75, 232)
        Me.PnlPass.Name = "PnlPass"
        Me.PnlPass.Size = New System.Drawing.Size(408, 42)
        Me.PnlPass.TabIndex = 29
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.Silver
        Me.TxtPass.Location = New System.Drawing.Point(41, 11)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(360, 20)
        Me.TxtPass.TabIndex = 2
        Me.TxtPass.Text = "Contraseña"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(76, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 42)
        Me.Panel1.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(41, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Confirmar contraseña"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Location = New System.Drawing.Point(76, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 42)
        Me.Panel2.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Silver
        Me.TextBox2.Location = New System.Drawing.Point(41, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(360, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Correo electrónico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(148, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 22)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Complete los siguientes casilleros:"
        '
        'BtnRecuperar
        '
        Me.BtnRecuperar.BackColor = System.Drawing.Color.Transparent
        Me.BtnRecuperar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnRecuperar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnRecuperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecuperar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecuperar.ForeColor = System.Drawing.Color.Silver
        Me.BtnRecuperar.Location = New System.Drawing.Point(212, 356)
        Me.BtnRecuperar.Name = "BtnRecuperar"
        Me.BtnRecuperar.Size = New System.Drawing.Size(168, 40)
        Me.BtnRecuperar.TabIndex = 33
        Me.BtnRecuperar.Text = "CREAR CUENTA"
        Me.BtnRecuperar.UseVisualStyleBackColor = False
        '
        'PcbPass
        '
        Me.PcbPass.Image = Global.Biblioteca.My.Resources.Resources.ojoBlueTachado
        Me.PcbPass.Location = New System.Drawing.Point(523, 236)
        Me.PcbPass.Name = "PcbPass"
        Me.PcbPass.Size = New System.Drawing.Size(34, 37)
        Me.PcbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbPass.TabIndex = 36
        Me.PcbPass.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Biblioteca.My.Resources.Resources.mailBluex56
        Me.PictureBox3.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Biblioteca.My.Resources.Resources.usuario_azul_osc
        Me.PictureBox2.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PcbCandados
        '
        Me.PcbCandados.Image = CType(resources.GetObject("PcbCandados.Image"), System.Drawing.Image)
        Me.PcbCandados.Location = New System.Drawing.Point(0, 1)
        Me.PcbCandados.Name = "PcbCandados"
        Me.PcbCandados.Size = New System.Drawing.Size(36, 40)
        Me.PcbCandados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbCandados.TabIndex = 19
        Me.PcbCandados.TabStop = False
        '
        'BtnMin
        '
        Me.BtnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMin.ForeColor = System.Drawing.Color.LightGray
        Me.BtnMin.Image = Global.Biblioteca.My.Resources.Resources.Icono_Minimizar_negro
        Me.BtnMin.Location = New System.Drawing.Point(543, 0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(40, 40)
        Me.BtnMin.TabIndex = 6
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.LightGray
        Me.BtnCerrar.Image = Global.Biblioteca.My.Resources.Resources.Icono_cerrar_FN_negro
        Me.BtnCerrar.Location = New System.Drawing.Point(583, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PcbConfPass
        '
        Me.PcbConfPass.Image = Global.Biblioteca.My.Resources.Resources.ojoBlueTachado
        Me.PcbConfPass.Location = New System.Drawing.Point(523, 301)
        Me.PcbConfPass.Name = "PcbConfPass"
        Me.PcbConfPass.Size = New System.Drawing.Size(34, 37)
        Me.PcbConfPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbConfPass.TabIndex = 37
        Me.PcbConfPass.TabStop = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnVolver.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnVolver.BorderColor = System.Drawing.Color.PeachPuff
        Me.BtnVolver.BorderRadius = 18
        Me.BtnVolver.BorderSize = 1
        Me.BtnVolver.FlatAppearance.BorderSize = 0
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Image = Global.Biblioteca.My.Resources.Resources.blueCla
        Me.BtnVolver.Location = New System.Drawing.Point(12, 56)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(39, 39)
        Me.BtnVolver.TabIndex = 34
        Me.BtnVolver.TextColor = System.Drawing.Color.White
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FrmCrearCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(623, 461)
        Me.Controls.Add(Me.PcbConfPass)
        Me.Controls.Add(Me.PcbPass)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnRecuperar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlUser)
        Me.Controls.Add(Me.PnlPass)
        Me.Controls.Add(Me.PnlBarraBaja)
        Me.Controls.Add(Me.PnlBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCrearCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrearCuenta"
        Me.PnlBarraBaja.ResumeLayout(False)
        Me.PnlBarraBaja.PerformLayout()
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        Me.PnlUser.ResumeLayout(False)
        Me.PnlUser.PerformLayout()
        Me.PnlPass.ResumeLayout(False)
        Me.PnlPass.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PcbPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbCandados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbConfPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlBarraBaja As System.Windows.Forms.Panel
    Friend WithEvents LblDerechos As System.Windows.Forms.Label
    Friend WithEvents PnlBarra As System.Windows.Forms.Panel
    Friend WithEvents LblBienvenida As System.Windows.Forms.Label
    Friend WithEvents BtnMin As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents PnlUser As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents PnlPass As System.Windows.Forms.Panel
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents PcbCandados As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRecuperar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As Biblioteca.ButtonRadio
    Friend WithEvents PcbPass As System.Windows.Forms.PictureBox
    Friend WithEvents PcbConfPass As System.Windows.Forms.PictureBox
End Class
