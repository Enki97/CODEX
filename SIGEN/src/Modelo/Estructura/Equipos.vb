Public Class Equipos
    Public id_equipo, esSeleccion, id_actividad As Integer
    Public categoria, deportistas() As String

    Public actividad As Actividad

    'Variable utilizada para debug (pruebas)
    Public msg

    Public Sub New(Optional ByVal id_equipo As Integer = -1)
        'Si se quiere inicializar vacio toma por defecto -1
        'Por tanto si es mayor a -1 (id >= 0) es porque se necesita llenar datos
        If id_equipo >= 0 Then
            Try
                'Intenta realizar la consulta en el id que se le pasa
                Dim consulta As New BD("SELECT * FROM EQUIPOS where id_equipo=" & id_equipo)

                'Lee la consulta
                consulta.consulta.Read()

                Me.id_equipo = id_equipo
                'Si tiene datos
                If consulta.consulta.HasRows Then
                    'Llena las variables de clase con los datos consultados
                    'en la base de datos
                    Me.id_equipo = consulta.consulta.GetValue(0)
                    Me.categoria = consulta.consulta.GetValue(1)
                    Me.esSeleccion = consulta.consulta.GetValue(2)
                    Me.id_actividad = consulta.consulta.GetValue(3)
                    'Llamada a un metodo de esta clase
                    Me.consultarActividad()
                    Me.consultarDeportistas()
                End If
                'Cerramos la consulta
                consulta.close()
            Catch ex As Exception
                'Obtenemos el error y lo pasamos en la variable de debug
                Me.msg = ex.ToString
            End Try
        End If
    End Sub

    Function ingresarEquipo(ByVal categoria As String, ByVal esSeleccion As Boolean, ByVal actividad As Integer)
        'Declaramos el id = 0
        Dim sel As Integer = 0
        Dim id As Integer = 0
        If esSeleccion Then
            sel = 1
        End If
        Try
            'Obtenemos el último id ingresado
            Dim contar As New BD("SELECT id_equipo FROM equipos order by id_equipo DESC")
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
            If esSeleccion Then
                sel = 1
            Else
                sel = 0
            End If
            Dim ingresar As New BD("INSERT INTO equipos VALUES('" & id & "','" & categoria & "','" & _
                                   sel & "','" & actividad & "')")
            'si todo sale bien devolvemos la id
            Return id
        Catch ex As Exception
            'capturamos el error
            Me.msg = ex.ToString
            'Si algo esta mal devolvemos -1
            Return -1
        End Try
    End Function

    Function bajaEquipo(ByVal id_equipo As Integer)
        Try
            'Para eliminar la entidad primero necesitamos eliminar los datos relacionados
            Dim eliminarRelacion As New BD("DELETE FROM eq_re WHERE id_equipo=" & id_equipo)
            'Eliminamos los datos que cumplan con la condicion
            Dim eliminar As New BD("DELETE FROM equipos WHERE id_equipo=" & id_equipo)
            'Si todo sale bien devolvemos 0
            Return 0
        Catch ex As Exception
            'Capturamos el error y lo almacenamos en la variable de debug
            Me.msg = ex.ToString
            'Si algo esta mal devolvemos -1
            Return -1
        End Try
    End Function

    Function modificarEquipo(ByVal id_equipo As Integer, Optional ByVal categoria As String = Nothing, Optional ByVal esSeleccion As Boolean = Nothing, Optional ByVal actividad As Integer = Nothing)
        Dim sel As Integer = 0
        'Si alguno de los datos fue omitido en la funcion, se iguala al dato que ya tenia
        If categoria Is Nothing Then
            categoria = Me.categoria
        End If
        If esSeleccion Then
            sel = 1
        End If
        Try
            'Modificamos todos los campos donde se cumpla la condicion
            Dim modificar As New BD("UPDATE equipos SET categoria='" & categoria & "', esSeleccion='" & sel & _
                                   "',actividad='" & actividad & "' WHERE id_equipo='" & id_equipo & "';")
            'Si todo está bien devuelve 0
            Return 0
        Catch ex As Exception
            'Capturamos el error en la variable de debug
            Me.msg = ex.ToString
            'Si algo sale mal devolvemos -1
            Return -1
        End Try
    End Function

    Function listar()
        'Creamos un vector que representa lo que vamos a listar
        Dim equipos() As String
        'Creamos una variable cantidad que servira para redimensionar el vector
        Dim cantidad As Integer = 0
        Try
            'Contamos los datos que hay en la base
            Dim contar As New BD("SELECT COUNT(*) FROM equipo")
            'Ejecutamos la consulta
            contar.consulta.Read()
            'Guardamos la cantidad de datos en la variable cantidad
            cantidad = contar.consulta.GetValue(0)
            'Cerramos la consulta
            contar.close()
        Catch ex As Exception
            'capturamos el error en la variable de debug
            Me.msg = ex.ToString
            'si algo esta mal devolvemos -1
            Return -1
        End Try
        'Si hay algun dato
        If cantidad > 0 Then
            Try
                'Consultamos el nombre de los datos que hay
                Dim consulta As New BD("SELECT nombre FROM equipo")
                'redimensionamos el vector, se ingresa cantidad -1 ya que los vectores
                'comienzan con el indice 0
                ReDim equipos(cantidad - 1)
                Dim i As Integer = 0
                'Se leen todos los datos
                While consulta.consulta.Read()
                    'Se pasan los datos leidos al vector
                    equipos(i) = consulta.consulta.GetValue(0)
                    i += 1
                End While
                'Cerramos la consulta
                consulta.close()
            Catch ex As Exception
                'Capturamos el error en la variable debug
                Me.msg = ex.ToString
                'Si algo sale mal devolvemos -1
                Return -1
            End Try
        Else
            'Si no hay datos igualamos el vector a nothing
            equipos = Nothing
        End If
        'Si todo salió bien devolvemos el vector
        Return equipos
    End Function

    Function listarIDNombre()
        'Listamos el nombre y la id
        Dim equipos() As String
        Dim cantidad As Integer = 0
        Try
            'contamos cuantos datos hay
            Dim contar As New BD("SELECT COUNT(*) FROM equipos")
            'Ejecutamos la consulta
            contar.consulta.Read()
            'obtenemos la cantidad de datos
            cantidad = contar.consulta.GetValue(0)
            'cerramos la consulta
            contar.close()
        Catch ex As Exception
            'Capturamos los errores
            Me.msg = ex.ToString
            'Si algo sale mal devolvemos -1
            Return -1
        End Try
        'Si hay datos en la base
        If cantidad > 0 Then
            Try
                'consultamos la id y el nombre
                Dim consulta As New BD("SELECT e.id_equipo, a.nombre, e.categoria FROM EQUIPOS E INNER JOIN ACTIVIDAD A ON e.actividad=a.id_actividad;")
                'redimensionamos el vector segun la cantidad de datos, se le pasa
                'cantidad - 1 ya que los vectores comienzan en 0
                ReDim equipos(cantidad - 1)
                Dim i As Integer = 0
                'Se declaran dos variables auxiliares
                Dim auxID As Integer
                Dim auxCat, auxAct As String
                'Se consultan los datos de la base de datos
                While consulta.consulta.Read()
                    'Se consulta la id
                    auxID = consulta.consulta.GetValue(0)
                    'Se consulta el nombre
                    auxAct = consulta.consulta.GetValue(1)
                    auxCat = consulta.consulta.GetValue(2)
                    'Se agrega al vector la id y el nombre
                    equipos(i) = auxID.ToString + " : " + Trim(auxAct) + "(" + Trim(auxCat) + ")"
                    i += 1
                End While
                'cerramos la consulta
                consulta.close()
            Catch ex As Exception
                'capturamos los errores
                Me.msg = ex.ToString
                'Si algo esta  mal devolvemos -1
                Return -1
            End Try
        Else
            'Si no hay datos en la base igualamos el vector a nothing
            equipos = Nothing
        End If
        'Si todo salio bien devolvemos el vector
        Return equipos
    End Function

    Function yaExiste(ByVal categoria As String, ByVal actividad As Integer)
        'ENTONCES PORQUE NO HACER NOMBRE UNA PRIMARY KEY EN LA BASE DE DATOS?
        'En el momento de hacer el analisis no se tuvo ese problema, pero en la practica
        'se encontro que en realidad los nombres no podrian ser iguales. Sin embargo, 
        'el desarrollo se encontraba en etapas tardías y cambiar todo el analisis supondria
        'grandes costos de tiempo. Por tanto, se decidio controlarlo desde programación.

        Dim existe As Boolean
        Try
            'se consulta el nombre ingresado en la base de datos
            Dim consulta As New BD("SELECT * FROM equipos WHERE categoria='" & categoria & "' AND actividad=" & actividad)
            'Leemos la variable
            consulta.consulta.Read()
            'Si el dato consultado existe en la bd
            If consulta.consulta.HasRows Then
                'Se iguala existe a True
                existe = True
            Else
                'si no existe se lo iguala a False
                existe = False
            End If
            'Cerramos la consulta
            consulta.close()
        Catch ex As Exception
            'Capturamos el error
            Me.msg = ex.ToString
            'Si algo sale mal devolvemos -1
            Return -1
        End Try
        'Devolvemos el valor booleano
        Return existe
    End Function

    Sub consultarActividad()
        Me.actividad = New Actividad(Me.id_actividad)
    End Sub

    Sub consultarDeportistas()
        Dim sql As String = "SELECT u.documento, u.primernombre, u.primerapellido FROM USUARIO U INNER JOIN EQ_RE ON U.documento=eq_re.documento WHERE EQ_RE.id_equipo='" & Me.id_equipo & "';"
        Dim sqlContar As String = "SELECT COUNT(u.documento) FROM USUARIO U INNER JOIN EQ_RE ON U.documento=eq_re.documento WHERE EQ_RE.id_equipo='" & Me.id_equipo & "';"
        Try
            Dim contar As New BD(sqlContar)
            Dim cantidad As Integer
            If contar.consulta.HasRows Then
                cantidad = contar.consulta.GetValue(0)
            Else
                Me.deportistas = Nothing
                Exit Sub
            End If
            contar.close()

            ReDim Me.deportistas(cantidad)

            Dim consulta As New BD(sql)
            If consulta.consulta.HasRows Then
                Dim i As Integer = 0
                Dim auxNombre, auxApellido As String
                Dim auxCI As Integer
                While consulta.consulta.Read()
                    auxCI = consulta.consulta.GetValue(0)
                    auxNombre = consulta.consulta.GetValue(1)
                    auxApellido = consulta.consulta.GetValue(2)
                    Me.deportistas(i) = auxCI.ToString + " : " + Trim(auxApellido) + ", " + Trim(auxNombre)
                    i += 1
                End While
            Else
                Me.deportistas = Nothing
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
        End Try
    End Sub

    Function ingresarRelacion(ByVal id As Integer, ByVal deportistas() As Integer)
        Try
            For Each d In deportistas
                Dim sql As String
                sql = "INSERT INTO EQ_RE VALUES('" & d & "','" & id & "');"
                Dim ingresar As New BD(sql)
            Next
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Function listarDeportistas(ByVal id_actividad As Integer)
        Dim usuarios() As String
        Dim sql, sqlContar As String
        sql = "SELECT U.documento, U.primernombre, u.primerapellido FROM REALIZAN R INNER JOIN USUARIO U ON R.documento=U.documento WHERE R.id_actividad=" & id_actividad & ";"
        sqlContar = "SELECT COUNT(U.documento) FROM REALIZAN R INNER JOIN USUARIO U ON R.documento=U.documento WHERE R.id_actividad=" & id_actividad & ";"

        Try
            Dim contar As New BD(sqlContar)
            Dim cantidad As Integer
            If contar.consulta.HasRows Then
                cantidad = contar.consulta.GetValue(0)
            Else
                Return Nothing
            End If
            contar.close()

            ReDim usuarios(cantidad)

            Dim consulta As New BD(sql)
            If consulta.consulta.HasRows Then
                Dim i As Integer = 0

                Dim auxCI As Integer
                Dim auxNombre, auxApellido As String

                While consulta.consulta.Read()
                    auxCI = consulta.consulta.GetValue(0)
                    auxNombre = consulta.consulta.GetValue(1)
                    auxApellido = consulta.consulta.GetValue(2)

                    usuarios(i) = auxCI.ToString() + " : " + Trim(auxApellido) + ", " + Trim(auxNombre)

                    i += 1
                End While
                Return usuarios
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try

    End Function

    Function listarSeleccionables(ByVal id_actividad As Integer)
        Dim deportistas() As String
        Dim sql As String
        sql = "SELECT U.documento, U.primernombre, u.primerapellido," & _
              "E.cumplimiento, E.resistenciaanaerobica, E.resistenciaMuscular," & _
              "E.fuerzamuscular, E.flexibilidad, E.resistenciamonotonia, E.recilencia " & _
              "FROM REALIZAN R " & _
              "INNER JOIN USUARIO U ON R.documento=U.documento " & _
              "INNER JOIN EVOLUCION E ON U.documento=E.documento_deportista " & _
              "WHERE R.id_actividad=0 AND fecha=(SELECT max(fecha) FROM EVOLUCION " & _
              "WHERE DOCUMENTO_DEPORTISTA=U.documento);"

        Try
            Dim consulta As New BD(sql)
            If consulta.consulta.HasRows Then
                Dim i As Integer = 0
                Dim contar As Integer = 0
                Dim auxCI As Integer
                Dim auxNombre, auxApellido As String
                Dim cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia As Integer
                While consulta.consulta.Read()
                    cumplimiento = consulta.consulta.GetValue(3)
                    rAnaerobica = consulta.consulta.GetValue(4)
                    rMuscular = consulta.consulta.GetValue(5)
                    fMuscular = consulta.consulta.GetValue(6)
                    flexibilidad = consulta.consulta.GetValue(7)
                    rMonotonia = consulta.consulta.GetValue(8)
                    reciliencia = consulta.consulta.GetValue(9)

                    If clasifica(cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia) Then
                        contar += 1
                    End If
                End While

                ReDim deportistas(contar)

                While consulta.consulta.Read()
                    cumplimiento = consulta.consulta.GetValue(3)
                    rAnaerobica = consulta.consulta.GetValue(4)
                    rMuscular = consulta.consulta.GetValue(5)
                    fMuscular = consulta.consulta.GetValue(6)
                    flexibilidad = consulta.consulta.GetValue(7)
                    rMonotonia = consulta.consulta.GetValue(8)
                    reciliencia = consulta.consulta.GetValue(9)

                    If clasifica(cumplimiento, rAnaerobica, rMuscular, fMuscular, flexibilidad, rMonotonia, reciliencia) Then
                        deportistas(i) = auxCI.ToString + " : " + Trim(auxApellido) + ", " + Trim(auxNombre)
                        i += 1
                    End If
                End While
                Return deportistas
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function

    Private Function clasifica(ByVal cumplimiento As Integer, ByVal rAnaerobica As Integer, _
                             ByVal rMuscular As Integer, ByVal fMuscular As Integer, _
                             ByVal flexibilidad As Integer, ByVal rMonotonia As Integer, _
                             ByVal reciliencia As Integer)
        Dim total As Integer
        total = cumplimiento + rAnaerobica + rMuscular + fMuscular + flexibilidad + rMonotonia + reciliencia
        If total >= 80 Then
            If cumplimiento > 9 And rAnaerobica > 9 And rMuscular > 9 And fMuscular > 9 And flexibilidad > 9 And rMonotonia > 9 And _
            reciliencia > 9 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Function modificarRelacion(ByVal id As Integer, ByVal deportistas() As Integer)
        Try
            Dim eliminarRelacion As New BD("DELETE FROM eq_re WHERE id_equipo=" & id_equipo)
            Me.ingresarRelacion(id, deportistas)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function
End Class
