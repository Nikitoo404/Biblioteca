Module ModuloAcordeon
    ''' <summary>
    ''' Desplaza hacia abajo los controles que están debajo y alineados en el eje X con un panel dado.
    ''' </summary>
    ''' <param name="targetPanel">Panel de referencia</param>
    ''' <param name="parentContainer">Contenedor donde buscar los controles (por ejemplo, Me para el formulario)</param>
    ''' <param name="offset">Cantidad de desplazamiento en píxeles</param>
    Public Sub MoverControlesAlineados(ByVal targetPanel As Panel, ByVal parentContainer As Control, ByVal offset As Integer)
        For Each ctrl As Control In parentContainer.Controls
            If TypeOf ctrl Is Control Then
                ' Verificar si el control está físicamente debajo del targetPanel
                If ctrl.Top > targetPanel.Bottom Then
                    ' Verificar si el control está alineado en el eje X con el targetPanel
                    If ctrl.Left >= targetPanel.Left AndAlso ctrl.Left < targetPanel.Left + targetPanel.Width Then
                        ' Mover el control hacia abajo
                        ctrl.Top += offset
                    End If
                End If
            End If
        Next
    End Sub
End Module
