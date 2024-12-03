Public Class TxtPerso
    'Fields
    Private borderColor As Color = Color.MediumSlateBlue
    Private borderSize As Integer = 2
    Private underlinedStyle As Boolean = False
    Private borderFocusColor As Color = Color.HotPink
    Private isFocused As Boolean = False

    'Private methods
    Public Sub UpdateControlHeight()
        If TextBox1.Multiline = False Then
            Dim txtHeight As Integer = TextRenderer.MeasureText("Text", Me.Font).Height + 1
            TextBox1.Multiline = True
            TextBox1.MinimumSize = New Size(0, txtHeight)
            TextBox1.Multiline = False
            Me.Height = TextBox1.Height + Me.Padding.Top + Me.Padding.Bottom
        End If
    End Sub

    ' Properties
    Public Property _MaxLength As Integer
        Get
            Return TextBox1.MaxLength
        End Get
        Set(value As Integer)
            TextBox1.MaxLength = value
        End Set
    End Property
    Public Property _BorderColor As Color
        Get
            Return borderColor
        End Get
        Set(value As Color)
            borderColor = value
            Me.Invalidate()
        End Set
    End Property
    Public Property _BorderSize As Integer
        Get
            Return borderSize
        End Get
        Set(value As Integer)
            borderSize = value
        End Set
    End Property
    Public Property _UnderlinedStyle As Boolean
        Get
            Return underlinedStyle
        End Get
        Set(value As Boolean)
            underlinedStyle = value
        End Set
    End Property
    Public Property _PasswordChar As Boolean
        Get
            Return TextBox1.UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            TextBox1.UseSystemPasswordChar = value
        End Set
    End Property
    Public Property _Multiline As Boolean
        Get
            Return TextBox1.Multiline
        End Get
        Set(value As Boolean)
            TextBox1.Multiline = value
        End Set
    End Property
    Public Overrides Property BackColor As System.Drawing.Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As System.Drawing.Color)
            MyBase.BackColor = value
            TextBox1.BackColor = value
        End Set
    End Property
    Public Overrides Property ForeColor As System.Drawing.Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As System.Drawing.Color)
            MyBase.ForeColor = value
            TextBox1.ForeColor = value
        End Set
    End Property
    Public Overrides Property Font As System.Drawing.Font
        Get
            Return MyBase.Font
        End Get
        Set(value As System.Drawing.Font)
            MyBase.Font = value
            TextBox1.Font = value
            If Me.DesignMode Then
                UpdateControlHeight()
            End If
        End Set
    End Property
    Public Property Texts As String
        Get
            Return TextBox1.Text
        End Get
        Set(value As String)
            TextBox1.Text = value
        End Set
    End Property
    Public Property _BorderFocusColor As Color
        Get
            Return borderFocusColor
        End Get
        Set(value As Color)
            borderFocusColor = value
        End Set
    End Property

    'Overridden methods
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics
        'Draw border
        Using penBorder As Pen = New Pen(borderColor, borderSize)
            penBorder.Alignment = Drawing2D.PenAlignment.Inset
            If isFocused Then
                penBorder.Color = borderFocusColor 'Set Border color in focus. Otherwise, normal border color
                If underlinedStyle Then 'Line Style
                    graph.DrawLine(penBorder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
                Else
                    graph.DrawRectangle(penBorder, 0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
                End If
            End If
        End Using
    End Sub
    Protected Overrides Sub OnResize(e As System.EventArgs)
        MyBase.OnResize(e)
        If Me.DesignMode Then
            UpdateControlHeight()
        End If
    End Sub
    Protected Overrides Sub OnLoad(e As System.EventArgs)
        MyBase.OnLoad(e)
        UpdateControlHeight()
    End Sub

    'Change border color in focus mode
    Private Sub textBox1_Enter(sender As System.Object, e As System.EventArgs) Handles TextBox1.MouseEnter
        isFocused = True
        Me.Invalidate()
    End Sub
    Private Sub textBox1_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox1.MouseLeave
        isFocused = False
        Me.Invalidate()
    End Sub

    '<DefaultEvent("_TextChanged")>
    Partial Public Class RJTextBox
        Inherits UserControl

        ' Default Event
        Public Event _TextChanged As EventHandler

        ' TextBox -> TextChanged event
        Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _TextChangedEvent IsNot Nothing Then
                RaiseEvent _TextChanged(sender, e)
            End If
        End Sub
    End Class

    'TextBox events
    ' <summary>
    ' textbox events attached to user control events
    '</summary>
    Private Sub textBox1_Click(sender As System.Object, e As System.EventArgs) Handles TextBox1.Click
        Me.OnClick(e)
    End Sub
    Private Sub textBox1_MouseEnter(sender As System.Object, e As System.EventArgs)
        Me.OnMouseEnter(e)
    End Sub
    Private Sub textBox1_MouseLeave(sender As System.Object, e As System.EventArgs)
        Me.OnMouseLeave(e)
    End Sub
    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Me.OnKeyPress(e)
    End Sub
End Class
