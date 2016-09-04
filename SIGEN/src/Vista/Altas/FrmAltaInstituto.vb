Public Class FrmAltaInstituto
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtRUT.Text = ""
        txtCalle.Text = ""
        txtEmail.Text = ""
        txtNombre.Text = ""
        txtNumero.Text = ""
        txtSitioWeb.Text = ""
        txtTel.Text = ""
        lbxTelefono.Items.Clear()
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rut As Long
        Dim dNumero, telefono() As Integer
        Dim dBis As Boolean
        Dim nombre, email, sitioWeb, dCalle As String
        Dim faltan As Boolean = False
        Dim invalido As Boolean = False
        Dim existe As Boolean = False
        Dim strFaltan, strExiste, strInvalido, strCorrecto As String
        Dim instituto As New Instituto()

        If esIngles Then
            strFaltan = "The following fields are required: "
            strExiste = "The entered institute already exist."
            strInvalido = "The following fields are invalid: "
            strCorrecto = "Successfully registered."
        Else
            strFaltan = "Faltan campos obligatorios: "
            strExiste = "El instituto ingresado ya existe"
            strInvalido = "Los siguientes campos son inválidos: "
            strCorrecto = "Procedimiento Correcto."
        End If

        If txtRUT.Text = "" Then  'Si es vacio
            faltan = True
            strFaltan += "/RUT"
        ElseIf txtRUT.Text.Length <> 12 Then
            invalido = True
            strInvalido += "/RUT"
        Else 'si no es vacio
            'comprobamos que tenga solo numero
            For Each c As Char In txtRUT.Text
                If Not Char.IsDigit(c) Then
                    invalido = True
                    strInvalido += "/RUT"
                    Exit For
                End If
            Next
            If Not invalido Then 'si solo tiene numeros
                If instituto.yaExiste(CLng(txtRUT.Text)) Then 'si ya existe
                    existe = True
                Else 'si no existe
                    rut = CLng(txtRUT.Text)
                End If 'Termina si existe
            End If 'End if solo tiene numeros
        End If 'End if si no es vacio

        If txtNombre.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Name"
            Else
                strFaltan += "/Nombre"
            End If
        Else
            nombre = txtNombre.Text
        End If

        If txtEmail.Text = "" Then
            faltan = True
            strFaltan += "/Email"
        Else
            Dim val As New Validacion(txtEmail.Text)
            If val.mail() Then
                email = txtEmail.Text
            Else
                invalido = True
                strInvalido += "/Email"
            End If
        End If

        If txtSitioWeb.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Website"
            Else
                strFaltan += "/Sitio Web"
            End If
        Else
            sitioWeb = txtSitioWeb.Text
        End If

        If txtCalle.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Street"
            Else
                strFaltan += "/Calle"
            End If
        Else
            dCalle = txtCalle.Text
        End If

        If txtNumero.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Door's Number"
            Else
                strFaltan += "/Número de Puerta"
            End If
        Else
            For Each c As Char In txtNumero.Text
                If Not Char.IsDigit(c) Then
                    invalido = True
                    If esIngles Then
                        strInvalido += "/Door's Number"
                    Else
                        strInvalido += "/Número de Puerta"
                    End If
                    Exit For
                End If
            Next
            If Not invalido Then
                dNumero = CInt(txtNumero.Text)
            End If
        End If

        If faltan Then
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        ElseIf invalido Then
            MsgBox(strInvalido + "/", MsgBoxStyle.Critical)
        ElseIf existe Then
            MsgBox(strExiste + "/", MsgBoxStyle.Critical)
        Else
            If ckbBIS.Checked Then
                dBis = True
            Else
                dBis = False
            End If
            instituto.ingresarInstituto(rut, nombre, dCalle, dNumero, dBis, email, sitioWeb)
            'Si se ingresó algún telefono
            If lbxTelefono.Items.Count > 0 Then
                'Se redimensiona la variable telefono según los items que hallan en la lista
                'El hecho de restarle 1 es necesario ya que los vectores comienzan en 0
                ReDim telefono(lbxTelefono.Items.Count - 1)

                'Para cada telefono de la lista se lo pasa al array tel
                For i As Integer = 0 To lbxTelefono.Items.Count - 1
                    telefono(i) = CInt(lbxTelefono.Items(i))
                Next

                'Se registran los telefonos pasandole el documento y el vector tel(ver ingresarTelefono de
                'la clase Usuario).
                instituto.ingresarTelefonos(rut, telefono)
            End If

            MsgBox(strCorrecto)

            txtRUT.Text = ""
            txtCalle.Text = ""
            txtEmail.Text = ""
            txtNombre.Text = ""
            txtNumero.Text = ""
            txtSitioWeb.Text = ""
            txtTel.Text = ""
            lbxTelefono.Items.Clear()
            nav.anterior()
        End If
    End Sub

    Private Sub FrmAltaInstituto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "New Institute"
            lblCalle.Text = "Street:"
            lblNombre.Text = "Name:"
            lblNumero.Text = "Door's Number:"
            lblRUT.Text = "RUT:"
            lblSitioWeb.Text = "Website:"
            lblTelefono.Text = "Phone:"
            gbxDireccion.Text = "Address"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"

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
        For Each caracter As Char In txtTel.Text
            If Not Char.IsDigit(caracter) Then
                soloNumero = False
            End If
        Next

        'Comprobamos que no sea vacio y que solo sean numeros
        'Si solo son numeros añade el telefono a la lista de telefonos
        'y posteriormente deja vacio el campo de ingresar telefonos
        If txtTel.Text = "" Then
            MsgBox(strDebeIngresar)
        ElseIf soloNumero Then
            lbxTelefono.Items.Add(txtTel.Text)
            txtTel.Text = ""
        Else
            MsgBox(strSoloNumero, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        'si se presiona la tecla enter cuando estamos en el campo de ingresar telefono
        'se ejecuta la funcion que simula el evento click en el boton de agregar telefono
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnAltaTelefono.PerformClick()
        End If
    End Sub
End Class