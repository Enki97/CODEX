Public Class Evolucion
    Public entrenador As Entrenador
    Public deportista As Deportista
    Dim documento_deportista, documento_entrenador As Integer

    'Conversor de fecha
    Dim f As New Fecha()

    'Debug
    Public msg As String

    Public Sub New(ByVal deportista As Deportista, Optional ByVal entrenador As Entrenador = Nothing)
        Me.documento_deportista = deportista.documento
        If entrenador Is Nothing Then
            Try
                Dim consulta = New BD("SELECT documento_entrenador FROM EVOLUCION WHERE documento_deportista=" & Me.documento_deportista)
                consulta.consulta.Read()
                If consulta.consulta.HasRows() Then
                    Me.documento_entrenador = consulta.consulta.GetValue(0)
                    Me.entrenador = New Entrenador(Me.documento_entrenador)
                Else
                    Me.entrenador = Nothing
                End If
            Catch ex As Exception

            End Try
        Else
            Me.documento_entrenador = entrenador.documento
        End If


    End Sub

    Function ingresarCalificacion(ByVal cumplimiento As Integer, ByVal resistenciaAnaerobica As Integer, _
                                  ByVal resistenciaMuscular As Integer, ByVal fuerzaMuscular As Integer, _
                                  ByVal flexibilidad As Integer, ByVal resistenciaMonotonia As Integer, _
                                  ByVal reciliencia As Integer)
        Dim sumatoria As Integer = cumplimiento + resistenciaAnaerobica + resistenciaMuscular + fuerzaMuscular + _
        flexibilidad + resistenciaMonotonia + reciliencia
        Dim promedio As Integer = sumatoria / 7
        Try
            Dim ingresar = New BD("INSERT INTO EVOLUCION VALUES('" & Me.documento_deportista & "','" & Me.documento_entrenador & _
                                  "','" & f.fecha2informix(Now) & "','" & cumplimiento & "','" & resistenciaAnaerobica & "','" & _
                                  resistenciaMuscular & "','" & fuerzaMuscular & "','" & flexibilidad & "','" & _
                                  resistenciaMonotonia & "','" & reciliencia & "','" & promedio & "')")
            Return 0
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Function ultimaCalificacion()
        Dim calificacion(8) As Integer
        Try
            Dim consultar = New BD("SELECT * FROM EVOLUCION ORDER BY FECHA DESC")
            consultar.consulta.Read()
            calificacion(0) = consultar.consulta.GetValue(3)
            calificacion(1) = consultar.consulta.GetValue(4)
            calificacion(2) = consultar.consulta.GetValue(5)
            calificacion(3) = consultar.consulta.GetValue(6)
            calificacion(4) = consultar.consulta.GetValue(7)
            calificacion(5) = consultar.consulta.GetValue(8)
            calificacion(6) = consultar.consulta.GetValue(9)
            calificacion(7) = consultar.consulta.GetValue(10)
            consultar.close()
            Return calificacion
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Function consultarEvolucion()
        Dim fecha As String
        Dim diccionario As New Dictionary(Of Date, Integer())
        Try
            Dim consultar = New BD("SELECT * FROM EVOLUCION ORDER BY FECHA ASC")
            While consultar.consulta.Read()
                Dim calificacion(8) As Integer
                calificacion(0) = consultar.consulta.GetValue(3)
                calificacion(1) = consultar.consulta.GetValue(4)
                calificacion(2) = consultar.consulta.GetValue(5)
                calificacion(3) = consultar.consulta.GetValue(6)
                calificacion(4) = consultar.consulta.GetValue(7)
                calificacion(5) = consultar.consulta.GetValue(8)
                calificacion(6) = consultar.consulta.GetValue(9)
                calificacion(7) = consultar.consulta.GetValue(10)
                fecha = consultar.consulta.GetValue(2)
                diccionario.Add(f.fecha2vb(fecha), calificacion)
                calificacion = Nothing
            End While
            consultar.close()
            Return diccionario
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Function correspondeEntrenador(ByVal documento_deportista As Integer, ByVal documento_entrenador As Integer)
        'Devuelve si el entrenador es el que ya lo estaba entrenandor
        Dim entrenador As Integer
        Try
            Dim consulta As New BD("SELECT documento_entrenador FROM EVOLUCION WHERE documento_deportista=" & documento_deportista)
            consulta.consulta.Read()
            entrenador = consulta.consulta.GetValue(0)
            consulta.close()

            If documento_entrenador = entrenador Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function
End Class
