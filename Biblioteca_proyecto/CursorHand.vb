Imports System.Runtime.InteropServices
Module CursorHand
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Function LoadCursor(ByVal hInstance As IntPtr, ByVal lpCursorName As Integer) As IntPtr
    End Function
    Public Const OCR_HAND As Integer = 32649

    ' Función para obtener un cursor personalizado desde archivo
    Public Function GetCustomCursor() As Cursor
        Dim ptrHand As IntPtr = LoadCursor(IntPtr.Zero, OCR_HAND)
        If ptrHand <> IntPtr.Zero Then
            Return New Cursor(ptrHand)
        Else
            Return Cursors.Default ' En caso de fallo, retorna el cursor por defecto
        End If
        ' Para usarlo en un cursor, simplemente completar en la propiedad cursor de un objeto: CursorHand.GetCustomCursor
    End Function
End Module
