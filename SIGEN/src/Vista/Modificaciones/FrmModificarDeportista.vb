Public Class FrmModificarDeportista
    Public esIngles As Boolean = False
    Public usuario As Deportista
    Dim nav = New Navegacion(Me)
    Dim telEliminados() As Integer
    Dim eliminaTelefonos As Boolean = False
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
    Public Sub cargarDatos()
        Me.cargarInstitutos()
        txtApartamento.Text = usuario.dirApartamento.ToString
        txtCalle.Text = Trim(usuario.dirCalle)
        txtDocumento.Text = usuario.documento
        txtEmail.Text = Trim(usuario.email)
        txtFotoURL.Text = Trim(usuario.foto)
        txtNumero.Text = usuario.dirNumero
        txtPriApellido.Text = Trim(usuario.primerApellido)
        txtPriNombre.Text = Trim(usuario.primerNombre)
        txtSegApellido.Text = Trim(usuario.segundoApellido)
        txtSegNombre.Text = Trim(usuario.segundoNombre)
        cmbNacionalidad.SelectedText = Trim(usuario.nacionalidad)
        cmbNacionalidad.SelectedItem = Trim(usuario.nacionalidad)
        dtpFechaNacimiento.Value = usuario.fechaNacimiento

        If usuario.dirBis = 1 Then
            ckbBIS.Checked = True
        End If
        If CChar(usuario.sexo) = "M" Or CChar(usuario.sexo) = "m" Then
            rbnMasculino.Checked = True
        Else
            rbnFemenino.Checked = True
        End If

        lbxTelefono.Items.Clear()
        If Not usuario.telefono(0) = Nothing Then
            For Each t As Integer In usuario.telefono
                lbxTelefono.Items.Add(t.ToString)
            Next
        End If
    End Sub
    Private Sub FrmModificarDeportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If esIngles Then
            Me.Text = "Avanced User Modify"
            lblFotoURL.Text = "Photo URL:"
            lblDocumento.Text = "Document:"
            gbxNombreCompleto.Text = "Full Name"
            lblPriNombre.Text = "First Name:"
            lblSegNombre.Text = "Middle Name:"
            lblPriApellido.Text = "Last Name:"
            lblSegApellido.Text = "Second Last Name:"
            gbxDatosPeronales.Text = "Personal Data"
            lblNacionalidad.Text = "Nacionality:"
            lblSexo.Text = "Gender:"
            lblFechaNacimiento.Text = "Date of Birth:"
            lblInstituto.Text = "Institute:"
            gbxDireccion.Text = "Address"
            lblCalle.Text = "Street:"
            lblNumero.Text = "Number:"
            lblApartamento.Text = "Apartment:"
            lblTelefono.Text = "Phone:"
            lblAntiguaContrasenia.Text = "Old Password:"
            lblContrasenia.Text = "New Password:"
            lblRepetirContrasenia.Text = "Repeat New Password"
            btnAtras.Text = "Back"
            btnGuardar.Text = "Save"
        End If
        Me.cargarDatos()
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim dNumero, dApartamento, dBis As Integer
        Dim pNombre, sNombre, pApellido, sApellido, email, foto, dCalle, nacionalidad, sexo, contrasenia As String
        Dim fNac As Date
        Dim rol As String = "seleccionador"
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strValido As String = "Algunos campos no son válidos: "
        Dim strNoCoincide As String = "Las contraseñas no coinciden."
        Dim strCorrecto As String = "Usuario registrado correctamente."
        Dim strYaExiste As String = "El usuario ya existe."
        Dim strSoloNumeros As String = "Los siguientes campos solo admiten caracteres numéricos: "
        Dim nuevaContra As Boolean = True
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

        If txtContrasenia.Text = "" Then 'si el campo está vacío
            nuevaContra = False
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
            sNombre = "--------"
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
        ElseIf dtpFechaNacimiento.Value > Now Then 'Si la fecha es posterior a la fecha actual
            invalido = True
            If esIngles Then 'Si está en ingles
                strValido += "/Date of Birth"
            Else 'Si no esta en ingles
                strValido += "/Fecha Nacimiento"
            End If
        Else 'Si la fecha es menor a la de hoy
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

            FrmModificarDeportistaDos.setDatos(usuario.documento, pNombre, sNombre, pApellido, sApellido, email, foto, dCalle, _
                                               dNumero, CBool(dBis), dApartamento, nacionalidad, sexo, fNac)

            Dim contraCorrecta As Boolean = False

            If Trim(usuario.contrasenia) = usuario.cifrarContrasenia(txtAntiguaContrasenia.Text) Then
                contraCorrecta = True
            Else
                contraCorrecta = False
            End If

            If nuevaContra And contraCorrecta Then
                FrmModificarDeportistaDos.setContra(True, contrasenia)
            ElseIf Not contraCorrecta And nuevaContra Then
                If esIngles Then
                    MsgBox("The password is wrong and was not modified.")
                Else
                    MsgBox("La contrasenia es incorrecta y no fue modificada")
                End If
            End If

            'Si se ingresó algún telefono
            If lbxTelefono.Items.Count > 0 Then
                'Se redimensiona la variable telefono según los items que hallan en la lista
                'El hecho de restarle 1 es necesario ya que los vectores comienzan en 0
                ReDim tel(lbxTelefono.Items.Count - 1)

                'Para cada telefono de la lista se lo pasa al array tel
                For i As Integer = 0 To lbxTelefono.Items.Count - 1
                    tel(i) = CInt(lbxTelefono.Items(i))
                Next

                FrmModificarDeportistaDos.setTelefono(tel)

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
                FrmModificarDeportistaDos.instituto = instituto
                FrmModificarDeportistaDos.actualizarActividad()
            End If

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

            FrmModificarDeportistaDos.usuario = usuario
            FrmModificarDeportistaDos.esIngles = esIngles
            FrmModificarDeportistaDos.cargarDatos()
            nav.siguiente(FrmModificarDeportistaDos)
        End If


    End Sub

    Private Sub btnBajaTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajaTelefono.Click
        Dim strError As String = "Debe seleccionar un telefono."
        If esIngles Then
            strError = "You must select a phone."
        End If
        If lbxTelefono.SelectedItem = "" Then
            MsgBox(strError)
        Else
            lbxTelefono.Items.Remove(lbxTelefono.SelectedItem)
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

    Private Sub btnAltaTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaTelefono.Click
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
End Class