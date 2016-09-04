Public Class Sectores
    Public rut As Long
    Public nombre, instituto, actividades() As String
    Public nro_sector As Integer

    Public msg As String

    Public Sub New(Optional ByVal rut As Long = -1, Optional ByVal nro_sector As Integer = -1)
        If rut >= 0 And nro_sector >= 0 Then
            Try
                Dim consultar As New BD("SELECT nombre FROM sectores where rut='" & rut & "' AND nro_sector='" & nro_sector & "';")
                consultar.consulta.Read()
                If consultar.consulta.HasRows Then
                    Me.rut = rut
                    Me.nro_sector = nro_sector
                    Me.nombre = consultar.consulta.GetValue(0)
                    Me.consultarInstituto()
                    Me.consultarActividades()
                Else
                    Me.msg = "NE"
                End If
                consultar.close()
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try
        End If
    End Sub

    Sub consultarInstituto()
        Dim sql As String = "SELECT NOMBRE FROM INSTITUTO WHERE RUT='" & Me.rut & "';"
        Try
            Dim consultar As New BD(sql)
            consultar.consulta.Read()
            Me.instituto = consultar.consulta.GetValue(0)
            consultar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
        End Try
    End Sub
    Function ingresarSector(ByVal rut As Long, ByVal nro_sector As Integer, ByVal nombre As String)
        Dim sql As String
        sql = "INSERT INTO SECTORES VALUES('" & rut & "','" & nro_sector & "','" & nombre & "');"
        Try
            Dim ingresar As New BD(sql)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Function modificarSectores(ByVal rut As Long, ByVal nro_sector As Integer, ByVal nombre As String)
        Dim sql As String
        sql = "UPDATE SECTORES SET NOMBRE='" & nombre & "' WHERE RUT='" & rut & "' AND nro_sector='" & nro_sector & "';"
        Try
            Dim modificar As New BD(sql)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function bajaSectores(ByVal rut As Long, ByVal nro_sector As Integer)
        Try
            Dim consultarRelacion As New BD("SELECT * FROM SEREALIZANAS WHERE rut='" & rut & "' AND nro_sector='" & nro_sector & "';")
            If consultarRelacion.consulta.HasRows Then
                Dim borrar As New BD("DELETE FORM SEREALIZANAS WHERE rut='" & rut & "' AND nro_sector='" & nro_sector & "';")
            End If
            consultarRelacion.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Try
            Dim consultarRelacion As New BD("SELECT * FROM SECTORES WHERE rut='" & rut & "' AND nro_sector='" & nro_sector & "';")
            If consultarRelacion.consulta.HasRows Then
                Dim borrar As New BD("DELETE FORM SECTORES WHERE rut='" & rut & "' AND nro_sector='" & nro_sector & "';")
            End If
            consultarRelacion.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Return 0
    End Function

    Function listarSectores()
        Dim sectores() As String
        Dim cantidad As Integer = 0
        Try
            Dim contar As New BD("SELECT COUNT(*) FROM SECTORES")
            contar.consulta.Read()
            cantidad = contar.consulta.GetValue(0)
            contar.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        If cantidad > 0 Then
            Try
                Dim consulta As New BD("SELECT rut::varchar(12),nro_sector,nombre FROM SECTORES")
                ReDim sectores(cantidad - 1)
                Dim i As Integer = 0
                Dim auxNro As Integer
                Dim auxStr, auxRut As String
                While consulta.consulta.Read()
                    auxRut = consulta.consulta.GetValue(0)
                    auxNro = consulta.consulta.GetValue(1)
                    auxStr = consulta.consulta.GetValue(2)
                    sectores(i) = auxRut + "(" + auxNro.ToString + ")" + " : " + auxStr
                    i += 1
                End While
                consulta.close()
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Else
            sectores = Nothing
        End If
        Return sectores
    End Function

    Private Sub consultarActividades()
        Dim sql, sqlContar As String
        sql = "SELECT A.id_actividad, A.nombre FROM SEREALIZANAS S INNER JOIN ACTIVIDAD A ON S.id_actividad=A.id_actividad " & _
              "WHERE rut='" & Me.rut & "' AND nro_sector='" & Me.nro_sector & "';"
        sqlContar = "SELECT COUNT(A.id_actividad) FROM SEREALIZANAS S INNER JOIN ACTIVIDAD A ON S.id_actividad=A.id_actividad " & _
                    "WHERE rut='" & Me.rut & "' AND nro_sector='" & Me.nro_sector & "';"

        Try
            Dim contar = New BD(sqlContar)
            contar.consulta.Read()
            Dim cantidad As Integer = contar.consulta.GetValue(0) - 1
            'Ya que los arrays comienzan en 0, es necesario restarle 1 a la cantidad.
            contar.close()
            If cantidad >= 0 Then
                Dim consultar = New BD(sql)

                'controlamos que no este vacio
                If consultar.consulta.HasRows Then
                    ReDim Me.actividades(cantidad)


                    'Lee multiples una lista de valores
                    Dim i As Integer = 0
                    Dim auxID As Integer
                    Dim auxStr As String
                    While consultar.consulta.Read()
                        auxID = consultar.consulta.GetValue(0)
                        auxStr = consultar.consulta.GetValue(1)
                        Me.actividades(i) = auxID.ToString + " : " + auxStr
                        i += 1
                    End While
                    consultar.close()
                End If
            Else
                Me.actividades = Nothing
            End If
        Catch ex As Exception
            'Se controlan los errores
            Me.msg = ex.ToString
        End Try
    End Sub

    Function ingresarActividades(ByVal rut As Long, ByVal nro_sector As Integer, ByVal actividades() As Integer)
        For Each actividad As Integer In actividades

            Try
                Dim ingresar = New BD("INSERT INTO SEREALIZANAS VALUES('" & rut & "','" & nro_sector & "','" & actividad & "');")
            Catch ex As Exception
                Me.msg = ex.ToString
                Return -1
            End Try
        Next
        Return 0
    End Function
    Function modificarActividades(ByVal rut As Long, ByVal nro_sector As Integer, ByVal actividades() As Integer)
        Try
            Dim del = New BD("DELETE FROM SEREALIZANAS WHERE rut='" & rut & "' AND nro_sector='" & nro_sector & "';")
            Me.ingresarActividades(rut, nro_sector, actividades)
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Function listarActividades(ByVal rut As Long, ByVal nro_sector As Integer)
        Dim actividades() As String
        Dim cantidad As Integer = 0
        Dim sql, sqlContar As String
        sql = "SELECT A.id_actividad, A.nombre FROM SEREALIZANAS S INNER JOIN ACTIVIDAD A ON S.id_actividad=A.id_actividad" & _
              " WHERE S.RUT='" & rut & "' AND S.nro_sector='" & nro_sector & "';"
        sql = "SELECT COUNT(A.id_actividad) FROM SEREALIZANAS S INNER JOIN ACTIVIDAD A ON S.id_actividad=A.id_actividad" & _
              " WHERE S.RUT='" & rut & "' AND S.nro_sector='" & nro_sector & "';"

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
    Function yaExiste(ByVal rut As Long, ByVal nro_sector As Integer)
        Dim existe As Boolean
        Try
            Dim consulta As New BD("SELECT nombre FROM SECTORES WHERE rut='" & rut & "' AND nro_sector='" & nro_sector & "';")
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
