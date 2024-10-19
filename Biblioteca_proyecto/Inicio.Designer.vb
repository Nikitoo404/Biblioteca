<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblCerrarSesion = New System.Windows.Forms.Label()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PnlContenedor = New System.Windows.Forms.Panel()
        Me.PnlBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.PeachPuff
        Me.PnlBarra.Controls.Add(Me.LblTitulo)
        Me.PnlBarra.Controls.Add(Me.LblCerrarSesion)
        Me.PnlBarra.Controls.Add(Me.BtnRestaurar)
        Me.PnlBarra.Controls.Add(Me.BtnMinimizar)
        Me.PnlBarra.Controls.Add(Me.BtnMaximizar)
        Me.PnlBarra.Controls.Add(Me.BtnCerrar)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.Size = New System.Drawing.Size(910, 38)
        Me.PnlBarra.TabIndex = 11
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTitulo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.Black
        Me.LblTitulo.Image = Global.Biblioteca.My.Resources.Resources.biblioteca_portadax50
        Me.LblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(384, 22)
        Me.LblTitulo.TabIndex = 14
        Me.LblTitulo.Text = "             Biblioteca Municipal ""María Elena Walsh"""
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCerrarSesion
        '
        Me.LblCerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCerrarSesion.AutoSize = True
        Me.LblCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.LblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCerrarSesion.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCerrarSesion.ForeColor = System.Drawing.Color.Gray
        Me.LblCerrarSesion.Location = New System.Drawing.Point(700, 9)
        Me.LblCerrarSesion.Name = "LblCerrarSesion"
        Me.LblCerrarSesion.Size = New System.Drawing.Size(90, 18)
        Me.LblCerrarSesion.TabIndex = 13
        Me.LblCerrarSesion.Text = "Cerrar sesión"
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnRestaurar.FlatAppearance.BorderSize = 0
        Me.BtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Image = Global.Biblioteca.My.Resources.Resources.Icono_Restaurar_negro
        Me.BtnRestaurar.Location = New System.Drawing.Point(834, 0)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(38, 38)
        Me.BtnRestaurar.TabIndex = 8
        Me.BtnRestaurar.UseVisualStyleBackColor = False
        Me.BtnRestaurar.Visible = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Image = Global.Biblioteca.My.Resources.Resources.Icono_Minimizar_negro
        Me.BtnMinimizar.Location = New System.Drawing.Point(796, 0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(38, 38)
        Me.BtnMinimizar.TabIndex = 7
        Me.BtnMinimizar.UseVisualStyleBackColor = True
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Image = Global.Biblioteca.My.Resources.Resources.Icono_Maximizar_negro
        Me.BtnMaximizar.Location = New System.Drawing.Point(834, 0)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(38, 38)
        Me.BtnMaximizar.TabIndex = 8
        Me.BtnMaximizar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = Global.Biblioteca.My.Resources.Resources.Icono_cerrar_FN_negro
        Me.BtnCerrar.Location = New System.Drawing.Point(872, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(38, 38)
        Me.BtnCerrar.TabIndex = 6
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PnlContenedor
        '
        Me.PnlContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlContenedor.Location = New System.Drawing.Point(0, 38)
        Me.PnlContenedor.Name = "PnlContenedor"
        Me.PnlContenedor.Size = New System.Drawing.Size(910, 472)
        Me.PnlContenedor.TabIndex = 12
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 510)
        Me.Controls.Add(Me.PnlBarra)
        Me.Controls.Add(Me.PnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlBarra As System.Windows.Forms.Panel
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents LblCerrarSesion As System.Windows.Forms.Label
    Friend WithEvents BtnRestaurar As System.Windows.Forms.Button
    Friend WithEvents BtnMinimizar As System.Windows.Forms.Button
    Friend WithEvents BtnMaximizar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents PnlContenedor As System.Windows.Forms.Panel
End Class
