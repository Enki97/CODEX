<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaEquipo
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
        Me.cmbDeportistas = New System.Windows.Forms.ComboBox
        Me.lblCategoria = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.lblDeportista = New System.Windows.Forms.Label
        Me.lstDeportista = New System.Windows.Forms.ListBox
        Me.ckbEsSeleccion = New System.Windows.Forms.CheckBox
        Me.lblEsSeleccion = New System.Windows.Forms.Label
        Me.lblSeleccioneDeportista = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtCategoria = New System.Windows.Forms.TextBox
        Me.lblActividad = New System.Windows.Forms.Label
        Me.cmbActividad = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmbDeportistas
        '
        Me.cmbDeportistas.FormattingEnabled = True
        Me.cmbDeportistas.Location = New System.Drawing.Point(270, 148)
        Me.cmbDeportistas.Name = "cmbDeportistas"
        Me.cmbDeportistas.Size = New System.Drawing.Size(202, 21)
        Me.cmbDeportistas.TabIndex = 90
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(12, 9)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(57, 13)
        Me.lblCategoria.TabIndex = 88
        Me.lblCategoria.Text = "Categoría:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(270, 175)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(202, 23)
        Me.btnAgregar.TabIndex = 87
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblDeportista
        '
        Me.lblDeportista.AutoSize = True
        Me.lblDeportista.Location = New System.Drawing.Point(12, 111)
        Me.lblDeportista.Name = "lblDeportista"
        Me.lblDeportista.Size = New System.Drawing.Size(63, 13)
        Me.lblDeportista.TabIndex = 86
        Me.lblDeportista.Text = "Deportistas:"
        '
        'lstDeportista
        '
        Me.lstDeportista.FormattingEnabled = True
        Me.lstDeportista.Location = New System.Drawing.Point(15, 128)
        Me.lstDeportista.Name = "lstDeportista"
        Me.lstDeportista.Size = New System.Drawing.Size(249, 147)
        Me.lstDeportista.TabIndex = 92
        '
        'ckbEsSeleccion
        '
        Me.ckbEsSeleccion.AutoSize = True
        Me.ckbEsSeleccion.Location = New System.Drawing.Point(15, 91)
        Me.ckbEsSeleccion.Name = "ckbEsSeleccion"
        Me.ckbEsSeleccion.Size = New System.Drawing.Size(73, 17)
        Me.ckbEsSeleccion.TabIndex = 93
        Me.ckbEsSeleccion.Text = "Selección"
        Me.ckbEsSeleccion.UseVisualStyleBackColor = True
        '
        'lblEsSeleccion
        '
        Me.lblEsSeleccion.AutoSize = True
        Me.lblEsSeleccion.Location = New System.Drawing.Point(12, 75)
        Me.lblEsSeleccion.Name = "lblEsSeleccion"
        Me.lblEsSeleccion.Size = New System.Drawing.Size(196, 13)
        Me.lblEsSeleccion.TabIndex = 94
        Me.lblEsSeleccion.Text = "Indique si este equipo es una selección:"
        '
        'lblSeleccioneDeportista
        '
        Me.lblSeleccioneDeportista.AutoSize = True
        Me.lblSeleccioneDeportista.Location = New System.Drawing.Point(270, 128)
        Me.lblSeleccioneDeportista.Name = "lblSeleccioneDeportista"
        Me.lblSeleccioneDeportista.Size = New System.Drawing.Size(175, 13)
        Me.lblSeleccioneDeportista.TabIndex = 95
        Me.lblSeleccioneDeportista.Text = "Seleccione un deportista a agregar:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(256, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 97
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(367, 369)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardar.TabIndex = 96
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(75, 6)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(397, 20)
        Me.txtCategoria.TabIndex = 98
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Location = New System.Drawing.Point(12, 35)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(97, 13)
        Me.lblActividad.TabIndex = 99
        Me.lblActividad.Text = "Actividad/Deporte:"
        '
        'cmbActividad
        '
        Me.cmbActividad.FormattingEnabled = True
        Me.cmbActividad.Location = New System.Drawing.Point(15, 51)
        Me.cmbActividad.Name = "cmbActividad"
        Me.cmbActividad.Size = New System.Drawing.Size(457, 21)
        Me.cmbActividad.TabIndex = 100
        '
        'FrmAltaEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.cmbActividad)
        Me.Controls.Add(Me.lblActividad)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblSeleccioneDeportista)
        Me.Controls.Add(Me.lblEsSeleccion)
        Me.Controls.Add(Me.ckbEsSeleccion)
        Me.Controls.Add(Me.lstDeportista)
        Me.Controls.Add(Me.cmbDeportistas)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblDeportista)
        Me.Name = "FrmAltaEquipo"
        Me.Text = "Nuevo Equipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDeportistas As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblDeportista As System.Windows.Forms.Label
    Friend WithEvents lstDeportista As System.Windows.Forms.ListBox
    Friend WithEvents ckbEsSeleccion As System.Windows.Forms.CheckBox
    Friend WithEvents lblEsSeleccion As System.Windows.Forms.Label
    Friend WithEvents lblSeleccioneDeportista As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents lblActividad As System.Windows.Forms.Label
    Friend WithEvents cmbActividad As System.Windows.Forms.ComboBox
End Class
