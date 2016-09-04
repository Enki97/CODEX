Public Class FrmModificarInstituto
    Public esIngles As Boolean = False
    Public instituto As Instituto
    Dim nav = New Navegacion(Me)

    Public Sub cargarDatos()
        Dim noTel As String = "No se han ingresado telefonos."
        If esIngles Then
            noTel = "No phones added yet."
        End If
        txtNombre.Text = Trim(instituto.nombre)
        txtEmail.Text = Trim(instituto.email)
        txtSitioWeb.Text = Trim(instituto.web)
        txtCalle.Text = Trim(instituto.dCalle)
        txtNumero.Text = Trim(instituto.dNumero)

        If instituto.dBis Then
            ckbBIS.Checked = True
        End If

        lbxTelefono.Items.Clear()
        If instituto.telefono Is Nothing Then
            lbxTelefono.Items.Add(noTel)
        Else
            For Each tel As Integer In instituto.telefono
                If Not tel = Nothing Then
                    lbxTelefono.Items.Add(tel.ToString)
                End If
            Next
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim dNumero, telefono() As Integer
        Dim dBis As Boolean
        Dim nombre, email, sitioWeb, dCalle As String
        Dim faltan As Boolean = False
        Dim invalido As Boolean = False
        Dim strFaltan, strInvalido, strCorrecto As String
        If esIngles Then
            strFaltan = "The following fields are required: "
            strInvalido = "The following fields are invalid: "
            strCorrecto = "Successfully registered."
        Else
            strFaltan = "Faltan campos obligatorios: "
            strInvalido = "Los siguientes campos son inválidos: "
            strCorrecto = "Procedimiento Correcto."
        End If

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
        Else
            If ckbBIS.Checked Then
                dBis = True
            Else
                dBis = False
            End If
            instituto.modificarInstituto(instituto.rut, nombre, dCalle, dNumero, dBis, email, sitioWeb)
            'Si se ingresó algún telefono
            If lbxTelefono.Items.Count > 0 Then
                'Se redimensiona la variable telefono según los items que hallan en la lista
                'El hecho de restarle 1 es necesario ya que los vectores comienzan en 0
                ReDim telefono(lbxTelefono.Items.Count - 1)

                'Para cada telefono de la lista se lo pasa al array tel
                For i As Integer = 0 To lbxTelefono.Items.Count - 1
                    telefono(i) = CInt(lbxTelefono.Items(i))
                Next

                'Se registran los telefonos pasandole el rut y el vector tel
                instituto.modificarTelefono(instituto.rut, telefono)
            End If

            MsgBox(strCorrecto)

            FrmInstituto.instituto = New Instituto(instituto.rut)
            FrmInstituto.cargarDatos()

            nav.anterior()
        End If
    End Sub

    Private Sub FrmModificarInstituto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If esIngles Then
            Me.Text = "Institute Modify"
            lblNombre.Text = "Name:"
            lblSitioWeb.Text = "Website:"
            gbxDireccion.Text = "Address"
            lblCalle.Text = "Street:"
            lblNumero.Text = "Door's Number:"
            lblTelefono.Text = "Phone:"
            btnCancelar.Text = "Cancel"
            btnGuardar.Text = "Save"
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

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        'si se presiona la tecla enter cuando estamos en el campo de ingresar telefono
        'se ejecuta la funcion que simula el evento click en el boton de agregar telefono
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnAltaTelefono.PerformClick()
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
End Class