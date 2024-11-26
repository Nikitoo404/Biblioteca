Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class FrmLogin
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub LblOlvid_MouseDown(sender As Object, e As MouseEventArgs) Handles LblOlvid.MouseDown
        LblOlvid.ForeColor = Color.White
    End Sub

    Private Sub LblOlvid_MouseEnter(sender As Object, e As EventArgs) Handles LblOlvid.MouseEnter
        LblOlvid.ForeColor = Color.LightGray
    End Sub

    Private Sub LblOlvid_MouseLeave(sender As Object, e As EventArgs) Handles LblOlvid.MouseLeave
        LblOlvid.ForeColor = Color.DarkGray
    End Sub

    Private Sub LblOlvid_MouseUp(sender As Object, e As MouseEventArgs) Handles LblOlvid.MouseUp
        LblOlvid.ForeColor = Color.LightGray
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Dim result = CuadroDeMensaje.Show("¿Está seguro de que desea cerrar el programa?",
                                      "Atención - Cierre del programa",
        MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtUser_GotFocus(sender As Object, e As EventArgs) Handles TxtUser.GotFocus, PnlUser.Click
        If TxtUser.Text = "Usuario o correo electrónico" Then
            TxtUser.Clear()
            If TxtUser.Focused = False Then
                TxtUser.Focus()
            End If
        End If
    End Sub

    Private Sub TxtUser_LostFocus(sender As Object, e As EventArgs) Handles TxtUser.LostFocus
        If Len(Trim(TxtUser.Text)) = 0 Then
            TxtUser.Text = "Usuario o correo electrónico"
        End If
    End Sub

    Private Sub TxtPass_GotFocus(sender As Object, e As EventArgs) Handles TxtPass.GotFocus, PnlPass.Click
        If TxtPass.Text = "Contraseña" Then
            TxtPass.Text = ""
            If TxtPass.Focused = False Then
                TxtPass.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPass_LostFocus(sender As Object, e As EventArgs) Handles TxtPass.LostFocus
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

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        If TxtPass.Text <> "Contraseña" Then
            If TxtPass.Text.Trim() <> "" Then
                TxtPass.Focus()
            End If
        Else
            PcbCandados.Image = My.Resources.candado_c_azul
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

    Private Sub PnlBarra_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlBarra.MouseDown, LblBienvenida.MouseDown, PnlBarraBaja.MouseDown, LblDerechos.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        
        If Len(Trim(TxtUser.Text)) = 0 Or Len(Trim(TxtPass.Text)) = 0 Then
            Dim result = CuadroDeMensaje.Show("Complete los campos vacíos.",
                                          "Iniciar sesión - Error",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim usuario As Integer = UsuariosBindingSource.Find("NombreUsuario", TxtUser.Text)
        Dim correo As Integer = UsuariosBindingSource.Find("correo", TxtUser.Text)
        Dim id As Integer
        If usuario = 0 Then
            id = UsuariosTableAdapter.GetData(usuario).ID - 1
        ElseIf correo = 0 Then
            id = UsuariosTableAdapter.GetData(correo).ID - 1
        Else
            Dim result = CuadroDeMensaje.Show("El correo electrónico/usuario ingresado no existe o es incorrecto.",
                               "Iniciar sesión - Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim contraBase As String = UsuariosTableAdapter.GetData(id).Contraseña
        If TxtPass.Text = contraBase Then
            FrmInicio.Show()
        Else
            Dim result = CuadroDeMensaje.Show("Contraseña incorrecta.",
                                           "Iniciar sesión - Error",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblOlvid.Cursor = CursorHand.GetCustomCursor
        LblCrear.Cursor = CursorHand.GetCustomCursor
        FrmInicio.Close()
        FrmRecuperacion.Close()
        Me.UsuariosTableAdapter.Fill(Me.BdbibliotecaDataSet.usuarios)
        If BdbibliotecaDataSet.usuarios.Rows.Count + 0 Then
            LblCrear.Enabled = False
            LblOlvid.Enabled = True
        Else
            LblCrear.Enabled = True
            LblOlvid.Enabled = False
        End If
    End Sub

    Private Sub BtnLogin_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles BtnLogin.MouseDown
        BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(30, 67, 90)
        BtnLogin.BackColor = Color.FromArgb(70, 118, 126)
    End Sub

    Private Sub BtnLogin_MouseEnter(sender As Object, e As System.EventArgs) Handles BtnLogin.MouseEnter
        BtnLogin.FlatAppearance.BorderColor = Color.LightGray
        BtnLogin.BackColor = Color.FromArgb(20, 57, 80)
        BtnLogin.ForeColor = Color.LightGray
    End Sub

    Private Sub BtnLogin_MouseLeave(sender As Object, e As System.EventArgs) Handles BtnLogin.MouseLeave
        BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(30, 67, 90)
        BtnLogin.BackColor = Color.FromArgb(20, 57, 80)
        BtnLogin.ForeColor = Color.Silver
    End Sub

    Private Sub BtnLogin_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles BtnLogin.MouseUp
        BtnLogin.FlatAppearance.BorderColor = Color.LightGray
        BtnLogin.BackColor = Color.FromArgb(20, 57, 80)
    End Sub

    Private Sub LblOlvid_Click(sender As System.Object, e As System.EventArgs) Handles LblOlvid.Click
        FrmRecuperacion.Show()
    End Sub

    Private Sub LblCrear_Click(sender As System.Object, e As System.EventArgs) Handles LblCrear.Click
        FrmCrearCuenta.Show()
    End Sub

    Private Sub LblCrear_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LblCrear.MouseDown
        LblCrear.ForeColor = Color.White
    End Sub

    Private Sub LblCrear_MouseEnter(sender As Object, e As System.EventArgs) Handles LblCrear.MouseEnter
        LblCrear.ForeColor = Color.LightGray
    End Sub

    Private Sub LblCrear_MouseLeave(sender As Object, e As System.EventArgs) Handles LblCrear.MouseLeave
        LblCrear.ForeColor = Color.DarkGray
    End Sub

    Private Sub LblCrear_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LblCrear.MouseUp
        LblCrear.ForeColor = Color.LightGray
    End Sub
End Class