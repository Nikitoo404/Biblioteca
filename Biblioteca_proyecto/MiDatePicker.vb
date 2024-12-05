Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class MiDatePicker
    Inherits DateTimePicker
    Private _skinColor As Color = Color.BlueViolet
    Private _textColor As Color = Color.White
    Private _borderColor As Color = Color.Transparent
    Private _borderSize As Integer = 0
    Private _droppedDown As Boolean = False
    Private _calendarIcon As Image = My.Resources.calendarWhite
    Private _iconButtonArea As RectangleF = Nothing
    Private _calendarIconWidth As Integer = 34
    Private _arrowIconWidth As Integer = 17

    Public Property SkinColor As Color
        Get
            Return _skinColor
        End Get
        Set(value As Color)
            _skinColor = value
            If (SkinColor.GetBrightness() >= 0.8F) Then
                _calendarIcon = My.Resources.calendarDark
            Else
                _calendarIcon = My.Resources.calendarWhite
            End If
            Me.Update()
        End Set
    End Property

    Public Property TextColor As Color
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
            Me.Update()
        End Set
    End Property

    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
        End Set
    End Property

    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
        End Set
    End Property

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.MinimumSize = New Size(0, 35)
        Me.Font = New Font(Me.Font.Name, 9.5F)
    End Sub

    Protected Overrides Sub OnDropDown(eventargs As EventArgs)
        MyBase.OnDropDown(eventargs)
        _droppedDown = True
    End Sub

    Protected Overrides Sub OnCloseUp(eventargs As EventArgs)
        MyBase.OnCloseUp(eventargs)
        _droppedDown = False
    End Sub

    'Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
    '    MyBase.OnKeyPress(e)
    '    e.Handled = True
    'End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using graphics As Graphics = Me.CreateGraphics()
            Using penBorder As New Pen(borderColor, borderSize)
                Using skinBrush As New SolidBrush(skinColor)
                    Using openIconBrush As New SolidBrush(Color.FromArgb(50, 64, 64, 64))
                        Using textBrush As New SolidBrush(textColor)
                            Using textFormat As New StringFormat()
                                Dim clientArea As New RectangleF(0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
                                Dim iconArea As New RectangleF(clientArea.Width - _calendarIconWidth, 0, _calendarIconWidth, clientArea.Height)
                                penBorder.Alignment = Drawing2D.PenAlignment.Inset
                                textFormat.LineAlignment = StringAlignment.Center
                                textFormat.Alignment = StringAlignment.Near

                                'Draw surface
                                graphics.FillRectangle(skinBrush, clientArea)
                                'Draw text
                                graphics.DrawString(" " + Me.Text, Me.Font, textBrush, clientArea, textFormat)
                                'Draw open calendar icon highlight
                                If _droppedDown = True Then graphics.FillRectangle(openIconBrush, iconArea)
                                'Draw border 
                                If borderSize >= 1 Then graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height)
                                'Draw icon
                                graphics.DrawImage(_calendarIcon, Me.Width - _calendarIcon.Width - 9, Me.Height - _calendarIcon.Height - 9)

                            End Using
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        Dim iconWidth As Integer = GetIconButtonWidth()
        _iconButtonArea = New RectangleF(Me.Width - iconWidth, 0, iconWidth, Me.Height)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If _iconButtonArea.Contains(e.Location) Then

        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

    'Private methods
    Private Function GetIconButtonWidth() As Integer
        Dim textWidh As Integer = TextRenderer.MeasureText(Me.Text, Me.Font).Width
        If textWidh <= Me.Width - (_calendarIconWidth + 20) Then
            Return _calendarIconWidth
        Else
            Return _arrowIconWidth
        End If
    End Function
End Class
