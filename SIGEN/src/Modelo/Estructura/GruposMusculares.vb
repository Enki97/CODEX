Public Class GruposMusculares
    Public nombre, foto, descripcion, tipo As String
    Public id_grupos As Integer
    Public msg As String

    Public Sub New(Optional ByVal id_grupos As Integer = -1)
        If id_grupos >= 0 Then
            Try
                Dim consultar As New BD("SELECT * FROM gruposmusculares where id_grupos=" & id_grupos)
                consultar.consulta.Read()
                If consultar.consulta.HasRows Then
                    Me.id_grupos = id_grupos
                    Me.nombre = consultar.consulta.GetValue(1)
                    Me.descripcion = consultar.consulta.GetValue(2)
                    Me.foto = consultar.consulta.GetValue(3)
                    Me.tipo = consultar.consulta.GetValue(4)
                Else
                    Me.msg = "NE"
                End If
                consultar.close()
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try
        End If
    End Sub

    Function ingresarGrupos(ByVal nombre As String, ByVal descripcion As String, ByVal foto As String, _
                            ByVal tipo As String)
        Dim id As Integer = 0
        Try
            Dim contar As New BD("SELECT id_grupos FROM GRUPOSMUSCULARES order by id_grupos desc")
            contar.consulta.Read()
            If contar.consulta.HasRows Then
                id = contar.consulta.GetValue(0) + 1
            End If
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            Dim ingresar As New BD("INSERT INTO GRUPOSMUSCULARES VALUES('" & id & "','" & nombre & "','" _
                                   & descripcion & "','" & foto & "','" & tipo & "')")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Function modificarGrupos(ByVal id_grupos As Integer, ByVal nombre As String, ByVal descripcion As String, _
                             ByVal foto As String, ByVal tipo As String)
        Try
            Dim modificar As New BD("UPDATE GRUPOSMUSCULARES SET nombre='" & nombre & "', descripcion='" & descripcion & _
                                    "', imagen='" & foto & "', tipo='" & tipo & "' WHERE id_grupos=" & id_grupos)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function bajaGrupo(ByVal id_grupos As Integer)
        Try
            Dim consultarRelacion As New BD("SELECT * FROM ENTRENA WHERE id_grupos=" & id_grupos)
            If consultarRelacion.consulta.HasRows Then
                Dim borrar As New BD("DELETE FORM ENTRENA WHERE id_grupos=" & id_grupos)
            End If
            consultarRelacion.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            Dim borrar As New BD("DELETE FROM GRUPOSMUSCULARES WHERE id_grupos=" & id_grupos)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Function listarGrupos()
        Dim grupos() As String
        Dim cantidad As Integer = 0
        Try
            Dim contar As New BD("SELECT COUNT(*) FROM GRUPOSMUSCULARES")
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        If cantidad > 0 Then
            Try
                Dim consulta As New BD("SELECT nombre FROM GRUPOSMUSCULARES")
                ReDim grupos(cantidad - 1)
                Dim i As Integer = 0
                While consulta.consulta.Read()
                    grupos(i) = consulta.consulta.GetValue(0)
                    i += 1
                End While
                consulta.close()
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Else
            grupos = Nothing
        End If
        Return grupos
    End Function

    Function listarIDNombre()
        Dim grupos() As String
        Dim cantidad As Integer = 0
        Try
            Dim contar As New BD("SELECT COUNT(*) FROM GRUPOSMUSCULARES")
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        If cantidad > 0 Then
            Try
                Dim consulta As New BD("SELECT id_grupos,nombre FROM GRUPOSMUSCULARES")
                ReDim grupos(cantidad - 1)
                Dim i As Integer = 0
                Dim auxID As Integer
                Dim auxStr As String
                While consulta.consulta.Read()
                    auxID = consulta.consulta.GetValue(0)
                    auxStr = consulta.consulta.GetValue(1)
                    grupos(i) = auxID.ToString + " : " + auxStr
                    i += 1
                End While
                consulta.close()
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Else
            grupos = Nothing
        End If
        Return grupos
    End Function
    Function obtenerID(ByVal nombre As String)
        Try
            Dim id As Integer
            Dim consultar As New BD("SELECT id_grupos FROM GRUPOSMUSCULARES WHERE nombre='" & nombre & "'")
            consultar.consulta.Read()
            If consultar.consulta.HasRows Then
                id = consultar.consulta.GetValue(0)
            End If
            consultar.close()
            Return id
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Function yaExiste(ByVal nombre As String)
        Dim existe As Boolean
        Try
            Dim consulta As New BD("SELECT * FROM GRUPOSMUSCULARES WHERE nombre='" & nombre & "'")
            consulta.consulta.Read()
            If consulta.consulta.HasRows Then
                existe = True
            Else
                existe = False
            End If
            consulta.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        Return existe
    End Function
End Class
