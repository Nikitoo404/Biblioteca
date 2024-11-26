Public Class FrmRegistros
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
        Utilidades.AbrirFormEnPanel(Of FrmBase)()
    End Sub

    Private Sub FrmRegistros_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        ' Dimensiones base de los botones
        Dim baseWidth As Integer = 186
        Dim baseHeight As Integer = 164
        Dim baseBtnCrearX As Integer = 116
        Dim baseBtnVerX As Integer = 350
        Dim baseBtnEditarX As Integer = 587
        Dim baseY As Integer = 157
        Dim baseFormWidth As Integer = 910 ' Ancho base del formulario 
        Dim baseFormHeight As Integer = 472 ' Altura base del formulario 

        ' Factores de escala
        Dim scaleX As Double = Me.ClientSize.Width / baseFormWidth
        Dim scaleY As Double = Me.ClientSize.Height / baseFormHeight

        ' Calcula nuevas dimensiones de los botones
        Dim newBtnWidth As Integer = CInt(baseWidth * scaleX)
        Dim newBtnHeight As Integer = CInt(baseHeight * scaleY)

        ' Calcula nuevas posiciones para los botones
        BtnCrear.Width = newBtnWidth
        BtnCrear.Height = newBtnHeight
        BtnCrear.Location = New Point(CInt(baseBtnCrearX * scaleX), CInt(baseY * scaleY))

        BtnVer.Width = newBtnWidth
        BtnVer.Height = newBtnHeight
        BtnVer.Location = New Point(CInt(baseBtnVerX * scaleX), CInt(baseY * scaleY))

        BtnEditar.Width = newBtnWidth
        BtnEditar.Height = newBtnHeight
        BtnEditar.Location = New Point(CInt(baseBtnEditarX * scaleX), CInt(baseY * scaleY))
    End Sub

    Private Sub BtnCrear_Click(sender As System.Object, e As System.EventArgs) Handles BtnCrear.Click
        Utilidades.AbrirFormEnPanel(Of FrmCrearRegistros)()
    End Sub

    Private Sub BtnVer_Click(sender As System.Object, e As System.EventArgs) Handles BtnVer.Click
        Utilidades.AbrirFormEnPanel(Of FrmVerRegistros)()
    End Sub

    Private Sub BtnEditar_Click(sender As System.Object, e As System.EventArgs) Handles BtnEditar.Click
        Utilidades.AbrirFormEnPanel(Of FrmEditarRegistros)()
    End Sub
End Class