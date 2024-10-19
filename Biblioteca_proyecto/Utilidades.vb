Module Utilidades
    Public Sub AbrirFormEnPanel(Of FormHijo As {Form, New})()
        If FrmInicio.PnlContenedor.Controls.Count > 0 Then
            FrmInicio.PnlContenedor.Controls.RemoveAt(0)
        End If

        Dim Formulario As Form = FrmInicio.PnlContenedor.Controls.OfType(Of FormHijo)().FirstOrDefault
        If Formulario Is Nothing Then
            Formulario = New FormHijo()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            FrmInicio.PnlContenedor.Controls.Add(Formulario)
            FrmInicio.PnlContenedor.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub
End Module