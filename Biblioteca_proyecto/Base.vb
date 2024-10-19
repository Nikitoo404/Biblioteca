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
End Class