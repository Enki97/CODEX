<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaSeleccionador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbInstituto = New System.Windows.Forms.ComboBox
        Me.lblInstituto = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtRepetirContrasenia = New System.Windows.Forms.TextBox
        Me.txtFotoURL = New System.Windows.Forms.TextBox
        Me.lblFotoURL = New System.Windows.Forms.Label
        Me.txtContrasenia = New System.Windows.Forms.TextBox
        Me.lblRepetirContrasenia = New System.Windows.Forms.Label
        Me.lblContrasenia = New System.Windows.Forms.Label
        Me.btnAtras = New System.Windows.Forms.Button
        Me.btnRegistrar = New System.Windows.Forms.Button
        Me.btnAltaTelefono = New System.Windows.Forms.Button
        Me.lbxTelefono = New System.Windows.Forms.ListBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtDocumento = New System.Windows.Forms.TextBox
        Me.lblDocumento = New System.Windows.Forms.Label
        Me.gbxDireccion = New System.Windows.Forms.GroupBox
        Me.lblApartamento = New System.Windows.Forms.Label
        Me.lblNumero = New System.Windows.Forms.Label
        Me.txtApartamento = New System.Windows.Forms.TextBox
        Me.ckbBIS = New System.Windows.Forms.CheckBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.lblCalle = New System.Windows.Forms.Label
        Me.gbxDatosPersonales = New System.Windows.Forms.GroupBox
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker
        Me.lblFechaNacimiento = New System.Windows.Forms.Label
        Me.rbnFemenino = New System.Windows.Forms.RadioButton
        Me.rbnMasculino = New System.Windows.Forms.RadioButton
        Me.lblSexo = New System.Windows.Forms.Label
        Me.cmbNacionalidad = New System.Windows.Forms.ComboBox
        Me.lblNacionalidad = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.gbxNombreCompleto = New System.Windows.Forms.GroupBox
        Me.lblSegApellido = New System.Windows.Forms.Label
        Me.lblPriApellido = New System.Windows.Forms.Label
        Me.lblSegNombre = New System.Windows.Forms.Label
        Me.lblPriNombre = New System.Windows.Forms.Label
        Me.txtSegNombre = New System.Windows.Forms.TextBox
        Me.txtPriApellido = New System.Windows.Forms.TextBox
        Me.txtSegApellido = New System.Windows.Forms.TextBox
        Me.txtPriNombre = New System.Windows.Forms.TextBox
        Me.gbxDireccion.SuspendLayout()
        Me.gbxDatosPersonales.SuspendLayout()
        Me.gbxNombreCompleto.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbInstituto
        '
        Me.cmbInstituto.FormattingEnabled = True
        Me.cmbInstituto.Location = New System.Drawing.Point(65, 282)
        Me.cmbInstituto.Name = "cmbInstituto"
        Me.cmbInstituto.Size = New System.Drawing.Size(451, 21)
        Me.cmbInstituto.TabIndex = 109
        '
        'lblInstituto
        '
        Me.lblInstituto.AutoSize = True
        Me.lblInstituto.Location = New System.Drawing.Point(12, 285)
        Me.lblInstituto.Name = "lblInstituto"
        Me.lblInstituto.Size = New System.Drawing.Size(47, 13)
        Me.lblInstituto.TabIndex = 122
        Me.lblInstituto.Text = "Instituto:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(525, 27)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(138, 20)
        Me.txtTelefono.TabIndex = 110
        '
        'txtRepetirContrasenia
        '
        Me.txtRepetirContrasenia.Location = New System.Drawing.Point(525, 256)
        Me.txtRepetirContrasenia.Name = "txtRepetirContrasenia"
        Me.txtRepetirContrasenia.Size = New System.Drawing.Size(167, 20)
        Me.txtRepetirContrasenia.TabIndex = 113
        Me.txtRepetirContrasenia.UseSystemPasswordChar = True
        '
        'txtFotoURL
        '
        Me.txtFotoURL.Location = New System.Drawing.Point(74, 14)
        Me.txtFotoURL.Name = "txtFotoURL"
        Me.txtFotoURL.Size = New System.Drawing.Size(191, 20)
        Me.txtFotoURL.TabIndex = 104
        '
        'lblFotoURL
        '
        Me.lblFotoURL.AutoSize = True
        Me.lblFotoURL.Location = New System.Drawing.Point(12, 17)
        Me.lblFotoURL.Name = "lblFotoURL"
        Me.lblFotoURL.Size = New System.Drawing.Size(56, 13)
        Me.lblFotoURL.TabIndex = 121
        Me.lblFotoURL.Text = "Foto URL:"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(525, 214)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(167, 20)
        Me.txtContrasenia.TabIndex = 112
        Me.txtContrasenia.UseSystemPasswordChar = True
        '
        'lblRepetirContrasenia
        '
        Me.lblRepetirContrasenia.AutoSize = True
        Me.lblRepetirContrasenia.Location = New System.Drawing.Point(522, 242)
        Me.lblRepetirContrasenia.Name = "lblRepetirContrasenia"
        Me.lblRepetirContrasenia.Size = New System.Drawing.Size(101, 13)
        Me.lblRepetirContrasenia.TabIndex = 120
        Me.lblRepetirContrasenia.Text = "Repetir Contraseña:"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(522, 198)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(64, 13)
        Me.lblContrasenia.TabIndex = 119
        Me.lblContrasenia.Text = "Contraseña:"
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.SIGEN.My.Resources.Resources.cancel1
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(525, 282)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(82, 23)
        Me.btnAtras.TabIndex = 115
        Me.btnAtras.Text = "Cancelar"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.Location = New System.Drawing.Point(613, 282)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(79, 23)
        Me.btnRegistrar.TabIndex = 114
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnAltaTelefono
        '
        Me.btnAltaTelefono.Location = New System.Drawing.Point(669, 25)
        Me.btnAltaTelefono.Name = "btnAltaTelefono"
        Me.btnAltaTelefono.Size = New System.Drawing.Size(23, 23)
        Me.btnAltaTelefono.TabIndex = 111
        Me.btnAltaTelefono.Text = "+"
        Me.btnAltaTelefono.UseVisualStyleBackColor = True
        '
        'lbxTelefono
        '
        Me.lbxTelefono.FormattingEnabled = True
        Me.lbxTelefono.Location = New System.Drawing.Point(525, 53)
        Me.lbxTelefono.Name = "lbxTelefono"
        Me.lbxTelefono.Size = New System.Drawing.Size(167, 134)
        Me.lbxTelefono.TabIndex = 118
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(522, 11)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 117
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(83, 40)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(182, 20)
        Me.txtDocumento.TabIndex = 105
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(12, 43)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(65, 13)
        Me.lblDocumento.TabIndex = 116
        Me.lblDocumento.Text = "Documento:"
        '
        'gbxDireccion
        '
        Me.gbxDireccion.Controls.Add(Me.lblApartamento)
        Me.gbxDireccion.Controls.Add(Me.lblNumero)
        Me.gbxDireccion.Controls.Add(Me.txtApartamento)
        Me.gbxDireccion.Controls.Add(Me.ckbBIS)
        Me.gbxDireccion.Controls.Add(Me.txtNumero)
        Me.gbxDireccion.Controls.Add(Me.txtCalle)
        Me.gbxDireccion.Controls.Add(Me.lblCalle)
        Me.gbxDireccion.Location = New System.Drawing.Point(12, 198)
        Me.gbxDireccion.Name = "gbxDireccion"
        Me.gbxDireccion.Size = New System.Drawing.Size(504, 78)
        Me.gbxDireccion.TabIndex = 108
        Me.gbxDireccion.TabStop = False
        Me.gbxDireccion.Text = "Dirección"
        '
        'lblApartamento
        '
        Me.lblApartamento.AutoSize = True
        Me.lblApartamento.Location = New System.Drawing.Point(9, 45)
        Me.lblApartamento.Name = "lblApartamento"
        Me.lblApartamento.Size = New System.Drawing.Size(70, 13)
        Me.lblApartamento.TabIndex = 8
        Me.lblApartamento.Text = "Apartamento:"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(316, 20)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 13)
        Me.lblNumero.TabIndex = 6
        Me.lblNumero.Text = "Número:"
        '
        'txtApartamento
        '
        Me.txtApartamento.Location = New System.Drawing.Point(85, 42)
        Me.txtApartamento.Name = "txtApartamento"
        Me.txtApartamento.Size = New System.Drawing.Size(75, 20)
        Me.txtApartamento.TabIndex = 4
        '
        'ckbBIS
        '
        Me.ckbBIS.AutoSize = True
        Me.ckbBIS.Location = New System.Drawing.Point(455, 19)
        Me.ckbBIS.Name = "ckbBIS"
        Me.ckbBIS.Size = New System.Drawing.Size(43, 17)
        Me.ckbBIS.TabIndex = 3
        Me.ckbBIS.Text = "BIS"
        Me.ckbBIS.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(369, 16)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(80, 20)
        Me.txtNumero.TabIndex = 2
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(62, 16)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(248, 20)
        Me.txtCalle.TabIndex = 1
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(9, 19)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 0
        Me.lblCalle.Text = "Calle:"
        '
        'gbxDatosPersonales
        '
        Me.gbxDatosPersonales.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbxDatosPersonales.Controls.Add(Me.lblFechaNacimiento)
        Me.gbxDatosPersonales.Controls.Add(Me.rbnFemenino)
        Me.gbxDatosPersonales.Controls.Add(Me.rbnMasculino)
        Me.gbxDatosPersonales.Controls.Add(Me.lblSexo)
        Me.gbxDatosPersonales.Controls.Add(Me.cmbNacionalidad)
        Me.gbxDatosPersonales.Controls.Add(Me.lblNacionalidad)
        Me.gbxDatosPersonales.Controls.Add(Me.txtEmail)
        Me.gbxDatosPersonales.Controls.Add(Me.lblEmail)
        Me.gbxDatosPersonales.Location = New System.Drawing.Point(271, 11)
        Me.gbxDatosPersonales.Name = "gbxDatosPersonales"
        Me.gbxDatosPersonales.Size = New System.Drawing.Size(245, 181)
        Me.gbxDatosPersonales.TabIndex = 107
        Me.gbxDatosPersonales.TabStop = False
        Me.gbxDatosPersonales.Text = "Datos Personales"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(6, 148)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(233, 20)
        Me.dtpFechaNacimiento.TabIndex = 5
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(6, 126)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaNacimiento.TabIndex = 7
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'rbnFemenino
        '
        Me.rbnFemenino.AutoSize = True
        Me.rbnFemenino.Location = New System.Drawing.Point(88, 100)
        Me.rbnFemenino.Name = "rbnFemenino"
        Me.rbnFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbnFemenino.TabIndex = 4
        Me.rbnFemenino.TabStop = True
        Me.rbnFemenino.Text = "Femenino"
        Me.rbnFemenino.UseVisualStyleBackColor = True
        '
        'rbnMasculino
        '
        Me.rbnMasculino.AutoSize = True
        Me.rbnMasculino.Location = New System.Drawing.Point(9, 100)
        Me.rbnMasculino.Name = "rbnMasculino"
        Me.rbnMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbnMasculino.TabIndex = 3
        Me.rbnMasculino.TabStop = True
        Me.rbnMasculino.Text = "Masculino"
        Me.rbnMasculino.UseVisualStyleBackColor = True
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(6, 84)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 4
        Me.lblSexo.Text = "Sexo:"
        '
        'cmbNacionalidad
        '
        Me.cmbNacionalidad.FormattingEnabled = True
        Me.cmbNacionalidad.Items.AddRange(New Object() {"Afganistán", "Akrotiri", "Albania", "Alemania", "Andorra", "Angola", "Anguila", "Antártida", "Antigua y Barbuda", "Antillas Neerlandesas", "Arabia Saudí", "Arctic Ocean", "Argelia", "Argentina", "Armenia", "Aruba", "Ashmore andCartier Islands", "Atlantic Ocean", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bahráin", "Bangladesh", "Barbados", "Bélgica", "Belice", "Benín", "Bermudas", "Bielorrusia", "Birmania Myanmar", "Bolivia", "Bosnia y Hercegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Chad", "Chile", "China", "Chipre", "Clipperton Island", "Colombia", "Comoras", "Congo", "Coral Sea Islands", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dhekelia", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "El Vaticano", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Gaza Strip", "Georgia", "Ghana", "Gibraltar", "Granada", "Grecia", "Groenlandia", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea Ecuatorial", "Guinea-Bissau", "Guyana", "Haití", "Honduras", "Hong Kong", "Hungría", "India", "Indian Ocean", "Indonesia", "Irán", "Iraq", "Irlanda", "Isla Bouvet", "Isla Christmas", "Isla Norfolk", "Islandia", "Islas Caimán", "Islas Cocos", "Islas Cook", "Islas Feroe", "Islas Georgia del Sur y Sandwich del Sur", "Islas Heard y McDonald", "Islas Malvinas", "Islas Marianas del Norte", "IslasMarshall", "Islas Pitcairn", "Islas Salomón", "Islas Turcas y Caicos", "Islas Vírgenes Americanas", "Islas Vírgenes Británicas", "Israel", "Italia", "Jamaica", "Jan Mayen", "Japón", "Jersey", "Jordania", "Kazajistán", "Kenia", "Kirguizistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macao", "Macedonia", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Man, Isle of", "Marruecos", "Mauricio", "Mauritania", "Mayotte", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montserrat", "Mozambique", "Namibia", "Nauru", "Navassa Island", "Nepal", "Nicaragua", "Níger", "Nigeria", "Niue", "Noruega", "Nueva Caledonia", "Nueva Zelanda", "Omán", "Pacific Ocean", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa-Nueva Guinea", "Paracel Islands", "Paraguay", "Perú", "Polinesia Francesa", "Polonia", "Portugal", "Puerto Rico", "Qatar", "Reino Unido", "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Sáhara Occidental", "Samoa", "Samoa Americana", "San Cristóbal y Nieves", "San Marino", "San Pedro y Miquelón", "San Vicente y las Granadinas", "Santa Helena", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Southern Ocean", "Spratly Islands", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Suecia", "Suiza", "Surinam", "Svalbard y Jan Mayen", "Tailandia", "Taiwán", "Tanzania", "Tayikistán", "TerritorioBritánicodel Océano Indico", "Territorios Australes Franceses", "Timor Oriental", "Togo", "Tokelau", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Unión Europea", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Wake Island", "Wallis y Futuna", "West Bank", "World", "Yemen", "Yibuti", "Zambia", "Zimbabue"})
        Me.cmbNacionalidad.Location = New System.Drawing.Point(84, 52)
        Me.cmbNacionalidad.Name = "cmbNacionalidad"
        Me.cmbNacionalidad.Size = New System.Drawing.Size(155, 21)
        Me.cmbNacionalidad.TabIndex = 2
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(6, 55)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblNacionalidad.TabIndex = 2
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(47, 19)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(192, 20)
        Me.txtEmail.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 22)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email:"
        '
        'gbxNombreCompleto
        '
        Me.gbxNombreCompleto.Controls.Add(Me.lblSegApellido)
        Me.gbxNombreCompleto.Controls.Add(Me.lblPriApellido)
        Me.gbxNombreCompleto.Controls.Add(Me.lblSegNombre)
        Me.gbxNombreCompleto.Controls.Add(Me.lblPriNombre)
        Me.gbxNombreCompleto.Controls.Add(Me.txtSegNombre)
        Me.gbxNombreCompleto.Controls.Add(Me.txtPriApellido)
        Me.gbxNombreCompleto.Controls.Add(Me.txtSegApellido)
        Me.gbxNombreCompleto.Controls.Add(Me.txtPriNombre)
        Me.gbxNombreCompleto.Location = New System.Drawing.Point(15, 66)
        Me.gbxNombreCompleto.Name = "gbxNombreCompleto"
        Me.gbxNombreCompleto.Size = New System.Drawing.Size(250, 126)
        Me.gbxNombreCompleto.TabIndex = 106
        Me.gbxNombreCompleto.TabStop = False
        Me.gbxNombreCompleto.Text = "Nombre Completo"
        '
        'lblSegApellido
        '
        Me.lblSegApellido.AutoSize = True
        Me.lblSegApellido.Location = New System.Drawing.Point(6, 100)
        Me.lblSegApellido.Name = "lblSegApellido"
        Me.lblSegApellido.Size = New System.Drawing.Size(93, 13)
        Me.lblSegApellido.TabIndex = 7
        Me.lblSegApellido.Text = "Segundo Apellido:"
        '
        'lblPriApellido
        '
        Me.lblPriApellido.AutoSize = True
        Me.lblPriApellido.Location = New System.Drawing.Point(6, 74)
        Me.lblPriApellido.Name = "lblPriApellido"
        Me.lblPriApellido.Size = New System.Drawing.Size(79, 13)
        Me.lblPriApellido.TabIndex = 6
        Me.lblPriApellido.Text = "Primer Apellido:"
        '
        'lblSegNombre
        '
        Me.lblSegNombre.AutoSize = True
        Me.lblSegNombre.Location = New System.Drawing.Point(6, 48)
        Me.lblSegNombre.Name = "lblSegNombre"
        Me.lblSegNombre.Size = New System.Drawing.Size(93, 13)
        Me.lblSegNombre.TabIndex = 5
        Me.lblSegNombre.Text = "Segundo Nombre:"
        '
        'lblPriNombre
        '
        Me.lblPriNombre.AutoSize = True
        Me.lblPriNombre.Location = New System.Drawing.Point(6, 22)
        Me.lblPriNombre.Name = "lblPriNombre"
        Me.lblPriNombre.Size = New System.Drawing.Size(79, 13)
        Me.lblPriNombre.TabIndex = 4
        Me.lblPriNombre.Text = "Primer Nombre:"
        '
        'txtSegNombre
        '
        Me.txtSegNombre.Location = New System.Drawing.Point(118, 45)
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(126, 20)
        Me.txtSegNombre.TabIndex = 2
        '
        'txtPriApellido
        '
        Me.txtPriApellido.Location = New System.Drawing.Point(118, 71)
        Me.txtPriApellido.Name = "txtPriApellido"
        Me.txtPriApellido.Size = New System.Drawing.Size(126, 20)
        Me.txtPriApellido.TabIndex = 3
        '
        'txtSegApellido
        '
        Me.txtSegApellido.Location = New System.Drawing.Point(118, 97)
        Me.txtSegApellido.Name = "txtSegApellido"
        Me.txtSegApellido.Size = New System.Drawing.Size(126, 20)
        Me.txtSegApellido.TabIndex = 4
        '
        'txtPriNombre
        '
        Me.txtPriNombre.Location = New System.Drawing.Point(118, 19)
        Me.txtPriNombre.Name = "txtPriNombre"
        Me.txtPriNombre.Size = New System.Drawing.Size(126, 20)
        Me.txtPriNombre.TabIndex = 1
        '
        'FrmAltaSeleccionador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 316)
        Me.Controls.Add(Me.cmbInstituto)
        Me.Controls.Add(Me.lblInstituto)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtRepetirContrasenia)
        Me.Controls.Add(Me.txtFotoURL)
        Me.Controls.Add(Me.lblFotoURL)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.lblRepetirContrasenia)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnAltaTelefono)
        Me.Controls.Add(Me.lbxTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.gbxDireccion)
        Me.Controls.Add(Me.gbxDatosPersonales)
        Me.Controls.Add(Me.gbxNombreCompleto)
        Me.Name = "FrmAltaSeleccionador"
        Me.Text = "Registrar Seleccionador"
        Me.gbxDireccion.ResumeLayout(False)
        Me.gbxDireccion.PerformLayout()
        Me.gbxDatosPersonales.ResumeLayout(False)
        Me.gbxDatosPersonales.PerformLayout()
        Me.gbxNombreCompleto.ResumeLayout(False)
        Me.gbxNombreCompleto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbInstituto As System.Windows.Forms.ComboBox
    Friend WithEvents lblInstituto As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtRepetirContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents txtFotoURL As System.Windows.Forms.TextBox
    Friend WithEvents lblFotoURL As System.Windows.Forms.Label
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents lblRepetirContrasenia As System.Windows.Forms.Label
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnAltaTelefono As System.Windows.Forms.Button
    Friend WithEvents lbxTelefono As System.Windows.Forms.ListBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents gbxDireccion As System.Windows.Forms.GroupBox
    Friend WithEvents lblApartamento As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents txtApartamento As System.Windows.Forms.TextBox
    Friend WithEvents ckbBIS As System.Windows.Forms.CheckBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents gbxDatosPersonales As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents rbnFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rbnMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cmbNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents gbxNombreCompleto As System.Windows.Forms.GroupBox
    Friend WithEvents lblSegApellido As System.Windows.Forms.Label
    Friend WithEvents lblPriApellido As System.Windows.Forms.Label
    Friend WithEvents lblSegNombre As System.Windows.Forms.Label
    Friend WithEvents lblPriNombre As System.Windows.Forms.Label
    Friend WithEvents txtSegNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPriApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSegApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPriNombre As System.Windows.Forms.TextBox
End Class
