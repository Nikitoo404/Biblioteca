Imports System.Runtime.InteropServices
Public Class FrmBase
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function LoadCursor(ByVal hInstance As IntPtr, ByVal lpCursorName As Integer) As IntPtr
    End Function
    Public Const OCR_HAND As Integer = 32649
    Dim ptrHand As IntPtr
    Dim hCursor As Cursor
    Private Sub FrmBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptrHand = LoadCursor(IntPtr.Zero, OCR_HAND)
        hCursor = New Cursor(ptrHand)
        BtnVerPres.Cursor = hCursor
        BtnRegPres.Cursor = hCursor
        BtnRegistros.Cursor = hCursor

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