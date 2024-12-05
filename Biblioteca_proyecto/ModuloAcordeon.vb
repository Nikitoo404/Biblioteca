Module ModuloAcordeon
    Private _timer As Timer
    Private _targetPanel As Panel
    Private _parentContainer As Control
    Private _isExpanding As Boolean
    Private _expandedHeight As Integer
    Private _collapsedHeight As Integer
    Private _currentOffset As Integer
    Private _arrowPictureBox As PictureBox

    ''' <summary>
    ''' Inicia el desplazamiento de los controles alineados con el panel de referencia.
    ''' </summary>
    ''' <param name="targetPanel">Panel de referencia</param>
    ''' <param name="parentContainer">Contenedor donde buscar los controles (por ejemplo, Me para el formulario)</param>
    ''' <param name="collapsedHeight">Altura cuando está contraído</param>
    ''' <param name="expandedHeight">Altura cuando está expandido</param>
    ''' <param name="arrowPictureBox">PictureBox donde se cambiará la imagen de la flecha</param>
    Public Sub StartPanelAccordion(ByVal targetPanel As Panel, ByVal parentContainer As Control, ByVal collapsedHeight As Integer, ByVal expandedHeight As Integer, ByVal arrowPictureBox As PictureBox)
        _targetPanel = targetPanel
        _parentContainer = parentContainer
        _collapsedHeight = collapsedHeight
        _expandedHeight = expandedHeight
        _arrowPictureBox = arrowPictureBox

        ' Determinar si el panel está expandido o contraído
        _isExpanding = (_targetPanel.Height = _collapsedHeight)

        ' Reiniciar el desplazamiento actual
        _currentOffset = 0

        ' Deshabilitar controles del formulario
        DeshabilitarControles(parentContainer)

        ' Iniciar el temporizador
        _timer = New Timer()
        AddHandler _timer.Tick, AddressOf Timer_Tick
        _timer.Interval = 1
        _timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        If _isExpanding Then
            If _currentOffset < (_expandedHeight - _collapsedHeight) Then
                MoverControlesAlineados(_targetPanel, _parentContainer, 2) ' Mover hacia abajo
                _targetPanel.Height += 2
                _currentOffset += 2
            Else
                _timer.Stop()
                ' Cambiar imagen a flecha hacia abajo
                _arrowPictureBox.Image = My.Resources.flechaArriba
                ' Habilitar controles del formulario
                HabilitarControles(_parentContainer)
            End If
        Else
            If _currentOffset < (_expandedHeight - _collapsedHeight) Then
                MoverControlesAlineados(_targetPanel, _parentContainer, -2) ' Mover hacia arriba
                _targetPanel.Height -= 2
                _currentOffset += 2
            Else
                _timer.Stop()
                ' Cambiar imagen a flecha hacia arriba
                _arrowPictureBox.Image = My.Resources.flechaAbajo
                ' Habilitar controles del formulario
                HabilitarControles(_parentContainer)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Deshabilita todos los controles en el contenedor especificado.
    ''' </summary>
    ''' <param name="parentContainer">Contenedor donde buscar los controles</param>
    Private Sub DeshabilitarControles(ByVal parentContainer As Control)
        For Each ctrl As Control In parentContainer.Controls
            ctrl.Enabled = False
        Next
    End Sub

    ''' <summary>
    ''' Habilita todos los controles en el contenedor especificado.
    ''' </summary>
    ''' <param name="parentContainer">Contenedor donde buscar los controles</param>
    Private Sub HabilitarControles(ByVal parentContainer As Control)
        For Each ctrl As Control In parentContainer.Controls
            ctrl.Enabled = True
        Next
    End Sub

    ''' <summary>
    ''' Desplaza hacia abajo o arriba los controles que están debajo y alineados en el eje X con un panel dado.
    ''' </summary>
    ''' <param name="targetPanel">Panel de referencia</param>
    ''' <param name="parentContainer">Contenedor donde buscar los controles (por ejemplo, Me para el formulario)</param>
    ''' <param name="offset">Cantidad de desplazamiento en píxeles (positivo para abajo, negativo para arriba)</param>
    Private Sub MoverControlesAlineados(ByVal targetPanel As Panel, ByVal parentContainer As Control, ByVal offset As Integer)
        For Each ctrl As Control In parentContainer.Controls
            If TypeOf ctrl Is Control Then
                ' Verificar si el control está físicamente debajo del targetPanel
                If ctrl.Top > targetPanel.Bottom Then
                    ' Verificar si el control está alineado en el eje X con el targetPanel
                    If ctrl.Left >= targetPanel.Left AndAlso ctrl.Left < targetPanel.Left + targetPanel.Width Then
                        ' Mover el control hacia abajo o arriba según el offset
                        ctrl.Top += offset
                    End If
                End If
            End If
        Next
    End Sub
End Module
