Imports System.Runtime.InteropServices
Public Class FrmBase
    Private Sub FrmBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnVerPres.Cursor = CursorHand.GetCustomCursor
        BtnRegPres.Cursor = CursorHand.GetCustomCursor
        BtnRegistros.Cursor = CursorHand.GetCustomCursor

        Dim fechaHoy As Date = Date.Now.ToShortDateString
        Dim titulo As String = "Noticias            -               " & fechaHoy
        ColumnNoticias.HeaderText = titulo
    End Sub

    Private Sub BtnRegistros_Click(sender As Object, e As EventArgs) Handles BtnRegistros.Click
        Utilidades.AbrirFormEnPanel(Of FrmRegistros)()
    End Sub

    Private Sub BtnRegPres_Click(sender As Object, e As EventArgs) Handles BtnRegPres.Click
        Utilidades.AbrirFormEnPanel(Of FrmRegPres)()
    End Sub

    Private Sub BtnVerPres_Click(sender As Object, e As EventArgs) Handles BtnVerPres.Click
        Utilidades.AbrirFormEnPanel(Of FrmVerPres)()
    End Sub

    Private Sub FrmBase_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        ' Dimensiones base del formulario
        Dim baseFormWidth As Integer = 910
        Dim baseFormHeight As Integer = 472

        ' Tamaños base de los controles
        Dim baseBtnRegistrosWidth As Integer = 190
        Dim baseBtnRegistrosHeight As Integer = 254
        Dim baseBtnPresWidth As Integer = 190
        Dim baseBtnPresHeight As Integer = 254
        Dim baseBtnVerPresWidth As Integer = 400
        Dim baseBtnVerPresHeight As Integer = 120
        Dim baseGridNoticiasWidth As Integer = 412
        Dim baseGridNoticiasHeight As Integer = 387

        ' Ubicaciones base de los controles
        Dim baseBtnRegistrosX As Integer = 28
        Dim baseBtnRegistrosY As Integer = 43
        Dim baseBtnPresX As Integer = 238
        Dim baseBtnPresY As Integer = 43
        Dim baseBtnVerPresX As Integer = 28
        Dim baseBtnVerPresY As Integer = 310
        Dim baseGridNoticiasX As Integer = 470
        Dim baseGridNoticiasY As Integer = 43

        ' Factores de escala según el tamaño actual del formulario
        Dim scaleX As Double = Me.ClientSize.Width / baseFormWidth
        Dim scaleY As Double = Me.ClientSize.Height / baseFormHeight

        ' Ajustar tamaño y posición de BtnRegistros
        BtnRegistros.Width = CInt(baseBtnRegistrosWidth * scaleX)
        BtnRegistros.Height = CInt(baseBtnRegistrosHeight * scaleY)
        BtnRegistros.Location = New Point(CInt(baseBtnRegistrosX * scaleX), CInt(baseBtnRegistrosY * scaleY))

        ' Ajustar tamaño y posición de BtnRegPres
        BtnRegPres.Width = CInt(baseBtnPresWidth * scaleX)
        BtnRegPres.Height = CInt(baseBtnPresHeight * scaleY)
        BtnRegPres.Location = New Point(CInt(baseBtnPresX * scaleX), CInt(baseBtnPresY * scaleY))

        ' Ajustar tamaño y posición de BtnVerPres
        BtnVerPres.Width = CInt(baseBtnVerPresWidth * scaleX)
        BtnVerPres.Height = CInt(baseBtnVerPresHeight * scaleY)
        BtnVerPres.Location = New Point(CInt(baseBtnVerPresX * scaleX), CInt(baseBtnVerPresY * scaleY))

        ' Ajustar tamaño y posición de GridNoticias
        GridNoticias.Width = CInt(baseGridNoticiasWidth * scaleX)
        GridNoticias.Height = CInt(baseGridNoticiasHeight * scaleY)
        GridNoticias.Location = New Point(CInt(baseGridNoticiasX * scaleX), CInt(baseGridNoticiasY * scaleY))
    End Sub
End Class