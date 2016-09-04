<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaCombo
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
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.rtxDescripcion = New System.Windows.Forms.RichTextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.lblEjercicios = New System.Windows.Forms.Label
        Me.lstEjercicios = New System.Windows.Forms.ListBox
        Me.cmbAgregar = New System.Windows.Forms.ComboBox
        Me.lblSeleccioneEjercicio = New System.Windows.Forms.Label
        Me.btnAgregarEjercicio = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(62, 6)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(410, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 35)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Text = "Descripción:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rtxDescripcion
        '
        Me.rtxDescripcion.Location = New System.Drawing.Point(12, 51)
        Me.rtxDescripcion.Name = "rtxDescripcion"
        Me.rtxDescripcion.Size = New System.Drawing.Size(460, 114)
        Me.rtxDescripcion.TabIndex = 2
        Me.rtxDescripcion.Text = ""
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(367, 369)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(256, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblEjercicios
        '
        Me.lblEjercicios.AutoSize = True
        Me.lblEjercicios.Location = New System.Drawing.Point(9, 168)
        Me.lblEjercicios.Name = "lblEjercicios"
        Me.lblEjercicios.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicios.TabIndex = 10
        Me.lblEjercicios.Text = "Ejercicios:"
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.Location = New System.Drawing.Point(12, 184)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(270, 173)
        Me.lstEjercicios.TabIndex = 3
        '
        'cmbAgregar
        '
        Me.cmbAgregar.FormattingEnabled = True
        Me.cmbAgregar.Location = New System.Drawing.Point(288, 200)
        Me.cmbAgregar.Name = "cmbAgregar"
        Me.cmbAgregar.Size = New System.Drawing.Size(184, 21)
        Me.cmbAgregar.TabIndex = 4
        '
        'lblSeleccioneEjercicio
        '
        Me.lblSeleccioneEjercicio.AutoSize = True
        Me.lblSeleccioneEjercicio.Location = New System.Drawing.Point(288, 184)
        Me.lblSeleccioneEjercicio.Name = "lblSeleccioneEjercicio"
        Me.lblSeleccioneEjercicio.Size = New System.Drawing.Size(164, 13)
        Me.lblSeleccioneEjercicio.TabIndex = 13
        Me.lblSeleccioneEjercicio.Text = "Seleccione el ejercicio a agregar:"
        '
        'btnAgregarEjercicio
        '
        Me.btnAgregarEjercicio.Location = New System.Drawing.Point(289, 228)
        Me.btnAgregarEjercicio.Name = "btnAgregarEjercicio"
        Me.btnAgregarEjercicio.Size = New System.Drawing.Size(183, 23)
        Me.btnAgregarEjercicio.TabIndex = 5
        Me.btnAgregarEjercicio.Text = "Agregar"
        Me.btnAgregarEjercicio.UseVisualStyleBackColor = True
        '
        'FrmAltaCombo
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.btnAgregarEjercicio)
        Me.Controls.Add(Me.lblSeleccioneEjercicio)
        Me.Controls.Add(Me.cmbAgregar)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.lblEjercicios)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.rtxDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmAltaCombo"
        Me.Text = "Nuevo Combo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents rtxDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblEjercicios As System.Windows.Forms.Label
    Friend WithEvents lstEjercicios As System.Windows.Forms.ListBox
    Friend WithEvents cmbAgregar As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccioneEjercicio As System.Windows.Forms.Label
    Friend WithEvents btnAgregarEjercicio As System.Windows.Forms.Button
End Class
