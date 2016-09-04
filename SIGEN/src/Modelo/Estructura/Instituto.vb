Public Class Instituto
    Public rut As Long
    Public nombre, dCalle, email, web As String
    Public telefono(), dNumero As Integer
    Public dBis As Boolean
    Public actividades(), sectores(), usuarios() As String

    Dim f As New Fecha()

    Public msg As String

    Public Sub New(Optional ByVal rut As Long = -1)
        If rut >= 0 Then
            Try
                Dim consultar As New BD("SELECT nombre, dir_calle, dir_num, dir_bis, email, sitio_web FROM instituto where rut=" & rut)
                consultar.consulta.Read()
                If consultar.consulta.HasRows Then
                    Me.rut = rut
                    Me.nombre = consultar.consulta.GetValue(0)
                    Me.dCalle = consultar.consulta.GetValue(1)
                    Me.dNumero = consultar.consulta.GetValue(2)
                    Me.dBis = consultar.consulta.GetValue(3)
                    Me.email = consultar.consulta.GetValue(4)
                    Me.web = consultar.consulta.GetValue(5)
                    Me.consultarTelefono()
                    Me.actividades = Me.listarActividades(Me.rut)
                    Me.sectores = Me.listarSectores(Me.rut)
                    Me.usuarios = Me.listarUsuarios(Me.rut)
                Else
                    Me.msg = "NE"
                End If
                consultar.close()
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try
        End If
    End Sub
    Private Sub consultarTelefono()
        'Rellena el array telefono con todos los telefonos que tenga el usuario
        Try
            'Cuenta todos los telefonos que posee el usuario con un determinado documento
            Dim contar = New BD("SELECT COUNT(*) FROM telefono_instituto WHERE rut=" & rut)
            contar.consulta.Read()
            Dim cantidad As Integer = contar.consulta.GetValue(0) - 1
            'Ya que los arrays comienzan en 0, es necesario restarle 1 a la cantidad.
            contar.close()
            If cantidad >= 0 Then
                Dim consultar = New BD("SELECT telefono FROM TELEFONO_INSTITUTO WHERE RUT=" & rut)

                'controlamos que no este vacio
                If consultar.consulta.HasRows Then
                    'Redimencionamos el array telefono según la cantidad de telefonos que tenga el usuario
                    'ver variables contar y cantidad
                    ReDim Me.telefono(cantidad)


                    'Lee multiples una lista de valores
                    Dim i As Integer = 0
                    While consultar.consulta.Read()
                        Me.telefono(i) = consultar.consulta.GetValue(0)
                        i += 1
                    End While
                    consultar.close()
                End If
            Else
                'Controlamos el caso que no haya telefonos
                ReDim telefono(1)
                Me.telefono(0) = Nothing
            End If
        Catch ex As Exception
            'Se controlan los errores
            Me.msg = ex.ToString
        End Try
    End Sub

    Function ingresarTelefonos(ByVal rut As Long, ByVal telefonos() As Integer)
        For Each telefono As Integer In telefonos

            Try
                Dim ingresar = New BD("INSERT INTO TELEFONO_INSTITUTO VALUES('" & rut & "','" & telefono & "')")
            Catch ex As Exception
                Me.msg = ex.ToString
                Return -1
            End Try
        Next
        Return 0
    End Function
    Function modificarTelefono(ByVal rut As Long, ByVal tel() As Integer)
        Try
            Dim del = New BD("DELETE FROM TELEFONO_INSTITUTO WHERE RUT=" & rut)
            Me.ingresarTelefonos(rut, tel)
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Function ingresarInstituto(ByVal rut As Long, ByVal nombre As String, ByVal dCalle As String, _
                               ByVal dNumero As Integer, ByVal dBis As Boolean, ByVal email As String, _
                               ByVal web As String)
        Dim bis As Integer
        If dBis Then
            bis = 1
        Else
            bis = 0
        End If
        Dim sql As String
        sql = "INSERT INTO INSTITUTO VALUES('" & rut & "','" & nombre & "','" & dCalle & "','" & dNumero & "','" & bis & _
            "','" & email & "','" & web & "');"
        Try
            Dim ingresar As New BD(sql)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Function modificarInstituto(ByVal rut As Long, ByVal nombre As String, ByVal dCalle As String, _
                               ByVal dNumero As Integer, ByVal dBis As Boolean, ByVal email As String, _
                               ByVal web As String)
        Dim bis As Integer
        If dBis Then
            bis = 1
        Else
            bis = 0
        End If
        Dim sql As String
        sql = "UPDATE INSTITUTO SET NOMBRE='" & nombre & "', DIR_CALLE='" & dCalle & "', DIR_NUM='" & dNumero & "', DIR_BIS='" & bis & _
              "',EMAIL='" & email & "',SITIO_WEB='" & web & "' WHERE RUT='" & rut & "';"
        Try
            Dim modificar As New BD(sql)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function bajaInstituto(ByVal rut As Long)
        Try
            Dim consultarRelacion As New BD("SELECT * FROM PERTENECE WHERE rut=" & rut)
            If consultarRelacion.consulta.HasRows Then
                Dim borrar As New BD("DELETE FORM PERTENECE WHERE rut=" & rut)
            End If
            consultarRelacion.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            Dim consultarRelacion As New BD("SELECT * FROM SEREALIZANAS WHERE rut=" & rut)
            If consultarRelacion.consulta.HasRows Then
                Dim borrar As New BD("DELETE FORM SEREALIZANAS WHERE rut=" & rut)
            End If
            consultarRelacion.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            Dim consultarRelacion As New BD("SELECT * FROM SECTORES WHERE rut=" & rut)
            If consultarRelacion.consulta.HasRows Then
                Dim borrar As New BD("DELETE FORM SECTORES WHERE rut=" & rut)
            End If
            consultarRelacion.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            Dim borrar As New BD("DELETE FROM INSTITUTO WHERE rut=" & rut)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Function listarInstituto()
        Dim instituto() As String
        Dim cantidad As Integer = 0
        Try
            Dim contar As New BD("SELECT COUNT(*) FROM INSTITUTO")
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        If cantidad > 0 Then
            Try
                Dim consulta As New BD("SELECT nombre FROM INSTITUTO")
                ReDim instituto(cantidad - 1)
                Dim i As Integer = 0
                While consulta.consulta.Read()
                    instituto(i) = consulta.consulta.GetValue(0)
                    i += 1
                End While
                consulta.close()
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Else
            instituto = Nothing
        End If
        Return instituto
    End Function

    Function listarIDNombre()
        Dim instituto() As String
        Dim cantidad As Integer = 0
        Try
            Dim contar As New BD("SELECT COUNT(*) FROM INSTITUTO")
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        If cantidad > 0 Then
            Try
                Dim consulta As New BD("SELECT rut::varchar(12),nombre FROM INSTITUTO")
                ReDim instituto(cantidad - 1)
                Dim i As Integer = 0
                Dim auxId, auxStr As String
                While consulta.consulta.Read()
                    auxId = consulta.consulta.GetValue(0)
                    auxStr = consulta.consulta.GetValue(1)
                    instituto(i) = auxId.ToString + " : " + auxStr
                    i += 1
                End While
                consulta.close()
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Else
            instituto = Nothing
        End If
        Return instituto
    End Function

    Function yaExiste(ByVal rut As Long)
        Dim existe As Boolean
        Try
            Dim consulta As New BD("SELECT nombre FROM INSTITUTO WHERE rut='" & rut & "'")
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

    Function listarActividades(ByVal rut As Long)
        Dim actividades() As String
        Dim cantidad As Integer = 0
        Dim sql, sqlContar As String
        sql = "SELECT A.id_actividad, A.nombre FROM INSTITUTO I INNER JOIN SEREALIZANAS S ON I.RUT=S.RUT" & _
              " INNER JOIN ACTIVIDAD A ON A.id_actividad=S.id_actividad WHERE I.RUT='" & rut & "';"
        sqlContar = "SELECT COUNT(A.nombre) FROM INSTITUTO I INNER JOIN SEREALIZANAS S ON I.RUT=S.RUT" & _
                    " INNER JOIN ACTIVIDAD A ON A.id_actividad=S.id_actividad WHERE I.RUT='" & rut & _
                    "' GROUP BY A.id_actividad;"

        Try
            Dim contar As New BD(sqlContar)
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            If cantidad > 0 Then
                ReDim actividades(cantidad)

                Dim consulta As New BD(sql)
                Dim i As Integer = 0
                Dim auxId, auxNombre As String
                While consulta.consulta.Read()
                    auxId = consulta.consulta.GetValue(0)
                    auxNombre = consulta.consulta.GetValue(1)
                    actividades(i) = auxId + " : " + auxNombre
                    i += 1
                End While
                consulta.close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Return actividades
    End Function

    Function listarSectores(ByVal rut As Long)
        Dim sectores() As String
        Dim cantidad As Integer = 0
        Dim sql, sqlContar As String
        sql = "SELECT NRO_SECTOR,NOMBRE FROM SECTORES WHERE RUT='" & rut & "';"
        sqlContar = "SELECT COUNT(*) FROM SECTORES WHERE RUT='" & rut & "';"
        Try
            Dim contar As New BD(sqlContar)
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            If cantidad > 0 Then
                ReDim sectores(cantidad)

                Dim consulta As New BD(sql)
                Dim i As Integer = 0
                Dim auxId, auxNombre As String
                While consulta.consulta.Read()
                    auxId = consulta.consulta.GetValue(0)
                    auxNombre = consulta.consulta.GetValue(1)
                    sectores(i) = auxId + " : " + auxNombre
                    i += 1
                End While
                consulta.close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Return sectores
    End Function

    Function listarUsuarios(ByVal rut As Long)
        Dim usuarios() As String
        Dim cantidad As Integer = 0
        Dim sql, sqlContar As String
        sql = "SELECT U.documento, U.primernombre, U.primerapellido FROM PERTENECE I " & _
              "INNER JOIN USUARIO U ON U.documento=I.documento WHERE I.rut='" & rut & "';"
        sqlContar = "SELECT COUNT(*) FROM PERTENECE I INNER JOIN USUARIO U ON U.documento=I.documento WHERE I.rut='" & _
                    rut & "';"
        Try
            Dim contar As New BD(sqlContar)
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            If cantidad > 0 Then
                ReDim usuarios(cantidad)

                Dim consulta As New BD(sql)
                Dim i As Integer = 0
                Dim auxId, auxNombre, auxApellido As String
                While consulta.consulta.Read()
                    auxId = consulta.consulta.GetValue(0)
                    auxNombre = consulta.consulta.GetValue(1)
                    usuarios(i) = auxId + " : " + auxApellido + ", " + auxNombre
                    i += 1
                End While
                consulta.close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Return usuarios
    End Function

    Function pertenece(ByVal documento As Integer)
        Dim sql As String
        sql = "INSERT INTO PERTENECE(rut,documento,fecha_inicio) VALUES('" & Me.rut & "','" & documento & "','" & _
              f.fecha2informix(Now) & "');"
        Try
            Dim insertar As New BD(sql)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try

    End Function
    Function modificarPertenece(ByVal documento As Integer)
        Dim sql As String
        sql = "DELETE FROM PERTENECE WHERE documento='" & documento & "';"
        Try
            Dim borrar As New BD(sql)
            Me.pertenece(documento)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try

    End Function
End Class
