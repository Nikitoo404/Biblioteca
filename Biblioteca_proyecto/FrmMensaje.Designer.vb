<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMensaje
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
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.labelMessage = New System.Windows.Forms.Label()
        Me.pictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.labelCaption = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelBody.SuspendLayout()
        CType(Me.pictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelButtons.SuspendLayout()
        Me.panelTitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.panelBody.Controls.Add(Me.labelMessage)
        Me.panelBody.Controls.Add(Me.pictureBoxIcon)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 35)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.panelBody.Size = New System.Drawing.Size(350, 55)
        Me.panelBody.TabIndex = 12
        '
        'labelMessage
        '
        Me.labelMessage.AutoSize = True
        Me.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMessage.ForeColor = System.Drawing.Color.White
        Me.labelMessage.Location = New System.Drawing.Point(50, 10)
        Me.labelMessage.MaximumSize = New System.Drawing.Size(600, 0)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Padding = New System.Windows.Forms.Padding(5, 5, 10, 15)
        Me.labelMessage.Size = New System.Drawing.Size(110, 37)
        Me.labelMessage.TabIndex = 1
        Me.labelMessage.Text = "labelMessage"
        Me.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pictureBoxIcon
        '
        Me.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureBoxIcon.Image = Global.Biblioteca.My.Resources.Resources.chat
        Me.pictureBoxIcon.Location = New System.Drawing.Point(10, 10)
        Me.pictureBoxIcon.Name = "pictureBoxIcon"
        Me.pictureBoxIcon.Size = New System.Drawing.Size(40, 45)
        Me.pictureBoxIcon.TabIndex = 0
        Me.pictureBoxIcon.TabStop = False
        '
        'panelButtons
        '
        Me.panelButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelButtons.Controls.Add(Me.Button3)
        Me.panelButtons.Controls.Add(Me.Button2)
        Me.panelButtons.Controls.Add(Me.Button1)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 90)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(350, 60)
        Me.panelButtons.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(231, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 35)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(125, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.PeachPuff
        Me.panelTitleBar.Controls.Add(Me.labelCaption)
        Me.panelTitleBar.Controls.Add(Me.btnClose)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(350, 35)
        Me.panelTitleBar.TabIndex = 10
        '
        'labelCaption
        '
        Me.labelCaption.AutoSize = True
        Me.labelCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaption.ForeColor = System.Drawing.Color.Black
        Me.labelCaption.Location = New System.Drawing.Point(9, 8)
        Me.labelCaption.Name = "labelCaption"
        Me.labelCaption.Size = New System.Drawing.Size(86, 17)
        Me.labelCaption.TabIndex = 2
        Me.labelCaption.Text = "labelCaption"
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(310, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 35)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FrmMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 150)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.panelButtons)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Name = "FrmMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        CType(Me.pictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelButtons.ResumeLayout(False)
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelBody As System.Windows.Forms.Panel
    Friend WithEvents labelMessage As System.Windows.Forms.Label
    Friend WithEvents pictureBoxIcon As System.Windows.Forms.PictureBox
    Friend WithEvents panelButtons As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents panelTitleBar As System.Windows.Forms.Panel
    Friend WithEvents labelCaption As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
