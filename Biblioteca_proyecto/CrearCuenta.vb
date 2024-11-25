Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Public Class FrmCrearCuenta
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub BtnMin_Click(sender As System.Object, e As System.EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Dim result = CuadroDeMensaje.Show("¿Está seguro de que desea cerrar el programa? Perderá los datos no guardados.",
                                     "Atención - Cierre del programa",
       MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub PnlBarra_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PnlBarra.MouseDown, LblBienvenida.MouseDown, LblDerechos.MouseDown, PnlBarraBaja.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FrmCrearCuenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FrmLogin.Close()
        CboTipoCorreo.SelectedIndex = -1
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BdbibliotecaDataSet.usuarios)
    End Sub

    Private Sub TxtUser_Leave(sender As Object, e As System.EventArgs) Handles TxtUser.Leave
        If TxtUser.Text <> "Usuario" Then
            If TxtUser.Text.Trim() <> "" Then
                PcbVerUser.Visible = True
                If Not ContenidoValido(TxtUser.Text) Then
                    Dim result = CuadroDeMensaje.Show("Por favor, ingrese un nombre de usuairo válido. Recuerde que solo se permiten letras, números, puntos, guiones y guiones bajos. Además, debe tener como mínimo 3 caracteres, y no se permiten espacios.",
                                               "Ingresar nombre de usuario - Error",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error)
                    TxtUser.Focus()
                    PcbVerUser.Image = My.Resources.IncorrectoRojo
                Else
                    PcbVerUser.Image = My.Resources.Correcto
                End If
            End If
        Else
            PcbVerUser.Visible = False
        End If
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As System.EventArgs) Handles TxtUser.TextChanged
        If TxtUser.Text <> "Usuario" Then
            If TxtUser.Text.Trim() <> "" Then
                PcbVerUser.Visible = True
                If Not ContenidoValido(TxtUser.Text) Then
                    PcbVerUser.Image = My.Resources.IncorrectoRojo
                Else
                    PcbVerUser.Image = My.Resources.Correcto
                End If
            End If
        Else
            PcbVerUser.Visible = False
        End If
    End Sub

    Private Sub TxtUser_GotFocus(sender As Object, e As System.EventArgs) Handles TxtUser.GotFocus
        If TxtUser.Text = "Usuario" Then
            TxtUser.Clear()
            If TxtUser.Focused = False Then
                TxtUser.Focus()
            End If
        End If
    End Sub

    Private Sub TxtUser_LostFocus(sender As Object, e As System.EventArgs) Handles TxtUser.LostFocus
        If Len(Trim(TxtUser.Text)) = 0 Then
            TxtUser.Text = "Usuario"
        End If
    End Sub

    ' Función para verificar el formato del correo
    Private Function ContenidoValido(valor As String) As Boolean
        Dim Validar As String = "^[a-zA-Z0-9._-]{3,}$"
        Return Regex.IsMatch(valor, Validar)
    End Function

    Private Function ContraValida(valor As String) As Boolean
        Dim Validar As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$"
        Return Regex.IsMatch(valor, Validar)
    End Function

    Private Sub TxtCorreo_GotFocus(sender As Object, e As System.EventArgs) Handles TxtCorreo.GotFocus
        If TxtCorreo.Text = "Correo electrónico" Then
            TxtCorreo.Clear()
            If TxtCorreo.Focused = False Then
                TxtCorreo.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCorreo_Leave(sender As Object, e As System.EventArgs) Handles TxtCorreo.Leave
        If TxtCorreo.Text <> "Correo electrónico" Then
            If TxtCorreo.Text.Trim() <> "" Then
                If Not ContenidoValido(TxtCorreo.Text) Then
                    Dim result = CuadroDeMensaje.Show("Por favor, ingrese un correo electrónico válido. Recuerde que solo se permiten letras, números, puntos, guiones y guiones bajos. Además, debe tener como mínimo 3 caracteres, y no se permiten espacios.",
                                               "Ingresar correo - Error",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error)
                    TxtCorreo.Focus()
                Else
                    If CboTipoCorreo.SelectedIndex >= 0 Then
                        PcbVerCorreo.Image = My.Resources.Correcto
                        PcbVerCorreo.Visible = True
                    Else
                        PcbVerCorreo.Image = My.Resources.IncorrectoRojo
                        PcbVerCorreo.Visible = True
                    End If
                End If
            End If
        Else
            If CboTipoCorreo.SelectedIndex >= 0 Then
                PcbVerCorreo.Image = My.Resources.IncorrectoRojo
                PcbVerCorreo.Visible = True
            Else
                PcbVerCorreo.Visible = False
            End If
        End If
    End Sub

    Private Sub TxtCorreo_TextChanged(sender As Object, e As System.EventArgs) Handles TxtCorreo.TextChanged
        If TxtCorreo.Text <> "Correo electrónico" Then
            If TxtCorreo.Text.Trim() <> "" Then
                PcbVerCorreo.Visible = True
                If Not ContenidoValido(TxtCorreo.Text) Then
                    PcbVerCorreo.Image = My.Resources.IncorrectoRojo
                Else
                    If CboTipoCorreo.SelectedIndex >= 0 Then
                        PcbVerCorreo.Image = My.Resources.Correcto
                    Else
                        PcbVerCorreo.Image = My.Resources.IncorrectoRojo
                    End If
                End If
            End If
        Else
            If CboTipoCorreo.SelectedIndex >= 0 Then
                PcbVerCorreo.Image = My.Resources.IncorrectoRojo
                PcbVerCorreo.Visible = True
            Else
                PcbVerCorreo.Visible = False
            End If
        End If
    End Sub

    Private Sub TxtCorreo_LostFocus(sender As Object, e As System.EventArgs) Handles TxtCorreo.LostFocus
        If Len(Trim(TxtCorreo.Text)) = 0 Then
            TxtCorreo.Text = "Correo electrónico"
        End If
    End Sub

    Private Sub TxtPass_GotFocus(sender As Object, e As System.EventArgs) Handles TxtPass.GotFocus
        If TxtPass.Text = "Contraseña" Then
            TxtPass.Text = ""
            If TxtPass.Focused = False Then
                TxtPass.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPass_LostFocus(sender As Object, e As System.EventArgs) Handles TxtPass.LostFocus
        If Len(Trim(TxtPass.Text)) = 0 Then
            If TxtPass.UseSystemPasswordChar = True Then
                TxtPass.UseSystemPasswordChar = False
                PcbPass.Image = My.Resources.ojoBlueTachado
            End If
            TxtPass.Text = "Contraseña"
        End If
    End Sub

    Private Sub PcbPass_Click(sender As System.Object, e As System.EventArgs) Handles PcbPass.Click
        If PcbPass.Tag = "OjoTachado" Then
            If TxtPass.Text = "Contraseña" Then
                PcbPass.Image = My.Resources.ojoBlue
                PcbPass.Tag = "Ojo"
                Exit Sub
            Else
                TxtPass.UseSystemPasswordChar = False
                PcbPass.Image = My.Resources.ojoBlue
                PcbPass.Tag = "Ojo"
            End If
        Else
            If PcbPass.Tag = "Ojo" Then
                If TxtPass.Text = "Contraseña" Then
                    PcbPass.Image = My.Resources.ojoBlueTachado
                    PcbPass.Tag = "OjoTachado"
                    Exit Sub
                Else
                    TxtPass.UseSystemPasswordChar = True
                    PcbPass.Image = My.Resources.ojoBlueTachado
                    PcbPass.Tag = "OjoTachado"
                End If
            End If
        End If
    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As System.EventArgs) Handles TxtPass.TextChanged
        If TxtPass.Text <> "Contraseña" Then
            If TxtPass.Text.Trim() <> "" Then
                TxtPass.Focus()
                PcbVerPass.Visible = True
                If Not ContraValida(TxtPass.Text) Then
                    PcbVerPass.Image = My.Resources.IncorrectoRojo
                Else
                    PcbVerPass.Image = My.Resources.Correcto
                End If
            End If
        Else
            PcbCandados.Image = My.Resources.candado_c_azul
            PcbVerPass.Visible = False
        End If

        If Len(Trim(TxtPass.Text)) > 0 Then
            If TxtPass.Text = "Contraseña" Then
                PcbCandados.Image = My.Resources.candado_c_azul
            Else
                If PcbPass.Tag = "Ojo" Then
                    TxtPass.UseSystemPasswordChar = False
                    PcbCandados.Image = My.Resources.candado_a_azul
                    Exit Sub
                End If
                PcbCandados.Image = My.Resources.candado_a_azul
                TxtPass.UseSystemPasswordChar = True
            End If
        Else
            PcbCandados.Image = My.Resources.candado_c_azul
        End If

    End Sub

    Private Sub TxtPass_Leave(sender As Object, e As System.EventArgs) Handles TxtPass.Leave
        If TxtPass.Text <> "Contraseña" Then
            If TxtPass.Text.Trim() <> "" Then
                PcbVerPass.Visible = True
                If Not ContraValida(TxtPass.Text) Then
                    PcbVerPass.Image = My.Resources.IncorrectoRojo
                Else
                    PcbVerPass.Image = My.Resources.Correcto
                End If
            Else
                PcbVerPass.Visible = False
            End If
        End If
    End Sub

    Private Sub TxtConfPass_GotFocus(sender As Object, e As System.EventArgs) Handles TxtConfPass.GotFocus
        If TxtConfPass.Text = "Confirmar contraseña" Then
            TxtConfPass.Text = ""
            If TxtConfPass.Focused = False Then
                TxtConfPass.Focus()
            End If
        End If
    End Sub

    Private Sub TxtConfPass_LostFocus(sender As Object, e As System.EventArgs) Handles TxtConfPass.LostFocus
        If Len(Trim(TxtConfPass.Text)) = 0 Then
            If TxtConfPass.UseSystemPasswordChar = True Then
                TxtConfPass.UseSystemPasswordChar = False
                PcbConfPass.Image = My.Resources.ojoBlueTachado
            End If
            TxtConfPass.Text = "Confirmar contraseña"
        End If
    End Sub

    Private Sub PcbConfPass_Click(sender As System.Object, e As System.EventArgs) Handles PcbConfPass.Click
        If PcbConfPass.Tag = "ConfOjoTachado" Then
            If TxtConfPass.Text = "Confirmar contraseña" Then
                PcbConfPass.Image = My.Resources.ojoBlue
                PcbConfPass.Tag = "ConfOjo"
                Exit Sub
            Else
                TxtConfPass.UseSystemPasswordChar = False
                PcbConfPass.Image = My.Resources.ojoBlue
                PcbConfPass.Tag = "ConfOjo"
            End If
        Else
            If PcbConfPass.Tag = "ConfOjo" Then
                If TxtConfPass.Text = "Confirmar contraseña" Then
                    PcbConfPass.Image = My.Resources.ojoBlueTachado
                    PcbConfPass.Tag = "ConfOjoTachado"
                    Exit Sub
                Else
                    TxtConfPass.UseSystemPasswordChar = True
                    PcbConfPass.Image = My.Resources.ojoBlueTachado
                    PcbConfPass.Tag = "ConfOjoTachado"
                End If
            End If
        End If
    End Sub

    Private Sub TxtConfPass_TextChanged(sender As Object, e As System.EventArgs) Handles TxtConfPass.TextChanged
        If Len(Trim(TxtConfPass.Text)) > 0 Then
            If TxtConfPass.Text = "Confirmar contraseña" Then
                PcbCandadosConf.Image = My.Resources.candado_c_azul
                PcbVerConfPass.Visible = False
            Else
                PcbVerConfPass.Visible = True
                If Not ContraValida(TxtConfPass.Text) Then
                    PcbVerConfPass.Image = My.Resources.IncorrectoRojo
                Else
                    If TxtPass.Text = TxtConfPass.Text Then
                        PcbVerConfPass.Image = My.Resources.Correcto
                        BtnCrearCuenta.Enabled = True
                    Else
                        PcbVerConfPass.Image = My.Resources.IncorrectoRojo
                        BtnCrearCuenta.Enabled = False
                    End If
                End If

                If PcbConfPass.Tag = "ConfOjo" Then
                    TxtConfPass.UseSystemPasswordChar = False
                    PcbCandadosConf.Image = My.Resources.candado_a_azul
                    Exit Sub
                End If
                PcbCandadosConf.Image = My.Resources.candado_a_azul
                TxtConfPass.UseSystemPasswordChar = True
            End If
        Else
            PcbCandadosConf.Image = My.Resources.candado_c_azul
        End If
    End Sub

    Private Sub TxtConfPass_Leave(sender As Object, e As System.EventArgs) Handles TxtConfPass.Leave
        If TxtConfPass.Text <> "Confirmar contraseña" Then
            If TxtConfPass.Text.Trim() <> "" Then
                PcbVerConfPass.Visible = True
                If Not ContraValida(TxtConfPass.Text) Then
                    PcbVerConfPass.Image = My.Resources.IncorrectoRojo
                Else
                    If TxtPass.Text = TxtConfPass.Text Then
                        PcbVerConfPass.Image = My.Resources.Correcto
                    Else
                        Dim result = CuadroDeMensaje.Show("Las contraseñas no coinciden.",
                                               "Confirmar contraseña - Error",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error)
                        PcbVerConfPass.Image = My.Resources.IncorrectoRojo
                    End If
                End If
            Else
                PcbVerConfPass.Visible = False
            End If
        End If
    End Sub

    Private Sub CboTipoCorreo_OnSelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CboTipoCorreo.OnSelectedIndexChanged
        ' Llamar al evento Leave manualmente para asegurar que se verifique el texto
        TxtCorreo_Leave(TxtCorreo, EventArgs.Empty)

        ' Verifica si el correo es válido o no
        If Len(TxtCorreo.Text) > 0 Then
            If TxtCorreo.Text <> "Correo electrónico" Then
                If ContenidoValido(TxtCorreo.Text) Then
                    PcbVerCorreo.Image = My.Resources.Correcto
                Else
                    PcbVerCorreo.Image = My.Resources.IncorrectoRojo
                End If
                PcbVerCorreo.Visible = True
            Else
                PcbVerCorreo.Image = My.Resources.IncorrectoRojo
                PcbVerCorreo.Visible = True
            End If
        Else
            PcbVerCorreo.Image = My.Resources.IncorrectoRojo
            PcbVerCorreo.Visible = True
        End If
    End Sub

    Private Sub BtnVolver_Click(sender As System.Object, e As System.EventArgs) Handles BtnVolver.Click
        FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnCrearCuenta_Click(sender As System.Object, e As System.EventArgs) Handles BtnCrearCuenta.Click
        Dim correo As String = TxtCorreo.Text & CboTipoCorreo.Texts
        Dim usuario As String = TxtUser.Text
        Dim contrasena As String = TxtPass.Text
        UsuariosTableAdapter.Insert(TxtUser.Text, correo, TxtPass.Text, "", DateTime.Now)
        Me.UsuariosTableAdapter.Fill(Me.BdbibliotecaDataSet.usuarios)
        FrmLogin.Show()
    End Sub

    Private Sub BtnCrearCuenta_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles BtnCrearCuenta.MouseDown
        BtnCrearCuenta.FlatAppearance.BorderColor = Color.FromArgb(30, 67, 90)
        BtnCrearCuenta.BackColor = Color.FromArgb(70, 118, 126)
    End Sub

    Private Sub BtnCrearCuenta_MouseEnter(sender As Object, e As System.EventArgs) Handles BtnCrearCuenta.MouseEnter
        BtnCrearCuenta.FlatAppearance.BorderColor = Color.LightGray
        BtnCrearCuenta.BackColor = Color.FromArgb(20, 57, 80)
        BtnCrearCuenta.ForeColor = Color.LightGray
    End Sub

    Private Sub BtnCrearCuenta_MouseLeave(sender As Object, e As System.EventArgs) Handles BtnCrearCuenta.MouseLeave
        BtnCrearCuenta.FlatAppearance.BorderColor = Color.FromArgb(30, 67, 90)
        BtnCrearCuenta.BackColor = Color.FromArgb(20, 57, 80)
        BtnCrearCuenta.ForeColor = Color.Silver
    End Sub

    Private Sub BtnCrearCuenta_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles BtnCrearCuenta.MouseUp
        BtnCrearCuenta.FlatAppearance.BorderColor = Color.LightGray
        BtnCrearCuenta.BackColor = Color.FromArgb(20, 57, 80)
    End Sub
End Class