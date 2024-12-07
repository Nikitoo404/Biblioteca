Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Public Class ButtonToggleOnOff
    Inherits CheckBox

    'Fields
    Private _onBackColor As Color = Color.MediumSlateBlue
    Private _onToggleColor As Color = Color.WhiteSmoke
    Private _offBackColor As Color = Color.Gray
    Private _offToggleColor As Color = Color.Gainsboro
    Private _solidStyle As Boolean = True
    Private toggleX As Integer = 2 ' Initial X position of the toggle
    Private targetX As Integer ' Target X position of the toggle
    Private timer As New Timer()

    'Properties
    Public Property OnBackColor As Color
        Get
            Return _onBackColor
        End Get
        Set(value As Color)
            _onBackColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property OnToggleColor As Color
        Get
            Return _onToggleColor
        End Get
        Set(value As Color)
            _onToggleColor = value
            Me.Update()
        End Set
    End Property

    Public Property OffBackColor As Color
        Get
            Return _offBackColor
        End Get
        Set(value As Color)
            _offBackColor = value
            Me.Update()
        End Set
    End Property

    Public Property OffToggleColor As Color
        Get
            Return _offToggleColor
        End Get
        Set(value As Color)
            _offToggleColor = value
            Me.Update()
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property SolidStyle As Boolean
        Get
            Return _solidStyle
        End Get
        Set(value As Boolean)
            _solidStyle = value
            Me.Update()
        End Set
    End Property

    'Constructor
    Public Sub New()
        Me.MinimumSize = New Size(45, 22)
        AddHandler Me.CheckedChanged, AddressOf ToggleCheckedChanged
        timer.Interval = 2 ' Timer interval in milliseconds (adjust as needed)
        AddHandler timer.Tick, AddressOf TimerTick
        ' Inicializa la posición del toggle según el estado inicial
        If Me.Checked Then
            toggleX = Me.Width - Me.Height + 1
        Else
            toggleX = 2
        End If
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        ' Ajusta la posición del toggle al crear el control
        If Me.Checked Then
            toggleX = Me.Width - Me.Height + 1
        Else
            toggleX = 2
        End If
    End Sub


    'Methods

    Private Function GetFigurePath() As GraphicsPath
        Dim arcSize As Integer = Me.Height - 1
        Dim leftArc As Rectangle = New Rectangle(0, 0, arcSize, arcSize)
        Dim rightArc As Rectangle = New Rectangle(Me.Width - arcSize - 2, 0, arcSize, arcSize)
        Dim path As New GraphicsPath()

        path.StartFigure()
        path.AddArc(leftArc, 90, 180)
        path.AddArc(rightArc, 270, 180)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim toggleSize As Integer = Me.Height - 5
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        pevent.Graphics.Clear(Me.Parent.BackColor)

        ' Crea un pincel dinámico basado en ForeColor
        Using textBrush As New SolidBrush(Me.ForeColor)
            If Me.Checked Then 'ON
                ' Dibuja la superficie del control (Draw control surface)
                If SolidStyle Then
                    pevent.Graphics.FillPath(New SolidBrush(OnBackColor), GetFigurePath())
                Else
                    pevent.Graphics.DrawPath(New Pen(OnBackColor, 2), GetFigurePath())
                End If

                ' Dibuja el interruptor (Draw the toggle)
                pevent.Graphics.FillEllipse(New SolidBrush(OnToggleColor),
                                            New Rectangle(toggleX, 2, toggleSize, toggleSize))

                ' Dibuja el texto "ON"
                Dim onTextSize As SizeF = pevent.Graphics.MeasureString("ON", Me.Font)
                pevent.Graphics.DrawString("ON", Me.Font, textBrush, toggleX - onTextSize.Width - 5, Me.Height / 2 - onTextSize.Height / 2)
            Else 'OFF
                ' Dibuja la superficie del control (Draw control surface)
                If SolidStyle Then
                    pevent.Graphics.FillPath(New SolidBrush(OffBackColor), GetFigurePath())
                Else
                    pevent.Graphics.DrawPath(New Pen(OffBackColor, 2), GetFigurePath())
                End If

                ' Dibuja el interruptor (Draw the toggle)
                pevent.Graphics.FillEllipse(New SolidBrush(OffToggleColor),
                                            New Rectangle(toggleX, 2, toggleSize, toggleSize))

                ' Dibuja el texto "OFF"
                Dim offTextSize As SizeF = pevent.Graphics.MeasureString("OFF", Me.Font)
                pevent.Graphics.DrawString("OFF", Me.Font, textBrush, toggleX + toggleSize + 5, Me.Height / 2 - offTextSize.Height / 2)
            End If
        End Using
    End Sub



    Private Sub ToggleCheckedChanged(sender As Object, e As EventArgs)
        If Me.Checked Then 'ON state
            targetX = Me.Width - Me.Height + 1 ' Target X position for the toggle when ON
        Else 'OFF state
            targetX = 2 ' Target X position for the toggle when OFF
        End If
        timer.Start() ' Start the timer to animate the toggle movement
    End Sub

    Private Sub TimerTick(sender As Object, e As EventArgs)
        ' Calculate the new position of the toggle
        Dim dx As Integer = targetX - toggleX
        If Math.Abs(dx) <= 1 Then
            ' If the toggle is close to the target position, stop the timer and set the final position
            timer.Stop()
            toggleX = targetX
        Else
            ' Move the toggle closer to the target position
            toggleX += Math.Sign(dx) * Math.Min(Math.Abs(dx), 6) ' Adjust the division factor for smoother/faster animation
        End If
        Me.Invalidate() ' Redraw the control to update the toggle position
    End Sub
End Class
