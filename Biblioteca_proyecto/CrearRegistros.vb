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
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.autor' Puede moverla o quitarla según sea necesario.
        Me.RecursosTableAdapter.Fill(Me.BdbibliotecaDataSet.recursos)
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.autor' Puede moverla o quitarla según sea necesario.
        Me.FormatoTableAdapter.Fill(Me.BdbibliotecaDataSet.formato)
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.autor' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.BdbibliotecaDataSet.estado)

        DtpFecha.MaxDate = Date.Now
        ' Guardar las posiciones originales de los paneles al cargar el formulario
        Dim paneles As Control() = {PnlTitulo, PnlTitAutor, PnlAutor, PnlAutero, PnlGenero, PnlGenecion,
                                     PnlEdicion, PnlEdiado, PnlEstado, PnlISBN, PnlISso, PnlTipoRecurso,
                                     PnlTipoto, PnlFormato, PnlForcion, PnlFecha, PnlFechal, PnlEditorial,
                                     PnlEdias, PnlPaginas, PnlEstadoFin, PnlPagFin}

        For Each panel As Control In paneles
            posicionesOriginales(panel) = panel.Location
        Next
        BtnFecha.Checked = True
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
        ModuloAcordeon.StartPanelAccordion(PnlFecha, Me, 22, 110, PcbFechaHeader)
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
            TxtTitulo.BackColor = Color.FromArgb(95, 151, 186)
            MostrarMensajeYResaltar(TxtTitulo)
        Else
            TxtTitulo.BackColor = Color.FromArgb(25, 62, 85)
            If Len(Trim(TxtNombre.Texts)) = 0 Then
                TxtNombre.BackColor = Color.FromArgb(95, 151, 186)
                MostrarMensajeYResaltar(TxtNombre)
            Else
                TxtNombre.BackColor = Color.FromArgb(25, 62, 85)
                If Len(Trim(TxtApellido.Texts)) = 0 Then
                    TxtApellido.BackColor = Color.FromArgb(95, 151, 186)
                    MostrarMensajeYResaltar(TxtApellido)
                Else
                    TxtApellido.BackColor = Color.FromArgb(25, 62, 85)
                    If Len(Trim(CboEstado.Texts)) = 0 Then
                        CboEstado._BorderColor = Color.FromArgb(95, 151, 186)
                        MostrarMensajeYResaltar(CboEstado)
                    Else
                        CboEstado._BorderColor = Color.PeachPuff
                        If Len(Trim(CboTipoRecurso.Texts)) = 0 Then
                            CboTipoRecurso._BorderColor = Color.FromArgb(95, 151, 186)
                            MostrarMensajeYResaltar(CboTipoRecurso)
                        Else
                            CboTipoRecurso._BorderColor = Color.PeachPuff
                            If Len(Trim(CboFormato.Texts)) = 0 Then
                                CboFormato._BorderColor = Color.FromArgb(95, 151, 186)
                                MostrarMensajeYResaltar(CboFormato)
                            Else
                                If Len(Trim(TxtISBN.Texts)) > 0 Then
                                    RecursosBindingSource.Filter = "ISBN = '" & TxtISBN.Texts & "'"
                                    If RecursosBindingSource.Count > 0 Then
                                        Dim result = CuadroDeMensaje.Show("El número ISBN ingresado ya existe y no puede ser duplicado.",
                        "Crear registros.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                                        CboFormato._BorderColor = Color.FromArgb(95, 151, 186)
                                        Exit Sub
                                    End If
                                Else

                                    'hacer comprobaciones de tipos de datos para edicion año, número y número de páginas

                                    CboFormato._BorderColor = Color.PeachPuff
                                    MsgBox("completo")
                                    'empezar con comprobaciones de inconsistencia de base de datos antes de la alta
                                    Dim AutorID As Integer
                                    AutorBindingSource.Filter = "Nombres = '" & TxtNombre.Texts & "' AND Apellidos = '" & TxtApellido.Texts & "'"
                                    If AutorBindingSource.Count > 0 Then
                                        'si es 0, significa que ya existe un autor con el mismo nombre y apellido y, por lo tanto
                                        'no se creará otro, a pesar de que sea otra persona con el mismo nombre y apellido. Luego,
                                        'para la evolución del sistema, se le agregarán datos precisos diferenciales (FechaNAC, LugarNAC, etc.)

                                        ' Obtener el primer registro que coincide con el filtro
                                        Dim selectedRow As DataRowView = DirectCast(AutorBindingSource.Current, DataRowView)
                                        ' Obtener el valor de la columna "ID" del registro seleccionado
                                        AutorID = CInt(selectedRow("ID"))
                                    Else
                                        'sino, hacer un alta en la tabla de autor y guardar su ID
                                        AutorTableAdapter.Insert(TxtNombre.Texts, TxtApellido.Texts)
                                        Me.AutorTableAdapter.Fill(Me.BdbibliotecaDataSet.autor)
                                        ' Obtener el ID del último registro insertado
                                        AutorID = BdbibliotecaDataSet.autor.Rows(BdbibliotecaDataSet.autor.Rows.Count - 1)("ID")
                                    End If
                                    AutorBindingSource.RemoveFilter()

                                    Dim GeneroID As Integer
                                    GeneroBindingSource.Filter = "Nombre = '" & CboGenero.Texts & "'"
                                    If GeneroBindingSource.Count > 0 Then
                                        ' Obtener el primer registro que coincide con el filtro
                                        Dim selectedRow As DataRowView = DirectCast(GeneroBindingSource.Current, DataRowView)
                                        ' Obtener el valor de la columna "ID" del registro seleccionado
                                        GeneroID = CInt(selectedRow("ID"))
                                    Else
                                        GeneroTableAdapter.Insert(CboGenero.Texts)
                                        Me.GeneroTableAdapter.Fill(Me.BdbibliotecaDataSet.genero)
                                        ' Obtener el ID del último registro insertado
                                        GeneroID = BdbibliotecaDataSet.genero.Rows(BdbibliotecaDataSet.genero.Rows.Count - 1)("ID")
                                    End If
                                    GeneroBindingSource.RemoveFilter()

                                    Dim EstadoID As Integer
                                    EstadoBindingSource.Filter = "Tipo = '" & CboEstado.SelectedItem & "'"
                                    If EstadoBindingSource.Count > 0 Then
                                        ' Obtener el primer registro que coincide con el filtro
                                        Dim selectedRow As DataRowView = DirectCast(EstadoBindingSource.Current, DataRowView)
                                        ' Obtener el valor de la columna "ID" del registro seleccionado
                                        EstadoID = CInt(selectedRow("ID"))
                                    Else
                                        EstadoTableAdapter.Insert(CboEstado.SelectedItem)
                                        Me.EstadoTableAdapter.Fill(Me.BdbibliotecaDataSet.estado)
                                        ' Obtener el ID del último registro insertado
                                        EstadoID = BdbibliotecaDataSet.estado.Rows(BdbibliotecaDataSet.estado.Rows.Count - 1)("ID")
                                    End If
                                    EstadoBindingSource.RemoveFilter()

                                    Dim TipoID As Integer
                                    TipoderecursoBindingSource.Filter = "Nombre = '" & CboTipoRecurso.Texts & "'"
                                    If TipoderecursoBindingSource.Count > 0 Then
                                        ' Obtener el primer registro que coincide con el filtro
                                        Dim selectedRow As DataRowView = DirectCast(TipoderecursoBindingSource.Current, DataRowView)
                                        ' Obtener el valor de la columna "ID" del registro seleccionado
                                        TipoID = CInt(selectedRow("ID"))
                                    Else
                                        TipoderecursoTableAdapter.Insert(CboTipoRecurso.Texts)
                                        Me.TipoderecursoTableAdapter.Fill(Me.BdbibliotecaDataSet.tipoderecurso)
                                        ' Obtener el ID del último registro insertado
                                        TipoID = BdbibliotecaDataSet.tipoderecurso.Rows(BdbibliotecaDataSet.tipoderecurso.Rows.Count - 1)("ID")
                                    End If
                                    TipoderecursoBindingSource.RemoveFilter()

                                    Dim FormatoID As Integer
                                    FormatoBindingSource.Filter = "Nombre = '" & CboFormato.Texts & "'"
                                    If FormatoBindingSource.Count > 0 Then
                                        ' Obtener el primer registro que coincide con el filtro
                                        Dim selectedRow As DataRowView = DirectCast(FormatoBindingSource.Current, DataRowView)
                                        ' Obtener el valor de la columna "ID" del registro seleccionado
                                        FormatoID = CInt(selectedRow("ID"))
                                    Else
                                        FormatoTableAdapter.Insert(CboFormato.Texts)
                                        Me.FormatoTableAdapter.Fill(Me.BdbibliotecaDataSet.formato)
                                        ' Obtener el ID del último registro insertado
                                        FormatoID = BdbibliotecaDataSet.tipoderecurso.Rows(BdbibliotecaDataSet.tipoderecurso.Rows.Count - 1)("ID")
                                    End If
                                    FormatoBindingSource.RemoveFilter()
                                    Dim EditorialID As Integer
                                    EditorialBindingSource.Filter = "Nombre = '" & CboEditorial.Texts & "'"
                                    If EditorialBindingSource.Count > 0 Then
                                        ' Obtener el primer registro que coincide con el filtro
                                        Dim selectedRow As DataRowView = DirectCast(EditorialBindingSource.Current, DataRowView)
                                        ' Obtener el valor de la columna "ID" del registro seleccionado
                                        EditorialID = CInt(selectedRow("ID"))
                                    Else
                                        EditorialTableAdapter.Insert(CboFormato.Texts)
                                        Me.EditorialTableAdapter.Fill(Me.BdbibliotecaDataSet.editorial)
                                        ' Obtener el ID del último registro insertado
                                        EditorialID = BdbibliotecaDataSet.editorial.Rows(BdbibliotecaDataSet.editorial.Rows.Count - 1)("ID")
                                    End If
                                    EditorialBindingSource.RemoveFilter()

                                    If BtnFecha.Checked = True Then
                                        Dim fecha As Date = DateTime.ParseExact(DtpFecha.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
                                        Dim fechaConvertida As String = fecha.ToString("yyyy/MM/dd")
                                        'insert con fecha
                                        RecursosTableAdapter.Insert(TxtTitulo.Texts, AutorID, TxtISBN.Texts, TipoID, FormatoID, GeneroID, fechaConvertida, EditorialID, TxtNumero.Texts, TxtAno.Texts, TxtPag.Texts, EstadoID)
                                        Me.RecursosTableAdapter.Fill(Me.BdbibliotecaDataSet.recursos)
                                    Else
                                        'insert sin fecha
                                        RecursosTableAdapter.Insert(TxtTitulo.Texts, AutorID, TxtISBN.Texts, TipoID, FormatoID, GeneroID, Nothing, EditorialID, TxtNumero.Texts, TxtAno.Texts, TxtPag.Texts, EstadoID)
                                        Me.RecursosTableAdapter.Fill(Me.BdbibliotecaDataSet.recursos)
                                    End If
                                    Dim result = CuadroDeMensaje.Show("Registro guardado",
                                          "Crear registros.",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information)
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
        ctrl.Focus()
    End Sub

    Private Sub BtnFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BtnFecha.CheckedChanged
        If BtnFecha.Checked = True Then
            BtnFecha.ForeColor = Color.White
            DtpFecha.Enabled = True
        Else
            BtnFecha.ForeColor = Color.Black
            DtpFecha.Enabled = False
        End If
    End Sub
End Class