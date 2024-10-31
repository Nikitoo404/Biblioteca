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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearCuenta))
        Me.PnlBarraBaja = New System.Windows.Forms.Panel()
        Me.LblDerechos = New System.Windows.Forms.Label()
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.LblBienvenida = New System.Windows.Forms.Label()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PnlUser = New System.Windows.Forms.Panel()
        Me.PcbUser = New System.Windows.Forms.PictureBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.PnlPass = New System.Windows.Forms.Panel()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.PcbCandados = New System.Windows.Forms.PictureBox()
        Me.PnlConfPass = New System.Windows.Forms.Panel()
        Me.TxtConfPass = New System.Windows.Forms.TextBox()
        Me.PcbCandadosConf = New System.Windows.Forms.PictureBox()
        Me.PnlCorreo = New System.Windows.Forms.Panel()
        Me.PcbCorreo = New System.Windows.Forms.PictureBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LblCompletar = New System.Windows.Forms.Label()
        Me.BtnRecuperar = New System.Windows.Forms.Button()
        Me.PcbVerCorreo = New System.Windows.Forms.PictureBox()
        Me.PcbConfPass = New System.Windows.Forms.PictureBox()
        Me.PcbPass = New System.Windows.Forms.PictureBox()
        Me.PcbVerUser = New System.Windows.Forms.PictureBox()
        Me.PcbVerPass = New System.Windows.Forms.PictureBox()
        Me.PcbVerConfPass = New System.Windows.Forms.PictureBox()
        Me.ttpCuadros = New System.Windows.Forms.ToolTip(Me.components)
        Me.CboTipoCorreo = New Biblioteca.ComboPerso()
        Me.BtnVolver = New Biblioteca.ButtonRadio()
        Me.PnlBarraBaja.SuspendLayout()
        Me.PnlBarra.SuspendLayout()
        Me.PnlUser.SuspendLayout()
        CType(Me.PcbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPass.SuspendLayout()
        CType(Me.PcbCandados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlConfPass.SuspendLayout()
        CType(Me.PcbCandadosConf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCorreo.SuspendLayout()
        CType(Me.PcbCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbVerCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbConfPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbVerUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbVerPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbVerConfPass, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PnlUser
        '
        Me.PnlUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlUser.Controls.Add(Me.PcbUser)
        Me.PnlUser.Controls.Add(Me.TxtUser)
        Me.PnlUser.Location = New System.Drawing.Point(76, 171)
        Me.PnlUser.Name = "PnlUser"
        Me.PnlUser.Size = New System.Drawing.Size(408, 42)
        Me.PnlUser.TabIndex = 28
        '
        'PcbUser
        '
        Me.PcbUser.Image = Global.Biblioteca.My.Resources.Resources.usuario_azul_osc
        Me.PcbUser.Location = New System.Drawing.Point(1, 3)
        Me.PcbUser.Name = "PcbUser"
        Me.PcbUser.Size = New System.Drawing.Size(34, 37)
        Me.PcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbUser.TabIndex = 22
        Me.PcbUser.TabStop = False
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.Silver
        Me.TxtUser.Location = New System.Drawing.Point(41, 11)
        Me.TxtUser.MaxLength = 11
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
        Me.TxtPass.MaxLength = 36
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(360, 20)
        Me.TxtPass.TabIndex = 2
        Me.TxtPass.Text = "Contraseña"
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
        'PnlConfPass
        '
        Me.PnlConfPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlConfPass.Controls.Add(Me.TxtConfPass)
        Me.PnlConfPass.Controls.Add(Me.PcbCandadosConf)
        Me.PnlConfPass.Location = New System.Drawing.Point(76, 296)
        Me.PnlConfPass.Name = "PnlConfPass"
        Me.PnlConfPass.Size = New System.Drawing.Size(408, 42)
        Me.PnlConfPass.TabIndex = 30
        '
        'TxtConfPass
        '
        Me.TxtConfPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtConfPass.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfPass.ForeColor = System.Drawing.Color.Silver
        Me.TxtConfPass.Location = New System.Drawing.Point(41, 11)
        Me.TxtConfPass.MaxLength = 36
        Me.TxtConfPass.Name = "TxtConfPass"
        Me.TxtConfPass.Size = New System.Drawing.Size(360, 20)
        Me.TxtConfPass.TabIndex = 2
        Me.TxtConfPass.Text = "Confirmar contraseña"
        '
        'PcbCandadosConf
        '
        Me.PcbCandadosConf.Image = CType(resources.GetObject("PcbCandadosConf.Image"), System.Drawing.Image)
        Me.PcbCandadosConf.Location = New System.Drawing.Point(0, 1)
        Me.PcbCandadosConf.Name = "PcbCandadosConf"
        Me.PcbCandadosConf.Size = New System.Drawing.Size(36, 40)
        Me.PcbCandadosConf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbCandadosConf.TabIndex = 19
        Me.PcbCandadosConf.TabStop = False
        '
        'PnlCorreo
        '
        Me.PnlCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlCorreo.Controls.Add(Me.PcbCorreo)
        Me.PnlCorreo.Controls.Add(Me.TxtCorreo)
        Me.PnlCorreo.Location = New System.Drawing.Point(76, 112)
        Me.PnlCorreo.Name = "PnlCorreo"
        Me.PnlCorreo.Size = New System.Drawing.Size(245, 42)
        Me.PnlCorreo.TabIndex = 31
        Me.ttpCuadros.SetToolTip(Me.PnlCorreo, "Ingrese su correo electrónico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*solamente los caracteres previos al @*")
        '
        'PcbCorreo
        '
        Me.PcbCorreo.Image = Global.Biblioteca.My.Resources.Resources.mailBluex56
        Me.PcbCorreo.Location = New System.Drawing.Point(1, 3)
        Me.PcbCorreo.Name = "PcbCorreo"
        Me.PcbCorreo.Size = New System.Drawing.Size(34, 37)
        Me.PcbCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PcbCorreo.TabIndex = 22
        Me.PcbCorreo.TabStop = False
        '
        'TxtCorreo
        '
        Me.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCorreo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.ForeColor = System.Drawing.Color.Silver
        Me.TxtCorreo.Location = New System.Drawing.Point(41, 11)
        Me.TxtCorreo.MaxLength = 36
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(197, 20)
        Me.TxtCorreo.TabIndex = 1
        Me.TxtCorreo.Text = "Correo electrónico"
        Me.ttpCuadros.SetToolTip(Me.TxtCorreo, "Ingrese su correo electrónico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*solamente los caracteres previos al @*")
        '
        'LblCompletar
        '
        Me.LblCompletar.AutoSize = True
        Me.LblCompletar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompletar.ForeColor = System.Drawing.Color.Silver
        Me.LblCompletar.Location = New System.Drawing.Point(148, 62)
        Me.LblCompletar.Name = "LblCompletar"
        Me.LblCompletar.Size = New System.Drawing.Size(282, 22)
        Me.LblCompletar.TabIndex = 32
        Me.LblCompletar.Text = "Complete los siguientes casilleros:"
        '
        'BtnRecuperar
        '
        Me.BtnRecuperar.BackColor = System.Drawing.Color.Transparent
        Me.BtnRecuperar.Enabled = False
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
        'PcbVerCorreo
        '
        Me.PcbVerCorreo.Image = Global.Biblioteca.My.Resources.Resources.IncorrectoRojo
        Me.PcbVerCorreo.Location = New System.Drawing.Point(490, 112)
        Me.PcbVerCorreo.Name = "PcbVerCorreo"
        Me.PcbVerCorreo.Size = New System.Drawing.Size(34, 37)
        Me.PcbVerCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbVerCorreo.TabIndex = 38
        Me.PcbVerCorreo.TabStop = False
        Me.PcbVerCorreo.Visible = False
        '
        'PcbConfPass
        '
        Me.PcbConfPass.Image = Global.Biblioteca.My.Resources.Resources.ojoBlueTachado
        Me.PcbConfPass.Location = New System.Drawing.Point(533, 300)
        Me.PcbConfPass.Name = "PcbConfPass"
        Me.PcbConfPass.Size = New System.Drawing.Size(34, 37)
        Me.PcbConfPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbConfPass.TabIndex = 37
        Me.PcbConfPass.TabStop = False
        Me.PcbConfPass.Tag = "ConfOjoTachado"
        '
        'PcbPass
        '
        Me.PcbPass.Image = Global.Biblioteca.My.Resources.Resources.ojoBlueTachado
        Me.PcbPass.Location = New System.Drawing.Point(533, 236)
        Me.PcbPass.Name = "PcbPass"
        Me.PcbPass.Size = New System.Drawing.Size(34, 37)
        Me.PcbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbPass.TabIndex = 36
        Me.PcbPass.TabStop = False
        Me.PcbPass.Tag = "OjoTachado"
        '
        'PcbVerUser
        '
        Me.PcbVerUser.Image = Global.Biblioteca.My.Resources.Resources.IncorrectoRojo
        Me.PcbVerUser.Location = New System.Drawing.Point(490, 174)
        Me.PcbVerUser.Name = "PcbVerUser"
        Me.PcbVerUser.Size = New System.Drawing.Size(34, 37)
        Me.PcbVerUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbVerUser.TabIndex = 39
        Me.PcbVerUser.TabStop = False
        Me.PcbVerUser.Visible = False
        '
        'PcbVerPass
        '
        Me.PcbVerPass.Image = Global.Biblioteca.My.Resources.Resources.IncorrectoRojo
        Me.PcbVerPass.Location = New System.Drawing.Point(490, 236)
        Me.PcbVerPass.Name = "PcbVerPass"
        Me.PcbVerPass.Size = New System.Drawing.Size(34, 37)
        Me.PcbVerPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbVerPass.TabIndex = 40
        Me.PcbVerPass.TabStop = False
        Me.PcbVerPass.Visible = False
        '
        'PcbVerConfPass
        '
        Me.PcbVerConfPass.Image = Global.Biblioteca.My.Resources.Resources.IncorrectoRojo
        Me.PcbVerConfPass.Location = New System.Drawing.Point(490, 300)
        Me.PcbVerConfPass.Name = "PcbVerConfPass"
        Me.PcbVerConfPass.Size = New System.Drawing.Size(34, 37)
        Me.PcbVerConfPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcbVerConfPass.TabIndex = 41
        Me.PcbVerConfPass.TabStop = False
        Me.PcbVerConfPass.Visible = False
        '
        'CboTipoCorreo
        '
        Me.CboTipoCorreo._BorderColor = System.Drawing.Color.Silver
        Me.CboTipoCorreo._BorderSize = 1
        Me.CboTipoCorreo._IconColor = System.Drawing.Color.Silver
        Me.CboTipoCorreo._ListBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboTipoCorreo._ListTextColor = System.Drawing.Color.Silver
        Me.CboTipoCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CboTipoCorreo.DataSource = Nothing
        Me.CboTipoCorreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboTipoCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CboTipoCorreo.ForeColor = System.Drawing.Color.Silver
        Me.CboTipoCorreo.Items.AddRange(New Object() {"@gmail.com", "@outlook.com", "@hotmail.com", "@live.com", "@yahoo.com"})
        Me.CboTipoCorreo.Location = New System.Drawing.Point(327, 115)
        Me.CboTipoCorreo.MinimumSize = New System.Drawing.Size(150, 30)
        Me.CboTipoCorreo.Name = "CboTipoCorreo"
        Me.CboTipoCorreo.Padding = New System.Windows.Forms.Padding(1)
        Me.CboTipoCorreo.Size = New System.Drawing.Size(150, 30)
        Me.CboTipoCorreo.TabIndex = 42
        Me.CboTipoCorreo.Texts = ""
        Me.ttpCuadros.SetToolTip(Me.CboTipoCorreo, "Seleccione su tipo de correo")
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
        Me.Controls.Add(Me.CboTipoCorreo)
        Me.Controls.Add(Me.PcbVerConfPass)
        Me.Controls.Add(Me.PcbVerPass)
        Me.Controls.Add(Me.PcbVerUser)
        Me.Controls.Add(Me.PcbVerCorreo)
        Me.Controls.Add(Me.PcbConfPass)
        Me.Controls.Add(Me.PcbPass)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnRecuperar)
        Me.Controls.Add(Me.LblCompletar)
        Me.Controls.Add(Me.PnlCorreo)
        Me.Controls.Add(Me.PnlConfPass)
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
        CType(Me.PcbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPass.ResumeLayout(False)
        Me.PnlPass.PerformLayout()
        CType(Me.PcbCandados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlConfPass.ResumeLayout(False)
        Me.PnlConfPass.PerformLayout()
        CType(Me.PcbCandadosConf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCorreo.ResumeLayout(False)
        Me.PnlCorreo.PerformLayout()
        CType(Me.PcbCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbVerCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbConfPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbVerUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbVerPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbVerConfPass, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PcbUser As System.Windows.Forms.PictureBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents PnlPass As System.Windows.Forms.Panel
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents PcbCandados As System.Windows.Forms.PictureBox
    Friend WithEvents PnlConfPass As System.Windows.Forms.Panel
    Friend WithEvents TxtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents PcbCandadosConf As System.Windows.Forms.PictureBox
    Friend WithEvents PnlCorreo As System.Windows.Forms.Panel
    Friend WithEvents PcbCorreo As System.Windows.Forms.PictureBox
    Friend WithEvents TxtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents LblCompletar As System.Windows.Forms.Label
    Friend WithEvents BtnRecuperar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As Biblioteca.ButtonRadio
    Friend WithEvents PcbPass As System.Windows.Forms.PictureBox
    Friend WithEvents PcbConfPass As System.Windows.Forms.PictureBox
    Friend WithEvents PcbVerCorreo As System.Windows.Forms.PictureBox
    Friend WithEvents PcbVerUser As System.Windows.Forms.PictureBox
    Friend WithEvents PcbVerPass As System.Windows.Forms.PictureBox
    Friend WithEvents PcbVerConfPass As System.Windows.Forms.PictureBox
    Friend WithEvents CboTipoCorreo As Biblioteca.ComboPerso
    Friend WithEvents ttpCuadros As System.Windows.Forms.ToolTip
End Class
