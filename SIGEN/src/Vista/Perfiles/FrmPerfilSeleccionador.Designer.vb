<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerfilSeleccionador
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
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.ltbTelefono = New System.Windows.Forms.ListBox
        Me.gbxDatosPersonales = New System.Windows.Forms.GroupBox
        Me.lblAcreditacion = New System.Windows.Forms.Label
        Me.lblMostrarAcreditacion = New System.Windows.Forms.Label
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
        Me.lblMostrarApto = New System.Windows.Forms.Label
        Me.lblMostrarNroPuerta = New System.Windows.Forms.Label
        Me.lblMostrarCalle = New System.Windows.Forms.Label
        Me.ckbBIS = New System.Windows.Forms.CheckBox
        Me.lblApartamento = New System.Windows.Forms.Label
        Me.lblNroPuerta = New System.Windows.Forms.Label
        Me.lblCalle = New System.Windows.Forms.Label
        Me.gbxNombre = New System.Windows.Forms.GroupBox
        Me.lblMostrarSegApellido = New System.Windows.Forms.Label
        Me.lblPriNombre = New System.Windows.Forms.Label
        Me.lblSegApellido = New System.Windows.Forms.Label
        Me.lblMostrarPriNombre = New System.Windows.Forms.Label
        Me.lblSegNombre = New System.Windows.Forms.Label
        Me.lblMostrarPriApellido = New System.Windows.Forms.Label
        Me.lblMostrarSegNombre = New System.Windows.Forms.Label
        Me.lblPriApellido = New System.Windows.Forms.Label
        Me.imgFoto = New System.Windows.Forms.PictureBox
        Me.btnBaja = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.gbxDatosPersonales.SuspendLayout()
        Me.gbxDomicilio.SuspendLayout()
        Me.gbxNombre.SuspendLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(249, 129)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 58
        Me.lblTelefono.Text = "Telefono:"
        '
        'ltbTelefono
        '
        Me.ltbTelefono.FormattingEnabled = True
        Me.ltbTelefono.Items.AddRange(New Object() {""})
        Me.ltbTelefono.Location = New System.Drawing.Point(249, 145)
        Me.ltbTelefono.Name = "ltbTelefono"
        Me.ltbTelefono.Size = New System.Drawing.Size(171, 186)
        Me.ltbTelefono.TabIndex = 57
        '
        'gbxDatosPersonales
        '
        Me.gbxDatosPersonales.Controls.Add(Me.lblAcreditacion)
        Me.gbxDatosPersonales.Controls.Add(Me.lblMostrarAcreditacion)
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
        Me.gbxDatosPersonales.Location = New System.Drawing.Point(15, 129)
        Me.gbxDatosPersonales.Name = "gbxDatosPersonales"
        Me.gbxDatosPersonales.Size = New System.Drawing.Size(228, 202)
        Me.gbxDatosPersonales.TabIndex = 56
        Me.gbxDatosPersonales.TabStop = False
        Me.gbxDatosPersonales.Text = "Datos Personales"
        '
        'lblAcreditacion
        '
        Me.lblAcreditacion.AutoSize = True
        Me.lblAcreditacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcreditacion.Location = New System.Drawing.Point(6, 29)
        Me.lblAcreditacion.Name = "lblAcreditacion"
        Me.lblAcreditacion.Size = New System.Drawing.Size(69, 13)
        Me.lblAcreditacion.TabIndex = 19
        Me.lblAcreditacion.Text = "Acreditación:"
        '
        'lblMostrarAcreditacion
        '
        Me.lblMostrarAcreditacion.AutoSize = True
        Me.lblMostrarAcreditacion.Location = New System.Drawing.Point(122, 29)
        Me.lblMostrarAcreditacion.Name = "lblMostrarAcreditacion"
        Me.lblMostrarAcreditacion.Size = New System.Drawing.Size(66, 13)
        Me.lblMostrarAcreditacion.TabIndex = 20
        Me.lblMostrarAcreditacion.Text = "Acreditacion"
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
        Me.lblMostrarDocumento.Location = New System.Drawing.Point(122, 16)
        Me.lblMostrarDocumento.Name = "lblMostrarDocumento"
        Me.lblMostrarDocumento.Size = New System.Drawing.Size(62, 13)
        Me.lblMostrarDocumento.TabIndex = 6
        Me.lblMostrarDocumento.Text = "Documento"
        '
        'lblMostrarSexo
        '
        Me.lblMostrarSexo.AutoSize = True
        Me.lblMostrarSexo.Location = New System.Drawing.Point(122, 68)
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
        Me.lblMostrarEdad.Location = New System.Drawing.Point(122, 42)
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
        Me.lblMostrarNacionalidad.Location = New System.Drawing.Point(122, 55)
        Me.lblMostrarNacionalidad.Name = "lblMostrarNacionalidad"
        Me.lblMostrarNacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.lblMostrarNacionalidad.TabIndex = 14
        Me.lblMostrarNacionalidad.Text = "Nacionalidad"
        '
        'gbxDomicilio
        '
        Me.gbxDomicilio.Controls.Add(Me.lblMostrarApto)
        Me.gbxDomicilio.Controls.Add(Me.lblMostrarNroPuerta)
        Me.gbxDomicilio.Controls.Add(Me.lblMostrarCalle)
        Me.gbxDomicilio.Controls.Add(Me.ckbBIS)
        Me.gbxDomicilio.Controls.Add(Me.lblApartamento)
        Me.gbxDomicilio.Controls.Add(Me.lblNroPuerta)
        Me.gbxDomicilio.Controls.Add(Me.lblCalle)
        Me.gbxDomicilio.Location = New System.Drawing.Point(15, 337)
        Me.gbxDomicilio.Name = "gbxDomicilio"
        Me.gbxDomicilio.Size = New System.Drawing.Size(405, 70)
        Me.gbxDomicilio.TabIndex = 55
        Me.gbxDomicilio.TabStop = False
        Me.gbxDomicilio.Text = "Domicilio"
        '
        'lblMostrarApto
        '
        Me.lblMostrarApto.AutoSize = True
        Me.lblMostrarApto.Location = New System.Drawing.Point(141, 42)
        Me.lblMostrarApto.Name = "lblMostrarApto"
        Me.lblMostrarApto.Size = New System.Drawing.Size(29, 13)
        Me.lblMostrarApto.TabIndex = 13
        Me.lblMostrarApto.Text = "Apto"
        '
        'lblMostrarNroPuerta
        '
        Me.lblMostrarNroPuerta.AutoSize = True
        Me.lblMostrarNroPuerta.Location = New System.Drawing.Point(141, 29)
        Me.lblMostrarNroPuerta.Name = "lblMostrarNroPuerta"
        Me.lblMostrarNroPuerta.Size = New System.Drawing.Size(44, 13)
        Me.lblMostrarNroPuerta.TabIndex = 13
        Me.lblMostrarNroPuerta.Text = "Numero"
        '
        'lblMostrarCalle
        '
        Me.lblMostrarCalle.AutoSize = True
        Me.lblMostrarCalle.Location = New System.Drawing.Point(141, 16)
        Me.lblMostrarCalle.Name = "lblMostrarCalle"
        Me.lblMostrarCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblMostrarCalle.TabIndex = 4
        Me.lblMostrarCalle.Text = "Calle"
        '
        'ckbBIS
        '
        Me.ckbBIS.AutoSize = True
        Me.ckbBIS.Location = New System.Drawing.Point(201, 28)
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
        Me.gbxNombre.Location = New System.Drawing.Point(161, 12)
        Me.gbxNombre.Name = "gbxNombre"
        Me.gbxNombre.Size = New System.Drawing.Size(259, 111)
        Me.gbxNombre.TabIndex = 54
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
        'imgFoto
        '
        Me.imgFoto.Location = New System.Drawing.Point(15, 12)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(140, 111)
        Me.imgFoto.TabIndex = 53
        Me.imgFoto.TabStop = False
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(151, 419)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(133, 30)
        Me.btnBaja.TabIndex = 67
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.back
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(15, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 30)
        Me.btnCancelar.TabIndex = 66
        Me.btnCancelar.Text = "&Atras"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(290, 419)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(130, 30)
        Me.btnModificar.TabIndex = 65
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'FrmPerfilSeleccionador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 461)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.ltbTelefono)
        Me.Controls.Add(Me.gbxDatosPersonales)
        Me.Controls.Add(Me.gbxDomicilio)
        Me.Controls.Add(Me.gbxNombre)
        Me.Controls.Add(Me.imgFoto)
        Me.Name = "FrmPerfilSeleccionador"
        Me.Text = "Perfil"
        Me.gbxDatosPersonales.ResumeLayout(False)
        Me.gbxDatosPersonales.PerformLayout()
        Me.gbxDomicilio.ResumeLayout(False)
        Me.gbxDomicilio.PerformLayout()
        Me.gbxNombre.ResumeLayout(False)
        Me.gbxNombre.PerformLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
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
    Friend WithEvents lblMostrarApto As System.Windows.Forms.Label
    Friend WithEvents lblMostrarNroPuerta As System.Windows.Forms.Label
    Friend WithEvents lblMostrarCalle As System.Windows.Forms.Label
    Friend WithEvents ckbBIS As System.Windows.Forms.CheckBox
    Friend WithEvents lblApartamento As System.Windows.Forms.Label
    Friend WithEvents lblNroPuerta As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents gbxNombre As System.Windows.Forms.GroupBox
    Friend WithEvents lblMostrarSegApellido As System.Windows.Forms.Label
    Friend WithEvents lblPriNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegApellido As System.Windows.Forms.Label
    Friend WithEvents lblMostrarPriNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegNombre As System.Windows.Forms.Label
    Friend WithEvents lblMostrarPriApellido As System.Windows.Forms.Label
    Friend WithEvents lblMostrarSegNombre As System.Windows.Forms.Label
    Friend WithEvents lblPriApellido As System.Windows.Forms.Label
    Friend WithEvents imgFoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblAcreditacion As System.Windows.Forms.Label
    Friend WithEvents lblMostrarAcreditacion As System.Windows.Forms.Label
End Class
