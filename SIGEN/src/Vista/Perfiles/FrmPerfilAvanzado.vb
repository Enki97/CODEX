Public Class FrmPerfilAvanzado
    Public usuario As Avanzado
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub cargar()
        Dim dia, mes, anio, edad As Integer
        dia = usuario.fechaNacimiento.Day
        mes = usuario.fechaNacimiento.Month
        anio = usuario.fechaNacimiento.Year

        If Now.Month > mes Then
            edad = Now.Year - anio
        ElseIf Now.Month = mes Then
            If Now.Day > dia Then
                edad = Now.Year - anio
            Else
                edad = Now.Year - anio
                edad -= 1
            End If
        Else
            edad = Now.Year - anio
            edad -= 1
        End If

        lblMostrarNFuncionario.Text = usuario.nroFuncionario
        If Not usuario.dirApartamento = Nothing Then
            lblMostrarApto.Text = usuario.dirApartamento
        Else
            lblMostrarApto.Text = "----"
        End If
        lblMostrarCalle.Text = usuario.dirCalle
        lblMostrarDocumento.Text = usuario.documento
        lblMostrarEdad.Text = edad
        lblMostrarEmail.Text = usuario.email
        lblMostrarNacionalidad.Text = usuario.nacionalidad
        lblMostrarNroPuerta.Text = usuario.dirNumero
        lblMostrarPriApellido.Text = usuario.primerApellido
        lblMostrarPriNombre.Text = usuario.primerNombre
        lblMostrarSegApellido.Text = usuario.segundoApellido
        If Not usuario.segundoNombre Is Nothing Then
            lblMostrarSegNombre.Text = usuario.segundoNombre
        Else
            lblMostrarSegNombre.Text = "--------"
        End If

        If esIngles Then
            If CChar(usuario.sexo) = "M" Or CChar(usuario.sexo) = "m" Then
                lblMostrarSexo.Text = "Male"
            Else
                lblMostrarSexo.Text = "Female"
            End If
        Else
            lblMostrarSexo.Text = usuario.sexo
        End If

        If usuario.dirBis = 1 Then
            ckbBIS.Checked = True
        End If
        If Not usuario.foto Is Nothing Then
            imgFoto.LoadAsync(usuario.foto)
            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            imgFoto.LoadAsync("http://eloboost.la/miembros/images/user/user_perfil_defecto.jpg")
            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        ltbTelefono.Items.Clear()
        If Not usuario.telefono(0) = Nothing Then 'Si hay telefono en la base de datos
            For Each t As Integer In usuario.telefono
                ltbTelefono.Items.Add(t.ToString)
            Next
        End If


    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        nav.anterior()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        FrmModificarAvanzado.esIngles = esIngles
        FrmModificarAvanzado.usuario = usuario
        FrmModificarAvanzado.cargarDatos()
        nav.siguiente(FrmModificarAvanzado)
    End Sub

    Private Sub FrmPerfilAvanzado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar()
        'Sistema bilingüe
        If esIngles Then
            Me.Text = "Profile"
            gbxDatosPersonales.Text = "Personal Data"
            gbxDomicilio.Text = "Address"
            gbxNombre.Text = "Full Name"
            lblApartamento.Text = "Apartment:"
            lblDocumento.Text = "Document:"
            lblEdad.Text = "Age:"
            lblEmail.Text = "Email:"
            lblNacionalidad.Text = "Nacionality:"
            lblNroPuerta.Text = "Door's Number:"
            lblPriApellido.Text = "Last Name:"
            lblSegApellido.Text = "Second Last Name:"
            lblPriNombre.Text = "First Name:"
            lblSegNombre.Text = "Middle Name:"
            lblSexo.Text = "Gender:"
            lblTelefono.Text = "Phone:"
            lblNFuncionario.Text = "Number of Official:"
            lblCalle.Text = "Street"
            btnBaja.Text = "Delete"
            btnCancelar.Text = "Back"
            btnModificar.Text = "Modify"

        End If
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strBorrar As String = "Esta seguro? (Para habilitar nuevamente al usuario contacte con un administrador)"
        Dim strOK As String = "Usuario eliminado correctamente."
        If esIngles Then
            strBorrar = "Are you sure? (In order to enable the user again contact an administrator)"
            strOK = "User deleted successfully."
        End If
        If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            usuario.bajaUsuario(usuario.documento)
            MsgBox(strOK)
        End If
    End Sub
End Class