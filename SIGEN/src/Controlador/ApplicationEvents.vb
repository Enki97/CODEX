Imports System.IO
Imports System.Text

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            MsgBox("Gracias por comprar el producto.")

        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            'OBTENEMOS LOS PARAMETROS DE CONFIGURACIÓN DEL USUARIO

            Dim lector As New StreamReader("etc\cfg.txt")
            Dim linea, lineas(5) As String
            Dim rutaDNS, rutaRecursos, UID, PWD As String
            Dim fecha As Boolean
            Dim i As Integer = 0
            linea = lector.ReadLine()

            While (linea <> "")
                lineas(i) = linea
                linea = lector.ReadLine()
                i += 1
            End While
            lector.Close()

            If lineas(0).Chars(6) = "F" Or lineas(0).Chars(6) = "f" Then
                fecha = False
            Else
                fecha = True
            End If

            rutaDNS = lineas(1).Substring(8)
            rutaRecursos = lineas(2).Substring(13)
            UID = lineas(3).Substring(4)
            PWD = lineas(4).Substring(4)

            Configuracion.setDNS(rutaDNS, UID, PWD)
            Configuracion.setRutaRecursos(rutaRecursos)
            Configuracion.setFormato(fecha)
        End Sub


        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MsgBox("Ha ocurrido el error: " + e.Exception.ToString + vbNewLine + vbNewLine + "Por favor, contacte a un administrador.", MsgBoxStyle.Critical)

        End Sub


    End Class

End Namespace

