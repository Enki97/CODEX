Public Class Ejercicio
    'Variables de clase (atributos)
    Public id_ejercicio As Integer
    Public nombre, descripcion, foto, video, grupos() As String

    'Variable utilizada para debug (pruebas)
    Public msg

    Public Sub New(Optional ByVal id_ejercicio As Integer = -1)
        'Si se quiere inicializar vacio toma por defecto -1
        'Por tanto si es mayor a -1 (id >= 0) es porque se necesita llenar datos
        If id_ejercicio >= 0 Then
            Try
                'Intenta realizar la consulta en el id que se le pasa
                Dim consulta As New BD("SELECT * FROM EJERCICIO where id_ejercicio=" & id_ejercicio)

                'Lee la consulta
                consulta.consulta.Read()

                Me.id_ejercicio = id_ejercicio
                'Si tiene datos
                If consulta.consulta.HasRows Then
                    'Llena las variables de clase con los datos consultados
                    'en la base de datos
                    Me.id_ejercicio = consulta.consulta.GetValue(0)
                    Me.nombre = consulta.consulta.GetValue(1)
                    Me.descripcion = consulta.consulta.GetValue(2)
                    'Si el campo 3 es vacio
                    If consulta.consulta.IsDBNull(3) Then
                        Me.foto = Nothing
                    Else
                        Me.foto = consulta.consulta.GetValue(3)
                    End If
                    'Si el campo 4 es vacío
                    If consulta.consulta.IsDBNull(4) Then
                        Me.video = Nothing
                    Else
                        Me.video = Me.normalizarVideo(consulta.consulta.GetValue(4))
                    End If

                    'Llamada a un metodo de esta clase
                    Me.consultarGrupos()
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
    Private Sub consultarGrupos()
        Try
            'Se crea una variable cantidad para obtener el numero de entidades que
            'cumplen con la condicion.
            Dim cantidad = 0
            'Contamos cuantas instancias en la base de datos cumplen con la condicion
            Dim contar As New BD("SELECT COUNT(*) FROM ENTRENA WHERE id_ejercicio=" & Me.id_ejercicio)
            'Ejecutamos la consulta
            contar.consulta.Read()
            'Obtenemos el valor de la consulta
            cantidad = contar.consulta.GetValue(0)
            'Cerramos la consulta
            contar.close()
            'Redimensionamos el vector según la cantidad de entidades que cumplen con la condicion
            ReDim Me.grupos(cantidad)
            'Obtenemos cuales son los datos que se relacionan
            Dim relacion As New BD("SELECT nombre FROM GRUPOSMUSCULARES WHERE id_grupos in (SELECT id_grupos FROM ENTRENA WHERE id_ejercicio='" & id_ejercicio & "')")
            Dim i As Integer = 0
            'Leemos todas las columnas obtenidas
            While relacion.consulta.Read()
                'Llenamos el vector con los valores de la consulta
                Me.grupos(i) = relacion.consulta.GetValue(0)
                i += 1
            End While
            'Cerramos la consulta
            relacion.close()
        Catch ex As Exception
            'Capturamos el error en la variable de debug
            Me.msg = ex.ToString
        End Try
    End Sub
    Function normalizarVideo(ByVal video As String)
        'Esta funcion se realizó, ya que el iframe necesita solo el identificador del video de 
        'youtube, este identificador se encuentra a partir del caracter numero 32.
        Return video.Substring(32)
    End Function
    Function ingresarEjercicio(ByVal nombre As String, ByVal descripcion As String, Optional ByVal foto As String = Nothing, Optional ByVal video As String = Nothing)
        'Declaramos el id = 0
        Dim id As Integer = 0
        Try
            'Obtenemos el último id ingresado
            Dim contar As New BD("SELECT id_ejercicio FROM EJERCICIO order by id_ejercicio DESC")
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
            Dim ingresar As New BD("INSERT INTO EJERCICIO VALUES('" & id & "','" & nombre & "','" & _
                                   descripcion & "','" & foto & "','" & video & "')")
            'si todo sale bien devolvemos 0
            Return 0
        Catch ex As Exception
            'capturamos el error
            Me.msg = ex.ToString
            'Si algo esta mal devolvemos -1
            Return -1
        End Try
    End Function

    Function bajaEjercicio(ByVal id_ejercicio As Integer)
        Try
            'Para eliminar la entidad primero necesitamos eliminar los datos relacionados
            Dim eliminarRelacion As New BD("DELETE FROM ENTRENA WHERE id_ejercicio=" & id_ejercicio)
            'Eliminamos los datos que cumplan con la condicion
            Dim eliminar As New BD("DELETE FROM EJERCICIO WHERE id_ejercicio=" & id_ejercicio)
            'Si todo sale bien devolvemos 0
            Return 0
        Catch ex As Exception
            'Capturamos el error y lo almacenamos en la variable de debug
            Me.msg = ex.ToString
            'Si algo esta mal devolvemos -1
            Return -1
        End Try
    End Function

    Function modificarEjercicio(ByVal id_ejercicio As Integer, Optional ByVal nombre As String = Nothing, Optional ByVal descripcion _
                                As String = Nothing, Optional ByVal foto As String = Nothing, Optional ByVal video As String = Nothing)
        'Si alguno de los datos fue omitido en la funcion, se iguala al dato que ya tenia
        If nombre Is Nothing Then
            nombre = Me.nombre
        End If
        If descripcion Is Nothing Then
            descripcion = Me.descripcion
        End If
        If foto Is Nothing Then
            foto = Me.foto
        End If
        If video Is Nothing Then
            video = Me.video
        End If
      
        Try
            Dim modificar As New BD("UPDATE EJERCICIO SET nombre='" & nombre & "', descripcion='" & descripcion & _
                                   "', imagen='" & foto & "', video='" & video & "' WHERE id_ejercicio='" & id_ejercicio & "';")
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try

    End Function

    Function entrena(ByVal id As Integer, ByVal grupo() As Integer)
        'Ingresamos la relacion
        'Para cada entero que hay en el vector pasado como parametro
        For Each g As Integer In grupo
            Try
                'Se relaciona el id ingresado con cada uno de los valores del vector
                Dim relacionar As New BD("INSERT INTO ENTRENA VALUES('" & id & "','" & g & "')")
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

    Function modificarEntrena(ByVal id As Integer, ByVal grupo() As Integer)
        Try
            Dim borrar As New BD("DELETE FROM ENTRENA WHERE id_ejercicio='" & id & "';")
            Me.entrena(id, grupo)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return -1
        End Try
    End Function
    Function listar()
        'Creamos un vector que representa lo que vamos a listar
        Dim ejercicios() As String
        'Creamos una variable cantidad que servira para redimensionar el vector
        Dim cantidad As Integer = 0
        Try
            'Contamos los datos que hay en la base
            Dim contar As New BD("SELECT COUNT(*) FROM EJERCICIO")
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
                Dim consulta As New BD("SELECT nombre FROM EJERCICIO")
                'redimensionamos el vector, se ingresa cantidad -1 ya que los vectores
                'comienzan con el indice 0
                ReDim ejercicios(cantidad - 1)
                Dim i As Integer = 0
                'Se leen todos los datos
                While consulta.consulta.Read()
                    'Se pasan los datos leidos al vector
                    ejercicios(i) = consulta.consulta.GetValue(0)
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
            ejercicios = Nothing
        End If
        'Si todo salió bien devolvemos el vector
        Return ejercicios
    End Function

    Function obtenerID(ByVal nombre As String)
        Try
            Dim id As Integer
            'Ya que los nombres no se repiten se obtiene la id consultando los mismos y pasando
            'nombre como condicion
            Dim consultar As New BD("SELECT id_ejercicio FROM EJERCICIO WHERE nombre='" & nombre & "'")
            'Leemos la consulta
            consultar.consulta.Read()
            'Si existe
            If consultar.consulta.HasRows Then
                'Igualamos la id de la funcion a la id obtenida de la base de datos
                id = consultar.consulta.GetValue(0)
            End If
            'Cerramos la consulta
            consultar.close()
            'Devolvemos la id obtenida
            Return id
        Catch ex As Exception
            'Capturamos el error
            Me.msg = ex.ToString
            'Si algo sale mal devolvemos -1
            Return -1
        End Try
    End Function

    Function listarIDNombre()
        'Listamos el nombre y la id
        Dim ejercicios() As String
        Dim cantidad As Integer = 0
        Try
            'contamos cuantos datos hay
            Dim contar As New BD("SELECT COUNT(*) FROM EJERCICIO")
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
                Dim consulta As New BD("SELECT id_ejercicio,nombre FROM EJERCICIO")
                'redimensionamos el vector segun la cantidad de datos, se le pasa
                'cantidad - 1 ya que los vectores comienzan en 0
                ReDim ejercicios(cantidad - 1)
                Dim i As Integer = 0
                'Se declaran dos variables auxiliares
                Dim auxID As Integer
                Dim auxStr As String
                'Se consultan los datos de la base de datos
                While consulta.consulta.Read()
                    'Se consulta la id
                    auxID = consulta.consulta.GetValue(0)
                    'Se consulta el nombre
                    auxStr = consulta.consulta.GetValue(1)
                    'Se agrega al vector la id y el nombre
                    ejercicios(i) = auxID.ToString + " : " + auxStr
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
            ejercicios = Nothing
        End If
        'Si todo salio bien devolvemos el vector
        Return ejercicios
    End Function

    Function yaExiste(ByVal nombre As String)
        'ENTONCES PORQUE NO HACER NOMBRE UNA PRIMARY KEY EN LA BASE DE DATOS?
        'En el momento de hacer el analisis no se tuvo ese problema, pero en la practica
        'se encontro que en realidad los nombres no podrian ser iguales. Sin embargo, 
        'el desarrollo se encontraba en etapas tardías y cambiar todo el analisis supondria
        'grandes costos de tiempo. Por tanto, se decidio controlarlo desde programación.

        Dim existe As Boolean
        Try
            'se consulta el nombre ingresado en la base de datos
            Dim consulta As New BD("SELECT * FROM EJERCICIO WHERE nombre='" & nombre & "'")
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
End Class
