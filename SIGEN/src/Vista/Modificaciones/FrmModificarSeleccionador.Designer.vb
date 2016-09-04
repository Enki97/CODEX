<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarSeleccionador
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
        Me.txtAntiguaContrasenia = New System.Windows.Forms.TextBox
        Me.lblAntiguaContrasenia = New System.Windows.Forms.Label
        Me.btnBajaTelefono = New System.Windows.Forms.Button
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.btnAltaTelefono = New System.Windows.Forms.Button
        Me.lbxTelefono = New System.Windows.Forms.ListBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtFotoURL = New System.Windows.Forms.TextBox
        Me.lblFotoURL = New System.Windows.Forms.Label
        Me.txtRepetirContrasenia = New System.Windows.Forms.TextBox
        Me.txtContrasenia = New System.Windows.Forms.TextBox
        Me.lblRepetirContrasenia = New System.Windows.Forms.Label
        Me.lblContrasenia = New System.Windows.Forms.Label
        Me.btnAtras = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
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
        Me.gbxDatosPeronales = New System.Windows.Forms.GroupBox
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
        Me.gbxDatosPeronales.SuspendLayout()
        Me.gbxNombreCompleto.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbInstituto
        '
        Me.cmbInstituto.FormattingEnabled = True
        Me.cmbInstituto.Location = New System.Drawing.Point(64, 281)
        Me.cmbInstituto.Name = "cmbInstituto"
        Me.cmbInstituto.Size = New System.Drawing.Size(440, 21)
        Me.cmbInstituto.TabIndex = 99
        '
        'lblInstituto
        '
        Me.lblInstituto.AutoSize = True
        Me.lblInstituto.Location = New System.Drawing.Point(11, 284)
        Me.lblInstituto.Name = "lblInstituto"
        Me.lblInstituto.Size = New System.Drawing.Size(47, 13)
        Me.lblInstituto.TabIndex = 115
        Me.lblInstituto.Text = "Instituto:"
        '
        'txtAntiguaContrasenia
        '
        Me.txtAntiguaContrasenia.Location = New System.Drawing.Point(510, 216)
        Me.txtAntiguaContrasenia.Name = "txtAntiguaContrasenia"
        Me.txtAntiguaContrasenia.Size = New System.Drawing.Size(184, 20)
        Me.txtAntiguaContrasenia.TabIndex = 104
        Me.txtAntiguaContrasenia.UseSystemPasswordChar = True
        '
        'lblAntiguaContrasenia
        '
        Me.lblAntiguaContrasenia.AutoSize = True
        Me.lblAntiguaContrasenia.Location = New System.Drawing.Point(510, 200)
        Me.lblAntiguaContrasenia.Name = "lblAntiguaContrasenia"
        Me.lblAntiguaContrasenia.Size = New System.Drawing.Size(103, 13)
        Me.lblAntiguaContrasenia.TabIndex = 114
        Me.lblAntiguaContrasenia.Text = "Antigua Contraseña:"
        '
        'btnBajaTelefono
        '
        Me.btnBajaTelefono.Location = New System.Drawing.Point(671, 51)
        Me.btnBajaTelefono.Name = "btnBajaTelefono"
        Me.btnBajaTelefono.Size = New System.Drawing.Size(23, 23)
        Me.btnBajaTelefono.TabIndex = 103
        Me.btnBajaTelefono.Text = "-"
        Me.btnBajaTelefono.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(513, 24)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(152, 20)
        Me.txtTelefono.TabIndex = 100
        '
        'btnAltaTelefono
        '
        Me.btnAltaTelefono.Location = New System.Drawing.Point(671, 22)
        Me.btnAltaTelefono.Name = "btnAltaTelefono"
        Me.btnAltaTelefono.Size = New System.Drawing.Size(23, 23)
        Me.btnAltaTelefono.TabIndex = 101
        Me.btnAltaTelefono.Text = "+"
        Me.btnAltaTelefono.UseVisualStyleBackColor = True
        '
        'lbxTelefono
        '
        Me.lbxTelefono.FormattingEnabled = True
        Me.lbxTelefono.Location = New System.Drawing.Point(513, 50)
        Me.lbxTelefono.Name = "lbxTelefono"
        Me.lbxTelefono.Size = New System.Drawing.Size(152, 147)
        Me.lbxTelefono.TabIndex = 102
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(510, 8)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 113
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtFotoURL
        '
        Me.txtFotoURL.Location = New System.Drawing.Point(73, 11)
        Me.txtFotoURL.Name = "txtFotoURL"
        Me.txtFotoURL.Size = New System.Drawing.Size(180, 20)
        Me.txtFotoURL.TabIndex = 94
        '
        'lblFotoURL
        '
        Me.lblFotoURL.AutoSize = True
        Me.lblFotoURL.Location = New System.Drawing.Point(11, 14)
        Me.lblFotoURL.Name = "lblFotoURL"
        Me.lblFotoURL.Size = New System.Drawing.Size(56, 13)
        Me.lblFotoURL.TabIndex = 112
        Me.lblFotoURL.Text = "Foto URL:"
        '
        'txtRepetirContrasenia
        '
        Me.txtRepetirContrasenia.Location = New System.Drawing.Point(513, 294)
        Me.txtRepetirContrasenia.Name = "txtRepetirContrasenia"
        Me.txtRepetirContrasenia.Size = New System.Drawing.Size(181, 20)
        Me.txtRepetirContrasenia.TabIndex = 106
        Me.txtRepetirContrasenia.UseSystemPasswordChar = True
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(513, 255)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(181, 20)
        Me.txtContrasenia.TabIndex = 105
        Me.txtContrasenia.UseSystemPasswordChar = True
        '
        'lblRepetirContrasenia
        '
        Me.lblRepetirContrasenia.AutoSize = True
        Me.lblRepetirContrasenia.Location = New System.Drawing.Point(510, 278)
        Me.lblRepetirContrasenia.Name = "lblRepetirContrasenia"
        Me.lblRepetirContrasenia.Size = New System.Drawing.Size(136, 13)
        Me.lblRepetirContrasenia.TabIndex = 111
        Me.lblRepetirContrasenia.Text = "Repetir Nueva Contraseña:"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(510, 239)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(99, 13)
        Me.lblContrasenia.TabIndex = 110
        Me.lblContrasenia.Text = "Nueva Contraseña:"
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.SIGEN.My.Resources.Resources.cancel1
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(513, 323)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(90, 30)
        Me.btnAtras.TabIndex = 108
        Me.btnAtras.Text = "Cancelar"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(604, 323)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 30)
        Me.btnGuardar.TabIndex = 107
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(82, 37)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(171, 20)
        Me.txtDocumento.TabIndex = 95
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(11, 40)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(65, 13)
        Me.lblDocumento.TabIndex = 109
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
        Me.gbxDireccion.Location = New System.Drawing.Point(14, 195)
        Me.gbxDireccion.Name = "gbxDireccion"
        Me.gbxDireccion.Size = New System.Drawing.Size(490, 80)
        Me.gbxDireccion.TabIndex = 98
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
        Me.lblNumero.Location = New System.Drawing.Point(308, 18)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 13)
        Me.lblNumero.TabIndex = 6
        Me.lblNumero.Text = "Número:"
        '
        'txtApartamento
        '
        Me.txtApartamento.Location = New System.Drawing.Point(82, 41)
        Me.txtApartamento.Name = "txtApartamento"
        Me.txtApartamento.Size = New System.Drawing.Size(75, 20)
        Me.txtApartamento.TabIndex = 4
        '
        'ckbBIS
        '
        Me.ckbBIS.AutoSize = True
        Me.ckbBIS.Location = New System.Drawing.Point(444, 18)
        Me.ckbBIS.Name = "ckbBIS"
        Me.ckbBIS.Size = New System.Drawing.Size(43, 17)
        Me.ckbBIS.TabIndex = 3
        Me.ckbBIS.Text = "BIS"
        Me.ckbBIS.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(358, 15)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(80, 20)
        Me.txtNumero.TabIndex = 2
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(68, 16)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(198, 20)
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
        'gbxDatosPeronales
        '
        Me.gbxDatosPeronales.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbxDatosPeronales.Controls.Add(Me.lblFechaNacimiento)
        Me.gbxDatosPeronales.Controls.Add(Me.rbnFemenino)
        Me.gbxDatosPeronales.Controls.Add(Me.rbnMasculino)
        Me.gbxDatosPeronales.Controls.Add(Me.lblSexo)
        Me.gbxDatosPeronales.Controls.Add(Me.cmbNacionalidad)
        Me.gbxDatosPeronales.Controls.Add(Me.lblNacionalidad)
        Me.gbxDatosPeronales.Controls.Add(Me.txtEmail)
        Me.gbxDatosPeronales.Controls.Add(Me.lblEmail)
        Me.gbxDatosPeronales.Location = New System.Drawing.Point(259, 8)
        Me.gbxDatosPeronales.Name = "gbxDatosPeronales"
        Me.gbxDatosPeronales.Size = New System.Drawing.Size(245, 181)
        Me.gbxDatosPeronales.TabIndex = 97
        Me.gbxDatosPeronales.TabStop = False
        Me.gbxDatosPeronales.Text = "Datos Personales"
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
        Me.cmbNacionalidad.Location = New System.Drawing.Point(81, 52)
        Me.cmbNacionalidad.Name = "cmbNacionalidad"
        Me.cmbNacionalidad.Size = New System.Drawing.Size(158, 21)
        Me.cmbNacionalidad.TabIndex = 2
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(3, 55)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(72, 13)
        Me.lblNacionalidad.TabIndex = 2
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(44, 19)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(195, 20)
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
        Me.gbxNombreCompleto.Location = New System.Drawing.Point(14, 63)
        Me.gbxNombreCompleto.Name = "gbxNombreCompleto"
        Me.gbxNombreCompleto.Size = New System.Drawing.Size(239, 126)
        Me.gbxNombreCompleto.TabIndex = 96
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
        Me.txtSegNombre.Location = New System.Drawing.Point(113, 45)
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(120, 20)
        Me.txtSegNombre.TabIndex = 2
        '
        'txtPriApellido
        '
        Me.txtPriApellido.Location = New System.Drawing.Point(113, 71)
        Me.txtPriApellido.Name = "txtPriApellido"
        Me.txtPriApellido.Size = New System.Drawing.Size(120, 20)
        Me.txtPriApellido.TabIndex = 3
        '
        'txtSegApellido
        '
        Me.txtSegApellido.Location = New System.Drawing.Point(113, 97)
        Me.txtSegApellido.Name = "txtSegApellido"
        Me.txtSegApellido.Size = New System.Drawing.Size(120, 20)
        Me.txtSegApellido.TabIndex = 4
        '
        'txtPriNombre
        '
        Me.txtPriNombre.Location = New System.Drawing.Point(113, 19)
        Me.txtPriNombre.Name = "txtPriNombre"
        Me.txtPriNombre.Size = New System.Drawing.Size(120, 20)
        Me.txtPriNombre.TabIndex = 1
        '
        'FrmModificarSeleccionador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 361)
        Me.Controls.Add(Me.cmbInstituto)
        Me.Controls.Add(Me.lblInstituto)
        Me.Controls.Add(Me.txtAntiguaContrasenia)
        Me.Controls.Add(Me.lblAntiguaContrasenia)
        Me.Controls.Add(Me.btnBajaTelefono)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnAltaTelefono)
        Me.Controls.Add(Me.lbxTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtFotoURL)
        Me.Controls.Add(Me.lblFotoURL)
        Me.Controls.Add(Me.txtRepetirContrasenia)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.lblRepetirContrasenia)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.gbxDireccion)
        Me.Controls.Add(Me.gbxDatosPeronales)
        Me.Controls.Add(Me.gbxNombreCompleto)
        Me.Name = "FrmModificarSeleccionador"
        Me.Text = "Modificar Seleccionador"
        Me.gbxDireccion.ResumeLayout(False)
        Me.gbxDireccion.PerformLayout()
        Me.gbxDatosPeronales.ResumeLayout(False)
        Me.gbxDatosPeronales.PerformLayout()
        Me.gbxNombreCompleto.ResumeLayout(False)
        Me.gbxNombreCompleto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbInstituto As System.Windows.Forms.ComboBox
    Friend WithEvents lblInstituto As System.Windows.Forms.Label
    Friend WithEvents txtAntiguaContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents lblAntiguaContrasenia As System.Windows.Forms.Label
    Friend WithEvents btnBajaTelefono As System.Windows.Forms.Button
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnAltaTelefono As System.Windows.Forms.Button
    Friend WithEvents lbxTelefono As System.Windows.Forms.ListBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtFotoURL As System.Windows.Forms.TextBox
    Friend WithEvents lblFotoURL As System.Windows.Forms.Label
    Friend WithEvents txtRepetirContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents lblRepetirContrasenia As System.Windows.Forms.Label
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
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
    Friend WithEvents gbxDatosPeronales As System.Windows.Forms.GroupBox
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
