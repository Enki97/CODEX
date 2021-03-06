﻿Public Class FrmAltaEntrenador
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub cargarInstitutos()
        cmbInstituto.Items.Clear()
        Dim strNoInstituto As String = "No se han añadido institutos."
        Dim institutos As New Instituto()
        Dim lista() As String = institutos.listarIDNombre
        If esIngles Then
            strNoInstituto = "Not institute added yet."
        End If
        If Not lista Is Nothing Then
            For Each i As String In institutos.listarIDNombre
                cmbInstituto.Items.Add(i)
            Next
        Else
            cmbInstituto.Items.Add(strNoInstituto)
        End If
    End Sub

    Private Sub FrmAltaEntrenador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarInstitutos()

        'Sistema bilingüe
        If esIngles Then
            Me.Text = "Sign Up Coach"
            gbxDatosPersonales.Text = "Personal Data"
            gbxDireccion.Text = "Recidence"
            gbxNombreCompleto.Text = "Full Name"
            lblApartamento.Text = "Apartment:"
            lblDocumento.Text = "Document:"
            lblEmail.Text = "Email:"
            lblNacionalidad.Text = "Nacionality:"
            lblNumero.Text = "Number:"
            lblPriApellido.Text = "Last Name:"
            lblSegApellido.Text = "Second Last Name:"
            lblPriNombre.Text = "First Name:"
            lblSegNombre.Text = "Middle Name:"
            lblSexo.Text = "Gender:"
            lblTelefono.Text = "Phone:"
            lblFechaNacimiento.Text = "Date of Birth:"
            lblFotoURL.Text = "Photo URL:"
            lblCalle.Text = "Street:"
            lblContrasenia.Text = "Password:"
            lblRepetirContrasenia.Text = "Repeat Password:"
            lblInstituto.Text = "Institute:"
            rbnFemenino.Text = "Female"
            rbnMasculino.Text = "Male"
            btnAtras.Text = "Cancel"
            btnRegistrar.Text = "Sign Up"
        End If
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        'Borra todos los campos, si no se hacen hay que borrarlo manualmente al ingresar otro usuario
        txtApartamento.Text = ""
        txtCalle.Text = ""
        txtContrasenia.Text = ""
        txtRepetirContrasenia.Text = ""
        txtDocumento.Text = ""
        txtEmail.Text = ""
        txtFotoURL.Text = ""
        txtNumero.Text = ""
        txtPriApellido.Text = ""
        txtPriNombre.Text = ""
        txtSegApellido.Text = ""
        txtSegNombre.Text = ""
        txtTelefono.Text = ""
        rbnFemenino.Checked = False
        rbnMasculino.Checked = False
        dtpFechaNacimiento.Value = Now
        cmbNacionalidad.ResetText()
        lbxTelefono.Items.Clear()

        nav.anterior()
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim documento, dNumero, dApartamento, dBis As Integer
        Dim pNombre, sNombre, pApellido, sApellido, email, foto, dCalle, nacionalidad, sexo, contrasenia As String
        Dim fNac As Date
        Dim rol As String = "entrenador"
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strValido As String = "Algunos campos no son válidos: "
        Dim strNoCoincide As String = "Las contraseñas no coinciden."
        Dim strCorrecto As String = "Usuario registrado correctamente."
        Dim strYaExiste As String = "El usuario ya existe."
        Dim strSoloNumeros As String = "Los siguientes campos solo admiten caracteres numéricos: "
        Dim faltan As Boolean = False
        Dim invalido As Boolean = False
        Dim noCoincide As Boolean = False
        Dim yaExiste As Boolean = False
        Dim soloNumeros As Boolean = False

        If esIngles Then
            strYaExiste = "The user is already registered"
            strFaltan = "The following fields are required: "
            strValido = "Some fields aren't valid: "
            strNoCoincide = "The passwords doesn't match"
            strCorrecto = "Successfully registered."
            strSoloNumeros = "The following field only accepts numbers: "
        End If

        'En caso de que este correctamente ingresado se asigna el valor a la variable
        'sino se controla el error ya sea que el usuario ya existe, que las contraseñas
        'no coincidan, que falten campos o que no sean válidos.
        If txtDocumento.Text = "" Then 'Si el campo está vacio
            faltan = True
            If esIngles Then 'Si el formulario está en ingles
                strFaltan += "/Document"
            Else 'si no esta en ingles
                strFaltan += "/Documento"
            End If
        Else 'Si el campo no está vacío
            Dim vDoc As New Validacion(txtDocumento.Text)
            If vDoc.cedula Then 'si el documento es válido
                Try
                    'Consulta al documento ingresado en la tabla usuario con el objetivo de saber si el usuario
                    'Ya existe.
                    Dim existe = New BD("SELECT documento FROM USUARIO WHERE documento='" & txtDocumento.Text & "'")
                    existe.consulta.Read()
                    If existe.consulta.HasRows Then 'Si la consulta tiene resultado (es decir, si el usuario ya existe)
                        yaExiste = True
                    Else 'Si el usuario no existe
                        documento = txtDocumento.Text
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else 'Si el documento no es válido
                invalido = True
                If esIngles Then 'si el formulario está en inglés
                    strValido += "/Document"
                Else 'Si no esta en inglés
                    strValido += "/Documento"
                End If
            End If
        End If


        If txtContrasenia.Text = "" Then 'si el campo está vacío
            faltan = True
            If esIngles Then 'si el formulario está en ingles
                strFaltan += "/Password"
            Else 'Si el formulario no esta en ingles
                strFaltan += "/Contraseña"
            End If
        ElseIf txtContrasenia.Text = txtRepetirContrasenia.Text Then 'Si las contraseñas ingresadas son iguales
            contrasenia = txtContrasenia.Text
        Else 'Si repetir conraseña no es igual a la contraseña
            noCoincide = True
        End If


        If txtPriNombre.Text = "" Then 'Si el primer nombre es vacío
            faltan = True
            If esIngles Then 'Si el formulario está en inglés
                strFaltan += "/First Name"
            Else 'Si el formulario no está en inglés
                strFaltan += "/Primer Nombre"
            End If
        Else 'Si el campo no es vacío
            pNombre = txtPriNombre.Text
        End If


        If txtSegNombre.Text = "" Then 'Si el campo esta vacio
            sNombre = Nothing
        Else 'Si el campo no está vacio
            sNombre = txtSegNombre.Text
        End If


        If txtPriApellido.Text = "" Then 'si el campo esta vacío
            faltan = True
            If esIngles Then 'si el formulario esta en ingles
                strFaltan += "/Last Name"
            Else 'si el formulario no está en ingles
                strFaltan += "/Primer Apellido"
            End If
        Else 'Si el campo no está vacío
            pApellido = txtPriApellido.Text
        End If


        If txtSegApellido.Text = "" Then 'Si el campo esta vacío
            faltan = True
            If esIngles Then 'Si esta en inglés
                strFaltan += "/Second Last Name"
            Else 'Si no está en inglés 
                strFaltan += "/Segundo Apellido"
            End If
        Else 'Si el campo no está vacío
            sApellido = txtSegApellido.Text
        End If

        If dtpFechaNacimiento.Value = Now Then 'Si la fecha es igual a la de hoy
            faltan = True
            If esIngles Then 'Si está en ingles
                strFaltan += "/Date of Birth"
            Else 'Si no esta en ingles
                strFaltan += "/Fecha Nacimiento"
            End If
        Else 'Si la fecha no es igual a la de hot
            fNac = dtpFechaNacimiento.Value
        End If

        If txtEmail.Text = "" Then 'si el campo es vacío
            faltan = True
            strFaltan += "/Email"
            'No hace falta comprobar si esta en ingles o no ya que email sirve para ambos idiomas.
        Else 'Si el campo no es vacío
            Dim vMail = New Validacion(txtEmail.Text)
            If vMail.mail() Then 'Si el mail es valido
                email = txtEmail.Text
            Else 'Si el mail no es valido
                strValido += "/Email"
                invalido = True
            End If
        End If

        If txtFotoURL.Text = "" Then 'Si el campo esta vacio
            foto = Nothing
        Else 'Si el campo no está vacio
            foto = txtFotoURL.Text
        End If

        If txtCalle.Text = "" Then 'Si el campo esta vacio
            faltan = True
            If esIngles Then 'si el formulario esta en ingles
                strFaltan += "/Street"
            Else 'Si el formulario no está en ingles
                strFaltan += "/Calle"
            End If
        Else 'Si el campo no esta vacio
            dCalle = txtCalle.Text
        End If

        If txtNumero.Text = "" Then 'Si el campo está vacío
            faltan = True
            If esIngles Then 'Si el formulario está en inglés
                strFaltan += "/Door's Number"
            Else 'Si el formulario no está en inglés
                strFaltan += "/Número de Puerta"
            End If
        Else 'Si el campo no esta vacio
            For Each num As Char In txtNumero.Text 'Recorremos todos los caracteres del campo
                If Not Char.IsDigit(num) Then 'Comprobamos si no es un número
                    soloNumeros = True
                End If
            Next

            If soloNumeros Then 'Si tiene algun caracter no numerico
                If esIngles Then 'Si esta en ingles
                    strSoloNumeros += "/Door's Number"
                Else 'si no está en inglés
                    strSoloNumeros += "/Número de Puerta"
                End If
            Else 'Si solo tiene números
                dNumero = CInt(txtNumero.Text)
            End If
        End If

        If ckbBIS.Checked Then 'Si es BIS
            dBis = 1
        Else 'SI no es BIS
            dBis = 0
        End If

        If txtApartamento.Text = "" Then 'Si el campo está vacío
            dApartamento = Nothing
        Else 'si el campo no está vacio
            For Each c As Char In txtApartamento.Text 'Recorremos los caracteres del campo
                If Not Char.IsDigit(c) Then 'Comprobamos si no son números
                    soloNumeros = True
                End If
            Next
            If soloNumeros Then 'Si no son numeros
                If esIngles Then 'Si está en inglés
                    strSoloNumeros += "/Apartment"
                Else 'Si no está en inglés
                    strSoloNumeros += "/Apartamento"
                End If
            Else 'Si son números
                dApartamento = CInt(txtApartamento.Text)
            End If
        End If

        If cmbNacionalidad.SelectedItem = "" Then 'Si no se selecciono nada
            faltan = True
            If esIngles Then 'Si esta en ingles
                strFaltan += "/Nacionality"
            Else 'Si no está en ingles
                strFaltan += "/Nacionalidad"
            End If
        Else 'Si se selecciono
            nacionalidad = cmbNacionalidad.SelectedItem.ToString
        End If

        If rbnFemenino.Checked Then 'si esta chequeado femenino
            sexo = "Femenino"
        ElseIf rbnMasculino.Checked Then 'si esta chequeado masculino
            sexo = "Masculino"
        Else 'Si no esta chequeado
            faltan = True
            If esIngles Then 'Si está en inglés
                strFaltan += "/Gender"
            Else 'Si no está en inglés
                strFaltan += "/Sexo"
            End If
        End If

        'Si no hay ningún fallo se registra al usuario
        If faltan Then 'Si faltan campos
            MsgBox(strFaltan & "/", MsgBoxStyle.Critical)
        ElseIf invalido Then 'Si algún campo es inválido
            MsgBox(strValido & "/", MsgBoxStyle.Critical)
        ElseIf noCoincide Then 'Si las contraseñas no coinciden
            MsgBox(strNoCoincide, MsgBoxStyle.Critical)
        ElseIf yaExiste Then 'Si el usuario ya existe
            MsgBox(strYaExiste, MsgBoxStyle.Critical)
        ElseIf soloNumeros Then 'Si un campo que solo admite numeros tiene letras
            MsgBox(strSoloNumeros & "/", MsgBoxStyle.Critical)
        Else 'Si no hay ningún error
            Dim tel() As Integer

            'Se inicializa un usuario seleccionador
            Dim registrar = New Entrenador()

            'Se invoca la funcion que hereda avanzado de usuario, la cual ingresa un usuario generico
            registrar.ingresarUsuario(documento, pNombre, pApellido, sApellido, fNac, email, dCalle, dNumero, nacionalidad, _
                                       rol, sexo, contrasenia, sNombre, dBis, dApartamento, foto)

            'Se registra el usaurio seleccionador concretamente, agregando un número de funcionario (ver registrarSeleccionador
            'de la clase Seleccionador).
            registrar.registrarEntrenador(documento)

            'Si se ingresó algún telefono
            If lbxTelefono.Items.Count > 0 Then
                'Se redimensiona la variable telefono según los items que hallan en la lista
                'El hecho de restarle 1 es necesario ya que los vectores comienzan en 0
                ReDim tel(lbxTelefono.Items.Count - 1)

                'Para cada telefono de la lista se lo pasa al array tel
                For i As Integer = 0 To lbxTelefono.Items.Count - 1
                    tel(i) = CInt(lbxTelefono.Items(i))
                Next

                'Se registran los telefonos pasandole el documento y el vector tel(ver ingresarTelefono de
                'la clase Usuario).
                registrar.ingresarTelefonos(documento, tel)
            End If
            If Not cmbInstituto.SelectedItem = "" And Not CChar(cmbInstituto.SelectedItem) = "N" Then
                Dim auxId As String = ""
                Dim id As Long

                For Each c As Char In cmbInstituto.SelectedItem
                    If c = ":" Then
                        Exit For
                    Else
                        auxId += c
                    End If
                Next
                id = CLng(Trim(auxId))
                Dim instituto As New Instituto(id)
                instituto.pertenece(documento)
            End If
            MsgBox(strCorrecto, MsgBoxStyle.Information)

            'Borra todos los campos, si no se hacen hay que borrarlo manualmente al ingresar otro usuario
            txtApartamento.Text = ""
            txtCalle.Text = ""
            txtContrasenia.Text = ""
            txtRepetirContrasenia.Text = ""
            txtDocumento.Text = ""
            txtEmail.Text = ""
            txtFotoURL.Text = ""
            txtNumero.Text = ""
            txtPriApellido.Text = ""
            txtPriNombre.Text = ""
            txtSegApellido.Text = ""
            txtSegNombre.Text = ""
            txtTelefono.Text = ""
            rbnFemenino.Checked = False
            rbnMasculino.Checked = False
            dtpFechaNacimiento.Value = Now
            cmbNacionalidad.ResetText()
            lbxTelefono.Items.Clear()

            'Actualizamos lista de entrenadores
            FrmListarEntrenadores.actualizarLista()
            'Se vuelve al formulario anterior
            nav.anterior()
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        'si se presiona la tecla enter cuando estamos en el campo de ingresar telefono
        'se ejecuta la funcion que simula el evento click en el boton de agregar telefono
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnAltaTelefono.PerformClick()
        End If
    End Sub

    Private Sub btnAltaTelefono_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAltaTelefono.Click
        Dim soloNumero As Boolean = True
        Dim strDebeIngresar As String = "Debe ingresar un número"
        Dim strSoloNumero As String = "El telefono solo puede contener numeros enteros"

        'Cambia las string a ingles
        If esIngles Then
            strDebeIngresar = "You must input a number"
            strSoloNumero = "The phone only can have integer numbers"
        End If

        'Comprobamos que solo sean números
        For Each caracter As Char In txtTelefono.Text
            If Not Char.IsDigit(caracter) Then
                soloNumero = False
            End If
        Next

        'Comprobamos que no sea vacio y que solo sean numeros
        'Si solo son numeros añade el telefono a la lista de telefonos
        'y posteriormente deja vacio el campo de ingresar telefonos
        If txtTelefono.Text = "" Then
            MsgBox(strDebeIngresar)
        ElseIf soloNumero Then
            lbxTelefono.Items.Add(txtTelefono.Text)
            txtTelefono.Text = ""
        Else
            MsgBox(strSoloNumero, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtRepetirContrasenia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepetirContrasenia.KeyPress
        'Si en el campo de repetir contraseña presionamos enter desencadena el evento click en el boton registrar
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnRegistrar.PerformClick()
        End If
    End Sub
End Class
