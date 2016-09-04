<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarDeportistaDos
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
        Me.cmbDeporte = New System.Windows.Forms.ComboBox
        Me.lblDeporte = New System.Windows.Forms.Label
        Me.gbxDatosFisicos = New System.Windows.Forms.GroupBox
        Me.lblCriterio = New System.Windows.Forms.Label
        Me.lblSomatotipo = New System.Windows.Forms.Label
        Me.cmbCriterio = New System.Windows.Forms.ComboBox
        Me.cmbSomatotipo = New System.Windows.Forms.ComboBox
        Me.txtAltura = New System.Windows.Forms.TextBox
        Me.lblAltura = New System.Windows.Forms.Label
        Me.txtPeso = New System.Windows.Forms.TextBox
        Me.lblPeso = New System.Windows.Forms.Label
        Me.gbxSalud = New System.Windows.Forms.GroupBox
        Me.btnBajaVacunas = New System.Windows.Forms.Button
        Me.btnBajaAlergias = New System.Windows.Forms.Button
        Me.btnBajaOperaciones = New System.Windows.Forms.Button
        Me.btnBajaMedicamentos = New System.Windows.Forms.Button
        Me.txtVacunas = New System.Windows.Forms.TextBox
        Me.txtAlergias = New System.Windows.Forms.TextBox
        Me.txtOperaciones = New System.Windows.Forms.TextBox
        Me.txtMedicamentos = New System.Windows.Forms.TextBox
        Me.btnAltaVacunas = New System.Windows.Forms.Button
        Me.btnAltaAlergias = New System.Windows.Forms.Button
        Me.btnAltaOperaciones = New System.Windows.Forms.Button
        Me.btnAltaMedicamentos = New System.Windows.Forms.Button
        Me.ltbVacunas = New System.Windows.Forms.ListBox
        Me.ltbAlergias = New System.Windows.Forms.ListBox
        Me.ltbOperaciones = New System.Windows.Forms.ListBox
        Me.ltbMedicamentos = New System.Windows.Forms.ListBox
        Me.lblVacunas = New System.Windows.Forms.Label
        Me.lblAlergias = New System.Windows.Forms.Label
        Me.lblOperaciones = New System.Windows.Forms.Label
        Me.lblMedicamentos = New System.Windows.Forms.Label
        Me.dtpVencimientoFichaMedica = New System.Windows.Forms.DateTimePicker
        Me.lblVencimientoFichaMedica = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnAtras = New System.Windows.Forms.Button
        Me.txtPosicion = New System.Windows.Forms.TextBox
        Me.lblPosicion = New System.Windows.Forms.Label
        Me.gbxDatosFisicos.SuspendLayout()
        Me.gbxSalud.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbDeporte
        '
        Me.cmbDeporte.FormattingEnabled = True
        Me.cmbDeporte.Location = New System.Drawing.Point(493, 235)
        Me.cmbDeporte.Name = "cmbDeporte"
        Me.cmbDeporte.Size = New System.Drawing.Size(199, 21)
        Me.cmbDeporte.TabIndex = 76
        '
        'lblDeporte
        '
        Me.lblDeporte.AutoSize = True
        Me.lblDeporte.Location = New System.Drawing.Point(439, 239)
        Me.lblDeporte.Name = "lblDeporte"
        Me.lblDeporte.Size = New System.Drawing.Size(48, 13)
        Me.lblDeporte.TabIndex = 74
        Me.lblDeporte.Text = "Deporte:"
        '
        'gbxDatosFisicos
        '
        Me.gbxDatosFisicos.Controls.Add(Me.lblCriterio)
        Me.gbxDatosFisicos.Controls.Add(Me.lblSomatotipo)
        Me.gbxDatosFisicos.Controls.Add(Me.cmbCriterio)
        Me.gbxDatosFisicos.Controls.Add(Me.cmbSomatotipo)
        Me.gbxDatosFisicos.Controls.Add(Me.txtAltura)
        Me.gbxDatosFisicos.Controls.Add(Me.lblAltura)
        Me.gbxDatosFisicos.Controls.Add(Me.txtPeso)
        Me.gbxDatosFisicos.Controls.Add(Me.lblPeso)
        Me.gbxDatosFisicos.Location = New System.Drawing.Point(12, 221)
        Me.gbxDatosFisicos.Name = "gbxDatosFisicos"
        Me.gbxDatosFisicos.Size = New System.Drawing.Size(421, 81)
        Me.gbxDatosFisicos.TabIndex = 71
        Me.gbxDatosFisicos.TabStop = False
        Me.gbxDatosFisicos.Text = "Datos Físicos"
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(199, 48)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(42, 13)
        Me.lblCriterio.TabIndex = 79
        Me.lblCriterio.Text = "Criterio:"
        '
        'lblSomatotipo
        '
        Me.lblSomatotipo.AutoSize = True
        Me.lblSomatotipo.Location = New System.Drawing.Point(199, 22)
        Me.lblSomatotipo.Name = "lblSomatotipo"
        Me.lblSomatotipo.Size = New System.Drawing.Size(63, 13)
        Me.lblSomatotipo.TabIndex = 5
        Me.lblSomatotipo.Text = "Somatotipo:"
        '
        'cmbCriterio
        '
        Me.cmbCriterio.FormattingEnabled = True
        Me.cmbCriterio.Location = New System.Drawing.Point(265, 45)
        Me.cmbCriterio.Name = "cmbCriterio"
        Me.cmbCriterio.Size = New System.Drawing.Size(152, 21)
        Me.cmbCriterio.TabIndex = 78
        '
        'cmbSomatotipo
        '
        Me.cmbSomatotipo.FormattingEnabled = True
        Me.cmbSomatotipo.Location = New System.Drawing.Point(265, 18)
        Me.cmbSomatotipo.Name = "cmbSomatotipo"
        Me.cmbSomatotipo.Size = New System.Drawing.Size(152, 21)
        Me.cmbSomatotipo.TabIndex = 4
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(55, 45)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(138, 20)
        Me.txtAltura.TabIndex = 3
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(6, 48)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(37, 13)
        Me.lblAltura.TabIndex = 2
        Me.lblAltura.Text = "Altura:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(55, 19)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(138, 20)
        Me.txtPeso.TabIndex = 1
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(6, 22)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 13)
        Me.lblPeso.TabIndex = 0
        Me.lblPeso.Text = "Peso:"
        '
        'gbxSalud
        '
        Me.gbxSalud.Controls.Add(Me.btnBajaVacunas)
        Me.gbxSalud.Controls.Add(Me.btnBajaAlergias)
        Me.gbxSalud.Controls.Add(Me.btnBajaOperaciones)
        Me.gbxSalud.Controls.Add(Me.btnBajaMedicamentos)
        Me.gbxSalud.Controls.Add(Me.txtVacunas)
        Me.gbxSalud.Controls.Add(Me.txtAlergias)
        Me.gbxSalud.Controls.Add(Me.txtOperaciones)
        Me.gbxSalud.Controls.Add(Me.txtMedicamentos)
        Me.gbxSalud.Controls.Add(Me.btnAltaVacunas)
        Me.gbxSalud.Controls.Add(Me.btnAltaAlergias)
        Me.gbxSalud.Controls.Add(Me.btnAltaOperaciones)
        Me.gbxSalud.Controls.Add(Me.btnAltaMedicamentos)
        Me.gbxSalud.Controls.Add(Me.ltbVacunas)
        Me.gbxSalud.Controls.Add(Me.ltbAlergias)
        Me.gbxSalud.Controls.Add(Me.ltbOperaciones)
        Me.gbxSalud.Controls.Add(Me.ltbMedicamentos)
        Me.gbxSalud.Controls.Add(Me.lblVacunas)
        Me.gbxSalud.Controls.Add(Me.lblAlergias)
        Me.gbxSalud.Controls.Add(Me.lblOperaciones)
        Me.gbxSalud.Controls.Add(Me.lblMedicamentos)
        Me.gbxSalud.Controls.Add(Me.dtpVencimientoFichaMedica)
        Me.gbxSalud.Controls.Add(Me.lblVencimientoFichaMedica)
        Me.gbxSalud.Location = New System.Drawing.Point(12, 12)
        Me.gbxSalud.Name = "gbxSalud"
        Me.gbxSalud.Size = New System.Drawing.Size(680, 201)
        Me.gbxSalud.TabIndex = 70
        Me.gbxSalud.TabStop = False
        Me.gbxSalud.Text = "Salud"
        '
        'btnBajaVacunas
        '
        Me.btnBajaVacunas.Location = New System.Drawing.Point(649, 97)
        Me.btnBajaVacunas.Name = "btnBajaVacunas"
        Me.btnBajaVacunas.Size = New System.Drawing.Size(21, 23)
        Me.btnBajaVacunas.TabIndex = 33
        Me.btnBajaVacunas.Text = "-"
        Me.btnBajaVacunas.UseVisualStyleBackColor = True
        '
        'btnBajaAlergias
        '
        Me.btnBajaAlergias.Location = New System.Drawing.Point(483, 100)
        Me.btnBajaAlergias.Name = "btnBajaAlergias"
        Me.btnBajaAlergias.Size = New System.Drawing.Size(21, 23)
        Me.btnBajaAlergias.TabIndex = 32
        Me.btnBajaAlergias.Text = "-"
        Me.btnBajaAlergias.UseVisualStyleBackColor = True
        '
        'btnBajaOperaciones
        '
        Me.btnBajaOperaciones.Location = New System.Drawing.Point(294, 97)
        Me.btnBajaOperaciones.Name = "btnBajaOperaciones"
        Me.btnBajaOperaciones.Size = New System.Drawing.Size(21, 23)
        Me.btnBajaOperaciones.TabIndex = 31
        Me.btnBajaOperaciones.Text = "-"
        Me.btnBajaOperaciones.UseVisualStyleBackColor = True
        '
        'btnBajaMedicamentos
        '
        Me.btnBajaMedicamentos.Location = New System.Drawing.Point(109, 97)
        Me.btnBajaMedicamentos.Name = "btnBajaMedicamentos"
        Me.btnBajaMedicamentos.Size = New System.Drawing.Size(21, 23)
        Me.btnBajaMedicamentos.TabIndex = 30
        Me.btnBajaMedicamentos.Text = "-"
        Me.btnBajaMedicamentos.UseVisualStyleBackColor = True
        '
        'txtVacunas
        '
        Me.txtVacunas.Location = New System.Drawing.Point(546, 74)
        Me.txtVacunas.Name = "txtVacunas"
        Me.txtVacunas.Size = New System.Drawing.Size(97, 20)
        Me.txtVacunas.TabIndex = 29
        '
        'txtAlergias
        '
        Me.txtAlergias.Location = New System.Drawing.Point(380, 74)
        Me.txtAlergias.Name = "txtAlergias"
        Me.txtAlergias.Size = New System.Drawing.Size(97, 20)
        Me.txtAlergias.TabIndex = 28
        '
        'txtOperaciones
        '
        Me.txtOperaciones.Location = New System.Drawing.Point(191, 74)
        Me.txtOperaciones.Name = "txtOperaciones"
        Me.txtOperaciones.Size = New System.Drawing.Size(97, 20)
        Me.txtOperaciones.TabIndex = 27
        '
        'txtMedicamentos
        '
        Me.txtMedicamentos.Location = New System.Drawing.Point(6, 74)
        Me.txtMedicamentos.Name = "txtMedicamentos"
        Me.txtMedicamentos.Size = New System.Drawing.Size(97, 20)
        Me.txtMedicamentos.TabIndex = 26
        '
        'btnAltaVacunas
        '
        Me.btnAltaVacunas.Location = New System.Drawing.Point(649, 71)
        Me.btnAltaVacunas.Name = "btnAltaVacunas"
        Me.btnAltaVacunas.Size = New System.Drawing.Size(21, 23)
        Me.btnAltaVacunas.TabIndex = 25
        Me.btnAltaVacunas.Text = "+"
        Me.btnAltaVacunas.UseVisualStyleBackColor = True
        '
        'btnAltaAlergias
        '
        Me.btnAltaAlergias.Location = New System.Drawing.Point(483, 71)
        Me.btnAltaAlergias.Name = "btnAltaAlergias"
        Me.btnAltaAlergias.Size = New System.Drawing.Size(21, 23)
        Me.btnAltaAlergias.TabIndex = 24
        Me.btnAltaAlergias.Text = "+"
        Me.btnAltaAlergias.UseVisualStyleBackColor = True
        '
        'btnAltaOperaciones
        '
        Me.btnAltaOperaciones.Location = New System.Drawing.Point(294, 71)
        Me.btnAltaOperaciones.Name = "btnAltaOperaciones"
        Me.btnAltaOperaciones.Size = New System.Drawing.Size(21, 23)
        Me.btnAltaOperaciones.TabIndex = 23
        Me.btnAltaOperaciones.Text = "+"
        Me.btnAltaOperaciones.UseVisualStyleBackColor = True
        '
        'btnAltaMedicamentos
        '
        Me.btnAltaMedicamentos.Location = New System.Drawing.Point(109, 71)
        Me.btnAltaMedicamentos.Name = "btnAltaMedicamentos"
        Me.btnAltaMedicamentos.Size = New System.Drawing.Size(21, 23)
        Me.btnAltaMedicamentos.TabIndex = 22
        Me.btnAltaMedicamentos.Text = "+"
        Me.btnAltaMedicamentos.UseVisualStyleBackColor = True
        '
        'ltbVacunas
        '
        Me.ltbVacunas.FormattingEnabled = True
        Me.ltbVacunas.Location = New System.Drawing.Point(546, 97)
        Me.ltbVacunas.Name = "ltbVacunas"
        Me.ltbVacunas.Size = New System.Drawing.Size(97, 95)
        Me.ltbVacunas.TabIndex = 21
        '
        'ltbAlergias
        '
        Me.ltbAlergias.FormattingEnabled = True
        Me.ltbAlergias.Location = New System.Drawing.Point(380, 97)
        Me.ltbAlergias.Name = "ltbAlergias"
        Me.ltbAlergias.Size = New System.Drawing.Size(97, 95)
        Me.ltbAlergias.TabIndex = 20
        '
        'ltbOperaciones
        '
        Me.ltbOperaciones.FormattingEnabled = True
        Me.ltbOperaciones.Location = New System.Drawing.Point(191, 97)
        Me.ltbOperaciones.Name = "ltbOperaciones"
        Me.ltbOperaciones.Size = New System.Drawing.Size(97, 95)
        Me.ltbOperaciones.TabIndex = 19
        '
        'ltbMedicamentos
        '
        Me.ltbMedicamentos.FormattingEnabled = True
        Me.ltbMedicamentos.Location = New System.Drawing.Point(6, 97)
        Me.ltbMedicamentos.Name = "ltbMedicamentos"
        Me.ltbMedicamentos.Size = New System.Drawing.Size(97, 95)
        Me.ltbMedicamentos.TabIndex = 18
        '
        'lblVacunas
        '
        Me.lblVacunas.AutoSize = True
        Me.lblVacunas.Location = New System.Drawing.Point(543, 58)
        Me.lblVacunas.Name = "lblVacunas"
        Me.lblVacunas.Size = New System.Drawing.Size(49, 13)
        Me.lblVacunas.TabIndex = 8
        Me.lblVacunas.Text = "Vacunas"
        '
        'lblAlergias
        '
        Me.lblAlergias.AutoSize = True
        Me.lblAlergias.Location = New System.Drawing.Point(377, 58)
        Me.lblAlergias.Name = "lblAlergias"
        Me.lblAlergias.Size = New System.Drawing.Size(44, 13)
        Me.lblAlergias.TabIndex = 6
        Me.lblAlergias.Text = "Alergias"
        '
        'lblOperaciones
        '
        Me.lblOperaciones.AutoSize = True
        Me.lblOperaciones.Location = New System.Drawing.Point(188, 58)
        Me.lblOperaciones.Name = "lblOperaciones"
        Me.lblOperaciones.Size = New System.Drawing.Size(67, 13)
        Me.lblOperaciones.TabIndex = 5
        Me.lblOperaciones.Text = "Operaciones"
        '
        'lblMedicamentos
        '
        Me.lblMedicamentos.AutoSize = True
        Me.lblMedicamentos.Location = New System.Drawing.Point(3, 58)
        Me.lblMedicamentos.Name = "lblMedicamentos"
        Me.lblMedicamentos.Size = New System.Drawing.Size(76, 13)
        Me.lblMedicamentos.TabIndex = 3
        Me.lblMedicamentos.Text = "Medicamentos"
        '
        'dtpVencimientoFichaMedica
        '
        Me.dtpVencimientoFichaMedica.Location = New System.Drawing.Point(6, 32)
        Me.dtpVencimientoFichaMedica.Name = "dtpVencimientoFichaMedica"
        Me.dtpVencimientoFichaMedica.Size = New System.Drawing.Size(200, 20)
        Me.dtpVencimientoFichaMedica.TabIndex = 1
        '
        'lblVencimientoFichaMedica
        '
        Me.lblVencimientoFichaMedica.AutoSize = True
        Me.lblVencimientoFichaMedica.Location = New System.Drawing.Point(6, 16)
        Me.lblVencimientoFichaMedica.Name = "lblVencimientoFichaMedica"
        Me.lblVencimientoFichaMedica.Size = New System.Drawing.Size(147, 13)
        Me.lblVencimientoFichaMedica.TabIndex = 0
        Me.lblVencimientoFichaMedica.Text = "Vencimiento de Ficha Médica"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(610, 319)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 30)
        Me.btnGuardar.TabIndex = 73
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.SIGEN.My.Resources.Resources.back
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(514, 319)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(90, 30)
        Me.btnAtras.TabIndex = 72
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(528, 262)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(164, 20)
        Me.txtPosicion.TabIndex = 78
        '
        'lblPosicion
        '
        Me.lblPosicion.AutoSize = True
        Me.lblPosicion.Location = New System.Drawing.Point(441, 265)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(82, 13)
        Me.lblPosicion.TabIndex = 77
        Me.lblPosicion.Text = "Posición/Modo:"
        '
        'FrmModificarDeportistaDos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 361)
        Me.Controls.Add(Me.txtPosicion)
        Me.Controls.Add(Me.lblPosicion)
        Me.Controls.Add(Me.cmbDeporte)
        Me.Controls.Add(Me.lblDeporte)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.gbxDatosFisicos)
        Me.Controls.Add(Me.gbxSalud)
        Me.Name = "FrmModificarDeportistaDos"
        Me.Text = "Modificar Deportista"
        Me.gbxDatosFisicos.ResumeLayout(False)
        Me.gbxDatosFisicos.PerformLayout()
        Me.gbxSalud.ResumeLayout(False)
        Me.gbxSalud.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDeporte As System.Windows.Forms.ComboBox
    Friend WithEvents lblDeporte As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents gbxDatosFisicos As System.Windows.Forms.GroupBox
    Friend WithEvents lblSomatotipo As System.Windows.Forms.Label
    Friend WithEvents cmbSomatotipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents gbxSalud As System.Windows.Forms.GroupBox
    Friend WithEvents btnBajaAlergias As System.Windows.Forms.Button
    Friend WithEvents btnBajaOperaciones As System.Windows.Forms.Button
    Friend WithEvents btnBajaMedicamentos As System.Windows.Forms.Button
    Friend WithEvents txtVacunas As System.Windows.Forms.TextBox
    Friend WithEvents txtAlergias As System.Windows.Forms.TextBox
    Friend WithEvents txtOperaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtMedicamentos As System.Windows.Forms.TextBox
    Friend WithEvents btnAltaVacunas As System.Windows.Forms.Button
    Friend WithEvents btnAltaAlergias As System.Windows.Forms.Button
    Friend WithEvents btnAltaOperaciones As System.Windows.Forms.Button
    Friend WithEvents btnAltaMedicamentos As System.Windows.Forms.Button
    Friend WithEvents ltbVacunas As System.Windows.Forms.ListBox
    Friend WithEvents ltbAlergias As System.Windows.Forms.ListBox
    Friend WithEvents ltbOperaciones As System.Windows.Forms.ListBox
    Friend WithEvents ltbMedicamentos As System.Windows.Forms.ListBox
    Friend WithEvents lblVacunas As System.Windows.Forms.Label
    Friend WithEvents lblAlergias As System.Windows.Forms.Label
    Friend WithEvents lblOperaciones As System.Windows.Forms.Label
    Friend WithEvents lblMedicamentos As System.Windows.Forms.Label
    Friend WithEvents dtpVencimientoFichaMedica As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVencimientoFichaMedica As System.Windows.Forms.Label
    Friend WithEvents btnBajaVacunas As System.Windows.Forms.Button
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents cmbCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents txtPosicion As System.Windows.Forms.TextBox
    Friend WithEvents lblPosicion As System.Windows.Forms.Label
End Class
