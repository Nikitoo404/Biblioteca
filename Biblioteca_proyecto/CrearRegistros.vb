Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class FrmCrearRegistros
    Private valor As Integer = 77
    Private isExpanded As Boolean = True
    Private valor2 As Integer = 96
    Private isExpanded2 As Boolean = True
    Private valor3 As Integer = 77
    Private isExpanded3 As Boolean = True
    Private valor4 As Integer = 96
    Private isExpanded4 As Boolean = True
    Private valor5 As Integer = 77
    Private isExpanded5 As Boolean = True
    Private valor6 As Integer = 77
    Private isExpanded6 As Boolean = True
    Private valor7 As Integer = 77
    Private isExpanded7 As Boolean = True
    Private valor8 As Integer = 77
    Private isExpanded8 As Boolean = True
    Private valor9 As Integer = 77
    Private isExpanded9 As Boolean = True
    Private valor10 As Integer = 77
    Private isExpanded10 As Boolean = True
    Private valor11 As Integer = 77
    Private isExpanded11 As Boolean = True
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
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.tipoderecurso' Puede moverla o quitarla según sea necesario.
        Me.TipoderecursoTableAdapter.Fill(Me.BdbibliotecaDataSet.tipoderecurso)
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.autor' Puede moverla o quitarla según sea necesario.
        Me.AutorTableAdapter.Fill(Me.BdbibliotecaDataSet.autor)
    End Sub

    Private Sub PnlTituloHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlTituloHeader.Click, lblTituloLibro.Click, PcbTituloHeader.Click, PnlTituloLinea.Click
        TmrTitulo.Start()
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

    Private Sub TmrTitulo_Tick(sender As System.Object, e As System.EventArgs) Handles TmrTitulo.Tick
        If isExpanded = True Then
            If valor > 22 Then
                MoverControlesAlineados(PnlTitulo, Me, -11)
                PnlTitulo.Size = New Size(PnlTitulo.Width, PnlTitulo.Height - 11)
                valor -= 11
            Else
                PnlTitulo.Size = New Size(PnlTitulo.Width, valor)
                PcbTituloHeader.Image = My.Resources.flechaAbajo
                isExpanded = False
                TmrTitulo.Stop()
            End If
        Else
            If valor < 77 Then
                MoverControlesAlineados(PnlTitulo, Me, 11)
                PnlTitulo.Size = New Size(PnlTitulo.Width, PnlTitulo.Height + 11)
                valor += 11
            Else
                PnlTitulo.Size = New Size(PnlTitulo.Width, valor)
                PcbTituloHeader.Image = My.Resources.flechaArriba
                isExpanded = True
                TmrTitulo.Stop()
            End If
        End If
    End Sub

    Private Sub PnlAutorHeader_Click(sender As Object, e As System.EventArgs) Handles PnlAutorHeader.Click, lblAutor.Click, PcbAutorHeader.Click, PnlAutorLinea.Click
        TmrAutor.Start()
    End Sub

    Private Sub TmrAutor_Tick(sender As System.Object, e As System.EventArgs) Handles TmrAutor.Tick
        If isExpanded2 = True Then
            If valor2 > 22 Then
                MoverControlesAlineados(PnlAutor, Me, -11)
                PnlAutor.Size = New Size(PnlAutor.Width, PnlAutor.Height - 11)
                valor2 -= 11
            Else
                PnlAutor.Size = New Size(PnlAutor.Width, valor2)
                PcbAutorHeader.Image = My.Resources.flechaAbajo
                isExpanded2 = False
                TmrAutor.Stop()
            End If
        Else
            If valor2 < 96 Then
                MoverControlesAlineados(PnlAutor, Me, 11)
                PnlAutor.Size = New Size(PnlAutor.Width, PnlAutor.Height + 11)
                valor2 += 11
            Else
                PnlAutor.Size = New Size(PnlAutor.Width, valor2)
                PcbAutorHeader.Image = My.Resources.flechaArriba
                isExpanded2 = True
                TmrAutor.Stop()
            End If
        End If
    End Sub

    Private Sub PnlGeneroHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlGeneroHeader.Click, PnlGeneLinea.Click, PnlGenero.Click, PcbGeneroHeader.Click
        TmrGenero.Start()
    End Sub

    Private Sub TmrGenero_Tick(sender As System.Object, e As System.EventArgs) Handles TmrGenero.Tick
        If isExpanded3 = True Then
            If valor3 > 22 Then
                MoverControlesAlineados(PnlGenero, Me, -11)
                PnlGenero.Size = New Size(PnlGenero.Width, PnlGenero.Height - 11)
                valor3 -= 11
            Else
                PnlGenero.Size = New Size(PnlGenero.Width, valor3)
                PcbGeneroHeader.Image = My.Resources.flechaAbajo
                isExpanded3 = False
                TmrGenero.Stop()
            End If
        Else
            If valor3 < 77 Then
                MoverControlesAlineados(PnlGenero, Me, 11)
                PnlGenero.Size = New Size(PnlGenero.Width, PnlGenero.Height + 11)
                valor3 += 11
            Else
                PnlGenero.Size = New Size(PnlGenero.Width, valor3)
                PcbGeneroHeader.Image = My.Resources.flechaArriba
                isExpanded3 = True
                TmrGenero.Stop()
            End If
        End If
    End Sub

    Private Sub PnlEdicionHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlEdicionHeader.Click, PnlEdicion.Click, PnlEdicLinea.Click, PcbEdicionHeader.Click
        TmrEdicion.Start()
    End Sub

    Private Sub TmrEdicion_Tick(sender As System.Object, e As System.EventArgs) Handles TmrEdicion.Tick
        If isExpanded4 = True Then
            If valor4 > 22 Then
                MoverControlesAlineados(PnlEdicion, Me, -11)
                PnlEdicion.Size = New Size(PnlEdicion.Width, PnlEdicion.Height - 11)
                valor4 -= 11
            Else
                PnlEdicion.Size = New Size(PnlEdicion.Width, valor4)
                PcbEdicionHeader.Image = My.Resources.flechaAbajo
                isExpanded4 = False
                TmrEdicion.Stop()
            End If
        Else
            If valor4 < 96 Then
                MoverControlesAlineados(PnlEdicion, Me, 11)
                PnlEdicion.Size = New Size(PnlEdicion.Width, PnlEdicion.Height + 11)
                valor4 += 11
            Else
                PnlEdicion.Size = New Size(PnlEdicion.Width, valor4)
                PcbEdicionHeader.Image = My.Resources.flechaArriba
                isExpanded4 = True
                TmrEdicion.Stop()
            End If
        End If
    End Sub

    Private Sub PnlEstadoHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlEstadoHeader.Click, PnlEstado.Click, PnlEstLinea.Click, PcbEstadoHeader.Click
        TmrEstado.Start()
    End Sub

    Private Sub TmrEstado_Tick(sender As System.Object, e As System.EventArgs) Handles TmrEstado.Tick
        If isExpanded5 = True Then
            If valor5 > 22 Then
                MoverControlesAlineados(PnlEstado, Me, -11)
                PnlEstado.Size = New Size(PnlEstado.Width, PnlEstado.Height - 11)
                valor5 -= 11
            Else
                PnlEstado.Size = New Size(PnlEstado.Width, valor5)
                PcbEstadoHeader.Image = My.Resources.flechaAbajo
                isExpanded5 = False
                TmrEstado.Stop()
            End If
        Else
            If valor5 < 77 Then
                MoverControlesAlineados(PnlEstado, Me, 11)
                PnlEstado.Size = New Size(PnlEstado.Width, PnlEstado.Height + 11)
                valor5 += 11
            Else
                PnlEstado.Size = New Size(PnlEstado.Width, valor5)
                PcbEstadoHeader.Image = My.Resources.flechaArriba
                isExpanded5 = True
                TmrEstado.Stop()
            End If
        End If
    End Sub

    Private Sub PnlISBNHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlISBNHeader.Click

    End Sub

    Private Sub TmrISBN_Tick(sender As System.Object, e As System.EventArgs) Handles TmrISBN.Tick

    End Sub

    Private Sub PnlTipoHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlTipoHeader.Click

    End Sub

    Private Sub TmrTipo_Tick(sender As System.Object, e As System.EventArgs) Handles TmrTipo.Tick

    End Sub

    Private Sub PnlFormatoHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlFormatoHeader.Click

    End Sub

    Private Sub TmrFormato_Tick(sender As System.Object, e As System.EventArgs) Handles TmrFormato.Tick

    End Sub

    Private Sub PnlFechaHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlFechaHeader.Click

    End Sub

    Private Sub TmrFecha_Tick(sender As System.Object, e As System.EventArgs) Handles TmrFecha.Tick

    End Sub

    Private Sub PnlEditorialHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlEditorialHeader.Click

    End Sub

    Private Sub TmrEditorial_Tick(sender As System.Object, e As System.EventArgs) Handles TmrEditorial.Tick

    End Sub

    Private Sub PnlPagHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlPagHeader.Click

    End Sub

    Private Sub TmrPag_Tick(sender As System.Object, e As System.EventArgs) Handles TmrPag.Tick

    End Sub
End Class