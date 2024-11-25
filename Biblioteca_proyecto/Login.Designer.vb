<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.LblBienvenida = New System.Windows.Forms.Label()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.PnlUser = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PnlPass = New System.Windows.Forms.Panel()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.PcbCandados = New System.Windows.Forms.PictureBox()
        Me.LblOlvid = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.ChkPass = New System.Windows.Forms.CheckBox()
        Me.LblDerechos = New System.Windows.Forms.Label()
        Me.PnlBarraBaja = New System.Windows.Forms.Panel()
        Me.LblCrear = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BdbibliotecaDataSet = New Biblioteca.bdbibliotecaDataSet()
        Me.UsuariosTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.usuariosTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlBarra.SuspendLayout()
        Me.PnlUser.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPass.SuspendLayout()
        CType(Me.PcbCandados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBarraBaja.SuspendLayout()
        CType(Me.BdbibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PnlBarra.Size = New System.Drawing.Size(575, 40)
        Me.PnlBarra.TabIndex = 9
        '
        'LblBienvenida
        '
        Me.LblBienvenida.AutoSize = True
        Me.LblBienvenida.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBienvenida.ForeColor = System.Drawing.Color.Black
        Me.LblBienvenida.Location = New System.Drawing.Point(12, 9)
        Me.LblBienvenida.Name = "LblBienvenida"
        Me.LblBienvenida.Size = New System.Drawing.Size(372, 22)
        Me.LblBienvenida.TabIndex = 11
        Me.LblBienvenida.Text = "Biblioteca Municipal ""Maria E. Walsh"" - Acceso"
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
        Me.BtnMin.Location = New System.Drawing.Point(495, 0)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(535, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.UseVisualStyleBackColor = True
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
        Me.TxtUser.Text = "Usuario o correo electrónico"
        '
        'PnlUser
        '
        Me.PnlUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlUser.Controls.Add(Me.PictureBox2)
        Me.PnlUser.Controls.Add(Me.TxtUser)
        Me.PnlUser.Location = New System.Drawing.Point(23, 64)
        Me.PnlUser.Name = "PnlUser"
        Me.PnlUser.Size = New System.Drawing.Size(408, 42)
        Me.PnlUser.TabIndex = 26
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
        'PnlPass
        '
        Me.PnlPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PnlPass.Controls.Add(Me.TxtPass)
        Me.PnlPass.Controls.Add(Me.PcbCandados)
        Me.PnlPass.Location = New System.Drawing.Point(23, 136)
        Me.PnlPass.Name = "PnlPass"
        Me.PnlPass.Size = New System.Drawing.Size(408, 42)
        Me.PnlPass.TabIndex = 27
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
        'LblOlvid
        '
        Me.LblOlvid.AutoSize = True
        Me.LblOlvid.BackColor = System.Drawing.Color.Transparent
        Me.LblOlvid.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOlvid.ForeColor = System.Drawing.Color.DarkGray
        Me.LblOlvid.Location = New System.Drawing.Point(101, 270)
        Me.LblOlvid.Name = "LblOlvid"
        Me.LblOlvid.Size = New System.Drawing.Size(172, 18)
        Me.LblOlvid.TabIndex = 24
        Me.LblOlvid.Text = "¿Olvidaste tu contraseña?"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.Silver
        Me.BtnLogin.Location = New System.Drawing.Point(76, 222)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(408, 40)
        Me.BtnLogin.TabIndex = 23
        Me.BtnLogin.Text = "ACCEDER"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'ChkPass
        '
        Me.ChkPass.AutoSize = True
        Me.ChkPass.BackColor = System.Drawing.Color.Transparent
        Me.ChkPass.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPass.ForeColor = System.Drawing.Color.Silver
        Me.ChkPass.Location = New System.Drawing.Point(469, 141)
        Me.ChkPass.Name = "ChkPass"
        Me.ChkPass.Size = New System.Drawing.Size(84, 34)
        Me.ChkPass.TabIndex = 22
        Me.ChkPass.Text = "      Ver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contraseña"
        Me.ChkPass.UseVisualStyleBackColor = False
        '
        'LblDerechos
        '
        Me.LblDerechos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LblDerechos.AutoSize = True
        Me.LblDerechos.BackColor = System.Drawing.Color.Transparent
        Me.LblDerechos.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDerechos.ForeColor = System.Drawing.Color.Black
        Me.LblDerechos.Location = New System.Drawing.Point(292, 13)
        Me.LblDerechos.Name = "LblDerechos"
        Me.LblDerechos.Size = New System.Drawing.Size(261, 18)
        Me.LblDerechos.TabIndex = 12
        Me.LblDerechos.Text = "© 2024 - Todos los derechos reservados."
        '
        'PnlBarraBaja
        '
        Me.PnlBarraBaja.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlBarraBaja.Controls.Add(Me.LblDerechos)
        Me.PnlBarraBaja.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBarraBaja.Location = New System.Drawing.Point(0, 309)
        Me.PnlBarraBaja.Name = "PnlBarraBaja"
        Me.PnlBarraBaja.Size = New System.Drawing.Size(575, 40)
        Me.PnlBarraBaja.TabIndex = 25
        '
        'LblCrear
        '
        Me.LblCrear.AutoSize = True
        Me.LblCrear.BackColor = System.Drawing.Color.Transparent
        Me.LblCrear.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCrear.ForeColor = System.Drawing.Color.DarkGray
        Me.LblCrear.Location = New System.Drawing.Point(297, 270)
        Me.LblCrear.Name = "LblCrear"
        Me.LblCrear.Size = New System.Drawing.Size(92, 18)
        Me.LblCrear.TabIndex = 28
        Me.LblCrear.Text = "Crear cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(279, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "|"
        '
        'BdbibliotecaDataSet
        '
        Me.BdbibliotecaDataSet.DataSetName = "bdbibliotecaDataSet"
        Me.BdbibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(575, 349)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCrear)
        Me.Controls.Add(Me.PnlUser)
        Me.Controls.Add(Me.PnlPass)
        Me.Controls.Add(Me.LblOlvid)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.ChkPass)
        Me.Controls.Add(Me.PnlBarraBaja)
        Me.Controls.Add(Me.PnlBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        Me.PnlUser.ResumeLayout(False)
        Me.PnlUser.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPass.ResumeLayout(False)
        Me.PnlPass.PerformLayout()
        CType(Me.PcbCandados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBarraBaja.ResumeLayout(False)
        Me.PnlBarraBaja.PerformLayout()
        CType(Me.BdbibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlBarra As System.Windows.Forms.Panel
    Friend WithEvents LblBienvenida As System.Windows.Forms.Label
    Friend WithEvents BtnMin As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents PnlUser As System.Windows.Forms.Panel
    Friend WithEvents PcbCandados As System.Windows.Forms.PictureBox
    Friend WithEvents PnlPass As System.Windows.Forms.Panel
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents LblOlvid As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents ChkPass As System.Windows.Forms.CheckBox
    Friend WithEvents LblDerechos As System.Windows.Forms.Label
    Friend WithEvents PnlBarraBaja As System.Windows.Forms.Panel
    Friend WithEvents LblCrear As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BdbibliotecaDataSet As Biblioteca.bdbibliotecaDataSet
    Friend WithEvents UsuariosTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource

End Class
