Imports System.Runtime.InteropServices
Public Class FrmInicio
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub AbrirFormEnPanel(Of FormHijo As {Form, New})()
        If Me.PnlContenedor.Controls.Count > 0 Then
            Me.PnlContenedor.Controls.RemoveAt(0)
        End If
        Dim Formulario As Form = PnlContenedor.Controls.OfType(Of FormHijo)().FirstOrDefault
        If Formulario Is Nothing Then
            Formulario = New FormHijo()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PnlContenedor.Controls.Add(Formulario)
            PnlContenedor.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub PnlBarra_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlBarra.MouseDown, LblTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
        If e.Button = MouseButtons.Left Then
            If e.Clicks = 2 Then
                If Me.WindowState = FormWindowState.Normal Then
                    Me.WindowState = FormWindowState.Maximized
                Else
                    Me.WindowState = FormWindowState.Normal
                End If
            End If
        End If
    End Sub
    Private Sub BtnMinimizar_Click(sender As System.Object, e As System.EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnRestaurar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        BtnRestaurar.Visible = False
        BtnMaximizar.Visible = True
    End Sub
    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Dim result = CuadroDeMensaje.Show("¿Está seguro de que desea cerrar el programa?",
                                      "Atención - Cierre del programa",
        MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub BtnMaximizar_Click(sender As System.Object, e As System.EventArgs) Handles BtnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize
        FrmLogin.Close()
        LblCerrarSesion.Cursor = CursorHand.GetCustomCursor
        AbrirFormEnPanel(Of FrmBase)()
    End Sub

    Private Sub LblCerrarSesion_MouseDown(sender As Object, e As MouseEventArgs) Handles LblCerrarSesion.MouseDown
        LblCerrarSesion.ForeColor = Color.Black
    End Sub

    Private Sub LblCerrarSesion_MouseEnter(sender As Object, e As EventArgs) Handles LblCerrarSesion.MouseEnter
        LblCerrarSesion.ForeColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub LblCerrarSesion_MouseLeave(sender As Object, e As EventArgs) Handles LblCerrarSesion.MouseLeave
        LblCerrarSesion.ForeColor = Color.Gray
    End Sub

    Private Sub LblCerrarSesion_MouseUp(sender As Object, e As MouseEventArgs) Handles LblCerrarSesion.MouseUp
        LblCerrarSesion.ForeColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub LblCerrarSesion_Click(sender As Object, e As EventArgs) Handles LblCerrarSesion.Click
        FrmLogin.Show()
    End Sub
End Class
