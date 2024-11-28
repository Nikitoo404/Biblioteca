Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class FrmCrearRegistros
    Private Sub BtnVolver_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnVolver.MouseDown
        BtnVolver.BackColor = Color.PeachPuff
        BtnVolver.Image = My.Resources.blueOsc
        BtnVolver.BorderColor = Color.FromArgb(20, 57, 80)
    End Sub

    Private Sub BtnVolver_MouseEnter(sender As Object, e As EventArgs) Handles BtnVolver.MouseEnter
        BtnVolver.BackColor = Color.PeachPuff
        BtnVolver.Image = My.Resources.blueOsc
        BtnVolver.BorderColor = Color.FromArgb(20, 57, 80)
    End Sub

    Private Sub BtnVolver_MouseLeave(sender As Object, e As EventArgs) Handles BtnVolver.MouseLeave
        BtnVolver.BackColor = Color.FromArgb(20, 57, 80)
        BtnVolver.Image = My.Resources.blueCla
        BtnVolver.BorderColor = Color.PeachPuff
    End Sub

    Private Sub BtnVolver_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnVolver.MouseUp
        BtnVolver.BackColor = Color.FromArgb(20, 57, 80)
        BtnVolver.Image = My.Resources.blueCla
        BtnVolver.BorderColor = Color.PeachPuff
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Utilidades.AbrirFormEnPanel(Of FrmRegistros)()
    End Sub

    Private Sub PnlTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PnlTitulo.Paint, PnlAutor.Paint
        ' Llamar a la función para dibujar el borde punteado
        DrawDottedBorder(sender, e)

    End Sub

    Private Sub DrawDottedBorder(panel As Object, e As PaintEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim pen As New Pen(Color.PeachPuff)
        pen.DashStyle = DashStyle.Solid ' Establecer el estilo del trazo a punteado
        pen.Width = 3 ' Ajustar el ancho del trazo según tus preferencias

        ' Dibujar el borde punteado
        graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1)
    End Sub
End Class