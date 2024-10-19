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
                ChkPass.Checked = False
            End If
            TxtPass.Text = "Contraseña"
        End If
    End Sub

    Private Sub ChkPass_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPass.CheckedChanged
        If ChkPass.Checked = False Then
            If TxtPass.Text = "Contraseña" Then
                Exit Sub
            Else
                TxtPass.UseSystemPasswordChar = True
            End If
        Else
            If ChkPass.Checked = True Then
                TxtPass.UseSystemPasswordChar = False
            End If
        End If
    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        If Len(Trim(TxtPass.Text)) > 0 Then
            If TxtPass.Text = "Contraseña" Then
                PcbCandados.Image = My.Resources.candado_c_azul
            Else
                If ChkPass.Checked = True Then
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
        FrmInicio.Show()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblOlvid.Cursor = CursorHand.GetCustomCursor
        LblCrear.Cursor = CursorHand.GetCustomCursor
        FrmInicio.Close()
        FrmRecuperacion.Close()
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