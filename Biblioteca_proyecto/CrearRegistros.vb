Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class FrmCrearRegistros
    Private Sub BtnVolver_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnVolver.MouseDown
        BtnVolver.BackColor = Color.PeachPuff
        BtnVolver.Image = My.Resources.blueOsc
        BtnVolver.BorderColor = Color.FromArgb(20, 57, 80)
    End Sub

    Private Sub BtnVolver_MouseEnter(sender As Object, e As EventArgs) Handles BtnVolver.MouseEnter
        BtnVolver.BackColor = Color.PeachPuff
        BtnVolver.Image = My.Resources.blueOsc
        BtnVolver.BorderColor = Color.FromArgb(20, 57, 80)
    End Sub

    Private Sub BtnVolver_MouseLeave(sender As Object, e As EventArgs) Handles BtnVolver.MouseLeave
        BtnVolver.BackColor = Color.FromArgb(20, 57, 80)
        BtnVolver.Image = My.Resources.blueCla
        BtnVolver.BorderColor = Color.PeachPuff
    End Sub

    Private Sub BtnVolver_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnVolver.MouseUp
        BtnVolver.BackColor = Color.FromArgb(20, 57, 80)
        BtnVolver.Image = My.Resources.blueCla
        BtnVolver.BorderColor = Color.PeachPuff
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Utilidades.AbrirFormEnPanel(Of FrmRegistros)()
    End Sub

    Private Sub FrmCrearRegistros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.editorial' Puede moverla o quitarla según sea necesario.
        Me.EditorialTableAdapter.Fill(Me.BdbibliotecaDataSet.editorial)
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.genero' Puede moverla o quitarla según sea necesario.
        Me.GeneroTableAdapter.Fill(Me.BdbibliotecaDataSet.genero)
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.tipoderecurso' Puede moverla o quitarla según sea necesario.
        Me.TipoderecursoTableAdapter.Fill(Me.BdbibliotecaDataSet.tipoderecurso)
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.autor' Puede moverla o quitarla según sea necesario.
        Me.AutorTableAdapter.Fill(Me.BdbibliotecaDataSet.autor)
    End Sub

    Private Sub PnlTituloHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlTituloHeader.Click, lblTituloLibro.Click, PcbTituloHeader.Click, PnlTituloLinea.Click
        ModuloAcordeon.StartPanelAccordion(PnlTitulo, Me, 22, 78, PcbTituloHeader)
    End Sub

    Private Sub FrmCrearRegistros_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If FrmInicio.WindowState = FormWindowState.Maximized Then
            PnlTitulo.Location = New Point(PnlTitulo.Location.X + 100, PnlTitulo.Location.Y)
            PnlTitAutor.Location = New Point(PnlTitAutor.Location.X + 100, PnlTitAutor.Location.Y)
            PnlAutor.Location = New Point(PnlAutor.Location.X + 100, PnlAutor.Location.Y)
            PnlAutero.Location = New Point(PnlAutero.Location.X + 100, PnlAutero.Location.Y)
            PnlGenero.Location = New Point(PnlGenero.Location.X + 100, PnlGenero.Location.Y)
            PnlGenecion.Location = New Point(PnlGenecion.Location.X + 100, PnlGenecion.Location.Y)
            PnlEdicion.Location = New Point(PnlEdicion.Location.X + 100, PnlEdicion.Location.Y)
            PnlEdiado.Location = New Point(PnlEdiado.Location.X + 100, PnlEdiado.Location.Y)
            PnlEstado.Location = New Point(PnlEstado.Location.X + 100, PnlEstado.Location.Y)
            PnlISBN.Location = New Point(PnlISBN.Location.X + 100, PnlISBN.Location.Y)
            PnlISso.Location = New Point(PnlISso.Location.X + 100, PnlISso.Location.Y)
            PnlTipoRecurso.Location = New Point(PnlTipoRecurso.Location.X + 100, PnlTipoRecurso.Location.Y)
            PnlTipoto.Location = New Point(PnlTipoto.Location.X + 100, PnlTipoto.Location.Y)
            PnlFormato.Location = New Point(PnlFormato.Location.X + 100, PnlFormato.Location.Y)
            PnlForcion.Location = New Point(PnlForcion.Location.X + 100, PnlForcion.Location.Y)
            PnlFecha.Location = New Point(PnlFecha.Location.X + 100, PnlFecha.Location.Y)
            PnlFechal.Location = New Point(PnlFechal.Location.X + 100, PnlFechal.Location.Y)
            PnlEditorial.Location = New Point(PnlEditorial.Location.X + 100, PnlEditorial.Location.Y)
            PnlEdias.Location = New Point(PnlEdias.Location.X + 100, PnlEdias.Location.Y)
            PnlPaginas.Location = New Point(PnlPaginas.Location.X + 100, PnlPaginas.Location.Y)
            PnlEstadoFin.Location = New Point(PnlEstadoFin.Location.X + 100, PnlEstadoFin.Location.Y)
            PnlPagFin.Location = New Point(PnlPagFin.Location.X + 100, PnlPagFin.Location.Y)
        ElseIf PnlTitulo.Location.X <> 40 Then
            PnlTitulo.Location = New Point(PnlTitulo.Location.X - 100, PnlTitulo.Location.Y)
            PnlTitAutor.Location = New Point(PnlTitAutor.Location.X - 100, PnlTitAutor.Location.Y)
            PnlAutor.Location = New Point(PnlAutor.Location.X - 100, PnlAutor.Location.Y)
            PnlAutero.Location = New Point(PnlAutero.Location.X - 100, PnlAutero.Location.Y)
            PnlGenero.Location = New Point(PnlGenero.Location.X - 100, PnlGenero.Location.Y)
            PnlGenecion.Location = New Point(PnlGenecion.Location.X - 100, PnlGenecion.Location.Y)
            PnlEdicion.Location = New Point(PnlEdicion.Location.X - 100, PnlEdicion.Location.Y)
            PnlEdiado.Location = New Point(PnlEdiado.Location.X - 100, PnlEdiado.Location.Y)
            PnlEstado.Location = New Point(PnlEstado.Location.X - 100, PnlEstado.Location.Y)
            PnlISBN.Location = New Point(PnlISBN.Location.X - 100, PnlISBN.Location.Y)
            PnlISso.Location = New Point(PnlISso.Location.X - 100, PnlISso.Location.Y)
            PnlTipoRecurso.Location = New Point(PnlTipoRecurso.Location.X - 100, PnlTipoRecurso.Location.Y)
            PnlTipoto.Location = New Point(PnlTipoto.Location.X - 100, PnlTipoto.Location.Y)
            PnlFormato.Location = New Point(PnlFormato.Location.X - 100, PnlFormato.Location.Y)
            PnlForcion.Location = New Point(PnlForcion.Location.X - 100, PnlForcion.Location.Y)
            PnlFecha.Location = New Point(PnlFecha.Location.X - 100, PnlFecha.Location.Y)
            PnlFechal.Location = New Point(PnlFechal.Location.X - 100, PnlFechal.Location.Y)
            PnlEditorial.Location = New Point(PnlEditorial.Location.X - 100, PnlEditorial.Location.Y)
            PnlEdias.Location = New Point(PnlEdias.Location.X - 100, PnlEdias.Location.Y)
            PnlPaginas.Location = New Point(PnlPaginas.Location.X - 100, PnlPaginas.Location.Y)
            PnlEstadoFin.Location = New Point(PnlEstadoFin.Location.X - 100, PnlEstadoFin.Location.Y)
            PnlPagFin.Location = New Point(PnlPagFin.Location.X - 100, PnlPagFin.Location.Y)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PnlAutorHeader_Click(sender As Object, e As System.EventArgs) Handles PnlAutorHeader.Click, lblAutor.Click, PcbAutorHeader.Click, PnlAutorLinea.Click
        ModuloAcordeon.StartPanelAccordion(PnlAutor, Me, 22, 96, PcbAutorHeader)
    End Sub

    Private Sub PnlGeneroHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlGeneroHeader.Click, PnlGeneLinea.Click, lblGenero.Click, PcbGeneroHeader.Click
        ModuloAcordeon.StartPanelAccordion(PnlGenero, Me, 22, 78, PcbGeneroHeader)
    End Sub

    Private Sub PnlEdicionHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlEdicionHeader.Click, lblEdicion.Click, PnlEdicLinea.Click, PcbEdicionHeader.Click
        ModuloAcordeon.StartPanelAccordion(PnlEdicion, Me, 22, 96, PcbEdicionHeader)
    End Sub

    Private Sub PnlEstadoHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlEstadoHeader.Click, lblEstado.Click, PnlEstLinea.Click, PcbEstadoHeader.Click
        ModuloAcordeon.StartPanelAccordion(PnlEstado, Me, 22, 78, PcbEstadoHeader)
    End Sub

    Private Sub PnlISBNHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlISBNHeader.Click, PnlISHeader.Click, PcbISBNHeader.Click, lblISBN.Click
        ModuloAcordeon.StartPanelAccordion(PnlISBN, Me, 22, 78, PcbISBNHeader)
    End Sub

    Private Sub PnlTipoHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlTipoHeader.Click, PnlTipoLinea.Click, PcbTipoHeader.Click, lblTipoRecurso.Click
        ModuloAcordeon.StartPanelAccordion(PnlTipoRecurso, Me, 22, 78, PcbTipoHeader)
    End Sub

    Private Sub PnlFormatoHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlFormatoHeader.Click, PnlFormatoLinea.Click, PcbFormatoHeader.Click, lblFormato.Click
        ModuloAcordeon.StartPanelAccordion(PnlFormato, Me, 22, 78, PcbFormatoHeader)
    End Sub

    Private Sub PnlFechaHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlFechaHeader.Click, PnlFechaLinea.Click, PcbFechaHeader.Click, lblFecha.Click
        ModuloAcordeon.StartPanelAccordion(PnlFecha, Me, 22, 78, PcbFechaHeader)
    End Sub

    Private Sub PnlEditorialHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlEditorialHeader.Click, PnlEditLinea.Click, PcbEditorialHeader.Click, lblEditorial.Click
        ModuloAcordeon.StartPanelAccordion(PnlEditorial, Me, 22, 78, PcbEditorialHeader)
    End Sub

    Private Sub PnlPagHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlPagHeader.Click, PnlPagLinea.Click, PcbPagHeader.Click, lblPag.Click
        ModuloAcordeon.StartPanelAccordion(PnlPaginas, Me, 22, 78, PcbPagHeader)
    End Sub

    Private Sub BtnGuardar_MouseEnter(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.MouseEnter
        BtnGuardar.BorderColor = Color.LightGray
        BtnGuardar.BackColor = Color.FromArgb(20, 57, 80)
        BtnGuardar.ForeColor = Color.LightGray
    End Sub

    Private Sub BtnGuardar_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles BtnGuardar.MouseDown
        BtnGuardar.BorderColor = Color.FromArgb(30, 67, 90)
        BtnGuardar.BackColor = Color.FromArgb(70, 118, 126)
    End Sub

    Private Sub BtnGuardar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.MouseLeave
        BtnGuardar.BorderColor = Color.FromArgb(30, 67, 90)
        BtnGuardar.BackColor = Color.FromArgb(20, 57, 80)
        BtnGuardar.ForeColor = Color.Silver
    End Sub

    Private Sub BtnGuardar_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles BtnGuardar.MouseUp
        BtnGuardar.BorderColor = Color.LightGray
        BtnGuardar.BackColor = Color.FromArgb(20, 57, 80)
    End Sub
End Class