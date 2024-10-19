<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPortada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PcbPortada = New System.Windows.Forms.PictureBox()
        CType(Me.PcbPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PcbPortada
        '
        Me.PcbPortada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PcbPortada.Image = Global.Biblioteca.My.Resources.Resources.biblioteca_portada
        Me.PcbPortada.Location = New System.Drawing.Point(0, 0)
        Me.PcbPortada.Name = "PcbPortada"
        Me.PcbPortada.Size = New System.Drawing.Size(600, 300)
        Me.PcbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbPortada.TabIndex = 1
        Me.PcbPortada.TabStop = False
        '
        'FrmPortada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.PcbPortada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPortada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Portada"
        CType(Me.PcbPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PcbPortada As System.Windows.Forms.PictureBox
End Class
