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
        Dim result = CuadroDeMensaje.Show("¿Está seguro de que desea cerrar el programa?",
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
    End Sub

    Private Sub TxtUser_MouseHover(sender As Object, e As System.EventArgs) Handles TxtUser.MouseHover

    End Sub

    Private Sub TxtUser_MouseLeave(sender As Object, e As System.EventArgs) Handles TxtUser.MouseLeave

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
        Dim Validar As String = "^[a-zA-Z0-9._-]+$"
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
        If Not ContenidoValido(TxtCorreo.Text) Then
            MessageBox.Show("Por favor, ingrese un correo electrónico válido. Recuerde que solo se permiten letras, números, puntos, guiones y guiones bajos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtCorreo.Focus()
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

    Private Sub TxtConfPass_GotFocus(sender As Object, e As System.EventArgs) Handles TxtConfPass.GotFocus

    End Sub

    Private Sub TxtConfPass_LostFocus(sender As Object, e As System.EventArgs) Handles TxtConfPass.LostFocus

    End Sub
End Class