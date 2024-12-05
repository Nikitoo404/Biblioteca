Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class FrmCrearRegistros
    Private posicionesOriginales As New Dictionary(Of Control, Point)
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
        DtpFecha.MaxDate = Date.Now
        ' Guardar las posiciones originales de los paneles al cargar el formulario
        Dim paneles As Control() = {PnlTitulo, PnlTitAutor, PnlAutor, PnlAutero, PnlGenero, PnlGenecion,
                                     PnlEdicion, PnlEdiado, PnlEstado, PnlISBN, PnlISso, PnlTipoRecurso,
                                     PnlTipoto, PnlFormato, PnlForcion, PnlFecha, PnlFechal, PnlEditorial,
                                     PnlEdias, PnlPaginas, PnlEstadoFin, PnlPagFin}

        For Each panel As Control In paneles
            posicionesOriginales(panel) = panel.Location
        Next
    End Sub

    Private Sub PnlTituloHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlTituloHeader.Click, lblTituloLibro.Click, PcbTituloHeader.Click, PnlTituloLinea.Click
        ModuloAcordeon.StartPanelAccordion(PnlTitulo, Me, 22, 78, PcbTituloHeader)
    End Sub

    Private Sub FrmCrearRegistros_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim desplazamientoX As Integer = 100

        If FrmInicio.WindowState = FormWindowState.Maximized Then
            ' Reubicar los paneles a la posición desplazada
            For Each panel As Control In posicionesOriginales.Keys
                Dim posicionOriginal = posicionesOriginales(panel)
                panel.Location = New Point(posicionOriginal.X + desplazamientoX, posicionOriginal.Y)
            Next
        Else
            ' Restaurar las posiciones originales si no está maximizado
            For Each panel As Control In posicionesOriginales.Keys
                panel.Location = posicionesOriginales(panel)
            Next
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

    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click
        ' Lista de nombres de paneles que deseas recorrer
        Dim panelesObjetivo As String() = {"PnlTitulo", "PnlAutor", "PnlGenero", "PnlEdicion", "PnlEstado", "PnlISBN", "PnlTipoRecurso", "PnlFormato", "PnlFecha", "PnlEditorial", "PnlPaginas"}

        If Len(Trim(TxtTitulo.Texts)) = 0 Then
            MostrarMensajeYResaltar(TxtTitulo)
        Else
            TxtTitulo.BackColor = Color.FromArgb(25, 62, 85)
            If Len(Trim(TxtNombre.Texts)) = 0 Then
                MostrarMensajeYResaltar(TxtNombre)
            Else
                TxtNombre.BackColor = Color.FromArgb(25, 62, 85)
                If Len(Trim(TxtApellido.Texts)) = 0 Then
                    MostrarMensajeYResaltar(TxtApellido)
                Else
                    TxtApellido.BackColor = Color.FromArgb(25, 62, 85)
                    If Len(Trim(CboGenero.Texts)) = 0 Then
                        Dim result = CuadroDeMensaje.Show("Complete todos los espacios",
                                         "Casilleros vacíos.",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information)
                        CboGenero._BorderColor = Color.FromArgb(95, 151, 186)
                        CboGenero.Focus()
                        Exit Sub
                    Else
                        CboGenero._BorderColor = Color.PeachPuff
                        If Len(Trim(TxtNumero.Texts)) = 0 Then
                            MostrarMensajeYResaltar(TxtNumero)
                        Else
                            TxtNumero.BackColor = Color.FromArgb(25, 62, 85)
                            If Len(Trim(TxtAno.Texts)) = 0 Then
                                MostrarMensajeYResaltar(TxtAno)
                            Else
                                TxtAno.BackColor = Color.FromArgb(25, 62, 85)
                                If Len(Trim(CboEstado.Texts)) = 0 Then
                                    Dim result = CuadroDeMensaje.Show("Complete todos los espacios",
                                         "Casilleros vacíos.",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information)
                                    CboEstado._BorderColor = Color.FromArgb(95, 151, 186)
                                    CboEstado.Focus()
                                    Exit Sub
                                Else
                                    CboEstado._BorderColor = Color.PeachPuff
                                    If Len(Trim(TxtISBN.Texts)) = 0 Then
                                        MostrarMensajeYResaltar(TxtISBN)
                                    Else
                                        TxtISBN.BackColor = Color.FromArgb(25, 62, 85)
                                        If Len(Trim(CboTipoRecurso.Texts)) = 0 Then
                                            Dim result = CuadroDeMensaje.Show("Complete todos los espacios",
                                         "Casilleros vacíos.",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information)
                                            CboTipoRecurso._BorderColor = Color.FromArgb(95, 151, 186)
                                            CboTipoRecurso.Focus()
                                            Exit Sub
                                        Else
                                            CboTipoRecurso._BorderColor = Color.PeachPuff
                                            If Len(Trim(CboFormato.Texts)) = 0 Then
                                                Dim result = CuadroDeMensaje.Show("Complete todos los espacios",
                                         "Casilleros vacíos.",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information)
                                                CboFormato._BorderColor = Color.FromArgb(95, 151, 186)
                                                CboFormato.Focus()
                                                Exit Sub
                                            Else
                                                CboFormato._BorderColor = Color.PeachPuff
                                                If Len(Trim(CboEditorial.Texts)) = 0 Then
                                                    Dim result = CuadroDeMensaje.Show("Complete todos los espacios",
                                         "Casilleros vacíos.",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information)
                                                    CboEditorial._BorderColor = Color.FromArgb(95, 151, 186)
                                                    CboEditorial.Focus()
                                                    Exit Sub
                                                Else
                                                    CboEditorial._BorderColor = Color.PeachPuff
                                                    If Len(Trim(TxtPerso8.Texts)) = 0 Then
                                                        MostrarMensajeYResaltar(TxtPerso8)
                                                    Else
                                                        TxtPerso8.BackColor = Color.FromArgb(25, 62, 85)
                                                        MsgBox("completo")

                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    ' Función para mostrar mensaje y resaltar el control vacío
    Sub MostrarMensajeYResaltar(ctrl As Control)
        Dim result = CuadroDeMensaje.Show("Complete todos los espacios",
                                          "Casilleros vacíos.",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information)
        ctrl.BackColor = Color.FromArgb(95, 151, 186)
        ctrl.Focus()
    End Sub

End Class