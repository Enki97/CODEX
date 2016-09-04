<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerfilDeportista
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button
        Me.tabDeportista = New System.Windows.Forms.TabControl
        Me.tabDatosPersonales = New System.Windows.Forms.TabPage
        Me.imgFoto = New System.Windows.Forms.PictureBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.gbxNombre = New System.Windows.Forms.GroupBox
        Me.lblMostrarSegApellido = New System.Windows.Forms.Label
        Me.lblPriNombre = New System.Windows.Forms.Label
        Me.lblSegApellido = New System.Windows.Forms.Label
        Me.lblMostrarPriNombre = New System.Windows.Forms.Label
        Me.lblSegNombre = New System.Windows.Forms.Label
        Me.lblMostrarPriApellido = New System.Windows.Forms.Label
        Me.lblMostrarSegNombre = New System.Windows.Forms.Label
        Me.lblPriApellido = New System.Windows.Forms.Label
        Me.ltbTelefono = New System.Windows.Forms.ListBox
        Me.gbxDatosPersonales = New System.Windows.Forms.GroupBox
        Me.lblNSocio = New System.Windows.Forms.Label
        Me.lblMostrarNSocio = New System.Windows.Forms.Label
        Me.lblDocumento = New System.Windows.Forms.Label
        Me.lblMostrarEmail = New System.Windows.Forms.Label
        Me.lblMostrarDocumento = New System.Windows.Forms.Label
        Me.lblMostrarSexo = New System.Windows.Forms.Label
        Me.lblEdad = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblMostrarEdad = New System.Windows.Forms.Label
        Me.lblSexo = New System.Windows.Forms.Label
        Me.lblNacionalidad = New System.Windows.Forms.Label
        Me.lblMostrarNacionalidad = New System.Windows.Forms.Label
        Me.gbxDomicilio = New System.Windows.Forms.GroupBox
        Me.lblMostrarApartamento = New System.Windows.Forms.Label
        Me.lblMostrarNroPuerta = New System.Windows.Forms.Label
        Me.lblMostrarCalle = New System.Windows.Forms.Label
        Me.ckbBIS = New System.Windows.Forms.CheckBox
        Me.lblApartamento = New System.Windows.Forms.Label
        Me.lblNroPuerta = New System.Windows.Forms.Label
        Me.lblCalle = New System.Windows.Forms.Label
        Me.tabDatosDeportivos = New System.Windows.Forms.TabPage
        Me.lblConsultarCriterio = New System.Windows.Forms.Label
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.lblConsultarEntrenador = New System.Windows.Forms.Label
        Me.lblEntrenador = New System.Windows.Forms.Label
        Me.lblVacunas = New System.Windows.Forms.Label
        Me.btnEvolucion = New System.Windows.Forms.Button
        Me.lblOperaciones = New System.Windows.Forms.Label
        Me.ltbVacunas = New System.Windows.Forms.ListBox
        Me.btnPlanEntrenamiento = New System.Windows.Forms.Button
        Me.ltbOperaciones = New System.Windows.Forms.ListBox
        Me.lblAlergias = New System.Windows.Forms.Label
        Me.gbxDatosDeportivos = New System.Windows.Forms.GroupBox
        Me.lblMostrarIMC = New System.Windows.Forms.Label
        Me.lblIMC = New System.Windows.Forms.Label
        Me.lblConsultarVenFichaMedica = New System.Windows.Forms.Label
        Me.lblConsultarPosicion = New System.Windows.Forms.Label
        Me.lblConsultarActividad = New System.Windows.Forms.Label
        Me.lblConsultarAltura = New System.Windows.Forms.Label
        Me.lblConsultarPeso = New System.Windows.Forms.Label
        Me.lblPeso = New System.Windows.Forms.Label
        Me.lblConsultarSomatotipo = New System.Windows.Forms.Label
        Me.lblVenFichaMedica = New System.Windows.Forms.Label
        Me.lblAltura = New System.Windows.Forms.Label
        Me.lblPosicion = New System.Windows.Forms.Label
        Me.lblSomatotipo = New System.Windows.Forms.Label
        Me.lblActividad = New System.Windows.Forms.Label
        Me.lblMedicamentos = New System.Windows.Forms.Label
        Me.ltbMedicamentos = New System.Windows.Forms.ListBox
        Me.ltbAlergias = New System.Windows.Forms.ListBox
        Me.btnBaja = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.tabDeportista.SuspendLayout()
        Me.tabDatosPersonales.SuspendLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxNombre.SuspendLayout()
        Me.gbxDatosPersonales.SuspendLayout()
        Me.gbxDomicilio.SuspendLayout()
        Me.tabDatosDeportivos.SuspendLayout()
        Me.gbxDatosDeportivos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(894, 442)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tabDeportista
        '
        Me.tabDeportista.Controls.Add(Me.tabDatosPersonales)
        Me.tabDeportista.Controls.Add(Me.tabDatosDeportivos)
        Me.tabDeportista.Location = New System.Drawing.Point(12, 12)
        Me.tabDeportista.Name = "tabDeportista"
        Me.tabDeportista.SelectedIndex = 0
        Me.tabDeportista.Size = New System.Drawing.Size(410, 395)
        Me.tabDeportista.TabIndex = 73
        '
        'tabDatosPersonales
        '
        Me.tabDatosPersonales.Controls.Add(Me.imgFoto)
        Me.tabDatosPersonales.Controls.Add(Me.lblTelefono)
        Me.tabDatosPersonales.Controls.Add(Me.gbxNombre)
        Me.tabDatosPersonales.Controls.Add(Me.ltbTelefono)
        Me.tabDatosPersonales.Controls.Add(Me.gbxDatosPersonales)
        Me.tabDatosPersonales.Controls.Add(Me.gbxDomicilio)
        Me.tabDatosPersonales.Location = New System.Drawing.Point(4, 22)
        Me.tabDatosPersonales.Name = "tabDatosPersonales"
        Me.tabDatosPersonales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatosPersonales.Size = New System.Drawing.Size(402, 369)
        Me.tabDatosPersonales.TabIndex = 0
        Me.tabDatosPersonales.Text = "Datos Personales"
        Me.tabDatosPersonales.UseVisualStyleBackColor = True
        '
        'imgFoto
        '
        Me.imgFoto.Location = New System.Drawing.Point(6, 6)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(131, 102)
        Me.imgFoto.TabIndex = 63
        Me.imgFoto.TabStop = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(264, 114)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 68
        Me.lblTelefono.Text = "Telefono:"
        '
        'gbxNombre
        '
        Me.gbxNombre.Controls.Add(Me.lblMostrarSegApellido)
        Me.gbxNombre.Controls.Add(Me.lblPriNombre)
        Me.gbxNombre.Controls.Add(Me.lblSegApellido)
        Me.gbxNombre.Controls.Add(Me.lblMostrarPriNombre)
        Me.gbxNombre.Controls.Add(Me.lblSegNombre)
        Me.gbxNombre.Controls.Add(Me.lblMostrarPriApellido)
        Me.gbxNombre.Controls.Add(Me.lblMostrarSegNombre)
        Me.gbxNombre.Controls.Add(Me.lblPriApellido)
        Me.gbxNombre.Location = New System.Drawing.Point(143, 6)
        Me.gbxNombre.Name = "gbxNombre"
        Me.gbxNombre.Size = New System.Drawing.Size(248, 102)
        Me.gbxNombre.TabIndex = 64
        Me.gbxNombre.TabStop = False
        Me.gbxNombre.Text = "Nombre Completo"
        '
        'lblMostrarSegApellido
        '
        Me.lblMostrarSegApellido.AutoSize = True
        Me.lblMostrarSegApellido.Location = New System.Drawing.Point(122, 55)
        Me.lblMostrarSegApellido.Name = "lblMostrarSegApellido"
        Me.lblMostrarSegApellido.Size = New System.Drawing.Size(87, 13)
        Me.lblMostrarSegApellido.TabIndex = 10
        Me.lblMostrarSegApellido.Text = "SegundoApellido"
        '
        'lblPriNombre
        '
        Me.lblPriNombre.AutoSize = True
        Me.lblPriNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriNombre.Location = New System.Drawing.Point(6, 16)
        Me.lblPriNombre.Name = "lblPriNombre"
        Me.lblPriNombre.Size = New System.Drawing.Size(79, 13)
        Me.lblPriNombre.TabIndex = 0
        Me.lblPriNombre.Text = "Primer Nombre:"
        '
        'lblSegApellido
        '
        Me.lblSegApellido.AutoSize = True
        Me.lblSegApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegApellido.Location = New System.Drawing.Point(6, 55)
        Me.lblSegApellido.Name = "lblSegApellido"
        Me.lblSegApellido.Size = New System.Drawing.Size(93, 13)
        Me.lblSegApellido.TabIndex = 9
        Me.lblSegApellido.Text = "Segundo Apellido:"
        '
        'lblMostrarPriNombre
        '
        Me.lblMostrarPriNombre.AutoSize = True
        Me.lblMostrarPriNombre.Location = New System.Drawing.Point(122, 16)
        Me.lblMostrarPriNombre.Name = "lblMostrarPriNombre"
        Me.lblMostrarPriNombre.Size = New System.Drawing.Size(73, 13)
        Me.lblMostrarPriNombre.TabIndex = 1
        Me.lblMostrarPriNombre.Text = "PrimerNombre"
        '
        'lblSegNombre
        '
        Me.lblSegNombre.AutoSize = True
        Me.lblSegNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegNombre.Location = New System.Drawing.Point(6, 29)
        Me.lblSegNombre.Name = "lblSegNombre"
        Me.lblSegNombre.Size = New System.Drawing.Size(93, 13)
        Me.lblSegNombre.TabIndex = 2
        Me.lblSegNombre.Text = "Segundo Nombre:"
        '
        'lblMostrarPriApellido
        '
        Me.lblMostrarPriApellido.AutoSize = True
        Me.lblMostrarPriApellido.Location = New System.Drawing.Point(122, 42)
        Me.lblMostrarPriApellido.Name = "lblMostrarPriApellido"
        Me.lblMostrarPriApellido.Size = New System.Drawing.Size(73, 13)
        Me.lblMostrarPriApellido.TabIndex = 7
        Me.lblMostrarPriApellido.Text = "PrimerApellido"
        '
        'lblMostrarSegNombre
        '
        Me.lblMostrarSegNombre.AutoSize = True
        Me.lblMostrarSegNombre.Location = New System.Drawing.Point(122, 29)
        Me.lblMostrarSegNombre.Name = "lblMostrarSegNombre"
        Me.lblMostrarSegNombre.Size = New System.Drawing.Size(87, 13)
        Me.lblMostrarSegNombre.TabIndex = 3
        Me.lblMostrarSegNombre.Text = "SegundoNombre"
        '
        'lblPriApellido
        '
        Me.lblPriApellido.AutoSize = True
        Me.lblPriApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriApellido.Location = New System.Drawing.Point(6, 42)
        Me.lblPriApellido.Name = "lblPriApellido"
        Me.lblPriApellido.Size = New System.Drawing.Size(79, 13)
        Me.lblPriApellido.TabIndex = 4
        Me.lblPriApellido.Text = "Primer Apellido:"
        '
        'ltbTelefono
        '
        Me.ltbTelefono.FormattingEnabled = True
        Me.ltbTelefono.Items.AddRange(New Object() {""})
        Me.ltbTelefono.Location = New System.Drawing.Point(264, 130)
        Me.ltbTelefono.Name = "ltbTelefono"
        Me.ltbTelefono.Size = New System.Drawing.Size(127, 225)
        Me.ltbTelefono.TabIndex = 67
        '
        'gbxDatosPersonales
        '
        Me.gbxDatosPersonales.Controls.Add(Me.lblNSocio)
        Me.gbxDatosPersonales.Controls.Add(Me.lblMostrarNSocio)
        Me.gbxDatosPersonales.Controls.Add(Me.lblDocumento)
        Me.gbxDatosPersonales.Controls.Add(Me.lblMostrarEmail)
        Me.gbxDatosPersonales.Controls.Add(Me.lblMostrarDocumento)
        Me.gbxDatosPersonales.Controls.Add(Me.lblMostrarSexo)
        Me.gbxDatosPersonales.Controls.Add(Me.lblEdad)
        Me.gbxDatosPersonales.Controls.Add(Me.lblEmail)
        Me.gbxDatosPersonales.Controls.Add(Me.lblMostrarEdad)
        Me.gbxDatosPersonales.Controls.Add(Me.lblSexo)
        Me.gbxDatosPersonales.Controls.Add(Me.lblNacionalidad)
        Me.gbxDatosPersonales.Controls.Add(Me.lblMostrarNacionalidad)
        Me.gbxDatosPersonales.Location = New System.Drawing.Point(6, 114)
        Me.gbxDatosPersonales.Name = "gbxDatosPersonales"
        Me.gbxDatosPersonales.Size = New System.Drawing.Size(252, 165)
        Me.gbxDatosPersonales.TabIndex = 66
        Me.gbxDatosPersonales.TabStop = False
        Me.gbxDatosPersonales.Text = "Datos Personales"
        '
        'lblNSocio
        '
        Me.lblNSocio.AutoSize = True
        Me.lblNSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNSocio.Location = New System.Drawing.Point(6, 29)
        Me.lblNSocio.Name = "lblNSocio"
        Me.lblNSocio.Size = New System.Drawing.Size(92, 13)
        Me.lblNSocio.TabIndex = 19
        Me.lblNSocio.Text = "Número de Socio:"
        '
        'lblMostrarNSocio
        '
        Me.lblMostrarNSocio.AutoSize = True
        Me.lblMostrarNSocio.Location = New System.Drawing.Point(108, 29)
        Me.lblMostrarNSocio.Name = "lblMostrarNSocio"
        Me.lblMostrarNSocio.Size = New System.Drawing.Size(42, 13)
        Me.lblMostrarNSocio.TabIndex = 20
        Me.lblMostrarNSocio.Text = "NSocio"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.Location = New System.Drawing.Point(6, 16)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(65, 13)
        Me.lblDocumento.TabIndex = 5
        Me.lblDocumento.Text = "Documento:"
        '
        'lblMostrarEmail
        '
        Me.lblMostrarEmail.AutoSize = True
        Me.lblMostrarEmail.Location = New System.Drawing.Point(6, 94)
        Me.lblMostrarEmail.Name = "lblMostrarEmail"
        Me.lblMostrarEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblMostrarEmail.TabIndex = 18
        Me.lblMostrarEmail.Text = "Email"
        '
        'lblMostrarDocumento
        '
        Me.lblMostrarDocumento.AutoSize = True
        Me.lblMostrarDocumento.Location = New System.Drawing.Point(108, 16)
        Me.lblMostrarDocumento.Name = "lblMostrarDocumento"
        Me.lblMostrarDocumento.Size = New System.Drawing.Size(62, 13)
        Me.lblMostrarDocumento.TabIndex = 6
        Me.lblMostrarDocumento.Text = "Documento"
        '
        'lblMostrarSexo
        '
        Me.lblMostrarSexo.AutoSize = True
        Me.lblMostrarSexo.Location = New System.Drawing.Point(108, 68)
        Me.lblMostrarSexo.Name = "lblMostrarSexo"
        Me.lblMostrarSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblMostrarSexo.TabIndex = 17
        Me.lblMostrarSexo.Text = "Sexo"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(6, 42)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(35, 13)
        Me.lblEdad.TabIndex = 11
        Me.lblEdad.Text = "Edad:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(6, 81)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email:"
        '
        'lblMostrarEdad
        '
        Me.lblMostrarEdad.AutoSize = True
        Me.lblMostrarEdad.Location = New System.Drawing.Point(108, 42)
        Me.lblMostrarEdad.Name = "lblMostrarEdad"
        Me.lblMostrarEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblMostrarEdad.TabIndex = 12
        Me.lblMostrarEdad.Text = "Edad"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(6, 68)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 15
        Me.lblSexo.Text = "Sexo:"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacionalidad.Location = New System.Drawing.Point(6, 55)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblNacionalidad.TabIndex = 13
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'lblMostrarNacionalidad
        '
        Me.lblMostrarNacionalidad.AutoSize = True
        Me.lblMostrarNacionalidad.Location = New System.Drawing.Point(108, 55)
        Me.lblMostrarNacionalidad.Name = "lblMostrarNacionalidad"
        Me.lblMostrarNacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.lblMostrarNacionalidad.TabIndex = 14
        Me.lblMostrarNacionalidad.Text = "Nacionalidad"
        '
        'gbxDomicilio
        '
        Me.gbxDomicilio.Controls.Add(Me.lblMostrarApartamento)
        Me.gbxDomicilio.Controls.Add(Me.lblMostrarNroPuerta)
        Me.gbxDomicilio.Controls.Add(Me.lblMostrarCalle)
        Me.gbxDomicilio.Controls.Add(Me.ckbBIS)
        Me.gbxDomicilio.Controls.Add(Me.lblApartamento)
        Me.gbxDomicilio.Controls.Add(Me.lblNroPuerta)
        Me.gbxDomicilio.Controls.Add(Me.lblCalle)
        Me.gbxDomicilio.Location = New System.Drawing.Point(6, 285)
        Me.gbxDomicilio.Name = "gbxDomicilio"
        Me.gbxDomicilio.Size = New System.Drawing.Size(252, 70)
        Me.gbxDomicilio.TabIndex = 65
        Me.gbxDomicilio.TabStop = False
        Me.gbxDomicilio.Text = "Domicilio"
        '
        'lblMostrarApartamento
        '
        Me.lblMostrarApartamento.AutoSize = True
        Me.lblMostrarApartamento.Location = New System.Drawing.Point(108, 42)
        Me.lblMostrarApartamento.Name = "lblMostrarApartamento"
        Me.lblMostrarApartamento.Size = New System.Drawing.Size(29, 13)
        Me.lblMostrarApartamento.TabIndex = 13
        Me.lblMostrarApartamento.Text = "Apto"
        '
        'lblMostrarNroPuerta
        '
        Me.lblMostrarNroPuerta.AutoSize = True
        Me.lblMostrarNroPuerta.Location = New System.Drawing.Point(108, 29)
        Me.lblMostrarNroPuerta.Name = "lblMostrarNroPuerta"
        Me.lblMostrarNroPuerta.Size = New System.Drawing.Size(44, 13)
        Me.lblMostrarNroPuerta.TabIndex = 13
        Me.lblMostrarNroPuerta.Text = "Numero"
        '
        'lblMostrarCalle
        '
        Me.lblMostrarCalle.AutoSize = True
        Me.lblMostrarCalle.Location = New System.Drawing.Point(108, 16)
        Me.lblMostrarCalle.Name = "lblMostrarCalle"
        Me.lblMostrarCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblMostrarCalle.TabIndex = 4
        Me.lblMostrarCalle.Text = "Calle"
        '
        'ckbBIS
        '
        Me.ckbBIS.AutoSize = True
        Me.ckbBIS.Location = New System.Drawing.Point(158, 28)
        Me.ckbBIS.Name = "ckbBIS"
        Me.ckbBIS.Size = New System.Drawing.Size(43, 17)
        Me.ckbBIS.TabIndex = 3
        Me.ckbBIS.Text = "BIS"
        Me.ckbBIS.UseVisualStyleBackColor = True
        '
        'lblApartamento
        '
        Me.lblApartamento.AutoSize = True
        Me.lblApartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApartamento.Location = New System.Drawing.Point(6, 42)
        Me.lblApartamento.Name = "lblApartamento"
        Me.lblApartamento.Size = New System.Drawing.Size(70, 13)
        Me.lblApartamento.TabIndex = 2
        Me.lblApartamento.Text = "Apartamento:"
        '
        'lblNroPuerta
        '
        Me.lblNroPuerta.AutoSize = True
        Me.lblNroPuerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroPuerta.Location = New System.Drawing.Point(6, 29)
        Me.lblNroPuerta.Name = "lblNroPuerta"
        Me.lblNroPuerta.Size = New System.Drawing.Size(96, 13)
        Me.lblNroPuerta.TabIndex = 1
        Me.lblNroPuerta.Text = "Número de Puerta:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(6, 16)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 0
        Me.lblCalle.Text = "Calle:"
        '
        'tabDatosDeportivos
        '
        Me.tabDatosDeportivos.Controls.Add(Me.lblConsultarCriterio)
        Me.tabDatosDeportivos.Controls.Add(Me.lblCriterio)
        Me.tabDatosDeportivos.Controls.Add(Me.lblConsultarEntrenador)
        Me.tabDatosDeportivos.Controls.Add(Me.lblEntrenador)
        Me.tabDatosDeportivos.Controls.Add(Me.lblVacunas)
        Me.tabDatosDeportivos.Controls.Add(Me.btnEvolucion)
        Me.tabDatosDeportivos.Controls.Add(Me.lblOperaciones)
        Me.tabDatosDeportivos.Controls.Add(Me.ltbVacunas)
        Me.tabDatosDeportivos.Controls.Add(Me.btnPlanEntrenamiento)
        Me.tabDatosDeportivos.Controls.Add(Me.ltbOperaciones)
        Me.tabDatosDeportivos.Controls.Add(Me.lblAlergias)
        Me.tabDatosDeportivos.Controls.Add(Me.gbxDatosDeportivos)
        Me.tabDatosDeportivos.Controls.Add(Me.lblMedicamentos)
        Me.tabDatosDeportivos.Controls.Add(Me.ltbMedicamentos)
        Me.tabDatosDeportivos.Controls.Add(Me.ltbAlergias)
        Me.tabDatosDeportivos.Location = New System.Drawing.Point(4, 22)
        Me.tabDatosDeportivos.Name = "tabDatosDeportivos"
        Me.tabDatosDeportivos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatosDeportivos.Size = New System.Drawing.Size(402, 369)
        Me.tabDatosDeportivos.TabIndex = 1
        Me.tabDatosDeportivos.Text = "Datos Deportivos"
        Me.tabDatosDeportivos.UseVisualStyleBackColor = True
        '
        'lblConsultarCriterio
        '
        Me.lblConsultarCriterio.AutoSize = True
        Me.lblConsultarCriterio.Location = New System.Drawing.Point(80, 190)
        Me.lblConsultarCriterio.Name = "lblConsultarCriterio"
        Me.lblConsultarCriterio.Size = New System.Drawing.Size(39, 13)
        Me.lblConsultarCriterio.TabIndex = 98
        Me.lblConsultarCriterio.Text = "Criterio"
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(12, 190)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(42, 13)
        Me.lblCriterio.TabIndex = 97
        Me.lblCriterio.Text = "Criterio:"
        '
        'lblConsultarEntrenador
        '
        Me.lblConsultarEntrenador.AutoSize = True
        Me.lblConsultarEntrenador.Location = New System.Drawing.Point(80, 177)
        Me.lblConsultarEntrenador.Name = "lblConsultarEntrenador"
        Me.lblConsultarEntrenador.Size = New System.Drawing.Size(59, 13)
        Me.lblConsultarEntrenador.TabIndex = 96
        Me.lblConsultarEntrenador.Text = "Entrenador"
        '
        'lblEntrenador
        '
        Me.lblEntrenador.AutoSize = True
        Me.lblEntrenador.Location = New System.Drawing.Point(12, 177)
        Me.lblEntrenador.Name = "lblEntrenador"
        Me.lblEntrenador.Size = New System.Drawing.Size(62, 13)
        Me.lblEntrenador.TabIndex = 95
        Me.lblEntrenador.Text = "Entrenador:"
        '
        'lblVacunas
        '
        Me.lblVacunas.AutoSize = True
        Me.lblVacunas.Location = New System.Drawing.Point(298, 252)
        Me.lblVacunas.Name = "lblVacunas"
        Me.lblVacunas.Size = New System.Drawing.Size(49, 13)
        Me.lblVacunas.TabIndex = 94
        Me.lblVacunas.Text = "Vacunas"
        '
        'btnEvolucion
        '
        Me.btnEvolucion.Location = New System.Drawing.Point(6, 6)
        Me.btnEvolucion.Name = "btnEvolucion"
        Me.btnEvolucion.Size = New System.Drawing.Size(390, 30)
        Me.btnEvolucion.TabIndex = 84
        Me.btnEvolucion.Text = "Evolución"
        Me.btnEvolucion.UseVisualStyleBackColor = True
        '
        'lblOperaciones
        '
        Me.lblOperaciones.AutoSize = True
        Me.lblOperaciones.Location = New System.Drawing.Point(200, 252)
        Me.lblOperaciones.Name = "lblOperaciones"
        Me.lblOperaciones.Size = New System.Drawing.Size(67, 13)
        Me.lblOperaciones.TabIndex = 93
        Me.lblOperaciones.Text = "Operaciones"
        '
        'ltbVacunas
        '
        Me.ltbVacunas.FormattingEnabled = True
        Me.ltbVacunas.Location = New System.Drawing.Point(301, 268)
        Me.ltbVacunas.Name = "ltbVacunas"
        Me.ltbVacunas.Size = New System.Drawing.Size(90, 95)
        Me.ltbVacunas.TabIndex = 89
        '
        'btnPlanEntrenamiento
        '
        Me.btnPlanEntrenamiento.Location = New System.Drawing.Point(6, 43)
        Me.btnPlanEntrenamiento.Name = "btnPlanEntrenamiento"
        Me.btnPlanEntrenamiento.Size = New System.Drawing.Size(390, 30)
        Me.btnPlanEntrenamiento.TabIndex = 85
        Me.btnPlanEntrenamiento.Text = "Plan de Entrenamiento"
        Me.btnPlanEntrenamiento.UseVisualStyleBackColor = True
        '
        'ltbOperaciones
        '
        Me.ltbOperaciones.FormattingEnabled = True
        Me.ltbOperaciones.Location = New System.Drawing.Point(203, 268)
        Me.ltbOperaciones.Name = "ltbOperaciones"
        Me.ltbOperaciones.Size = New System.Drawing.Size(90, 95)
        Me.ltbOperaciones.TabIndex = 87
        '
        'lblAlergias
        '
        Me.lblAlergias.AutoSize = True
        Me.lblAlergias.Location = New System.Drawing.Point(101, 252)
        Me.lblAlergias.Name = "lblAlergias"
        Me.lblAlergias.Size = New System.Drawing.Size(44, 13)
        Me.lblAlergias.TabIndex = 92
        Me.lblAlergias.Text = "Alergias"
        '
        'gbxDatosDeportivos
        '
        Me.gbxDatosDeportivos.Controls.Add(Me.lblMostrarIMC)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblIMC)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblConsultarVenFichaMedica)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblConsultarPosicion)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblConsultarActividad)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblConsultarAltura)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblConsultarPeso)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblPeso)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblConsultarSomatotipo)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblVenFichaMedica)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblAltura)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblPosicion)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblSomatotipo)
        Me.gbxDatosDeportivos.Controls.Add(Me.lblActividad)
        Me.gbxDatosDeportivos.Location = New System.Drawing.Point(6, 79)
        Me.gbxDatosDeportivos.Name = "gbxDatosDeportivos"
        Me.gbxDatosDeportivos.Size = New System.Drawing.Size(390, 95)
        Me.gbxDatosDeportivos.TabIndex = 90
        Me.gbxDatosDeportivos.TabStop = False
        Me.gbxDatosDeportivos.Text = "Datos Deportivos"
        '
        'lblMostrarIMC
        '
        Me.lblMostrarIMC.AutoSize = True
        Me.lblMostrarIMC.Location = New System.Drawing.Point(75, 51)
        Me.lblMostrarIMC.Name = "lblMostrarIMC"
        Me.lblMostrarIMC.Size = New System.Drawing.Size(23, 13)
        Me.lblMostrarIMC.TabIndex = 86
        Me.lblMostrarIMC.Text = "imc"
        '
        'lblIMC
        '
        Me.lblIMC.AutoSize = True
        Me.lblIMC.Location = New System.Drawing.Point(6, 51)
        Me.lblIMC.Name = "lblIMC"
        Me.lblIMC.Size = New System.Drawing.Size(29, 13)
        Me.lblIMC.TabIndex = 85
        Me.lblIMC.Text = "IMC:"
        '
        'lblConsultarVenFichaMedica
        '
        Me.lblConsultarVenFichaMedica.AutoSize = True
        Me.lblConsultarVenFichaMedica.Location = New System.Drawing.Point(313, 51)
        Me.lblConsultarVenFichaMedica.Name = "lblConsultarVenFichaMedica"
        Me.lblConsultarVenFichaMedica.Size = New System.Drawing.Size(57, 13)
        Me.lblConsultarVenFichaMedica.TabIndex = 84
        Me.lblConsultarVenFichaMedica.Text = "dd/mm/aa"
        '
        'lblConsultarPosicion
        '
        Me.lblConsultarPosicion.AutoSize = True
        Me.lblConsultarPosicion.Location = New System.Drawing.Point(313, 34)
        Me.lblConsultarPosicion.Name = "lblConsultarPosicion"
        Me.lblConsultarPosicion.Size = New System.Drawing.Size(47, 13)
        Me.lblConsultarPosicion.TabIndex = 83
        Me.lblConsultarPosicion.Text = "Posición"
        '
        'lblConsultarActividad
        '
        Me.lblConsultarActividad.AutoSize = True
        Me.lblConsultarActividad.Location = New System.Drawing.Point(313, 16)
        Me.lblConsultarActividad.Name = "lblConsultarActividad"
        Me.lblConsultarActividad.Size = New System.Drawing.Size(51, 13)
        Me.lblConsultarActividad.TabIndex = 82
        Me.lblConsultarActividad.Text = "Actividad"
        '
        'lblConsultarAltura
        '
        Me.lblConsultarAltura.AutoSize = True
        Me.lblConsultarAltura.Location = New System.Drawing.Point(75, 34)
        Me.lblConsultarAltura.Name = "lblConsultarAltura"
        Me.lblConsultarAltura.Size = New System.Drawing.Size(34, 13)
        Me.lblConsultarAltura.TabIndex = 80
        Me.lblConsultarAltura.Text = "Altura"
        '
        'lblConsultarPeso
        '
        Me.lblConsultarPeso.AutoSize = True
        Me.lblConsultarPeso.Location = New System.Drawing.Point(75, 16)
        Me.lblConsultarPeso.Name = "lblConsultarPeso"
        Me.lblConsultarPeso.Size = New System.Drawing.Size(31, 13)
        Me.lblConsultarPeso.TabIndex = 79
        Me.lblConsultarPeso.Text = "Peso"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(6, 16)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 13)
        Me.lblPeso.TabIndex = 73
        Me.lblPeso.Text = "Peso:"
        '
        'lblConsultarSomatotipo
        '
        Me.lblConsultarSomatotipo.AutoSize = True
        Me.lblConsultarSomatotipo.Location = New System.Drawing.Point(75, 70)
        Me.lblConsultarSomatotipo.Name = "lblConsultarSomatotipo"
        Me.lblConsultarSomatotipo.Size = New System.Drawing.Size(60, 13)
        Me.lblConsultarSomatotipo.TabIndex = 81
        Me.lblConsultarSomatotipo.Text = "Somatotipo"
        '
        'lblVenFichaMedica
        '
        Me.lblVenFichaMedica.AutoSize = True
        Me.lblVenFichaMedica.Location = New System.Drawing.Point(157, 51)
        Me.lblVenFichaMedica.Name = "lblVenFichaMedica"
        Me.lblVenFichaMedica.Size = New System.Drawing.Size(150, 13)
        Me.lblVenFichaMedica.TabIndex = 78
        Me.lblVenFichaMedica.Text = "Vancimiento de Ficha Medica:"
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(6, 34)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(37, 13)
        Me.lblAltura.TabIndex = 74
        Me.lblAltura.Text = "Altura:"
        '
        'lblPosicion
        '
        Me.lblPosicion.AutoSize = True
        Me.lblPosicion.Location = New System.Drawing.Point(157, 34)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(82, 13)
        Me.lblPosicion.TabIndex = 77
        Me.lblPosicion.Text = "Posición/Modo:"
        '
        'lblSomatotipo
        '
        Me.lblSomatotipo.AutoSize = True
        Me.lblSomatotipo.Location = New System.Drawing.Point(6, 70)
        Me.lblSomatotipo.Name = "lblSomatotipo"
        Me.lblSomatotipo.Size = New System.Drawing.Size(63, 13)
        Me.lblSomatotipo.TabIndex = 75
        Me.lblSomatotipo.Text = "Somatotipo:"
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Location = New System.Drawing.Point(157, 16)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(97, 13)
        Me.lblActividad.TabIndex = 76
        Me.lblActividad.Text = "Deporte/Actividad:"
        '
        'lblMedicamentos
        '
        Me.lblMedicamentos.AutoSize = True
        Me.lblMedicamentos.Location = New System.Drawing.Point(3, 252)
        Me.lblMedicamentos.Name = "lblMedicamentos"
        Me.lblMedicamentos.Size = New System.Drawing.Size(76, 13)
        Me.lblMedicamentos.TabIndex = 91
        Me.lblMedicamentos.Text = "Medicamentos"
        '
        'ltbMedicamentos
        '
        Me.ltbMedicamentos.FormattingEnabled = True
        Me.ltbMedicamentos.Location = New System.Drawing.Point(6, 268)
        Me.ltbMedicamentos.Name = "ltbMedicamentos"
        Me.ltbMedicamentos.Size = New System.Drawing.Size(90, 95)
        Me.ltbMedicamentos.TabIndex = 86
        '
        'ltbAlergias
        '
        Me.ltbAlergias.FormattingEnabled = True
        Me.ltbAlergias.Location = New System.Drawing.Point(104, 268)
        Me.ltbAlergias.Name = "ltbAlergias"
        Me.ltbAlergias.Size = New System.Drawing.Size(90, 95)
        Me.ltbAlergias.TabIndex = 88
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(146, 419)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(140, 30)
        Me.btnBaja.TabIndex = 72
        Me.btnBaja.Text = "Eliminar"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(292, 419)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(130, 30)
        Me.btnModificar.TabIndex = 70
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.back
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(12, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 30)
        Me.btnCancelar.TabIndex = 71
        Me.btnCancelar.Text = "&Atras"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmPerfilDeportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 461)
        Me.Controls.Add(Me.tabDeportista)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Button3)
        Me.Name = "FrmPerfilDeportista"
        Me.Text = "Perfil"
        Me.tabDeportista.ResumeLayout(False)
        Me.tabDatosPersonales.ResumeLayout(False)
        Me.tabDatosPersonales.PerformLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxNombre.ResumeLayout(False)
        Me.gbxNombre.PerformLayout()
        Me.gbxDatosPersonales.ResumeLayout(False)
        Me.gbxDatosPersonales.PerformLayout()
        Me.gbxDomicilio.ResumeLayout(False)
        Me.gbxDomicilio.PerformLayout()
        Me.tabDatosDeportivos.ResumeLayout(False)
        Me.tabDatosDeportivos.PerformLayout()
        Me.gbxDatosDeportivos.ResumeLayout(False)
        Me.gbxDatosDeportivos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tabDeportista As System.Windows.Forms.TabControl
    Friend WithEvents tabDatosPersonales As System.Windows.Forms.TabPage
    Friend WithEvents imgFoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents gbxNombre As System.Windows.Forms.GroupBox
    Friend WithEvents lblMostrarSegApellido As System.Windows.Forms.Label
    Friend WithEvents lblPriNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegApellido As System.Windows.Forms.Label
    Friend WithEvents lblMostrarPriNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegNombre As System.Windows.Forms.Label
    Friend WithEvents lblMostrarPriApellido As System.Windows.Forms.Label
    Friend WithEvents lblMostrarSegNombre As System.Windows.Forms.Label
    Friend WithEvents lblPriApellido As System.Windows.Forms.Label
    Friend WithEvents ltbTelefono As System.Windows.Forms.ListBox
    Friend WithEvents gbxDatosPersonales As System.Windows.Forms.GroupBox
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents lblMostrarEmail As System.Windows.Forms.Label
    Friend WithEvents lblMostrarDocumento As System.Windows.Forms.Label
    Friend WithEvents lblMostrarSexo As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblMostrarEdad As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents lblMostrarNacionalidad As System.Windows.Forms.Label
    Friend WithEvents gbxDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents lblMostrarApartamento As System.Windows.Forms.Label
    Friend WithEvents lblMostrarNroPuerta As System.Windows.Forms.Label
    Friend WithEvents lblMostrarCalle As System.Windows.Forms.Label
    Friend WithEvents ckbBIS As System.Windows.Forms.CheckBox
    Friend WithEvents lblApartamento As System.Windows.Forms.Label
    Friend WithEvents lblNroPuerta As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents tabDatosDeportivos As System.Windows.Forms.TabPage
    Friend WithEvents lblVacunas As System.Windows.Forms.Label
    Friend WithEvents btnEvolucion As System.Windows.Forms.Button
    Friend WithEvents lblOperaciones As System.Windows.Forms.Label
    Friend WithEvents ltbVacunas As System.Windows.Forms.ListBox
    Friend WithEvents btnPlanEntrenamiento As System.Windows.Forms.Button
    Friend WithEvents ltbOperaciones As System.Windows.Forms.ListBox
    Friend WithEvents lblAlergias As System.Windows.Forms.Label
    Friend WithEvents gbxDatosDeportivos As System.Windows.Forms.GroupBox
    Friend WithEvents lblConsultarVenFichaMedica As System.Windows.Forms.Label
    Friend WithEvents lblConsultarPosicion As System.Windows.Forms.Label
    Friend WithEvents lblConsultarActividad As System.Windows.Forms.Label
    Friend WithEvents lblConsultarAltura As System.Windows.Forms.Label
    Friend WithEvents lblConsultarPeso As System.Windows.Forms.Label
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents lblConsultarSomatotipo As System.Windows.Forms.Label
    Friend WithEvents lblVenFichaMedica As System.Windows.Forms.Label
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents lblPosicion As System.Windows.Forms.Label
    Friend WithEvents lblSomatotipo As System.Windows.Forms.Label
    Friend WithEvents lblActividad As System.Windows.Forms.Label
    Friend WithEvents lblMedicamentos As System.Windows.Forms.Label
    Friend WithEvents ltbMedicamentos As System.Windows.Forms.ListBox
    Friend WithEvents ltbAlergias As System.Windows.Forms.ListBox
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblConsultarEntrenador As System.Windows.Forms.Label
    Friend WithEvents lblEntrenador As System.Windows.Forms.Label
    Friend WithEvents lblNSocio As System.Windows.Forms.Label
    Friend WithEvents lblMostrarNSocio As System.Windows.Forms.Label
    Friend WithEvents lblConsultarCriterio As System.Windows.Forms.Label
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents lblMostrarIMC As System.Windows.Forms.Label
    Friend WithEvents lblIMC As System.Windows.Forms.Label
End Class
