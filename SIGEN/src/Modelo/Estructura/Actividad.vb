Public Class Actividad
    Public id_actividad As Integer
    Public nombre, descripcion, imagen As String
    Public msg As String

    Dim realizan As New Realiza()
    Public deportistas() As Deportista

    Public Sub New(Optional ByVal id As Integer = -1)
        If id >= 0 Then
            Try
                Dim actividad = New BD("SELECT nombre,descripcion,imagen FROM ACTIVIDAD WHERE id_actividad='" & id & "'")
                actividad.consulta.Read()
                If actividad.consulta.HasRows Then
                    Me.id_actividad = id
                    Me.nombre = actividad.consulta.GetValue(0)
                    Me.descripcion = actividad.consulta.GetValue(1)
                    If actividad.consulta.IsDBNull(2) Then
                        Me.imagen = Nothing
                    Else
                        Me.imagen = actividad.consulta.GetValue(2)
                    End If
                    Me.deportistas = realizan.listarDeportistas(id)
                Else
                    Me.msg = "NE"
                End If
                actividad.close()
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try
        End If
    End Sub

    Function ingresarActividad(ByVal nombre As String, ByVal descripcion As String, Optional ByVal imagen As String = Nothing)
        Dim id_actividad As Integer = 0
        Try
            'Consulta el último número de actividad que se halla ingresado con el fin de que sea autoincremental
            Dim consultar = New BD("SELECT id_actividad FROM ACTIVIDAD ORDER BY id_actividad DESC")
            consultar.consulta.Read()
            If consultar.consulta.HasRows Then
                id_actividad = consultar.consulta.GetValue(0) + 1
            End If
            consultar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        Try
            If imagen Is Nothing Then
                Dim insertar = New BD("INSERT INTO ACTIVIDAD(id_actividad,nombre,descripcion) VALUES('" _
                                      & id_actividad & "','" & nombre & "','" & descripcion & "')")
                Return 0
            Else
                Dim insertar = New BD("INSERT INTO ACTIVIDAD VALUES('" & id_actividad & "','" & nombre & "','" & descripcion _
                                 & "','" & imagen & "')")
                Return 0
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function modificarActividad(ByVal id_actividad As Integer, Optional ByVal nombre As String = Nothing, _
                                Optional ByVal descripcion As String = Nothing, Optional ByVal imagen As String = Nothing)
        If nombre Is Nothing Then
            nombre = Me.nombre
        End If
        If descripcion Is Nothing Then
            descripcion = Me.descripcion
        End If
        If imagen Is Nothing Then
            imagen = Me.imagen
        End If
        Try
            If imagen Is Nothing Then
                Dim modificar = New BD("UPDATE ACTIVIDAD SET nombre = '" & nombre & "', descripcion = '" & descripcion & _
                                       "' WHERE id_actividad = " & id_actividad)
                Return 0
            Else
                Dim modificar = New BD("UPDATE ACTIVIDAD SET nombre = '" & nombre & "', descripcion = '" & descripcion & _
                                        "', imagen ='" & imagen & "' WHERE id_actividad = " & id_actividad)
                Return 0
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function bajaActividad(ByVal id_actividad As Integer)
        Try

            Dim relacion0 = New BD("DELETE FROM EQUIPOS WHERE actividad=" & id_actividad)
            Dim relacion1 = New BD("DELETE FROM REALIZAN WHERE id_actividad=" & id_actividad)
            Dim relacion2 = New BD("DELETE FROM SEREALIZANAS WHERE id_actividad=" & id_actividad)
            Dim eliminar = New BD("DELETE FROM ACTIVIDAD WHERE id_actividad=" & id_actividad)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function listar()
        Dim actividad() As String
        Dim cantidad As Integer
        Try
            Dim contar = New BD("SELECT COUNT(*) FROM ACTIVIDAD")
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
            If cantidad >= 1 Then
                ReDim actividad(cantidad - 1)
                Dim lista = New BD("SELECT id_actividad, nombre FROM ACTIVIDAD")
                Dim i As Integer = 0
                Dim id As Integer
                Dim nombre As String
                While lista.consulta.Read()
                    id = lista.consulta.GetValue(0)
                    nombre = lista.consulta.GetValue(1)
                    actividad(i) = id.ToString + " : " + Trim(nombre)
                    i += 1
                End While
                lista.close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        Return actividad
    End Function

    Function listarDeportistas(ByVal id_actividad As Integer)
        Dim sql, deportistas() As String
        sql = "SELECT documento,primerapellido,primernombre FROM USUARIO WHERE documento in " & _
        "(SELECT documento FROM REALIZAN WHERE id_actividad='" & id_actividad & "');"
        Try
            Dim cantidad As Integer
            Dim contar As New BD("SELECT COUNT(*) FROM REALIZAN WHERE id_actividad='" & id_actividad & "';")
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()

            ReDim deportistas(cantidad - 1)
            Dim lista As New BD(sql)
            Dim i As Integer = 0
            Dim documento As Integer
            Dim nombre, apellido As String
            If lista.consulta.HasRows Then
                While lista.consulta.Read()
                    documento = lista.consulta.GetValue(0)
                    apellido = lista.consulta.GetValue(1)
                    nombre = lista.consulta.GetValue(2)
                    deportistas(i) = documento.ToString + " : " + Trim(apellido) + ", " + Trim(nombre)
                    i += 1
                End While
            Else
                deportistas = Nothing
            End If
           

            lista.close()
            Return deportistas

        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function listarEntrenadores(ByVal id_actividad As Integer)
        Dim sql, sqlContar, entrenadores() As String
        Dim cantidad As Integer
        sql = "SELECT documento,primerapellido,primernombre FROM USUARIO WHERE documento IN " & _
        "(SELECT documento_entrenador FROM EVOLUCION WHERE documento_deportista IN " & _
        "(SELECT documento FROM REALIZAN WHERE id_actividad='" & id_actividad & "'));"
        sqlContar = "SELECT COUNT(*) FROM USUARIO WHERE documento IN " & _
        "(SELECT documento_entrenador FROM EVOLUCION WHERE documento_deportista IN " & _
        "(SELECT documento FROM REALIZAN WHERE id_actividad='" & id_actividad & "'));"
        Try
            Dim contar As New BD(sqlContar)
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()

            ReDim entrenadores(cantidad - 1)

            Dim documento As Integer
            Dim apellido, nombre As String
            Dim i As Integer = 0
            Dim realizan As New BD(sql)
            If realizan.consulta.HasRows Then
                While realizan.consulta.Read()
                    documento = realizan.consulta.GetValue(0)
                    apellido = realizan.consulta.GetValue(1)
                    nombre = realizan.consulta.GetValue(2)
                    entrenadores(i) = documento.ToString + " : " + Trim(apellido) + ", " + Trim(nombre)
                    i += 1
                End While
            Else
                entrenadores = Nothing
            End If
            realizan.close()
            Return entrenadores
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1

        End Try
    End Function

    Function listarSectores(ByVal id_actividad As Integer)
        Dim sql, sqlContar, sectores() As String
        Dim cantidad As Integer
        sql = "SELECT RUT::varchar(12),nro_sector,nombre FROM SECTORES WHERE RUT IN (SELECT RUT FROM SEREALIZANAS WHERE id_actividad='" & id_actividad & _
        "') AND nro_sector IN (SELECT nro_sector FROM SEREALIZANAS WHERE id_actividad='" & id_actividad & "');"

        sqlContar = "SELECT COUNT(*) FROM SEREALIZANAS WHERE id_actividad=" & id_actividad

        Try
            Dim contar As New BD(sqlContar)
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()

            ReDim sectores(cantidad - 1)

            Dim lista As New BD(sql)
            If lista.consulta.HasRows Then
                Dim nombre As String
                Dim rut As Long
                Dim nro As Integer
                Dim i As Integer = 0
                While lista.consulta.Read()
                    rut = lista.consulta.GetValue(0)
                    nro = lista.consulta.GetValue(1)
                    nombre = lista.consulta.GetValue(2)
                    sectores(i) = rut.ToString + "," + nro.ToString + " : " + Trim(nombre)
                End While
            Else
                sectores = Nothing
            End If
            lista.close()

            Return sectores
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function
    Function yaExiste(ByVal nombre As String)
        Dim existe As Boolean
        Try
            Dim consulta As New BD("SELECT * FROM ACTIVIDAD WHERE nombre='" & nombre & "'")
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
    Function obtenerID(ByVal nombre As String)
        If Char.IsDigit(CChar(nombre)) Then
            Dim auxID As String = ""

            For Each c As Char In nombre
                If c = ":" Then
                    Exit For
                Else
                    auxID += c
                End If
            Next

            Return CInt(Trim(auxID))
        Else
            Try
                Dim id As Integer
                Dim consultar As New BD("SELECT id_actividad FROM ACTIVIDAD WHERE nombre='" & nombre & "'")
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
        End If
    End Function
End Class
