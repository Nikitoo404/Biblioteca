﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PnlTituloLinea = New System.Windows.Forms.Panel()
        Me.PcbTituloHeader = New System.Windows.Forms.PictureBox()
        Me.lblTituloLibro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlTitAutor = New System.Windows.Forms.Panel()
        Me.PnlAutorHeader = New System.Windows.Forms.Panel()
        Me.PnlAutorLinea = New System.Windows.Forms.Panel()
        Me.PcbAutorHeader = New System.Windows.Forms.PictureBox()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.PnlISBNHeader = New System.Windows.Forms.Panel()
        Me.PnlISHeader = New System.Windows.Forms.Panel()
        Me.PcbISBNHeader = New System.Windows.Forms.PictureBox()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.PnlTipoHeader = New System.Windows.Forms.Panel()
        Me.PnlTipoLinea = New System.Windows.Forms.Panel()
        Me.PcbTipoHeader = New System.Windows.Forms.PictureBox()
        Me.lblTipoRecurso = New System.Windows.Forms.Label()
        Me.PnlISso = New System.Windows.Forms.Panel()
        Me.PnlTipoto = New System.Windows.Forms.Panel()
        Me.PnlFormatoHeader = New System.Windows.Forms.Panel()
        Me.PnlFormatoLinea = New System.Windows.Forms.Panel()
        Me.PcbFormatoHeader = New System.Windows.Forms.PictureBox()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.PnlTitulo = New System.Windows.Forms.Panel()
        Me.PnlAutor = New System.Windows.Forms.Panel()
        Me.PnlISBN = New System.Windows.Forms.Panel()
        Me.PnlTipoRecurso = New System.Windows.Forms.Panel()
        Me.PnlFormato = New System.Windows.Forms.Panel()
        Me.PnlGenero = New System.Windows.Forms.Panel()
        Me.PnlGeneroHeader = New System.Windows.Forms.Panel()
        Me.PnlGeneLinea = New System.Windows.Forms.Panel()
        Me.PcbGeneroHeader = New System.Windows.Forms.PictureBox()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.PnlFecha = New System.Windows.Forms.Panel()
        Me.PnlFechaHeader = New System.Windows.Forms.Panel()
        Me.PnlFechaLinea = New System.Windows.Forms.Panel()
        Me.PcbFechaHeader = New System.Windows.Forms.PictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.PnlAutero = New System.Windows.Forms.Panel()
        Me.PnlForcion = New System.Windows.Forms.Panel()
        Me.PnlFechal = New System.Windows.Forms.Panel()
        Me.PnlEditorial = New System.Windows.Forms.Panel()
        Me.PnlEditorialHeader = New System.Windows.Forms.Panel()
        Me.PnlEditLinea = New System.Windows.Forms.Panel()
        Me.PcbEditorialHeader = New System.Windows.Forms.PictureBox()
        Me.lblEditorial = New System.Windows.Forms.Label()
        Me.PnlGenecion = New System.Windows.Forms.Panel()
        Me.PnlEdias = New System.Windows.Forms.Panel()
        Me.PnlEdicion = New System.Windows.Forms.Panel()
        Me.PnlEdicionHeader = New System.Windows.Forms.Panel()
        Me.PnlEdicLinea = New System.Windows.Forms.Panel()
        Me.PcbEdicionHeader = New System.Windows.Forms.PictureBox()
        Me.lblEdicion = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PnlEdiado = New System.Windows.Forms.Panel()
        Me.PnlPaginas = New System.Windows.Forms.Panel()
        Me.PnlPagHeader = New System.Windows.Forms.Panel()
        Me.PnlPagLinea = New System.Windows.Forms.Panel()
        Me.PcbPagHeader = New System.Windows.Forms.PictureBox()
        Me.lblPag = New System.Windows.Forms.Label()
        Me.PnlEstado = New System.Windows.Forms.Panel()
        Me.PnlEstadoHeader = New System.Windows.Forms.Panel()
        Me.PnlEstLinea = New System.Windows.Forms.Panel()
        Me.PcbEstadoHeader = New System.Windows.Forms.PictureBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.PnlEstadoFin = New System.Windows.Forms.Panel()
        Me.PnlPagFin = New System.Windows.Forms.Panel()
        Me.CboEstado = New Biblioteca.ComboPerso()
        Me.BtnGuardar = New Biblioteca.ButtonRadio()
        Me.TxtPag = New Biblioteca.TxtPerso()
        Me.TxtAno = New Biblioteca.TxtPerso()
        Me.TxtNumero = New Biblioteca.TxtPerso()
        Me.CboEditorial = New Biblioteca.ComboPerso()
        Me.DtpFecha = New Biblioteca.MiDatePicker()
        Me.BtnFecha = New Biblioteca.ButtonToggleOnOff()
        Me.CboGenero = New Biblioteca.ComboPerso()
        Me.CboFormato = New Biblioteca.ComboPerso()
        Me.CboTipoRecurso = New Biblioteca.ComboPerso()
        Me.TxtISBN = New Biblioteca.TxtPerso()
        Me.TxtApellido = New Biblioteca.TxtPerso()
        Me.TxtNombre = New Biblioteca.TxtPerso()
        Me.TxtTitulo = New Biblioteca.TxtPerso()
        Me.BtnVolver = New Biblioteca.ButtonRadio()
        Me.EditorialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdbibliotecaDataSet = New Biblioteca.bdbibliotecaDataSet()
        Me.GeneroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoderecursoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoderecursoTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.tipoderecursoTableAdapter()
        Me.AutorTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.autorTableAdapter()
        Me.EditorialTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.editorialTableAdapter()
        Me.GeneroTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.generoTableAdapter()
        Me.EstadoTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.estadoTableAdapter()
        Me.FormatoTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.formatoTableAdapter()
        Me.RecursosTableAdapter = New Biblioteca.bdbibliotecaDataSetTableAdapters.recursosTableAdapter()
        Me.PnlTituloHeader.SuspendLayout()
        CType(Me.PcbTituloHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlAutorHeader.SuspendLayout()
        CType(Me.PcbAutorHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlISBNHeader.SuspendLayout()
        CType(Me.PcbISBNHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTipoHeader.SuspendLayout()
        CType(Me.PcbTipoHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFormatoHeader.SuspendLayout()
        CType(Me.PcbFormatoHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitulo.SuspendLayout()
        Me.PnlAutor.SuspendLayout()
        Me.PnlISBN.SuspendLayout()
        Me.PnlTipoRecurso.SuspendLayout()
        Me.PnlFormato.SuspendLayout()
        Me.PnlGenero.SuspendLayout()
        Me.PnlGeneroHeader.SuspendLayout()
        CType(Me.PcbGeneroHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFecha.SuspendLayout()
        Me.PnlFechaHeader.SuspendLayout()
        CType(Me.PcbFechaHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEditorial.SuspendLayout()
        Me.PnlEditorialHeader.SuspendLayout()
        CType(Me.PcbEditorialHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEdicion.SuspendLayout()
        Me.PnlEdicionHeader.SuspendLayout()
        CType(Me.PcbEdicionHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPaginas.SuspendLayout()
        Me.PnlPagHeader.SuspendLayout()
        CType(Me.PcbPagHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEstado.SuspendLayout()
        Me.PnlEstadoHeader.SuspendLayout()
        CType(Me.PcbEstadoHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditorialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdbibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoderecursoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LblTitulo.TabIndex = 86
        Me.LblTitulo.Text = "Crear registros"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTituloHeader
        '
        Me.PnlTituloHeader.Controls.Add(Me.PnlTituloLinea)
        Me.PnlTituloHeader.Controls.Add(Me.PcbTituloHeader)
        Me.PnlTituloHeader.Controls.Add(Me.lblTituloLibro)
        Me.PnlTituloHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlTituloHeader.Name = "PnlTituloHeader"
        Me.PnlTituloHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlTituloHeader.TabIndex = 16
        '
        'PnlTituloLinea
        '
        Me.PnlTituloLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlTituloLinea.Location = New System.Drawing.Point(57, 12)
        Me.PnlTituloLinea.Name = "PnlTituloLinea"
        Me.PnlTituloLinea.Size = New System.Drawing.Size(307, 1)
        Me.PnlTituloLinea.TabIndex = 28
        '
        'PcbTituloHeader
        '
        Me.PcbTituloHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
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
        Me.lblTituloLibro.TabIndex = 27
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
        Me.Label4.Location = New System.Drawing.Point(203, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 22)
        Me.Label4.TabIndex = 33
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
        Me.Label3.Location = New System.Drawing.Point(1, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Nombre/s"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTitAutor
        '
        Me.PnlTitAutor.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlTitAutor.Location = New System.Drawing.Point(40, 166)
        Me.PnlTitAutor.Name = "PnlTitAutor"
        Me.PnlTitAutor.Size = New System.Drawing.Size(390, 1)
        Me.PnlTitAutor.TabIndex = 29
        '
        'PnlAutorHeader
        '
        Me.PnlAutorHeader.Controls.Add(Me.PnlAutorLinea)
        Me.PnlAutorHeader.Controls.Add(Me.PcbAutorHeader)
        Me.PnlAutorHeader.Controls.Add(Me.lblAutor)
        Me.PnlAutorHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlAutorHeader.Name = "PnlAutorHeader"
        Me.PnlAutorHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlAutorHeader.TabIndex = 17
        '
        'PnlAutorLinea
        '
        Me.PnlAutorLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlAutorLinea.Location = New System.Drawing.Point(55, 11)
        Me.PnlAutorLinea.Name = "PnlAutorLinea"
        Me.PnlAutorLinea.Size = New System.Drawing.Size(310, 1)
        Me.PnlAutorLinea.TabIndex = 31
        '
        'PcbAutorHeader
        '
        Me.PcbAutorHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbAutorHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbAutorHeader.Name = "PcbAutorHeader"
        Me.PcbAutorHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbAutorHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbAutorHeader.TabIndex = 35
        Me.PcbAutorHeader.TabStop = False
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.BackColor = System.Drawing.Color.Transparent
        Me.lblAutor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAutor.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.ForeColor = System.Drawing.Color.Silver
        Me.lblAutor.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblAutor.Location = New System.Drawing.Point(-4, 0)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(54, 22)
        Me.lblAutor.TabIndex = 30
        Me.lblAutor.Text = "Autor"
        Me.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlISBNHeader
        '
        Me.PnlISBNHeader.Controls.Add(Me.PnlISHeader)
        Me.PnlISBNHeader.Controls.Add(Me.PcbISBNHeader)
        Me.PnlISBNHeader.Controls.Add(Me.lblISBN)
        Me.PnlISBNHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlISBNHeader.Name = "PnlISBNHeader"
        Me.PnlISBNHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlISBNHeader.TabIndex = 21
        '
        'PnlISHeader
        '
        Me.PnlISHeader.BackColor = System.Drawing.Color.Silver
        Me.PnlISHeader.Location = New System.Drawing.Point(52, 12)
        Me.PnlISHeader.Name = "PnlISHeader"
        Me.PnlISHeader.Size = New System.Drawing.Size(310, 1)
        Me.PnlISHeader.TabIndex = 53
        '
        'PcbISBNHeader
        '
        Me.PcbISBNHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbISBNHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbISBNHeader.Name = "PcbISBNHeader"
        Me.PcbISBNHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbISBNHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbISBNHeader.TabIndex = 35
        Me.PcbISBNHeader.TabStop = False
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.BackColor = System.Drawing.Color.Transparent
        Me.lblISBN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblISBN.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.ForeColor = System.Drawing.Color.Silver
        Me.lblISBN.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblISBN.Location = New System.Drawing.Point(-4, 0)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(50, 22)
        Me.lblISBN.TabIndex = 52
        Me.lblISBN.Text = "ISBN"
        Me.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTipoHeader
        '
        Me.PnlTipoHeader.Controls.Add(Me.PnlTipoLinea)
        Me.PnlTipoHeader.Controls.Add(Me.PcbTipoHeader)
        Me.PnlTipoHeader.Controls.Add(Me.lblTipoRecurso)
        Me.PnlTipoHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlTipoHeader.Name = "PnlTipoHeader"
        Me.PnlTipoHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlTipoHeader.TabIndex = 22
        '
        'PnlTipoLinea
        '
        Me.PnlTipoLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlTipoLinea.Location = New System.Drawing.Point(135, 11)
        Me.PnlTipoLinea.Name = "PnlTipoLinea"
        Me.PnlTipoLinea.Size = New System.Drawing.Size(230, 1)
        Me.PnlTipoLinea.TabIndex = 57
        '
        'PcbTipoHeader
        '
        Me.PcbTipoHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbTipoHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbTipoHeader.Name = "PcbTipoHeader"
        Me.PcbTipoHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbTipoHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbTipoHeader.TabIndex = 35
        Me.PcbTipoHeader.TabStop = False
        '
        'lblTipoRecurso
        '
        Me.lblTipoRecurso.AutoSize = True
        Me.lblTipoRecurso.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoRecurso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoRecurso.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoRecurso.ForeColor = System.Drawing.Color.Silver
        Me.lblTipoRecurso.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTipoRecurso.Location = New System.Drawing.Point(-4, 0)
        Me.lblTipoRecurso.Name = "lblTipoRecurso"
        Me.lblTipoRecurso.Size = New System.Drawing.Size(133, 22)
        Me.lblTipoRecurso.TabIndex = 56
        Me.lblTipoRecurso.Text = "Tipo de recurso"
        Me.lblTipoRecurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlISso
        '
        Me.PnlISso.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlISso.Location = New System.Drawing.Point(465, 166)
        Me.PnlISso.Name = "PnlISso"
        Me.PnlISso.Size = New System.Drawing.Size(390, 1)
        Me.PnlISso.TabIndex = 54
        '
        'PnlTipoto
        '
        Me.PnlTipoto.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlTipoto.Location = New System.Drawing.Point(465, 257)
        Me.PnlTipoto.Name = "PnlTipoto"
        Me.PnlTipoto.Size = New System.Drawing.Size(390, 1)
        Me.PnlTipoto.TabIndex = 58
        '
        'PnlFormatoHeader
        '
        Me.PnlFormatoHeader.Controls.Add(Me.PnlFormatoLinea)
        Me.PnlFormatoHeader.Controls.Add(Me.PcbFormatoHeader)
        Me.PnlFormatoHeader.Controls.Add(Me.lblFormato)
        Me.PnlFormatoHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlFormatoHeader.Name = "PnlFormatoHeader"
        Me.PnlFormatoHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlFormatoHeader.TabIndex = 23
        '
        'PnlFormatoLinea
        '
        Me.PnlFormatoLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlFormatoLinea.Location = New System.Drawing.Point(80, 12)
        Me.PnlFormatoLinea.Name = "PnlFormatoLinea"
        Me.PnlFormatoLinea.Size = New System.Drawing.Size(285, 1)
        Me.PnlFormatoLinea.TabIndex = 61
        '
        'PcbFormatoHeader
        '
        Me.PcbFormatoHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbFormatoHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbFormatoHeader.Name = "PcbFormatoHeader"
        Me.PcbFormatoHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbFormatoHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbFormatoHeader.TabIndex = 35
        Me.PcbFormatoHeader.TabStop = False
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.BackColor = System.Drawing.Color.Transparent
        Me.lblFormato.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFormato.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormato.ForeColor = System.Drawing.Color.Silver
        Me.lblFormato.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblFormato.Location = New System.Drawing.Point(-4, 0)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(78, 22)
        Me.lblFormato.TabIndex = 60
        Me.lblFormato.Text = "Formato"
        Me.lblFormato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTitulo
        '
        Me.PnlTitulo.Controls.Add(Me.TxtTitulo)
        Me.PnlTitulo.Controls.Add(Me.PnlTituloHeader)
        Me.PnlTitulo.Location = New System.Drawing.Point(40, 82)
        Me.PnlTitulo.Name = "PnlTitulo"
        Me.PnlTitulo.Size = New System.Drawing.Size(390, 78)
        Me.PnlTitulo.TabIndex = 0
        '
        'PnlAutor
        '
        Me.PnlAutor.Controls.Add(Me.PnlAutorHeader)
        Me.PnlAutor.Controls.Add(Me.Label3)
        Me.PnlAutor.Controls.Add(Me.TxtApellido)
        Me.PnlAutor.Controls.Add(Me.Label4)
        Me.PnlAutor.Controls.Add(Me.TxtNombre)
        Me.PnlAutor.Location = New System.Drawing.Point(40, 174)
        Me.PnlAutor.Name = "PnlAutor"
        Me.PnlAutor.Size = New System.Drawing.Size(390, 96)
        Me.PnlAutor.TabIndex = 1
        '
        'PnlISBN
        '
        Me.PnlISBN.Controls.Add(Me.PnlISBNHeader)
        Me.PnlISBN.Controls.Add(Me.TxtISBN)
        Me.PnlISBN.Location = New System.Drawing.Point(465, 82)
        Me.PnlISBN.Name = "PnlISBN"
        Me.PnlISBN.Size = New System.Drawing.Size(390, 78)
        Me.PnlISBN.TabIndex = 6
        '
        'PnlTipoRecurso
        '
        Me.PnlTipoRecurso.Controls.Add(Me.PnlTipoHeader)
        Me.PnlTipoRecurso.Controls.Add(Me.CboTipoRecurso)
        Me.PnlTipoRecurso.Location = New System.Drawing.Point(465, 173)
        Me.PnlTipoRecurso.Name = "PnlTipoRecurso"
        Me.PnlTipoRecurso.Size = New System.Drawing.Size(390, 78)
        Me.PnlTipoRecurso.TabIndex = 7
        '
        'PnlFormato
        '
        Me.PnlFormato.Controls.Add(Me.PnlFormatoHeader)
        Me.PnlFormato.Controls.Add(Me.CboFormato)
        Me.PnlFormato.Location = New System.Drawing.Point(465, 264)
        Me.PnlFormato.Name = "PnlFormato"
        Me.PnlFormato.Size = New System.Drawing.Size(390, 78)
        Me.PnlFormato.TabIndex = 8
        '
        'PnlGenero
        '
        Me.PnlGenero.Controls.Add(Me.PnlGeneroHeader)
        Me.PnlGenero.Controls.Add(Me.CboGenero)
        Me.PnlGenero.Location = New System.Drawing.Point(40, 284)
        Me.PnlGenero.Name = "PnlGenero"
        Me.PnlGenero.Size = New System.Drawing.Size(390, 78)
        Me.PnlGenero.TabIndex = 2
        '
        'PnlGeneroHeader
        '
        Me.PnlGeneroHeader.Controls.Add(Me.PnlGeneLinea)
        Me.PnlGeneroHeader.Controls.Add(Me.PcbGeneroHeader)
        Me.PnlGeneroHeader.Controls.Add(Me.lblGenero)
        Me.PnlGeneroHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlGeneroHeader.Name = "PnlGeneroHeader"
        Me.PnlGeneroHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlGeneroHeader.TabIndex = 18
        '
        'PnlGeneLinea
        '
        Me.PnlGeneLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlGeneLinea.Location = New System.Drawing.Point(72, 12)
        Me.PnlGeneLinea.Name = "PnlGeneLinea"
        Me.PnlGeneLinea.Size = New System.Drawing.Size(290, 1)
        Me.PnlGeneLinea.TabIndex = 39
        '
        'PcbGeneroHeader
        '
        Me.PcbGeneroHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbGeneroHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbGeneroHeader.Name = "PcbGeneroHeader"
        Me.PcbGeneroHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbGeneroHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbGeneroHeader.TabIndex = 35
        Me.PcbGeneroHeader.TabStop = False
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.BackColor = System.Drawing.Color.Transparent
        Me.lblGenero.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGenero.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.ForeColor = System.Drawing.Color.Silver
        Me.lblGenero.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblGenero.Location = New System.Drawing.Point(-4, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(69, 22)
        Me.lblGenero.TabIndex = 38
        Me.lblGenero.Text = "Género"
        Me.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlFecha
        '
        Me.PnlFecha.Controls.Add(Me.DtpFecha)
        Me.PnlFecha.Controls.Add(Me.BtnFecha)
        Me.PnlFecha.Controls.Add(Me.PnlFechaHeader)
        Me.PnlFecha.Location = New System.Drawing.Point(465, 355)
        Me.PnlFecha.Name = "PnlFecha"
        Me.PnlFecha.Size = New System.Drawing.Size(390, 110)
        Me.PnlFecha.TabIndex = 9
        '
        'PnlFechaHeader
        '
        Me.PnlFechaHeader.Controls.Add(Me.PnlFechaLinea)
        Me.PnlFechaHeader.Controls.Add(Me.PcbFechaHeader)
        Me.PnlFechaHeader.Controls.Add(Me.lblFecha)
        Me.PnlFechaHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlFechaHeader.Name = "PnlFechaHeader"
        Me.PnlFechaHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlFechaHeader.TabIndex = 24
        '
        'PnlFechaLinea
        '
        Me.PnlFechaLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlFechaLinea.Location = New System.Drawing.Point(183, 12)
        Me.PnlFechaLinea.Name = "PnlFechaLinea"
        Me.PnlFechaLinea.Size = New System.Drawing.Size(180, 1)
        Me.PnlFechaLinea.TabIndex = 65
        '
        'PcbFechaHeader
        '
        Me.PcbFechaHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbFechaHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbFechaHeader.Name = "PcbFechaHeader"
        Me.PcbFechaHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbFechaHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbFechaHeader.TabIndex = 35
        Me.PcbFechaHeader.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFecha.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Silver
        Me.lblFecha.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblFecha.Location = New System.Drawing.Point(-4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(181, 22)
        Me.lblFecha.TabIndex = 64
        Me.lblFecha.Text = "Fecha de publicación"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlAutero
        '
        Me.PnlAutero.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlAutero.Location = New System.Drawing.Point(40, 277)
        Me.PnlAutero.Name = "PnlAutero"
        Me.PnlAutero.Size = New System.Drawing.Size(390, 1)
        Me.PnlAutero.TabIndex = 36
        '
        'PnlForcion
        '
        Me.PnlForcion.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlForcion.Location = New System.Drawing.Point(465, 348)
        Me.PnlForcion.Name = "PnlForcion"
        Me.PnlForcion.Size = New System.Drawing.Size(390, 1)
        Me.PnlForcion.TabIndex = 62
        '
        'PnlFechal
        '
        Me.PnlFechal.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlFechal.Location = New System.Drawing.Point(465, 470)
        Me.PnlFechal.Name = "PnlFechal"
        Me.PnlFechal.Size = New System.Drawing.Size(390, 1)
        Me.PnlFechal.TabIndex = 66
        '
        'PnlEditorial
        '
        Me.PnlEditorial.Controls.Add(Me.PnlEditorialHeader)
        Me.PnlEditorial.Controls.Add(Me.CboEditorial)
        Me.PnlEditorial.Location = New System.Drawing.Point(465, 477)
        Me.PnlEditorial.Name = "PnlEditorial"
        Me.PnlEditorial.Size = New System.Drawing.Size(390, 78)
        Me.PnlEditorial.TabIndex = 10
        '
        'PnlEditorialHeader
        '
        Me.PnlEditorialHeader.Controls.Add(Me.PnlEditLinea)
        Me.PnlEditorialHeader.Controls.Add(Me.PcbEditorialHeader)
        Me.PnlEditorialHeader.Controls.Add(Me.lblEditorial)
        Me.PnlEditorialHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlEditorialHeader.Name = "PnlEditorialHeader"
        Me.PnlEditorialHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlEditorialHeader.TabIndex = 25
        '
        'PnlEditLinea
        '
        Me.PnlEditLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlEditLinea.Location = New System.Drawing.Point(83, 11)
        Me.PnlEditLinea.Name = "PnlEditLinea"
        Me.PnlEditLinea.Size = New System.Drawing.Size(280, 1)
        Me.PnlEditLinea.TabIndex = 69
        '
        'PcbEditorialHeader
        '
        Me.PcbEditorialHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbEditorialHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbEditorialHeader.Name = "PcbEditorialHeader"
        Me.PcbEditorialHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbEditorialHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbEditorialHeader.TabIndex = 35
        Me.PcbEditorialHeader.TabStop = False
        '
        'lblEditorial
        '
        Me.lblEditorial.AutoSize = True
        Me.lblEditorial.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEditorial.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorial.ForeColor = System.Drawing.Color.Silver
        Me.lblEditorial.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblEditorial.Location = New System.Drawing.Point(-4, 0)
        Me.lblEditorial.Name = "lblEditorial"
        Me.lblEditorial.Size = New System.Drawing.Size(75, 22)
        Me.lblEditorial.TabIndex = 68
        Me.lblEditorial.Text = "Editorial"
        Me.lblEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlGenecion
        '
        Me.PnlGenecion.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlGenecion.Location = New System.Drawing.Point(40, 368)
        Me.PnlGenecion.Name = "PnlGenecion"
        Me.PnlGenecion.Size = New System.Drawing.Size(390, 1)
        Me.PnlGenecion.TabIndex = 40
        '
        'PnlEdias
        '
        Me.PnlEdias.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlEdias.Location = New System.Drawing.Point(465, 560)
        Me.PnlEdias.Name = "PnlEdias"
        Me.PnlEdias.Size = New System.Drawing.Size(390, 1)
        Me.PnlEdias.TabIndex = 70
        '
        'PnlEdicion
        '
        Me.PnlEdicion.Controls.Add(Me.PnlEdicionHeader)
        Me.PnlEdicion.Controls.Add(Me.Label12)
        Me.PnlEdicion.Controls.Add(Me.TxtAno)
        Me.PnlEdicion.Controls.Add(Me.Label13)
        Me.PnlEdicion.Controls.Add(Me.TxtNumero)
        Me.PnlEdicion.Location = New System.Drawing.Point(40, 375)
        Me.PnlEdicion.Name = "PnlEdicion"
        Me.PnlEdicion.Size = New System.Drawing.Size(390, 96)
        Me.PnlEdicion.TabIndex = 4
        '
        'PnlEdicionHeader
        '
        Me.PnlEdicionHeader.Controls.Add(Me.PnlEdicLinea)
        Me.PnlEdicionHeader.Controls.Add(Me.PcbEdicionHeader)
        Me.PnlEdicionHeader.Controls.Add(Me.lblEdicion)
        Me.PnlEdicionHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlEdicionHeader.Name = "PnlEdicionHeader"
        Me.PnlEdicionHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlEdicionHeader.TabIndex = 19
        '
        'PnlEdicLinea
        '
        Me.PnlEdicLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlEdicLinea.Location = New System.Drawing.Point(72, 11)
        Me.PnlEdicLinea.Name = "PnlEdicLinea"
        Me.PnlEdicLinea.Size = New System.Drawing.Size(290, 1)
        Me.PnlEdicLinea.TabIndex = 43
        '
        'PcbEdicionHeader
        '
        Me.PcbEdicionHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbEdicionHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbEdicionHeader.Name = "PcbEdicionHeader"
        Me.PcbEdicionHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbEdicionHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbEdicionHeader.TabIndex = 35
        Me.PcbEdicionHeader.TabStop = False
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.BackColor = System.Drawing.Color.Transparent
        Me.lblEdicion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEdicion.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicion.ForeColor = System.Drawing.Color.Silver
        Me.lblEdicion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblEdicion.Location = New System.Drawing.Point(-4, 0)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(70, 22)
        Me.lblEdicion.TabIndex = 42
        Me.lblEdicion.Text = "Edición"
        Me.lblEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label12.Location = New System.Drawing.Point(3, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 22)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "N°"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Silver
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label13.Location = New System.Drawing.Point(203, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 22)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Año"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlEdiado
        '
        Me.PnlEdiado.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlEdiado.Location = New System.Drawing.Point(40, 477)
        Me.PnlEdiado.Name = "PnlEdiado"
        Me.PnlEdiado.Size = New System.Drawing.Size(390, 1)
        Me.PnlEdiado.TabIndex = 46
        '
        'PnlPaginas
        '
        Me.PnlPaginas.Controls.Add(Me.PnlPagHeader)
        Me.PnlPaginas.Controls.Add(Me.TxtPag)
        Me.PnlPaginas.Location = New System.Drawing.Point(465, 567)
        Me.PnlPaginas.Name = "PnlPaginas"
        Me.PnlPaginas.Size = New System.Drawing.Size(390, 78)
        Me.PnlPaginas.TabIndex = 11
        '
        'PnlPagHeader
        '
        Me.PnlPagHeader.Controls.Add(Me.PnlPagLinea)
        Me.PnlPagHeader.Controls.Add(Me.PcbPagHeader)
        Me.PnlPagHeader.Controls.Add(Me.lblPag)
        Me.PnlPagHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlPagHeader.Name = "PnlPagHeader"
        Me.PnlPagHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlPagHeader.TabIndex = 26
        '
        'PnlPagLinea
        '
        Me.PnlPagLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlPagLinea.Location = New System.Drawing.Point(124, 12)
        Me.PnlPagLinea.Name = "PnlPagLinea"
        Me.PnlPagLinea.Size = New System.Drawing.Size(240, 1)
        Me.PnlPagLinea.TabIndex = 73
        '
        'PcbPagHeader
        '
        Me.PcbPagHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbPagHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbPagHeader.Name = "PcbPagHeader"
        Me.PcbPagHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbPagHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbPagHeader.TabIndex = 35
        Me.PcbPagHeader.TabStop = False
        '
        'lblPag
        '
        Me.lblPag.AutoSize = True
        Me.lblPag.BackColor = System.Drawing.Color.Transparent
        Me.lblPag.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPag.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPag.ForeColor = System.Drawing.Color.Silver
        Me.lblPag.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblPag.Location = New System.Drawing.Point(-4, 0)
        Me.lblPag.Name = "lblPag"
        Me.lblPag.Size = New System.Drawing.Size(122, 22)
        Me.lblPag.TabIndex = 72
        Me.lblPag.Text = "N° de páginas"
        Me.lblPag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlEstado
        '
        Me.PnlEstado.Controls.Add(Me.PnlEstadoHeader)
        Me.PnlEstado.Controls.Add(Me.CboEstado)
        Me.PnlEstado.Location = New System.Drawing.Point(40, 484)
        Me.PnlEstado.Name = "PnlEstado"
        Me.PnlEstado.Size = New System.Drawing.Size(390, 78)
        Me.PnlEstado.TabIndex = 5
        '
        'PnlEstadoHeader
        '
        Me.PnlEstadoHeader.Controls.Add(Me.PnlEstLinea)
        Me.PnlEstadoHeader.Controls.Add(Me.PcbEstadoHeader)
        Me.PnlEstadoHeader.Controls.Add(Me.lblEstado)
        Me.PnlEstadoHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlEstadoHeader.Name = "PnlEstadoHeader"
        Me.PnlEstadoHeader.Size = New System.Drawing.Size(390, 22)
        Me.PnlEstadoHeader.TabIndex = 20
        '
        'PnlEstLinea
        '
        Me.PnlEstLinea.BackColor = System.Drawing.Color.Silver
        Me.PnlEstLinea.Location = New System.Drawing.Point(67, 11)
        Me.PnlEstLinea.Name = "PnlEstLinea"
        Me.PnlEstLinea.Size = New System.Drawing.Size(295, 1)
        Me.PnlEstLinea.TabIndex = 49
        '
        'PcbEstadoHeader
        '
        Me.PcbEstadoHeader.Image = Global.Biblioteca.My.Resources.Resources.flechaArriba
        Me.PcbEstadoHeader.Location = New System.Drawing.Point(371, 0)
        Me.PcbEstadoHeader.Name = "PcbEstadoHeader"
        Me.PcbEstadoHeader.Size = New System.Drawing.Size(19, 22)
        Me.PcbEstadoHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbEstadoHeader.TabIndex = 35
        Me.PcbEstadoHeader.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEstado.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Silver
        Me.lblEstado.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblEstado.Location = New System.Drawing.Point(-4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(65, 22)
        Me.lblEstado.TabIndex = 48
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlEstadoFin
        '
        Me.PnlEstadoFin.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlEstadoFin.Location = New System.Drawing.Point(40, 568)
        Me.PnlEstadoFin.Name = "PnlEstadoFin"
        Me.PnlEstadoFin.Size = New System.Drawing.Size(390, 1)
        Me.PnlEstadoFin.TabIndex = 50
        '
        'PnlPagFin
        '
        Me.PnlPagFin.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlPagFin.Location = New System.Drawing.Point(465, 651)
        Me.PnlPagFin.Name = "PnlPagFin"
        Me.PnlPagFin.Size = New System.Drawing.Size(390, 1)
        Me.PnlPagFin.TabIndex = 74
        '
        'CboEstado
        '
        Me.CboEstado._BorderColor = System.Drawing.Color.PeachPuff
        Me.CboEstado._BorderSize = 1
        Me.CboEstado._IconColor = System.Drawing.Color.PeachPuff
        Me.CboEstado._ListBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboEstado._ListTextColor = System.Drawing.Color.Silver
        Me.CboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CboEstado.DataSource = Nothing
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstado.ForeColor = System.Drawing.Color.Silver
        Me.CboEstado.Items.AddRange(New Object() {"Disponible", "Prestado", "Reservado", "Extraviado", "En reparación", "Dañado", "En proceso de adquisición", "No disponible"})
        Me.CboEstado.Location = New System.Drawing.Point(3, 31)
        Me.CboEstado.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CboEstado.MaxLength = 25
        Me.CboEstado.MinimumSize = New System.Drawing.Size(188, 41)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Padding = New System.Windows.Forms.Padding(1)
        Me.CboEstado.Size = New System.Drawing.Size(384, 41)
        Me.CboEstado.TabIndex = 7
        Me.CboEstado.Texts = ""
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnGuardar.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnGuardar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnGuardar.BorderRadius = 13
        Me.BtnGuardar.BorderSize = 1
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Silver
        Me.BtnGuardar.Location = New System.Drawing.Point(639, 18)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(126, 45)
        Me.BtnGuardar.TabIndex = 12
        Me.BtnGuardar.Text = "Guardar registro"
        Me.BtnGuardar.TextColor = System.Drawing.Color.Silver
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtPag
        '
        Me.TxtPag._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtPag._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtPag._BorderSize = 2
        Me.TxtPag._MaxLength = 10
        Me.TxtPag._Multiline = False
        Me.TxtPag._PasswordChar = False
        Me.TxtPag._UnderlinedStyle = True
        Me.TxtPag.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtPag.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPag.ForeColor = System.Drawing.Color.LightGray
        Me.TxtPag.Location = New System.Drawing.Point(5, 30)
        Me.TxtPag.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtPag.Name = "TxtPag"
        Me.TxtPag.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtPag.Size = New System.Drawing.Size(380, 37)
        Me.TxtPag.TabIndex = 13
        Me.TxtPag.Texts = ""
        '
        'TxtAno
        '
        Me.TxtAno._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtAno._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtAno._BorderSize = 2
        Me.TxtAno._MaxLength = 10
        Me.TxtAno._Multiline = False
        Me.TxtAno._PasswordChar = False
        Me.TxtAno._UnderlinedStyle = True
        Me.TxtAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtAno.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAno.ForeColor = System.Drawing.Color.LightGray
        Me.TxtAno.Location = New System.Drawing.Point(207, 50)
        Me.TxtAno.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtAno.Size = New System.Drawing.Size(178, 37)
        Me.TxtAno.TabIndex = 6
        Me.TxtAno.Texts = ""
        '
        'TxtNumero
        '
        Me.TxtNumero._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtNumero._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtNumero._BorderSize = 2
        Me.TxtNumero._MaxLength = 11
        Me.TxtNumero._Multiline = False
        Me.TxtNumero._PasswordChar = False
        Me.TxtNumero._UnderlinedStyle = True
        Me.TxtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtNumero.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero.ForeColor = System.Drawing.Color.LightGray
        Me.TxtNumero.Location = New System.Drawing.Point(5, 50)
        Me.TxtNumero.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtNumero.Size = New System.Drawing.Size(178, 37)
        Me.TxtNumero.TabIndex = 5
        Me.TxtNumero.Texts = ""
        '
        'CboEditorial
        '
        Me.CboEditorial._BorderColor = System.Drawing.Color.PeachPuff
        Me.CboEditorial._BorderSize = 1
        Me.CboEditorial._IconColor = System.Drawing.Color.PeachPuff
        Me.CboEditorial._ListBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboEditorial._ListTextColor = System.Drawing.Color.Silver
        Me.CboEditorial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboEditorial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboEditorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CboEditorial.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.EditorialBindingSource, "Nombre", True))
        Me.CboEditorial.DataSource = Nothing
        Me.CboEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboEditorial.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEditorial.ForeColor = System.Drawing.Color.Silver
        Me.CboEditorial.Location = New System.Drawing.Point(3, 31)
        Me.CboEditorial.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CboEditorial.MaxLength = 100
        Me.CboEditorial.MinimumSize = New System.Drawing.Size(188, 41)
        Me.CboEditorial.Name = "CboEditorial"
        Me.CboEditorial.Padding = New System.Windows.Forms.Padding(1)
        Me.CboEditorial.Size = New System.Drawing.Size(384, 41)
        Me.CboEditorial.TabIndex = 12
        Me.CboEditorial.Texts = ""
        '
        'DtpFecha
        '
        Me.DtpFecha.BorderColor = System.Drawing.Color.PeachPuff
        Me.DtpFecha.BorderSize = 1
        Me.DtpFecha.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(5, 28)
        Me.DtpFecha.MinimumSize = New System.Drawing.Size(4, 41)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(380, 41)
        Me.DtpFecha.SkinColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DtpFecha.TabIndex = 26
        Me.DtpFecha.TextColor = System.Drawing.Color.White
        '
        'BtnFecha
        '
        Me.BtnFecha.AutoSize = True
        Me.BtnFecha.Location = New System.Drawing.Point(5, 77)
        Me.BtnFecha.MinimumSize = New System.Drawing.Size(65, 25)
        Me.BtnFecha.Name = "BtnFecha"
        Me.BtnFecha.OffBackColor = System.Drawing.Color.Gray
        Me.BtnFecha.OffToggleColor = System.Drawing.Color.Gainsboro
        Me.BtnFecha.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnFecha.OnToggleColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BtnFecha.Size = New System.Drawing.Size(65, 25)
        Me.BtnFecha.SolidStyle = True
        Me.BtnFecha.TabIndex = 25
        Me.BtnFecha.UseVisualStyleBackColor = True
        '
        'CboGenero
        '
        Me.CboGenero._BorderColor = System.Drawing.Color.PeachPuff
        Me.CboGenero._BorderSize = 1
        Me.CboGenero._IconColor = System.Drawing.Color.PeachPuff
        Me.CboGenero._ListBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CboGenero._ListTextColor = System.Drawing.Color.Silver
        Me.CboGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CboGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboGenero.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CboGenero.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.GeneroBindingSource, "Nombre", True))
        Me.CboGenero.DataSource = Nothing
        Me.CboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboGenero.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboGenero.ForeColor = System.Drawing.Color.Silver
        Me.CboGenero.Location = New System.Drawing.Point(3, 31)
        Me.CboGenero.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CboGenero.MaxLength = 100
        Me.CboGenero.MinimumSize = New System.Drawing.Size(188, 41)
        Me.CboGenero.Name = "CboGenero"
        Me.CboGenero.Padding = New System.Windows.Forms.Padding(1)
        Me.CboGenero.Size = New System.Drawing.Size(384, 41)
        Me.CboGenero.TabIndex = 0
        Me.CboGenero.Texts = ""
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
        Me.CboFormato.DataSource = Nothing
        Me.CboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormato.Font = New System.Drawing.Font("Montserrat", 12.0!)
        Me.CboFormato.ForeColor = System.Drawing.Color.Silver
        Me.CboFormato.Items.AddRange(New Object() {"Físico", "Digital", "Físico y Digital"})
        Me.CboFormato.Location = New System.Drawing.Point(3, 31)
        Me.CboFormato.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CboFormato.MaxLength = 100
        Me.CboFormato.MinimumSize = New System.Drawing.Size(188, 41)
        Me.CboFormato.Name = "CboFormato"
        Me.CboFormato.Padding = New System.Windows.Forms.Padding(1)
        Me.CboFormato.Size = New System.Drawing.Size(384, 41)
        Me.CboFormato.TabIndex = 10
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
        Me.CboTipoRecurso.MaxLength = 100
        Me.CboTipoRecurso.MinimumSize = New System.Drawing.Size(188, 41)
        Me.CboTipoRecurso.Name = "CboTipoRecurso"
        Me.CboTipoRecurso.Padding = New System.Windows.Forms.Padding(1)
        Me.CboTipoRecurso.Size = New System.Drawing.Size(384, 41)
        Me.CboTipoRecurso.TabIndex = 9
        Me.CboTipoRecurso.Texts = ""
        '
        'TxtISBN
        '
        Me.TxtISBN._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtISBN._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtISBN._BorderSize = 2
        Me.TxtISBN._MaxLength = 17
        Me.TxtISBN._Multiline = False
        Me.TxtISBN._PasswordChar = False
        Me.TxtISBN._UnderlinedStyle = True
        Me.TxtISBN.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtISBN.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtISBN.ForeColor = System.Drawing.Color.LightGray
        Me.TxtISBN.Location = New System.Drawing.Point(5, 33)
        Me.TxtISBN.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtISBN.Name = "TxtISBN"
        Me.TxtISBN.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtISBN.Size = New System.Drawing.Size(380, 37)
        Me.TxtISBN.TabIndex = 8
        Me.TxtISBN.Texts = ""
        '
        'TxtApellido
        '
        Me.TxtApellido._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtApellido._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtApellido._BorderSize = 2
        Me.TxtApellido._MaxLength = 100
        Me.TxtApellido._Multiline = False
        Me.TxtApellido._PasswordChar = False
        Me.TxtApellido._UnderlinedStyle = True
        Me.TxtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.AutorBindingSource, "Apellidos", True))
        Me.TxtApellido.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.ForeColor = System.Drawing.Color.LightGray
        Me.TxtApellido.Location = New System.Drawing.Point(207, 50)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtApellido.Size = New System.Drawing.Size(178, 37)
        Me.TxtApellido.TabIndex = 3
        Me.TxtApellido.Texts = ""
        '
        'TxtNombre
        '
        Me.TxtNombre._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtNombre._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtNombre._BorderSize = 2
        Me.TxtNombre._MaxLength = 100
        Me.TxtNombre._Multiline = False
        Me.TxtNombre._PasswordChar = False
        Me.TxtNombre._UnderlinedStyle = True
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.AutorBindingSource, "Nombres", True))
        Me.TxtNombre.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.LightGray
        Me.TxtNombre.Location = New System.Drawing.Point(5, 50)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtNombre.Size = New System.Drawing.Size(178, 37)
        Me.TxtNombre.TabIndex = 2
        Me.TxtNombre.Texts = ""
        '
        'TxtTitulo
        '
        Me.TxtTitulo._BorderColor = System.Drawing.Color.PeachPuff
        Me.TxtTitulo._BorderFocusColor = System.Drawing.Color.PeachPuff
        Me.TxtTitulo._BorderSize = 2
        Me.TxtTitulo._MaxLength = 200
        Me.TxtTitulo._Multiline = False
        Me.TxtTitulo._PasswordChar = False
        Me.TxtTitulo._UnderlinedStyle = True
        Me.TxtTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TxtTitulo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitulo.ForeColor = System.Drawing.Color.LightGray
        Me.TxtTitulo.Location = New System.Drawing.Point(7, 30)
        Me.TxtTitulo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Padding = New System.Windows.Forms.Padding(7)
        Me.TxtTitulo.Size = New System.Drawing.Size(378, 37)
        Me.TxtTitulo.TabIndex = 1
        Me.TxtTitulo.Texts = ""
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
        Me.BtnVolver.TabIndex = 15
        Me.BtnVolver.TextColor = System.Drawing.Color.White
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'EditorialBindingSource
        '
        Me.EditorialBindingSource.DataMember = "editorial"
        Me.EditorialBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'BdbibliotecaDataSet
        '
        Me.BdbibliotecaDataSet.DataSetName = "bdbibliotecaDataSet"
        Me.BdbibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneroBindingSource
        '
        Me.GeneroBindingSource.DataMember = "genero"
        Me.GeneroBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'TipoderecursoBindingSource
        '
        Me.TipoderecursoBindingSource.DataMember = "tipoderecurso"
        Me.TipoderecursoBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'AutorBindingSource
        '
        Me.AutorBindingSource.DataMember = "autor"
        Me.AutorBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'RecursosBindingSource
        '
        Me.RecursosBindingSource.DataMember = "recursos"
        Me.RecursosBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "estado"
        Me.EstadoBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'FormatoBindingSource
        '
        Me.FormatoBindingSource.DataMember = "formato"
        Me.FormatoBindingSource.DataSource = Me.BdbibliotecaDataSet
        '
        'TipoderecursoTableAdapter
        '
        Me.TipoderecursoTableAdapter.ClearBeforeFill = True
        '
        'AutorTableAdapter
        '
        Me.AutorTableAdapter.ClearBeforeFill = True
        '
        'EditorialTableAdapter
        '
        Me.EditorialTableAdapter.ClearBeforeFill = True
        '
        'GeneroTableAdapter
        '
        Me.GeneroTableAdapter.ClearBeforeFill = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'FormatoTableAdapter
        '
        Me.FormatoTableAdapter.ClearBeforeFill = True
        '
        'RecursosTableAdapter
        '
        Me.RecursosTableAdapter.ClearBeforeFill = True
        '
        'FrmCrearRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(910, 472)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(978, 472)
        Me.Controls.Add(Me.PnlPagFin)
        Me.Controls.Add(Me.PnlEstadoFin)
        Me.Controls.Add(Me.PnlEstado)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.PnlPaginas)
        Me.Controls.Add(Me.PnlEdiado)
        Me.Controls.Add(Me.PnlEdicion)
        Me.Controls.Add(Me.PnlEdias)
        Me.Controls.Add(Me.PnlGenecion)
        Me.Controls.Add(Me.PnlEditorial)
        Me.Controls.Add(Me.PnlFechal)
        Me.Controls.Add(Me.PnlForcion)
        Me.Controls.Add(Me.PnlAutero)
        Me.Controls.Add(Me.PnlFecha)
        Me.Controls.Add(Me.PnlGenero)
        Me.Controls.Add(Me.PnlFormato)
        Me.Controls.Add(Me.PnlTipoRecurso)
        Me.Controls.Add(Me.PnlISBN)
        Me.Controls.Add(Me.PnlAutor)
        Me.Controls.Add(Me.PnlTitulo)
        Me.Controls.Add(Me.PnlTipoto)
        Me.Controls.Add(Me.PnlISso)
        Me.Controls.Add(Me.PnlTitAutor)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCrearRegistros"
        Me.Text = "CrearRegistros"
        Me.PnlTituloHeader.ResumeLayout(False)
        Me.PnlTituloHeader.PerformLayout()
        CType(Me.PcbTituloHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlAutorHeader.ResumeLayout(False)
        Me.PnlAutorHeader.PerformLayout()
        CType(Me.PcbAutorHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlISBNHeader.ResumeLayout(False)
        Me.PnlISBNHeader.PerformLayout()
        CType(Me.PcbISBNHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTipoHeader.ResumeLayout(False)
        Me.PnlTipoHeader.PerformLayout()
        CType(Me.PcbTipoHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFormatoHeader.ResumeLayout(False)
        Me.PnlFormatoHeader.PerformLayout()
        CType(Me.PcbFormatoHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitulo.ResumeLayout(False)
        Me.PnlAutor.ResumeLayout(False)
        Me.PnlAutor.PerformLayout()
        Me.PnlISBN.ResumeLayout(False)
        Me.PnlTipoRecurso.ResumeLayout(False)
        Me.PnlFormato.ResumeLayout(False)
        Me.PnlGenero.ResumeLayout(False)
        Me.PnlGeneroHeader.ResumeLayout(False)
        Me.PnlGeneroHeader.PerformLayout()
        CType(Me.PcbGeneroHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFecha.ResumeLayout(False)
        Me.PnlFecha.PerformLayout()
        Me.PnlFechaHeader.ResumeLayout(False)
        Me.PnlFechaHeader.PerformLayout()
        CType(Me.PcbFechaHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEditorial.ResumeLayout(False)
        Me.PnlEditorialHeader.ResumeLayout(False)
        Me.PnlEditorialHeader.PerformLayout()
        CType(Me.PcbEditorialHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEdicion.ResumeLayout(False)
        Me.PnlEdicion.PerformLayout()
        Me.PnlEdicionHeader.ResumeLayout(False)
        Me.PnlEdicionHeader.PerformLayout()
        CType(Me.PcbEdicionHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPaginas.ResumeLayout(False)
        Me.PnlPagHeader.ResumeLayout(False)
        Me.PnlPagHeader.PerformLayout()
        CType(Me.PcbPagHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEstado.ResumeLayout(False)
        Me.PnlEstadoHeader.ResumeLayout(False)
        Me.PnlEstadoHeader.PerformLayout()
        CType(Me.PcbEstadoHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditorialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdbibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoderecursoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVolver As Biblioteca.ButtonRadio
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboTipoRecurso As Biblioteca.ComboPerso
    Friend WithEvents CboFormato As Biblioteca.ComboPerso
    Friend WithEvents PnlTituloHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTituloLibro As System.Windows.Forms.Label
    Friend WithEvents PcbTituloHeader As System.Windows.Forms.PictureBox
    Friend WithEvents PnlTitAutor As System.Windows.Forms.Panel
    Friend WithEvents PnlAutorHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbAutorHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents PnlISBNHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbISBNHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblISBN As System.Windows.Forms.Label
    Friend WithEvents PnlTipoHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbTipoHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblTipoRecurso As System.Windows.Forms.Label
    Friend WithEvents PnlISso As System.Windows.Forms.Panel
    Friend WithEvents PnlTipoto As System.Windows.Forms.Panel
    Friend WithEvents PnlFormatoHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbFormatoHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblFormato As System.Windows.Forms.Label
    Friend WithEvents PnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents TxtTitulo As Biblioteca.TxtPerso
    Friend WithEvents TxtNombre As Biblioteca.TxtPerso
    Friend WithEvents TxtApellido As Biblioteca.TxtPerso
    Friend WithEvents TxtISBN As Biblioteca.TxtPerso
    Friend WithEvents PnlAutor As System.Windows.Forms.Panel
    Friend WithEvents PnlISBN As System.Windows.Forms.Panel
    Friend WithEvents PnlTipoRecurso As System.Windows.Forms.Panel
    Friend WithEvents PnlFormato As System.Windows.Forms.Panel
    Friend WithEvents PnlGenero As System.Windows.Forms.Panel
    Friend WithEvents PnlGeneroHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbGeneroHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents CboGenero As Biblioteca.ComboPerso
    Friend WithEvents PnlFecha As System.Windows.Forms.Panel
    Friend WithEvents PnlFechaHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbFechaHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents PnlAutero As System.Windows.Forms.Panel
    Friend WithEvents PnlForcion As System.Windows.Forms.Panel
    Friend WithEvents PnlFechal As System.Windows.Forms.Panel
    Friend WithEvents PnlEditorial As System.Windows.Forms.Panel
    Friend WithEvents PnlEditorialHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbEditorialHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblEditorial As System.Windows.Forms.Label
    Friend WithEvents CboEditorial As Biblioteca.ComboPerso
    Friend WithEvents PnlGenecion As System.Windows.Forms.Panel
    Friend WithEvents PnlEdias As System.Windows.Forms.Panel
    Friend WithEvents PnlEdicion As System.Windows.Forms.Panel
    Friend WithEvents PnlEdicionHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbEdicionHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblEdicion As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtAno As Biblioteca.TxtPerso
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtNumero As Biblioteca.TxtPerso
    Friend WithEvents PnlEdiado As System.Windows.Forms.Panel
    Friend WithEvents PnlPaginas As System.Windows.Forms.Panel
    Friend WithEvents PnlPagHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbPagHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblPag As System.Windows.Forms.Label
    Friend WithEvents TxtPag As Biblioteca.TxtPerso
    Friend WithEvents BtnGuardar As Biblioteca.ButtonRadio
    Friend WithEvents PnlEstado As System.Windows.Forms.Panel
    Friend WithEvents PnlEstadoHeader As System.Windows.Forms.Panel
    Friend WithEvents PcbEstadoHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents CboEstado As Biblioteca.ComboPerso
    Friend WithEvents PnlEstadoFin As System.Windows.Forms.Panel
    Friend WithEvents PnlPagFin As System.Windows.Forms.Panel
    Friend WithEvents PnlTituloLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlAutorLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlISHeader As System.Windows.Forms.Panel
    Friend WithEvents PnlTipoLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlFormatoLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlGeneLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlFechaLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlEditLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlEdicLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlPagLinea As System.Windows.Forms.Panel
    Friend WithEvents PnlEstLinea As System.Windows.Forms.Panel
    Friend WithEvents AutorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoderecursoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EditorialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecursosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormatoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnFecha As Biblioteca.ButtonToggleOnOff
    Friend WithEvents TipoderecursoTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.tipoderecursoTableAdapter
    Friend WithEvents BdbibliotecaDataSet As Biblioteca.bdbibliotecaDataSet
    Friend WithEvents AutorTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.autorTableAdapter
    Friend WithEvents EditorialTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.editorialTableAdapter
    Friend WithEvents GeneroTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.generoTableAdapter
    Friend WithEvents EstadoTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.estadoTableAdapter
    Friend WithEvents DtpFecha As Biblioteca.MiDatePicker
    Friend WithEvents FormatoTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.formatoTableAdapter
    Friend WithEvents RecursosTableAdapter As Biblioteca.bdbibliotecaDataSetTableAdapters.recursosTableAdapter
End Class
