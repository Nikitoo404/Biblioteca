Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class FrmLogin
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function LoadCursorFromFile(lpFileName As String) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function GetSystemCursor(hCursor As IntPtr, id As Integer) As Boolean
    End Function

    Public Const OCR_HAND As Integer = 32649

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
        Dim hCursor As IntPtr = LoadCursorFromFile("C:\Windows\Cursors\aero_link.cur")
        If hCursor = IntPtr.Zero Then
            hCursor = LoadCursorFromFile(CStr(OCR_HAND))
        End If
        Dim handCursor As New Cursor(hCursor)
        LblOlvid.Cursor = handCursor
        FrmInicio.Close()
    End Sub
End Class