Imports System.Runtime.InteropServices
Public Class FrmRecuperacion
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PnlBarra_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PnlBarra.MouseDown, PnlBarraBaja.MouseDown, LblBienvenida.MouseDown, LblDerechos.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FrmRecuperacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FrmLogin.Close()
    End Sub

    Private Sub BtnRecuperar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRecuperar.Click
        FrmLogin.Show()
    End Sub

    Private Sub BtnRecuperar_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles BtnRecuperar.MouseDown
        BtnRecuperar.FlatAppearance.BorderColor = Color.FromArgb(30, 67, 90)
        BtnRecuperar.BackColor = Color.FromArgb(70, 118, 126)
    End Sub

    Private Sub BtnRecuperar_MouseEnter(sender As Object, e As System.EventArgs) Handles BtnRecuperar.MouseEnter
        BtnRecuperar.FlatAppearance.BorderColor = Color.LightGray
        BtnRecuperar.BackColor = Color.FromArgb(20, 57, 80)
        BtnRecuperar.ForeColor = Color.LightGray
    End Sub

    Private Sub BtnRecuperar_MouseLeave(sender As Object, e As System.EventArgs) Handles BtnRecuperar.MouseLeave
        BtnRecuperar.FlatAppearance.BorderColor = Color.FromArgb(30, 67, 90)
        BtnRecuperar.BackColor = Color.FromArgb(20, 57, 80)
        BtnRecuperar.ForeColor = Color.Silver
    End Sub

    Private Sub BtnRecuperar_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles BtnRecuperar.MouseUp
        BtnRecuperar.FlatAppearance.BorderColor = Color.LightGray
        BtnRecuperar.BackColor = Color.FromArgb(20, 57, 80)
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
End Class