<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistros
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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.BtnVolver = New Biblioteca.ButtonRadio()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTitulo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.PeachPuff
        Me.LblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LblTitulo.Location = New System.Drawing.Point(57, 18)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(85, 22)
        Me.LblTitulo.TabIndex = 16
        Me.LblTitulo.Text = "Registros"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnVolver.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnVolver.BorderColor = System.Drawing.Color.PeachPuff
        Me.BtnVolver.BorderRadius = 18
        Me.BtnVolver.BorderSize = 1
        Me.BtnVolver.FlatAppearance.BorderSize = 0
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Image = Global.Biblioteca.My.Resources.Resources.blueCla
        Me.BtnVolver.Location = New System.Drawing.Point(12, 12)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(39, 39)
        Me.BtnVolver.TabIndex = 19
        Me.BtnVolver.TextColor = System.Drawing.Color.White
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FrmRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 472)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegistros"
        Me.Text = "Registros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents BtnVolver As Biblioteca.ButtonRadio
End Class
