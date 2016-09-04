'Estas importaciones son usadas en cifrarContraseña
Imports System.Security.Cryptography
Imports System.Text

Public Class Usuario
    'Las siguientes son las propiedades de la clase Usuario
    Public documento As Integer
    Public primerNombre, segundoNombre As String
    Public primerApellido, segundoApellido As String
    Public fechaNacimiento As Date
    Public telefono() As Integer
    Public email As String
    Public foto As String
    Public dirCalle As String
    Public dirNumero As Integer
    Public dirBis As Boolean
    Public dirApartamento As Integer
    Public nacionalidad As String
    Public rol As String
    Public sexo As String
    Public contrasenia As String
    Public inactivo As Boolean

    'Conversiones de fecha
    Dim f As New Fecha()

    'esta variable es utilizada para enviar informacion a otras clases(gralmente debug)
    Public msg As String

    Sub New(Optional ByVal documento As Integer = Nothing)
        'Esta clase puede ser inicializada vacia, en caso que se quiera listar a todos los usuarios.
        If Not documento = Nothing Then
            'Si se especifica algún documento, el sistema consultará al usuario que poseea el documento
            'y asignará lo consultado a las propiedades del objeto
            Try 'Controlamos los errores
                'Consultamos todos los atributos del usuario que posean el documento
                Dim consultarUsuario = New BD("SELECT * FROM usuario WHERE documento=" & documento)
                consultarUsuario.consulta.Read()
                'Si el resultado de la consulta no es vacio iguala todos los campos
                If consultarUsuario.consulta.HasRows Then
                    Me.documento = documento
                    'Desde aqui se obtiene el valor de la consulta, ver clase BD.vb
                    'Con GetValue(posicion) obtenemos el valor de la columna posicion
                    'Donde posicion es la posicion ordenada de izquierda a derecha
                    'Es decir GetValue(0) primera columna, GetValue(1) segunda, etc
                    Me.primerNombre = consultarUsuario.consulta.GetValue(1)
                    If Not consultarUsuario.consulta.IsDBNull(2) Then
                        Me.segundoNombre = consultarUsuario.consulta.GetValue(2)
                    Else
                        Me.segundoNombre = Nothing
                    End If
                    Me.primerApellido = consultarUsuario.consulta.GetValue(3)
                    Me.segundoApellido = consultarUsuario.consulta.GetValue(4)
                    Me.fechaNacimiento = f.fecha2vb(consultarUsuario.consulta.GetValue(5))
                    Me.consultaTelefono(documento) 'Metodo que rellena el array telefono
                    Me.email = consultarUsuario.consulta.GetValue(6)
                    If Not consultarUsuario.consulta.IsDBNull(7) Then
                        Me.foto = consultarUsuario.consulta.GetValue(7)
                    Else
                        Me.foto = Nothing
                    End If
                    Me.dirCalle = consultarUsuario.consulta.GetValue(8)
                    Me.dirNumero = consultarUsuario.consulta.GetValue(9)
                    If Not consultarUsuario.consulta.IsDBNull(11) Then
                        Me.dirApartamento = consultarUsuario.consulta.GetValue(11)
                    Else
                        Me.dirApartamento = Nothing
                    End If
                    If consultarUsuario.consulta.IsDBNull(10) Then
                        Me.dirBis = consultarUsuario.consulta.GetValue(10)
                    Else
                        Me.dirBis = Nothing
                    End If
                    Me.nacionalidad = consultarUsuario.consulta.GetValue(12)
                    Me.rol = consultarUsuario.consulta.GetValue(13)
                    Me.sexo = consultarUsuario.consulta.GetValue(14)
                    Me.inactivo = consultarUsuario.consulta.GetValue(15)
                    Me.contrasenia = consultarUsuario.consulta.GetValue(16)
                Else
                    'Si el usuario no existe devuelve NE
                    Me.msg = "NE"
                End If
                'Cerramos la base de datos
                consultarUsuario.close()
            Catch ex As Exception
                'captura el error y lo manda a msg por si a otra clase le interesa su lectura
                Me.msg = ex.ToString()
            End Try
        Else
            Me.documento = Nothing
            Me.primerNombre = Nothing
            Me.segundoNombre = Nothing
            Me.primerApellido = Nothing
            Me.segundoApellido = Nothing
            Me.fechaNacimiento = Nothing
            ReDim Me.telefono(1)
            Me.telefono(0) = Nothing
            Me.foto = Nothing
            Me.dirCalle = Nothing
            Me.dirNumero = Nothing
            Me.dirApartamento = Nothing
            Me.dirBis = Nothing
            Me.nacionalidad = Nothing
            Me.rol = Nothing
            Me.sexo = Nothing
            Me.inactivo = Nothing
            Me.contrasenia = Nothing
        End If
    End Sub

    Private Sub consultaTelefono(ByVal documento As Integer)
        'Rellena el array telefono con todos los telefonos que tenga el usuario
        Try
            'Cuenta todos los telefonos que posee el usuario con un determinado documento
            Dim contar = New BD("SELECT COUNT(*) FROM usuario_telefono WHERE documento=" & documento)
            contar.consulta.Read()
            Dim cantidad As Integer = contar.consulta.GetValue(0) - 1
            'Ya que los arrays comienzan en 0, es necesario restarle 1 a la cantidad.
            contar.close()
            If cantidad >= 0 Then
                Dim consultar = New BD("SELECT telefono FROM usuario_telefono WHERE documento=" & documento)

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

    Function ingresarTelefonos(ByVal documento As Integer, ByVal telefonos() As Integer)
        For Each telefono As Integer In telefonos

            Try
                Dim ingresar = New BD("INSERT INTO usuario_telefono VALUES('" & documento & "','" & telefono & "')")
            Catch ex As Exception
                Me.msg = ex.ToString
                Return 1
            End Try
        Next
        Return 0
    End Function
    Function autenticar(ByVal doc As String, ByVal contra As String)
        'Primero cifra la contraseña ingresada
        contra = cifrarContrasenia(contra)
        doc = CInt(doc)
        Dim esIgual = True
        If Not contra = Trim(Me.contrasenia) Then
            esIgual = False
        End If
        'Luego compara si existe el documento ingresado en la base de datos
        'y si la contraseña cifrada de la base de datos corresponde con
        'la contraseña que se acaba de cifrar. Por tanto se comparan ambar contraseñas
        'cifradas.
        'Nota: En la base de datos todas las contraseñas están cifradas
        If esIgual And Me.inactivo = 0 Then
            'Si las credenciales son correctas y el usuario no está inactivo devuelve el rol para direccionar
            'al usuario a la ventana adecuada.
            Return True
        Else
            Me.msg = "CI Ingresada: " + doc + " - CI: "
            Return False
        End If
    End Function

    Function ingresarUsuario(ByVal documento As Integer, ByVal primerNombre As String, ByVal primerApellido As String, _
                             ByVal segundoApellido As String, ByVal fechaNacimiento As Date, ByVal email As String, _
                             ByVal dirCalle As String, ByVal dirNumero As Integer, ByVal Nacionalidad As String, _
                             ByVal rol As String, ByVal sexo As String, ByVal contrasenia As String, _
                             Optional ByVal segundoNombre As String = Nothing, Optional ByVal dirBis As Integer = 0, _
                             Optional ByVal apartamento As Integer = Nothing, Optional ByVal foto As String = Nothing)

        Dim valCI = New Validacion(documento.ToString) 'Valida cedula (ver clase Validacion)
        Dim valMail = New Validacion(email) 'Valida Mail (ver clase Validacion)

        'cifra la contraseña con el fin de almacenarla cifrada en la base de datos (ver metodo cifrarContrasenia)
        contrasenia = cifrarContrasenia(contrasenia)

        'Si el mail y la cedula son validos
        If valCI.cedula And valMail.mail Then
            'Si todo es válido comenzamos a consturuir la cadena sql
            Dim sentencia As New StringBuilder()
            Dim valores As New StringBuilder()
            Dim c As String = "','"
            Dim sql As String

            'agregamos valores obligatorios, donde sentencia compondra los campos que se desean modificar y valores
            'contendra los valores a ingresar.
            sentencia.Append("INSERT INTO USUARIO(documento,primernombre,primerapellido,segundoapellido,fechanac,email,dir_calle,dir_numero,dir_bis,nacionalidad,rol,sexo,inactivo,contrasenia")
            valores.Append(" VALUES('")
            valores.Append(documento)
            valores.Append(c)
            valores.Append(primerNombre)
            valores.Append(c)
            valores.Append(primerApellido)
            valores.Append(c)
            valores.Append(segundoApellido)
            valores.Append(c)
            valores.Append(f.fecha2informix(fechaNacimiento))
            valores.Append(c)
            valores.Append(email)
            valores.Append(c)
            valores.Append(dirCalle)
            valores.Append(c)
            valores.Append(dirNumero)
            valores.Append(c)
            valores.Append(dirBis)
            valores.Append(c)
            valores.Append(Nacionalidad)
            valores.Append(c)
            valores.Append(rol)
            valores.Append(c)
            valores.Append(sexo)
            valores.Append(c)
            valores.Append(0)
            valores.Append(c)
            valores.Append(contrasenia)

            'Agregamos los campos no obligatorios que no sean vacios.
            If Not segundoNombre Is Nothing Then
                sentencia.Append(",segundonombre")
                valores.Append(c)
                valores.Append(segundoNombre)
            End If

            If Not apartamento = Nothing Then
                sentencia.Append(",dir_apartamento")
                valores.Append(c)
                valores.Append(apartamento)
            End If

            If Not foto Is Nothing Then
                sentencia.Append(",foto")
                valores.Append(c)
                valores.Append(foto)
            End If

            sentencia.Append(")")
            valores.Append("')")

            'construimos la cadena
            sql = sentencia.ToString + valores.ToString

            Try 'Controlamos errores
                Dim insertar = New BD(sql)

                'Si todo está bien devuelve 0
                Return 0
            Catch ex As Exception
                Me.msg = ex.ToString
                'Si se devuelve 1 es porque ocurrió algún error
                Return -1
            End Try
        Else
            Me.msg = "Cedula o Correo falsos"
            Return 1
        End If
    End Function
    Function modificarTelefono(ByVal documento As Integer, ByVal tel() As Integer)
        Try
            Dim del = New BD("DELETE FROM USUARIO_TELEFONO WHERE documento=" & documento)
            Me.ingresarTelefonos(documento, tel)
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function
    Function modificarContrasenia(ByVal documento As Integer, ByVal contrasenia As Integer)
        Dim contra As String = Me.cifrarContrasenia(contrasenia)
        Try
            Dim modificar = New BD("UPDATE USUARIO SET contrasenia='" & contra & "' WHERE documento=" & documento)
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            Return 1
        End Try
    End Function
    Function modificarUsuario(ByVal documento As Integer, _
                             Optional ByVal primerNombre As String = Nothing, _
                             Optional ByVal primerApellido As String = Nothing, _
                             Optional ByVal segundoApellido As String = Nothing, _
                             Optional ByVal fechaNacimiento As Date = Nothing, _
                             Optional ByVal email As String = Nothing, _
                             Optional ByVal dirCalle As String = Nothing, _
                             Optional ByVal dirNumero As Integer = Nothing, _
                             Optional ByVal nacionalidad As String = Nothing, _
                             Optional ByVal sexo As String = Nothing, _
                             Optional ByVal segundoNombre As String = Nothing, _
                             Optional ByVal dirBis As Boolean = Nothing, _
                             Optional ByVal apartamento As Integer = Nothing, _
                             Optional ByVal foto As String = Nothing)

        Dim bis As Integer
        'Solo el documento debe ser ingresado obligatoriamente
        'En caso de que el parametro no haya sido ingresado, el mismo se iguala al
        'valor existente.
        'Luego se modifica todo aunque no haya sido ingresado, ya que si no fue ingresado
        'conservara el valor que tenía anteriormente.
        If primerNombre Is Nothing Then
            primerNombre = Me.primerNombre
        End If
        If segundoNombre Is Nothing Then
            segundoNombre = Me.segundoNombre
        End If
        If primerApellido Is Nothing Then
            primerApellido = Me.primerApellido
        End If
        If segundoApellido Is Nothing Then
            segundoApellido = Me.segundoApellido
        End If
        If fechaNacimiento = Nothing Then
            fechaNacimiento = Me.fechaNacimiento
        End If
        If email Is Nothing Then
            email = Me.email
        End If
        If dirCalle Is Nothing Then
            dirCalle = Me.dirCalle
        End If
        If dirNumero = Nothing Then
            dirNumero = Me.dirNumero
        End If
        If dirBis = Nothing Then
            dirBis = Me.dirBis
        End If

        If dirBis Then
            bis = 1
        Else
            bis = 0
        End If

        If apartamento = Nothing Then
            apartamento = Me.dirApartamento
        End If
        If nacionalidad Is Nothing Then
            nacionalidad = Me.nacionalidad
        End If
        If foto Is Nothing Then
            foto = Me.foto
        End If
        If sexo Is Nothing Then
            sexo = Me.sexo
        End If

        Try 'controlamos errores
            'Se realiza la modificacion
            If foto Is Nothing Then
                Dim modificar = New BD("UPDATE USUARIO SET primernombre='" & primerNombre & _
                                       "',segundonombre='" & segundoNombre & "', primerapellido='" _
                                       & primerApellido & "', segundoapellido='" & segundoApellido & _
                                       "', fechanac='" & f.fecha2informix(fechaNacimiento) & "', email='" & email & _
                                       "',dir_calle='" & dirCalle & "',dir_numero='" _
                                       & dirNumero & "',dir_bis='" & bis & "',dir_apartamento='" _
                                       & apartamento & "',nacionalidad='" & nacionalidad & "',sexo='" _
                                       & sexo & "' WHERE documento=" & documento)
            Else
                Dim modificar = New BD("UPDATE USUARIO SET primernombre='" & primerNombre & _
                                       "',segundonombre='" & segundoNombre & "', primerapellido='" _
                                       & primerApellido & "', segundoapellido='" & segundoApellido & _
                                       "', fechanac='" & f.fecha2informix(fechaNacimiento) & "', email='" & email & _
                                       "', foto='" & foto & "',dir_calle='" & dirCalle & "',dir_numero='" _
                                       & dirNumero & "',dir_bis='" & bis & "',dir_apartamento='" _
                                       & apartamento & "',nacionalidad='" & nacionalidad & "',sexo='" _
                                       & sexo & "' WHERE documento=" & documento)
            End If
            'Si todo está bien retorna 0
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            'En caso de que algo falle retorna 1
            Return -1
        End Try
    End Function


    Function bajaUsuario(ByVal documento As Integer)
        Try 'controlamos errores
            'Marcamos inactivo como true (1), por tanto no se podra autenticar.
            Dim desactivar = New BD("UPDATE USUARIO SET inactivo=1 WHERE documento=" & documento)

            'si no hubo errores devuelve 0
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            'Si hubo errores devuelve 1
            Return 1
        End Try
    End Function
    Function agregarTelefono(ByVal documento As Integer, ByVal telefono As Integer)
        Try 'controlamos errores
            'insertamos nuevo telefono
            Dim insertar = New BD("INSERT INTO usuario_telefono VALUES(" & documento & "," & telefono & ")")
        Catch ex As Exception
            Me.msg = ex.ToString
            'si algo falló devuelve 1
            Return 1
        End Try
        Return 0
    End Function

    Function bajaTelefono(ByVal documento, ByVal telefono)
        Try 'controlamos errores
            'borramos el telefono de un usuario
            Dim borrar = New BD("DELETE FROM usuario_telefono WHERE documento=" & documento & " AND telefono=" & telefono)
            'Si está bien devuelve 0
            Return 0
        Catch ex As Exception
            Me.msg = ex.ToString
            'si falló algo devuelve 1
            Return 1
        End Try
    End Function
    Function listar(Optional ByVal rol As String = Nothing)
        'Lista todos los usuarios, si se pasa rol como parametro
        'devuelve los usuarios de un determinado rol

        'Se crea un diccionario de usuarios con documento como clave del diccionario
        'y el nombre completo de forma apellido, nombre como valor
        Dim usuarios As New Dictionary(Of Integer, String)
        Dim nombreCompleto As String
        Dim cantidad As Integer
        Dim pNombre(), pApellido() As String
        Dim documento() As Integer

        'Comprueba si se ingresó el parametro rol
        If rol Is Nothing Then
            Try 'controlamos errores
                'cuenta la cantidad de usuarios que hay
                Dim contar = New BD("SELECT COUNT(*) FROM USUARIO")
                contar.consulta.Read()
                cantidad = contar.consulta.GetValue(0) - 1
                contar.close()
                If cantidad >= 0 Then
                    'redimenciona el array según la cantidad de telefonos
                    ReDim pNombre(cantidad)
                    ReDim pApellido(cantidad)
                    ReDim documento(cantidad)

                    'lista todos los usuarios ordenado por el apellido, donde el primer campo es documento, el segundo
                    'primernombre y el tercero priemer apellido
                    Dim lista = New BD("SELECT documento,primernombre,primerapellido FROM USUARIO ORDER BY primerapellido")
                    Dim nombre, apellido As String
                    Dim i As Integer = 0
                    'Se lee todos los consultados y se los asigna a los array
                    While lista.consulta.Read()
                        documento(i) = lista.consulta.GetValue(0)
                        nombre = lista.consulta.GetValue(1)
                        pNombre(i) = Trim(nombre) 'Quita espacios en blanco
                        apellido = lista.consulta.GetValue(2)
                        pApellido(i) = Trim(apellido) 'Quita espacios en blanco
                        i += 1
                    End While
                    lista.close()
                End If
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try

        Else
            Try
                'lo mismo que en la consulta anterior pero tomando en cuenta el rol
                Dim contar = New BD("SELECT COUNT(*) FROM USUARIO WHERE rol='" & rol & "'")
                contar.consulta.Read()
                cantidad = contar.consulta.GetValue(0) - 1
                contar.close()
                If cantidad >= 0 Then
                    ReDim pNombre(cantidad)
                    ReDim pApellido(cantidad)
                    ReDim documento(cantidad)
                    Dim lista = New BD("SELECT documento,primernombre,primerapellido,inactivo FROM USUARIO WHERE rol='" & rol & "' ORDER BY primerapellido")
                    Dim nombre, apellido As String
                    Dim i As Integer = 0
                    While lista.consulta.Read()
                        If lista.consulta.GetValue(3) = 0 Then 'Si esta activo
                            documento(i) = lista.consulta.GetValue(0)
                            nombre = lista.consulta.GetValue(1)
                            pNombre(i) = Trim(nombre) 'Quita espacios en blanco
                            apellido = lista.consulta.GetValue(2)
                            pApellido(i) = Trim(apellido) 'Quita espacios en blanco
                            i += 1
                        End If
                    End While
                    lista.close()

                    For j As Integer = 0 To cantidad
                        nombreCompleto = pApellido(j) & ", " & pNombre(j)
                        usuarios.Add(documento(j), nombreCompleto)
                    Next
                End If
            Catch ex As Exception
                Me.msg = ex.ToString
            End Try
        End If
        Return usuarios
    End Function
    Function cifrarContrasenia(ByVal contrasenia As String)
        'Metodo que utiliza MD5 para no guardar en la base de datos
        'las contraseñas en texto plano (Metodo extraido de la documentacion
        'de microsoft)
        'http://msdn.microsoft.com/es-es/library/system.security.cryptography.md5cryptoserviceprovider.aspx

        'Primero inicializamos MD5 (importado de System.Security.Cryptography)
        Dim md5 As New MD5CryptoServiceProvider()

        'Convertimos la cadena a un array de Bytes y se hace el hasheo
        Dim hash As Byte() = md5.ComputeHash(Encoding.Default.GetBytes(contrasenia))
        'El metodo Encoding.Default.GetBytes(contrasenia) Convierte el string
        'contrasenia a bytes(importado de System.Text)

        'Creamos un stringBuilder para pasar los bytes hasheados a cadena
        Dim str As New StringBuilder()

        'Recorre cada byte del hash y lo formatea a un string hexadecimal
        Dim i As Integer
        For i = 0 To hash.Length - 1
            str.Append(hash(i).ToString("x2"))
        Next i

        'Devuelve el string MD5
        Return str.ToString
    End Function
End Class