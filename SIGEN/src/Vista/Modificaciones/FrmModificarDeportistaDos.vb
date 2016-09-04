Public Class FrmModificarDeportistaDos
    Public esIngles As Boolean = False
    Public usuario As Deportista
    Dim nav = New Navegacion(Me)
    Dim telEliminados() As Integer
    Dim eliminaTelefonos As Boolean = False


    Dim dNumero, dApartamento, telefono(), documento As Integer
    Dim dBis As Boolean
    Dim pNombre, sNombre, pApellido, sApellido, email, foto, dCalle, nacionalidad, sexo, contrasenia As String
    Dim fNac As Date
    Public instituto As Instituto
    Dim rol As String = "deportista"
    Dim cambiaContra As Boolean = False

    Public Sub actualizarActividad()
        cmbDeporte.Items.Clear()
        If instituto Is Nothing Then
            Dim actividades As New Actividad()
            Dim lista() As String
            lista = actividades.listar
            If Not lista Is Nothing Then
                For Each actividad In lista
                    cmbDeporte.Items.Add(actividad)
                Next
            End If
        Else
            Dim lista() As String
            lista = instituto.actividades
            If Not lista Is Nothing Then
                For Each actividad In lista
                    cmbDeporte.Items.Add(actividad)
                Next
            End If
        End If
    End Sub

    Public Sub cargarDatos()

        If usuario.realiza.realizaActividad Then
            Dim actividad As New Actividad(usuario.realiza.id_actividad)
            cmbDeporte.SelectedText = actividad.id_actividad.ToString + " : " + Trim(actividad.nombre)
            txtPosicion.Text = Trim(usuario.realiza.posicion)
        End If

        txtAltura.Text = usuario.altura.ToString

        If esIngles Then
            If CChar(usuario.criterio) = "D" Then
                cmbCriterio.SelectedText = "Directed"
            Else
                cmbCriterio.SelectedText = "Free"
            End If
        Else
            cmbCriterio.SelectedText = Trim(usuario.criterio)
        End If

        txtPeso.Text = usuario.peso.ToString
        If esIngles Then
            If Trim(usuario.somatotipo) = "Ectomorfo" Then
                cmbSomatotipo.SelectedText = "Ectomorph"
            ElseIf Trim(usuario.somatotipo) = "Mesomorfo" Then
                cmbSomatotipo.SelectedText = "Mesomorph"
            Else
                cmbSomatotipo.SelectedText = "Endomorph"
            End If
        Else
            cmbSomatotipo.SelectedText = Trim(usuario.somatotipo)
        End If

        dtpVencimientoFichaMedica.Value = usuario.venFichaMedica

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

    Public Sub setDatos(ByVal documento As Integer, ByVal pNombre As String, ByVal sNombre As String, ByVal pApellido As String, _
                        ByVal sApellido As String, ByVal email As String, ByVal foto As String, _
                        ByVal dCalle As String, ByVal dNumero As Integer, ByVal dBis As Boolean, _
                        ByVal dApartamento As Integer, ByVal nacionalidad As String, ByVal sexo As String, _
                        ByVal fNac As Date)
        Me.documento = documento
        Me.pNombre = pNombre
        Me.sNombre = sNombre
        Me.pApellido = pApellido
        Me.sApellido = sApellido
        Me.email = email
        Me.foto = foto
        Me.dCalle = dCalle
        Me.dNumero = dNumero
        Me.dBis = dBis
        Me.dApartamento = dApartamento
        Me.nacionalidad = nacionalidad
        Me.sexo = sexo
        Me.fNac = fNac
    End Sub
    Public Sub setContra(ByVal cambiaContra As Boolean, ByVal contrasenia As String)
        If cambiaContra Then
            Me.cambiaContra = True
            Me.contrasenia = contrasenia
        End If
    End Sub
    Public Sub setTelefono(ByVal telefono() As Integer)
        Me.telefono = telefono
    End Sub
    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        FrmModificarDeportista.cargarDatos()
        Me.instituto = Nothing
        nav.anterior()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim altura, peso As Integer
        Dim criterio, somatotipo, posicion, deporte, alergias(), medicamentos(), operaciones(), vacunas() As String
        Dim venFMedic As Date
        Dim faltan As Boolean = False
        Dim strFaltan As String = "Faltan campos obligatorios: "
        Dim strCorrecto As String = "Usuario registrado correctamente."
        If esIngles Then
            strFaltan = "The following fields are required: "
            strCorrecto = "Successfully registered."
        End If

        If dtpVencimientoFichaMedica.Value > Now Then
            venFMedic = dtpVencimientoFichaMedica.Value
        Else
            faltan = True
            If esIngles Then
                strFaltan += "/Medical Record"
            Else
                strFaltan += "/Ficha Medica"
            End If
        End If

        If txtAltura.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Height"
            Else
                strFaltan += "/Altura"
            End If

        Else
            altura = txtAltura.Text
        End If


        If txtPeso.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Weight"
            Else
                strFaltan += "/Peso"
            End If
        Else
            peso = txtPeso.Text
        End If

        If cmbCriterio.SelectedItem = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Criterion"
            Else
                strFaltan += "/Criterio"
            End If
        Else
            criterio = cmbCriterio.SelectedItem.ToString
            If criterio = "Free" Then
                criterio = "Libre"
            ElseIf criterio = "Directed" Then
                criterio = "Dirigido"
            End If
        End If
        If cmbSomatotipo.SelectedItem = "" And criterio = "Dirigido" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Somatotype"
            Else
                strFaltan += "/Somatotipo"
            End If
        ElseIf cmbSomatotipo.SelectedItem = "" Then
            somatotipo = Nothing
        Else
            somatotipo = cmbSomatotipo.SelectedItem.ToString
            If somatotipo = "Ectomorph" Then
                somatotipo = "Ectomorfo"
            ElseIf somatotipo = "Mesomorph" Then
                somatotipo = "Mesomorfo"
            Else
                somatotipo = "Endomorfo"
            End If
        End If

        If cmbCriterio.SelectedItem = "Dirigido" Or cmbCriterio.SelectedItem = "Directed" Then
            If cmbDeporte.Text = "" Then
                faltan = True
                If esIngles Then
                    strFaltan += "/Actividades"
                Else
                    strFaltan += "/Activities"
                End If
            Else
                deporte = cmbDeporte.SelectedItem
            End If
        End If

        If Not cmbDeporte.SelectedItem = "" And txtPosicion.Text = "" Then
            faltan = True
            If esIngles Then
                strFaltan += "/Position"
            Else
                strFaltan += "/Posicion"
            End If
        ElseIf Not cmbDeporte.SelectedItem = "" And Not txtPosicion.Text = "" Then
            posicion = txtPosicion.Text
        End If

        If faltan Then
            MsgBox(strFaltan + "/", MsgBoxStyle.Critical)
        Else
            Dim realiza = New Realiza()
            usuario.modificarUsuario(documento, pNombre, pApellido, sApellido, fNac, email, dCalle, dNumero, nacionalidad, sexo, _
                                     sNombre, dBis, dApartamento, foto)

            If Not telefono Is Nothing Then
                usuario.modificarTelefono(documento, telefono)
            End If


            usuario.modificarDeportista(documento, altura, peso, venFMedic, criterio, somatotipo)

            Dim id_actividad As Integer
            Dim strID As String = ""
            For Each c As Char In cmbDeporte.SelectedItem.ToString
                If c = ":" Then
                    Exit For
                Else
                    strID += c
                End If
            Next
            id_actividad = CInt(Trim(strID))
            realiza.modificar(documento, id_actividad, posicion)
            'Si el usuario ingresó alergias
            If ltbAlergias.Items.Count > 0 Then
                ReDim alergias(ltbAlergias.Items.Count - 1)
                For i As Integer = 0 To ltbAlergias.Items.Count - 1
                    alergias(i) = ltbAlergias.Items(i)
                Next
                usuario.modificarAlergias(documento, alergias)
            End If

            'Si el usuario ingresó medicamentos
            If ltbMedicamentos.Items.Count > 0 Then
                ReDim medicamentos(ltbMedicamentos.Items.Count - 1)
                For i As Integer = 0 To ltbMedicamentos.Items.Count - 1
                    medicamentos(i) = ltbMedicamentos.Items(i)
                Next
                usuario.modificarMedicamentos(documento, medicamentos)
            End If

            'Si el usuario ingresó operaciones
            If ltbOperaciones.Items.Count > 0 Then
                ReDim operaciones(ltbOperaciones.Items.Count - 1)
                For i As Integer = 0 To ltbOperaciones.Items.Count - 1
                    operaciones(i) = ltbOperaciones.Items(i)
                Next

                usuario.modificarOperaciones(documento, operaciones)
            End If

            If ltbVacunas.Items.Count > 0 Then
                ReDim vacunas(ltbVacunas.Items.Count - 1)
                For i As Integer = 0 To ltbVacunas.Items.Count - 1
                    vacunas(i) = ltbVacunas.Items(i)
                Next
                usuario.modificarVacunas(documento, vacunas)
            End If

            If Not instituto Is Nothing Then
                instituto.modificarPertenece(documento)
            End If

            MsgBox(strCorrecto)

            'Borra los campos de este formulario
            txtAltura.Text = ""
            txtPeso.Text = ""
            dtpVencimientoFichaMedica.Value = Now
            cmbCriterio.ResetText()
            cmbSomatotipo.ResetText()


            'Borra todos los campos del primer formulario, si no se hacen hay que borrarlo manualmente al ingresar otro usuario
            FrmAltaDeportista.txtApartamento.Text = ""
            FrmAltaDeportista.txtCalle.Text = ""
            FrmAltaDeportista.txtContrasenia.Text = ""
            FrmAltaDeportista.txtRepetirContrasenia.Text = ""
            FrmAltaDeportista.txtDocumento.Text = ""
            FrmAltaDeportista.txtEmail.Text = ""
            FrmAltaDeportista.txtFotoURL.Text = ""
            FrmAltaDeportista.txtNumero.Text = ""
            FrmAltaDeportista.txtPriApellido.Text = ""
            FrmAltaDeportista.txtPriNombre.Text = ""
            FrmAltaDeportista.txtSegApellido.Text = ""
            FrmAltaDeportista.txtSegNombre.Text = ""
            FrmAltaDeportista.txtTelefono.Text = ""
            FrmAltaDeportista.rbnFemenino.Checked = False
            FrmAltaDeportista.rbnMasculino.Checked = False
            FrmAltaDeportista.dtpFechaNacimiento.Value = Now
            FrmAltaDeportista.cmbNacionalidad.ResetText()
            FrmAltaDeportista.lbxTelefono.Items.Clear()

            FrmPerfilDeportista.usuario = New Deportista(documento)
            FrmPerfilDeportista.cargarPerfil()
            FrmPerfilDeportista.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub FrmModificarDeportistaDos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.actualizarActividad()
        If esIngles Then
            Me.Text = "Sportman Modify"
            gbxDatosFisicos.Text = "Pyshic Data"
            gbxSalud.Text = "Health"
            lblAlergias.Text = "Allergies"
            lblAltura.Text = "Height:"
            lblDeporte.Text = "Sport:"
            lblMedicamentos.Text = "Medicine"
            lblOperaciones.Text = "Surgeries"
            lblPeso.Text = "Weight:"
            lblPosicion.Text = "Position/Mode:"
            lblSomatotipo.Text = "Somatotype:"
            lblVacunas.Text = "Vaccines"
            lblVencimientoFichaMedica.Text = "Medical Record Expiration"
            lblCriterio.Text = "Criterion:"
            btnGuardar.Text = "Save"
            btnAtras.Text = "Back"
            cmbCriterio.Items.Add("Directed")
            cmbCriterio.Items.Add("Free")
            cmbSomatotipo.Items.Add("Ectomorph")
            cmbSomatotipo.Items.Add("Mesomorph")
            cmbSomatotipo.Items.Add("Endomorph")
        Else
            cmbCriterio.Items.Add("Dirigido")
            cmbCriterio.Items.Add("Libre")
            cmbSomatotipo.Items.Add("Ectomorfo")
            cmbSomatotipo.Items.Add("Mesomorfo")
            cmbSomatotipo.Items.Add("Endomorfo")
        End If
    End Sub

    Private Sub btnAltaMedicamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaMedicamentos.Click
        Dim strDebeIngresar As String = "Debe ingresar un medicamento"

        If esIngles Then
            strDebeIngresar = "You must input a medicine."
        End If

        If txtMedicamentos.Text = "" Then
            MsgBox(strDebeIngresar)
        Else
            ltbMedicamentos.Items.Add(txtMedicamentos.Text)
            txtMedicamentos.Text = ""
        End If
    End Sub

    Private Sub txtMedicamentos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMedicamentos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnAltaMedicamentos.PerformClick()
        End If
    End Sub


    Private Sub btnAltaOperaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaOperaciones.Click
        Dim strDebeIngresar As String = "Debe ingresar una operacion"

        If esIngles Then
            strDebeIngresar = "You must input a surgery."
        End If

        If txtOperaciones.Text = "" Then
            MsgBox(strDebeIngresar)
        Else
            ltbOperaciones.Items.Add(txtOperaciones.Text)
            txtOperaciones.Text = ""
        End If
    End Sub


    Private Sub txtOperaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperaciones.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnAltaOperaciones.PerformClick()
        End If
    End Sub

    Private Sub btnAltaAlergias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaAlergias.Click
        Dim strDebeIngresar As String = "Debe ingresar una alergia"

        If esIngles Then
            strDebeIngresar = "You must input a allergy."
        End If

        If txtAlergias.Text = "" Then
            MsgBox(strDebeIngresar)
        Else
            ltbAlergias.Items.Add(txtAlergias.Text)
            txtAlergias.Text = ""
        End If
    End Sub


    Private Sub txtAlergias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlergias.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnAltaAlergias.PerformClick()
        End If
    End Sub


    Private Sub btnAltaVacunas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaVacunas.Click
        Dim strDebeIngresar As String = "Debe ingresar una vacuna."

        If esIngles Then
            strDebeIngresar = "You must input a vaccine."
        End If

        If txtVacunas.Text = "" Then
            MsgBox(strDebeIngresar)
        Else
            ltbVacunas.Items.Add(txtVacunas.Text)
            txtVacunas.Text = ""
        End If
    End Sub

    Private Sub txtVacunas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVacunas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnAltaVacunas.PerformClick()
        End If
    End Sub

    Private Sub btnBajaMedicamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajaMedicamentos.Click
        Dim strError As String = "Debe seleccionar un medicamento."
        If esIngles Then
            strError = "You must select a medicine."
        End If
        If ltbMedicamentos.SelectedItem = "" Then
            MsgBox(strError)
        Else
            ltbMedicamentos.Items.Remove(ltbMedicamentos.SelectedItem)
        End If
    End Sub

    Private Sub btnBajaOperaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajaOperaciones.Click
        Dim strError As String = "Debe seleccionar una operación."
        If esIngles Then
            strError = "You must select an surgey."
        End If
        If ltbOperaciones.SelectedItem = "" Then
            MsgBox(strError)
        Else
            ltbOperaciones.Items.Remove(ltbOperaciones.SelectedItem)
        End If
    End Sub

    Private Sub btnBajaAlergias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajaAlergias.Click
        Dim strError As String = "Debe seleccionar una alergia."
        If esIngles Then
            strError = "You must select an allergy."
        End If
        If ltbAlergias.SelectedItem = "" Then
            MsgBox(strError)
        Else
            ltbAlergias.Items.Remove(ltbAlergias.SelectedItem)
        End If
    End Sub

    Private Sub btnBajaVacunas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajaVacunas.Click
        Dim strError As String = "Debe seleccionar una vacuna."
        If esIngles Then
            strError = "You must select a vaccine."
        End If
        If ltbVacunas.SelectedItem = "" Then
            MsgBox(strError)
        Else
            ltbVacunas.Items.Remove(ltbVacunas.SelectedItem)
        End If
    End Sub
End Class