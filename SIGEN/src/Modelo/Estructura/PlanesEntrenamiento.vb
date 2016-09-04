Imports SIGEN.Fecha

Public Class PlanesEntrenamiento
    'Variables de clase (atributos)
    Public id_planes As Integer
    Public nombre, descripcion, fase As String
    Public fecha_desde, fecha_hasta As Date

    'Relacion ejercicios
    Public ejSesion(), ejModo() As String
    Public ejCantidad(), ejKcal(), ejCarga(), ejRepeticiones(), ejID() As Integer
    Public ejercicios() As String

    'Relacion combos
    Public comSesion(), comModo() As String
    Public comCantidad(), comKcal(), comCarga(), comRepeticiones(), comID() As Integer
    Public combos() As String

    'Conversiones de fecha
    Dim f As New Fecha()

    'Variable utilizada para debug (pruebas)
    Public msg

    Public Sub New(Optional ByVal id_planes As Integer = -1)
        'Si se quiere inicializar vacio toma por defecto -1
        'Por tanto si es mayor a -1 (id >= 0) es porque se necesita llenar datos
        If id_planes >= 0 Then
            Try
                'Intenta realizar la consulta en el id que se le pasa
                Dim consulta As New BD("SELECT * FROM PLANESENTRENAMIENTO WHERE id_planes=" & id_planes)

                'Lee la consulta
                consulta.consulta.Read()

                Me.id_planes = id_planes
                'Si tiene datos
                If consulta.consulta.HasRows Then
                    'Llena las variables de clase con los datos consultados
                    'en la base de datos
                    Me.id_planes = consulta.consulta.GetValue(0)
                    Me.nombre = consulta.consulta.GetValue(1)
                    Me.descripcion = consulta.consulta.GetValue(2)
                    Me.fase = consulta.consulta.GetValue(3)
                    Me.fecha_desde = f.fecha2vb(consulta.consulta.GetValue(4))
                    Me.fecha_hasta = f.fecha2vb(consulta.consulta.GetValue(5))

                    'Llamada a un metodo de esta clase
                    Me.consultarEjercicios()
                    Me.consultarCombos()
                Else
                    Me.msg = "NE"
                End If
                'Cerramos la consulta
                consulta.close()
            Catch ex As Exception
                'Obtenemos el error y lo pasamos en la variable de debug
                Me.msg = ex.ToString
            End Try
        End If
    End Sub

    'Metodo privado
    'Un metodo privado es aquel que solo puede ser utilizado por la clase
    Private Sub consultarCombos()
        Try
            'Se crea una variable cantidad para obtener el numero de entidades que
            'cumplen con la condicion.
            Dim cantidad = 0
            'Contamos cuantas instancias en la base de datos cumplen con la condicion
            Dim contar As New BD("SELECT COUNT(*) FROM PLA_COM WHERE id_planes=" & Me.id_planes)
            'Ejecutamos la consulta
            contar.consulta.Read()
            'Obtenemos el valor de la consulta
            cantidad = contar.consulta.GetValue(0)
            'Cerramos la consulta
            contar.close()
            'Redimensionamos el vector según la cantidad de entidades que cumplen con la condicion
            ReDim Me.combos(cantidad)
            ReDim Me.comID(cantidad)
            'Obtenemos cuales son los datos que se relacionan
            Dim combo As New BD("SELECT id_combo, nombre FROM COMBOS WHERE id_combo in (SELECT id_combo FROM PLA_COM WHERE id_planes='" & id_planes & "')")
            Dim i As Integer = 0
            'Leemos todas las columnas obtenidas
            While combo.consulta.Read()
                'Llenamos el vector con los valores de la consulta
                Me.comID(i) = combo.consulta.GetValue(0)
                Me.combos(i) = combo.consulta.GetValue(1)
                i += 1
            End While
            'Cerramos la consulta
            combo.close()

            ReDim Me.comSesion(cantidad)
            ReDim Me.comCantidad(cantidad)
            ReDim Me.comKcal(cantidad)
            ReDim Me.comCarga(cantidad)
            ReDim Me.comRepeticiones(cantidad)
            ReDim Me.comModo(cantidad)

            Dim relacion As New BD("SELECT sesion,cantidad,kcal_quemadas,carga,repeticiones,modo FROM PLA_COM WHERE id_planes='" & _
                                   id_planes & "' ORDER BY id_combo ASC")
            Dim j As Integer = 0
            While relacion.consulta.Read()
                Me.comSesion(j) = relacion.consulta.GetValue(0)
                Me.comCantidad(j) = relacion.consulta.GetValue(1)
                Me.comKcal(j) = relacion.consulta.GetValue(2)
                Me.comCarga(j) = relacion.consulta.GetValue(3)
                Me.comRepeticiones(j) = relacion.consulta.GetValue(4)
                Me.comModo(j) = relacion.consulta.GetValue(5)
                j += 1
            End While
        Catch ex As Exception
            'Capturamos el error en la variable de debug
            Me.msg = ex.ToString
        End Try
    End Sub
    'Metodo privado
    'Un metodo privado es aquel que solo puede ser utilizado por la clase
    Private Sub consultarEjercicios()
        Try
            'Se crea una variable cantidad para obtener el numero de entidades que
            'cumplen con la condicion.
            Dim cantidad = 0
            'Contamos cuantas instancias en la base de datos cumplen con la condicion
            Dim contar As New BD("SELECT COUNT(*) FROM PLA_EJ WHERE id_planes=" & Me.id_planes)
            'Ejecutamos la consulta
            contar.consulta.Read()
            'Obtenemos el valor de la consulta
            cantidad = contar.consulta.GetValue(0)
            'Cerramos la consulta
            contar.close()

            'Redimensionamos el vector según la cantidad de entidades que cumplen con la condicion
            ReDim Me.ejercicios(cantidad)
            ReDim Me.ejID(cantidad)
            'Obtenemos cuales son los datos que se relacionan
            Dim ejercicio As New BD("SELECT id_ejercicio, nombre FROM ejercicio WHERE id_ejercicio in (SELECT id_ejercicio FROM PLA_EJ WHERE id_planes='" & id_planes & "') ORDER BY id_ejercicio ASC")
            Dim i As Integer = 0
            'Leemos todas las columnas obtenidas
            While ejercicio.consulta.Read()
                'Llenamos el vector con los valores de la consulta
                Me.ejID(i) = ejercicio.consulta.GetValue(0)
                Me.ejercicios(i) = ejercicio.consulta.GetValue(1)
                i += 1
            End While
            'Cerramos la consulta
            ejercicio.close()

            ReDim Me.ejSesion(cantidad)
            ReDim Me.ejCantidad(cantidad)
            ReDim Me.ejKcal(cantidad)
            ReDim Me.ejCarga(cantidad)
            ReDim Me.ejRepeticiones(cantidad)
            ReDim Me.ejModo(cantidad)

            Dim relacion As New BD("SELECT sesion,cantidad,kcal_quemadas,carga,repeticiones,modo FROM PLA_EJ WHERE id_planes='" & _
                                   id_planes & "' ORDER BY id_ejercicio DESC;")

            Dim j As Integer = 0
            While relacion.consulta.Read()
                Me.ejSesion(j) = relacion.consulta.GetValue(0)
                Me.ejCantidad(j) = relacion.consulta.GetValue(1)
                Me.ejKcal(j) = relacion.consulta.GetValue(2)
                Me.ejCarga(j) = relacion.consulta.GetValue(3)
                Me.ejRepeticiones(j) = relacion.consulta.GetValue(4)
                Me.ejModo(j) = relacion.consulta.GetValue(5)
                j += 1
            End While
            relacion.close()
        Catch ex As Exception
            'Capturamos el error en la variable de debug
            Me.msg = ex.ToString
        End Try
    End Sub

    Function ingresarPlan(ByVal nombre As String, ByVal descripcion As String, ByVal fase As String, _
                          ByVal fechaDesde As Date, ByVal fechaHasta As Date)
        'Declaramos el id = 0
        Dim id As Integer = 0
        Try
            'Obtenemos el último id ingresado
            Dim contar As New BD("SELECT id_planes FROM PLANESENTRENAMIENTO ORDER BY id_planes DESC")
            'Realizamos la consulta
            contar.consulta.Read()
            'Si existen datos
            If contar.consulta.HasRows Then
                'el id es igual al consultado + 1 ya que es autoincremental
                'Es decir que se suma uno al último id automaticamente
                id = contar.consulta.GetValue(0) + 1
            End If
            'Cerramos la consulta, si no tiene ningún valor entonces significa que 
            'no existe ningun dato sobre esta entidad en la base de datos.
            'Por tanto el id queda en cero
            contar.close()
        Catch ex As Exception
            'Capturamos un error
            Me.msg = ex.ToString
            'Si algo está mal devolvemos -1
            Return -1
        End Try
        Try
            'Insertamos los valores dados por la funcion en la base de datos
            Dim ingresar As New BD("INSERT INTO PLANESENTRENAMIENTO VALUES('" & id & "','" & nombre & "','" & _
                                   descripcion & "','" & fase & "','" & f.fecha2informix(fechaDesde) & "','" & _
                                   f.fecha2informix(fechaHasta) & "');")
            'si todo sale bien devolvemos 0
            Return id
        Catch ex As Exception
            'capturamos el error
            Me.msg = ex.ToString
            'Si algo esta mal devolvemos -1
            Return -1
        End Try
    End Function

    Function bajaPlan(ByVal id_planes As Integer)
        Try
            'Para eliminar la entidad primero necesitamos eliminar los datos relacionados
            Dim eliminarRelCombos As New BD("DELETE FROM PLA_COM WHERE id_planes=" & id_planes)
            Dim eliminarRelEjercicios As New BD("DELETE FROM PLA_EJ WHERE id_planes=" & id_planes)

            'Eliminamos los datos que cumplan con la condicion
            Dim eliminar As New BD("DELETE FROM PLANESENTRENAMIENTO WHERE id_planes=" & id_planes)
            'Si todo sale bien devolvemos 0
            Return 0
        Catch ex As Exception
            'Capturamos el error y lo almacenamos en la variable de debug
            Me.msg = ex.ToString
            'Si algo esta mal devolvemos -1
            Return -1
        End Try
    End Function
    Function cumple(ByVal id As Integer, ByVal deportistas() As Integer)
        'Ingresamos la relacion
        'Para cada entero que hay en el vector pasado como parametro
        For Each d As Integer In deportistas
            Try
                'Se relaciona el id ingresado con cada uno de los valores del vector
                Dim relacionar As New BD("INSERT INTO CUMPLE VALUES('" & id & "','" & d & "')")
            Catch ex As Exception
                'Si hay error se captura en la variable de debug
                Me.msg = ex.ToString
                'Si algo sale mal devuelve -1
                Return -1
            End Try
        Next
        'Si todo salio bien al recorrer el vector e ingresar datos
        'devuelve 0
        Return 0
    End Function
    Function pla_com(ByVal id_plan As Integer, ByVal id_combo As Integer, ByVal sesion As String, ByVal cantidad As Integer, _
                ByVal kcal As Integer, ByVal carga As Integer, ByVal repeticiones As Integer, ByVal modo As String)
        'Ingresamos la relacion
        Try
            'Se relaciona el id ingresado con cada uno de los valores del vector
            Dim relacionar As New BD("INSERT INTO PLA_COM VALUES('" & id_plan & "','" & id_combo & "','" & _
                                     sesion & "','" & cantidad & "','" & kcal & "','" & carga & "','" & _
                                     repeticiones & "','" & modo & "')")
        Catch ex As Exception
            'Si hay error se captura en la variable de debug
            Me.msg = ex.ToString
            'Si algo sale mal devuelve -1
            Return -1
        End Try
        'devuelve 0
        Return 0
    End Function
    Function pla_ej(ByVal id_plan As Integer, ByVal id_ejercicio As Integer, ByVal sesion As String, ByVal cantidad As Integer, _
            ByVal kcal As Integer, ByVal carga As Integer, ByVal repeticiones As Integer, ByVal modo As String)
        'Ingresamos la relacion
        Try
            'Se relaciona el id ingresado con cada uno de los valores del vector
            Dim relacionar As New BD("INSERT INTO PLA_EJ VALUES('" & id_plan & "','" & id_ejercicio & "','" & _
                                     sesion & "','" & cantidad & "','" & kcal & "','" & carga & "','" & _
                                     repeticiones & "','" & modo & "')")
        Catch ex As Exception
            'Si hay error se captura en la variable de debug
            Me.msg = ex.ToString
            'Si algo sale mal devuelve -1
            Return -1
        End Try
        'devuelve 0
        Return 0
    End Function

End Class
