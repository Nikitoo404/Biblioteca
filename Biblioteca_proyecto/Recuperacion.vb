Imports System.Runtime.InteropServices
Imports System.Net.Mail
Imports System.Text.RegularExpressions
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

    Private Function ValidarDominioCorreo(correo As String) As Boolean
        ' Lista de dominios permitidos
        Dim dominiosPermitidos As String() = {"@gmail.com", "@outlook.com", "@hotmail.com", "@live.com", "@yahoo.com"}

        ' Verificar si el correo termina en uno de los dominios permitidos
        For Each dominio In dominiosPermitidos
            If correo.EndsWith(dominio, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next

        ' Si no coincide con ninguno, retorna False
        Return False
    End Function

    Private Function EnviarCorreo(correoDestino As String, codigo As String) As Boolean
        Try
            Dim correo As New MailMessage()
            correo.From = New MailAddress("nikitoo242@gmail.com") ' Correo del remitente (hacer un correo modelo)
            correo.To.Add(correoDestino)
            correo.Subject = "Código de Recuperación de Contraseña"
            correo.Body = "Tu código de recuperación es: " & codigo
            correo.IsBodyHtml = False

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential("nikitoo242@gmail.com", "s n v v s x y s x g j o s b f t") ' Credenciales
            smtp.EnableSsl = True

            smtp.Send(correo)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub BtnRecuperar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRecuperar.Click
        Dim correoDestino As String = "impresonico@gmail.com" 'Obtener correo del usuario en base de datos

        ' Verificar si el correo tiene un dominio válido
        If ValidarDominioCorreo(correoDestino) Then
            Dim codigoRecuperacion As String = "1234"  'solicitar contraseña en base de datos

            If EnviarCorreo(correoDestino, codigoRecuperacion) Then
                MessageBox.Show("Correo de recuperación enviado exitosamente.")
                Dim result = CuadroDeMensaje.Show("Correo de recuperación enviado exitosamente.",
                                               "Recuperar contraseña",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al enviar el correo.")
                Dim result = CuadroDeMensaje.Show("Error al enviar el correo. Inténtelo más tarde. Si el error vuelve a ocurrir, consulte con el desarrollador del programa.",
                                               "Recuperar contraseña",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error)
            End If
        End If
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

    Private Sub BtnVolver_Click(sender As System.Object, e As System.EventArgs) Handles BtnVolver.Click
        FrmLogin.Show()
        Me.Close()
    End Sub
End Class