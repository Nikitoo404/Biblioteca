<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearRegistros
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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PnlTituloHeader = New System.Windows.Forms.Panel()
        Me.PcbTituloHeader = New System.Windows.Forms.PictureBox()
        Me.lblTituloLibro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AutorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdbibliotecaDataSet = New Biblioteca.bdbibliotecaDataSet()
        Me.TipoderecursoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.autorTableAdapter()
        Me.TipoderecursoTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.tipoderecursoTableAdapter()
        Me.PnlProductos = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PnlTitulo = New System.Windows.Forms.Panel()
        Me.TxtPerso3 = New Biblioteca.TxtPerso()
        Me.TxtPerso2 = New Biblioteca.TxtPerso()
        Me.TxtPerso1 = New Biblioteca.TxtPerso()
        Me.CboFormato = New Biblioteca.ComboPerso()
        Me.CboTipoRecurso = New Biblioteca.ComboPerso()
        Me.BtnVolver = New Biblioteca.ButtonRadio()
        Me.TxtPerso4 = New Biblioteca.TxtPerso()
        Me.PnlAutor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PnlTituloHeader.SuspendLayout()
        CType(Me.PcbTituloHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdbibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoderecursoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitulo.SuspendLayout()
        Me.PnlAutor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTitulo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.PeachPuff
        Me.LblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LblTitulo.Location = New System.Drawing.Point(57, 18)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(126, 22)
        Me.LblTitulo.TabIndex = 20
        Me.LblTitulo.Text = "Crear registros"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTituloHeader
        '
        Me.PnlTituloHeader.Controls.Add(Me.PcbTituloHeader)
        Me.PnlTituloHeader.Controls.Add(Me.lblTituloLibro)
        Me.PnlTituloHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlTituloHeader.Name = "PnlTituloHeader"
        Me.PnlTituloHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlTituloHeader.TabIndex = 35
        '
        'PcbTituloHeader
        '
        Me.PcbTituloHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaAbajo
        Me.PcbTituloHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbTituloHeader.Name = "PcbTituloHeader"
        Me.PcbTituloHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbTituloHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbTituloHeader.TabIndex = 35
        Me.PcbTituloHeader.TabStop = False
        '
        'lblTituloLibro
        '
        Me.lblTituloLibro.AutoSize = True
        Me.lblTituloLibro.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloLibro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTituloLibro.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloLibro.ForeColor = System.Drawing.Color.Silver
        Me.lblTituloLibro.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTituloLibro.Location = New System.Drawing.Point(-4, 0)
        Me.lblTituloLibro.Name = "lblTituloLibro"
        Me.lblTituloLibro.Size = New System.Drawing.Size(54, 22)
        Me.lblTituloLibro.TabIndex = 36
        Me.lblTituloLibro.Text = "Título"
        Me.lblTituloLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(248, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 22)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Apellido/s"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(40, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nombre/s"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AutorBindingSource
        '
        Me.AutorBindingSource.DataMember = "autor"
        Me.AutorBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'BdbibliotecaDataSet
        '
        Me.BdbibliotecaDataSet.DataSetName = "bdbibliotecaDataSet"
        Me.BdbibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoderecursoBindingSource
        '
        Me.TipoderecursoBindingSource.DataMember = "tipoderecurso"
        Me.TipoderecursoBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'AutorTableAdapter
        '
        Me.AutorTableAdapter.ClearBeforeFill = True
        '
        'TipoderecursoTableAdapter
        '
        Me.TipoderecursoTableAdapter.ClearBeforeFill = True
        '
        'PnlProductos
        '
        Me.PnlProductos.BackColor = System.Drawing.Color.Silver
        Me.PnlProductos.Location = New System.Drawing.Point(73, 178)
        Me.PnlProductos.Name = "PnlProductos"
        Me.PnlProductos.Size = New System.Drawing.Size(390, 1)
        Me.PnlProductos.TabIndex = 36
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(390, 22)
        Me.Panel9.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Biblioteca.My.Resources.Resources.flechaAbajo
        Me.PictureBox1.Location = New System.Drawing.Point(371, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(-4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 22)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Autor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.PictureBox2)
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(390, 22)
        Me.Panel10.TabIndex = 38
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Biblioteca.My.Resources.Resources.flechaAbajo
        Me.PictureBox2.Location = New System.Drawing.Point(371, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(-4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 22)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "ISBN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(390, 22)
        Me.Panel3.TabIndex = 39
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Biblioteca.My.Resources.Resources.flechaAbajo
        Me.PictureBox3.Location = New System.Drawing.Point(371, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label5.Location = New System.Drawing.Point(-4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tipo de recurso"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Location = New System.Drawing.Point(500, 178)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(390, 1)
        Me.Panel5.TabIndex = 44
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Silver
        Me.Panel11.Location = New System.Drawing.Point(500, 269)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(390, 1)
        Me.Panel11.TabIndex = 46
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.PictureBox4)
        Me.Panel12.Controls.Add(Me.Label6)
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(390, 22)
        Me.Panel12.TabIndex = 45
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Biblioteca.My.Resources.Resources.flechaAbajo
        Me.PictureBox4.Location = New System.Drawing.Point(371, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 22)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label6.Location = New System.Drawing.Point(-4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 22)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Formato"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTitulo
        '
        Me.PnlTitulo.Controls.Add(Me.TxtPerso1)
        Me.PnlTitulo.Controls.Add(Me.PnlTituloHeader)
        Me.PnlTitulo.Location = New System.Drawing.Point(70, 95)
        Me.PnlTitulo.Name = "PnlTitulo"
        Me.PnlTitulo.Size = New System.Drawing.Size(390, 77)
        Me.PnlTitulo.TabIndex = 47
        '
        'TxtPerso3
        '
        Me.TxtPerso3._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtPerso3._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtPerso3._BorderSize = 2
        Me.TxtPerso3._MaxLength = 100
        Me.TxtPerso3._Multiline = False
        Me.TxtPerso3._PasswordChar = False
        Me.TxtPerso3._UnderlinedStyle = True
        Me.TxtPerso3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtPerso3.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.AutorBindingSource, "Apellidos", True))
        Me.TxtPerso3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPerso3.ForeColor = System.Drawing.Color.LightGray
        Me.TxtPerso3.Location = New System.Drawing.Point(207, 50)
        Me.TxtPerso3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtPerso3.Name = "TxtPerso3"
        Me.TxtPerso3.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtPerso3.Size = New System.Drawing.Size(178, 37)
        Me.TxtPerso3.TabIndex = 50
        Me.TxtPerso3.Texts = ""
        '
        'TxtPerso2
        '
        Me.TxtPerso2._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtPerso2._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtPerso2._BorderSize = 2
        Me.TxtPerso2._MaxLength = 100
        Me.TxtPerso2._Multiline = False
        Me.TxtPerso2._PasswordChar = False
        Me.TxtPerso2._UnderlinedStyle = True
        Me.TxtPerso2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtPerso2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.AutorBindingSource, "Nombres", True))
        Me.TxtPerso2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPerso2.ForeColor = System.Drawing.Color.LightGray
        Me.TxtPerso2.Location = New System.Drawing.Point(2, 50)
        Me.TxtPerso2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtPerso2.Name = "TxtPerso2"
        Me.TxtPerso2.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtPerso2.Size = New System.Drawing.Size(178, 37)
        Me.TxtPerso2.TabIndex = 49
        Me.TxtPerso2.Texts = ""
        '
        'TxtPerso1
        '
        Me.TxtPerso1._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtPerso1._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtPerso1._BorderSize = 2
        Me.TxtPerso1._MaxLength = 200
        Me.TxtPerso1._Multiline = False
        Me.TxtPerso1._PasswordChar = False
        Me.TxtPerso1._UnderlinedStyle = True
        Me.TxtPerso1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtPerso1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPerso1.ForeColor = System.Drawing.Color.LightGray
        Me.TxtPerso1.Location = New System.Drawing.Point(3, 31)
        Me.TxtPerso1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtPerso1.Name = "TxtPerso1"
        Me.TxtPerso1.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtPerso1.Size = New System.Drawing.Size(385, 37)
        Me.TxtPerso1.TabIndex = 48
        Me.TxtPerso1.Texts = ""
        '
        'CboFormato
        '
        Me.CboFormato._BorderColor = System.Drawing.Color.PeachPuff
        Me.CboFormato._BorderSize = 1
        Me.CboFormato._IconColor = System.Drawing.Color.PeachPuff
        Me.CboFormato._ListBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboFormato._ListTextColor = System.Drawing.Color.Silver
        Me.CboFormato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboFormato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboFormato.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CboFormato.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TipoderecursoBindingSource, "Nombre", True))
        Me.CboFormato.DataSource = Nothing
        Me.CboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormato.Font = New System.Drawing.Font("Montserrat", 12.0!)
        Me.CboFormato.ForeColor = System.Drawing.Color.Silver
        Me.CboFormato.Items.AddRange(New Object() {"Físico", "Digital"})
        Me.CboFormato.Location = New System.Drawing.Point(3, 31)
        Me.CboFormato.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CboFormato.MinimumSize = New System.Drawing.Size(188, 41)
        Me.CboFormato.Name = "CboFormato"
        Me.CboFormato.Padding = New System.Windows.Forms.Padding(1)
        Me.CboFormato.Size = New System.Drawing.Size(384, 41)
        Me.CboFormato.TabIndex = 43
        Me.CboFormato.Texts = ""
        '
        'CboTipoRecurso
        '
        Me.CboTipoRecurso._BorderColor = System.Drawing.Color.PeachPuff
        Me.CboTipoRecurso._BorderSize = 1
        Me.CboTipoRecurso._IconColor = System.Drawing.Color.PeachPuff
        Me.CboTipoRecurso._ListBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboTipoRecurso._ListTextColor = System.Drawing.Color.Silver
        Me.CboTipoRecurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboTipoRecurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTipoRecurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CboTipoRecurso.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TipoderecursoBindingSource, "Nombre", True))
        Me.CboTipoRecurso.DataSource = Nothing
        Me.CboTipoRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboTipoRecurso.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoRecurso.ForeColor = System.Drawing.Color.Silver
        Me.CboTipoRecurso.Location = New System.Drawing.Point(3, 31)
        Me.CboTipoRecurso.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CboTipoRecurso.MinimumSize = New System.Drawing.Size(188, 41)
        Me.CboTipoRecurso.Name = "CboTipoRecurso"
        Me.CboTipoRecurso.Padding = New System.Windows.Forms.Padding(1)
        Me.CboTipoRecurso.Size = New System.Drawing.Size(384, 41)
        Me.CboTipoRecurso.TabIndex = 43
        Me.CboTipoRecurso.Texts = ""
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
        Me.BtnVolver.Location = New System.Drawing.Point(12, 12)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(39, 39)
        Me.BtnVolver.TabIndex = 21
        Me.BtnVolver.TextColor = System.Drawing.Color.White
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'TxtPerso4
        '
        Me.TxtPerso4._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtPerso4._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtPerso4._BorderSize = 2
        Me.TxtPerso4._MaxLength = 13
        Me.TxtPerso4._Multiline = False
        Me.TxtPerso4._PasswordChar = False
        Me.TxtPerso4._UnderlinedStyle = True
        Me.TxtPerso4.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtPerso4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPerso4.ForeColor = System.Drawing.Color.LightGray
        Me.TxtPerso4.Location = New System.Drawing.Point(5, 33)
        Me.TxtPerso4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtPerso4.Name = "TxtPerso4"
        Me.TxtPerso4.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtPerso4.Size = New System.Drawing.Size(385, 37)
        Me.TxtPerso4.TabIndex = 51
        Me.TxtPerso4.Texts = ""
        '
        'PnlAutor
        '
        Me.PnlAutor.Controls.Add(Me.Panel9)
        Me.PnlAutor.Controls.Add(Me.Label3)
        Me.PnlAutor.Controls.Add(Me.TxtPerso3)
        Me.PnlAutor.Controls.Add(Me.Label4)
        Me.PnlAutor.Controls.Add(Me.TxtPerso2)
        Me.PnlAutor.Location = New System.Drawing.Point(70, 186)
        Me.PnlAutor.Name = "PnlAutor"
        Me.PnlAutor.Size = New System.Drawing.Size(390, 96)
        Me.PnlAutor.TabIndex = 52
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.TxtPerso4)
        Me.Panel1.Location = New System.Drawing.Point(500, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 77)
        Me.Panel1.TabIndex = 53
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.CboTipoRecurso)
        Me.Panel2.Location = New System.Drawing.Point(500, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(390, 77)
        Me.Panel2.TabIndex = 54
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel12)
        Me.Panel4.Controls.Add(Me.CboFormato)
        Me.Panel4.Location = New System.Drawing.Point(500, 276)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(390, 77)
        Me.Panel4.TabIndex = 55
        '
        'FrmCrearRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(910, 472)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(944, 472)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlAutor)
        Me.Controls.Add(Me.PnlTitulo)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PnlProductos)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCrearRegistros"
        Me.Text = "CrearRegistros"
        Me.PnlTituloHeader.ResumeLayout(False)
        Me.PnlTituloHeader.PerformLayout()
        CType(Me.PcbTituloHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdbibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoderecursoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitulo.ResumeLayout(False)
        Me.PnlAutor.ResumeLayout(False)
        Me.PnlAutor.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVolver As Biblioteca.ButtonRadio
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboTipoRecurso As Biblioteca.ComboPerso
    Friend WithEvents BdbibliotecaDataSet As Biblioteca.bdbibliotecaDataSet
    Friend WithEvents AutorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutorTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.autorTableAdapter
    Friend WithEvents TipoderecursoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoderecursoTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.tipoderecursoTableAdapter
    Friend WithEvents CboFormato As Biblioteca.ComboPerso
    Friend WithEvents PnlTituloHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTituloLibro As System.Windows.Forms.Label
    Friend WithEvents PcbTituloHeader As System.Windows.Forms.PictureBox
    Friend WithEvents PnlProductos As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents TxtPerso1 As Biblioteca.TxtPerso
    Friend WithEvents TxtPerso2 As Biblioteca.TxtPerso
    Friend WithEvents TxtPerso3 As Biblioteca.TxtPerso
    Friend WithEvents TxtPerso4 As Biblioteca.TxtPerso
    Friend WithEvents PnlAutor As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
