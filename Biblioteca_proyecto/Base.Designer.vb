<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBase
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GridNoticias = New System.Windows.Forms.DataGridView()
        Me.ColumnNoticias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnRegPres = New System.Windows.Forms.Button()
        Me.BtnVerPres = New System.Windows.Forms.Button()
        Me.BtnRegistros = New System.Windows.Forms.Button()
        CType(Me.GridNoticias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridNoticias
        '
        Me.GridNoticias.AllowUserToAddRows = False
        Me.GridNoticias.AllowUserToDeleteRows = False
        Me.GridNoticias.AllowUserToResizeColumns = False
        Me.GridNoticias.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridNoticias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridNoticias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridNoticias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridNoticias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridNoticias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GridNoticias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridNoticias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridNoticias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridNoticias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridNoticias.ColumnHeadersHeight = 30
        Me.GridNoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridNoticias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNoticias})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridNoticias.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridNoticias.EnableHeadersVisualStyles = False
        Me.GridNoticias.GridColor = System.Drawing.Color.Teal
        Me.GridNoticias.Location = New System.Drawing.Point(470, 43)
        Me.GridNoticias.MinimumSize = New System.Drawing.Size(412, 387)
        Me.GridNoticias.Name = "GridNoticias"
        Me.GridNoticias.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridNoticias.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridNoticias.RowHeadersVisible = False
        Me.GridNoticias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridNoticias.Size = New System.Drawing.Size(412, 387)
        Me.GridNoticias.TabIndex = 54
        '
        'ColumnNoticias
        '
        Me.ColumnNoticias.HeaderText = "Noticias"
        Me.ColumnNoticias.Name = "ColumnNoticias"
        Me.ColumnNoticias.ReadOnly = True
        '
        'BtnRegPres
        '
        Me.BtnRegPres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRegPres.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnRegPres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegPres.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff
        Me.BtnRegPres.FlatAppearance.BorderSize = 0
        Me.BtnRegPres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BtnRegPres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnRegPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegPres.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegPres.ForeColor = System.Drawing.Color.White
        Me.BtnRegPres.Image = Global.Biblioteca.My.Resources.Resources.registrar_blancox150
        Me.BtnRegPres.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRegPres.Location = New System.Drawing.Point(238, 43)
        Me.BtnRegPres.MinimumSize = New System.Drawing.Size(190, 254)
        Me.BtnRegPres.Name = "BtnRegPres"
        Me.BtnRegPres.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRegPres.Size = New System.Drawing.Size(190, 254)
        Me.BtnRegPres.TabIndex = 53
        Me.BtnRegPres.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "préstamos"
        Me.BtnRegPres.UseVisualStyleBackColor = False
        '
        'BtnVerPres
        '
        Me.BtnVerPres.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnVerPres.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnVerPres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVerPres.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff
        Me.BtnVerPres.FlatAppearance.BorderSize = 0
        Me.BtnVerPres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BtnVerPres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnVerPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerPres.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerPres.ForeColor = System.Drawing.Color.White
        Me.BtnVerPres.Image = Global.Biblioteca.My.Resources.Resources.planillaBlancox75
        Me.BtnVerPres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerPres.Location = New System.Drawing.Point(28, 310)
        Me.BtnVerPres.MaximumSize = New System.Drawing.Size(800, 240)
        Me.BtnVerPres.MinimumSize = New System.Drawing.Size(400, 120)
        Me.BtnVerPres.Name = "BtnVerPres"
        Me.BtnVerPres.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnVerPres.Size = New System.Drawing.Size(400, 120)
        Me.BtnVerPres.TabIndex = 52
        Me.BtnVerPres.Text = "Ver préstamos"
        Me.BtnVerPres.UseVisualStyleBackColor = False
        '
        'BtnRegistros
        '
        Me.BtnRegistros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRegistros.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnRegistros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistros.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff
        Me.BtnRegistros.FlatAppearance.BorderSize = 0
        Me.BtnRegistros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BtnRegistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BtnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistros.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistros.ForeColor = System.Drawing.Color.White
        Me.BtnRegistros.Image = Global.Biblioteca.My.Resources.Resources.lupaVerBlancox75
        Me.BtnRegistros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRegistros.Location = New System.Drawing.Point(28, 43)
        Me.BtnRegistros.MinimumSize = New System.Drawing.Size(190, 254)
        Me.BtnRegistros.Name = "BtnRegistros"
        Me.BtnRegistros.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.BtnRegistros.Size = New System.Drawing.Size(190, 254)
        Me.BtnRegistros.TabIndex = 51
        Me.BtnRegistros.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registros" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bibliotecarios"
        Me.BtnRegistros.UseVisualStyleBackColor = False
        '
        'FrmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 472)
        Me.Controls.Add(Me.GridNoticias)
        Me.Controls.Add(Me.BtnRegPres)
        Me.Controls.Add(Me.BtnVerPres)
        Me.Controls.Add(Me.BtnRegistros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBase"
        Me.Text = "Base"
        CType(Me.GridNoticias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridNoticias As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnNoticias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnRegPres As System.Windows.Forms.Button
    Friend WithEvents BtnVerPres As System.Windows.Forms.Button
    Friend WithEvents BtnRegistros As System.Windows.Forms.Button
End Class
