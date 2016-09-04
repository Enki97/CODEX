Public Class Seleccionador
    Inherits Usuario
    Public acreditacionSeleccionador As Integer

    Public Sub New(Optional ByVal documento As Integer = Nothing)
        MyBase.New(documento)
        If Not documento = Nothing Then
            Try
                Dim seleccionador As New BD("SELECT acreditacion_seleccionador FROM seleccionador WHERE documento='" & documento & "'")
                seleccionador.consulta.Read()
                If seleccionador.consulta.HasRows Then
                    Me.acreditacionSeleccionador = seleccionador.consulta.GetValue(0)
                Else
                    Me.msg = "No existe el usuario"
                End If
                seleccionador.close()
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try

        Else
            Me.acreditacionSeleccionador = Nothing
        End If
    End Sub

    Function registrarSeleccionador(ByVal documento As Integer)
        Dim acreditacion As Integer = 0
        Try
            'Consulta el último número de usuario seleccionador que se halla ingresado con el fin _
            'de que sea autoincremental
            Dim consultar = New BD("SELECT acreditacion_seleccionador FROM seleccionador ORDER BY acreditacion_seleccionador DESC")
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
            Dim insertar = New BD("INSERT INTO seleccionador VALUES('" & documento & "','" & acreditacion & "')")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function
End Class
