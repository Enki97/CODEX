Public Class Fecha
    Dim formato As Boolean = Configuracion.getFormato()

    Function fecha2vb(ByVal f As String)
        Dim mes As Integer = CInt(f.Substring(3, 2))
        Dim dia As Integer = CInt(f.Substring(0, 2))
        Dim anio As Integer = CInt(f.Substring(6, 4))
        Dim fVB As New Date(anio, mes, dia)
        Return fVB
    End Function

    Function fecha2informix(ByVal f As Date)
        'Se normaliza la fecha como se ingresaría en informix
        If formato Then
            Dim dia As Integer = f.Day
            Dim mes As Integer = f.Month
            Dim anio As Integer = f.Year
            Dim fecha As String = mes.ToString & "/" & dia.ToString & "/" & anio.ToString
            Return fecha
        Else
            Dim dia As Integer = f.Day
            Dim mes As Integer = f.Month
            Dim anio As Integer = f.Year
            Dim fecha As String = dia.ToString & "/" & mes.ToString & "/" & anio.ToString
            Return fecha
        End If
    End Function
End Class
