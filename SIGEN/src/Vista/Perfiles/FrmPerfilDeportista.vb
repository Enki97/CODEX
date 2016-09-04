Public Class FrmPerfilDeportista
    Public usuario As Deportista
    Public esIngles As Boolean = False
    Dim nav = New Navegacion(Me)

    Public Sub cargarPerfil()
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

        lblMostrarNSocio.Text = usuario.nroSocio
        If Not usuario.dirApartamento = Nothing Then
            lblMostrarApartamento.Text = usuario.dirApartamento
        Else
            lblMostrarApartamento.Text = "----"
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
            If CChar(usuario.sexo) = "M" Then
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
        If Not usuario.telefono Is Nothing Then 'Si hay telefono en la base de datos
            For Each t As Integer In usuario.telefono
                ltbTelefono.Items.Add(t.ToString)
            Next
        End If

        If usuario.realiza.realizaActividad Then
            Dim actividad As New Actividad(usuario.realiza.id_actividad)
            lblConsultarActividad.Text = actividad.nombre
            lblConsultarPosicion.Text = usuario.realiza.posicion
        Else
            lblConsultarActividad.Text = "----------"
            lblConsultarPosicion.Text = "----------"
        End If

        If usuario.entrenador Is Nothing Then
            lblConsultarEntrenador.Text = "---------"
        Else
            lblConsultarEntrenador.Text = Trim(usuario.entrenador.primerApellido) + ", " + Trim(usuario.entrenador.primerNombre)
        End If

        lblConsultarAltura.Text = usuario.altura.ToString

        If esIngles Then
            If CChar(usuario.criterio) = "D" Then
                lblConsultarCriterio.Text = "Directed"
            Else
                lblConsultarCriterio.Text = "Free"
            End If
        Else
            lblConsultarCriterio.Text = usuario.criterio
        End If

        lblConsultarPeso.Text = usuario.peso.ToString
        If esIngles Then
            If usuario.somatotipo = "Ectomorfo" Then
                lblConsultarSomatotipo.Text = "Ectomorph"
            ElseIf usuario.somatotipo = "Mesomorfo" Then
                lblConsultarSomatotipo.Text = "Mesomorph"
            Else
                lblConsultarSomatotipo.Text = "Endomorph"
            End If
        Else
            lblConsultarSomatotipo.Text = usuario.somatotipo
        End If

        lblConsultarVenFichaMedica.Text = usuario.venFichaMedica.Day.ToString + "/" + usuario.venFichaMedica.Month.ToString + "/" + _
        usuario.venFichaMedica.Year.ToString

        lblMostrarIMC.Text = usuario.imc

        ltbAlergias.Items.Clear()
        If Not usuario.alergias Is Nothing Then
            For Each a As String In usuario.alergias
                ltbAlergias.Items.Add(a)
            Next
        End If

        ltbMedicamentos.Items.Clear()
        If Not usuario.medicamentos Is Nothing Then
            For Each m As String In usuario.medicamentos
                ltbMedicamentos.Items.Add(m)
            Next
        End If

        ltbOperaciones.Items.Clear()
        If Not usuario.operaciones Is Nothing Then
            For Each o As String In usuario.operaciones
                ltbOperaciones.Items.Add(o)
            Next
        End If

        ltbVacunas.Items.Clear()
        If Not usuario.vacunas Is Nothing Then
            For Each v As String In usuario.vacunas
                ltbVacunas.Items.Add(v)
            Next
        End If

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        tabDeportista.SelectedIndex = 0
        nav.anterior()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        FrmModificarDeportista.esIngles = esIngles
        FrmModificarDeportista.usuario = usuario
        FrmModificarDeportista.cargarDatos()
        nav.siguiente(FrmModificarDeportista)
    End Sub

    Private Sub btnEvolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvolucion.Click
        If usuario.tieneCalificacion() Then
            FrmEvolucion.deportista = usuario
            FrmEvolucion.esIngles = esIngles
            nav.siguiente(FrmEvolucion)
        Else
            If esIngles Then
                MsgBox("The sportman has no qualifications currently")
            Else
                MsgBox("El deportista no calificaciones actualmente")
            End If
        End If
    End Sub

    Private Sub btnPlanEntrenamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanEntrenamiento.Click
        If usuario.tienePlanes() Then
            Dim plan As New PlanesEntrenamiento(usuario.ultimoPlan())
            FrmPlanEntrenamiento.esIngles = esIngles
            FrmPlanEntrenamiento.plan = plan
            nav.siguiente(FrmPlanEntrenamiento)
        Else
            If esIngles Then
                MsgBox("The sportman has no training plans currently")
            Else
                MsgBox("El deportista no tiene planes de entrenamiento actualmente")
            End If
        End If
    End Sub

    Private Sub FrmPerfilDeportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            lblNSocio.Text = "Member's Number:"
            lblCalle.Text = "Street"
            btnBaja.Text = "Delete"
            btnCancelar.Text = "Back"
            btnModificar.Text = "Modify"
            tabDatosPersonales.Text = "Personal Data"
            tabDatosDeportivos.Text = "Sports Data"
            btnEvolucion.Text = "Evolution"
            btnPlanEntrenamiento.Text = "Training Plan"
            gbxDatosDeportivos.Text = "Sports Data"
            lblPeso.Text = "Weight:"
            lblAltura.Text = "Height:"
            lblSomatotipo.Text = "Somatotype:"
            lblActividad.Text = "Sport/Activity:"
            lblPosicion.Text = "Position/Mode:"
            lblVenFichaMedica.Text = "Medical Record Expiration:"
            lblEntrenador.Text = "Coach:"
            lblMedicamentos.Text = "Medicine"
            lblOperaciones.Text = "Surgeries"
            lblAlergias.Text = "Allergies"
            lblVacunas.Text = "Vaccines"
            lblCriterio.Text = "Criterion"
        End If
        'Cargar Datos
        Me.cargarPerfil()
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim strBorrar As String = "Esta seguro? (Para habilitar nuevamente al deportista contacte con un administrador)"
        Dim strOK As String = "Usuario eliminado correctamente."
        If esIngles Then
            strBorrar = "Are you sure? (In order to enable the sportman again contact an administrator)"
            strOK = "User deleted successfully."
        End If
        If MsgBox(strBorrar, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            usuario.bajaUsuario(usuario.documento)
            MsgBox(strOK)
            FrmListaDeportistas.actualizarLista()
            nav.anterior()
        End If
    End Sub
End Class