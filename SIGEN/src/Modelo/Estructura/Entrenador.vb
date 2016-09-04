Public Class Entrenador
    Inherits Usuario
    Public acreditacionEntrenador As Integer

    Public Sub New(Optional ByVal documento As Integer = Nothing)
        MyBase.New(documento)
        If Not documento = Nothing Then
            Try
                Dim entrenador As New BD("SELECT acreditacion_entrenador FROM entrenador WHERE documento='" & documento & "'")
                entrenador.consulta.Read()
                If entrenador.consulta.HasRows Then
                    Me.acreditacionEntrenador = entrenador.consulta.GetValue(0)
                Else
                    Me.msg = "No existe el usuario"
                End If
                entrenador.close()
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try

        Else
            acreditacionEntrenador = Nothing
        End If
    End Sub

    Function registrarEntrenador(ByVal documento As Integer)
        Dim acreditacion As Integer = 0
        Try
            'Consulta el último número de entrenador que se halla ingresado con el fin _
            'de que sea autoincremental
            Dim consultar = New BD("SELECT acreditacion_entrenador FROM entrenador ORDER BY acreditacion_entrenador DESC")
            consultar.consulta.Read()
            If consultar.consulta.HasRows Then
                acreditacion = consultar.consulta.GetValue(0) + 1
            End If
            consultar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        Try
            Dim insertar = New BD("INSERT INTO entrenador VALUES('" & documento & "','" & acreditacion & "')")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

End Class
