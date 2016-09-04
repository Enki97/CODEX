<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaEjercicio
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
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtURLVideo = New System.Windows.Forms.TextBox
        Me.lblURLVideo = New System.Windows.Forms.Label
        Me.txtFotoURL = New System.Windows.Forms.TextBox
        Me.lblFotoURL = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblGruposMusculares = New System.Windows.Forms.Label
        Me.lstGruposMusculares = New System.Windows.Forms.ListBox
        Me.lblEjercita = New System.Windows.Forms.Label
        Me.cmbGrupoMuscular = New System.Windows.Forms.ComboBox
        Me.btnAgregarMusculo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(15, 100)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(457, 130)
        Me.rtbDescripcion.TabIndex = 4
        Me.rtbDescripcion.Text = ""
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 84)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 14
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(65, 6)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(407, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre:"
        '
        'txtURLVideo
        '
        Me.txtURLVideo.Location = New System.Drawing.Point(95, 61)
        Me.txtURLVideo.Name = "txtURLVideo"
        Me.txtURLVideo.Size = New System.Drawing.Size(377, 20)
        Me.txtURLVideo.TabIndex = 3
        '
        'lblURLVideo
        '
        Me.lblURLVideo.AutoSize = True
        Me.lblURLVideo.Location = New System.Drawing.Point(12, 64)
        Me.lblURLVideo.Name = "lblURLVideo"
        Me.lblURLVideo.Size = New System.Drawing.Size(77, 13)
        Me.lblURLVideo.TabIndex = 10
        Me.lblURLVideo.Text = "URL de Video:"
        '
        'txtFotoURL
        '
        Me.txtFotoURL.Location = New System.Drawing.Point(74, 32)
        Me.txtFotoURL.Name = "txtFotoURL"
        Me.txtFotoURL.Size = New System.Drawing.Size(398, 20)
        Me.txtFotoURL.TabIndex = 2
        '
        'lblFotoURL
        '
        Me.lblFotoURL.AutoSize = True
        Me.lblFotoURL.Location = New System.Drawing.Point(12, 35)
        Me.lblFotoURL.Name = "lblFotoURL"
        Me.lblFotoURL.Size = New System.Drawing.Size(56, 13)
        Me.lblFotoURL.TabIndex = 65
        Me.lblFotoURL.Text = "Foto URL:"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(256, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 8
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
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblGruposMusculares
        '
        Me.lblGruposMusculares.AutoSize = True
        Me.lblGruposMusculares.Location = New System.Drawing.Point(15, 237)
        Me.lblGruposMusculares.Name = "lblGruposMusculares"
        Me.lblGruposMusculares.Size = New System.Drawing.Size(101, 13)
        Me.lblGruposMusculares.TabIndex = 69
        Me.lblGruposMusculares.Text = "Grupos Musculares:"
        '
        'lstGruposMusculares
        '
        Me.lstGruposMusculares.FormattingEnabled = True
        Me.lstGruposMusculares.Location = New System.Drawing.Point(18, 253)
        Me.lstGruposMusculares.Name = "lstGruposMusculares"
        Me.lstGruposMusculares.Size = New System.Drawing.Size(252, 108)
        Me.lstGruposMusculares.TabIndex = 70
        '
        'lblEjercita
        '
        Me.lblEjercita.AutoSize = True
        Me.lblEjercita.Location = New System.Drawing.Point(277, 253)
        Me.lblEjercita.Name = "lblEjercita"
        Me.lblEjercita.Size = New System.Drawing.Size(191, 26)
        Me.lblEjercita.TabIndex = 71
        Me.lblEjercita.Text = "Seleccione los Grupos Musculares que" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ejercita:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbGrupoMuscular
        '
        Me.cmbGrupoMuscular.FormattingEnabled = True
        Me.cmbGrupoMuscular.Location = New System.Drawing.Point(277, 283)
        Me.cmbGrupoMuscular.Name = "cmbGrupoMuscular"
        Me.cmbGrupoMuscular.Size = New System.Drawing.Size(191, 21)
        Me.cmbGrupoMuscular.TabIndex = 5
        '
        'btnAgregarMusculo
        '
        Me.btnAgregarMusculo.Location = New System.Drawing.Point(277, 311)
        Me.btnAgregarMusculo.Name = "btnAgregarMusculo"
        Me.btnAgregarMusculo.Size = New System.Drawing.Size(191, 23)
        Me.btnAgregarMusculo.TabIndex = 6
        Me.btnAgregarMusculo.Text = "Agregar"
        Me.btnAgregarMusculo.UseVisualStyleBackColor = True
        '
        'FrmAltaEjercicio
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.btnAgregarMusculo)
        Me.Controls.Add(Me.cmbGrupoMuscular)
        Me.Controls.Add(Me.lblEjercita)
        Me.Controls.Add(Me.lstGruposMusculares)
        Me.Controls.Add(Me.lblGruposMusculares)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtFotoURL)
        Me.Controls.Add(Me.lblFotoURL)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtURLVideo)
        Me.Controls.Add(Me.lblURLVideo)
        Me.Name = "FrmAltaEjercicio"
        Me.Text = "Nuevo Ejercicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtURLVideo As System.Windows.Forms.TextBox
    Friend WithEvents lblURLVideo As System.Windows.Forms.Label
    Friend WithEvents txtFotoURL As System.Windows.Forms.TextBox
    Friend WithEvents lblFotoURL As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblGruposMusculares As System.Windows.Forms.Label
    Friend WithEvents lstGruposMusculares As System.Windows.Forms.ListBox
    Friend WithEvents lblEjercita As System.Windows.Forms.Label
    Friend WithEvents cmbGrupoMuscular As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarMusculo As System.Windows.Forms.Button
End Class
