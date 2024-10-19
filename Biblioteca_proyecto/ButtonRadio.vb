Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Public Class ButtonRadio
    Inherits Button

    'fields
    Private _borderSize As Integer = 0
    Private _borderRadius As Integer = 13
    Private _borderColor As Color = Drawing.Color.PaleVioletRed


    'Properties
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Invalidate()
        End Set
    End Property
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate()
        End Set
    End Property
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property
    Public Property BackGroundColor
        Get
            Return Me.BackColor
        End Get
        Set(value)
            Me.BackColor = value
        End Set
    End Property
    Public Property TextColor As Color
        Get
            Return Me.ForeColor
        End Get
        Set(value As Color)
            Me.ForeColor = value
        End Set
    End Property

    'constructor
    Public Sub New()
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.Size = New Size(79, 24)
        Me.BackColor = Color.MediumSlateBlue
        Me.ForeColor = Color.White
        AddHandler Me.Resize, AddressOf Button_Resize
    End Sub
    Private Sub Button_Resize(sender As Object, e As EventArgs)
        If _borderRadius > Me.Height Then
            _borderRadius = Me.Height
        End If
    End Sub

    'Metodos
    Private Function GetFigurePath(ByVal rect As Rectangle, ByVal radius As Single) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        Dim rectSurface As Rectangle = Me.ClientRectangle
        Dim rectBorder As Rectangle = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize)
        Dim smoothSize As Integer = 2
        If _borderSize > 0 Then
            smoothSize = _borderSize
        End If

        If _borderRadius > 2 Then ' Rounded button
            Using pathSurface As GraphicsPath = GetFigurePath(rectSurface, _borderRadius)
                Using pathBorder As GraphicsPath = GetFigurePath(rectBorder, _borderRadius - _borderSize)
                    Using penSurface As New Pen(Me.Parent.BackColor, smoothSize)
                        Using penBorder As New Pen(_borderColor, _borderSize)
                            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                            ' Button surface
                            Me.Region = New Region(pathSurface)
                            ' Draw surface border for HD result
                            pevent.Graphics.DrawPath(penSurface, pathSurface)

                            ' Button border                   
                            If _borderSize >= 1 Then
                                ' Draw control border
                                pevent.Graphics.DrawPath(penBorder, pathBorder)
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Else ' Normal button
            pevent.Graphics.SmoothingMode = SmoothingMode.None
            ' Button surface
            Me.Region = New Region(rectSurface)
            ' Button border
            If _borderSize >= 1 Then
                Using penBorder As New Pen(_borderColor, _borderSize)
                    penBorder.Alignment = PenAlignment.Inset
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, Me.Width - 1, Me.Height - 1)
                End Using
            End If
        End If
    End Sub

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        AddHandler Me.Parent.BackColorChanged, AddressOf Container_BackColorChanged
    End Sub

    Private Sub Container_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.Invalidate()
    End Sub

End Class