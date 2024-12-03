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

    Private Sub FrmCrearRegistros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.tipoderecurso' Puede moverla o quitarla según sea necesario.
        Me.TipoderecursoTableAdapter.Fill(Me.BdbibliotecaDataSet.tipoderecurso)
        'TODO: esta línea de código carga datos en la tabla 'BdbibliotecaDataSet.autor' Puede moverla o quitarla según sea necesario.
        Me.AutorTableAdapter.Fill(Me.BdbibliotecaDataSet.autor)
    End Sub

    Private Sub PnlTituloHeader_Click(sender As System.Object, e As System.EventArgs) Handles PnlTituloHeader.Click, lblTituloLibro.Click, PcbTituloHeader.Click
        If PnlTitulo.Size.Height = 22 Then
            PnlTitulo.Size = New Size(PnlTitulo.Width, 77)
            PcbTituloHeader.Image = My.Resources.flechaArriba
        Else
            PnlTitulo.Size = New Size(PnlTitulo.Width, 22)
            PcbTituloHeader.Image = My.Resources.flechaAbajo
        End If
    End Sub
End Class