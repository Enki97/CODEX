Public Class Deportista
    Inherits Usuario
    Public nroSocio As Integer
    Public altura As Integer
    Public peso As Integer
    Public venFichaMedica As Date
    Public criterio As String
    Public imc As Integer
    Public somatotipo As String
    Public alergias() As String
    Public medicamentos() As String
    Public vacunas() As String
    Public operaciones() As String

    'Conversiones de fecha
    Dim f As New Fecha()
    'Relaciones
    Public evolucion As Evolucion
    Public entrenador As Entrenador
    Public realiza As Realiza

    Public Sub New(Optional ByVal documento As Integer = Nothing)
        MyBase.New(documento)
        If Not documento = Nothing Then
            Try
                Dim deportista As New BD("SELECT * FROM deportista WHERE documento=" & documento)
                deportista.consulta.Read()
                If deportista.consulta.HasRows Then
                    Me.nroSocio = deportista.consulta.GetValue(1)
                    Me.altura = deportista.consulta.GetValue(2)
                    Me.peso = deportista.consulta.GetValue(3)
                    Me.venFichaMedica = f.fecha2vb(deportista.consulta.GetValue(4))
                    Me.criterio = deportista.consulta.GetValue(5)
                    Me.imc = deportista.consulta.GetValue(6)
                    Me.somatotipo = deportista.consulta.GetValue(7)
                    Me.cAlergias(documento)
                    Me.cMedicamentos(documento)
                    Me.cVacunas(documento)
                    Me.cOperaciones(documento)
                    Me.obtenerEvolucion()
                    Me.obtenerActividad()
                Else
                    Me.msg = "No existe el usuario"
                End If
                deportista.close()
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try

        Else
            Me.nroSocio = Nothing
            Me.altura = Nothing
            Me.peso = Nothing
            Me.venFichaMedica = Nothing
            Me.criterio = Nothing
            Me.imc = Nothing
            Me.somatotipo = Nothing
            Me.evolucion = Nothing
            Me.entrenador = Nothing
        End If
    End Sub

    Function registrarDeportista(ByVal documento As Integer, ByVal altura As Integer, ByVal peso As Integer, ByVal vFicha As Date, ByVal criterio As String, ByVal somatotipo As String)
        Dim nroSocio As Integer = 0
        Dim alt As Decimal = altura / 100
        Dim a As Decimal = alt * alt
        Dim indicemasacorporal As Decimal = CDec(peso) / a


        Try
            Dim consultar = New BD("SELECT nro_socio FROM deportista ORDER BY nro_socio DESC")
            consultar.consulta.Read()
            If consultar.consulta.HasRows Then
                nroSocio = consultar.consulta.GetValue(0) + 1
            End If
            consultar.close()

        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
        Try
            Dim insertar = New BD("INSERT INTO deportista VALUES('" & documento & "','" & nroSocio & "','" & altura & "','" & _
                             peso & "','" & f.fecha2informix(vFicha) & "','" & criterio & "','" & CInt(indicemasacorporal) & "','" & somatotipo & "')")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function

    Function modificarDeportista(ByVal documento As Integer, ByVal altura As Integer, ByVal peso As Integer, ByVal vFicha As Date, ByVal criterio As String, ByVal somatotipo As String)
       Dim alt As Decimal = altura / 100
        Dim a As Decimal = alt * alt
        Dim indicemasacorporal As Decimal = CDec(peso) / a

        Try
            Dim modificar = New BD("UPDATE DEPORTISTA SET altura='" & altura & "',peso='" & peso & "',venfichamedica='" & _
                                   f.fecha2informix(vFicha) & "',criterio='" & criterio & "',imc='" & _
                                   CInt(indicemasacorporal) & "',somatotipo='" & somatotipo & "' WHERE DOCUMENTO='" & _
                                   documento & "';")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function


    Private Sub cAlergias(ByVal documento As Integer)
        Dim cantidad As Integer = 0
        'Rellena el array telefono con todos los telefonos que tenga el usuario
        Try
            'Cuenta todos los telefonos que posee el usuario con un determinado documento
            Dim contar = New BD("SELECT COUNT(*) FROM alergias WHERE documento=" & documento)
            If contar.consulta.HasRows Then
                cantidad = contar.consulta.GetValue(0) - 1
                'Ya que los arrays comienzan en 0, es necesario restarle 1 a la cantidad.
            End If
            contar.close()
            Dim consultar = New BD("SELECT alergias FROM alergias WHERE documento=" & documento)

            'controlamos que no este vacio
            If consultar.consulta.HasRows Then
                'Redimencionamos el array telefono según la cantidad de telefonos que tenga el usuario
                'ver variables contar y cantidad
                ReDim Me.alergias(cantidad)

                'Lee multiples una lista de valores
                Dim i As Integer = 0
                While consultar.consulta.Read()
                    Me.alergias(i) = consultar.consulta.GetValue(0)
                    i += 1
                End While
                consultar.close()
            Else
                'Si esta vacio da un mensaje y iguala el indice 0 de telefono a Nothing
                'esto se hace para que desde una clase externa si se sabe que el indice de
                '0 es Nothing no muestre ningún telefono
                Me.msg = "No tiene alergias"
                Me.medicamentos(0) = Nothing
            End If
        Catch ex As Exception
            'Se controlan los errores
            Me.msg = ex.ToString
        End Try
    End Sub

    Function ingresarAlergias(ByVal documento As Integer, ByVal alergias() As String)
        For Each alergia As String In alergias
            Try
                Dim insertar = New BD("INSERT INTO alergias VALUES('" & documento & "','" & alergia & "')")
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Next
        Return 0
    End Function
    Function modificarAlergias(ByVal documento As Integer, ByVal alergias() As String)
        Try
            Dim del = New BD("DELETE FROM Alergias WHERE documento=" & documento)
            Me.ingresarAlergias(documento, alergias)
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function
    Private Sub cMedicamentos(ByVal documento As Integer)
        Dim cantidad As Integer = 0

        'Rellena el array telefono con todos los telefonos que tenga el usuario
        Try
            'Cuenta todos los telefonos que posee el usuario con un determinado documento
            Dim contar = New BD("SELECT COUNT(*) FROM medicamentos WHERE documento=" & documento)
            If contar.consulta.HasRows Then
                cantidad = contar.consulta.GetValue(0) - 1
                'Ya que los arrays comienzan en 0, es necesario restarle 1 a la cantidad.
            End If
            contar.close()
            Dim consultar = New BD("SELECT medicamentos FROM medicamentos WHERE documento=" & documento)

            'controlamos que no este vacio
            If consultar.consulta.HasRows Then
                'Redimencionamos el array telefono según la cantidad de telefonos que tenga el usuario
                'ver variables contar y cantidad
                ReDim Me.medicamentos(cantidad)

                'Lee multiples una lista de valores
                Dim i As Integer = 0
                While consultar.consulta.Read()
                    Me.medicamentos(i) = consultar.consulta.GetValue(0)
                    i += 1
                End While
                consultar.close()
            Else
                Me.msg = "No tiene medicamentos"
                Me.medicamentos = Nothing
            End If
        Catch ex As Exception
            'Se controlan los errores
            Me.msg = ex.ToString
        End Try
    End Sub
    Function ingresarMedicamentos(ByVal documento As Integer, ByVal medicamentos() As String)
        For Each medicamento As String In medicamentos
            Try
                Dim insertar = New BD("INSERT INTO medicamentos VALUES('" & documento & "','" & medicamento & "')")
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Next
        Return 0
    End Function
    Function modificarMedicamentos(ByVal documento As Integer, ByVal medicamentos() As String)
        Try
            Dim del = New BD("DELETE FROM medicamentos WHERE documento=" & documento)
            Me.ingresarMedicamentos(documento, medicamentos)
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Private Sub cVacunas(ByVal documento As Integer)
        Dim cantidad As Integer = 0
        'Rellena el array telefono con todos los telefonos que tenga el usuario
        Try
            'Cuenta todos los telefonos que posee el usuario con un determinado documento
            Dim contar = New BD("SELECT COUNT(*) FROM vacunas WHERE documento=" & documento)
            If contar.consulta.HasRows Then
                cantidad = contar.consulta.GetValue(0) - 1
                'Ya que los arrays comienzan en 0, es necesario restarle 1 a la cantidad.
            End If
            'Ya que los arrays comienzan en 0, es necesario restarle 1 a la cantidad.
            contar.close()
            Dim consultar = New BD("SELECT vacunas FROM vacunas WHERE documento=" & documento)

            'controlamos que no este vacio
            If consultar.consulta.HasRows Then
                'Redimencionamos el array telefono según la cantidad de telefonos que tenga el usuario
                'ver variables contar y cantidad
                ReDim Me.vacunas(cantidad)
                'Lee multiples una lista de valores
                Dim i As Integer = 0
                While consultar.consulta.Read()
                    Me.vacunas(i) = consultar.consulta.GetValue(0)
                    i += 1
                End While
                consultar.close()
            Else
                Me.msg = "No tiene vacunas"
                Me.vacunas = Nothing
            End If

        Catch ex As Exception
            'Se controlan los errores
            Me.msg = ex.ToString
        End Try
    End Sub
    Function ingresarVacunas(ByVal documento As Integer, ByVal vacunas() As String)
        For Each vacuna As String In vacunas
            Try
                Dim insertar = New BD("INSERT INTO vacunas VALUES('" & documento & "','" & vacuna & "')")
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Next
        Return 0
    End Function
    Function modificarVacunas(ByVal documento As Integer, ByVal vacunas() As String)
        Try
            Dim del = New BD("DELETE FROM vacunas WHERE documento=" & documento)
            Me.ingresarVacunas(documento, vacunas)
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Private Sub cOperaciones(ByVal documento As Integer)
        'Rellena el array telefono con todos los telefonos que tenga el usuario
        Dim cantidad As Integer = 0
        Try
            'Cuenta todos los telefonos que posee el usuario con un determinado documento
            Dim contar = New BD("SELECT COUNT(*) FROM operaciones WHERE documento=" & documento)
            If contar.consulta.HasRows Then
                cantidad = contar.consulta.GetValue(0) - 1
                'Ya que los arrays comienzan en 0, es necesario restarle 1 a la cantidad.
            End If
            contar.close()
            Dim consultar = New BD("SELECT operaciones FROM operaciones WHERE documento=" & documento)

            'controlamos que no este vacio
            If consultar.consulta.HasRows Then
                'Redimencionamos el array telefono según la cantidad de telefonos que tenga el usuario
                'ver variables contar y cantidad
                ReDim Me.operaciones(cantidad)

                'Lee multiples una lista de valores
                Dim i As Integer = 0
                While consultar.consulta.Read()
                    Me.operaciones(i) = consultar.consulta.GetValue(0)
                    i += 1
                End While
                consultar.close()
            Else
                Me.msg = "No tiene operaciones"
                Me.operaciones = Nothing
            End If
        Catch ex As Exception
            'Se controlan los errores
            Me.msg = ex.ToString
        End Try
    End Sub
    Function ingresarOperaciones(ByVal documento As Integer, ByVal operaciones() As String)
        For Each operacion As String In operaciones
            Try
                Dim insertar = New BD("INSERT INTO operaciones VALUES('" & documento & "','" & operacion & "')")
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Next
        Return 0
    End Function
    Function modificarOperaciones(ByVal documento As Integer, ByVal operaciones() As String)
        Try
            Dim del = New BD("DELETE FROM operaciones WHERE documento=" & documento)
            Me.ingresarOperaciones(documento, operaciones)
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function
    Sub obtenerEvolucion()
        Dim obtenerEntrenador As New Evolucion(Me)
        Me.entrenador = obtenerEntrenador.entrenador
        If Not Me.entrenador Is Nothing Then
            Me.evolucion = New Evolucion(Me, Me.entrenador)
        End If
    End Sub

    Sub obtenerActividad()
        Me.realiza = New Realiza(Me.documento)
    End Sub

    Function tienePlanes()
        Try
            Dim consutla As New BD("SELECT COUNT(*) FROM cumple WHERE documento=" & Me.documento)
            consutla.consulta.Read()
            Dim cantidad As Integer = consutla.consulta.GetValue(0)
            consutla.close()
            If cantidad = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Function tieneCalificacion()
        Try
            Dim consutla As New BD("SELECT COUNT(*) FROM EVOLUCION WHERE documento_deportista=" & Me.documento)
            consutla.consulta.Read()
            Dim cantidad As Integer = consutla.consulta.GetValue(0)
            consutla.close()
            If cantidad = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function


    Function ultimoPlan()
        Dim id As Integer
        Try
            Dim sql As String
            sql = "SELECT id_planes FROM PLANESENTRENAMIENTO WHERE id_planes in (SELECT id_planes FROM CUMPLE " & _
            "WHERE documento=" & Me.documento & ") ORDER BY id_planes DESC"

            Dim consulta As New BD(sql)
            consulta.consulta.Read()
            id = consulta.consulta.GetValue(0)
            consulta.close()
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
        Return id
    End Function
End Class
