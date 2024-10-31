Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class ComboPerso
    Inherits UserControl

    ' Campos
    Private _backColor As Color = Color.WhiteSmoke
    Private iconColor As Color = Color.MediumSlateBlue
    Private listBackColor As Color = Color.FromArgb(230, 228, 245)
    Private listTextColor As Color = Color.DimGray
    Private borderColor As Color = Color.MediumSlateBlue
    Private borderSize As Integer = 1

    ' Items
    Private cmbList As ComboBox
    Private lblText As Label
    Private btnIcon As Button

    ' Eventos
    Public Event OnSelectedIndexChanged As EventHandler ' Default event

    ' Constructor
    Public Sub New()
        cmbList = New ComboBox()
        lblText = New Label()
        btnIcon = New Button()
        Me.SuspendLayout()

        ' ComboBox: Dropdown list
        cmbList.BackColor = listBackColor
        cmbList.Font = New Font(Me.Font.Name, 10.0F)
        cmbList.ForeColor = listTextColor
        AddHandler cmbList.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged ' Default event
        AddHandler cmbList.TextChanged, AddressOf ComboBox_TextChanged ' Refresh text

        ' Button: Icon
        btnIcon.Dock = DockStyle.Right
        btnIcon.FlatStyle = FlatStyle.Flat
        btnIcon.FlatAppearance.BorderSize = 0
        btnIcon.BackColor = BackColor
        btnIcon.Size = New Size(30, 30)
        btnIcon.Cursor = Cursors.Default
        AddHandler btnIcon.Click, AddressOf Icon_Click ' Open dropdown list
        AddHandler btnIcon.Paint, AddressOf Icon_Paint ' Draw icon

        ' Label: Text
        lblText.Dock = DockStyle.Fill
        lblText.AutoSize = False
        lblText.BackColor = BackColor
        lblText.TextAlign = ContentAlignment.MiddleLeft
        lblText.Padding = New Padding(8, 0, 0, 0)
        lblText.Font = New Font(Me.Font.Name, 10.0F)

        ' Attach label events to user control event
        AddHandler lblText.Click, AddressOf Surface_Click ' Select combo box
        AddHandler lblText.MouseEnter, AddressOf Surface_MouseEnter
        AddHandler lblText.MouseLeave, AddressOf Surface_MouseLeave

        ' User Control
        Me.Controls.Add(lblText) ' 2
        Me.Controls.Add(btnIcon) ' 1
        Me.Controls.Add(cmbList) ' 0
        Me.MinimumSize = New Size(200, 30)
        Me.Size = New Size(200, 30)
        Me.ForeColor = Color.DimGray
        Me.Padding = New Padding(borderSize) ' Border Size
        Me.Font = New Font(Me.Font.Name, 10.0F)
        MyBase.BackColor = borderColor ' Border Color

        Me.ResumeLayout()
        AdjustComboBoxDimensions()
    End Sub

    ' Private methods
    Private Sub AdjustComboBoxDimensions()
        cmbList.Width = lblText.Width
        cmbList.Location = New Point() With
        {
            .X = Me.Width - Me.Padding.Right - cmbList.Width,
            .Y = lblText.Bottom - cmbList.Height
        }
    End Sub

    ' Event methods

    ' Default event
    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
          lblText.Text = cmbList.Text
        RaiseEvent OnSelectedIndexChanged(Me, e) ' Invocar evento
    End Sub

    ' Items actions
    Private Sub Icon_Click(sender As Object, e As EventArgs)
        ' Open dropdown list
        cmbList.Select()
        cmbList.DroppedDown = True
    End Sub

    Private Sub Surface_Click(sender As Object, e As EventArgs)
        ' Attach label click to user control click
        Me.OnClick(e)
        ' Select combo box
        cmbList.Select()
        If cmbList.DropDownStyle = ComboBoxStyle.DropDownList Then
            cmbList.DroppedDown = True ' Open dropdown list
        End If
    End Sub

    Private Sub ComboBox_TextChanged(sender As Object, e As EventArgs)
        ' Refresh text
        lblText.Text = cmbList.Text
    End Sub

    ' Draw icon
    Private Sub Icon_Paint(sender As Object, e As PaintEventArgs)
        ' Fields
        Dim iconWidth As Integer = 14
        Dim iconHeight As Integer = 6
        Dim rectIcon As New Rectangle((btnIcon.Width - iconWidth) \ 2, (btnIcon.Height - iconHeight) \ 2, iconWidth, iconHeight)
        Dim graph As Graphics = e.Graphics

        ' Draw arrow down icon
        Using path As New GraphicsPath()
            Using pen As New Pen(iconColor, 2)
                graph.SmoothingMode = SmoothingMode.AntiAlias
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth \ 2), rectIcon.Bottom)
                path.AddLine(rectIcon.X + (iconWidth \ 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y)
                graph.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    ' Properties

    ' Appearance

    <Category("RJ Code - Appearance")>
    Public Shadows Property BackColor As Color
        Get
            Return _backColor
        End Get
        Set(value As Color)
            _backColor = value
            lblText.BackColor = _backColor
            btnIcon.BackColor = _backColor
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Property _IconColor As Color
        Get
            Return iconColor
        End Get
        Set(value As Color)
            iconColor = value
            btnIcon.Invalidate() ' Redraw icon
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Property _ListBackColor As Color
        Get
            Return listBackColor
        End Get
        Set(value As Color)
            listBackColor = value
            cmbList.BackColor = listBackColor
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Property _ListTextColor As Color
        Get
            Return listTextColor
        End Get
        Set(value As Color)
            listTextColor = value
            cmbList.ForeColor = listTextColor
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Property _BorderColor As Color
        Get
            Return borderColor
        End Get
        Set(value As Color)
            borderColor = value
            MyBase.BackColor = borderColor ' Border Color
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Property _BorderSize As Integer
        Get
            Return borderSize
        End Get
        Set(value As Integer)
            borderSize = value
            Me.Padding = New Padding(borderSize) ' Border Size
            AdjustComboBoxDimensions()
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
            lblText.ForeColor = value
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            lblText.Font = value
            cmbList.Font = value ' Optional
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Property Texts As String
        Get
            Return lblText.Text
        End Get
        Set(value As String)
            lblText.Text = value
        End Set
    End Property

    <Category("RJ Code - Appearance")>
    Public Property DropDownStyle As ComboBoxStyle
        Get
            Return cmbList.DropDownStyle
        End Get
        Set(value As ComboBoxStyle)
            If cmbList.DropDownStyle <> ComboBoxStyle.Simple Then
                cmbList.DropDownStyle = value
            End If
        End Set
    End Property

    ' Properties

    ' Data

    <Category("RJ Code - Data")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))>
    <Localizable(True)>
    <MergableProperty(False)>
    Public ReadOnly Property Items As ComboBox.ObjectCollection
        Get
            Return cmbList.Items
        End Get
    End Property

    '<Category("RJ Code - Data")>
    '<AttributeProvider(GetType(IListSource))>
    '<DefaultValue(Nothing)>
    Public Property DataSource As Object
        Get
            Return cmbList.DataSource
        End Get
        Set(value As Object)
            cmbList.DataSource = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <Localizable(True)>
    Public Property AutoCompleteCustomSource As AutoCompleteStringCollection
        Get
            Return cmbList.AutoCompleteCustomSource
        End Get
        Set(value As AutoCompleteStringCollection)
            cmbList.AutoCompleteCustomSource = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <Browsable(True)>
    <DefaultValue(AutoCompleteSource.None)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    Public Property AutoCompleteSource As AutoCompleteSource
        Get
            Return cmbList.AutoCompleteSource
        End Get
        Set(value As AutoCompleteSource)
            cmbList.AutoCompleteSource = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <Browsable(True)>
    <DefaultValue(AutoCompleteMode.None)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    Public Property AutoCompleteMode As AutoCompleteMode
        Get
            Return cmbList.AutoCompleteMode
        End Get
        Set(value As AutoCompleteMode)
            cmbList.AutoCompleteMode = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <Bindable(True)>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property SelectedItem As Object
        Get
            Return cmbList.SelectedItem
        End Get
        Set(value As Object)
            cmbList.SelectedItem = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property SelectedIndex As Integer
        Get
            Return cmbList.SelectedIndex
        End Get
        Set(value As Integer)
            cmbList.SelectedIndex = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <DefaultValue("")>
    <Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))>
    <TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    Public Property DisplayMember As String
        Get
            Return cmbList.DisplayMember
        End Get
        Set(value As String)
            cmbList.DisplayMember = value
        End Set
    End Property

    <Category("RJ Code - Data")>
    <DefaultValue("")>
    <Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))>
    Public Property ValueMember As String
        Get
            Return cmbList.ValueMember
        End Get
        Set(value As String)
            cmbList.ValueMember = value
        End Set
    End Property

    ' Attach label events to user control event
    Private Sub Surface_MouseLeave(sender As Object, e As EventArgs)
        Me.OnMouseLeave(e)
    End Sub

    Private Sub Surface_MouseEnter(sender As Object, e As EventArgs)
        Me.OnMouseEnter(e)
    End Sub

    ' Overridden methods
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        AdjustComboBoxDimensions()
    End Sub
End Class
