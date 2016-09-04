Module Configuracion
    'En este módulo se almacenan las variables configuradas
    'por el usuario desde el archivo cfg.txt
    Dim ruta As String = "etc\BD\prueba.dsn"
    Dim UID As String = "informix"
    Dim PWD As String = "lospii1024"
    Dim formato As Boolean = True
    Public rutaRecursos As String = "share/icono.ico"

    Public Sub setRutaRecursos(ByVal r As String)
        rutaRecursos = r
    End Sub

    Public Sub setFormato(ByVal f As Boolean)
        formato = f
    End Sub

    Public Sub setDNS(ByVal r As String, ByVal u As String, ByVal p As String)
        ruta = r
        UID = u
        PWD = p
    End Sub

    Function getRutaRecursos()
        Return rutaRecursos
    End Function

    Function getRutaDNS()
        Return ruta
    End Function

    Function getUID()
        Return UID
    End Function

    Function getPWD()
        Return PWD
    End Function

    Function getFormato()
        Return formato
    End Function
End Module
