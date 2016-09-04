Public Class Avanzado
    Inherits Usuario
    Public nroFuncionario As Integer

    Public Sub New(Optional ByVal documento As Integer = Nothing)
        MyBase.New(documento)
        If Not documento = 0 Then
            Try
                Dim avanzado = New BD("SELECT nro_funcionario FROM avanzado WHERE documento='" & documento & "'")
                avanzado.consulta.Read()
                If avanzado.consulta.HasRows Then
                    Me.nroFuncionario = avanzado.consulta.GetValue(0)
                Else
                    Me.msg = "No existe el usuario"
                End If
                avanzado.close()
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try

        Else
            nroFuncionario = Nothing
        End If
    End Sub

    Function registrarAvanzado(ByVal documento As Integer)
        Dim nFuncionario As Integer = 0
        Try
            'Consulta el último número de usuario avanzado que se halla ingresado con el fin _
            'de que sea autoincremental
            Dim consultar = New BD("SELECT nro_funcionario FROM avanzado ORDER BY nro_funcionario DESC")
            consultar.consulta.Read()
            If consultar.consulta.HasRows Then
                nFuncionario = consultar.consulta.GetValue(0) + 1
            End If
            consultar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        Try
            Dim insertar = New BD("INSERT INTO avanzado VALUES('" & documento & "','" & nFuncionario & "')")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

End Class
