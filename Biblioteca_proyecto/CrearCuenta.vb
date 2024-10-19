Imports System.Runtime.InteropServices
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
End Class