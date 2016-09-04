<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCombos
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
        Me.btnAgregarEjercicio = New System.Windows.Forms.Button
        Me.lblSeleccioneEjercicio = New System.Windows.Forms.Label
        Me.cmbAgregar = New System.Windows.Forms.ComboBox
        Me.lstEjercicios = New System.Windows.Forms.ListBox
        Me.lblEjercicios = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.rtxDescripción = New System.Windows.Forms.RichTextBox
        Me.lblDescripción = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnAgregarEjercicio
        '
        Me.btnAgregarEjercicio.Location = New System.Drawing.Point(291, 231)
        Me.btnAgregarEjercicio.Name = "btnAgregarEjercicio"
        Me.btnAgregarEjercicio.Size = New System.Drawing.Size(183, 23)
        Me.btnAgregarEjercicio.TabIndex = 25
        Me.btnAgregarEjercicio.Text = "Agregar"
        Me.btnAgregarEjercicio.UseVisualStyleBackColor = True
        '
        'lblSeleccioneEjercicio
        '
        Me.lblSeleccioneEjercicio.AutoSize = True
        Me.lblSeleccioneEjercicio.Location = New System.Drawing.Point(290, 187)
        Me.lblSeleccioneEjercicio.Name = "lblSeleccioneEjercicio"
        Me.lblSeleccioneEjercicio.Size = New System.Drawing.Size(164, 13)
        Me.lblSeleccioneEjercicio.TabIndex = 24
        Me.lblSeleccioneEjercicio.Text = "Seleccione el ejercicio a agregar:"
        '
        'cmbAgregar
        '
        Me.cmbAgregar.FormattingEnabled = True
        Me.cmbAgregar.Location = New System.Drawing.Point(290, 203)
        Me.cmbAgregar.Name = "cmbAgregar"
        Me.cmbAgregar.Size = New System.Drawing.Size(182, 21)
        Me.cmbAgregar.TabIndex = 23
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.Location = New System.Drawing.Point(14, 187)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(270, 173)
        Me.lstEjercicios.TabIndex = 22
        '
        'lblEjercicios
        '
        Me.lblEjercicios.AutoSize = True
        Me.lblEjercicios.Location = New System.Drawing.Point(11, 171)
        Me.lblEjercicios.Name = "lblEjercicios"
        Me.lblEjercicios.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicios.TabIndex = 21
        Me.lblEjercicios.Text = "Ejercicios:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SIGEN.My.Resources.Resources.cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(258, 372)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 30)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SIGEN.My.Resources.Resources.ok1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(369, 372)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'rtxDescripción
        '
        Me.rtxDescripción.Location = New System.Drawing.Point(14, 54)
        Me.rtxDescripción.Name = "rtxDescripción"
        Me.rtxDescripción.Size = New System.Drawing.Size(460, 114)
        Me.rtxDescripción.TabIndex = 18
        Me.rtxDescripción.Text = ""
        '
        'lblDescripción
        '
        Me.lblDescripción.AutoSize = True
        Me.lblDescripción.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripción.Location = New System.Drawing.Point(14, 38)
        Me.lblDescripción.Name = "lblDescripción"
        Me.lblDescripción.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripción.TabIndex = 17
        Me.lblDescripción.Text = "Descripción:"
        Me.lblDescripción.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(64, 9)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(410, 20)
        Me.txtNombre.TabIndex = 16
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(14, 12)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(291, 260)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(183, 23)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmModificarCombos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregarEjercicio)
        Me.Controls.Add(Me.lblSeleccioneEjercicio)
        Me.Controls.Add(Me.cmbAgregar)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.lblEjercicios)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.rtxDescripción)
        Me.Controls.Add(Me.lblDescripción)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmModificarCombos"
        Me.Text = "Modificar Combo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarEjercicio As System.Windows.Forms.Button
    Friend WithEvents lblSeleccioneEjercicio As System.Windows.Forms.Label
    Friend WithEvents cmbAgregar As System.Windows.Forms.ComboBox
    Friend WithEvents lstEjercicios As System.Windows.Forms.ListBox
    Friend WithEvents lblEjercicios As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents rtxDescripción As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDescripción As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
